using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public string Type { get; set; }

        //Navagation Property
        public virtual ICollection<Location> Locations { get; set; }




    }
}