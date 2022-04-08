﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCollector
{
    public class Tim
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);   
        public int Id { get; set; }
        public string Country { get; set; }
        public object Alternate_name { get; set; }
        public string Fifa_code { get; set; }
        public int Group_id { get; set; }
        public string Group_letter { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Games_played { get; set; }
        public int Points { get; set; }
        public int Goals_for { get; set; }
        public int Goals_against { get; set; }
        public int Goal_differential { get; set; }

        public override string ToString() => $"{Country} ({Fifa_code})";
    }
}
