using Library.Data;
using Library.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    public class EmployeesLogic:BaseLogic
    {
        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public Employees GetByID(int ID)
        {
            List<Employees> employees = GetAll();

            Employees empleado = new Employees();
            
            
            foreach(Employees employee in employees)
            {
                if (employee.EmployeeID == ID)
                {
                    return employee;
                }

            }
            return empleado;
        }

        public void Add(Employees newEmployee)
        {
            context.Employees.Add(newEmployee);

            context.SaveChanges();
        }
    }
}
