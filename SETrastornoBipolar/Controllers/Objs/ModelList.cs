using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SETrastornoBipolar.Controllers.Objs
{
    public class ModelList
    {
        public int IdRespuestaxPregunta { get; set; }
        public int IdPregunta { get; set; }
        public int IdOpcionRespuesta { get; set; }
        public int IdPonderado { get; set; }
        public string DescripcionFT { get; set; }
        public DateTime FechaRegistraFe { get; set; }
        public bool Premisa1 { get; set; }
        public string Pregunta1 { get; set; }
        public int PonderadoPregunta1 { get; set; }
        public string Respuestas1 { get; set; }
        public int PonderadoRespuesta1 { get; set; }
    }
}