using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//libreria para poder encriptar
 
using System.Security.Cryptography;

namespace CapaNegocio
{
    public class Resumen
    {
        // metodo para la encriptacion del texto
        public static string Encriptacion(string text){
        // aprender mas sobre todo esto...
            StringBuilder sb = new StringBuilder();
            using (SHA256 hash= SHA256Managed.Create())
            {
                Encoding codigo = Encoding.UTF8;
                byte[] resultado = hash.ComputeHash(codigo.GetBytes(text));

                foreach(byte b in resultado)
                {
                    sb.Append(b.ToString("x2"));
                }
            }
            return sb.ToString(); ;
        }
    }
}
