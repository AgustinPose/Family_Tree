using System;
using System.Collections.Generic;
using System.Text;
namespace Library
{
    public abstract class Visitor
    {
        public int Age;
        public Node <int> node;
        private List<int> lista;
        public abstract void Visit (Node<object> node);
        public abstract void Visit (Person person);
    }

}
