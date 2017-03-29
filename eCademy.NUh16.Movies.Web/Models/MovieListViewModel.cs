namespace eCademy.NUh16.Movies.Web.Models
{
    public class MovieListViewModel
    {
        public string Search { get; set; }
        public Movie[] Movies { get; set; }
        public Movie NewMovie { get; set; }
    }
}