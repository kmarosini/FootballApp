using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ApiCollector
{
    public class PrepareForForm
    {
        public static List<SkupIgraca> favourites = new List<SkupIgraca>();
        public static List<SkupIgraca> protivnici = new List<SkupIgraca>();

        public static void InsertInList(SkupIgraca p)
        {
            if (favourites == null)
            {
                favourites = new List<SkupIgraca>();
            }
            favourites.Add(p);
        }
        public static async Task<List<Games.Root>> DohvatiIgraca()
        {
            if (SaverLoader.tim == null)
            {
                return new List<Games.Root>();
            }
            if (SaverLoader.Prvenstvo == "Muško")
            {
                string url = SaverLoader.tim.Fifa_code;
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(Collector.igraci + url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var emp = response.Content.ReadAsStringAsync();
                    List<Games.Root> myDeserializedClass = JsonConvert.DeserializeObject<List<Games.Root>>(await emp);
                    return myDeserializedClass;
                }
                return new List<Games.Root>();
            }
            else if (SaverLoader.Prvenstvo == "Žensko")
            {
                string url = SaverLoader.tim.Fifa_code;
                HttpClient client = new HttpClient();
                HttpResponseMessage response = client.GetAsync(Collector.igracice + url).Result;
                if (response.IsSuccessStatusCode)
                {
                    var emp = response.Content.ReadAsStringAsync();
                    List<Games.Root> myDeserializedClass = JsonConvert.DeserializeObject<List<Games.Root>>(await emp);
                    return myDeserializedClass;
                }
                return new List<Games.Root>();
            }
            return new List<Games.Root>();
        }
        public static async Task<List<ApiCollector.SkupIgraca>> DohvatiImenaIgraca()
        {
            List<Games.Root> list = await DohvatiIgraca();
            List<Games.StartingEleven> igraciPrva = list[0].home_team_statistics.starting_eleven;
            List<Games.Substitute> igraciDruga = list[0].home_team_statistics.substitutes;

            List<SkupIgraca> skupIgraca = new List<SkupIgraca>();
            igraciPrva.ForEach(x => skupIgraca.Add(x));
            igraciDruga.ForEach(y => skupIgraca.Add(y));

            return skupIgraca;
        }

        public static async Task<List<ApiCollector.Games.HomeTeamEvent>> DohvatiHomeTeamEvente()
        {
            List<ApiCollector.Games.Root> list = await DohvatiIgraca();
            List<ApiCollector.Games.HomeTeamEvent> homeTeam = new List<ApiCollector.Games.HomeTeamEvent>();

            List<Games.HomeTeamEvent> domaciTim = new List<Games.HomeTeamEvent>();


            list.ForEach(x => x.home_team_events.ForEach(y => homeTeam.Add(y)));

            homeTeam.ForEach(x => domaciTim.Add(x));


            return domaciTim;
        }

        public static async Task<List<ApiCollector.Games.AwayTeamEvent>> DohvatiAwayTeamEvente()
        {
            List<Games.Root> list = await DohvatiIgraca();
            List<Games.AwayTeamEvent> awayTeam = new List<Games.AwayTeamEvent>();

            List<Games.AwayTeamEvent> gostujuciTim = new List<Games.AwayTeamEvent>();


            list.ForEach(x => x.away_team_events.ForEach(y => awayTeam.Add(y)));

            awayTeam.ForEach(x => gostujuciTim.Add(x));


            return gostujuciTim;
        }
       
        public static async Task<List<SkupIgraca>> DohvatiStatistikuIgraca()
        {
            List<ApiCollector.Games.HomeTeamEvent> list = await DohvatiHomeTeamEvente();
            List<ApiCollector.Games.AwayTeamEvent> list2 = await DohvatiAwayTeamEvente();
            List<ApiCollector.SkupIgraca> listaIgraca = await DohvatiImenaIgraca();

            //List<Games.HomeTeamEvent> novaLista = new List<Games.HomeTeamEvent>();

            //cbRangLista.Items.Add(igrac.type_of_event);
            // moram proc po listi, nac koji je igrac te za svaki zeljeni event inkrementirati isti.

            foreach (var homeevent in list)
            {
                if (homeevent.type_of_event == "goal")
                {
                    if (listaIgraca.Exists(x => x.Name.Contains(homeevent.player)))
                    {
                        listaIgraca.Find(x => x.Name.Contains(homeevent.player)).GoalNumber++;
                    }
                }

                if (homeevent.type_of_event == "yellow-card")
                {
                    if (listaIgraca.Exists(x => x.Name.Contains(homeevent.player)))
                    {
                        listaIgraca.Find(x => x.Name.Contains(homeevent.player)).YellowCard++;
                    }
                }

            }

            foreach (var awayevent in list2)
            {
                if (awayevent.type_of_event == "goal")
                {
                    if (listaIgraca.Exists(x => x.Name.Contains(awayevent.player)))
                    {
                        listaIgraca.Find(x => x.Name.Contains(awayevent.player)).GoalNumber++;
                    }
                }

                if (awayevent.type_of_event == "yellow-card")
                {
                    if (listaIgraca.Exists(x => x.Name.Contains(awayevent.player)))
                    {
                        listaIgraca.Find(x => x.Name.Contains(awayevent.player)).YellowCard++;
                    }
                }
            }

            listaIgraca.Sort((x, y) => x.Name.CompareTo(y.Name));

            return listaIgraca;
        }


        public static async Task<Dictionary<string,string>> DohvatiProtivnike()
        {
            List<Games.Root> listaIgraca = await DohvatiIgraca();

            Dictionary<string,string> keyValuePairs = new Dictionary<string,string>();

            foreach (var x in listaIgraca)
            {
                if (x.home_team.code != SaverLoader.tim.Fifa_code)
                {
                    keyValuePairs.Add(x.home_team.code, x.home_team.country);
                }
                if (x.away_team.code != SaverLoader.tim.Fifa_code)
                {
                    keyValuePairs.Add(x.away_team.code, x.away_team.country);
                }
            }

            return keyValuePairs;
        }

    }



}

