using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaAPI.Models
{
    public class Pedidos
    {

        [Key]
        public int idPedidos { get; set; }
        public string NomeMedicamento { get; set; }
        public string QtdeMedicamento { get; set; }
        public string CodCliente { get; set; }
        public string DataDeEntrega { get; set; }
    }
}