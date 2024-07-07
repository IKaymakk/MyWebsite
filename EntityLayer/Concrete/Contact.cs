using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ID { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(70)]
        public string Subject { get; set; }
        [StringLength(500)]
        public string MessageText { get; set; }
        public string MyMail { get; set; }
        public string MyPhone { get; set; }
        public string MyAdress { get; set; }
    }
}
