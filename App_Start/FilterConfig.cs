using System.Web;
using System.Web.Mvc;

namespace KCCodeMentors_Darlene
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
