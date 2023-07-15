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

        public List<AppUser> UserListWithWorkLocation()
        {
           var context = new TContext();
            return context.Users.Include(x=>x.WorkLocation).ToList();
        }
    }
}
