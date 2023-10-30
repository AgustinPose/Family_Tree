using System;
using System.Text;
namespace Library
{
    public interface IVisitor
    {
        public void Visit (Node<object> node);
        public void Visit (Person person);
    }

}
