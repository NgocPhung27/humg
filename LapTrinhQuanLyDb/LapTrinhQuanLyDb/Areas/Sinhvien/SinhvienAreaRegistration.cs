using System.Web.Mvc;

namespace LapTrinhQuanLyDb.Areas.Sinhvien
{
    public class SinhvienAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Sinhvien";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Sinhvien_default",
                "Sinhvien/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}