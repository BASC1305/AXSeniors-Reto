using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AXSeniors_Reto.Models
{
    public class ProductModel
    {
        [Key]
        [Display(Name = "Código del prodcuto")]
        public string Id { get; set; }

        [Display(Name = "Nombre del producto")]
        [Required(ErrorMessage = "El campo nombre es requerido")]
        public string Name { get; set; }

        [Display(Name = "Lote")]
        [Required(ErrorMessage = "El campo lote es requerido")]
        public string Lot { get; set; }

        [Display(Name = "Unidad de medida")]
        [Required(ErrorMessage = "El campo unidad de medida es requerido")]
        public string Unit { get; set; }


        [Display(Name = "Precio")]
        [Required(ErrorMessage = "El campo precio es requerido")]
        public int Price { get; set; }
    }
}
