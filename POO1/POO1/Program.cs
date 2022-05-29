using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String A1 = "Taxi";
            String B1 = "Colectivo";        
            List<Transporte> transporteList = new List<Transporte>
            {
                new Taxi(4, 1, A1),
                new Taxi(5, 2, A1),
                new Taxi(4, 3, A1),
                new Taxi(3, 4, A1),
                new Taxi(2, 5, A1),
                new Colectivo(9, 1, B1),
                new Colectivo(10, 2, B1),
                new Colectivo(20, 3, B1),
                new Colectivo(8, 4, B1),
                new Colectivo(19, 5, B1)
            };

            foreach (Transporte transporte in transporteList)
            {
                Console.WriteLine(transporte.Tipo+" "+transporte.ID+": "+transporte.Pasajeros+" Pasajeros."); 

            }
            Console.ReadKey();

        }
    }
}
