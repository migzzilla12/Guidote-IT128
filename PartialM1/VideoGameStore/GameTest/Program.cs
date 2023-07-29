using VideoGameStore.Data;
using VideoGameStore.Models;
using VideoGameStore.Database;
using Microsoft.Extensions.Configuration;
using System.Xml.Linq;

namespace GameTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlData db = GetConnection();
            AddItem(db);
            ItemList(db);
            GetItems(db);

            Console.WriteLine("Press Enter to Exit...");
            Console.ReadLine();
        }

        static SqlData GetConnection()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            IConfiguration config = builder.Build();
            ISqlDataAccess dbAccess = new SqlDataAccess(config);
            SqlData db = new SqlData(dbAccess);

            return db;
        }
        private static void AddItem(SqlData db)
        {
            Console.Write("Code: ");
            string code = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("UnitPrice: ");
            string unitPrice = Console.ReadLine();

            Item item = new Item
            { Code = code,Name = name, Brand = brand, UnitPrice = unitPrice, DateOrdered = DateTime.Now,};

            db.AddItem(item);
        }
        private static void ItemList(SqlData db)
        {
            List<ItemList> items = db.ListItems();

            foreach (ItemList item in items)
            {

                Console.WriteLine($"ID: {item.OrderId}");
                Console.WriteLine($"Name: {item.Name}");
                Console.WriteLine($"Item: {item.Code}");
                Console.WriteLine($"Brand: {item.Brand}");
                Console.WriteLine($"Unit Price: {item.UnitPrice}");
                Console.WriteLine($"[{item.DateOrdered.ToString("yyyy-MM-dd")}]");
                Console.WriteLine();
            }
        }

        private static void GetItems(SqlData db)
        {
            Console.Write("Enter an Order ID: ");
            int id = Int32.Parse(Console.ReadLine());

            ItemList item = db.GetItems(id);
            Console.WriteLine($"ID: {item.OrderId}");
            Console.WriteLine($"Name: {item.Name}");
            Console.WriteLine($"Item: {item.Code}");
            Console.WriteLine($"Brand: {item.Brand}");
            Console.WriteLine($"Unit Price: {item.UnitPrice}");
            Console.WriteLine($"[{item.DateOrdered.ToString("yyyy-MM-dd")}]");
            Console.WriteLine();
        }
    }
}
