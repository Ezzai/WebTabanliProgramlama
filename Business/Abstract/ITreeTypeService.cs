using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITreeTypeService
    {
        IDataResult<List<TreeType>> GetAll();
        IDataResult<TreeType> GetById(int id);
        IResult Add(TreeType treeType);
        IResult Update(TreeType treeType);
        IResult Delete(TreeType treeType);
    }
}
