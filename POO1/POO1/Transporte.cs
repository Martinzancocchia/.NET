using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    public abstract class Transporte
    {
        public int Pasajeros { get; set; }

        public int ID { get; set; }

        public String Tipo { get; set; }

        
        public Transporte(int pasajeros, int ID, string Tipo)
        {
            this.Pasajeros = pasajeros;
            this.ID = ID;
            this.Tipo = Tipo;
        }

        public abstract void Avanzar();

        public abstract void Detenerse();
    }
}
