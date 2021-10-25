using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node("Pedro",70);
            Node n2 = new Node("Maria",60);
            Node n3 = new Node("Juana",50);
            Node n4 = new Node("Juan",40);
            Node n5 = new Node("Manuel",30);
            Node n6 = new Node("Martin",10);
            Node n7 = new Node("Gonzalo",10);

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
        }
    }
}
