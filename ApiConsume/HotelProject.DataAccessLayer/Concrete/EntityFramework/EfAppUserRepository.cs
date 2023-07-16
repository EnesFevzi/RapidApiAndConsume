using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete.EntityFramework
{
    public class EfAppUserRepository : GenericRepository<AppUser>, IAppUserRepository

    {
        public EfAppUserRepository(TContext context) : base(context)
        {
        }

        public int AppUserCount()
        {
            var context = new TContext();
            return context.Users.Count();
        }

        public List<AppUser> UserListWithWorkLocation()
        {
           var context = new TContext();
            return context.Users.Include(x=>x.WorkLocation).ToList();
        }

        public List<AppUser> UsersListWithWorkLocations()
        {
            var context = new TContext();
            //var values = context.Users.Include(x => x.WorkLocation).Select(y => new AppUserWithWorkLocationDto
            //{
            //    Name = y.Name,
            //    Surname = y.Surname,
            //    WorkLocationID = y.WorkLocationID,
            //    WorkLocationName = y.WorkLocation.WorkLocationName
            //});
            var values = context.Users.ToList();
            return values.ToList();
        }
    }
}
