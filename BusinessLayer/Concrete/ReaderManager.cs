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
    public class ReaderManager : IReaderService
    {
        //Reader servisimi oluşturdum ve interface i olan IBookService i ekledim. 
        //interface de generic servisden geldiği için bu metodları implement ettim.
        private readonly IReaderRepository _readerRepository;

        public ReaderManager(IReaderRepository readerRepository)
        {
            _readerRepository = readerRepository;
        }

        public void TAdd(Reader t)
        {
            _readerRepository.Insert(t);
        }

        public void TDelete(Reader t)
        {
            _readerRepository.Delete(t);
        }

        public Reader TGetByID(int id)
        {
            return _readerRepository.GetByID(id);
        }

        public List<Reader> TGetList()
        {
            return _readerRepository.GetList();
        }

        public void TUpdate(Reader t)
        {
            _readerRepository.Update(t);
        }
    }
}
