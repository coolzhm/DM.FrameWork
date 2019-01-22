using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;

namespace DM.FrameWork.Entities.Apps
{
    [Table("Application")]
    public class Application : AuditedAggregateRoot<Guid>
    {
        /// <summary>
        /// 应用名称
        /// </summary>
        public string App_Name { get; set; }
        /// <summary>
        /// 应用备注
        /// </summary>
        public string App_Remark { get; set; }
        /// <summary>
        /// 是否隐藏
        /// </summary>
        public bool App_IsHide { get; set; }
        /// <summary>
        /// 应用图标
        /// </summary>
        public string App_Icon { get; set; }
        /// <summary>
        /// 父类应用
        /// </summary>
        public Guid App_Parent { get; set; }
        /// <summary>
        /// 是否有子类应用
        /// </summary>
        public bool App_HasChild { get; set; }
        /// <summary>
        /// 应用层级
        /// </summary>
        public decimal App_Level { get; set; }
        /// <summary>
        /// 应用地址
        /// </summary>
        public string App_Url { get; set; }
        /// <summary>
        /// 应用排序
        /// </summary>
        public string App_Sort { get; set; }
        /// <summary>
        /// 应用类型
        /// </summary>
        public ApplicationType App_Type { get; set; }
    }
}
