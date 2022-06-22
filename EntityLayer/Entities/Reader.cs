using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Reader //Sisteme yeni kullanıcıları eklemek için reader entitysi oluşturdum
    {
        public int ReaderID { get; set; }
        public string ReaderFullName { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
