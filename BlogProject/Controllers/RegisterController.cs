using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterRepository());
        CityManager cityManager = new CityManager(new EfCityRepository());

        [HttpGet]
        public IActionResult Index()
        {   //  işlem
            ViewBag.Cities = GetCityList();
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer,string passwordAgain)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult results = validationRules.Validate(writer);
            if (results.IsValid && writer.WriterPassword== passwordAgain)
            {
                writer.WriterAbout = "Yazar";
                writer.WriterStatus = true;
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            else
            {
                ModelState.AddModelError("WriterPassword", "Girdiğiniz Şifreler Eşleşmiyor! Lütfen Tekrar Deneyiniz");
            }
            return View();
        }
        public List<SelectListItem> GetCityList()
        {
            List<SelectListItem> adminRole = (from x in cityManager.GetList()
                                              select new SelectListItem
                                              {
                                                  Text = x.CityName,
                                                  Value = x.CityId.ToString()

                                              }).ToList();
            return adminRole;
        }
    }
}