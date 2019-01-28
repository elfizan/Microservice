using Microservice.Data.Access.Model;
using Microservice.Data.Access.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microservice.Common.Interfaces.Master
{
    public interface ISupplierRepository
    {
        bool Insert(SupplierParam supplierParam);
        bool Update(int? id,SupplierParam supplierParam);
        bool Delete(int? id);
        //Overload
        List<Supplier> Get();
        Supplier Get(int? id);
    }
}
