﻿/*
 * Author: 陈志杭 Caspar 
 * Contact: 279397942@qq.com qq:279397942
 * Description: 逻辑层数据契约实体模型文件
 * 文件由模板生成,请不要直接修改文件,如需修改请创建一个对应的partial文件
 */
using System;
using System.Collections;
using Zh.DAL.Define.Entities;
using System.Collections.Generic;
namespace Zh.BLL.Define.Entities
{
	#region TUsedCarBuyDto

	/// <summary>
    /// 
	/// TUsedCarBuyDto data view model for mapped table 'T_UsedCarBuy'.
	/// </summary>
	public partial class TUsedCarBuyDto
	{
		
		#region Constructors
        
		public TUsedCarBuyDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// 二手车求购表索引
        /// </summary>
		public virtual decimal UsedCarBuyIndex { get; set; }
        /// <summary>
        /// 二手车求购标题,求购意向
        /// </summary>
		public virtual string UsedCarBuyTitle { get; set; }
        /// <summary>
        /// 所在省份,意向地区
        /// </summary>
		public virtual string BuyProvince { get; set; }
        /// <summary>
        /// 所在城市
        /// </summary>
		public virtual string BuyCity { get; set; }
        /// <summary>
        /// 所在区,区域或街道
        /// </summary>
		public virtual string BuyArea { get; set; }
        /// <summary>
        /// 意向品牌
        /// </summary>
		public virtual int UsedCarBrandIndex { get; set; }
        /// <summary>
        /// 意向车型,大车型
        /// </summary>
		public virtual int UsedCarTypeBigIndex { get; set; }
        /// <summary>
        /// 使用年限,二手车年限,1年以下2年以下等用数字表示
        /// </summary>
		public virtual int? UsedCarYear { get; set; }
        /// <summary>
        /// 车辆颜色
        /// </summary>
		public virtual string UsedCarColor { get; set; }
        /// <summary>
        /// 其他要求,100字以内
        /// </summary>
		public virtual string OtherDemand { get; set; }
        /// <summary>
        /// 姓名,意向购车人姓名
        /// </summary>
		public virtual string BuyerName { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
		public virtual string BuyerSex { get; set; }
        /// <summary>
        /// 手机
        /// </summary>
		public virtual string BuyerHandTel { get; set; }
        /// <summary>
        /// 性质,个人、商家
        /// </summary>
		public virtual string BuyerKind { get; set; }
        /// <summary>
        /// 是否审核,0未审核1已审核
        /// </summary>
		public virtual int? IsAudting { get; set; }
        /// <summary>
        /// 跟进状态,新建、跟进中、暂不处理、已完成
        /// </summary>
		public virtual string TraceState { get; set; }
        /// <summary>
        /// 跟进人ID
        /// </summary>
		public virtual int? TraceEmployeeID { get; set; }
        /// <summary>
        /// 分配时间,分配跟进员工的时间,如果被重新分配则取最后一次被分配的时间
        /// </summary>
		public virtual DateTime? TraceAllotDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual byte[] Stamp { get; set; }
        
        /// <summary>
        /// 
        /// </summary>            
        public virtual TCarTypeBigDto TCarTypeBigDto{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 