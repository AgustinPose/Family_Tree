using System;
using Library;

namespace Program
{
    class Program
    {
        Visitor acceptVisit = new AcceptVisit();

        static void Main(string[] args)
        {
            Node<int> n1 = new Node<int>(1);
            Node<int> n2 = new Node<int>(2);
            Node<int> n3 = new Node<int>(3);
            Node<int> n4 = new Node<int>(4);
            Node<int> n5 = new Node<int>(5);
            Node<int> n6 = new Node<int>(6);
            Node<int> n7 = new Node<int>(7);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí

        
            Node<Person> Jaime = new Node<Person>(new Person("Jaime", 54));
            Node<Person> Rodrigo = new Node<Person>(new Person("Rodrigo", 32));
            Node<Person> Ignacio = new Node<Person>(new Person("Ignacio", 19));
            Node<Person> Agustina = new Node<Person>(new Person("Agustina", 90));
            Node<Person> Pepe = new Node<Person>(new Person("Pepe", 67));
            Node<Person> Roberto = new Node<Person>(new Person("Roberto", 25));
            Node<Person> Sofia = new Node<Person>(new Person("Sofia", 19));
            Node<Person> Martina = new Node<Person>(new Person("Martina", 21));
            Jaime.AddChildren(Rodrigo);
            Rodrigo.AddChildren(Ignacio);
            Ignacio.AddChildren(Agustina);
            Agustina.AddChildren(Pepe);
            Pepe.AddChildren(Roberto);
            Roberto.AddChildren(Sofia);
            Sofia.AddChildren(Martina);

            var acceptVisit = new AcceptVisit();

            Jaime.Accept(acceptVisit); // Inicia la visita desde el nodo raíz

            int totalAge = acceptVisit.TotalAge;
            Console.WriteLine("Total Age: " + totalAge);


            //Jaime.Accept(acceptVisit);
            //Console.WriteLine("Total Age: " + acceptVisit.TotalAge);
        }
    }
}
