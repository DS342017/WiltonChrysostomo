using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace FarmaciaMVC.Models
{
    public class Pedido
    {
        [Key]
        public int IdPedidos { get; set; }

        
        [Required][Display(Name = "Nome do Medicamanto")]
        public string NomeMedicamento { get; set; }

        
        [Required][Display(Name = "Quantidade")]
        public string QtdeMedicamento { get; set; }

        
        [Required][Display(Name = "Codigo do Cliente")]
        public string CodCliente { get; set; }

        
        [Required][DataType(DataType.Date)]
        [Display(Name = "Data de Entrega")]
        public string DataDeEntrega { get; set; }
        
    }
}