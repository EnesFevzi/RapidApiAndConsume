using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Repository;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Concrete.EntityFramework
{
	public class EfStaffRepository : GenericRepository<Staff>, IStaffRepository
	{
		public EfStaffRepository(TContext context) : base(context)
		{

		}

        public int GetStaffCount()
        {
            var context = new TContext();
            return context.Staffs.Count();
        }

        public List<Staff> Last4Staff()
        {
            using var context = new TContext();
            var values = context.Staffs.OrderByDescending(x => x.StaffID).Take(4).ToList();
            return values;


        }
    }
}
