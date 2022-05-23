using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TreeManager : ITreeService
    {
        private ITreeDal _treeDal;

        public TreeManager()
        {
            _treeDal = new EfTreeDal();
        }

        public IResult Add(Tree tree)
        {
            _treeDal.Add(tree);
            return new SuccessResult(Messages.TreeAdded);
        }

        public IResult Delete(Tree tree)
        {
            _treeDal.Delete(tree);
            return new SuccessResult(Messages.TreeDeleted);
        }

        public IDataResult<List<Tree>> GetAll()
        {
            var result = _treeDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<Tree>>();
            }
            return new SuccessDataResult<List<Tree>>(result, Messages.TreeListed);
        }

        public IDataResult<List<TreeDto>> GetAllTreeDtos()
        {
            var result = _treeDal.GetTreeDtos();
            if (result == null)
            {
                return new ErrorDataResult<List<TreeDto>>();
            }
            return new SuccessDataResult<List<TreeDto>>(result, Messages.TreeListed);
        }

        public IDataResult<Tree> GetById(int id)
        {
            var result = _treeDal.Get(t => t.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Tree>();
            }
            return new SuccessDataResult<Tree>(result, Messages.TreeGeted);
        }

        public IResult Update(Tree tree)
        {
            _treeDal.Update(tree);
            return new SuccessResult(Messages.TreeUpdated);
        }

    }
}
