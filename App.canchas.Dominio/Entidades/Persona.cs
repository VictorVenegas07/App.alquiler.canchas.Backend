using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Persona
    {
        public string TipoDocumento { get; set; }
        public string Identificacion { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Nombres { get; set; }
        [Column(TypeName = "varchar(20)")]
        public string Apellidos { get; set; }
        [Column(TypeName = "varchar(15)")]
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Departamento { get; set; }
    }
}
