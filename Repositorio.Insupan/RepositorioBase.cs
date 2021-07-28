using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Repositorio.Insupan.Interfaces;
using Dominio.Insupan;
using System.Linq.Expressions;

namespace Repositorio.Insupan
{
    public class RepositorioBase<T> : IRepositorioBaseGeneral<T> where T : class
    {
        bool _diposed;

        /// <summary>
        /// Contexto de la base de datos
        /// </summary>
        protected readonly InsupanEntities Contexto = new InsupanEntities();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        public void Delete(T entidad)
        {
            Contexto.Set<T>().Remove(entidad);
            Contexto.SaveChanges();
        }

        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Realiza una búsqueda acorde a una expresión
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public IQueryable<T> FindBy(Expression<Func<T, bool>> parametros)
        {
            return Contexto.Set<T>().Where(parametros);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> parametros, List<Expression<Func<T, object>>> inclusiones)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Obtiene todos los registros de una entidad
        /// </summary>
        /// <returns></returns>
        public IQueryable<T> GetAll()
        {
            return Contexto.Set<T>();
        }

        /// <summary>
        /// Obtiene todos los registros de la entidad que coincidan con los parámetros enviados
        /// </summary>
        /// <param name="inclusiones"></param>
        /// <returns></returns>
        public IQueryable<T> GetAll(List<Expression<Func<T, object>>> inclusiones)
        {
            var listaDeInclusiones = new List<string>();

            foreach (var body in inclusiones.Select(item => item.Body as MemberExpression))
            {
                if (body == null)
                    throw new ArgumentException("El elemento body debe ser un miembro de la expresión");

                listaDeInclusiones.Add(body.Member.Name);
            }

            DbQuery<T> query = Contexto.Set<T>();
            listaDeInclusiones.ForEach(x => query = query.Include(x));
            return query;
        }

        /// <summary>
        /// Guarda la información de la entidad enviada 
        /// </summary>
        /// <param name="entidad"></param>
        public void Save(T entidad)
        {
            Contexto.Set<T>().Add(entidad);
            Contexto.SaveChanges();
        }

        /// <summary>
        /// Actualiza los datos de las entidades
        /// </summary>
        /// <param name="entidad"></param>
        public void Update(T entidad)
        {
            Contexto.Entry(entidad).State = EntityState.Modified;
            Contexto.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_diposed)
                return;

            if (disposing)
                Contexto.Dispose();

            _diposed = true;
        }

        /// <summary>
        /// Obtiene un registro en base a los parámetros especificados
        /// </summary>
        /// <param name="parametros">Parámetros de búsqueda</param>
        /// <returns>Registro encontrado</returns>
        public T Single(Expression<Func<T, bool>> parametros)
        {
            return Contexto.Set<T>().FirstOrDefault(parametros);
        }

        public void Delete(Expression<Func<T, bool>> parametros)
        {
            throw new NotImplementedException();
        }
    }
}
