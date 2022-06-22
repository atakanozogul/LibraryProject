using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        //BookRepository için interface oluşturdum ve IGenericRepository den inherit aldım.
        //Generic repositoryden farklı bir durum lazım olmadığı için burası boş duruyor.
    }
}
