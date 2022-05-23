using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOS
{
    public class TreeDto : IDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TreeTypeName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string Photo { get; set; }
    }
}
