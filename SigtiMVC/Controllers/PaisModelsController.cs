using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using CapaDominioModel;
using CapaInfrastructura.Repositorios;
using SigtiMVC.Models;

namespace SigtiMVC.Controllers
{
    public class PaisModelsController : Controller
    {
        private SigtiEntities db = new SigtiEntities();
        private PaisRepository _PaisRepository = new PaisRepository();
        // GET: PaisModels
        public ActionResult Index()
        {
            var datoconsulta = _PaisRepository.GetPais();
           
            return View(datoconsulta);
        }

        // GET: PaisModels/Details/5
        public ActionResult Details(int id)
        {
            PaisModel paisModel = new PaisModel();
            paisModel.Id = id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapper.Initialize(cfg => cfg.CreateMap<Pais, PaisModel>()
               .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));


            Pais pais = _PaisRepository.FindById(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        // GET: PaisModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaisModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Laptitud,Codigo,Longitud,Nombre,Activo")] PaisModel paisModel)
        {
            if (ModelState.IsValid)
            {
                //db.Pais.Add(paisModel);
                //db.SaveChanges();

                Mapper.Initialize(cfg => cfg.CreateMap<PaisModel, Pais>()
                  .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

                // Выполняем сопоставление
                Pais pais = Mapper.Map<PaisModel, Pais>(paisModel);
                // db.Add(user);
                _PaisRepository.Add(pais);
                return RedirectToAction("Index");
            }

            return View(paisModel);
        }

        // GET: PaisModels/Edit/5
        public ActionResult Edit(int id)
        {
            PaisModel paisModel = new  PaisModel();
            paisModel.Id = id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //PaisModel paisModel = db.Pais.Find(id);
            //db.Entry(paisModel).State = EntityState.Modified;
            //db.SaveChanges();
            Mapper.Initialize(cfg => cfg.CreateMap<PaisModel, Pais>()
         .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

            // Выполняем сопоставление
            Pais pais = Mapper.Map<PaisModel, Pais>(paisModel);
            // db.Add(user);

            pais =  _PaisRepository.FindById(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        // POST: PaisModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Laptitud,Codigo,Longitud,Nombre,Activo")] PaisModel paisModel)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(paisModel).State = EntityState.Modified;
                //db.SaveChanges();
                Mapper.Initialize(cfg => cfg.CreateMap<PaisModel, Pais>()
             .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

                // Выполняем сопоставление
                Pais pais = Mapper.Map<PaisModel, Pais>(paisModel);
                // db.Add(user);
                _PaisRepository.Edit(pais);

                return RedirectToAction("Index");
            }
            return View(paisModel);
        }

        // GET: PaisModels/Delete/5
        public ActionResult Delete(int id)
        {
            PaisModel paisModel = new PaisModel();
            paisModel.Id = id;

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Mapper.Initialize(cfg => cfg.CreateMap<PaisModel, Pais>()
        .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

            // Выполняем сопоставление
            Pais pais = Mapper.Map<PaisModel, Pais>(paisModel);
            pais = _PaisRepository.FindById(id);
            if (pais == null)
            {
                return HttpNotFound();
            }
            return View(pais);
        }

        // POST: PaisModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //PaisModel paisModel = db.Pais.Find(id);
            //db.Pais.Remove(paisModel);
            //db.SaveChanges();
            PaisModel paisModel = new PaisModel();
            Mapper.Initialize(cfg => cfg.CreateMap<PaisModel, Pais>()
             .ForMember("Id", opt => opt.MapFrom(c => c.Id)));

            // Выполняем сопоставление
            Pais pais = Mapper.Map<PaisModel, Pais>(paisModel);
            // db.Add(user);
            int datoeliminar = pais.Id;
            _PaisRepository.Remove(pais.Id);

            return RedirectToAction("Index");
        }

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
