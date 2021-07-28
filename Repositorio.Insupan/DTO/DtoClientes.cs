using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.DTO
{
    public class DtoClientes
    {
        public string CLIENTE_ID { get; set; }
        public string TIPO_IDENTIFICACION_ID { get; set; }
        public string NIT { get; set; }
        public string RAZON_SOCIAL { get; set; }
        public string CIIU { get; set; }
        public string TIPO_CLIENTE_ID { get; set; }
        public string LISTA_PRECIOS_ID { get; set; }
        public string TIPO_PERSONA_ID { get; set; }
        public string CONDICION_COMERCIAL_ID { get; set; }
        public decimal CUPO_CREDITO { get; set; }    
        public string BLOQUEO_PEDIDOS { get; set; }
        public string PED_DIAS_DESPACHO { get; set; }
        public string PED_VALOR_MINIMO { get; set; }
        public string ETAPA_ACTUAL { get; set; }
        public string PORC_RETEFUENTE { get; set; }
        public string CLASE_CLIENTE_ID { get; set; }
        public DateTime CreateDate1 { get; set; }
        
    }

   
}
