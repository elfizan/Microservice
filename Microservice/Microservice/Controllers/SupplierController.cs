using Microservice.BussinessLogic.Services.Master;
using Microservice.Data.Access.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Controllers
{
    public class SupplierController
    {
        public void ManageSupplier()
        {
            
            ISupplierService _supplierService = new SupplierService();
            SupplierParam supplierParam = new SupplierParam();
            
            Console.WriteLine("=========== Manage Supplier Data ============");
            Console.WriteLine("1. Insert");
            Console.WriteLine("2. Update");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Retrieve");
            Console.WriteLine("======================================");
            Console.Write("Going to : ");
            int chance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("======================================");

            switch (chance)
            {
                case 1:
                    // ini untuk memasukkan nilai Name, JoinDate, dan CreateDate di Supplier
                    Console.Write("Insert Name of Supplier : ");
                    supplierParam.Name = Console.ReadLine();
                    _supplierService.Insert(supplierParam);
              
                    break;
                case 2:
                    // input id untuk dicari
                    Console.Write("Insert Id to Update Data : ");
                    supplierParam.Id = Convert.ToInt16(Console.ReadLine());
                    
                    Console.Write("Insert Name to Update Data : ");
                    supplierParam.Name = Console.ReadLine();
                    // mencari data sesuai dengan id di database
                    _supplierService.Update(supplierParam.Id, supplierParam);                    
                    break;
                case 3:
                    // input id untuk dicari
                    Console.Write("Insert Id to Delete Data : ");
                    supplierParam.Id = Convert.ToInt16(Console.ReadLine());
                    _supplierService.Delete(supplierParam.Id);

                    break;
                case 4:
                    _supplierService.Get();
                    foreach (var tampilin in _supplierService.Get())
                    {
                        Console.WriteLine("============================");
                        Console.WriteLine("Name      \t: " + tampilin.Name);
                        Console.WriteLine("Join Date \t: " + tampilin.JoinDate);
                        Console.WriteLine("============================");
                    }
                    Console.Write("Total Supplier\t: " + _supplierService.Get().Count);
                    Console.Read();
                    break;
                default:
                    Console.WriteLine("Something Wrong, Please try again next time");
                    break;
            }
        }
    }
}
