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

        //Navagation Property
        public virtual ICollection<Review> Reviews { get; set; }


    }
}