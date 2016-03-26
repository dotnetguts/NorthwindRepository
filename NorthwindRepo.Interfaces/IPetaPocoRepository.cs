using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindRepo.Interfaces
{
    public interface IPetaPocoRepository<T> where T : class
    {
        T Get(long id);
        T Get(string Sql, string Id);
        void Add(T model);
        void Update(T model);
        void Delete(T model);
    }
}
