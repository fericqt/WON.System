using WON.Entities.Models;
using WON.Services.Repository;

namespace WON.Services {
    public interface IAccessRepository {
        IDataRepository<Participant> ParticipantRepo { get; }
        IDataRepository<Users> UsersRepo { get; }
    }
}