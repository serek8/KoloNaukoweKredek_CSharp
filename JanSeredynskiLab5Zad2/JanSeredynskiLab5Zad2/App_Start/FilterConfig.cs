using System.Web;
using System.Web.Mvc;

namespace JanSeredynskiLab5Zad2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}