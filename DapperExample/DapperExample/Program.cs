using System;
using System.Data.OleDb;
using Dapper;

namespace DapperExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=test.mdb"))
            {
                var list = con.Query<Product>("select * from products");

                foreach (var item in list)
                {
                    Console.WriteLine(item.ProductNumber + " : " + item.Description);
                }

                Console.ReadLine();
            }
        }
    }

    public class Product
    {
        public string ProductNumber { get; set; }
        public string Description { get; set; }
    }
}
