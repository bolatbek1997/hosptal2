namespace Hospital.Server.Controllers
{
    using Data.Repository;
    using System.Web.Mvc;
    using System.Linq;
    using AutoMapper.QueryableExtensions;
    using Models;
    using Services.Contracts;
    using Hospital.DatabaseModels;
    using Hospital.Data;

    public class HomeController : BaseController
    {
        IHomeService homeService;

        public HomeController(IUnitOfWork data, IHomeService homeService) : base(data)
        {
            this.homeService = homeService;
        }

        public ActionResult Index()
        {
            return View(this.homeService.GetSpecialities());
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
         [HttpPost]
        public ActionResult Send(Send request)
        {
            try
            {
                var db = new ApplicationDbContext();
                db.Send.Add(request);
                db.SaveChanges();
                return Json("ok");
            }
            catch (System.Exception)
            {
                return Json("");
               
            }
            
        }
    }
}