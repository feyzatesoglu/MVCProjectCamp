using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class WriterRepository : IWriterDal
    {
        Context c = new Context();
        DbSet<writer> _object;

        public void Delete(writer p)
        {
            _object.Remove(p);
            c.SaveChanges();
        }

        public writer Get(Expression<Func<writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Insert(writer p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<writer> List()
        {
            return _object.ToList();
        }

        public List<writer> List(Expression<Func<writer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        //public List<Category> List(Expression<Func<Category, bool>> filter)
        //{
        //    //
        //}

        public void Update(Category p)
        {
            c.SaveChanges();
        }

        public void Update(writer p)
        {
            throw new NotImplementedException();
        }
    }
}
