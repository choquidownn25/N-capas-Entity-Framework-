using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CapaInfrastructura.Repositorios;
using SigtiMVC.Models;

namespace SigtiMVC.Controllers
{
    public class CiudadesModelsController : Controller
    {
        private SigtiEntities db = new SigtiEntities();
        private CiudadRepositorios _CiudadesRepository = new CiudadRepositorios();

        // GET: CiudadesModels
        public ActionResult Index()
        {
            var datoconsulta = _CiudadesRepository.GetCiudades();
          


            foreach (var detallesItinerarioVuelo in datoconsulta)
            {
                var aerolineaVuelo = new Ciudades();
                
            }
                //CiudadesModels categoriaModel = new CiudadesModels();
                //Mapper.Initialize(cfg => cfg.CreateMap<Ciudades, CiudadesModels>()
                //.ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

                //Ciudades categoria = Mapper.Map<CiudadesModels, Ciudades>(categoriaModel);
                //var mappeddata = AutoMapper.Mapper.Map<Ciudades, CiudadesModels>(ciudades);

            return View(datoconsulta);
        }

        //// GET: CiudadesModels/Details/5
        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CiudadesModels ciudadesModels = db.Ciudades.Find(id);
        //    if (ciudadesModels == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ciudadesModels);
        //}

        //// GET: CiudadesModels/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: CiudadesModels/Create
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,Laptitud,Codigo,Longitud,Nombre,IdPais,Activo")] CiudadesModels ciudadesModels)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Ciudades.Add(ciudadesModels);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(ciudadesModels);
        //}

        //// GET: CiudadesModels/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CiudadesModels ciudadesModels = db.Ciudades.Find(id);
        //    if (ciudadesModels == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ciudadesModels);
        //}

        //// POST: CiudadesModels/Edit/5
        //// Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        //// más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "Id,Laptitud,Codigo,Longitud,Nombre,IdPais,Activo")] CiudadesModels ciudadesModels)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(ciudadesModels).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(ciudadesModels);
        //}

        //// GET: CiudadesModels/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    CiudadesModels ciudadesModels = db.Ciudades.Find(id);
        //    if (ciudadesModels == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(ciudadesModels);
        //}

        //// POST: CiudadesModels/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    CiudadesModels ciudadesModels = db.Ciudades.Find(id);
        //    db.Ciudades.Remove(ciudadesModels);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
