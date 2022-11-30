using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Pago
    {
        [Key]
        [JsonIgnore]
        public int IdPago { get; set; }
        public string ReferenciaPago { get; set; }
        public DateTime FechaPago { get; set; }
        public string Comprobante { get; set; }
        [JsonIgnore]
        public int IdReserva { get; set; }
        [JsonIgnore]
        public FormularioReserva Reserva { get; set; }
    }
}
