using System;
using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace RazorPagesMovie.Models
{
    public class MyMovieRent
    {
        public int MyMovieRentID { get; set; }

        public int MyClientID { get; set; }
        public int MyMovieID { get; set; }

        [Display(Name = "Date de location")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime RentDate { get; set; }


    }
}
