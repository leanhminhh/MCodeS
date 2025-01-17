using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.Models
{
    public class Game
    {
        public string Name { get; set; }
        public string Genre { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Genre: {Genre}, Year: {Year}, Description: {Description}";
        }
    }
}