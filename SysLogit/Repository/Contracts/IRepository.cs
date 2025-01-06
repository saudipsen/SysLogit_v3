using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SysLogit.Repository.Contracts
{
    using global::SysLogit.Utility;
    using System.Collections.Generic;

    namespace SysLogit.Repository.Contracts
    {
        public interface IRepository<T> where T : class
        {
            Response<IEnumerable<T>> GetAll();
            Response<T> GetById(int id);
            Response<string> Add(T entity);
            Response<string> Update(T entity);
            Response<string> Delete(int id);
        }
    }


}
