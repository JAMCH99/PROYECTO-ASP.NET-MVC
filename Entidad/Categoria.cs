using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Categoria
    {
        private int idcategoria;

        public int IdCategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
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
