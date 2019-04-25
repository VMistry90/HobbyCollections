using System.Web.Mvc;

namespace Hobbies.Areas.MovieTickets
{
    public class MovieTicketsAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "MovieTickets";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "MovieTickets_default",
                "MovieTickets/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}