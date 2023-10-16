using Microsoft.AspNetCore.Mvc;
using PeopleManager.Cyb.Ui.Mvc.Core;

namespace PeopleManager.Cyb.Ui.Mvc.Controllers
{
    public class PeopleController : Controller
    {
        private readonly Database _database;

        public PeopleController(Database database)
        {
            _database = database;
        }

        public IActionResult Index()
        {
            var people = _database.People;
            return View(people);
        }
    }
}
