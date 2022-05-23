using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS
{
    public class UserNewPasswordDto : IDto
    {
        public string Password { get; set; }
        public string PasswordVerify { get; set; }
    }
}
