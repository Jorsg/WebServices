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
    
    public partial class DOCUMENTOS_CC
    {
        public string DOCUMENTO { get; set; }
        public string TIPO { get; set; }
        public string CONTRARECIBO { get; set; }
        public string APLICACION { get; set; }
        public System.DateTime FECHA_DOCUMENTO { get; set; }
        public System.DateTime FECHA { get; set; }
        public decimal MONTO { get; set; }
        public decimal SALDO { get; set; }
        public decimal MONTO_LOCAL { get; set; }
        public decimal SALDO_LOCAL { get; set; }
        public decimal MONTO_DOLAR { get; set; }
        public decimal SALDO_DOLAR { get; set; }
        public decimal MONTO_CLIENTE { get; set; }
        public decimal SALDO_CLIENTE { get; set; }
        public decimal TIPO_CAMBIO_MONEDA { get; set; }
        public decimal TIPO_CAMBIO_DOLAR { get; set; }
        public decimal TIPO_CAMBIO_CLIENT { get; set; }
        public decimal TIPO_CAMB_ACT_LOC { get; set; }
        public decimal TIPO_CAMB_ACT_DOL { get; set; }
        public decimal TIPO_CAMB_ACT_CLI { get; set; }
        public decimal SUBTOTAL { get; set; }
        public decimal DESCUENTO { get; set; }
        public decimal IMPUESTO1 { get; set; }
        public decimal IMPUESTO2 { get; set; }
        public decimal RUBRO1 { get; set; }
        public decimal RUBRO2 { get; set; }
        public decimal MONTO_RETENCION { get; set; }
        public decimal SALDO_RETENCION { get; set; }
        public string DEPENDIENTE { get; set; }
        public System.DateTime FECHA_ULT_CREDITO { get; set; }
        public string CARGADO_DE_FACT { get; set; }
        public string APROBADO { get; set; }
        public string ASIENTO { get; set; }
        public string ASIENTO_PENDIENTE { get; set; }
        public System.DateTime FECHA_ULT_MOD { get; set; }
        public string NOTAS { get; set; }
        public string CLASE_DOCUMENTO { get; set; }
        public System.DateTime FECHA_VENCE { get; set; }
        public short NUM_PARCIALIDADES { get; set; }
        public Nullable<System.DateTime> FECHA_REVISION { get; set; }
        public string COBRADOR { get; set; }
        public string USUARIO_ULT_MOD { get; set; }
        public string CONDICION_PAGO { get; set; }
        public string MONEDA { get; set; }
        public string CTA_BANCARIA { get; set; }
        public string VENDEDOR { get; set; }
        public string CLIENTE_REPORTE { get; set; }
        public string CLIENTE_ORIGEN { get; set; }
        public string CLIENTE { get; set; }
        public Nullable<short> SUBTIPO { get; set; }
        public decimal PORC_INTCTE { get; set; }
        public string CONTRATO { get; set; }
        public string TIPO_DOC_ORIGEN { get; set; }
        public string DOC_DOC_ORIGEN { get; set; }
        public Nullable<System.DateTime> FECHA_ANUL { get; set; }
        public string AUD_USUARIO_ANUL { get; set; }
        public Nullable<System.DateTime> AUD_FECHA_ANUL { get; set; }
        public Nullable<decimal> NUM_DOC_CB { get; set; }
        public Nullable<System.DateTime> FECHA_COBRO { get; set; }
        public string AUDITORIA_COBRO { get; set; }
        public Nullable<System.DateTime> FECHA_SEGUIMIENTO { get; set; }
        public string OBSERVACIONES_COBRO { get; set; }
        public string USUARIO_APROBACION { get; set; }
        public Nullable<System.DateTime> FECHA_APROBACION { get; set; }
        public string ANULADO { get; set; }
        public string CODIGO_IMPUESTO { get; set; }
        public string PAIS { get; set; }
        public string DIVISION_GEOGRAFICA1 { get; set; }
        public string DIVISION_GEOGRAFICA2 { get; set; }
        public Nullable<decimal> BASE_IMPUESTO1 { get; set; }
        public Nullable<decimal> BASE_IMPUESTO2 { get; set; }
        public string DEPENDIENTE_GP { get; set; }
        public decimal SALDO_TRANS { get; set; }
        public decimal SALDO_TRANS_LOCAL { get; set; }
        public decimal SALDO_TRANS_DOLAR { get; set; }
        public Nullable<System.DateTime> FECHA_PROYECTADA { get; set; }
        public Nullable<decimal> PORC_RECUPERACION { get; set; }
        public string TIPO_ASIENTO { get; set; }
        public string PAQUETE { get; set; }
        public decimal SALDO_TRANS_CLI { get; set; }
        public string DOCUMENTO_FISCAL { get; set; }
        public string FACTURADO { get; set; }
        public string GENERA_DOC_FE { get; set; }
        public string TASA_IMPOSITIVA { get; set; }
        public Nullable<decimal> TASA_IMPOSITIVA_PORC { get; set; }
        public string TASA_CREE1 { get; set; }
        public Nullable<decimal> TASA_CREE1_PORC { get; set; }
        public string TASA_CREE2 { get; set; }
        public Nullable<decimal> TASA_CREE2_PORC { get; set; }
        public Nullable<decimal> TASA_GAN_OCASIONAL_PORC { get; set; }
        public string ENTIDAD_FINANCIERA { get; set; }
        public byte NoteExistsFlag { get; set; }
        public System.DateTime RecordDate { get; set; }
        public System.Guid RowPointer { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CONTRATO_AC { get; set; }
        public string DOCUMENTO_GLOBAL { get; set; }
        public string CUENTA_ORIGEN { get; set; }
        public string USO_CFDI { get; set; }
        public string U_CLAVE_UNIDAD { get; set; }
        public string U_CLAVE_PROD_SERV { get; set; }
        public string FORMA_PAGO { get; set; }
        public string U_TIPO_RELACION { get; set; }
        public string CLAVE_REFERENCIA_DE { get; set; }
        public Nullable<System.DateTime> FECHA_REFERENCIA_DE { get; set; }
        public string JUSTI_DEV_HACIEND { get; set; }
        public string TIPO_OPERACION { get; set; }
        public string U_CLAVE_PS_PUB { get; set; }
        public string INCOTERMS { get; set; }
        public string CONSECUTIVO { get; set; }
        public string CLAVE_DE { get; set; }
        public string TIPO_IMPUESTO1 { get; set; }
        public string TIPO_TARIFA1 { get; set; }
        public string TIPO_IMPUESTO2 { get; set; }
        public string TIPO_TARIFA2 { get; set; }
        public string ACTIVIDAD_COMERCIAL { get; set; }
        public string ITEM_HACIENDA { get; set; }
        public string PREFIJO { get; set; }
        public Nullable<System.DateTime> FECHA_INICIO_RESOLUCION { get; set; }
        public Nullable<System.DateTime> FECHA_FINAL_RESOLUCION { get; set; }
        public string CLAVE_TECNICA { get; set; }
        public Nullable<int> MATRICULA_MERCANTIL { get; set; }
        public string ES_FACTURA_REEMPLAZO { get; set; }
        public string FACTURA_ORIGINAL_REEMPLAZO { get; set; }
        public string TIPO_REFERENCIA_DE { get; set; }
        public string CONSECUTIVO_FTC { get; set; }
        public string NUMERO_FTC { get; set; }
        public string NIT_TRANSPORTADOR { get; set; }
        public string CODIGO_REFERENCIA_DE { get; set; }
        public string NUM_OC_EXENTA { get; set; }
        public string NUM_CONS_REG_EXO { get; set; }
        public string NUM_IRSEDE_AGR_GAN { get; set; }
        public string U_AD_WM_TIPO_NC { get; set; }
    
        public virtual CLIENTE CLIENTE1 { get; set; }
        public virtual CLIENTE CLIENTE2 { get; set; }
        public virtual CLIENTE CLIENTE3 { get; set; }
        public virtual CUENTA_BANCARIA CUENTA_BANCARIA { get; set; }
        public virtual CONDICION_PAGO CONDICION_PAGO1 { get; set; }
        public virtual IMPUESTO IMPUESTO { get; set; }
    }
}
