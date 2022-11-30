using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Dueño:Persona
    {
        [Key]
        public int IdDueño { get; set; }
        public List<Negocio> Negocios { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
