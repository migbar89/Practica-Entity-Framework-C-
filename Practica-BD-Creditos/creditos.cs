//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Practica_BD_Creditos
{
    using System;
    using System.Collections.Generic;
    
    public partial class creditos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public creditos()
        {
            this.cuotas = new HashSet<cuotas>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> fecha_inicio { get; set; }
        public Nullable<System.DateTime> fecha_fin { get; set; }
        public Nullable<double> monto { get; set; }
        public Nullable<int> plazo { get; set; }
        public Nullable<double> monto_a_pagar { get; set; }
        public Nullable<int> interes { get; set; }
        public Nullable<double> monto_cuota { get; set; }
        public Nullable<int> idcliente { get; set; }
    
        public virtual cliente cliente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<cuotas> cuotas { get; set; }
    }
}
