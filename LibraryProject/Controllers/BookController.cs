using BookLibrary.Models;
using BusinessLayer.Concrete;
using BusinessLayer.Validations;
using DataAccessLayer.Concrete;
using DataAccessLayer.Context;
using EntityLayer.Entites;
using EntityLayer.Entities;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace BookLibrary.Controllers
{
    public class BookController : Controller
    {
        BookManager bookManager = new BookManager(new BookRepository()); //servisleri çağırdım
        LogManager logManager = new LogManager(new LogRepository());
        public IActionResult Index()
        {
            try
            {
                ApplicationDbContext applicationDbContext = new ApplicationDbContext(); //ActionResult lar içerisinde database ile bağlantı yaptım bu sayede database bağlantısı gerektiğinde yapılmış oldu
                var readers = applicationDbContext.Readers.ToList();
                if (readers != null)
                {
                    ViewBag.Readers = readers;
                }
                ViewBag.Readers = readers;
                var values = bookManager.TGetList(); //okuyucuları listelemek için null kontrolünden geçirdikten sonra view a gönderdim
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
        public IActionResult Add(AddBookVM newBook) //post metoduna viewModel geleceğini söyledim
        {
            try
            {
                Book book = new Book(); //viewModelimi entity ile birleştirdim
                book.BookID = newBook.BookID;
                book.BookName = newBook.BookName;
                book.BookAuthor = newBook.BookAuthor;
                book.BookImageUrl = newBook.BookImageUrl;
                book.TakeDate = null; //kütüphaneye ilk eklenen kitapların alınma veya verilme tarihi olmayacağı için böyle bir işlem yaptım
                book.GiveDate = null;
                book.IsOut = false; //eklenen kitapların kütüphanede olacağını varsaydığım için dışarıda mı sorusunu false yaptım
                book.ReaderID = null;
                BookValidator validations = new BookValidator(); //validasyon işlemlerini çağırdım
                ValidationResult validationResult = validations.Validate(book);
                if (validationResult.IsValid) //validasyon işlemlerinden geçtiyse kitabı ekle ve kitap listeleme sayfasına dön dedim
                {
                    bookManager.TAdd(book);
                    return RedirectToAction("Index", "Book");
                }
                else //validasyon işleminde hata oluştuysa buraya girecek ve hataları dönerek bunu view a gönderecek
                {
                    foreach (var item in validationResult.Errors)
                    {
                        ModelState.AddModelError("", item.ErrorMessage.ToString());
                    }
                }
                return View();
            }
            catch (Exception ex) //Hata yakalanırsa buraya girecek
            {
                Log log = new Log(); //Logları tutmak için entity oluşturdum ve burada nesnesini çağırdım
                log.Description = ex.ToString(); //Log nesnesinin açıklama propertysine gelen mesajı ekle dedim
                logManager.TAdd(log); //Bu sayede yakalanan mesajlar database içerisine kayıt olacak
                throw;
            }
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            try
            {
                var value = bookManager.TGetByID(id);
                return View(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public IActionResult Update(Book book)
        {
            try
            {
                bookManager.TUpdate(book);
                return RedirectToAction("Index", "Book");
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
                var value = bookManager.TGetByID(id);
                bookManager.TDelete(value);
                return RedirectToAction("Index", "Book");
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpGet]
        public IActionResult GiveBook(int id)
        {
            try
            {
                ApplicationDbContext context = new ApplicationDbContext();
                var readers = context.Readers.ToList();
                ViewBag.Readers = readers;
                var value = bookManager.TGetByID(id);
                return View(value);
            }
            catch (Exception)
            {

                throw;
            }
        }
        [HttpPost]
        public IActionResult GiveBook(Book book)
        {
            try
            {
                book.TakeDate = DateTime.Now;
                book.IsOut = true;
                bookManager.TUpdate(book);
                return RedirectToAction("Index", "Book");
            }
            catch (Exception)
            {
                throw;
            }
        }
        public IActionResult TakeBook(int id) //Kitap teslim alma işlemi için yaptığım kısım
        {
            try
            {
                //Burada kitap servisini çağırarak hangi kitabı seçtiğimi id ye göre belirledim ve kitabımda sıfırlanmasını istediğim kısımları null hale getirdim. Bu sayede kitap teslim alındığında alan kişi, alınma verilme tarihleri sıfırlanmış olacak
                var value = bookManager.TGetByID(id);
                value.TakeDate = null;
                value.GiveDate = null;
                value.ReaderID = null;
                value.IsOut = false;
                bookManager.TUpdate(value);
                return RedirectToAction("Index", "Book");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
