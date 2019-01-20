using Volo.Abp.Settings;

namespace DM.FrameWork.Settings
{
    public class FrameWorkSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(FrameWorkSettings.MySetting1));
        }
    }
}
