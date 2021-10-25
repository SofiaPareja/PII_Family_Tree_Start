using System;

namespace Library 
{
    public abstract class Visitor 
    {
        public abstract int SumaEdades(Node node);

        public abstract void Visit(Node node);
        public abstract void Visit(Person person);



    }
        
}