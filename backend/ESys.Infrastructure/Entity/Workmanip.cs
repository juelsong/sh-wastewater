using ESys.Contract.Entity;
using ESys.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ESys.Utilty.Defs.ErrorCode;

namespace ESys.Infrastructure.Entity
{
    /// <summary>
    /// 运行状态 
    /// </summary>
    public enum RunState
    {
        /// <summary>
        /// 未运行
        /// </summary>
        Stop,
        /// <summary>
        /// 运行
        /// </summary>
        Running,
        /// <summary>
        /// 错误
        /// </summary>
        Error
    }

    /// <summary>
    /// 工艺图
    /// </summary>
    [AuditDisable]
    public partial class Workmanip : BizEntity<Workmanip, int>, ITraceableEntity, ITimedEntity, IActiveEntity
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
        /// 设备状态
        /// </summary>
        public virtual ICollection<DeviceState> DeviceStates { get; set; }
        #region interfaces
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTimeOffset CreatedTime { get; set; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public DateTimeOffset? UpdatedTime { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public int CreateBy { get; set; }
        /// <summary>
        /// 更新人
        /// </summary>
        public int? UpdateBy { get; set; }

        /// <summary>
        /// 是否启用
        /// </summary>
        public bool IsActive { get; set; }
        #endregion interfaces

    }
}
