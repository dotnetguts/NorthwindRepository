using NorthwindRepo.Interfaces;
using PetaPoco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindRepo.Business
{
    public class PetaPocoRepositoryImpl<T> : IPetaPocoRepository<T> where T : class            
    {
        public T Get(long Id)
        {
            using (var db = new Database())
            {
                return db.SingleOrDefault<T>(Id);
            }
        }

        public T Get(string Sql, string Id)
        {
            using (var db = new Database())
            {
                return db.SingleOrDefault<T>(Sql, Id);
            }
        }

        
        public void Add(T model)
        {
            using (var db = new Database())
            {
                db.Insert(model);
            }
        }

        public void Update(T model)
        {
            using (var db = new Database())
            {
                db.Update(model);
            }
        }

        public void Delete(T model)
        {
            using (var db = new Database())
            {
                db.Delete(model);
            }
        }
    }
}
