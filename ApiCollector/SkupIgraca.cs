using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCollector
{
    public class SkupIgraca
    {
        public string Name { get; set; }
        public bool Captain { get; set; }
        public int Shirt_number { get; set; }
        public string Position { get; set; }
        public int GoalNumber { get; set; }
        public int YellowCard { get; set; }
        public bool IsFavourite { get; set; }


        public override string ToString() => $"{Name} - {GoalNumber} - {YellowCard}";

    }
}
