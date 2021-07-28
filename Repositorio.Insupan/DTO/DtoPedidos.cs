using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.DTO
{
    public class DtoPedidos
    {
        public string PEDIDO_ID { get; set; }
        public string CLIENTE_ID { get; set; } 
        public string ESTADO { get; set; }        
        public DateTime FECHA { get; set; }
        public DateTime HORA { get; set; }
        public string OBSERVACIONES { get; set; }
        public decimal VALOR_BRUTO { get; set; }
        public decimal VALOR_DESCUENTO { get; set; }
        public decimal VALOR_IVA { get; set; }
        public decimal VALOR_TOTAL { get; set; }  
        public DateTime FECHA_ENTREGA { get; set; }
        public string ASESOR_ID { get; set; }
        public string UBICACION_ID { get; set; }




    }
}
