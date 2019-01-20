using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Localization;
using DM.FrameWork.Localization.FrameWork;
using Volo.Abp.UI.Navigation;

namespace DM.FrameWork.Menus
{
    public class FrameWorkMenuContributor : IMenuContributor
    {
        public async Task ConfigureMenuAsync(MenuConfigurationContext context)
        {
            if (context.Menu.Name == StandardMenus.Main)
            {
                await ConfigureMainMenuAsync(context);
            }
        }

        private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
        {
            var l = context.ServiceProvider.GetRequiredService<IStringLocalizer<FrameWorkResource>>();

            context.Menu.Items.Insert(0, new ApplicationMenuItem("FrameWork.Home", l["Menu:Home"], "/"));
        }
    }
}
