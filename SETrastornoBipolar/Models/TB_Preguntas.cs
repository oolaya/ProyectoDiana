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
    
    public partial class TB_Preguntas
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Preguntas()
        {
            this.TB_RespuestasxPreguntas = new HashSet<TB_RespuestasxPreguntas>();
        }
    
        public int IdPreguntas_pk { get; set; }
        public string Descripcion { get; set; }
        public int IdPremisa_fk { get; set; }
        public int Orden { get; set; }
        public bool Activo { get; set; }
        public System.DateTime FechaRegistra { get; set; }
        public int IdPonderado_pk { get; set; }
    
        public virtual TB_Premisas TB_Premisas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_RespuestasxPreguntas> TB_RespuestasxPreguntas { get; set; }
        public virtual TB_Ponderados TB_Ponderados { get; set; }
    }
}