using System.Web;
using System.Web.Mvc;

namespace BuiDuyBinh_2011062484
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
