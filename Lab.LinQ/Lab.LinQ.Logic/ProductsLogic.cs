using Lab.LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LinQ.Logic
{
    public class ProductsLogic : BaseLogic
    {
        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }
        public List<Products> GetAllSinStock()
        {
            List<Products> products = GetAll();

            var product = products.Where(p => p.UnitsInStock == 0);

            return product.ToList();
        }

        public List<Products> GetAllStockMayorATres()
        {
            
            var query = from product in context.Products
                        where product.UnitsInStock > 0 && product.UnitPrice > 3
                        select product;

            return query.ToList();
        }

        public Products GetProductByID()
        {
            var query = context.Products.Where(p => p.ProductID == 789);
            
            return query.FirstOrDefault();
        }
    }
}
