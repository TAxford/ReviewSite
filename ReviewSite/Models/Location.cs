using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Date Reviewed")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}")]
        public DateTime ReviewedDate { get; set; }
        [Display(Name = "Travler Star Rating")]
        public int StarRating { get; set; }


        //Foreign Keys and Navigations Properties
        [ForeignKey("Eatery"), Display(Name = "Eatery")]
        public int EateryID { get; set; }
        public virtual Eatery Eatery { get; set; }

        //Foreign Keys and Navigations Properties
        [ForeignKey("Activity"), Display(Name = "Activity")]
        public int ActivityID { get; set; }
        public virtual Activity Activity { get; set; }


    }
}