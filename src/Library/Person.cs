using System;
using System.Collections.Generic;
namespace Library
{
    public class Person
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        internal static void Accept(AcceptVisit acceptVisit)
        {
            Person.Accept(acceptVisit);
        }
    }
}