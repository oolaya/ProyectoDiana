using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SETrastornoBipolar.Models;
using SETrastornoBipolar.Controllers.Objs;

namespace SETrastornoBipolar.Controllers
{
    public class HechosController : Controller
    {
        TrastornoBipolarDBEntities db = new TrastornoBipolarDBEntities();
        // GET: Hechos
        public ActionResult Individuo()
        {
            var list = (db.TB_Hechos.Where(x => x.Activo == true)).ToList();
            return View();
        }

        public ActionResult TestBipolar()
        {
            var list = (from rp in db.TB_RespuestasxPreguntas
                        join p in db.TB_Premisas on new { IdPremisa_pk = rp.IdPregunta_fk } equals new { IdPremisa_pk = p.IdPremisa_pk }
                        join por in db.TB_Ponderados on new { IdPonderado_fk = rp.IdPonderado_fk } equals new { IdPonderado_fk = por.IdPonderado_pk }
                        where
                          rp.Premisa == true
                        select new
                        {
                            IdRespuestaxPregunta_pk = rp.IdRespuestaxPregunta_pk,
                            IdPregunta_fk = rp.IdPregunta_fk,
                            IdOpcionRespuesta_fk = rp.IdOpcionRespuesta_fk,
                            IdPonderado_fk = rp.IdPonderado_fk,
                            Descripcion = rp.Descripcion,
                            FechaRegistra = rp.FechaRegistra,
                            Premisa = rp.Premisa,
                            Pregunta = p.Descripcion,
                            PonderadoPregunta = p.TB_Ponderados.Valor,
                            Respuestas = rp.TB_OpcionesRespuestas.Nombre,
                            PonderadoRespuesta = por.Valor
                        }).ToList();
            return View();
        }

        public ActionResult _ParcialPremisa()
        {
            List<ModelList> VarResult = new List<ModelList>();
            var resul1 = (from rp in db.TB_RespuestasxPreguntas
                          join p in db.TB_Premisas on new { IdPremisa_pk = rp.IdPregunta_fk } equals new { IdPremisa_pk = p.IdPremisa_pk }
                          join por in db.TB_Ponderados on new { IdPonderado_fk = rp.IdPonderado_fk } equals new { IdPonderado_fk = por.IdPonderado_pk }
                          where
                            rp.Premisa == true
                          select new
                          {
                              IdRespuestaxPregunta_pk = rp.IdRespuestaxPregunta_pk,
                              IdPregunta_fk = rp.IdPregunta_fk,
                              IdOpcionRespuesta_fk = rp.IdOpcionRespuesta_fk,
                              IdPonderado_fk = rp.IdPonderado_fk,
                              Descripcion = rp.Descripcion,
                              FechaRegistra = rp.FechaRegistra,
                              Premisa = rp.Premisa,
                              Pregunta = p.Descripcion,
                              PonderadoPregunta = p.TB_Ponderados.Valor,
                              Respuestas = rp.TB_OpcionesRespuestas.Nombre,
                              PonderadoRespuesta = por.Valor
                          }).ToList();

            foreach (var item in resul1)
            {
                VarResult.Add(new ModelList
                {
                    IdRespuestaxPregunta = item.IdRespuestaxPregunta_pk,
                    IdPregunta = item.IdPregunta_fk,
                    IdOpcionRespuesta = item.IdOpcionRespuesta_fk,
                    IdPonderado = item.IdPonderado_fk,
                    DescripcionFT = item.Descripcion,
                    FechaRegistraFe = item.FechaRegistra,
                    Premisa1 = item.Premisa,
                    Pregunta1 = item.Pregunta,
                    PonderadoPregunta1 = item.PonderadoPregunta,
                    Respuestas1 = item.Respuestas,
                    PonderadoRespuesta1 = item.PonderadoRespuesta
                });
            }
            ViewBag.Data = VarResult;
            return PartialView("_ParcialPremisa", VarResult);
            //View(VarResult);
        }

    }
}