using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public class Colectivo : Transporte
    {
        private int Ruedas;

        

        public Colectivo(int cantidadpasajeros, int ID, string Tipo) : base(cantidadpasajeros, ID, Tipo)
        {
            
        }

        public void Setruedas(int cantidadruedas)
        {
            this.Ruedas = cantidadruedas;
        }

        public int Getruedas()
        {
            return this.Ruedas;
        }

        public override void Avanzar()
        {
            Console.WriteLine("avanzo como colectivo");
        }

        public override void Detenerse()
        {
            Console.WriteLine("avanzo como colectivo");
        }
    }
}
