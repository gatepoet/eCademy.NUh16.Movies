using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace eCademy.NUh16.Movies.Web.Helpers
{
    public static class HtmlHelper
    {
        public static MvcForm BeginInlineForm<T>(this HtmlHelper<T> helper, string actionName, string controllerName)
        {
            var attributes = new { @class = "inline-form" };
            return helper.BeginForm(actionName, controllerName, FormMethod.Post, attributes);
        }
    }
}