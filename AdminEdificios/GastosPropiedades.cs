//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminEdificios
{
    using System;
    using System.Collections.Generic;
    
    public partial class GastosPropiedades
    {
        public int GastoPropiedadId { get; set; }
        public int DepartamentoId { get; set; }
        public int Año { get; set; }
        public string Mes { get; set; }
        public int GastoComunidad { get; set; }
        public decimal Alicuota { get; set; }
        public Nullable<int> Extra { get; set; }
        public Nullable<int> Multa { get; set; }
        public int TotalGastoDepto { get; set; }
    
        public virtual Departamentos Departamentos { get; set; }
    }
}
