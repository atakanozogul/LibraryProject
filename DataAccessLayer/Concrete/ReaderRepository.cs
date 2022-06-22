using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Entites;
using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class ReaderRepository : GenericRepository<Reader>, IReaderRepository
    {
        //Generic repositoryden farklı bir durum lazım olmadığı için burası boş duruyor.
    }
}
