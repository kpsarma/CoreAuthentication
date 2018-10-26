using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreAuthentication.EntityModels;
using Microsoft.AspNetCore.Mvc;

namespace CoreAuthentication.Controllers
{
    public class TeacherController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(string Name)
        {

            using (aspnetWebApplication9576319532204474D8C2D4A11DD127D27 _aspnetWebApplication9576319532204474D8C2D4A11DD127D27 = new aspnetWebApplication9576319532204474D8C2D4A11DD127D27())
            {
                _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.Teacher.Add(new Teacher() {Name = Name });
                _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.SaveChanges();
            }
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            List<Teacher> teacherList = new List<Teacher>();

            using (aspnetWebApplication9576319532204474D8C2D4A11DD127D27 _aspnetWebApplication9576319532204474D8C2D4A11DD127D27 = new aspnetWebApplication9576319532204474D8C2D4A11DD127D27())
            {

                 teacherList = _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.Teacher.ToList<Teacher>();
                

            }
            return View(teacherList);

        }

        [HttpGet]
        public IActionResult Edit(string Id)
        {
            Teacher teacherExisting = null;
            using (aspnetWebApplication9576319532204474D8C2D4A11DD127D27 _aspnetWebApplication9576319532204474D8C2D4A11DD127D27 = new aspnetWebApplication9576319532204474D8C2D4A11DD127D27())
            {

                teacherExisting = _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.Teacher.First(x => x.Id.ToString() == Id);
            }
            return View(teacherExisting);
        }

        [HttpPost]
        public IActionResult Edit(string Id, string Name)
        {
            Teacher teacherExisting = null;
            using (aspnetWebApplication9576319532204474D8C2D4A11DD127D27 _aspnetWebApplication9576319532204474D8C2D4A11DD127D27 = new aspnetWebApplication9576319532204474D8C2D4A11DD127D27())
            {

                teacherExisting = _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.Teacher.First(x => x.Id.ToString() == Id);
                teacherExisting.Name = Name;
                _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.Teacher.Update(teacherExisting);
                _aspnetWebApplication9576319532204474D8C2D4A11DD127D27.SaveChanges();


            }
            return View(teacherExisting);
        }
    }
}