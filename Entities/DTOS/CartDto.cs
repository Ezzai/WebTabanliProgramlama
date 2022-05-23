using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS
{
    public class CartDto : IDto
    {
        public int CartId { get; set; }
        public int TreeId { get; set; }
        public string UserName { get; set; }
        public string Photo { get; set; }
        public string TreeName { get; set; }
        public decimal TreeUnitPrice { get; set; }
        public Int16 Quantity { get; set; }

    }
}
