//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;


namespace AdminEdificios
{
    using System;
    using System.Collections.Generic;
    
    public partial class GastosComunes
    {
        public int GastosComunesId { get; set; }
        
        [Required(ErrorMessage="Ingresar Año")]
        public int Año { get; set; }

        [Required(ErrorMessage="Ingresar Mes")]
        public string Mes { get; set; }
        
        [Required(ErrorMessage="Ingresar Gastos por Servicios")]
        public int GastosServicios { get; set; }
        public Nullable<int> ServiciosHonorarios { get; set; }
        public Nullable<int> MaterialesGenerales { get; set; }
        
        [Required(ErrorMessage="Ingresar sueldos")]
        public int Sueldos { get; set; }
        public Nullable<int> Extras { get; set; }
        public Nullable<int> Total { get; set; }
    }
}
