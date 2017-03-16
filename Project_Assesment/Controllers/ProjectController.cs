using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Project_Assesment.Models;
using Project_Assesment.Repositories;

namespace Project_Assesment.Controllers
{
    public class ProjectController : Controller
    {
        //
        // GET: /Project/

        public ActionResult Index()
        {
            return View(ProjectRepository.GetAll());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new Project());
        }

        [HttpPost]
        public ActionResult Create(Project model)
        {
            if (ModelState.IsValid)
            {
                ProjectRepository.Create(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Edit(int id)
        {
            var model = ProjectRepository.FindOne(id);
            if (model != null)
            {
                return View(model);
            }
            else
                return View(new Project());
        }

        public ActionResult Edit(int id, Project model)
        {
            if (ModelState.IsValid)
            {
                ProjectRepository.Create(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        public ActionResult Delete(int id)
        {
            var model = ProjectRepository.FindOne(id);
            if (model != null)
            {
                if (!ProjectRepository.Delete(id) == false)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return RedirectToAction("Details", new { id = id });
                }
            }
            else
                return View(new Project());


        }

        public ActionResult Details(int id)
        {
            var model = ProjectRepository.FindOne(id);
            if (model != null)
            {
                return View(model);
            }
            else
                return View(new Project());
        }

    }
}
