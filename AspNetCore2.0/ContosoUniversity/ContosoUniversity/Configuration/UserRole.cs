using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Configuration
{
    public class UserRole
    {
        private RoleManager<IdentityRole> _roleManager;

        public UserRole(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task SeedAsync()
        {
            if(await _roleManager.FindByNameAsync("Member") == null) 
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
            }
            if (await _roleManager.FindByNameAsync("Admin") == null)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });
            }
            if (await _roleManager.FindByNameAsync("Employee") == null)
            {
                await _roleManager.CreateAsync(new IdentityRole { Name = "Employee" });
            }
        }
    }
}
