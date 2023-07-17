using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using Entidad;
using CapaNegocio;

namespace CapaPresentacionAdmi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Usuarios()
        {
            return View();
        }

        [HttpGet]
        public JsonResult Listar_Usuarios()
        {
            List<Usuario> olistar = new List<Usuario>();

            olistar = new CN_Usuarios().listar();

            return Json(new { data = olistar}, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult Guardar_Usuarios(Usuario objeto)
        {
            object resultado;
            string mensaje = string.Empty;
             
            if (objeto.IdUsuario == 0)
            {
                resultado = new CN_Usuarios().Registrar_Usuarios(objeto,out mensaje);
            }
            else {
                resultado = new CN_Usuarios().Editar_Usuarios(objeto, out mensaje);
            }
            return Json(new { resultado = resultado, mensaje= mensaje }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        
        public JsonResult Eliminacion(int id)
        {
            bool resultado = false;
            string mensaje = string.Empty;

            resultado = new CN_Usuarios().Eliminar(id,out mensaje);

            return Json(new {resultado= resultado,mensaje=mensaje },JsonRequestBehavior.AllowGet);

        }
    }
}