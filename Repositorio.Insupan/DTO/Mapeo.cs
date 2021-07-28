using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;
using Repositorio.Insupan.DTO;

namespace Repositorio.Insupan.DTO
{
    public class Mapeo
    {
        public CLIENTE MapearCliente(DtoClientes clientes)
        {
            CLIENTE dto = new CLIENTE();
            dto.CLIENTE1 = clientes.CLIENTE_ID;
            dto.CONTRIBUYENTE = clientes.NIT;
            dto.NOMBRE = clientes.RAZON_SOCIAL;
            dto.REGIMEN_TRIB = clientes.CIIU;
            dto.TIPIFICACION_CLIENTE = clientes.TIPO_CLIENTE_ID;
            dto.CONDICION_PAGO = clientes.CONDICION_COMERCIAL_ID;
            dto.CLASE_DOCUMENTO = clientes.TIPO_PERSONA_ID;
            dto.LIMITE_CREDITO = clientes.CUPO_CREDITO;
            dto.FECHA_HORA_CREACION = clientes.CreateDate1;
                       
            return dto;
        }

        public PEDIDO MapearPedido(DtoPedidos pedido)
        {
            PEDIDO dto = new PEDIDO();

            dto.PEDIDO1 = pedido.PEDIDO_ID;
            dto.CLIENTE_CORPORAC = pedido.CLIENTE_ID;
            dto.FECHA_HORA = pedido.FECHA;
            dto.OBSERVACIONES = pedido.OBSERVACIONES;
            dto.VENDEDOR = pedido.ASESOR_ID;
            dto.TOTAL_A_FACTURAR = pedido.VALOR_TOTAL;
            dto.TOTAL_MERCADERIA = pedido.VALOR_BRUTO;
            dto.TOTAL_IMPUESTO1 = pedido.VALOR_IVA;
            dto.MONTO_DESCUENTO1 = pedido.VALOR_DESCUENTO;
            dto.FECHA_PEDIDO = pedido.FECHA_ENTREGA;
            dto.DIRECCION_FACTURA = pedido.UBICACION_ID;
            return dto;
        }


        public PEDIDO_LINEA MapearPedidoLinea(DtoPedido_Linea pedidoLinea)
        {
            PEDIDO_LINEA dto = new PEDIDO_LINEA();

            dto.PEDIDO = pedidoLinea.PEDIDO_ID;
            dto.ARTICULO = pedidoLinea.PRODUCTO_ID;
            dto.DESCRIPCION = pedidoLinea.PRESENTACION_ID;
            dto.CANTIDAD_PEDIDA = pedidoLinea.CANTIDAD_PRESENTACION;
            dto.PRECIO_UNITARIO = pedidoLinea.PRECIO_BASE;
            dto.MONTO_DESCUENTO = pedidoLinea.DESCUENTO;
            dto.COMENTARIO = pedidoLinea.COMENTARIO;
            dto.BODEGA = pedidoLinea.BODEGA_ID;
            dto.PORC_IMP1_BASE = pedidoLinea.IVA;           

            return dto;
        }

        public DOCUMENTOS_CC MapearRecaudo(DtoRecudo recaudo)
        {
            DOCUMENTOS_CC dto = new DOCUMENTOS_CC();
            dto.DOCUMENTO = recaudo.RECAUDO_ID;
            dto.VENDEDOR = recaudo.ASESOR_ID;
            dto.APLICACION = recaudo.PREIMPRESO;
            dto.FECHA_DOCUMENTO = recaudo.FECHA;
            dto.CLIENTE_ORIGEN = recaudo.CLIENTE_ID;
            dto.MONTO = recaudo.TOTAL_RECAUDO;
            dto.MONTO_LOCAL = recaudo.TOTAL_EFECTIVO;
            dto.OBSERVACIONES_COBRO = recaudo.OBSERVACIONES;
            return dto;
        }
    }
}
