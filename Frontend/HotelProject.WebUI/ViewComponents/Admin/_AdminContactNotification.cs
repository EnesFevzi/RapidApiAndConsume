using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Admin
{
    public class _AdminContactNotification:ViewComponent
    {
        protected readonly IContactService _message2Manager;
        private readonly UserManager<AppUser> _userManager;
        protected readonly TContext _context;

        public _AdminContactNotification(IContactService message2Manager, UserManager<AppUser> userManager, TContext context)
        {
            _message2Manager = message2Manager;
            _userManager = userManager;
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var values = _message2Manager.TGetList();
            return View(values);

        }
    }
}
