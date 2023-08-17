using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidad;
using Capadatos;

namespace CapaNegocio
{
    public class CN_CATEGORIA
    {
        private static CD_CATEGORIA obj_categoria = new CD_CATEGORIA();
        public List<Categoria> lista()
        {
            return obj_categoria.Listar_Categoria();
        }

        public int Registrar_Categoria(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;
            
            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                mensaje = "La descripción no puede estar vacio";
            }

            if (string.IsNullOrEmpty(mensaje))
            {
                    return obj_categoria.Registrar_Categoria(obj, out mensaje);       
            }
            else
            {
                return 0;
            }
        }

        public int Editar_Categoria(Categoria obj, out string mensaje)
        {
            mensaje = string.Empty;

            if (string.IsNullOrEmpty(obj.Descripcion) || string.IsNullOrWhiteSpace(obj.Descripcion))
            {
                mensaje = "La descripción no puede estar vacio";
            }

            if (string.IsNullOrEmpty(mensaje))
            {
                return obj_categoria.Registrar_Categoria(obj, out mensaje);
            }
            else
            {
                return 0;
            }
        }
        public bool Eliminar(int id, out string mensaje)
        {
            return obj_categoria .Eliminar(id, out mensaje);
        }
    }
}
