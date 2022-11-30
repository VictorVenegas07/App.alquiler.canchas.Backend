using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Cancha
    {
        [Key]
        public int IdCancha { get; set; }
        public string NombreCancha { get; set; }
        public decimal Precio { get; set; }
        public string Disponibilidad { get; set; }
        public string Tipo { get; set; }
        public string Detalles { get; set; }
        public List<FormularioReserva> Reservas { get; set; }
        public int IdNeogcio { get; set; }
        public Negocio Negocio { get; set; }
    }
}
