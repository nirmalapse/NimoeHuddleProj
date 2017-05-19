using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Huddle.Repository;
using Huddle.Models;


namespace Huddle.Controllers
{
    public class HuddleController : Controller
    {
        private IHuddleRepository _huddleRepository;

        public HuddleController(IHuddleRepository huddleRepository)
        {
            _huddleRepository = huddleRepository;
        }
        // GET: Huddle
        public ActionResult HuddleDashboard()
        {
            var data = _huddleRepository.Getdata();
            return View(data);
        }

        public JsonResult GetData()
        {
            var data = _huddleRepository.Getdata();
            //return data.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            return Json(data, JsonRequestBehavior.AllowGet);
        }
    }
}