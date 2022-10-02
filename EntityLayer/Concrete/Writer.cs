using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        [StringLength(50)]
        public String WriterName { get; set; }

        [StringLength(50)]
        public String WriterSurName { get; set; }

        [StringLength(100)]
        public String WriterImage { get; set; }

        [StringLength(200)]
        public string WriterAbout { get; set; }

        [StringLength(200)]
        public String WriterMail { get; set; }

        [StringLength(200)]
        public String WriterPassword { get; set; }

        [StringLength(50)]
        public String WriterTitle { get; set; }

        public ICollection<Heading> Headings { get; set; }
        public ICollection<Content> Contents { get; set; }


    }
}
