using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Models
{
    public class FavoritePokémons
    {
        public string name { get; set;}
        public string image { get; set;}
        public int id { get; set;}

        public FavoritePokémons(string name)
        {
            this.name = name;
        }

        public FavoritePokémons()
        {
        }
    }
}
