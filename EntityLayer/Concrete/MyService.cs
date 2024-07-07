using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MyService
    {
        [Key]
        public int ServiceID { get; set; }
        public string ServiceName{ get; set; }
        public string ServiceDescription{ get; set; }
    }
}
