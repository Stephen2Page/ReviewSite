using System;
using System.Collections.Generic;
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
        public DateTime VisitDate { get; set; }
        public string Content { get; set; }
        public DateTime ReviewDate { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }


    }
}