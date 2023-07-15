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
    internal class AppUserManager : IAppUserService
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUserManager(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        public void TAdd(AppUser t)
        {
            _appUserRepository.Add(t);
        }

        public void TDelete(AppUser t)
        {
            _appUserRepository.Delete(t);
        }

        public AppUser TGetByID(int id)
        {
           return _appUserRepository.GetByID(id);
        }

        public List<AppUser> TGetList()
        {
           return _appUserRepository.GetList();
        }

        public void TUpdate(AppUser t)
        {
            _appUserRepository.Update(t);
        }

        public List<AppUser> TUserListWithWorkLocation()
        {
            return _appUserRepository.UserListWithWorkLocation();
        }
    }
}
