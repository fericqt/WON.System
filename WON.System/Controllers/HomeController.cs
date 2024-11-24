using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WON.Entities.Models;
using WON.Services.RepositoryServices;
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


        public async Task<IActionResult> GetNames() {
            var participants = new List<ParticipantModel>();
            var participantsEntities = await _accessRepository.ParticipantRepo.GetAllAsync();

            foreach(var item in participantsEntities) {
                participants.Add(new ParticipantModel {
                    Name = $"{item.Firstname} {item.Middlename} {item.Lastname}",
                    Label = $"{item.Firstname} {item.Middlename} {item.Lastname}",
                    Value = 1,
                    Id = 1,
                });
            }

            return Json(participants);
        }
    }
    
}
