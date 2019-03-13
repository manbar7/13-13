using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Magician
    {
        public string Name { get; private set; }
        public string Birthtown { get; private set; }
        public string FavoriteSpell { get; private set; }

        public Magician(string name, string birthtown, string favoriteSpell)
        {
            Name = name;
            Birthtown = birthtown;
            FavoriteSpell = favoriteSpell;
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
                    return this.FavoriteSpell;
                return "Unknown";
            }


        }

        public override string ToString()
        {
            return $"Name:{Name}, Birth town:{Birthtown},Favorite Spell:{FavoriteSpell}";
        }
    }
}
