/* DirectedGraph.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.LinkedListLibrary;

namespace Ksu.Cis300.Graphs
{
    /// <summary>
    /// An implementation of a directed graph.
    /// </summary>
    /// <typeparam name="TNode">The type of the nodes.</typeparam>
    /// <typeparam name="TEdgeData">The type of the data associated with the edges.</typeparam>
    public class DirectedGraph<TNode, TEdgeData>
    {
        /// <summary>
        /// The adjaceny list for each node.
        /// </summary>
        private Dictionary<TNode, LinkedListCell<TNode>> _adjacencyLists = new Dictionary<TNode, LinkedListCell<TNode>>();

        /// <summary>
        /// The data associated with each edge.
        /// </summary>
        private Dictionary<Tuple<TNode, TNode>, TEdgeData> _edges = new Dictionary<Tuple<TNode, TNode>, TEdgeData>();

        /// <summary>
        /// Gets an enumerable collection of the nodes.
        /// </summary>
        public IEnumerable<TNode> Nodes => _adjacencyLists.Keys;

        /// <summary>
        /// Gets a tuple containing the given source node and destination node.
        /// If either node is null, throws an ArgumentNullException.
        /// If the graph already contains an edge from the given source node to the given destination node,
        /// throws an ArgumentException.
        /// </summary>
        /// <param name="source">The source node.</param>
        /// <param name="dest">The destination node.</param>
        /// <returns>A tuple containing source and dest.</returns>
        private static Tuple<TNode, TNode> GetTuple(TNode source, TNode dest)
        {
            if (source == null || dest == null)
            {
                throw new ArgumentNullException();
            }
            if (source.Equals(dest))
            {
                throw new Exception("The source and sink nodes must be different.");
            }
            return new Tuple<TNode, TNode>(source, dest);
        }

        /// <summary>
        /// Adds the new edge described by the given tuple and data item.
        /// </summary>
        /// <param name="edge">A tuple containing the source and destination nodes of the edge to be added.</param>
        /// <param name="data">The data associated with the edge.</param>
        private void AddNewEdge(Tuple<TNode, TNode> edge, TEdgeData data)
        {
            _edges.Add(edge, data);
            LinkedListCell<TNode> list;
            _adjacencyLists.TryGetValue(edge.Item1, out list);
            LinkedListCell<TNode> cell = new LinkedListCell<TNode>();
            cell.Data = edge.Item2;
            cell.Next = list;
            _adjacencyLists[edge.Item1] = cell;
            if (!_adjacencyLists.ContainsKey(edge.Item2))
            {
                _adjacencyLists.Add(edge.Item2, null);
            }
        }

        /// <summary>
        /// Adds the given edge with the given data value to the graph.
        /// If either node is null, throws an ArgumentNullException.
        /// If the nodes are equal or an edge already exists between them, 
        /// throws an ArgumentException.
        /// </summary>
        /// <param name="source">The source node for the edge.</param>
        /// <param name="dest">The destination node for the edge.</param>
        /// <param name="value">The value associated with the edge.</param>
        public void AddEdge(TNode source, TNode dest, TEdgeData value)
        {
            Tuple<TNode, TNode> edge = GetTuple(source, dest);
            if (_edges.ContainsKey(edge))
            {
                throw new Exception("An eddge can be included only once.");
            }
            AddNewEdge(edge, value);
        }

        /// <summary>
        /// Instructions --- WORK ON THIS
        /// </summary>
        /// <param name="freshNode"></param>
        public static void NewNode(TNode freshNode)
        {
            // add to dictionary
        }

        /// <summary>
        /// DATA ASSOCIATED WITH EDGE -- KEEP WORKING
        /// </summary>
        /// <param name="sourceNode"></param>
        /// <param name="destNode"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool TryGetDataItem(TNode sourceNode, TNode destNode, out TEdgeData data)
        {
            // similar to TryGetValue
        }

        /// <summary>
        /// Gets an enumerable collection of the outgoing edges from the given node.
        /// </summary>
        /// <param name="node">The node.</param>
        /// <returns>An enumerable collection of the outgoing edges from node.</returns>
        public IEnumerable<Edge<TNode, TEdgeData>> OutGoingEdges(TNode node)
        {
            return new AdjacencyList(this, node);
        }

        /// <summary>
        /// An enumerator for an adjacency list.
        /// </summary>
        public class AdjacencyListEnumerator : IEnumerator<Edge<TNode, TEdgeData>>
        {
            /// <summary>
            /// The start position in the enumeration.
            /// </summary>
            private LinkedListCell<TNode> _list = new LinkedListCell<TNode>();

            /// <summary>
            /// The current position in the enumeration.
            /// </summary>
            private LinkedListCell<TNode> _current;

            /// <summary>
            /// The directed graph containing the edges being enumerated.
            /// </summary>
            private DirectedGraph<TNode, TEdgeData> _graph;

            /// <summary>
            /// The source node.
            /// </summary>
            private TNode _source;

            /// <summary>
            /// Constructs an enumerator for the outgoing edges from the given source node.
            /// </summary>
            /// <param name="graph">The graph.</param>
            /// <param name="source">The source node for the outgoing edges.</param>
            public AdjacencyListEnumerator(DirectedGraph<TNode, TEdgeData> graph, TNode source)
            {
                _list.Next = graph._adjacencyLists[source];
                _current = _list;
                _graph = graph;
                _source = source;
            }

            /// <summary>
            /// Gets the edge at the current position. If the current position is either the starting position
            /// or the ending position, throws an InvalidOperationException.
            /// </summary>
            public Edge<TNode, TEdgeData> Current
            {
                get
                {
                    if (_current == _list || _current == null)
                    {
                        throw new InvalidOperationException();
                    }
                    return new Edge<TNode, TEdgeData>(_source, _current.Data, _graph._edges[new Tuple<TNode, TNode>(_source, _current.Data)]);
                }
            }

            /// <summary>
            /// Disposes of any unmanaged resources (there are none).
            /// </summary>
            public void Dispose()
            {

            }

            /// <summary>
            /// Gets the edge at the current position. If the current position is either the starting position
            /// or the ending position, throws an InvalidOperationException.
            /// </summary>
            object System.Collections.IEnumerator.Current
            {
                get { return Current; }
            }

            /// <summary>
            /// Advances the current position to the next position.
            /// </summary>
            /// <returns>Whether the resulting position is valid.</returns>
            public bool MoveNext()
            {
                if (_current == null)
                {
                    return false;
                }
                _current = _current.Next;
                return _current != null;
            }

            /// <summary>
            /// Not implemented.
            /// </summary>
            public void Reset()
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// An enumerable adjacency list.
        /// </summary>
        public class AdjacencyList : IEnumerable<Edge<TNode, TEdgeData>>
        {
            /// <summary>
            /// The graph.
            /// </summary>
            private DirectedGraph<TNode, TEdgeData> _graph;

            /// <summary>
            /// The source node for the edges.
            /// </summary>
            private TNode _source;

            /// <summary>
            /// Constructs a new AdjacencyList for the graph and node.
            /// </summary>
            /// <param name="graph">The graph.</param>
            /// <param name="source">The source node for the adjacency list.</param>
            public AdjacencyList(DirectedGraph<TNode, TEdgeData> graph, TNode source)
            {
                _graph = graph;
                _source = source;
            }

            /// <summary>
            /// Gets an enumerator for this adjacency list.
            /// </summary>
            /// <returns>The enumerator.</returns>
            public IEnumerator<Edge<TNode, TEdgeData>> GetEnumerator()
            {
                return new AdjacencyListEnumerator(_graph, _source);
            }

            /// <summary>
            /// Gets an enumerator for this adjacency list.
            /// </summary>
            /// <returns>The enumerator.</returns>
            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
