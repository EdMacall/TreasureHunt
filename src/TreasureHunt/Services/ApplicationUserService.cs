
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class ApplicationUserService
    {
        private ApplicationUserRepository _applicationuserrepository;

        private TeamUserRepository _teamuserrepository;

        public ApplicationUserService(ApplicationUserRepository applicationuserrepository, TeamUserRepository teamuserrepository)
        {
            _applicationuserrepository = applicationuserrepository;
            _teamuserrepository = teamuserrepository;
        }

        public ICollection<ApplicationUserDTO> GetApplicationUserList()
        {
            return (from a in _applicationuserrepository.List()
                    select new ApplicationUserDTO
                    {
                        UserName = a.UserName,
                        Email = a.Email,
                        ImageURL = a.ImageURL,
                        // need to make a conversion here...
                        // TeamUsers = a.TeamUsers
                        Teams = (from tu in _teamuserrepository.List()
                                 where tu.ApplicationUser.UserName == a.UserName
                                 select new TeamDTO { }).ToList()
                    }).ToList();
        }
    }
}
