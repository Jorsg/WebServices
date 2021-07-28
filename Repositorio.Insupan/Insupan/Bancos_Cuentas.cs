using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repositorio.Insupan;
using Dominio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Bancos_Cuentas : RepositorioBase<CUENTA_BANCARIA>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="documentos"></param>
        /// <returns></returns>
        public CUENTA_BANCARIA GetBancosCuentas(string cuenta)
        {
            var query = Contexto.CUENTA_BANCARIA.FirstOrDefault(x => x.CUENTA_BANCO == cuenta);
            return query;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<CUENTA_BANCARIA> TodosBancosCuentas()
        {
            var query = GetAll();
            return query.ToList();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="carteraDocumento"></param>
        /// <returns></returns>
        public bool InsertBancosCuentas(CUENTA_BANCARIA bancosCuentas)
        {
            bool respuesta = false;
            try
            {
                Save(bancosCuentas);
                respuesta = true;
            }
            catch (Exception)
            {
                throw;
            }
            return respuesta;
        }
    }
}
