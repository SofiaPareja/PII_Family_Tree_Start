using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node 
    {
        private int number;

        private List<Node> children = new List<Node>();
        private Person person;
        
        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(string name, int edad)
        {
            this.person = new Person(name, edad);
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        public void Accept(Visitor visitor)
        {
             visitor.Visit(this);
        }
        
        

               
    }
}
