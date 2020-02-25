using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace Linq_task
{
    public class Order
    {
        public string id { get; set; }
        public DateTime created_at  { get; set; }
        public Customer Customer {get; set;}
        public List<Item> Items {get; set;}
    }
    public class Customer
    {
        public int id { get; set; }
        public string name {get; set;}
    }
    public class Item
    {
        public int id { get; set; }
        public string name { get; set; }
        public int qty { get; set; }
        public int price { get; set; }
    }

    public class LINQuery2
    {
        static string json2 = @"C:\Users\Nugi\Linq_task\Database\nomor2.json";

        public static int OnFebruary()
        {
            var json = File.ReadAllText(json2);
            var temp = JsonConvert.DeserializeObject<List<Order>>(json);
            var hasil = temp.Where(a => a.created_at.Date.Month==02).Select(a => a.id);
            return hasil.Count() ;
        }

        public static int TotalPurchaseByAri()
        {
            var json = File.ReadAllText(json2);
            var temp = JsonConvert.DeserializeObject<List<Order>>(json);
            var hasil = temp.Where(a => a.Customer.name.ToLower().Contains("ari")).Sum(b=>b.Items.Sum(c => c.price*c.qty));
            return hasil;
        }

        public static string lowerthan300000()
        {
            var json = File.ReadAllText(json2);
            var temp = JsonConvert.DeserializeObject<List<Order>>(json);
            // var hasil = temp.Where(a => a.Items.Sum(c => c.price*c.qty)< 300000).Select(b => b.Customer.name).Distinct();
            var hasil = temp.GroupBy(e => e.Customer.name).Select(e => new { name = e.First().Customer.name, total = e.Select(e => e.Items.Sum(e => e.price * e.qty)).Sum()}).Where(k => k.total < 300000);          
            return String.Join(',', hasil);
        }
    }
}