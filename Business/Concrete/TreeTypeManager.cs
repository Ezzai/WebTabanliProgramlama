using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class TreeTypeManager : ITreeTypeService
    {
        private ITreeTypeDal _treeTypeDal;
        public TreeTypeManager()
        {
            _treeTypeDal = new EfTreeTypeDal();
        }

        public IResult Add(TreeType treeType)
        {
            _treeTypeDal.Add(treeType);
            return new SuccessResult(Messages.TreeTypeAdded);
        }

        public IResult Delete(TreeType treeType)
        {
            _treeTypeDal.Delete(treeType);
            return new SuccessResult(Messages.TreeTypeDeleted);
        }

        public IDataResult<List<TreeType>> GetAll()
        {
            var result = _treeTypeDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<TreeType>>();
            }
            return new SuccessDataResult<List<TreeType>>(result, Messages.TreeTypesListed);
        }

        public IDataResult<TreeType> GetById(int id)
        {
            var result = _treeTypeDal.Get(t=> t.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<TreeType>();
            }
            return new SuccessDataResult<TreeType>(result, Messages.TreeTypeGeted);
        }

        public IResult Update(TreeType treetype)
        {
            _treeTypeDal.Update(treetype);
            return new SuccessResult(Messages.TreeTypeUpdated);
        }

      
    }
}
