using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCartDal : EfEntityRepositoryBase<Cart, AgacSatisWebContext>, ICartDal
    {
        public List<CartDto> GetAllCartDto(User user)
        {
            using (AgacSatisWebContext context = new AgacSatisWebContext())
            {
                var result = from tree in context.Trees
                             join cart in context.Carts
                             on tree.Id equals cart.TreeId
                             where cart.UserId == user.Id
                             select new CartDto
                             {
                                 TreeName = tree.Name,
                                 Quantity = cart.Quantity,
                                 UserName = user.FirstName + " " + user.LastName,
                                 TreeUnitPrice = tree.UnitPrice,
                                 TreeId = tree.Id,
                                 CartId = cart.Id,
                                 Photo = tree.Photo
                             };
                return result.ToList();
            }
        }
    }
}
