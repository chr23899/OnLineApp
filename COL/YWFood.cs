using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：菜品数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWFood
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]菜品</summary>
        private int? product;
        /// <summary>[变量]关联消费</summary>
        private int? consume;
        /// <summary>[变量]特殊要求</summary>
        private string specialRequirement;
        /// <summary>[变量]下单时间</summary>
        private string orderTime;
        /// <summary>[变量]配菜时间</summary>
        private string preparedTime;
        /// <summary>[变量]出菜时间</summary>
        private string outPutTime;
        /// <summary>[变量]上菜时间</summary>
        private string onTableTime;
        /// <summary>[变量]结账时间</summary>
        private string checkoutTime;
        /// <summary>[变量]菜品制作状态</summary>
        private int? makeState;
        /// <summary>[变量]菜品预定状态</summary>
        private int? orderState;
        /// <summary>[变量]菜品结账状态</summary>
        private int? checkState;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]菜品</summary>
        public int? Product
        {
            get { return product; }
            set { product = value; }
        }
        /// <summary>[属性]关联消费</summary>
        public int? Consume
        {
            get { return consume; }
            set { consume = value; }
        }
        /// <summary>[属性]特殊要求</summary>
        public string SpecialRequirement
        {
            get { return specialRequirement; }
            set { specialRequirement = value; }
        }
        /// <summary>[属性]下单时间</summary>
        public string OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }
        /// <summary>[属性]配菜时间</summary>
        public string PreparedTime
        {
            get { return preparedTime; }
            set { preparedTime = value; }
        }
        /// <summary>[属性]出菜时间</summary>
        public string OutPutTime
        {
            get { return outPutTime; }
            set { outPutTime = value; }
        }
        /// <summary>[属性]上菜时间</summary>
        public string OnTableTime
        {
            get { return onTableTime; }
            set { onTableTime = value; }
        }
        /// <summary>[属性]结账时间</summary>
        public string CheckoutTime
        {
            get { return checkoutTime; }
            set { checkoutTime = value; }
        }
        /// <summary>[属性]菜品制作状态</summary>
        public int? MakeState
        {
            get { return makeState; }
            set { makeState = value; }
        }
        /// <summary>[属性]菜品预定状态</summary>
        public int? OrderState
        {
            get { return orderState; }
            set { orderState = value; }
        }
        /// <summary>[属性]菜品结账状态</summary>
        public int? CheckState
        {
            get { return checkState; }
            set { checkState = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
