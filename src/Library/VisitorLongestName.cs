using System;

namespace Library
{
    
    public class VisitorLongestName : Visitor
    {
        private string longestName = "";
        public string LongestName
        {
            get
            {
                return this.longestName;
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
            if(this.LongestName.Length < person.Name.Length)
            {
                this.longestName = person.Name;
            }
        }
    }


}