using Microservice.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice
{
    class Program
    {
        static void Main(string[] args)
        {
            SupplierController callSupplier = new SupplierController();

            Console.WriteLine("=========== Manage Data ============");
            Console.WriteLine("1. Supplier");
            Console.WriteLine("2. Item");
            Console.WriteLine("3. Transaction");
            Console.WriteLine("======================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================");

            switch (chance)
            {
                case 1:
                    callSupplier.ManageSupplier();
                    break;
                case 2:
                    Console.WriteLine("Not yet");
                    Console.Read();
                    break;
                case 3:
                    Console.WriteLine("Not Yet");
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Not Found Your Choise");
                    Console.Read();
                    break;
            }
        }
    }
}
