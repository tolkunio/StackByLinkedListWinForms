using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackByLinkedList_001
{
    [Serializable]
    public class Node<T>
    {
        public T Value;
        public Node<T> NextNode { get; set; }
        public Node()
        {
            NextNode = default(Node<T>);
        }
    }
}
