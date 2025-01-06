using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLogit.Models;
using SysLogit.Utility;

namespace SysLogit.Business.Contracts
{
    

    public interface IProductService
    {
        Response<IEnumerable<Product>> GetAllProducts();
        Response<Product> GetProductById(int id);
        Response<string> AddProduct(Product product);
        Response<string> UpdateProduct(Product product);
        Response<string> DeleteProduct(int id); 
    }

}
