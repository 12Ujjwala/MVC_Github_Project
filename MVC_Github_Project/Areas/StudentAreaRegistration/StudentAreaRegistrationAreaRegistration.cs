using System.Web.Mvc;

namespace MVC_Github_Project.Areas.StudentAreaRegistration
{
    public class StudentAreaRegistrationAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "StudentAreaRegistration";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "StudentAreaRegistration_default",
                "StudentAreaRegistration/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}