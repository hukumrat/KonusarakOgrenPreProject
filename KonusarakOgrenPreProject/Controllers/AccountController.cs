using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MvcWebUI.ViewModels;

namespace MvcWebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AccountController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }
        [HttpGet]
        public async Task<IActionResult> Login()
        {
            
            var roles = roleManager.Roles;
            bool isSysadminExist = false;
            bool isAdminExist = false;
            bool isCustomerExist = false;
            foreach (var role in roles)
            {
                if (role.Name == "sysadmin")
                {
                    isSysadminExist = true;
                }
                else if (role.Name == "admin")
                {
                    isAdminExist = true;
                }
                else if (role.Name == "customer")
                {
                    isCustomerExist = true;
                }
            }

            IdentityRole sysadminRole = new IdentityRole
            {
                Name = "sysadmin"
            };
            if (!isSysadminExist)
            {
                await roleManager.CreateAsync(sysadminRole);
            }

            IdentityRole adminRole = new IdentityRole
            {
                Name = "admin"
            };
            if (!isAdminExist)
            {
                
                await roleManager.CreateAsync(adminRole);
            }

            IdentityRole customerRole = new IdentityRole
            {
                Name = "customer"
            };
            if (!isCustomerExist)
            {
                
                await roleManager.CreateAsync(customerRole);
            }

            var userSysAdminFromDatabase = await userManager.FindByEmailAsync("sysadmin@sysadmin.com");
            if (userSysAdminFromDatabase == null)
            {
                var userSysAdmin = new IdentityUser
                {
                    UserName = "sysadmin",
                    Email = "sysadmin@sysadmin.com"
                };
                await userManager.CreateAsync(userSysAdmin, "Sysadmin1.");
                await userManager.AddToRoleAsync(userSysAdmin, sysadminRole.Name);
            }


            var userAdminFromDatabase = await userManager.FindByEmailAsync("admin@admin.com");
            if (userAdminFromDatabase == null)
            {
                var userAdmin = new IdentityUser
                {
                    UserName = "admin",
                    Email = "admin@admin.com"
                };
                await userManager.CreateAsync(userAdmin, "Admin1.");
                await userManager.AddToRoleAsync(userAdmin, adminRole.Name);
            }

            var userCustomerFromDatabase = await userManager.FindByEmailAsync("customer@customer.com");
            if (userCustomerFromDatabase == null)
            {
                var userCustomer = new IdentityUser
                {
                    UserName = "customer",
                    Email = "customer@customer.com"
                };
                await userManager.CreateAsync(userCustomer, "Customer1.");
                await userManager.AddToRoleAsync(userCustomer, customerRole.Name);
            }
            return View();
        }

        
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }

        
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var result = await signInManager.PasswordSignInAsync(
                    model.Username, model.Password, model.RememberMe, false);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Account");
                }

                ModelState.AddModelError(string.Empty, "Invalid Login Attempt");
            }

            return View(model);
        }
    }
}
