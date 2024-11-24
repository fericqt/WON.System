using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WON.Entities.DBContext;
using WON.Entities.Models;
using WON.Services.Repository;

namespace WON.Services {
    public class AccessRepository : IAccessRepository {

        public AccessRepository(EntitiesDbContext dbContext) {
            ParticipantRepo = new DataRepository<Participant>(dbContext);
            UsersRepo = new DataRepository<Users>(dbContext);
        }

        public IDataRepository<Participant> ParticipantRepo { get; private set; }
        public IDataRepository<Users> UsersRepo { get; private set; }
    }
}
