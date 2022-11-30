using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio
{
    internal class ExepcionsValidations: Exception
    {
        public ExepcionsValidations(string mensaje):base(mensaje)
        {

        }
    }
}
