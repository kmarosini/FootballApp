using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiCollector
{
    public class SaverLoader
    {
        public const string DIR = @"C:\Users\programer10.UCIONE.002\Desktop\km\FootballApp";
        public const string PATH = DIR + @"\konfiguracija.txt";
        public const string FAV_DIR = @"C:\Users\programer10.UCIONE.002\Desktop\km\FootballApp";
        public const string FAV_PATH = FAV_DIR + @"\favourite_players.txt";
        private const char DEL = '|';

        public static string Prvenstvo;
        public static string Jezik;
        public static string fifa;
        public static string Resolution;
        public static Tim tim;

        // kreiranje config file-a
        public static bool CreateFile()
        {
            if (!File.Exists(PATH))
            {
                File.Create(PATH).Close();
                return false;
            }
            UcitajPostavke();
            return true;
        }

        public static bool NapraviOmiljeniIgraciFile()
        {
            if (!File.Exists(FAV_PATH))
            {
                File.Create(FAV_PATH).Close();
                return false;
            }
            return true;
        }

        public static void SpremiOmiljeneIgrace()
        {
            File.WriteAllText(FAV_PATH, JsonConvert.SerializeObject(ApiCollector.PrepareForForm.favourites));
        }

        // spremanje u datoteku
        public static void SpremiJezikIPrvenstvo()
        {
            string txt = $"{Prvenstvo}{DEL}{Jezik}{DEL}{tim?.Fifa_code}{DEL}{Resolution}";
            File.WriteAllText(PATH, txt);
        }

        // Loadanje settingsa
        public static void UcitajPostavke()
        {
            string lines = File.ReadAllText(PATH);
            string[] items = lines.Split('|');
            if (items.Count() == 1)
            {
                return;
            }
            Prvenstvo = items[0];
            Jezik = items[1];
            if (tim == null)
            {
                tim = new Tim();
            }
            tim.Fifa_code = items[2];
            Resolution = items[3];
        }

        public static void LoadFavoritIgrace()
        {

            string data = File.ReadAllText(FAV_PATH);
            if (String.IsNullOrEmpty(data) || data == "null")
            {
                ApiCollector.PrepareForForm.favourites = new List<SkupIgraca>();
                return;
            }
            ApiCollector.PrepareForForm.favourites = JsonConvert.DeserializeObject<List<SkupIgraca>>(data);

        }
    }
}
