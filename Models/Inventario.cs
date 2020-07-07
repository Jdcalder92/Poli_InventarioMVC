using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using InventatioMVC.Models;

namespace InventatioMVC.Models
{
    public class Inventario
    {
        public int Id { get; set; }

        [Required]
        public int ProductosId { get; set; }

        public  Productos Productos {get;set;}
        public int Cantidad { get; set; }
    }
}
