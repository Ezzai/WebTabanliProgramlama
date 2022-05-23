using Core.DataAccess;
using Core.Entities.Concrete;
using Entities.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<AuthorityDto> GetAuthorities(User user);
        UserSecurityQuestionDto GetUserSecurityQuestion(User user);
    }
}
