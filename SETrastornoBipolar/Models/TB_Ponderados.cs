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
    
    public partial class TB_Ponderados
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TB_Ponderados()
        {
            this.TB_RespuestasxPreguntas = new HashSet<TB_RespuestasxPreguntas>();
            this.TB_Hechos = new HashSet<TB_Hechos>();
            this.TB_Preguntas = new HashSet<TB_Preguntas>();
            this.TB_Premisas = new HashSet<TB_Premisas>();
        }
    
        public int IdPonderado_pk { get; set; }
        public int Valor { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_RespuestasxPreguntas> TB_RespuestasxPreguntas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Hechos> TB_Hechos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Preguntas> TB_Preguntas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TB_Premisas> TB_Premisas { get; set; }
    }
}
