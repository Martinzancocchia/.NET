using Lab.LinQ.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.LinQ.Logic
{
    public class CustomersLogic : BaseLogic
    {
        public List<Customers> GetAll()
        {
            return context.Customers.ToList();
        }
        public Customers GetByID(string ID)
        {
            var customer = context.Customers.Where(c => c.CustomerID == ID);

            //customer = customers.Where(c => c.CustomerID == ID);

            return customer.FirstOrDefault();
        }

        public List<CustomersOrders> getCustomersOrders(DateTime date, string region)
        {
            List<Customers> customers = GetAll();


            List<Orders> orders = context.Orders.ToList();


            var customersOrders = from customer in customers
                                  join order in orders
                                  on new { customer.CustomerID } equals new { order.CustomerID }
                                  where customer.Region == region && order.OrderDate > date
                                  select new CustomersOrders
                                  {
                                      CompanyName = customer.CompanyName,
                                      Region = customer.Region,
                                      OrderID = order.OrderID,
                                      OrderDate = order.OrderDate
                                  };

            return customersOrders.ToList();



        }

        public List<Customers> GetAllRegionWA()
        {
            
            var query = from customer in context.Customers
                        where customer.Region == "WA"
                        select customer;

            return query.ToList();
        }

        public List<string> GetCompanyName()
        {
            var Companyname = from customer in context.Customers
                        select customer.CompanyName;

            return Companyname.ToList();
        }
    }
}
