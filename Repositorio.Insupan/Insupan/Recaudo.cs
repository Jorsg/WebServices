using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;
using Repositorio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Recaudo : RepositorioBase<DOCUMENTOS_CC>
    {
        public bool InsertRecaudo(DTO.DtoRecudo recudo)
        {
            bool respuesta = false;
            try
            {
                var recaudar = new DTO.Mapeo();
                Save(recaudar.MapearRecaudo(recudo));
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
