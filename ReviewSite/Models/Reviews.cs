using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Reviews
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }
        [Display(Name = "Date of Visit")]
        public DateTime VisitDate { get; set; }
        [Display(Name = "Comments")]
        public string Content { get; set; }
        [Display(Name = "Date of Review")]
        public DateTime ReviewDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}