//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SETrastornoBipolar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TB_Premisas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Premisas()
        {
            this.TB_Preguntas = new HashSet<TB_Preguntas>();
        }
    
        public int IdPremisa_pk { get; set; }
        public string Descripcion { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaRegistra { get; set; }
        public int IdPonderado_pk { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Preguntas> TB_Preguntas { get; set; }
        public virtual TB_Ponderados TB_Ponderados { get; set; }
    }
}
