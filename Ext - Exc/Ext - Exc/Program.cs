using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext___Exc
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
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n ******************** Seleccione una opcion ******************** \n");
                    Console.WriteLine(" 1- Ejercicio 1 \n 2- Ejercicio 2 \n 3- Ejercicio 3 \n 4- Ejercicio 4 \n 0- Salir \n");
                    opcion = int.Parse(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            dividebycero();
                            break;
                        case 2:
                            division();
                            break;
                        case 3:
                            ej3();
                            break;
                        case 4:
                            ej4();
                            break;
                        default: throw new Exception("Ingrese opcion valida");

                    };
                }catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }

            }

        }

        static public void ej3()
        {
            try
            {
                Logic logic = new Logic();
                int _logic = logic.getlogic();
            }
            catch (Exception ex)
            {
                Console.WriteLine("La excepcion es de tipo: " + ex.GetType().ToString());
                Console.WriteLine("La excepcion tiene el siguiente mensaje: " + ex.Message + "\n");

            }

            return;
        }



        static public void ej4()
        {
            try
            {
                Logic2 logic = new Logic2();
                int _logic = logic.getlogic();
            }
            catch (Exception ex)
            {
                Console.WriteLine("La excepcion es de tipo: " + ex.GetType().ToString());
                Console.WriteLine("La excepcion tiene el siguiente mensaje: " + ex.Message + "\n");
            }

            return;
        }



        static public double division()
        {
            int a, b;
            double div = 0;
            try
            {

                Console.WriteLine("ingrese un numero");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("ingrese un divisor");
                b = int.Parse(Console.ReadLine());


                div = a / b;
                Console.WriteLine("la division entre " + a + " y " + b + " es: " + div);

            }
            catch (DivideByZeroException dbz)
            {
                Console.WriteLine("No se puede dividir por 0 pa");
                Console.WriteLine(dbz.Message);

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Ha introducido un numero demasiado alto, por favor vuelva a intentarlo ");
                Console.WriteLine(ex.Message);
            }
            catch (FormatException Val)
            {
                Console.WriteLine("Por favor ingrese un numero");
                Console.WriteLine(Val.Message);

            }
            return div;

        }


        static public double dividebycero()
        {
            int a, b, div = 0;
            Console.WriteLine("ingrese un numero: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese un divisor: ");
            b = int.Parse(Console.ReadLine());

            try
            {
                div = a / b;
                Console.WriteLine("el resultado de la division entre " + a + " y " + b + " es: " + div);
            }
            catch (Exception e)
            {
                Console.WriteLine("No se puede dividir por cero");
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Termine de dividir xd");
            return div;
        }

    }
}
