using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using NP.BLL.DomainModel.Security;
using NP.BLL.Security;

namespace NP.Web.Areas.Administrator.Controllers
{
    public class AdminController : Controller
    {
        private readonly IRoleService _roleService;
        public AdminController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        // GET: Administrator/Admin
        [HttpGet]
        [AllowAnonymous]
        public ActionResult Role()
        {
            return View();
        }

        [HttpPost]
        public JsonResult CreateRole(RoleModel roleModel)
        {
            try
            {
                _roleService.CreateRole(roleModel);
                var result = new {Success = "true"};
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                var result = new { Success = "false" };
                return Json(result, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        [AllowAnonymous]
        public ActionResult RoleList()
        {
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public JsonResult GetRoleList()
        {
           var result = _roleService.GetRoleList();
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult EditRole()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetRoleById(long Id)
        {
            var result = _roleService.GetRoleById(Id);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}