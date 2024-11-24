using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WON.Entities.Models;
using WON.Services;
using WON.Services.Repository;
using WON.System.Models;

namespace WON.System.Controllers {
    public class HomeController : Controller {

        private readonly IAccessRepository _accessRepository;

        public HomeController(IAccessRepository accessRepository) {
            _accessRepository = accessRepository;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }
        public async Task<IActionResult> Content() {
            await Create(new Participant {
                Firstname = "Feric",
                Middlename = "Garcines",
                Lastname = "Decenan",
                DateLastWon = DateTime.Now,
                Status = "Active"
            });
            return View();
        }

        public async Task<IActionResult> Create(Participant entity) {
            if (entity == null) {
                return View();
            }
            await _accessRepository.ParticipantRepo.SaveToDBAsync(entity);
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
    }
    
}
