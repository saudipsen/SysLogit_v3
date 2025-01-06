using SysLogit.Business.Contracts;
using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysLogit.Business.Services
{
    public class ProductService : IProductService
    {
        public readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public Response<IEnumerable<Product>> GetAllProducts()
        {
            return _repository.GetAll();
        }

        public Response<Product> GetProductById(int id)
        {
            return _repository.GetById(id);
        }

        public Response<string> AddProduct(Product product)
        {
            return _repository.Add(product);
        }

        public Response<string> UpdateProduct(Product product)
        {
            return _repository.Update(product);
        }

        public Response<string> DeleteProduct(int id)
        {
            return _repository.Delete(id);
        }
    }

}
