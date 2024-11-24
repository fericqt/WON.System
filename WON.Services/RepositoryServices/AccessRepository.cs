using FerPROJ.Base.ASP.Base.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WON.Entities.DBContext;
using WON.Entities.Models;

namespace WON.Services.RepositoryServices {
    public class AccessRepository : IAccessRepository {

        public AccessRepository(EntitiesDbContext dbContext) {
            ParticipantRepo = new BaseRepository<Participant, EntitiesDbContext>(dbContext);
            UsersRepo = new BaseRepository<Users, EntitiesDbContext>(dbContext);
        }

        public IBaseRepository<Participant> ParticipantRepo { get; private set; }
        public IBaseRepository<Users> UsersRepo { get; private set; }
    }
}
