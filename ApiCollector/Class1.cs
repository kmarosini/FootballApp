using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiCollector
{
    public class Collector
    {
        private static string zenskoPrvenstvo = "http://worldcup.sfg.io/teams/results";
        private static string muskoPrvenstvo = "http://world-cup-json-2018.herokuapp.com/teams/results";
        public static string igraci = $"http://world-cup-json-2018.herokuapp.com/matches/country?fifa_code=";
        public static string igracice = $"http://worldcup.sfg.io/matches/country?fifa_code=";


        // dohvacanje muskog prvenstva
        public static async Task<List<Tim>> DohvatiMuskoPrvenstvo()
        {

            if (SaverLoader.Prvenstvo == "Muško")
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(muskoPrvenstvo).Result;
                if (response.IsSuccessStatusCode)
                {
                    var emp = response.Content.ReadAsStringAsync();
                    List<Tim> myDeserializedClass = JsonConvert.DeserializeObject<List<Tim>>(await emp);
                    return myDeserializedClass;
                }
                return null;
            }
            else if (SaverLoader.Prvenstvo == "Žensko")
            {
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(zenskoPrvenstvo).Result;
                if (response.IsSuccessStatusCode)
                {
                    var emp = response.Content.ReadAsStringAsync();
                    List<Tim> myDeserializedClass = JsonConvert.DeserializeObject<List<Tim>>(await emp);
                    return myDeserializedClass;
                }
                return null;
            }
            return null;
        }

    }
}
