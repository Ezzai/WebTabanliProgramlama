using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITreeService
    {
        IDataResult<List<Tree>> GetAll();
        IDataResult<List<TreeDto>> GetAllTreeDtos();
        IDataResult<Tree> GetById(int id);
        IResult Add(Tree tree);
        IResult Update(Tree tree);
        IResult Delete(Tree tree);
    }
}
