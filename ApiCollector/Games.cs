using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCollector
{
    public class Games
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Weather
        {
            public string humidity { get; set; }
            public string temp_celsius { get; set; }
            public string temp_farenheit { get; set; }
            public string wind_speed { get; set; }
            public string description { get; set; }
        }

        public class HomeTeam
        {
            public string country { get; set; }
            public string code { get; set; }
            public int goals { get; set; }
            public int penalties { get; set; }
        }

        public class AwayTeam
        {
            public string country { get; set; }
            public string code { get; set; }
            public int goals { get; set; }
            public int penalties { get; set; }
        }

        public class HomeTeamEvent
        {
            public int id { get; set; }
            public string type_of_event { get; set; }
            public string player { get; set; }
            public string time { get; set; }
        }

        public class AwayTeamEvent
        {
            public int id { get; set; }
            public string type_of_event { get; set; }
            public string player { get; set; }
            public string time { get; set; }
        }

        public class StartingEleven : SkupIgraca
        {
            //public string name { get; set; }
            //public bool captain { get; set; }
            //public int shirt_number { get; set; }
            //public string position { get; set; }
        }

        public class Substitute : SkupIgraca
        {
            //public string name { get; set; }
            //public bool captain { get; set; }
            //public int shirt_number { get; set; }
            //public string position { get; set; }
        }


        public class HomeTeamStatistics
        {
            public string country { get; set; }
            public int attempts_on_goal { get; set; }
            public int on_target { get; set; }
            public int off_target { get; set; }
            public int blocked { get; set; }
            public int corners { get; set; }
            public int offsides { get; set; }
            public int ball_possession { get; set; }
            public int pass_accuracy { get; set; }
            public int num_passes { get; set; }
            public int passes_completed { get; set; }
            public int distance_covered { get; set; }
            public int tackles { get; set; }
            public int clearances { get; set; }
            public int yellow_cards { get; set; }
            public int red_cards { get; set; }
            public string tactics { get; set; }
            public List<StartingEleven> starting_eleven { get; set; }
            public List<Substitute> substitutes { get; set; }
        }

        public class AwayTeamStatistics
        {
            public string country { get; set; }
            public int attempts_on_goal { get; set; }
            public int on_target { get; set; }
            public int off_target { get; set; }
            public int blocked { get; set; }
            public int corners { get; set; }
            public int offsides { get; set; }
            public int ball_possession { get; set; }
            public int pass_accuracy { get; set; }
            public int num_passes { get; set; }
            public int passes_completed { get; set; }
            public int distance_covered { get; set; }
            public int tackles { get; set; }
            public int clearances { get; set; }
            public int yellow_cards { get; set; }
            public int red_cards { get; set; }
            public string tactics { get; set; }
            public List<StartingEleven> starting_eleven { get; set; }
            public List<Substitute> substitutes { get; set; }
        }

        public class Root
        {
            public string venue { get; set; }
            public string location { get; set; }
            public string status { get; set; }
            public string time { get; set; }
            public string fifa_id { get; set; }
            public Weather weather { get; set; }
            public string attendance { get; set; }
            public List<string> officials { get; set; }
            public string stage_name { get; set; }
            public string home_team_country { get; set; }
            public string away_team_country { get; set; }
            public DateTime datetime { get; set; }
            public string winner { get; set; }
            public string winner_code { get; set; }
            public HomeTeam home_team { get; set; }
            public AwayTeam away_team { get; set; }
            public List<HomeTeamEvent> home_team_events { get; set; }
            public List<AwayTeamEvent> away_team_events { get; set; }
            public HomeTeamStatistics home_team_statistics { get; set; }
            public AwayTeamStatistics away_team_statistics { get; set; }
        }
    }
}
