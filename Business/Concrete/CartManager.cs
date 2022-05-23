using Business.Abstract;
using Core.Entities.Concrete;
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
    public class CartManager : ICartService
    {
        ICartDal _cartDal;
        public CartManager()
        {
            _cartDal = new EfCartDal();
        }

        public IResult Add(Cart cart)
        {
            _cartDal.Add(cart);
            return new SuccessResult();
        }

        public IResult Delete(Cart cart)
        {
            _cartDal.Delete(cart);
            return new SuccessResult();
        }

        public IDataResult<List<Cart>> GetAll()
        {
            var result = _cartDal.GetAll();
            if (result == null)
            {
                return new ErrorDataResult<List<Cart>>();
            }
            return new SuccessDataResult<List<Cart>>(result);
        }

        public IResult CheckCart(Cart cart)
        {
            var getItem = _cartDal.Get(c => c.TreeId == cart.TreeId && c.UserId == cart.UserId);
            if (getItem == null)
            {
                Add(cart);
                return new SuccessResult();
            }
            else
            {
                getItem.Quantity += cart.Quantity;
                Update(getItem);
                return new SuccessResult();
            }
        }

        public IResult CartDelete(Cart cart)
        {
            var getItem = _cartDal.Get(c => c.TreeId == cart.TreeId && c.UserId == cart.UserId);
            if (getItem == null)
            {
                return new ErrorResult();
            }
            if (getItem.Quantity > 1)
            {
                getItem.Quantity -= cart.Quantity;
                Update(getItem);
                return new SuccessResult();
            }
            else
            {
                Delete(getItem);
                return new SuccessResult();
            }
        }

        public IDataResult<List<CartDto>> GetAllByDtos(User user)
        {
            var result = _cartDal.GetAllCartDto(user);
            if (result == null)
            {
                return new ErrorDataResult<List<CartDto>>();
            }
            return new SuccessDataResult<List<CartDto>>(result);
        }

        public IDataResult<Cart> GetById(int id)
        {
            var result = _cartDal.Get(p=>p.Id == id);
            if (result == null)
            {
                return new ErrorDataResult<Cart>();
            }
            return new SuccessDataResult<Cart>(result);
        }

        public IResult Update(Cart cart)
        {
            _cartDal.Update(cart);
            return new SuccessResult();
        }
    }
}
