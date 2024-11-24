using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WON.System.Models;

namespace WON.System.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }
        public IActionResult Content() {
            return View();
        }

        public IActionResult GetNames() {
            var particiapnts = new List<ParticipantModel>() {
                new ParticipantModel {
                    Id = 1,
                    Value = 1,
                    Name = "Feric Decenan",
                    Label = "Feric"
                },
                new ParticipantModel {
                    Id = 2,
                    Value = 2,
                    Name = "Steven Decenan",
                    Label = "Steven"

                },
                new ParticipantModel {
                    Id = 3,
                    Value = 3,
                    Name = "Angelo Jun Decenan",
                    Label = "Angelo"
                }
            };
            return Json(particiapnts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    
}
