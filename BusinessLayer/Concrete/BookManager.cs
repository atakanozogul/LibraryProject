using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class BookManager : IBookService
    {
        //Book servisimi oluşturdum ve interface i olan IBookService i ekledim. 
        //interface de generic servisden geldiği için bu metodları implement ettim.
        private readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void TAdd(Book t)
        {
            _bookRepository.Insert(t);
        }

        public void TDelete(Book t)
        {
            _bookRepository.Delete(t);
        }

        public Book TGetByID(int id)
        {
            return _bookRepository.GetByID(id);
        }

        public List<Book> TGetList()
        {
            return _bookRepository.GetList();
        }

        public void TUpdate(Book t)
        {
            _bookRepository.Update(t);
        }
    }
}
