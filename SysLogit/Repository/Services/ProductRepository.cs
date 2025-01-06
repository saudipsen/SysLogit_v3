using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SysLogit.Models;
using SysLogit.Repository.Contracts;
using SysLogit.Repository.Contracts.SysLogit.Repository.Contracts;
using SysLogit.Utility;

namespace SysLogit.Repository.Services
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Response<IEnumerable<Product>> GetAll()
        {
            try
            {
                var products = _context.Products.ToList();
                return products.Any()
                    ? new Response<IEnumerable<Product>>(true, "Products retrieved successfully.", products)
                    : new Response<IEnumerable<Product>>(false, "No products found.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(GetAll), ex);
                return new Response<IEnumerable<Product>>(false, "An error occurred while retrieving products.");
            }
        }

        public Response<Product> GetById(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                return product != null
                    ? new Response<Product>(true, "Product retrieved successfully.", product)
                    : new Response<Product>(false, "Product not found.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(GetById), ex);
                return new Response<Product>(false, "An error occurred while retrieving the product.");
            }
        }

        public Response<string> Add(Product product)
        {
            try
            {
                if (product == null) return new Response<string>(false, "Invalid product data.");
                _context.Products.Add(product);
                _context.SaveChanges();
                return new Response<string>(true, "Product added successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(Add), ex);
                return new Response<string>(false, "An error occurred while adding the product.");
            }
        }

        public Response<string> Update(Product product)
        {
            try
            {
                if (product == null) return new Response<string>(false, "Invalid product data.");
                var existingProduct = _context.Products.Find(product.ProductId);
                if (existingProduct == null) return new Response<string>(false, "Product not found.");
                _context.Entry(existingProduct).CurrentValues.SetValues(product);
                _context.SaveChanges();
                return new Response<string>(true, "Product updated successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(Update), ex);
                return new Response<string>(false, "An error occurred while updating the product.");
            }
        }

        public Response<string> Delete(int id)
        {
            try
            {
                var product = _context.Products.Find(id);
                if (product == null) return new Response<string>(false, "Product not found.");
                _context.Products.Remove(product);
                _context.SaveChanges();
                return new Response<string>(true, "Product deleted successfully.");
            }
            catch (Exception ex)
            {
                Logger.LogError(nameof(Delete), ex);
                return new Response<string>(false, "An error occurred while deleting the product.");
            }
        }
    }
}



