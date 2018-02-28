using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModelCodeFirst;
using System.Data.Entity;

namespace Repository
{
    public class RepositoryAuthor
    {
        Model Context;

        public RepositoryAuthor()
        {
            Context = new Model();
        }
        public virtual int Create(Author entity)
        {
            try
            {
                object insertedItem = Context.Authors.Add(entity);
                Context.SaveChanges();
                return insertedItem != null ? int.TryParse(insertedItem.ToString(), out int result) ? result : 0 : 0;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public virtual void Update(Author entity)
        {
            try
            {
                Context.Authors.Attach(entity);
                Context.Entry(entity).State = EntityState.Modified;
                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public virtual void Delete(int id)
        {
        
            try
            {
                Author student = Context.Authors.Find(id);
                Context.Authors.Remove(student);
                Context.SaveChanges();
                

            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public IEnumerable<Author> GetAllAuthors()
        {
            return Context.Authors.ToList();
        }

    }
}
