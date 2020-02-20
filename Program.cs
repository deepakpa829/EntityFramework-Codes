using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseFATask1
{
    class Program
    {
        static CategorydbEntities dbt = new CategorydbEntities();
        static void Main(string[] args)
        {
            Insertdata();
            //Insertdata1();
            Display();
            Console.ReadLine();
        }
        public static void Insertdata()
        {
            Console.WriteLine("Enter the Category Id");
            int Cid1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Category name");
            string Cname1 = Console.ReadLine();
            
            
            var category = new Category
            {
                Cid = Cid1,
                Cname=Cname1

            };
            dbt.Categories.Add(category);
            dbt.SaveChanges();
        }

       
        public static void Display()
        {
            Console.WriteLine("All Categories are...");
            var Category = dbt.Categories;
            foreach (var c in Category)
            {
                Console.WriteLine("{0}\t{1}", c.Cid, c.Cname);
            }

            Console.WriteLine();

            Console.WriteLine("All Products are....");
            var product = dbt.Products;
            foreach(var d in product)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", d.Pid, d.Title, d.Price, d.Category.Cid,d.Category.Cname);
            }
        }
    }
}
