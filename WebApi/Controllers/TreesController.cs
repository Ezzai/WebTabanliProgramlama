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
    public class TreesController : ApiController
    {
        ITreeService _treeService;
        public TreesController()
        {
            _treeService = new TreeManager();
        }

        [HttpGet]
        public List<Tree> GetAll()
        {
            var result = _treeService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public Tree GetById(int id)
        {
            var result = _treeService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(Tree tree)
        {
            var result = _treeService.Add(tree);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(Tree tree)
        {
            var result = _treeService.Delete(tree);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(Tree tree)
        {
            var result = _treeService.Update(tree);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}