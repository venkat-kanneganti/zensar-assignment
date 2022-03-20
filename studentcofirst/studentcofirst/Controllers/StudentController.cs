using studentcofirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace studentcofirst.Controllers
{
    public class StudentController : Controller
    {
        StudentContext sc = new StudentContext();
        // GET: Student
        public ActionResult Index()
        {
            List<StudentInfo> stud = sc.students.ToList();
            return View(stud);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(StudentInfo sd)
        {
            sc.students.Add(sd);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            StudentInfo sd = sc.students.Find(id);
            return View(sd);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            StudentInfo sd = sc.students.Find(id);
            return View(sd);
        }
        [HttpPost]
        public ActionResult Edit(StudentInfo sd)
        {
            StudentInfo std = sc.students.Find(sd.ID);
            std.Name = sd.Name;
            std.Branch = sd.Branch;
            std.city = sd.city;
            std.Percentage = sd.Percentage;
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            StudentInfo sd = sc.students.Find(id);
            sc.students.Remove(sd);
            sc.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SearchBY(string searchBy, string search)
        {
            if (searchBy == "city")
            {
                return View(sc.students.Where(x => x.city == search).ToList());
            }
            else if (searchBy == "Percentage")
            {
                return View(sc.students.Where(x => x.Percentage.ToString() == search).ToList());
            }
            else if (searchBy == "Branch")
            {
                return View(sc.students.Where(x => x.Branch == search).ToList());
            }
            else
            {
                //return View();
                return View(sc.students.Where(x => x.ID.ToString() == search).ToList());
            }

        }

    }
}