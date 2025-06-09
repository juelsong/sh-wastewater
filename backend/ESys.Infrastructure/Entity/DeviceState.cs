namespace ESys.Infrastructure.Entity
{
    using ESys.Contract.Entity;
    using ESys.DataAnnotations;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// 工艺图
    /// </summary>
    [AuditDisable]
    public partial class DeviceState : BizEntity<DeviceState, int>
    {
        /// <summary>
        /// 活动名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 活动描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        public RunState RunState { get; set; }
        /// <summary>
        /// 运行开始时间
        /// </summary>
        public DateTimeOffset? StartDate { get; set; }
        /// <summary>
        /// 工艺Id
        /// </summary>
        public int WorkmanipId { get; set; }
        /// <summary>
        /// 工艺
        /// </summary>
        public virtual Workmanip Workmanip { get; set; }

        /// <summary>
        /// 配置
        /// </summary>
        /// <param name="entityBuilder"></param>
        /// <param name="dbContext"></param>
        /// <param name="dbContextLocator"></param>
        public override void Configure(EntityTypeBuilder<DeviceState> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasIndex(d => d.Name);
            entityBuilder.HasOne(w => w.Workmanip)
                .WithMany(d => d.DeviceStates);
        }
    }
}