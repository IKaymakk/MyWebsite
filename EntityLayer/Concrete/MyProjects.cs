using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class MyProjects
    {
        [Key]
        public int ProjectID { get; set; }
        public string ProjectName { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectText1 { get; set; }
        public string ProjectText2 { get; set; }
        public string ProjectText3 { get; set; }
        public string ProjectText4 { get; set; }
        public string ProjectText5 { get; set; }
        public string ProjectIMG1 { get; set; }
        public string ProjectIMG2 { get; set; }
        public string ProjectIMG3 { get; set; }
        public string ProjectIMG4 { get; set; }
        public string ProjectIMG5 { get; set; }
        public string ProjectIMG6 { get; set; }
        public string ProjectIMG7 { get; set; }
        public string ProjectIMG8 { get; set; }
        public string ProjectIMG9 { get; set; }
        public string ProjectIMG10 { get; set; }

    }
}
