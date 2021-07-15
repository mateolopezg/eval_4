using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eval_iv_mateo_lopez.Datos;
using eval_iv_mateo_lopez.Models;
using Microsoft.AspNetCore.Mvc;

namespace eval_iv_mateo_lopez.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClientesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Producto> listaProductos = new List<Producto>()
            {
                new Producto() {id_producto = 12333, nombre_p = "Jabon", stock = 12, valor = 2999},
                new Producto() {id_producto = 29272, nombre_p = "Cloro", stock = 12, valor = 1200}
            };
            List<Producto> listaProductos2 = new List<Producto>()
            {
                new Producto() {id_producto = 1234343433, nombre_p = "Pan", stock = 3, valor = 1999},
                new Producto() {id_producto = 323232, nombre_p = "Yerba Mate", stock = 4, valor = 4200}
            };


            List<Cliente> listaDura = new List<Cliente>()            
            {
                //Ingreso cliente 1
                new Cliente() {id_cliente = 1, nombre = "Juanito Perez", rut = "177382997-8", direccion = "Lugar de nunca jamás", telefono = "0092192222", productos = listaProductos, cantidad = 12},

                //Ingreso cliente 2
                new Cliente() {id_cliente = 2, nombre = "Pabla Narcisa", rut = "1733332997-8", direccion = "Gringolandia", telefono = "123123213", productos = listaProductos2, cantidad = 12},

            };
            

            //IEnumerable<Cliente> listaCliente = _context.Cliente;
            IEnumerable <Cliente> listaCliente = listaDura;

            return View(listaCliente);
        }

        //http get Create
        public IActionResult Create()
        {
            return View();
        }

        //http post Create
        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Add(cliente);
                _context.SaveChanges();

                TempData["mensaje"] = "El cliente fue ingresado";
                return RedirectToAction("Index");
            }

            return View();
        }

        //http post Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                _context.Cliente.Update(cliente);
                _context.SaveChanges();

                TempData["mensaje"] = "El cliente fue Actualizado";
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener Cliente
            var cliente = _context.Cliente.Find(id);

            if(cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }

        //http post Delete
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteCliente(int? id)
        {
            var cliente = _context.Cliente.Find(id);

            if(cliente == null)
            {
                return NotFound();
            }

           
             _context.Cliente.Remove(cliente);
             _context.SaveChanges();

             TempData["mensaje"] = "El cliente fue Eliminado";
             return RedirectToAction("Index");
         

            return View();
        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }

            //Obtener Cliente
            var cliente = _context.Cliente.Find(id);

            if (cliente == null)
            {
                return NotFound();
            }
            return View(cliente);
        }
    }
}
