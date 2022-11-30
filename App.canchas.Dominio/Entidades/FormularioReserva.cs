using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class FormularioReserva
    {
        [Key]
        [JsonIgnore]
        public int IdReserva { get; set; }
        public DateTime FechaReserva { get; set; }
        public string Comentario { get; set; }
        public Pago Pago { get; set; }
        public int IdCancha { get; set; }
        [JsonIgnore]
        public Cancha Cancha { get; set; }
        [JsonIgnore]
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public string  Estado { get; set; }
    }
}
