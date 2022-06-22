using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class LogManager : ILogService
    {
        //Log servisimi oluşturdum ve interface i olan IBookService i ekledim. 
        //interface de generic servisden geldiği için bu metodları implement ettim.
        private readonly ILogRepository _logRepository;
        public LogManager(ILogRepository logRepository)
        {
            _logRepository = logRepository;
        }
        public void TAdd(Log t)
        {
            _logRepository.Insert(t);
        }
        
        public void TDelete(Log t)
        {
            _logRepository.Delete(t);
        }

        public Log TGetByID(int id)
        {
            return _logRepository.GetByID(id);
        }

        public List<Log> TGetList()
        {
            return _logRepository.GetList();
        }

        public void TUpdate(Log t)
        {
            _logRepository.Update(t);
        }
    }
}
