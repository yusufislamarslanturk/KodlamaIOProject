using Core.Utilities.Results;
using Entitties.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>>GetAll();
        IDataResult<Category> GetById(int categoyId);
        IDataResult<List<Product>> GetAllByCategoryId(int id);
    }
}
