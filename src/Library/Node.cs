using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node<T> 
    {
        private T item;

        private List<Node<T>> children = new List<Node<T>>();

        public T Item {
            get
            {
                return this.item;
            }
        }

        public ReadOnlyCollection<Node<T>> Children {
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(T item)
        {
            this.item = item;
        }

        public void AddChildren(Node<T> n)
        {
            this.children.Add(n);
        }

        internal static void Accept(AcceptVisit acceptVisit)
        {
            throw new NotImplementedException();
        }
    }
}
