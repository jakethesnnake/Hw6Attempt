using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ksu.Cis300.Graphs;

namespace Ksu.Cis300.NetworkFlow
{
    public struct FlowNetwork
    {

        public string SourceNode { get; }
        public string DestNode { get; }
        public DirectedGraph<string, int> Graph { get; }

        public FlowNetwork(string source, string dest)
        {
            DestNode = dest;
            SourceNode = source;
            Graph = new DirectedGraph<string, int>();   // new instance
            Graph.AddEdge(source, dest, 1);     // should NOT be 1.
        }

    }
}
