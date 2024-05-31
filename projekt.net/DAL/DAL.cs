
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;
using System.Drawing;


namespace DAL
{
    public class dal
    {
        
        public static int userinfoNum { get; set; } = 5;

       
        public static void CreateTextFile(string path)
        {
           
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }
        public static void CreateDirAndPath(string path)
        {
            Directory.CreateDirectory(path);
            CreateTextFile(@"preferences.txt");
            CreateTextFile(path + @"\favourites.txt");



        }
        public static bool CheckFileEmpty(string path)
        {
            string s = File.ReadAllText(path);
            if(s.Count() == 0)
            {
                return true;
            }
            return false;
        }
        public static void WriteFile(string preferences,string path)
        {
            File.WriteAllText(path, preferences);


        }
        
        public static string ReadFile(string path)
        { string s=File.ReadAllText(path);
            return s;
        }
        public static void AppendText(string str,string path)
        {
            File.AppendAllText(path,str);
        }
        public static string[] ReadPreferences(string path)
        {
            string[] result = new string[userinfoNum];
            string[] lines =File.ReadAllLines(path+@"\preferences.txt");
            
            foreach (string line in lines)
            {
                StringBuilder sb = new StringBuilder();
               string[] details= line.Split('#');
                result = details;
            }
            return result;
            
        }
        public static string[] ReadFileAsArray(string path, string file)
        {
            string[] result = new string[userinfoNum];
            string[] lines = File.ReadAllLines(path + file);

            foreach (string line in lines)
            {
                StringBuilder sb = new StringBuilder();
                string[] details = line.Split('#');
                result = details;
            }
            return result;
        }
        public static bool CheckFileExists(string path,string name)
        {
            return File.Exists(path+@"\"+name);
        }

       public static List<Representation> ReadJsonReps(string path)
        {

            List<Representation> result = JsonConvert.DeserializeObject<List<Representation>>(File.ReadAllText(path));
            
         

            return result;
        }
        public static List<MatchResult> ReadJsonResults(string path)
        {

            List<MatchResult> result = JsonConvert.DeserializeObject<List<MatchResult>>(File.ReadAllText(path));



            return result;
        }
        public static List<Match> ReadJsonMatch(string path)
        {

            //var result = DAL.Match.FromJson(File.ReadAllText(path));
            List<Match> result = JsonConvert.DeserializeObject<List<Match>>(File.ReadAllText(path), new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });



            path = null;
            return result;
        }
        
        //nisam naso link za skidanje fajla pa je sejvan u projektu al ovak bi radio async da sam uspio nac
        public static void SaveJsonFromWeb(string url,string fileName,string path)
        {
            WebClient client = new WebClient();
            client.BaseAddress = url;

            //ne radi treba dodat net.security i servicecertificatevalidationcallback idalje ne radi, jedini fix koji sam naso
            //ServicePointManager.ServiceCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

            // string json = client.DownloadString(url);
          
            var json =  client.DownloadString(url);
           
            bool x = File.Exists(path + @"\" + fileName+".json");
            
            if (!x)
            {
                File.Create(path + @"\" + fileName).Close();
            }
            
            File.WriteAllText(path + @"\" + fileName,json);
           

           


        }
       

        public static void DownloadFilesFromWeb(string url,string path)
        {

        }
    }
}
