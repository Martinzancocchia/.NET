using Library.Data;
using Library.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Logic
{
    public class CustomException : Exception
    {
        string _Message;
        public CustomException(string msj) : base(msj)
        {
            _Message = msj;
        }
        public override string Message
        {
            get { return "ZapalloException" + _Message; }
        }
    }
}