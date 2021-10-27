using System;

namespace Library
{
    public class VisitorOldestKid : Visitor
    {
        private int oldestKid = 0;
        public int OldestKid
        {
            get
            {
                return this.oldestKid;
            }
        }
        public override void Visit(Node node)
        {
           foreach(Node item in node.Children)
           {
               item.Accept(this);
           }
        }

        public override void Visit(Person person)
        {
            if(this.OldestKid < person.Edad)
            {
                this.oldestKid = person.Edad;
            }
        }
    }

}