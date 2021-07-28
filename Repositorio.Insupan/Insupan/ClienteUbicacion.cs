﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class ClienteUbicacion : RepositorioBase<ViewCLIENTES_UBICACIONES>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public ViewCLIENTES_UBICACIONES GetClientesContactos(string cliente)
        {
            var query = Contexto.ViewCLIENTES_UBICACIONES.FirstOrDefault(x => x.CLIENTE_ID == cliente);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<ViewCLIENTES_UBICACIONES> TodosClientesContactos()
        {
            var query = GetAll();
            return query.ToList();
        }

    }
}
