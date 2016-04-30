using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Services.Models
{
    public class ApplicationUserDTO
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ImageURL { get; set; }

        public ICollection<TeamDTO> Teams { get; set; }
    }
}
