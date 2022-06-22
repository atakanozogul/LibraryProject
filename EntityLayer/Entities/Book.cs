using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entites
{
    public class Book //Book için belirlediğim propertyleri yazdım
    {
        public int BookID { get; set; }
        public string BookName { get; set; }
        public string BookImageUrl { get; set; }
        public string BookAuthor { get; set; }
        public bool IsOut { get; set; }
        public DateTime? GiveDate { get; set; }
        public DateTime? TakeDate { get; set; }
        public int? ReaderID { get; set; }
        public Reader Reader { get; set; }
    }
}
