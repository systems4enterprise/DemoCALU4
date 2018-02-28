using DataModelCodeFirst.ViewModels;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private RepositoryAuthor Repository = new RepositoryAuthor();
        public ActionResult Index()
        {
            AuthorsDataView authorsData = new AuthorsDataView
            {
                AuthorsData = Repository.GetAllAuthors().Select(x => (AuthorViewModel)x).ToList()
            };
            return View(authorsData);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}