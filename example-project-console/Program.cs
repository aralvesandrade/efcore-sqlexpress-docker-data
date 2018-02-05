using System;
using example_project_data;
using System.Linq;

namespace example_project_console
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Context()) 
            {     
                var products = db.Products.ToList();

                foreach (var item in products)
                {
                    Console.WriteLine($"{item.Id} : {item.Name} - {item.Price}");
                }
            }

            Console.ReadLine();
        }
    }
}