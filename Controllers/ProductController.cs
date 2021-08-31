using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AXSeniors_Reto.Data;
using AXSeniors_Reto.Models;
using Microsoft.AspNetCore.Mvc;

namespace AXSeniors_Reto.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        //HTTP Get Index
        public IActionResult Index()
        {
            IEnumerable<ProductModel> listProducts = _context.Product;

            return View(listProducts);
        }

        //HTTP Get Create
        public IActionResult Create()
        {
            return View();
        }

        //HTTP Post Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Add(product);
                _context.SaveChanges();

                TempData["mensaje"] = "El producto se ha agregado correctamente" ;
                return RedirectToAction("Index");
            }
            return View();
        }

        //HTTP Get Edit
        public IActionResult Edit(string? id)
        {
            if( id == null || id == "0")
            {
                return NotFound();
            }

            //Obtener producto
            var product = _context.Product.Find(id);

            if (product==null)
            {
                return NotFound();
            }

            return View(product);
        }

        //HTTP Post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(ProductModel product)
        {
            if (ModelState.IsValid)
            {
                _context.Product.Update(product);
                _context.SaveChanges();

                TempData["mensaje"] = "El producto se ha actualizado correctamente";
                return RedirectToAction("Index");
            }
            return View();
        }

        //HTTP Get Edit
        public IActionResult Delete(string? id)
        {
            if (id == null || id == "0")
            {
                return NotFound();
            }

            //Obtener producto
            var product = _context.Product.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        //HTTP Post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteProduct(string? id)
        {
            //Obtener el producto por Id
            var product = _context.Product.Find(id);

            if (product == null)
            {
                return NotFound();
            }

            _context.Product.Remove(product);
            _context.SaveChanges();

            TempData["mensaje"] = "El producto se ha eliminado correctamente";
                
            return RedirectToAction("Index");
           
           
        }

    }
}
