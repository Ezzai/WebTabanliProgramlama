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
    public class TreeOrdersController : ApiController
    {
        ITreeOrderService _treeOrderService;
        public TreeOrdersController()
        {
            _treeOrderService = new TreeOrderManager();
        }

        [HttpGet]
        public List<TreeOrder> GetAll()
        {
            var result = _treeOrderService.GetAll();
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpGet]
        public TreeOrder GetById(int id)
        {
            var result = _treeOrderService.GetById(id);
            if (result.Success)
            {
                return result.Data;
            }
            return null;
        }

        [HttpPost]
        public string Add(TreeOrder treeOrder)
        {
            var result = _treeOrderService.Add(treeOrder);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Delete(TreeOrder treeOrder)
        {
            var result = _treeOrderService.Delete(treeOrder);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }

        [HttpPost]
        public string Update(TreeOrder treeOrder)
        {
            var result = _treeOrderService.Update(treeOrder);
            if (result.Success)
            {
                return result.Message;
            }
            return result.Message;
        }
    }
}