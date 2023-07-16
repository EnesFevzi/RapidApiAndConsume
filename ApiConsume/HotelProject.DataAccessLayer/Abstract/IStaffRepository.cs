using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
	public interface IStaffRepository:IGenericRepository<Staff>
	{
		public int GetStaffCount();
        List<Staff> Last4Staff();


    }
}
