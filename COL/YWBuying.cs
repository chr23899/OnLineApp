using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：采购记录数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWBuying
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]关联物料</summary>
        private int? material;
        /// <summary>[变量]购买数量</summary>
        private double? buyQuantity;
        /// <summary>[变量]购买数量单位</summary>
        private string buyQuantityUnit;
        /// <summary>[变量]购买重量</summary>
        private double? buyWeight;
        /// <summary>[变量]购买重量单位</summary>
        private string buyWeightUnit;
        /// <summary>[变量]购买人</summary>
        private string buyUser;
        /// <summary>[变量]购买时间</summary>
        private string buyTime;
        /// <summary>[变量]购买总价</summary>
        private double? buyPrice;
        /// <summary>[变量]购买记录状态</summary>
        private int? buyState;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]对应需求</summary>
        private string requirementList;
        /// <summary>[变量]结算人</summary>
        private string balanceUser;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]关联物料</summary>
        public int? Material
        {
            get { return material; }
            set { material = value; }
        }
        /// <summary>[属性]购买数量</summary>
        public double? BuyQuantity
        {
            get { return buyQuantity; }
            set { buyQuantity = value; }
        }
        /// <summary>[属性]购买数量单位</summary>
        public string BuyQuantityUnit
        {
            get { return buyQuantityUnit; }
            set { buyQuantityUnit = value; }
        }
        /// <summary>[属性]购买重量</summary>
        public double? BuyWeight
        {
            get { return buyWeight; }
            set { buyWeight = value; }
        }
        /// <summary>[属性]购买重量单位</summary>
        public string BuyWeightUnit
        {
            get { return buyWeightUnit; }
            set { buyWeightUnit = value; }
        }
        /// <summary>[属性]购买人</summary>
        public string BuyUser
        {
            get { return buyUser; }
            set { buyUser = value; }
        }
        /// <summary>[属性]购买时间</summary>
        public string BuyTime
        {
            get { return buyTime; }
            set { buyTime = value; }
        }
        /// <summary>[属性]购买总价</summary>
        public double? BuyPrice
        {
            get { return buyPrice; }
            set { buyPrice = value; }
        }
        /// <summary>[属性]购买记录状态</summary>
        public int? BuyState
        {
            get { return buyState; }
            set { buyState = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]对应需求</summary>
        public string RequirementList
        {
            get { return requirementList; }
            set { requirementList = value; }
        }
        /// <summary>[属性]结算人</summary>
        public string BalanceUser
        {
            get { return balanceUser; }
            set { balanceUser = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return BuyPrice.ToString();
        }

        #endregion EasyCode所生成的默认代码
    }
}
