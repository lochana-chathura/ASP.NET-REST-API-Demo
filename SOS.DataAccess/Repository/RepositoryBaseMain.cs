using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOS.DataAccess.Repository
{
    public class RepositoryBaseMain<T> : IRepositoryBase<T> where T : class
    {

        public DbContext _DataBase { get; set; }
        public DbSet<T> _Table { get; set; }

        public RepositoryBaseMain(DbContext context)
        {
            this._DataBase = context;
            this._Table = context.Set<T>();
        }

        public IEnumerable<T> FindAll()
        {
            try
            {
                return _Table;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Find(int Id)
        {
            try
            {
                return _Table.Find(Id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Modify(T Entity)
        {
            try
            {
                //DbEntityEntry<T> entry = _DataBase.Entry(Entity);
                //if (entry.State != EntityState.Detached)
                //{
                //    entry.State = EntityState.Modified;
                //}
                //else
                //{
                //    _Table.Attach(Entity);
                //}

                _DataBase.Entry(Entity).State = EntityState.Modified;
                _DataBase.SaveChanges();
                return Entity;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public T Save(T Entity)
        {
            try
            {
                DbEntityEntry<T> entry = _DataBase.Entry(Entity);
                if (entry.State != EntityState.Detached)
                {
                    entry.State = EntityState.Added;

                }
                else
                {
                    _Table.Add(Entity);
                }
                _DataBase.SaveChanges();
                return Entity;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = Find(id);
                if (entity != null)
                {
                    _Table.Remove(entity);
                    _DataBase.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
