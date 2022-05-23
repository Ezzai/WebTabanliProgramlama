using Business.Abstract;
using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class TreeTypesController : ApiController
    {
        ITreeTypeService _treeTypeService;
        public TreeTypesController()
        {
            _treeTypeService = new TreeTypeManager();
        }

        [HttpGet]
        public List<TreeType> GetAll()
        {
            var result = _treeTypeService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public TreeType GetById(int id)
        {
            var result = _treeTypeService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(TreeType treeType)
        {
            var result = _treeTypeService.Add(treeType);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(TreeType treeType)
        {
            var result = _treeTypeService.Delete(treeType);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(TreeType treeType)
        {
            var result = _treeTypeService.Update(treeType);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}