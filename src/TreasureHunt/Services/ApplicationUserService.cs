
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Infrastructure;
using TreasureHunt.Models;
using TreasureHunt.Services.Models;

namespace TreasureHunt.Services
{
    public class ApplicationUserService
    {
        private ApplicationUserRepository _applicationuserrepository;

        private        TeamUserRepository        _teamuserrepository;

        public ApplicationUserService(ApplicationUserRepository applicationuserrepository,
                                             TeamUserRepository        teamuserrepository)
        {
            _applicationuserrepository = applicationuserrepository;
                   _teamuserrepository =        teamuserrepository;
        }

        public ApplicationUserDTO GetApplicationUser(string username)
        {
            ApplicationUser applicationuser =
                _applicationuserrepository.List().FirstOrDefault(m => m.UserName == username);

            return new ApplicationUserDTO
            {
                // Id = applicationuser.Id,
                Email =    applicationuser.Email,
                UserName = applicationuser.UserName,
                ImageURL = applicationuser.ImageURL,
                Teams = (from tu in _teamuserrepository.List()
                         where tu.ApplicationUser.UserName == applicationuser.UserName
                         select new TeamDTO
                         {
                             Name = tu.Team.Name,
                             ImageURL = tu.Team.ImageURL,
                             Points = tu.Team.Points
                         }).ToList()
            };
        }

        /*  We're probably not using this anymore...
            Where did this come from anyway?
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
                                 select new TeamDTO {

                                     Name = tu.Team.Name,
                                     ImageURL = tu.Team.ImageURL,
                                     Points = tu.Team.Points

                                 }).ToList()
                    }).ToList();
        }
        */
    }
}
