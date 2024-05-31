﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Representation
    {
        public int id { get; set; }
        public string country { get; set; }
        public string alt_name { get; set; }
        public string fifa_code { get; set; }
        public int group_id { get; set; }
        public char group_letter { get; set; }
        public int wins { get; set; }
        public int draws { get; set; }
        public int losses { get; set; }
        public int games_played { get; set; }
        public int points { get; set; }
        public int goals_for { get; set; }
        public int goals_against { get; set; }
        public int goal_differential { get; set; }

        
    }
}
