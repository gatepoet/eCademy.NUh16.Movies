using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace eCademy.NUh16.Movies.Web.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Tittel")]
        public string Title { get; set; }

        [Required]
        public int Year { get; set; }

        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }

        public virtual Genre Genre { get; set; }
    }
}