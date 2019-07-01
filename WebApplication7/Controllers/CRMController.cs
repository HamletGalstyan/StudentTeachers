using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

using System.Threading.Tasks;
using WebApplication7.Models;
using WebApplication7.Services;

namespace WebApplication7.Controllers
{
    public class CRMController : Controller
    {
        private IStudentService _servicestudent;
        public CRMController(IStudentService servicestudent)
        {
            _servicestudent = servicestudent;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add() => View();

        [HttpPost]
        public async Task<IActionResult> Add(SudentRequestModel sudentRequestModel)
        {
            await _servicestudent.AddAsinc(sudentRequestModel);
            return View("ShowCreated");
        }

        public  IActionResult StudentsGetAll()
        {

            IEnumerable<Student> entit = _servicestudent.GetAllAsinc();
            
           
            return View(entit);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var student = _servicestudent.GetbyId(id);
            await _servicestudent.DeleteAsinc(student);

            return RedirectToAction("StudentsGetAll");
        }

        public IActionResult ShowCreated()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var student = _servicestudent.GetbyId(id);

            return View(student);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Student student)
        {
            /*await */_servicestudent.UpdateAsync(student);

            return RedirectToAction("StudentsGetAll");
        }

    }
}
