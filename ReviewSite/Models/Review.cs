using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; }
        public string Name { get; set; }
        [Display(Name = "Date Reviewed")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ReviewedDate { get; set; }
        [Display(Name = "Travler Star Rating")]
        public int StarRating { get; set; }
        public string Comments { get; set; }

        //Foreign Keys and Navigations Properties
        [ForeignKey("Location"), Display(Name = "Location")]
        public int LocationID { get; set; }
        public virtual Location Location { get; set; }

        //Foreign Keys and Navigations Properties
        [ForeignKey("Category"), Display(Name = "Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }



    }
}