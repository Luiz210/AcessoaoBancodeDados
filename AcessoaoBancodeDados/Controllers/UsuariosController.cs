using AcessoaoBancodeDados.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcessoaoBancodeDados.Controllers
{
    public class UsuariosController : Controller
    {
        public readonly Contexto db;
        public UsuariosController(Contexto banco)
        {
            db = banco;
        }
        // GET: UsuariosController
        public ActionResult Index()
        {
            return View(db.USUARIOS.ToList());
        }


        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Usuario dadosTela)
        {
            db.USUARIOS.Add(dadosTela);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
    }
}
