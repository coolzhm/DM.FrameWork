using DM.FrameWork.Localization.FrameWork;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DM.FrameWork.Pages
{
    public abstract class FrameWorkPageModelBase : AbpPageModel
    {
        protected FrameWorkPageModelBase()
        {
            LocalizationResourceType = typeof(FrameWorkResource);
        }
    }
}