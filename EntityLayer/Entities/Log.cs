using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Log //Loglama işlemi için logID ve açıklamasını ekledim
    {
        public int LogID { get; set; }
        public string Description { get; set; }
    }
}
