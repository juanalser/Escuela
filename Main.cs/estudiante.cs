//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Main.cs
{
    using System;
    using System.Collections.Generic;
    
    public partial class estudiante
    {
        public estudiante()
        {
            this.Facturas = new HashSet<Factura>();
            this.Facturas1 = new HashSet<Factura>();
            this.Facturas2 = new HashSet<Factura>();
            this.Pagoes = new HashSet<Pago>();
            this.Pagoes1 = new HashSet<Pago>();
            this.Pagoes2 = new HashSet<Pago>();
        }
    
        public int IDESTUDIANTE { get; set; }
        public Nullable<int> IDADMINISTRADOR { get; set; }
        public string NOMBRE { get; set; }
        public string SEXO { get; set; }
        public string PADRE { get; set; }
        public string MADRE { get; set; }
        public string TUTOR { get; set; }
        public string TELEFONO { get; set; }
        public string MOVIL { get; set; }
        public Nullable<System.DateTime> AÑO { get; set; }
        public string SERVICIO { get; set; }
        public string CURSO { get; set; }
    
        public virtual Administrador Administrador { get; set; }
        public virtual ICollection<Factura> Facturas { get; set; }
        public virtual ICollection<Factura> Facturas1 { get; set; }
        public virtual ICollection<Factura> Facturas2 { get; set; }
        public virtual ICollection<Pago> Pagoes { get; set; }
        public virtual ICollection<Pago> Pagoes1 { get; set; }
        public virtual ICollection<Pago> Pagoes2 { get; set; }
    }
}
