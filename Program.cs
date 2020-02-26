using System;

namespace Linq_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //nomer 1
            Console.WriteLine("Person who havent phone number");
            Console.WriteLine(LINQuery.NoPhone());
            Console.WriteLine("Who have articles");
            Console.WriteLine(LINQuery.HavingArticles());
            Console.WriteLine("Who have anis in their name");
            Console.WriteLine(LINQuery.ContainAnis());
            Console.WriteLine("who have articles on 2020");
            Console.WriteLine(LINQuery.HavingArticles2020());
            Console.WriteLine("who have born in 1986");
            Console.WriteLine(LINQuery.BornIn196());
            Console.WriteLine("contain tips on the title");
            Console.WriteLine(LINQuery.ContainTips());
            Console.WriteLine("publishbeforeaugust");
            Console.WriteLine(LINQuery.BeforeAugust());


            //nomer 2
            // Console.WriteLine("purchase made on february");
            // Console.WriteLine(LINQuery2.OnFebruary());
            // Console.WriteLine("Grand Total made by ari");
            // Console.WriteLine(LINQuery2.TotalPurchaseByAri());
            // Console.WriteLine("Lower Than 300000");
            // Console.WriteLine(LINQuery2.lowerthan300000());
            
            //nomer 3
            // LINQuery3.Items();
            LINQuery3.furnitures();
            LINQuery3.electronic();
            LINQuery3.allbrown();
            LINQuery3.Purchased_at();
        }
    }
}
