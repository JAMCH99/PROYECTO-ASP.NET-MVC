using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Producto
    {
        private int idproducto;

        public int IdProducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }

        private string descripcion;

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Marca idmarca;

        public Marca IdMarca
        {
            get { return idmarca; }
            set { idmarca = value; }
        }

        private Categoria idcategoria;

        public Categoria IdCategoria
        {
            get { return idcategoria; }
            set { idcategoria = value; }
        }

        private decimal precio;

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        private int stock;

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public string Ruta_de_Imagen { get; set; }
        public string Nombre_de_Imagen { get; set; }
        public bool Activo { get; set; }

    }
}
