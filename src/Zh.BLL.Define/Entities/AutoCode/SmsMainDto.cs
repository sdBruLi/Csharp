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
	#region SmsMainDto

	/// <summary>
    /// 短信表
	/// SmsMainDto data view model for mapped table 'Sms_Main'.
	/// </summary>
	public partial class SmsMainDto
	{
		
		#region Constructors
        
		public SmsMainDto() { }        
        
	 
		#endregion

		#region Public Properties
        /// <summary>
        /// ID
        /// </summary>
		public virtual Guid ID { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
		public virtual Guid XCategory { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Content { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual string Phone { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual int State { get; set; }
        /// <summary>
        /// 
        /// </summary>
		public virtual DateTime CreatedDate { get; set; }
        
        
        /// <summary>
        /// 短信表
        /// </summary>
        public virtual IList<TalkPriceOrderSmsRecordDto> TalkPriceOrderSmsRecordDto{get;set;}


		#endregion
	 
	}
	#endregion
}
 