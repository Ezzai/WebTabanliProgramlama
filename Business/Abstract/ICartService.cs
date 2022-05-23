using Core.Entities.Concrete;
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
    public interface ICartService
    {
        IDataResult<List<Cart>> GetAll();
        IDataResult<Cart> GetById(int id);
        IDataResult<List<CartDto>> GetAllByDtos(User user);
        IResult Add(Cart cart);
        IResult Update(Cart cart);
        IResult Delete(Cart cart);
        IResult CheckCart(Cart cart);
        IResult CartDelete(Cart cart);
    }
}
