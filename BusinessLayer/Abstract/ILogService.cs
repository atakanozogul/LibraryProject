using EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILogService : IGenericService<Log>
    {
        //Generic servisten farklı bir durum olmadığı için burası boş duruyor.
    }
}
