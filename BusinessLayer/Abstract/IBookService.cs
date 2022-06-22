using EntityLayer.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IBookService : IGenericService<Book>
    {
        //Generic servisten farklı bir durum olmadığı için burası boş duruyor.
    }
}
