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
    public class CategoriaModelsController : Controller
    {
        private SigtiEntities db = new SigtiEntities();
        private CategoriaRepositorios _CategoriaRepository = new CategoriaRepositorios();
        // GET: CategoriaModels
        public ActionResult Index()
        {
            

            var datoconsulta = _CategoriaRepository.GetCategorias();

            
            List<CategoriaModel> lstObj = new List<CategoriaModel>();


            foreach (var item in datoconsulta)
            {

                CategoriaModel item1 = new CategoriaModel();
                item1.id = item.id;
                item1.Codigo = item.Codigo;
                item1.Nombre = item.Nombre;
                item1.Descripcion = item.Descripcion;
                item1.Activo = item.Activo;
                lstObj.Add(item1);
               

            }
        
          
            return View(lstObj);
        }

        // GET: CategoriaModels/Details/5
        public ActionResult Details(int id)
        {
            CategoriaModel categoriaModel = new CategoriaModel();
            categoriaModel.id =  id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapper.Initialize(cfg => cfg.CreateMap<Categoria, CategoriaModel>()
             .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));


            Categoria categoria = _CategoriaRepository.FindById(id);

            //CategoriaModel categoriaModel = db.CategoriaModels.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // GET: CategoriaModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoriaModels/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,Codigo,Nombre,Descripcion,Activo")] CategoriaModel categoriaModel)
        {
            if (ModelState.IsValid)
            {
                //Mapper.Initialize(cfg => cfg.CreateMap<Categoria, CategoriaModel>()
                //.ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

                //// Выполняем сопоставление
                //Categoria categoria = Mapper.Map<CategoriaModel, Categoria>(categoriaModel);

                Categoria categoria = new CategoriaModel
                {
                    Codigo = categoriaModel.Codigo,
                    Nombre = categoriaModel.Nombre,
                    Descripcion = categoriaModel.Descripcion,
                    Activo = categoriaModel.Activo
                };
                // db.Add(user);
                _CategoriaRepository.Add(categoria);
                return RedirectToAction("Index");
            }

            return View(categoriaModel);
        }

        // GET: CategoriaModels/Edit/5
        public ActionResult Edit(int id)
        {
            CategoriaModel categoriaModel = new CategoriaModel();
            categoriaModel.id = id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapper.Initialize(cfg => cfg.CreateMap<CategoriaModel, Categoria>()
   .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

            // Выполняем сопоставление
            Categoria categoria = Mapper.Map<CategoriaModel, Categoria>(categoriaModel);
            // db.Add(user);

            categoria = _CategoriaRepository.FindById(id);
            
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: CategoriaModels/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Codigo,Nombre,Descripcion,Activo")] CategoriaModel categoriaModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(categoriaModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(categoriaModel);
        }

        // GET: CategoriaModels/Delete/5
        public ActionResult Delete(int id)
        {
            CategoriaModel categoriaModel = new CategoriaModel();
            categoriaModel.id = id;
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Mapper.Initialize(cfg => cfg.CreateMap<CategoriaModel, Categoria>()
            .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

            // Выполняем сопоставление
            Categoria categoria = Mapper.Map<CategoriaModel, Categoria>(categoriaModel);
            // db.Add(user);

            categoria = _CategoriaRepository.FindById(id);

            //CategoriaModel categoriaModel = db.CategoriaModels.Find(id);
            if (categoria == null)
            {
                return HttpNotFound();
            }
            return View(categoria);
        }

        // POST: CategoriaModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CategoriaModel categoriaModel = new CategoriaModel();
            categoriaModel.id = id;
            //CategoriaModel categoriaModel = db.CategoriaModels.Find(id);
            //db.CategoriaModels.Remove(categoriaModel);
            //db.SaveChanges();
            Mapper.Initialize(cfg => cfg.CreateMap<CategoriaModel, Categoria>()
            .ForMember("Nombre", opt => opt.MapFrom(c => c.Nombre)));

            // Выполняем сопоставление
            Categoria categoria = Mapper.Map<CategoriaModel, Categoria>(categoriaModel);
            // db.Add(user);

            // db.Add(user);
            _CategoriaRepository.Remove(categoria.id);
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
