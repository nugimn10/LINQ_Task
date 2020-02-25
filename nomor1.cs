
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Linq_task
{
    public class Profile
    {
        public string Full_name { get; set; }
        public DateTime Birthday { get; set; }
        public List<object> Phones { get; set; }
    }

    public class UserArticles
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public Profile Profile { get; set; }
        public List<Articles> Articles { get; set; }
    }
    public class Articles
    {
        public int Id { get; set; }
        public  string Title { get; set; }
        public DateTime Date {get; set;}
    }



    public class LINQuery
    {
        static string json1 = @"C:\Users\Nugi\Linq_task\Database\nomor1.json";

        public static string NoPhone()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.Where(a => (a.Profile.Phones.Count ==0)).Select(a=>a.Profile.Full_name);

            return String.Join(',', hasil);
        
        }

        public static string HavingArticles()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.Where(a => (a.Articles.Count ==0) ).Select(a=>a.Profile.Full_name);

            return String.Join(',', hasil);
        
        }

        public static string ContainAnis()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.Where(a => a.Profile.Full_name.Contains("annis")).Select(a=>a.Profile.Full_name);

            return String.Join(',', hasil);
        
        }

        public static string HavingArticles2020()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.Where(a => a.Articles.Any(b => b.Date.Year == 2020)).Select(a=>a.Profile.Full_name);

            return String.Join(',', hasil);
        
        }

        public static string BornIn196()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.Where(a => (a.Profile.Birthday.Year == 1986)).Select(a=>a.Profile.Full_name);

            return String.Join(',', hasil);
        
        }

        public static string ContainTips()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.SelectMany(a => a.Articles.Where(a => a.Title.ToLower().Contains("tips")).Select(a => a.Title));
            return String.Join(',', hasil);
        
        }

        public static string BeforeAugust()
        {
            var json = File.ReadAllText(json1);
            var temp = JsonConvert.DeserializeObject<List<UserArticles>>(json);
            var hasil = temp.SelectMany(x => x.Articles.Where(x => x.Date.ToLocalTime().Year < 2020)
            .Where(x => x.Date.ToLocalTime().Month < 08).Select(x => x.Title));

            return String.Join(',', hasil);
        
        }
    }

}