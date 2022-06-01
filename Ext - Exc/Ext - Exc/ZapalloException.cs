using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ext___Exc
{
    public class ZapalloException : Exception
    {
        string _Message;
        public ZapalloException(string msj) : base(msj)
        {
            _Message = msj;
        }
        public override string Message
        {
            get { return "ZapalloException" + _Message; }
        }
    }
}
