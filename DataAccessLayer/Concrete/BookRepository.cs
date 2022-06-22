using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {
        //Generic repositoryden farklı bir durum lazım olmadığı için burası boş duruyor.
    }
}
