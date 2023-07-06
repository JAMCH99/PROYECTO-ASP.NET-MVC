using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Carrito
    {
        private int idcarrito;

        public int IdCarrito
        {
            get { return idcarrito; }
            set { idcarrito = value; }
        }

        private Cliente idcliente;

        public Cliente IdCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private Producto idproducto;

        public Producto IdProducto
        {
            get { return idproducto; }
            set { idproducto = value; }
        }
        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

    }
}
