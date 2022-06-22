using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using EntityLayer.Entites;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BookLibrary.Controllers
{
    public class ReaderController : Controller
    {
        ReaderManager readerManager = new ReaderManager(new ReaderRepository()); //Servisleri çağırdım
        LogManager logManager = new LogManager(new LogRepository());
        public IActionResult Index()
        {
            try
            {
                var values = readerManager.TGetList(); //Anasayfada listeleme yaptığım için list metodunu kullandım
                return View(values);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult Add()
        {
            try
            {
                return View();
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public IActionResult Add(Reader reader)
        {
            try
            {
                ReaderValidator validations = new ReaderValidator(); //Validasyonları kullanmak için validator u çağırdım.
                ValidationResult validationResult = validations.Validate(reader);
                if (validationResult.IsValid) //Validasyonlardan geçerse ekle geçmezse hataları dön ve view a gönder dedim
                {
                    readerManager.TAdd(reader);
                    return RedirectToAction("Index", "Reader");
                }
                else
                {
                    foreach (var item in validationResult.Errors)
                    {
                        ModelState.AddModelError("", item.ErrorMessage.ToString());
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                //Hataları yakalama ve Loglama işlemi için yaptığım kısım
                Log log = new Log();
                log.Description = ex.ToString();
                logManager.TAdd(log);
                throw;
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            try
            {
                var value = readerManager.TGetByID(id);
                return View(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public IActionResult Update(Reader reader)
        {
            try
            {
                readerManager.TUpdate(reader);
                return RedirectToAction("Index", "Reader");
            }
            catch (Exception)
            {

                throw;
            }
        }
        public IActionResult Delete(int id)
        {
            try
            {
                var value = readerManager.TGetByID(id);
                readerManager.TDelete(value);
                return RedirectToAction("Index", "Reader");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
