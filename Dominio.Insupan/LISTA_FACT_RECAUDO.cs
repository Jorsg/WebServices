//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio.Insupan
{
    using System;
    using System.Collections.Generic;
    
    public partial class LISTA_FACT_RECAUDO
    {
        public string RECAUDO_ID { get; set; }
        public string ASESOR_ID { get; set; }
        public string FACTURA_ID { get; set; }
        public Nullable<decimal> SALDO_ANTERIOR { get; set; }
        public Nullable<decimal> VALOR_PAGO { get; set; }
        public Nullable<decimal> VALOR_DESCUENTO_FINANCIERO { get; set; }
        public Nullable<decimal> PORC_DESCUENTO_FINANCIERO { get; set; }
        public Nullable<decimal> PORC_RETEFUENTE { get; set; }
        public Nullable<decimal> VALOR_RETEFUENTE { get; set; }
        public Nullable<decimal> PORC_RETEICA { get; set; }
        public Nullable<decimal> VALOR_RETEICA { get; set; }
        public Nullable<decimal> PORC_CREE { get; set; }
        public Nullable<decimal> VALOR_CREE { get; set; }
    }
}
