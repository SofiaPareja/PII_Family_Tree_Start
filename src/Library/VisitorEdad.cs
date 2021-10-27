using System;

namespace Library
{
    public class VisitorEdad : Visitor 
    {
        private int sumaEdades = 0;
        public int SumaEdades
        {
            get
            {
                return this.sumaEdades;
            }
        }
       

        public override void Visit(Node node)
        {
            foreach (Node item in node.Children)
            {
                item.Accept(this);
                item.person.Accept(this);
            }
            
           // this.ContentBuilder.Append($"Total: ${sale.Total}");

        }
        public override void Visit(Person person)
        {
           this.sumaEdades += person.Edad;
        }

    }


}