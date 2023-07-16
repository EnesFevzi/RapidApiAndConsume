using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebUI.ViewComponents.Admin
{
    public class _AdminProfile : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public _AdminProfile(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Names = user.Name + " " + user.Surname;
            ViewBag.Values = user.ImageUrl;
            var roles = await _userManager.GetRolesAsync(user);
            ViewBag.Role = roles.FirstOrDefault();
            return View(user);
        }
    }
}
