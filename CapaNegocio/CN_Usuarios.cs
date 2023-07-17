using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Capadatos;
using Entidad;

namespace CapaNegocio
{
    public class CN_Usuarios
    {
        private CD_Usuarios objcapadato_usuario = new CD_Usuarios();

        public List<Usuario> listar()
        {

            return objcapadato_usuario.Listar_Usuario();
        }

        //validadciones para registrar un usuario
        public int Registrar_Usuarios(Usuario obj, out string mensaje)
        {
            mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Nombre))
            {
                mensaje = "el nombre del usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Apellido) || string.IsNullOrWhiteSpace(obj.Apellido))
            {
                mensaje = "el apellido del usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                mensaje = "el correo del usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(mensaje))
            {
                string clave = "text 123";
                obj.Clave = Recursos.Encriptacion(clave);
                return objcapadato_usuario.Registrar_Usuarios(obj, out mensaje);
            }
            else
            {
                    return 0;
            }
        }

        // validaciones para editar

        public bool Editar_Usuarios(Usuario obj, out string mensaje)
        {

            mensaje = string.Empty;
            if (string.IsNullOrEmpty(obj.Nombre) || string.IsNullOrWhiteSpace(obj.Nombre))
            {
                mensaje = "el nombre del usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Apellido) || string.IsNullOrWhiteSpace(obj.Apellido))
            {
                mensaje = "el apellido del usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(obj.Correo) || string.IsNullOrWhiteSpace(obj.Correo))
            {
                mensaje = "el correo del usuario no puede estar vacio";
            }
            if (string.IsNullOrEmpty(mensaje))
            {
                return objcapadato_usuario.Editar_Usuarios(obj, out mensaje);
            }
            else
            {
                return false;
            }
        }
        public bool Eliminar(int id, out string mensaje)
        {
            return objcapadato_usuario.Eliminar(id, out mensaje);
        }
    }
}
