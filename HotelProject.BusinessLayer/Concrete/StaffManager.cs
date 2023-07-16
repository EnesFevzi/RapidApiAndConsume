using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
	public class StaffManager : IStaffService
	{
		private readonly IStaffRepository _staffRepository;

		public StaffManager(IStaffRepository staffRepository)
		{
			_staffRepository = staffRepository;
		}

		public void TAdd(Staff t)
		{
			_staffRepository.Add(t);
		}

		public void TDelete(Staff t)
		{
			_staffRepository.Delete(t);
		}

		public Staff TGetByID(int id)
		{
			return _staffRepository.GetByID	(id);
		}

		public List<Staff> TGetList()
		{
			return _staffRepository.GetList();
		}

        public int TGetStaffCount()
        {
            return _staffRepository.GetStaffCount();
        }

        public List<Staff> TLast4Staff()
        {
			return _staffRepository.Last4Staff();
				
        }

        public void TUpdate(Staff t)
		{
			_staffRepository.Update(t);
		}
	}
}
