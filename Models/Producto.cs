using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiVentas.Models
{
    public class Producto
    {
            [Key]
            public int id { get; set; }
            public int usuarioId { get; set; }
            public int nombre { get; set; }
            public string precio { get; set; }
            public string descripcion { get; set; }
            public string marca { get; set; }
            public bool estado { get; set; }

    }
}
