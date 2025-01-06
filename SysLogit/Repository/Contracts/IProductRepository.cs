using SysLogit.Models;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Repository.Contracts
{
    public interface IProductRepository
    {
        Response<IEnumerable<Product>> GetAll();
        Response<Product> GetById(int id);
        Response<string> Add(Product product);
        Response<string> Update(Product product);
        Response<string> Delete(int id);
    }
}
