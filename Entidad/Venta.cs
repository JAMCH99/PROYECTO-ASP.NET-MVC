using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class Venta
    {
        private int idventa;

        public int IdVenta
        {
            get { return idventa; }
            set { idventa = value; }
        }
        private Cliente idcliente;

        public Cliente Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        private int totalproducto;

        public int TotalProducto
        {
            get { return totalproducto; }
            set { totalproducto = value; }
        }

        private decimal montototal;
                
        public decimal MontoTotal
        {
            get { return montototal; }
            set { montototal = value; }
        }

        public string Contacto { get; set; }
        public string IdDistrito { get; set; }
        public string Telefono { get; set; }
        public string Direccion{ get; set; }
        public string FechaTexto { get; set; }

        public string IdTransaccion { get; set; }

        public List<detalleVenta> Detalle_de_la_venta { get; set; }

    }
}
