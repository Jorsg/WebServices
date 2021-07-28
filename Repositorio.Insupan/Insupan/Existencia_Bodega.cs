using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Insupan;
using Repositorio.Insupan;

namespace Repositorio.Insupan.Insupan
{
    public class Existencia_Bodega: RepositorioBase<EXISTENCIA_BODEGA>
    {
        public EXISTENCIA_BODEGA GetBodega(string bodega)
        {
            var query = Contexto.EXISTENCIA_BODEGA.FirstOrDefault(x => x.BODEGA == bodega);
            return query;
        }

        public List<EXISTENCIA_BODEGA> GetTodas()
        {
            var query = GetAll();
            return query.ToList();
        }

        public bool InsertInventario(EXISTENCIA_BODEGA inventario)
        {
            bool respuesta = false;
            try
            {
                Save(inventario);
                respuesta = true;
            }
            catch (Exception)
            {
                throw;
            }
            return respuesta;
        }

        public bool UpdatInventario(EXISTENCIA_BODEGA invetario)
        {
            bool respuesta = false;
            try
            {
                Update(invetario);
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
