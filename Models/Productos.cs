using System;
using System.ComponentModel.DataAnnotations;

namespace InventatioMVC.Models
{
    public class Productos
    {
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Unidad_Medida { get; set; }
        [Required]
        public string Marca { get; set; }
        [Required]
        public int Peso_KG { get;set;}
    }
}