using QuieroPizza.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuieroPizza.Web.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
            var producto1 = new ProductoModel();
            producto1.Id = 1;
            producto1.Descripcion = "Pizza 6 quesos";
            producto1.Masa = "Masa Delgada";

            var producto2 = new ProductoModel();
            producto2.Id = 2;
            producto2.Descripcion = "Pizza 4 Estaciones";
            producto2.Masa = "Masa Gruesa";

            var producto3 = new ProductoModel();
            producto3.Id = 3;
            producto3.Descripcion = "Pizza Jamón y Queso";
            producto3.Masa = "Masa Delgada";

            var calzone = new ProductoModel();
            calzone.Id = 4;
            calzone.Descripcion = "Calzone de Pollo y Pepperoni";
            
            var listadeProductos = new List<ProductoModel>();
            listadeProductos.Add(producto1);
            listadeProductos.Add(producto2);
            listadeProductos.Add(producto3);
            listadeProductos.Add(calzone);

            return View(listadeProductos);
        }
    }
}