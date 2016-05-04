﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TreasureHunt.Models;

namespace TreasureHunt.Infrastructure
{
    public class ApplicationUserRepository : GenericRepository<ApplicationUser>
    {
        public ApplicationUserRepository(ApplicationDbContext db) : base(db) { }

        public IQueryable<ApplicationUser> FindUserByName(string name)
        {
            return from u in _db.ApplicationUsers
                   where u.UserName == name
                   select u;
        }
    }
}
