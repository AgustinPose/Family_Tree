using System;
namespace Library
{
    public class AcceptVisit : IVisitor
    {
        public void Visit(Node<object> node)
        {
            Node<object>.Accept(this);
        }

        public void Visit(Person person)
        {
            Person.Accept(this);
        }
    }
}