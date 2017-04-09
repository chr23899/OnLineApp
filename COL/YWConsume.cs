using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：消费数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWConsume
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]座位</summary>
        private int? consumeTable;
        /// <summary>[变量]关联预定（预定编号）</summary>
        private int? fromBook;
        /// <summary>[变量]消费日期</summary>
        private string consumeTime;
        /// <summary>[变量]消费时间段</summary>
        private int? consumeTimeBlock;
        /// <summary>[变量]实际消费人数</summary>
        private int? actualNumber;
        /// <summary>[变量]带客人</summary>
        private string welcomeOwner;
        /// <summary>[变量]服务员</summary>
        private string serviceOwner;
        /// <summary>[变量]应收总价</summary>
        private double? totalPrice;
        /// <summary>[变量]折扣</summary>
        private double? priceOff;
        /// <summary>[变量]优惠金额</summary>
        private double? discount;
        /// <summary>[变量]实收总价</summary>
        private double? actualTotalPrice;
        /// <summary>[变量]消费状态</summary>
        private int? consumeState;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]是否会员</summary>
        private int? isMember;
        /// <summary>[变量]会员卡号</summary>
        private string memberCardNo;
        /// <summary>[变量]服务号</summary>
        private string serviceNo;
        /// <summary>[变量]支付方式</summary>
        private int? payment;
        

        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]座位</summary>
        public int? ConsumeTable
        {
            get { return consumeTable; }
            set { consumeTable = value; }
        }
        /// <summary>[属性]关联预定（预定编号）</summary>
        public int? FromBook
        {
            get { return fromBook; }
            set { fromBook = value; }
        }
        /// <summary>[属性]消费日期</summary>
        public string ConsumeTime
        {
            get { return consumeTime; }
            set { consumeTime = value; }
        }
        /// <summary>[属性]消费时间段</summary>
        public int? ConsumeTimeBlock
        {
            get { return consumeTimeBlock; }
            set { consumeTimeBlock = value; }
        }
        /// <summary>[属性]实际消费人数</summary>
        public int? ActualNumber
        {
            get { return actualNumber; }
            set { actualNumber = value; }
        }
        /// <summary>[属性]带客人</summary>
        public string WelcomeOwner
        {
            get { return welcomeOwner; }
            set { welcomeOwner = value; }
        }
        /// <summary>[属性]服务员</summary>
        public string ServiceOwner
        {
            get { return serviceOwner; }
            set { serviceOwner = value; }
        }
        /// <summary>[属性]应收总价</summary>
        public double? TotalPrice
        {
            get { return totalPrice; }
            set { totalPrice = value; }
        }
        /// <summary>[属性]折扣</summary>
        public double? PriceOff
        {
            get { return priceOff; }
            set { priceOff = value; }
        }
        /// <summary>[属性]优惠金额</summary>
        public double? Discount
        {
            get { return discount; }
            set { discount = value; }
        }
        /// <summary>[属性]实收总价</summary>
        public double? ActualTotalPrice
        {
            get { return actualTotalPrice; }
            set { actualTotalPrice = value; }
        }
        /// <summary>[属性]消费状态</summary>
        public int? ConsumeState
        {
            get { return consumeState; }
            set { consumeState = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]是否会员</summary>
        public int? IsMember
        {
            get { return isMember; }
            set { isMember = value; }
        }
        /// <summary>[属性]会员卡号</summary>
        public string MemberCardNo
        {
            get { return memberCardNo; }
            set { memberCardNo = value; }
        }
        /// <summary>[属性]服务号</summary>
        public string ServiceNo
        {
            get { return serviceNo; }
            set { serviceNo = value; }
        }
        /// <summary>[属性]支付方式</summary>
        public int? Payment
        {
            get { return payment; }
            set { payment = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
