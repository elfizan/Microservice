using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microservice.Data.Access.Model;
using Microservice.Data.Access.Param;
using Microservice.Common.Interfaces.Master;

namespace Microservice.BussinessLogic.Services.Master
{
    public class SupplierService : ISupplierService
    {
        bool status = false;
        ISupplierRepository _supplierRepository = new SupplierRepository();
        public bool Delete(int? id)
        {
            if (_supplierRepository.Get(id) == null)
            {
                Console.WriteLine("Don't Match Data");
                Console.Read();
            }
            else if (_supplierRepository.Get(id).ToString() == " ")
            {

                Console.WriteLine("Don't White Space");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Delete(id);
            }
            return status;
        }

        public List<Supplier> Get()
        {
            return _supplierRepository.Get();
        }

        public Supplier Get(int? id)
        {
            return _supplierRepository.Get(id);
        }

        public bool Insert(SupplierParam supplierParam)
        {
            if (supplierParam == null)
            {
                Console.WriteLine("Don't Null Data");
                Console.Read();
            }
            else if(supplierParam.ToString() == " ")
            {

                Console.WriteLine("Don't White Space");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Insert(supplierParam);
            }
            return status;
        }

        public bool Update(int? id, SupplierParam supplierParam)
        {
            
            if (_supplierRepository.Get(id) == null)
            {
                Console.WriteLine("Don't Macth Id Data");
                Console.Read();
            }
            else if (supplierParam.Name.ToString() == " ")
            {
                Console.WriteLine("Don't White Space");
                Console.Read();
            }
            else
            {
                status = _supplierRepository.Update(id, supplierParam);
                
            }
            return status;
        }
    }
}
