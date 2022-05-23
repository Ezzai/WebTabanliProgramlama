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
    public class TreeOrderManager : ITreeOrderService
    {
        private ITreeOrderDal _treeOrderDal;

        public TreeOrderManager()
        {
            _treeOrderDal = new EfTreeOrderDal();
        }

        public IResult Add(TreeOrder treeOrder)
        {
            _treeOrderDal.Add(treeOrder);
            return new SuccessResult(Messages.TreeOrderAdded);
        }

        public IResult Delete(TreeOrder treeOrder)
        {
            _treeOrderDal.Delete(treeOrder);
            return new SuccessResult(Messages.TreeOrderDeleted);
        }

        public IDataResult<List<TreeOrder>> GetAll()
        {
            var result = _treeOrderDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<TreeOrder>>();
            }
            return new SuccessDataResult<List<TreeOrder>>(result, Messages.TreeOrdersListed);
        }

        public IDataResult<TreeOrder> GetById(int id)
        {
            var result = _treeOrderDal.Get(a => a.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<TreeOrder>();
            }
            return new SuccessDataResult<TreeOrder>(result, Messages.TreeOrderGeted);
        }

        public IResult Update(TreeOrder treeOrder)
        {
            _treeOrderDal.Update(treeOrder);
            return new SuccessResult(Messages.TreeOrderUpdated);
        }
    }
}
