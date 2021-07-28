using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Repositorio.Insupan.Insupan;
using Repositorio.Insupan.DTO;
using Dominio.Insupan;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Remoting.Activation;


/// <summary>
/// Descripción breve de ws_Insupan
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
// [System.Web.Script.Services.ScriptService]
public class ws_Insupan : System.Web.Services.WebService
{

    private readonly Cartera Repocartera = new Cartera();
    private readonly  Existencia_Bodega Repoexistencia = new Existencia_Bodega();
    private readonly Pedido Repopedido = new Pedido();
    private readonly Pedido_Linea RepopedidoLinea = new Pedido_Linea();
    private readonly Cliente_Cliente Repocliente = new Cliente_Cliente();
    private readonly Asignacion_Bodegas RepoasignBodega = new Asignacion_Bodegas();
    private readonly Asignacion_Clientes RepoasignCliente = new Asignacion_Clientes();
    private readonly Bancos_Cuentas RepobanCuenta = new Bancos_Cuentas();
    private readonly Cartera_Documentos RepocarteDocumento = new Cartera_Documentos();
    private readonly Cartera_TiposDoc RepocarteTipoDoc = new Cartera_TiposDoc();
    private readonly Inventario Repoinventario = new Inventario();
    private readonly ListaPrecios Repolistaprecio = new ListaPrecios();
    private readonly ProductoLineas RepoproductoLineas = new ProductoLineas();
    private readonly ProductoPresentacion RepoproductoPresentacion = new ProductoPresentacion();
    private readonly Productos Repoproductos = new Productos();
    private readonly TipoCliente RepotipoCliente = new TipoCliente();
    private readonly TiposIdentificacion RepotiposIdentificacion = new TiposIdentificacion();
    private readonly Condiciones_Comerciales RepoCondiciones = new Condiciones_Comerciales();
    private readonly Token repoToken = new Token();
    private readonly EncabezadoRecaudos repoEncaRecaudos = new EncabezadoRecaudos();
    private readonly ListaDiferenciaRecaudo repoLisDiRecaudo = new ListaDiferenciaRecaudo();
    private readonly ListaFactRecaudo repoLisFactRecaudo = new ListaFactRecaudo();
    private readonly ListaPagoRecaudo repoLisPaRecaudo = new ListaPagoRecaudo();
    private readonly EncabezadoPedido repoEncaPedido = new EncabezadoPedido();
    private readonly EncabezadoDevoluciones repoEncaDevoluciones = new EncabezadoDevoluciones();
    private readonly DetallePedido repoDetPedidos = new DetallePedido();
    private readonly DetalleDevolucion repoDetDevoluciones = new DetalleDevolucion();
    private readonly MaestroListaPrecio repoMaestroLisPrecio = new MaestroListaPrecio();
    private readonly ClientesContactos repoClienContacto = new ClientesContactos();
    private readonly ClienteUbicacion repoClienUbicacion = new ClienteUbicacion();
    private readonly CargueDevoluciones repoCarDevolucion = new CargueDevoluciones();
    private readonly CarguePedidos repoCarPedido = new CarguePedidos();
    private readonly Recaudo repoRecaudo = new Recaudo();
    private readonly ListaProductoDevueltos repolistaProductoDevueltos = new ListaProductoDevueltos();
    private readonly Impuestos repoImpuestos = new Impuestos();

    private static bool tokenValido = false;
    
  
  
    
    public ws_Insupan()
    {

        //Elimine la marca de comentario de la línea siguiente si utiliza los componentes diseñados 
        //InitializeComponent(); 
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public bool AutenticarToken(string token)
    {
        tokenValido = repoToken.ValidaToken(token);
        return tokenValido;
    }
    
    [WebMethod]    
    public PEDIDO Pedido(string pedido)
    {
        var result = new PEDIDO();
        if (tokenValido)
            result = Repopedido.GetPedido(pedido);
        else
            result = null;
        
        return result;
    }

    [WebMethod]
    public List<PEDIDO> ListarPedidos()
    {
        var result = new List<PEDIDO>();
        if (tokenValido)
            result = Repopedido.GetTodos();

        return result;
    }

    [WebMethod]
    public bool CrearEncabezadoPedido(PEDIDO pedido)
    {
        bool result = false;
        if(tokenValido)
        {
            var pedidos = new PEDIDO
            {
                PEDIDO1 = pedido.PEDIDO1,//"A13-2",            
                VENDEDOR = pedido.VENDEDOR,//"ND",
                FECHA_HORA = pedido.FECHA_HORA,//Convert.ToDateTime("21/08/2020 7:07:31"),             
                DIRECCION_FACTURA = pedido.DIRECCION_FACTURA,//"1036615730",
                MONTO_DESCUENTO1 = pedido.MONTO_DESCUENTO1,//0,
                AUTORIZADO = pedido.AUTORIZADO,//"N",
                BACKORDER = pedido.BACKORDER,//"N",
                BODEGA = pedido.BODEGA,//"1",
                CAMBIOS_COTI = pedido.CAMBIOS_COTI,
                CLASE_PEDIDO = pedido.CLASE_PEDIDO,//"N",
                CLIENTE = pedido.CLIENTE,//"1036615730",               
                CLIENTE_CORPORAC = pedido.CLIENTE_CORPORAC,//"1036615730",
                CLIENTE_DIRECCION = pedido.CLIENTE_DIRECCION,//"1036615730",
                CLIENTE_ORIGEN = pedido.CLIENTE_ORIGEN,//"1036615730",
                COBRADOR = pedido.COBRADOR,//"ND",
                CONDICION_PAGO = pedido.CONDICION_PAGO,//"30",
                CONTRATO_REVENTA = pedido.CONTRATO_REVENTA,//"",
                CORREOS_ENVIO = pedido.CORREOS_ENVIO,//"",
                COTIZACION_PADRE = pedido.COTIZACION_PADRE,//"",
                CreateDate = pedido.CreateDate,//DateTime.Now,
                CreatedBy = pedido.CreatedBy,//"FA/FACTURACION",
                UpdatedBy = pedido.UpdatedBy,//"FA/FACTURACION",
                DESCUENTO_CASCADA = pedido.DESCUENTO_CASCADA,//"N",
                DESCUENTO_VOLUMEN = pedido.DESCUENTO_VOLUMEN,//0,
                DESC_DIREC_EMBARQUE = pedido.DESC_DIREC_EMBARQUE,
                DES_CANCELA_COTI = pedido.DES_CANCELA_COTI,
                DIREC_EMBARQUE = pedido.DIREC_EMBARQUE,//"ND",
                DIVISION_GEOGRAFICA1 = pedido.DIVISION_GEOGRAFICA1,//"05",
                DIVISION_GEOGRAFICA2 = pedido.DIVISION_GEOGRAFICA2,//"631",
                DOC_A_GENERAR = pedido.DOC_A_GENERAR,//"F",
                EMBARCAR_A = pedido.EMBARCAR_A,//"ALISON  MONTOYA GARCES",              
                FECHA_PROMETIDA = pedido.FECHA_PROMETIDA,//Convert.ToDateTime("21/08/2020 7:07:31"),
                FECHA_PROX_EMBARQU = pedido.FECHA_PROX_EMBARQU,//Convert.ToDateTime("21/08/2020 7:07:31"),
                FECHA_PROYECTADA = pedido.FECHA_PROYECTADA,//Convert.ToDateTime("21/08/2020 7:07:31"),
                FECHA_PEDIDO = pedido.FECHA_PEDIDO,//DateTime.Now,
                FIJAR_TIPO_CAMBIO = pedido.FIJAR_TIPO_CAMBIO,//"N",
                IMPRESO = pedido.IMPRESO,//"N",
                MONEDA = pedido.MONEDA,//"L",
                MONEDA_PEDIDO = pedido.MONEDA_PEDIDO,//"N",
                MONTO_ANTICIPO = pedido.MONTO_ANTICIPO,//0,
                MONTO_DESCUENTO2 = pedido.MONTO_DESCUENTO2,///0,
                MONTO_DOCUMENTACIO = pedido.MONTO_DOCUMENTACIO,//0,                
                MONTO_FLETE = pedido.MONTO_FLETE,//0,
                MONTO_SEGURO = pedido.MONTO_SEGURO,//0,
                NIVEL_PRECIO = pedido.NIVEL_PRECIO,//Convert.ToString("ND-LOCAL"),
                ORIGEN_PEDIDO = pedido.ORIGEN_PEDIDO,//"F",
                PAIS = pedido.PAIS,//"169",
                PORC_COMI_COBRADOR = pedido.PORC_COMI_COBRADOR,//0,
                PORC_COMI_VENDEDOR = pedido.PORC_COMI_VENDEDOR,//0,
                PORC_DESCUENTO1 = pedido.PORC_DESCUENTO1,//0,
                PORC_DESCUENTO2 = pedido.PORC_DESCUENTO2,//0,
                RUTA = pedido.RUTA,//"ND",
                TIPO_DESCUENTO1 = pedido.TIPO_DESCUENTO1,//"P",
                TIPO_DESCUENTO2 = pedido.TIPO_DESCUENTO2,//"P",
                TIPO_DOCUMENTO = pedido.TIPO_DOCUMENTO,//"P",
                TIPO_OPERACION = pedido.TIPO_OPERACION,//"",
                TIPO_PEDIDO = pedido.TIPO_PEDIDO,//"N",
                TOTAL_CONTRATO_AC = pedido.TOTAL_CONTRATO_AC,//450534,
                TOTAL_CANCELADO = pedido.TOTAL_CANCELADO,//0,
                TOTAL_UNIDADES = pedido.TOTAL_UNIDADES,//0,
                TOTAL_IMPUESTO1 = pedido.TOTAL_IMPUESTO1,//0,
                TOTAL_IMPUESTO2 = pedido.TOTAL_IMPUESTO2,//0,
                USUARIO = pedido.USUARIO,//"FACTURACION",
                VERSION_COTIZACION = pedido.VERSION_COTIZACION,//"",
                VERSION_NP = pedido.VERSION_NP,//0,
                ZONA = pedido.ZONA,//"ND",
                ESTADO = pedido.ESTADO,//"N",
                TOTAL_MERCADERIA = pedido.TOTAL_MERCADERIA,//500000,
                NoteExistsFlag = pedido.NoteExistsFlag,//0,
                RecordDate = pedido.RecordDate,//DateTime.Now,
                RowPointer = pedido.RowPointer,//System.Guid.NewGuid(),
                TOTAL_A_FACTURAR = pedido.TOTAL_A_FACTURAR,
                BASE_IMPUESTO1 = pedido.BASE_IMPUESTO1,
                BASE_IMPUESTO2 = pedido.BASE_IMPUESTO2,
                TASA_IMPOSITIVA = pedido.TASA_IMPOSITIVA,
                TASA_IMPOSITIVA_PORC = pedido.TASA_IMPOSITIVA_PORC,
                TASA_CREE1_PORC = pedido.TASA_CREE1_PORC,
                TASA_CREE2_PORC = pedido.TASA_CREE2_PORC,
                TASA_GAN_OCASIONAL_PORC = pedido.TASA_GAN_OCASIONAL_PORC,
                TIPO_DOC_CXC = pedido.TIPO_DOC_CXC,
                FECHA_ULT_EMBARQUE = pedido.FECHA_ULT_EMBARQUE,
                FECHA_ULT_CANCELAC = pedido.FECHA_ULT_CANCELAC,
                ES_FACTURA_REEMPLAZO = pedido.ES_FACTURA_REEMPLAZO,
                FECHA_ORDEN = pedido.FECHA_ORDEN,
                MONTO_OTRO_CARGO = pedido.MONTO_OTRO_CARGO,
                PORC_INTCTE = pedido.PORC_INTCTE,
                SUBTIPO_DOC_CXC = pedido.SUBTIPO_DOC_CXC
                
            };         

            result = Repopedido.InsertPedido(pedidos);
        }      
        return result;
    }

    /// <summary>
    /// Lista el detalle del pedido por pedido
    /// </summary>
    /// <param name="pedidoLinea"></param>
    /// <returns></returns>
    [WebMethod]
    public PEDIDO_LINEA PedidoLinea(string pedidoLinea)
    {
        var result = new PEDIDO_LINEA();
        if(tokenValido)
        result = RepopedidoLinea.GetPedido_Linea(pedidoLinea);

        return result;
    }

    /// <summary>
    /// Lista todos los detalles de factura
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<PEDIDO_LINEA> ListarPedidosLinea()
    {
        var result = new List<PEDIDO_LINEA>();
        if(tokenValido)
          result =  RepopedidoLinea.GetTodos();

        return result;
    }

    /// <summary>
    /// Crea un pedido 
    /// </summary>
    /// <param name="pedidoLinea"></param>
    /// <returns></returns>
    [WebMethod]
    public bool CrearDetallePedido(PEDIDO_LINEA pedidoLinea)
    {
        bool result = false;
        if(tokenValido)
        {
            var detalles = new PEDIDO_LINEA
            {
                ARTICULO = pedidoLinea.ARTICULO,
                BODEGA = pedidoLinea.BODEGA,
                CANTIDAD_A_FACTURA = pedidoLinea.CANTIDAD_A_FACTURA,
                CANTIDAD_BONIFICAD = pedidoLinea.CANTIDAD_BONIFICAD,
                CANTIDAD_CANCELADA = pedidoLinea.CANTIDAD_CANCELADA,
                CANTIDAD_FACTURADA = pedidoLinea.CANTIDAD_FACTURADA,
                CANTIDAD_PEDIDA = pedidoLinea.CANTIDAD_PEDIDA,
                CANTIDAD_RESERVADA = pedidoLinea.CANTIDAD_RESERVADA,
                ESTADO = pedidoLinea.ESTADO,
                FECHA_ENTREGA = pedidoLinea.FECHA_ENTREGA,
                FECHA_PROMETIDA = pedidoLinea.FECHA_PROMETIDA,
                LINEA_USUARIO = pedidoLinea.LINEA_USUARIO,
                PEDIDO = pedidoLinea.PEDIDO,
                PEDIDO_LINEA1 = pedidoLinea.PEDIDO_LINEA1,
                PORC_DESCUENTO = pedidoLinea.PORC_DESCUENTO,
                PRECIO_UNITARIO = pedidoLinea.PRECIO_UNITARIO,
                TIPO_DESCUENTO = pedidoLinea.TIPO_DESCUENTO,
                MONTO_DESCUENTO = pedidoLinea.MONTO_DESCUENTO,
                NoteExistsFlag = pedidoLinea.NoteExistsFlag,
                RowPointer = pedidoLinea.RowPointer,
                CreateDate = pedidoLinea.CreateDate,
                CreatedBy = pedidoLinea.CreatedBy,
                UpdatedBy = pedidoLinea.UpdatedBy,
                RecordDate = pedidoLinea.RecordDate
            };

            return RepopedidoLinea.InsertPedido_Linea(detalles);
        }        
        return result;
    }

    /// <summary>
    /// lista cliente por cedula
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    [WebMethod]
    public CLIENTE Cliente(string cliente)
    {
        var result = new CLIENTE();
        if(tokenValido)
          result = Repocartera.GetCLIENTE(cliente);

        return result;
    }

    /// <summary>
    /// Lista todos los clientes
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<CLIENTE> ListarCliente()
    {
        var result = new List<CLIENTE>();
        if(tokenValido)
           result = Repocartera.GetTodos();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cliente"></param>
    /// <returns></returns>
    [WebMethod]
    public bool CrearClientes(CLIENTE cliente)
    {
        bool result = false;
        if (tokenValido)
        {
            var client = new DtoClientes
            {
                CLIENTE_ID = cliente.CLIENTE1,
                NIT = cliente.CONTRIBUYENTE,
                RAZON_SOCIAL = cliente.NOMBRE,
                CIIU = cliente.REGIMEN_TRIB,
                TIPO_CLIENTE_ID = cliente.TIPIFICACION_CLIENTE,
                CONDICION_COMERCIAL_ID = cliente.CONDICION_PAGO,
                TIPO_PERSONA_ID = cliente.CLASE_DOCUMENTO,
                CUPO_CREDITO = (decimal)cliente.LIMITE_CREDITO,
                CreateDate1 = (DateTime)cliente.FECHA_HORA_CREACION

            };
            result = Repocartera.InsertCliente(client);
        }        
        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bodega"></param>
    /// <returns></returns>
    [WebMethod]
    public EXISTENCIA_BODEGA Bodega(string bodega)
    {
        var result = new EXISTENCIA_BODEGA();
        if(tokenValido)
           result = Repoexistencia.GetBodega(bodega);

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<EXISTENCIA_BODEGA> ListarBodegas()
    {
        var result = new List<EXISTENCIA_BODEGA>();
        if(tokenValido)
          result = Repoexistencia.GetTodas();

        return result;
    }    

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bodega"></param>
    /// <returns></returns>
    [WebMethod]
    public  List<BODEGA> ListarAsigacion_Bodegas()
    {
        var result = new List<BODEGA>();
        if(tokenValido)
         result = RepoasignBodega.TodasAsignacionBodegas();

        return result;
    }   

    /// <summary>
    /// 
    /// </summary>
    /// <param name="idAsesor"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ViewAsignacion_Clientes> ListarAsignar_Clientes()
    {
        var result = new List<ViewAsignacion_Clientes>();
        if(tokenValido)
          result = RepoasignCliente.TodasAsignacionClientes();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cuenta"></param>
    /// <returns></returns>
    [WebMethod]
    public CUENTA_BANCARIA BancosCuentas(string cuenta)
    {
        var result = new CUENTA_BANCARIA();
        if(tokenValido)
          result = RepobanCuenta.GetBancosCuentas(cuenta);

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<CUENTA_BANCARIA> ListarBancosCuentas()
    {
        var result = new List<CUENTA_BANCARIA>();
        if(tokenValido)
        result = RepobanCuenta.TodosBancosCuentas();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="documentos"></param>
    /// <returns></returns>
    [WebMethod]
    public DOCUMENTOS_CC ListarCarteraDocumentos(string documentos)
    {
        var result = new DOCUMENTOS_CC();
        if(tokenValido)
          result = RepocarteDocumento.GetCarteraDocumentos(documentos);

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<DOCUMENTOS_CC> ListarTodosCarteraDocumentos()
    {
        var result = new List<DOCUMENTOS_CC>();
        if(tokenValido)
          result = RepocarteDocumento.TodosCarteraDocumento();

        return result;
    }       

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tipoDocumento"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ViewCARTERA_DOCUMENTOS> ListarCarteraTipoDocumento()
    {
        var result = new List<ViewCARTERA_DOCUMENTOS>();
        if(tokenValido)
         result = RepocarteTipoDoc.TodosCarteraTipoDoc();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="codicionesComerciales"></param>
    /// <returns></returns>
    [WebMethod]
    public List<CONDICION_PAGO> ListarCondicionesComerciales()
    {
        var result = new List<CONDICION_PAGO>();
        if(tokenValido)
          result = RepoCondiciones.TodosCondicionesComerciales();

        return result;
    }   

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bodegaId"></param>
    /// <returns></returns>
    [WebMethod]
    public List<EXISTENCIA_BODEGA> ListarInventario()
    {
        var result = new List<EXISTENCIA_BODEGA>();
        if(tokenValido)
          result = Repoinventario.TodosInventario();

        return result;
    }   

    /// <summary>
    /// 
    /// </summary>
    /// <param name="listPrecio"></param>
    /// <returns></returns>
    [WebMethod]
    public ARTICULO_PRECIO ListaPrecio(string listPrecio)
    {
        var result = new ARTICULO_PRECIO();
        if(tokenValido)
          result = Repolistaprecio.GetListaPrecio(listPrecio);

        return result;
    }


    /// <summary>
    /// 
    /// </summary>
    /// <param name="productId"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ARTICULO> ListarProducto()
    {
        var result = new List<ARTICULO>();
        if(tokenValido)
          result = Repoproductos.TodosProductos();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productoId"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ViewPRODUCTOS_PRESENTACION> ListarProductoPresentacion()
    {
        var result = new List<ViewPRODUCTOS_PRESENTACION>();
        if(tokenValido)
         result = RepoproductoPresentacion.TodosProdctoPresenta();

        return result;
    }    

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tipoIdentificacion"></param>
    /// <returns></returns>
    [WebMethod]
    public List<CLIENTE> TipoCliente()
    {
        var result = new List<CLIENTE>();
        if(tokenValido)
          result = Repocliente.GetTodos();

        return result;
    }   

    /// <summary>
    /// 
    /// </summary>
    /// <param name="tipoIdentificacion"></param>
    /// <returns></returns>
    [WebMethod]
    public List<TIPO_NIT> Tipo_Identificacion()
    {
        var result = new List<TIPO_NIT>();
        if(tokenValido)
         result =  RepotiposIdentificacion.TodosTipoIdentificacion();

        return result;
    }


        /// <summary>
    /// 
    /// </summary>
    /// <param name="recaudo"></param>
    /// <returns></returns>
    [WebMethod]
    public bool CrearEncabezado_Recaudo(DOCUMENTOS_CC recaudo)
    {
        bool result = false;
        if (tokenValido)
        {
            var recau = new DtoRecudo
            { 
                ASESOR_ID = recaudo.VENDEDOR,
                CLIENTE_ID = recaudo.CLIENTE_ORIGEN,
                FECHA = recaudo.FECHA_DOCUMENTO,
                OBSERVACIONES = recaudo.OBSERVACIONES_COBRO,
                PREIMPRESO = recaudo.APLICACION,
                RECAUDO_ID = recaudo.DOCUMENTO,
                TOTAL_EFECTIVO = recaudo.MONTO_LOCAL,
                TOTAL_RECAUDO = recaudo.MONTO
            };
            result = repoRecaudo.InsertRecaudo(recau);             
        }
        return result;
    }   

    /// <summary>
    /// Lista los pagos recaudados
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<ViewPAGO_RECAUDO> ListaPago_Recaudo()
    {
        var result = new List<ViewPAGO_RECAUDO>();
        if (tokenValido)
            result = repoLisPaRecaudo.TodosListaPagoRecaudo();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<ARTICULO_PRECIO> Listar_Precios()
    {
        var result = new List<ARTICULO_PRECIO>();
        if (tokenValido)
            result = Repolistaprecio.TodosListaPrecio();

        return result;
    }

    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<NIVEL_PRECIO> ListaMaestroLista_Precios()
    {
        var result = new List<NIVEL_PRECIO>();
        if (tokenValido)
            result = repoMaestroLisPrecio.TodosMaestrosListasPrecios();

        return result;
    }    

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<ViewCLIENTES_CONTACTOS> ListarClietes_Contactos()
    {
        var result = new List<ViewCLIENTES_CONTACTOS>();
        if (tokenValido)
            result = repoClienContacto.TodosClientesContactos();

        return result;
    }   

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<ViewCLIENTES_UBICACIONES> ListarClientes_Ubicacion()
    {
        var result = new List<ViewCLIENTES_UBICACIONES>();
        if (tokenValido)
            result = repoClienUbicacion.TodosClientesContactos();

        return result;
    }

        
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<CLASIFICACION> ListarProductos_Linea()
    {
        var result = new List<CLASIFICACION>();
        if (tokenValido)
            result = RepoproductoLineas.TodosProductosLinea();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productoId"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ViewFACTURA_RECAUDO> ListarFactura_Recaudo()
    {
        var result = new List<ViewFACTURA_RECAUDO>();
        if (tokenValido)
            result = repoLisFactRecaudo.TodosListaFacturaRecaudo();

        return result;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="productoId"></param>
    /// <returns></returns>
    [WebMethod]
    public List<ViewPRODUCTO_DEVUELTOS> ListarProducto_Devuletos()
    {
        var result = new List<ViewPRODUCTO_DEVUELTOS>();
        if (tokenValido)
            result = repolistaProductoDevueltos.TodosListaPagoRecaudo();

        return result;
    }

    /// <summary>
    /// Se consulta un impuesto de pendiendo del parametro que se le envíe
    /// </summary>
    /// <param name="impuestos"></param>
    /// <returns></returns>
    [WebMethod]
    public IMPUESTO Impuesto(string impuestos)
    {
        var result = new IMPUESTO();
        if (tokenValido)
            result = repoImpuestos.GetImpuesto(impuestos);

        return result;
    }

    /// <summary>
    /// Lista todos los impuestos que existen en la BD
    /// </summary>
    /// <returns></returns>
    [WebMethod]
    public List<IMPUESTO> TodosImpuestos()
    {
        var result = new List<IMPUESTO>();
        if (tokenValido)
            result = repoImpuestos.TodosImpuestos();

        return result;
    }

    
}
