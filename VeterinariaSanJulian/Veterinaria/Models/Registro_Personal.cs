//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Veterinaria.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registro_Personal
    {
        public int Registro_Veterinario { get; set; }
        public Nullable<int> IdPersona { get; set; }
        public string personal { get; set; }
        public string Nombre_Usuario { get; set; }
        public Nullable<int> Contraseña { get; set; }
        public Nullable<int> Edad { get; set; }
        public string Nombre_Completo { get; set; }
        public Nullable<System.DateTime> Fecha_Ingreso { get; set; }
        public string Email { get; set; }
    }
}
