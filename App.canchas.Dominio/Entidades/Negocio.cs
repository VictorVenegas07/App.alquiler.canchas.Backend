using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Negocio
    {
        [Key]
        public int  IdNegocio { get; set; }
        public string NombreNegocio { get; set; }
        public string NumeroCuenta { get; set; }
        public string Departamento { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public List<Cancha> Canchas { get; set; }
        public int IdDueño { get; set; }
        public Dueño Dueño { get; set; }

    }
}
