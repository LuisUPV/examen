//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace examen.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendedores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vendedores()
        {
            this.Facturas = new HashSet<Facturas>();
        }
    
        public int Id_Vendedor { get; set; }
        public string Nombre_Vendedor { get; set; }
        public string Direccion_Vendedor { get; set; }
        public string CP_Vendedor { get; set; }
        public Nullable<int> Ciudad_id { get; set; }
    
        public virtual Ciudades Ciudades { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facturas> Facturas { get; set; }
    }
}
