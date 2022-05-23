using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class AgacSatisWebContext : DbContext
    {
        public DbSet<Tree> Trees { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserAuthority> UserAuthorities { get; set; }
        public DbSet<TreeType> TreeTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<TreeOrder> TreeOrders { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<AdminMenu> AdminMenus { get; set; }




    }
}
