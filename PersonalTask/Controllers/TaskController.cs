using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalTask.Models;

namespace PersonalTask.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        [HttpGet]
        public ActionResult CreateTask()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTask(Task task)
        {
            return View();
        }
    }
}