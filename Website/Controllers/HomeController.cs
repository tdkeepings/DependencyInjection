using Models;
using Persistance;
using Services;
using System.Web.Mvc;

namespace Website.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            // Arguably, the Controller/Action should be able to have its dependencies injected instead of being
            // decided at request time. There's some space here to work out how that works
            // TODO Investigate default dependency creation on app startup? Use a Builder project of some sort?
            
            // Silly example, but proves a point.
            // You can have 2 IPersistable<School> defined in totally different ways, but
            // they are interchangable in execution. The site would load will either
            // "persistance" or "interfaceExample" passed into "SchoolService"s constructor.
            IDbContext<School> dbContext = new MyDbContext();
            IPersistable<School> interfaceExample = new SchoolDbPersistance(dbContext);
            IPersistable<School> persistance = new SchoolPersistance();

            ISchoolService service = new SchoolService(persistance); // persistance or interfaceExample
            
            Student student = service.GetTopStudent();

            return View(student);
        }
    }
}