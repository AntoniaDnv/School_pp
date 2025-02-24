using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList_introduction
{
    public class LinkedList
    {
        private class Node 
        {
            private object element;
            private Node? next;

            public Node(object element)
            {

            }
            public Node(object element, Node previousNode)
            {

            }

            public object Element
            {
                get => this.element;
                set
                {
                   this.element = value;
                }

            }
        }

    }
}
