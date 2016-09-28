using System.Web;
using System.Web.Mvc;

namespace Firebrand.Demos.Demo19_WebApi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}