using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace App.canchas.Dominio.Entidades
{
    public class Cliente:Persona
    {
        [Key]
        [JsonIgnore]
        public int IdCliente { get; set; }
        [JsonIgnore]
        public List<FormularioReserva> Reservas { get; set; }
    }
}
