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
    
    public partial class Administrador
    {
        public Administrador()
        {
            this.estudiantes = new HashSet<estudiante>();
        }
    
        public int IDAdministrador { get; set; }
        public Nullable<int> Inscripcion { get; set; }
        public Nullable<int> Mensualidad { get; set; }
    
        public virtual ICollection<estudiante> estudiantes { get; set; }
    }
}
