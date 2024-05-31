using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace DAL
{
   public class MatchResult
    {
        [JsonProperty("id")]
        public string ID { get; set; }

        [JsonProperty("country")]
        public string country { get; set; }
        [JsonProperty("alternate_name")]
        public string alt_name { get; set; }
        [JsonProperty("fifa_code")]
        public string code { get; set; }
        [JsonProperty("group_id")]
        public string group_id { get; set; }
        [JsonProperty("group_letter")]
        public string group_letter { get; set; }
        [JsonProperty("wins")]
        public string wins { get; set; }
        [JsonProperty("losses")]
        public string losses { get; set; }
        [JsonProperty("draws")]
        public string drwas { get; set; }
        [JsonProperty("points")]
        public string points { get; set; }
        [JsonProperty("goals_for")]
        public string goals_scored { get; set; }
        [JsonProperty("goals_against")]
        public string goals_taken { get; set; }
        [JsonProperty("goal_differential")]
        public string goal_dif { get; set; }
        

    }
}
