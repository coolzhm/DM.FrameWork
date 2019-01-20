using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using DM.FrameWork.Localization.FrameWork;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace DM.FrameWork.Pages
{
    public abstract class FrameWorkPageBase : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<FrameWorkResource> L { get; set; }
    }
}
