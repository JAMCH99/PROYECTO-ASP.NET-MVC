using System.Web;
using System.Web.Mvc;

namespace CapaPresentacionAdmi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
