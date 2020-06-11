using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial1_Ap2_Frandy.Models
{
    public class Articulos
    {
        [Key]

        public int ProductoId { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public int Existencia { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public double Costo { get; set; }

        [Required(ErrorMessage = "La descripcion es obligatoria")]
        public double ValorInventario { get; set; }

        public Articulos()
        {

            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = 0;
            Costo = 0;
            ValorInventario = 0;
        }
    }
}
