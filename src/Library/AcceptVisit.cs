using System;
namespace Library
{
    public class AcceptVisit : Visitor
    {

        public override void Visit(Node<object> node)
        {
            throw new NotImplementedException();
        }

        public override void Visit(Person person)
        {
            throw new NotImplementedException();
        }
    }
}