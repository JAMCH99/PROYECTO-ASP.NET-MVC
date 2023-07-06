using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
   public class Marca
    {
        private int idmarca;

        public int IdMarca
        {
            get { return idmarca; }
            set { idmarca = value; }
        }
        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public bool Activo { get; set; }
    }
}
