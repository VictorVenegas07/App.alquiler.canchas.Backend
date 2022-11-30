using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Administrador:Persona
    {
        [Key]
        public int IdAdministrador { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }

    }
}
