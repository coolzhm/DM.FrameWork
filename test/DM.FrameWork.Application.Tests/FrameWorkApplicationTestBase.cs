using Volo.Abp;

namespace DM.FrameWork
{
    public abstract class FrameWorkApplicationTestBase : AbpIntegratedTest<FrameWorkApplicationTestModule>
    {
        protected override void SetAbpApplicationCreationOptions(AbpApplicationCreationOptions options)
        {
            options.UseAutofac();
        }
    }
}
