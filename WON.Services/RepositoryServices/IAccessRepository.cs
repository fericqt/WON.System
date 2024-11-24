using FerPROJ.Base.ASP.Base.Repository;
using WON.Entities.Models;

namespace WON.Services.RepositoryServices {
    public interface IAccessRepository {
        IBaseRepository<Participant> ParticipantRepo { get; }
        IBaseRepository<Users> UsersRepo { get; }
    }
}