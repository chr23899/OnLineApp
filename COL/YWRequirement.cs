using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：需求数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWRequirement
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]项目</summary>
        private int? material;
        /// <summary>[变量]计量方式</summary>
        private int? estimateMode;
        /// <summary>[变量]数量</summary>
        private double? quantity;
        /// <summary>[变量]数量单位</summary>
        private string quantityUnit;
        /// <summary>[变量]重量</summary>
        private double? weight;
        /// <summary>[变量]重量单位</summary>
        private string weightUnit;
        /// <summary>[变量]来源</summary>
        private int? sourceOrg;
        /// <summary>[变量]提出人</summary>
        private string proposeUser;
        /// <summary>[变量]提出时间</summary>
        private string proposeTime;
        /// <summary>[变量]需求单状态</summary>
        private int? requirementState;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]特殊要求</summary>
        private string specialRequirement;
        /// <summary>[变量]接收人</summary>
        private string receiveUser;
        /// <summary>[变量]接收时间</summary>
        private string receiveTime;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]项目</summary>
        public int? Material
        {
            get { return material; }
            set { material = value; }
        }
        /// <summary>[属性]计量方式</summary>
        public int? EstimateMode
        {
            get { return estimateMode; }
            set { estimateMode = value; }
        }
        /// <summary>[属性]数量</summary>
        public double? Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        /// <summary>[属性]数量单位</summary>
        public string QuantityUnit
        {
            get { return quantityUnit; }
            set { quantityUnit = value; }
        }
        /// <summary>[属性]重量</summary>
        public double? Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        /// <summary>[属性]重量单位</summary>
        public string WeightUnit
        {
            get { return weightUnit; }
            set { weightUnit = value; }
        }
        /// <summary>[属性]来源</summary>
        public int? SourceOrg
        {
            get { return sourceOrg; }
            set { sourceOrg = value; }
        }
        /// <summary>[属性]提出人</summary>
        public string ProposeUser
        {
            get { return proposeUser; }
            set { proposeUser = value; }
        }
        /// <summary>[属性]提出时间</summary>
        public string ProposeTime
        {
            get { return proposeTime; }
            set { proposeTime = value; }
        }
        /// <summary>[属性]需求单状态</summary>
        public int? RequirementState
        {
            get { return requirementState; }
            set { requirementState = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]特殊要求</summary>
        public string SpecialRequirement
        {
            get { return specialRequirement; }
            set { specialRequirement = value; }
        }
        /// <summary>[属性]接收人</summary>
        public string ReceiveUser
        {
            get { return receiveUser; }
            set { receiveUser = value; }
        }
        /// <summary>[属性]接收时间</summary>
        public string ReceiveTime
        {
            get { return receiveTime; }
            set { receiveTime = value; }
        }
        

        #endregion EasyCode所生成的默认代码
    }
}
