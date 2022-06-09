using Library.Logic;
using Library.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Console.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int opcion = -1;
            while (opcion!=0)
            {
                try
                {
                    System.Console.Clear();
                    System.Console.ForegroundColor = ConsoleColor.Yellow;
                    System.Console.WriteLine("\n ******************** Seleccione una opcion ******************** \n");
                    System.Console.WriteLine(" 1- MOSTRAR TODOS LOS CLIENTES. \n 2- BUSCAR EMPLEADO POR ID. \n 3- AGREGAR TERRITORIO. \n 4- ELIMINAR TERRITORIO \n 5- ACTUALIZAR TERRITORIO \n 0- Salir \n");
                    opcion = int.Parse(System.Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            ListarClientes();
                            break;
                        case 2:
                            EmpleadosPorID();
                            break;
                        case 3:
                            Addterritories();
                            break;
                        case 4: 
                            Deleterritories();
                            break;
                        case 5:
                            Updaterritories();
                            break;
                            
                        default: throw new Exception("Ingrese opcion valida");
                    }
                }catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
        }

        static void ListarClientes()
        {
            CustomersLogic customers = new CustomersLogic();
            foreach (Customers customer in customers.GetAll())
            {
                System.Console.WriteLine($"{customer.CustomerID} - {customer.CompanyName}");
            }

            System.Console.ReadLine();
        }

        static void EmpleadosPorID()
        {
            EmployeesLogic employees = new EmployeesLogic();
            

            System.Console.WriteLine("Ingrese ID de empleado");
            int idempleado = int.Parse(System.Console.ReadLine());

            Employees empleado = employees.GetByID(idempleado);

            System.Console.WriteLine($"\n{empleado.FirstName} {empleado.LastName} - {empleado.Title} - {empleado.Address} / {empleado.City} / {empleado.Country} / TEL:{empleado.HomePhone}");

            System.Console.ReadLine();
        }

        static void Addterritories()
        {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            foreach (var item in territoriesLogic.GetAll())
            {
                System.Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription.Trim()} - {item.RegionID}");

            }

            System.Console.WriteLine("Ingrese ID del territorio");
            string territoryID = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese descripcion del territorio");
            string territoryDescription = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese ID de la region");
            int regionID = int.Parse(System.Console.ReadLine());
          

            Territories territory = new Territories()
            {
                TerritoryID = territoryID,
                TerritoryDescription = territoryDescription,
                RegionID = regionID
            };

            System.Console.WriteLine();

            territoriesLogic.Add(territory);
            
            System.Console.WriteLine();

            foreach (var item in territoriesLogic.GetAll())
            {
                System.Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription.Trim()} - {item.RegionID}");

            }

            System.Console.ReadLine();
            ;
        }

        

        static void Deleterritories()
        {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            foreach (var item in territoriesLogic.GetAll())
            {
                System.Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription.Trim()} - {item.RegionID}");

            }
            System.Console.WriteLine();

            System.Console.WriteLine("Ingrese ID del territorio que desea eliminar");
            string territoryID = System.Console.ReadLine();
            territoriesLogic.Delete(territoryID);

            System.Console.WriteLine();

            foreach (var item in territoriesLogic.GetAll())
            {
                System.Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription} - {item.RegionID}");

            }

            System.Console.ReadLine();
        }

        static void Updaterritories()
        {
            TerritoriesLogic territoriesLogic = new TerritoriesLogic();

            foreach (var item in territoriesLogic.GetAll())
            {
                System.Console.WriteLine($"{item.TerritoryID} - {item.TerritoryDescription} - {item.RegionID}");

            }

           
            System.Console.WriteLine("Ingrese ID del territorio a actualizar");
            string territoryID = System.Console.ReadLine();
            System.Console.WriteLine("Ingrese nueva descripcion del territorio");
            string territoryDescription = System.Console.ReadLine();

            Territories territory = new Territories()
            {
                TerritoryID = territoryID,
                TerritoryDescription = territoryDescription
                
            };

            territoriesLogic.Update(territory);
           
            foreach (var item in territoriesLogic.GetAll())
            {
                System.Console.WriteLine($"{item.TerritoryID.Trim()} - {item.TerritoryDescription.Trim()} - {item.RegionID}");

            }

            System.Console.ReadLine();
        }


    }
}
