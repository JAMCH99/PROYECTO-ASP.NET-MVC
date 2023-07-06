using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class detalleVenta
    {
        private int iddetalleventa;

        public int IdDetalleVenta
        {
            get { return iddetalleventa; }
            set { iddetalleventa = value; }
        }

        private Venta idventa;

        public Venta IdVenta
        {
            get { return idventa; }
            set { idventa = value; }
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
        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { total = value; }
        }

        public string IdTransaccion { get; set; }
    }
}
