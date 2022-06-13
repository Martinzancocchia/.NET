using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab.LinQ.Entities;
using Lab.LinQ.Logic;

namespace Lab.LinQ.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int opcion = -1;
            while (opcion != 0)
            {
                try
                {
                    System.Console.Clear();
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine("\n ******************** Seleccione una opcion ******************** \n");
                    System.Console.WriteLine(" 1- EJ1 \n 2- EJ2 \n 3- EJ3 \n 4- EJ4 \n 5- EJ5 \n 6- EJ6 \n 7- EJ7 \n \n 0- Salir \n");
                    opcion = int.Parse(System.Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            Ej1();
                            break;
                        case 2:
                            Ej2();
                            break;
                        case 3:
                            Ej3();
                            break;
                        case 4:
                            Ej4();
                            break;
                        case 5:
                            Ej5();
                            break;
                        case 6:
                            Ej6();
                            break;
                        case 7:
                            Ej7();
                            break;

                                

                        default: throw new Exception("Ingrese opcion valida");
                    }
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        static void Ej1()
        {
            Console.WriteLine("Ingrese ID");
            string ID = Console.ReadLine();
            CustomersLogic customersLogic = new CustomersLogic();
            Customers customers = customersLogic.GetByID(ID);

            Console.WriteLine($"{customers.ContactName} - {customers.ContactTitle} - {customers.CompanyName} - {customers.Country}");

            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }
        


        static void Ej2()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            List<Products> products = productsLogic.GetAllSinStock();

            foreach (Products product in products)
            {
                Console.WriteLine($"{product.ProductID} - {product.ProductName}");
            }
            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();

        }


        static void Ej3()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            List<Products> products = productsLogic.GetAllStockMayorATres();
            foreach (Products product in products)
            {
                Console.WriteLine($"{product.ProductID} - {product.ProductName} - {product.UnitPrice}");
            }

            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }


        static void Ej4()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            List<Customers> customer = customersLogic.GetAllRegionWA();
            foreach (var item in customer)
            {
                Console.WriteLine($"- {item.CompanyName}");
            }
            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }

        static void Ej5()
        {
            ProductsLogic productsLogic = new ProductsLogic();
            Products product = productsLogic.GetProductByID();
            if (product != null)
            {
                Console.WriteLine($"- {product.ProductName}");
            }
            else
            {
                Console.WriteLine(" \nEl ID: 789 no pertenece a ningun producto");
            }
            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }


        static void Ej6()
        {
            CustomersLogic customersLogic = new CustomersLogic();
            List<string> companyName = customersLogic.GetCompanyName();
            foreach(var item in companyName)
            {
                Console.WriteLine($"{item.ToUpper()} - {item.ToLower()}");
            }

            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }


        static void Ej7()
        {

            Console.WriteLine("Ingrese region");
            string region = Console.ReadLine();
            Console.WriteLine("Ingrese fecha de orden");
            DateTime fecha = DateTime.Parse(Console.ReadLine());

            CustomersLogic customersLogic = new CustomersLogic();
            List<CustomersOrders> customerorders = customersLogic.getCustomersOrders(fecha, region);
            foreach (CustomersOrders orders in customerorders)
            {
                Console.WriteLine($"{orders.OrderID} - {orders.CompanyName} - {orders.OrderDate} - {orders.Region}");
            }
            Console.WriteLine("\nPresione enter para volver al menu principal");
            Console.ReadLine();
        }


     

            
            
            
            
            







            
        
    }
}
