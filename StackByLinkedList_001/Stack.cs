using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackByLinkedList_001
{
    [Serializable]
    public class Stack<T>
    {
        public Node<T> Head { get; set; }
        public Stack()
        {
            Head = null;
        }
        public void Push(T value)
        {
            Node<T> node = new Node<T>();
            node.Value = value;
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                node.NextNode = Head;
                Head = node;
            }
        }
        public T Pop()
        {
            if (Head == null)
            {
                throw new InvalidOperationException("Stack is empty!");
            }
            T result = Head.Value;
            Head = Head.NextNode;
            return result;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Node<T> node = Head;
            builder.Append($"#[{GetHashCode()}] ");
            while (node != null)
            {
                builder.Append(node.Value + " ");
                node = node.NextNode;
            }
            return builder.ToString();
        }
    }
}
