using System.Web;
using System.Web.Mvc;

namespace pl.lodz.p.ftims.edu.pai.web
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
