using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class LogRepository : GenericRepository<Log>, ILogRepository
    {
        //Generic repositoryden farklı bir durum lazım olmadığı için burası boş duruyor.
    }
}
