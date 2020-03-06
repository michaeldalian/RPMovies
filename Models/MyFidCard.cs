using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesMovie.Models
{
    public class MyFidCard
    {
        public int MyFidCardID { get; set; }
        public int MyClientID { get; set; }

        [Display(Name = "Date d'abonnement")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime MembershipDate { get; set; }

    }
}
