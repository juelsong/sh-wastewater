namespace ESys.Infrastructure.Entity
{
    using ESys.Contract.Entity;
    using ESys.DataAnnotations;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    /// <summary>
    /// 表示与水池等相关设备信息及状态的类  
    /// 按照分钟读取 
    /// </summary>
    [AuditDisable]
    partial class WorkmanipData1 : BizEntity<WorkmanipData1, long>
    {
        /// <summary>
        /// 出水池流量，单位：㎡/H
        /// </summary>
        public double? OutletPoolFlow { get; set; }

        /// <summary>
        /// 出水池液位，单位：CM
        /// </summary>
        public double? OutletPoolLiquidLevel { get; set; }

        /// <summary>
        /// 出水池余氯，单位：mg/L
        /// </summary>
        public double? OutletPoolResidualChlorine { get; set; }

        /// <summary>
        /// 调节池提升泵1#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? RegulationPoolLiftPump1 { get; set; }

        /// <summary>
        /// 调节池提升泵2#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? RegulationPoolLiftPump2 { get; set; }

        /// <summary>
        /// 调节池液位，单位：CM
        /// </summary>
        public double? RegulationPoolLiquidLevel { get; set; }

        /// <summary>
        /// 调节池液位低状态（True 表示液位低，False 表示液位不低）
        /// </summary>
        public bool? RegulationPoolLowLiquidLevel { get; set; }

        /// <summary>
        /// 调节池液位高状态（True 表示液位高，False 表示液位不高）
        /// </summary>
        public bool? RegulationPoolHighLiquidLevel { get; set; }

        /// <summary>
        /// 调节池液位中状态（True 表示液位中，False 表示液位不在中间状态）
        /// </summary>
        public bool? RegulationPoolMiddleLiquidLevel { get; set; }

        /// <summary>
        /// 集水坑潜污泵1#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? SumpSubmersiblePump1 { get; set; }

        /// <summary>
        /// 集水坑潜污泵2#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? SumpSubmersiblePump2 { get; set; }

        /// <summary>
        /// 加药量
        /// </summary>
        public double? DrugDosage { get; set; }

        /// <summary>
        /// 搅拌曝气风机状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? StirringAerationFan { get; set; }

        /// <summary>
        /// 排放水泵1#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? DischargePump1 { get; set; }

        /// <summary>
        /// 排放水泵2#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? DischargePump2 { get; set; }

        /// <summary>
        /// 生化池曝气风机1#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? BioChemicalPoolAerationFan1 { get; set; }

        /// <summary>
        /// 生化池曝气风机2#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? BioChemicalPoolAerationFan2 { get; set; }

        /// <summary>
        /// 污泥池进料泵状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? SludgePoolFeedPump { get; set; }

        /// <summary>
        /// 污泥池液位，单位：CM
        /// </summary>
        public double? SludgePoolLiquidLevel { get; set; }

        /// <summary>
        /// 污泥池液位低状态（True 表示液位低，False 表示液位不低）
        /// </summary>
        public bool? SludgePoolLowLiquidLevel { get; set; }

        /// <summary>
        /// 污泥池液位高状态（True 表示液位高，False 表示液位不高）
        /// </summary>
        public bool? SludgePoolHighLiquidLevel { get; set; }

        /// <summary>
        /// 污泥池液位中状态（True 表示液位中，False 表示液位不在中间状态）
        /// </summary>
        public bool? SludgePoolMiddleLiquidLevel { get; set; }

        /// <summary>
        /// 污泥回流泵1#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? SludgeReturnPump1 { get; set; }

        /// <summary>
        /// 污泥回流泵2#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? SludgeReturnPump2 { get; set; }

        /// <summary>
        /// 消毒池液位低状态（True 表示液位低，False 表示液位不低）
        /// </summary>
        public bool? DisinfectionPoolLowLiquidLevel { get; set; }

        /// <summary>
        /// 消毒池液位高状态（True 表示液位高，False 表示液位不高）
        /// </summary>
        public bool? DisinfectionPoolHighLiquidLevel { get; set; }

        /// <summary>
        /// 消毒池液位中状态（True 表示液位中，False 表示液位不在中间状态）
        /// </summary>
        public bool? DisinfectionPoolMiddleLiquidLevel { get; set; }

        /// <summary>
        /// 消毒剂计量泵1#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? DisinfectantMeteringPump1 { get; set; }

        /// <summary>
        /// 消毒剂计量泵2#状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? DisinfectantMeteringPump2 { get; set; }

        /// <summary>
        /// 消毒搅拌机运行状态（0 表示未运行等非激活状态，1 表示运行等激活状态，具体含义根据实际业务）
        /// </summary>
        public RunState? DisinfectionBlenderOperation { get; set; }

        /// <summary>
        /// 测试相关值
        /// </summary>
        public RunState? TestValue { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 时间
        /// </summary>
        public DateTimeOffset Date { get; set; }
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
        public override void Configure(EntityTypeBuilder<WorkmanipData1> entityBuilder, DbContext dbContext, Type dbContextLocator)
        {
            entityBuilder.HasIndex(d => d.Date);
            entityBuilder.HasIndex(d => d.WorkmanipId);
            //entityBuilder.HasOne(w => w.Workmanip)
            //    .WithMany(d => d.DeviceStates);
        }
    }

}
