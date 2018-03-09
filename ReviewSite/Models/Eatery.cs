using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSite.Models
{
    public class Eatery
    {
        [Key]
        public int EateryID { get; set; }
        public string Name { get; set; }

        //Navagation Property
        public virtual ICollection<Location> Locations { get; set; }





    }
}