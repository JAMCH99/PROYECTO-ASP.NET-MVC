using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//libreria para poder encriptar
 
using System.Security.Cryptography;

// librerias para poder enviar email a usuarios

using System.Net;
using System.Net.Mail;
using System.IO;

namespace CapaNegocio
{

    public class Recursos
    {
        // para enviar una clave unica al usuario 
        public static string GenerarClave()
        {
            string clave = Guid.NewGuid().ToString("N").Substring(0, 4);
            return clave;
        }

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

        // Metodo para enviar correos 

        public static bool EnviarCorreo(string correo,string asunto,string mensaje, out string men)
        {
            men = null;
            bool respuesta = false;

            try
            {
                //  creacion del correo

                MailMessage mail = new MailMessage();
                mail.To.Add(correo);
                mail.From = new MailAddress("pruebas.sistemas99@gmail.com");
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                // creando nuestro servidor encargado de enviar nuestro mensaje
                // será el que envia 

                var smtp = new SmtpClient()
                {
                    // el correo remitente debe estar autenticada comom el siguiente correo de prueba
                    Credentials = new NetworkCredential("pruebas.sistemas99@gmail.com", "nmisqtgautfpocsj"),
                    //servidor que utiliza gmail
                    Host = "smtp.gmail.com",
                    // puerto que utiliza 
                    Port = 587,
                    //habilitar el certificado de seguridad
                    EnableSsl = true
                };

                smtp.Send(mail);
                respuesta = true;

            }
            catch(Exception ex){ respuesta = false;  men = ex.Message; }

            return respuesta;
        }
    }
}
