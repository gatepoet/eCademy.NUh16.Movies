using System.Web;
using System.Web.Mvc;

namespace eCademy.NUh16.Movies.Web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
