using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Entidad;
using CapaNegocio;

namespace CapaPresentacionAdmi.Controllers
{
    public class MantenedorController : Controller
    {
        // GET: Mantenedor
        public ActionResult Categoria()
        {
            return View();
        }
        public ActionResult Marca()
        {
            return View();
        }
        public ActionResult Producto()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Listar_Categoria()
        {
            List<Categoria> olistar = new List<Categoria>();

            olistar = new CN_CATEGORIA().lista();

            return Json(new { data = olistar }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guardar_Categoria(Categoria objeto)
        {
            object resultado;
            string mensaje = string.Empty;

            if (objeto.IdCategoria == 0)
            {
                resultado = new CN_CATEGORIA().Registrar_Categoria(objeto, out mensaje);
            }
            else
            {
                resultado = new CN_CATEGORIA().Editar_Categoria(objeto, out mensaje);
            }
            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]

        public JsonResult Eliminacion(int id)
        {
            bool resultado = false;
            string mensaje = string.Empty;

            resultado = new CN_CATEGORIA().Eliminar(id, out mensaje);

            return Json(new { resultado = resultado, mensaje = mensaje }, JsonRequestBehavior.AllowGet);

        }
    }
}