using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio.Insupan.DTO
{
    public class DtoRecudo
    {
        public string RECAUDO_ID { get; set; }
        public string ASESOR_ID { get; set; }
        public string PREIMPRESO { get; set; }
        public DateTime FECHA { get; set; }
        public string CLIENTE_ID { get; set; }  
        public decimal TOTAL_EFECTIVO { get; set; }
        public decimal TOTAL_RECAUDO { get; set; }
        public string OBSERVACIONES { get; set; }
    }
}
