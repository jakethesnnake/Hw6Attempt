/* Queue.cs
 * Author: Rod Howell
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ksu.Cis300.LinkedListLibrary
{
    /// <summary>
    /// A simple generic queue implemented using a linked list.
    /// </summary>
    /// <typeparam name="T">The type of elements in the queue.</typeparam>
    public class Queue<T>
    {
        /// <summary>
        /// The cell at the front of the queue. If the queue is empty, may be any value.
        /// </summary>
        private LinkedListCell<T> _front = null;

        /// <summary>
        /// The cell at the back of the queue. If the queue is empty, may be any value.
        /// </summary>
        private LinkedListCell<T> _back = null;

        /// <summary>
        /// Gets the number of elements in the queue.
        /// </summary>
        public int Count { get; private set; }

        /// <summary>
        /// Places the given element at the back of the queue.
        /// </summary>
        /// <param name="x">The element to enqueue.</param>
        public void Enqueue(T x)
        {
            LinkedListCell<T> cell = new LinkedListCell<T>();
            if (Count == 0)
            {
                _front = cell;
            }
            else
            {
                _back.Next = cell;
            }
            _back = cell;
            cell.Data = x;
            Count++;
        }

        /// <summary>
        /// Retrieves the element at the front of the queue. If the queue is empty,
        /// throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element at the front of the queue.</returns>
        public T Peek()
        {
            if (Count == 0)
            {
                throw new InvalidOperationException();
            }
            return _front.Data;
        }

        /// <summary>
        /// Removes the element from the front of the queue. If the queue is empty,
        /// throws an InvalidOperationException.
        /// </summary>
        /// <returns>The element removed.</returns>
        public T Dequeue()
        {
            T x = Peek();
            _front = _front.Next;
            Count--;
            return x;
        }
    }
}
