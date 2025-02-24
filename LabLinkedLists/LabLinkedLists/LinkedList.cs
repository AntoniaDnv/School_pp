using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LabLinkedLists
{
    public class LinkedList
    {
        private class Node
        {
            private object element;
            private Node next;

            public object Element
            {
                get { return element; }
                set { element = value; }
            }

            public Node Next 
            {
                get { return next; } 
                set {  next = value; }
            }
            public Node(object element, Node prevNode) 
            {
            
            }
        }
    }
}
