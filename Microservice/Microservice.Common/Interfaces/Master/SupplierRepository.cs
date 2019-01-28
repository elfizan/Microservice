using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.Data.Access.Model;
using Microservice.Data.Access.Param;

namespace Microservice.Common.Interfaces.Master
{
    public class SupplierRepository : ISupplierRepository
    {
        bool status = false;
        MyContext _context = new MyContext();
        Supplier supplier = new Supplier();
        public bool Delete(int? id)
        {
            var result = 0;
            supplier = Get(id);
            supplier.IsDelete = true;
            supplier.DeleteDate = DateTimeOffset.Now.LocalDateTime;

            result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
                Console.WriteLine("Delete Success");
                Console.Read();
            }
            return status;
        }

        public List<Supplier> Get()
        {
            var get = _context.Suppliers.Where(x => x.IsDelete == false).ToList();
            return get;
        }

        public Supplier Get(int? id)
        {
            var getId = _context.Suppliers.Find(id);
            return getId;
        }

        public bool Insert(SupplierParam supplierParam)
        {
            var result = 0;
            supplier.Name = supplierParam.Name;
            supplier.JoinDate = DateTimeOffset.Now.LocalDateTime;
            supplier.CreateDate = DateTimeOffset.Now.LocalDateTime;
            _context.Suppliers.Add(supplier);
            result = _context.SaveChanges();
            if (result > 0)
            {
                status= true;
                Console.WriteLine("Insert Success");
            }
            return status;
        }

        public bool Update( int? id,SupplierParam supplierParam)
        {
            var result = 0;
            var getId = Get(id);
            getId.Name = supplierParam.Name;
            getId.UpdateDate = DateTimeOffset.Now.LocalDateTime;
            //Opsional
           // _context.Entry(getId).State = System.Data.Entity.EntityState.Modified;
           
            result = _context.SaveChanges();
            if (result > 0)
            {
                status= true;
                Console.WriteLine("Update Success");
                Console.Read();
            }
            return status;
        }
    }
}
