using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StepCourseProject.Entites;
using StepCourseProject.Entites.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StepCourseProject.Areas.Client.ViewComponents
{
    public class MessageClientViewComponent:ViewComponent
    {

        private readonly AppDbContext context;
        private readonly UserManager<AppUser> userManager;

        public MessageClientViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            this.context = context;
            this.userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var currentUserName = User.Identity.Name;
            var currentUser = await userManager.FindByNameAsync(currentUserName);
            var data = context.Messages.Include(i => i.RecieverUser).Include(i=>i.SenderUser).Where(i => i.RecieverUserId == currentUser.Id).ToList();
            ViewBag.Count = data.Count();
            data = data.Take(5).ToList();
            return View(data);
        }
    }
}
