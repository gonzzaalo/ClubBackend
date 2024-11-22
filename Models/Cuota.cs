//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Globalization;
//namespace ClubBackend.Models
//{
//    public class Cuota
//    {
//            public int Id { get; set; }

//            [Required]
//            public string Nombre { get; set; } = string.Empty;

//        public string Descripcion { get; set; } = string.Empty;

//        // Navigation properties
//        //una cuota puede tener muchos deportistas
//        //una cuota puede tener muchos socios
//        public ICollection<Deportista>? Deportistas { get; set; }
//            public ICollection<Socio>? Socios { get; set; }

//    }
//}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Cuota
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = string.Empty;

    public string Descripcion { get; set; } = string.Empty;
    public decimal Monto { get; set; } // Nuevo campo para el monto

    // Relación con Deportistas (Uno a Muchos)
    public ICollection<Deportista>? Deportistas { get; set; }

    // Relación con Socios (Uno a Muchos)
    public ICollection<Socio>? Socios { get; set; }
}
