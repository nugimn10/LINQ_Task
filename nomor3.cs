using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Linq_task
{
    public class Inventory
    {
        public int Inventory_id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List <string> Tags { get; set; }
        public int Purchased_at { get; set; }
        public Placement Placement { get; set; }
    }

    public class Placement
    {
        public int Room_id { get; set; }
        public string Name { get; set; }
    }

    public class LINQuery3
    {
        protected static string json3 = @"C:\Users\Nugi\Linq_task\Database\nomor3.json";
        protected static string json = File.ReadAllText(json3);
        protected static List<Inventory> temp = JsonConvert.DeserializeObject<List<Inventory>>(json);

        public static void Items ()
        {
            string srcPth= @"C:\Users\Nugi\Linq_task\nomor3\items.json";
            var result = temp.Where(a=> a.Placement.Name.ToLower().Contains("meeting room")); 
            var hasil = JsonConvert.SerializeObject(result);
            File.WriteAllText(srcPth, hasil);
        }

        public static void electronic ()
        {
            string srcPth= @"C:\Users\Nugi\Linq_task\nomor3\electronic.json";
            var result = temp.Where(a=>a.Type.ToLower().Contains("electronic"));
            var hasil = JsonConvert.SerializeObject(result);
            File.WriteAllText(srcPth, hasil);
        }

        public static void allbrown ()
        {
            string srcPth= @"C:\Users\Nugi\Linq_task\nomor3\all-brown.json";
            var result = temp.Where(a=>a.Tags.Contains("brown"));
            var hasil = JsonConvert.SerializeObject(result);
            File.WriteAllText(srcPth, hasil);
        }

        public static void Purchased_at ()
        {
            string srcPth= @"C:\Users\Nugi\Linq_task\nomor3\purchased-at.json";
            var result = temp.Where(a=>a.Tags.Contains("brown"));
            var hasil = JsonConvert.SerializeObject(result);
            File.WriteAllText(srcPth, hasil);
        }

        
    }
}