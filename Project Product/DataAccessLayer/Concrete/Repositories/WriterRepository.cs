using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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

        public void Insert(writer p)
        {
            _object.Add(p);
            c.SaveChanges();
        }

        public List<writer> List()
        {
            return _object.ToList();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public void Update(Category p)
        {
            c.SaveChanges();
        }

    }
}
