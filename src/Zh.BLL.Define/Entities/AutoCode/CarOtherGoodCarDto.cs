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
	#region CarOtherGoodCarDto

	/// <summary>
    /// 其它重磅好车表
	/// CarOtherGoodCarDto data view model for mapped table 'Car_OtherGoodCar'.
	/// </summary>
	public partial class CarOtherGoodCarDto
	{
		
		#region Constructors
        
		public CarOtherGoodCarDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 自增ID
        /// </summary>
		public virtual int Identity { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid CarMainId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual Guid OtherGoodCarId { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int Sort { get; set; }
        
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto{get;set;}
        /// <summary>
        /// 车辆主表
        /// </summary>            
        public virtual CarMainDto CarMainDto2{get;set;}
        


		#endregion
	 
	}
	#endregion
}
 