using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesMovie.Models
{
    public class MyClient
    {
        public int MyClientID { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Nom du client ou pas")]
        public string Name { get; set; }
        public List<MyMovieRent> MyMovieRent { get; set; }

        [Display(Name = "Nombre de films loués")]
        public int TotalRent { get; set; }

        
    }
}
