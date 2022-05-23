using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tree : IEntity
    {
        public int Id { get; set; }
        public int TreeTypeId { get; set; }
        public decimal UnitPrice { get; set; }
        public Int16 UnitsInStock { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
    }
}
