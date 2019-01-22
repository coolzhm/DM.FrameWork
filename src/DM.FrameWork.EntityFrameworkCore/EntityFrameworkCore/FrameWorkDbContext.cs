using DM.FrameWork.Entities.Apps;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;

namespace DM.FrameWork.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class FrameWorkDbContext : AbpDbContext<FrameWorkDbContext>
    {
        #region DbSet
        public DbSet<Application> Applications { get; set; }
        #endregion

        public FrameWorkDbContext(DbContextOptions<FrameWorkDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureIdentity();
            modelBuilder.ConfigurePermissionManagement();
            modelBuilder.ConfigureSettingManagement();
            modelBuilder.ConfigureBackgroundJobs();
            modelBuilder.ConfigureAuditLogging();
        }
    }
}
