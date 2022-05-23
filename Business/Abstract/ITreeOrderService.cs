using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ITreeOrderService
    {
        IDataResult<List<TreeOrder>> GetAll();
        IDataResult<TreeOrder> GetById(int id);
        IResult Add(TreeOrder treeOrdere);
        IResult Update(TreeOrder treeOrder);
        IResult Delete(TreeOrder treeOrder);
    }
}
