using System;
using System.Linq;
using Microsoft.Data.Entity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNet.Identity;
using System.Security.Claims;
using System.Threading.Tasks;

namespace TreasureHunt.Models
{
    public class SampleData
    {
        public async static Task Initialize(IServiceProvider serviceProvider)
        {
            var context = serviceProvider.GetService<ApplicationDbContext>();
            var userManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            context.Database.Migrate();

            // Ensure Stephen (IsAdmin)
            var stephen = await userManager.FindByNameAsync("Stephen.Walther@CoderCamps.com");
            if (stephen == null)
            {
                // create user
                stephen = new ApplicationUser
                {
                    UserName = "Stephen.Walther@CoderCamps.com",
                    Email = "Stephen.Walther@CoderCamps.com"
                };
                await userManager.CreateAsync(stephen, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(stephen, new Claim("IsAdmin", "true"));
            }

            // Ensure Stephen (IsAdmin)
            var stephenw = await userManager.FindByNameAsync("Stephen");
            if (stephenw == null)
            {
                // create user
                stephenw = new ApplicationUser
                {
                    UserName = "Stephen",
                    Email = "Stephen.Walther@CoderCamps.com"
                };
                await userManager.CreateAsync(stephenw, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(stephenw, new Claim("IsAdmin", "true"));
            }

            // Ensure irvedwmac (IsAdmin)
            var irvedwmac = await userManager.FindByNameAsync("irvedwmac@aol.com");
            if (irvedwmac == null)
            {
                // create user
                irvedwmac = new ApplicationUser
                {
                    UserName = "irvedwmac@aol.com",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(irvedwmac, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(irvedwmac, new Claim("IsAdmin", "true"));
            }

            // Ensure irvedwmac (IsAdmin)
            var irvedwma = await userManager.FindByNameAsync("EdMacall");
            if (irvedwma == null)
            {
                // create user
                irvedwma = new ApplicationUser
                {
                    UserName = "EdMacall",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(irvedwma, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(irvedwma, new Claim("IsAdmin", "true"));
            }

            // Ensure xayadeth (IsAdmin)
            var xayadeth = await userManager.FindByNameAsync("xayadeth360@gmail.com");
            if (xayadeth == null)
            {
                // create user
                xayadeth = new ApplicationUser
                {
                    UserName = "xayadeth360@gmail.com",
                    Email = "xayadeth360@gmail.com"
                };
                await userManager.CreateAsync(xayadeth, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(xayadeth, new Claim("IsAdmin", "true"));
            }

            // Ensure xayadeth (IsAdmin)
            var xayadeth360 = await userManager.FindByNameAsync("Xayadeth360");
            if (xayadeth360 == null)
            {
                // create user
                xayadeth360 = new ApplicationUser
                {
                    UserName = "Xayadeth360",
                    Email = "xayadeth360@gmail.com"
                };
                await userManager.CreateAsync(xayadeth360, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(xayadeth360, new Claim("IsAdmin", "true"));
            }

            // Ensure gescobedoz (IsAdmin)
            var gescobedoz = await userManager.FindByNameAsync("gescobedoz@broncs.utpa.edu");
            if (gescobedoz == null)
            {
                // create user
                gescobedoz = new ApplicationUser
                {
                    UserName = "gescobedoz@broncs.utpa.edu",
                    Email = "gescobedoz@broncs.utpa.edu"
                };
                await userManager.CreateAsync(gescobedoz, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(gescobedoz, new Claim("IsAdmin", "true"));
            }

            // Ensure gescobedoz (IsAdmin)
            var gabe = await userManager.FindByNameAsync("Gabe");
            if (gabe == null)
            {
                // create user
                gabe = new ApplicationUser
                {
                    UserName = "Gabe",
                    Email = "gescobedoz@broncs.utpa.edu"
                };
                await userManager.CreateAsync(gabe, "Secret123!");

                // add claims
                await userManager.AddClaimAsync(gabe, new Claim("IsAdmin", "true"));
            }

            // Ensure Mike (not IsAdmin)
            var mike = await userManager.FindByNameAsync("Mike@CoderCamps.com");
            if (mike == null)
            {
                // create user
                mike = new ApplicationUser
                {
                    UserName = "Mike@CoderCamps.com",
                    Email = "Mike@CoderCamps.com"
                };
                await userManager.CreateAsync(mike, "Secret123!");
            }


            // Ensure Mike (not IsAdmin)
            var mikey = await userManager.FindByNameAsync("Mike");
            if (mikey == null)
            {
                // create user
                mikey = new ApplicationUser
                {
                    UserName = "Mike",
                    Email = "Mike@CoderCamps.com"
                };
                await userManager.CreateAsync(mikey, "Secret123!");
            }

            // Ensure Guanar (not IsAdmin)
            var guanar = await userManager.FindByNameAsync("Guanar");
            if (guanar == null)
            {
                // create user
                guanar = new ApplicationUser
                {
                    UserName = "Guanar",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(guanar, "Secret123!");
            }

            // Ensure Dactylus (not IsAdmin)
            var dactylus = await userManager.FindByNameAsync("Dactylus");
            if (dactylus == null)
            {
                // create user
                dactylus = new ApplicationUser
                {
                    UserName = "Dactylus",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(dactylus, "Secret123!");
            }

            // Ensure Ragazor (not IsAdmin)
            var ragazor = await userManager.FindByNameAsync("Ragazor");
            if (ragazor == null)
            {
                // create user
                ragazor = new ApplicationUser
                {
                    UserName = "Ragazor",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(ragazor, "Secret123!");
            }

            // Ensure Tyran (not IsAdmin)
            var tyran = await userManager.FindByNameAsync("Tyran");
            if (tyran == null)
            {
                // create user
                tyran = new ApplicationUser
                {
                    UserName = "Tyran",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(tyran, "Secret123!");
            }

            // Ensure Baldor (not IsAdmin)
            var baldor = await userManager.FindByNameAsync("Baldor");
            if (baldor == null)
            {
                // create user
                baldor = new ApplicationUser
                {
                    UserName = "Baldor",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(baldor, "Secret123!");
            }

            // Ensure Hessler (not IsAdmin)
            var hessler = await userManager.FindByNameAsync("Hessler");
            if (hessler == null)
            {
                // create user
                hessler = new ApplicationUser
                {
                    UserName = "Hessler",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(hessler, "Secret123!");
            }

            // Ensure Putin (not IsAdmin)
            var putin = await userManager.FindByNameAsync("Putin");
            if (putin == null)
            {
                // create user
                putin = new ApplicationUser
                {
                    UserName = "Putin",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(putin, "Secret123!");
            }

            // Ensure Morfane (not IsAdmin)
            var morfane = await userManager.FindByNameAsync("Morfane");
            if (morfane == null)
            {
                // create user
                morfane = new ApplicationUser
                {
                    UserName = "Morfane",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(morfane, "Secret123!");
            }

            // Ensure Narzina (not IsAdmin)
            var narzina = await userManager.FindByNameAsync("Narzina");
            if (narzina == null)
            {
                // create user
                narzina = new ApplicationUser
                {
                    UserName = "Narzina",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(narzina, "Secret123!");
            }

            // Ensure Mysvaleer (not IsAdmin)
            var mysvaleer = await userManager.FindByNameAsync("Mysvaleer");
            if (mysvaleer == null)
            {
                // create user
                mysvaleer = new ApplicationUser
                {
                    UserName = "Mysvaleer",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(mysvaleer, "Secret123!");
            }

            // Ensure Ellowyn (not IsAdmin)
            var ellowyn = await userManager.FindByNameAsync("Ellowyn");
            if (ellowyn == null)
            {
                // create user
                ellowyn = new ApplicationUser
                {
                    UserName = "Ellowyn",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(ellowyn, "Secret123!");
            }

            // Ensure Yarasi (not IsAdmin)
            var yarasi = await userManager.FindByNameAsync("Yarasi");
            if (yarasi == null)
            {
                // create user
                yarasi = new ApplicationUser
                {
                    UserName = "Yarasi",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(yarasi, "Secret123!");
            }

            // Ensure Berylia (not IsAdmin)
            var berylia = await userManager.FindByNameAsync("Berylia");
            if (berylia == null)
            {
                // create user
                berylia = new ApplicationUser
                {
                    UserName = "Berylia",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(berylia, "Secret123!");
            }

            // Ensure Voreet Zry (not IsAdmin)
            var voreetzry = await userManager.FindByNameAsync("VoreetZry");
            if (voreetzry == null)
            {
                // create user
                voreetzry = new ApplicationUser
                {
                    UserName = "VoreetZry",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(voreetzry, "Secret123!");
            }

            // Ensure Saguaro Ty (not IsAdmin)
            var saguaroty = await userManager.FindByNameAsync("SaguaroTy");
            if (saguaroty == null)
            {
                // create user
                saguaroty = new ApplicationUser
                {
                    UserName = "SaguaroTy",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(saguaroty, "Secret123!");
            }

            // Ensure Tavua Preet (not IsAdmin)
            var tavuapreet = await userManager.FindByNameAsync("TavuaPreet");
            if (tavuapreet == null)
            {
                // create user
                tavuapreet = new ApplicationUser
                {
                    UserName = "TavuaPreet",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(tavuapreet, "Secret123!");
            }

            // Ensure Tak Tochno (not IsAdmin)
            var taktochno = await userManager.FindByNameAsync("TakTochno");
            if (taktochno == null)
            {
                // create user
                taktochno = new ApplicationUser
                {
                    UserName = "TakTochno",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(taktochno, "Secret123!");
            }

            // Ensure K'kalak (not IsAdmin)
            var kkalak = await userManager.FindByNameAsync("Kkalak");
            if (kkalak == null)
            {
                // create user
                kkalak = new ApplicationUser
                {
                    UserName = "Kkalak",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(kkalak, "Secret123!");
            }

            // Ensure Klaquan (not IsAdmin)
            var klaquan = await userManager.FindByNameAsync("Klaquan");
            if (klaquan == null)
            {
                // create user
                klaquan = new ApplicationUser
                {
                    UserName = "Klaquan",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(klaquan, "Secret123!");
            }

            // Ensure Virzixl (not IsAdmin)
            var virzixl = await userManager.FindByNameAsync("Virzixl");
            if (virzixl == null)
            {
                // create user
                virzixl = new ApplicationUser
                {
                    UserName = "Virzixl",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(virzixl, "Secret123!");
            }

            // Ensure Parasha Vrrn (not IsAdmin)
            var parashavrrn = await userManager.FindByNameAsync("ParashaVrrn");
            if (parashavrrn == null)
            {
                // create user
                parashavrrn = new ApplicationUser
                {
                    UserName = "ParashaVrrn",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(parashavrrn, "Secret123!");
            }

            // Ensure Harrava Ril (not IsAdmin)
            var harravaril = await userManager.FindByNameAsync("HarravaRil");
            if (harravaril == null)
            {
                // create user
                harravaril = new ApplicationUser
                {
                    UserName = "HarravaRil",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(harravaril, "Secret123!");
            }

            // Ensure Yarrala Hrrsh (not IsAdmin)
            var yarralahrrsh = await userManager.FindByNameAsync("YarralaHrrsh");
            if (yarralahrrsh == null)
            {
                // create user
                yarralahrrsh = new ApplicationUser
                {
                    UserName = "YarralaHrrsh",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(yarralahrrsh, "Secret123!");
            }

            // Ensure Grunk (not IsAdmin)
            var grunk = await userManager.FindByNameAsync("Grunk");
            if (grunk == null)
            {
                // create user
                grunk = new ApplicationUser
                {
                    UserName = "Grunk",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(grunk, "Secret123!");
            }

            // Ensure Krorvog (not IsAdmin)
            var krorvog = await userManager.FindByNameAsync("Krorvog");
            if (krorvog == null)
            {
                // create user
                krorvog = new ApplicationUser
                {
                    UserName = "Krorvog",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(krorvog, "Secret123!");
            }

            // Ensure Uzor (not IsAdmin)
            var uzor = await userManager.FindByNameAsync("Uzor");
            if (uzor == null)
            {
                // create user
                uzor = new ApplicationUser
                {
                    UserName = "Uzor",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(uzor, "Secret123!");
            }

            // Ensure M3-850T (not IsAdmin)
            var m3850t = await userManager.FindByNameAsync("M3-850T");
            if (m3850t == null)
            {
                // create user
                m3850t = new ApplicationUser
                {
                    UserName = "M3-850T",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(m3850t, "Secret123!");
            }

            // Ensure THX-1137 (not IsAdmin)
            var thx1137 = await userManager.FindByNameAsync("THX-1137");
            if (thx1137 == null)
            {
                // create user
                thx1137 = new ApplicationUser
                {
                    UserName = "THX-1137",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(thx1137, "Secret123!");
            }

            // Ensure INT-986 (not IsAdmin)
            var int986 = await userManager.FindByNameAsync("INT-986");
            if (int986 == null)
            {
                // create user
                int986 = new ApplicationUser
                {
                    UserName = "INT-986",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(int986, "Secret123!");
            }

            // Ensure Sparky (not IsAdmin)
            var sparky = await userManager.FindByNameAsync("Sparky");
            if (sparky == null)
            {
                // create user
                sparky = new ApplicationUser
                {
                    UserName = "Sparky",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(sparky, "Secret123!");
            }

            // Ensure Calmari (not IsAdmin)
            var calmari = await userManager.FindByNameAsync("Calmari");
            if (calmari == null)
            {
                // create user
                calmari = new ApplicationUser
                {
                    UserName = "Calmari",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(calmari, "Secret123!");
            }

            // Ensure Wavya (not IsAdmin)
            var wavya = await userManager.FindByNameAsync("Wavya");
            if (wavya == null)
            {
                // create user
                wavya = new ApplicationUser
                {
                    UserName = "Wavya",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(wavya, "Secret123!");
            }

            // Ensure Cress (not IsAdmin)
            var cress = await userManager.FindByNameAsync("Cress");
            if (cress == null)
            {
                // create user
                cress = new ApplicationUser
                {
                    UserName = "Cress",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(cress, "Secret123!");
            }

            // Ensure Bortis (not IsAdmin)
            var bortis = await userManager.FindByNameAsync("Bortis");
            if (bortis == null)
            {
                // create user
                bortis = new ApplicationUser
                {
                    UserName = "Bortis",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(bortis, "Secret123!");
            }

            // Ensure Navolok (not IsAdmin)
            var navolok = await userManager.FindByNameAsync("Navolok");
            if (navolok == null)
            {
                // create user
                navolok = new ApplicationUser
                {
                    UserName = "Navolok",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(navolok, "Secret123!");
            }

            // Ensure Dolgran (not IsAdmin)
            var dolgran = await userManager.FindByNameAsync("Dolgran");
            if (dolgran == null)
            {
                // create user
                dolgran = new ApplicationUser
                {
                    UserName = "Dolgran",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(dolgran, "Secret123!");
            }

            // Ensure Geode (not IsAdmin)
            var geode = await userManager.FindByNameAsync("Geode");
            if (geode == null)
            {
                // create user
                geode = new ApplicationUser
                {
                    UserName = "Geode",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(geode, "Secret123!");
            }

            // Ensure Sedimen (not IsAdmin)
            var sedimen = await userManager.FindByNameAsync("Sedimen");
            if (sedimen == null)
            {
                // create user
                sedimen = new ApplicationUser
                {
                    UserName = "Sedimen",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(sedimen, "Secret123!");
            }

            // Ensure Vorkronoa (not IsAdmin)
            var vorkronoa = await userManager.FindByNameAsync("Vorkronoa");
            if (vorkronoa == null)
            {
                // create user
                vorkronoa = new ApplicationUser
                {
                    UserName = "Vorkronoa",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(vorkronoa, "Secret123!");
            }

            // Ensure Kelvan (not IsAdmin)
            var kelvan = await userManager.FindByNameAsync("Kelvan");
            if (kelvan == null)
            {
                // create user
                kelvan = new ApplicationUser
                {
                    UserName = "Kelvan",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(kelvan, "Secret123!");
            }

            // Ensure Meson (not IsAdmin)
            var meson = await userManager.FindByNameAsync("Meson");
            if (meson == null)
            {
                // create user
                meson = new ApplicationUser
                {
                    UserName = "Meson",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(meson, "Secret123!");
            }

            // Ensure Menz Agitat (not IsAdmin)
            var menzagitat = await userManager.FindByNameAsync("MenzAgitat");
            if (menzagitat == null)
            {
                // create user
                menzagitat = new ApplicationUser
                {
                    UserName = "MenzAgitat",
                    Email = "irvedwmac@aol.com"
                };
                await userManager.CreateAsync(menzagitat, "Secret123!");
            }


            if (!context.Hunts.Any())
            {
                // create TreasureHunts
                context.Hunts.AddRange(
                    new Hunt { Name = "Master of Orion" },
                    new Hunt { Name = "Elements" },
                    new Hunt { Name = "The Planets" },
                    new Hunt { Name = "The Wild Kingdom" },
                    new Hunt { Name = "The Lord of the Rings" }
                );
                context.SaveChanges();
            }

            if (!context.Teams.Any())
            {
                context.Teams.AddRange(
                    new Team { Name = "Sssla", ImageURL = "", Points = 0 },
                    new Team { Name = "Terra", ImageURL = "", Points = 0 },
                    new Team { Name = "Navin", ImageURL = "", Points = 0 },
                    new Team { Name = "Draconis", ImageURL = "", Points = 0 },
                    new Team { Name = "Altair", ImageURL = "", Points = 0 },
                    new Team { Name = "Kholdan", ImageURL = "", Points = 0 },
                    new Team { Name = "Fierias", ImageURL = "", Points = 0 },
                    new Team { Name = "Ursa", ImageURL = "", Points = 0 },
                    new Team { Name = "Meklon", ImageURL = "", Points = 0 },
                    new Team { Name = "Trilar", ImageURL = "", Points = 0 },
                    new Team { Name = "Gnol", ImageURL = "", Points = 0 },
                    new Team { Name = "Cryslon", ImageURL = "", Points = 0 },
                    new Team { Name = "Mentar", ImageURL = "", Points = 0 }
                );
                context.SaveChanges();
            }

            /*
            if (!context.TeamUsers.Any())
            {
                context.TeamUsers.AddRange(
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sssla").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Ragazor").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sssla").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Guanar").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sssla").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Dactylus").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Sssla").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Tyran").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Terra").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Baldor").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Terra").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Hessler").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Terra").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Putin").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Navin").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Morfane").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Navin").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Narzina").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Navin").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Mysvaleer").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Draconis").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Ellowyn").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Draconis").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Yarasi").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Draconis").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Berylia").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Altair").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "VoreetZry").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Altair").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "SaguaroTy").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Altair").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "TavuaPreet").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Altair").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "TakTochno").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Kholdan").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Kkalak").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Kholdan").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Klaquan").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Kholdan").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Virzixl").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Fierias").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "ParashaVrrn").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Fierias").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "HarravaRil").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Fierias").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "YarralaHrrsh").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Ursa").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Grunk").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Ursa").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Krorvog").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Ursa").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Uzor").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Meklon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "M3-850T").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Meklon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "THX-1137").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Meklon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "INT-986").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Meklon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Sparky").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Trilar").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Cress").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Trilar").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Calmari").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Trilar").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Wavya").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Gnol").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Bortis").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Gnol").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Navolok").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Gnol").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Dolgran").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Cryslon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Geode").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Cryslon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Sedimen").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Cryslon").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Vorkronoa").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Mentar").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Kelvan").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Mentar").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "Meson").Id
                    },
                    new TeamUser
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "Mentar").Id,
                        ApplicationUserId = context.ApplicationUsers.FirstOrDefault(a => a.UserName == "MenzAgitat").Id
                    }
                );
                context.SaveChanges();
            }
            */

            if (!context.Clues.Any())
            { 
                context.Clues.AddRange(
                    new Clue { Title = "Admiral Chronos", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Guardian of Orion", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "Fire Phasers...", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Dimensional Portal", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "Admiral Sparky", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "Golum", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Ring", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "Bilbow and The Ring", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Big Kahuna", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Big Rocks", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Musician", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "Ein Schooner Tanz...", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "The Statue", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "Find the Chipmunk", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "hi", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "clue", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "go to the store", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "soh", Description = "", Answer = "", PointValue = 0 },
                    new Clue { Title = "eat a cow", Description = "", Answer = "", PointValue = 0 }
                );
                context.SaveChanges();

                /*
                context.TeamClues.AddRange(
                    new TeamClue
                    {
                        TeamId = context.Teams.FirstOrDefault(t => t.Name == "").Id,
                        ClueId = context.Clues.FirstOrDefault(c => c.Title == "").Id
                    }
                );
                context.SaveChanges();
                */
            }
        }
    }
}
