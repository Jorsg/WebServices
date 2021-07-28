using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Insupan.DTO
{
    public class DtoPedido_Linea
    {
        public string PEDIDO_ID { get; set; }
        public string PRODUCTO_ID { get; set; }
        public string PRESENTACION_ID { get; set; }
        public decimal PRECIO_BASE { get; set; }        
        public decimal CANTIDAD_PRESENTACION { get; set; }
        public decimal DESCUENTO { get; set; }
        public decimal IVA { get; set; }
        public string COMENTARIO { get; set; }
        public string BODEGA_ID { get; set; }

    }
}
