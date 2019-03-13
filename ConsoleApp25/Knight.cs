using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Knight
    {
        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string Title { get; private set; }

        public Knight(string name, string birthtown, string title)
        {
            Name = name;
            Birthtown = birthtown;
            Title = title;
        }

        public string this[string FieldName]
        {
            get
            {
                if (FieldName == "Name")
                    return this.Name;
                if (FieldName == "Birth Town")
                    return this.Birthtown;
                if (FieldName == "Title")
                    return this.Title;
                return "Unknown";
            }
           

        }

        public override string ToString()
        {
            return $"Name:{Name}, Birth town:{Birthtown},Title:{Title}";
        }
    }
}
