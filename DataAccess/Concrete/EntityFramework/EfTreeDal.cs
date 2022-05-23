using Core.DataAccess.EntityFramework;
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
    public class EfTreeDal : EfEntityRepositoryBase<Tree, AgacSatisWebContext>, ITreeDal
    {
        public List<TreeDto> GetTreeDtos()
        {
            using (var context = new AgacSatisWebContext())
            {
                var result = from tree in context.Trees
                             join treeType in context.TreeTypes
                             on tree.TreeTypeId equals treeType.Id
                             select new TreeDto
                             {
                                 Id = tree.Id,
                                 Name = tree.Name,
                                 UnitsInStock = tree.UnitsInStock,
                                 TreeTypeName = treeType.Name,
                                 UnitPrice = tree.UnitPrice,
                                 Photo = tree.Photo
                             };
                return result.ToList();
            }
        }
    }
}
