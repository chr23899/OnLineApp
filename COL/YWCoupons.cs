using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：优惠券数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2016-4-16 16:34:11
    /// </summary>
    [Serializable]
    public class YWCoupons
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]消费记录</summary>
        private int? consumeId;
        /// <summary>[变量]优惠券类型</summary>
        private int? couponsType;
        /// <summary>[变量]数量</summary>
        private int? cnt;
        /// <summary>[变量]券号</summary>
        private string ticketNo;
        /// <summary>[变量]金额</summary>
        private double? amount;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]消费记录</summary>
        public int? ConsumeId
        {
            get { return consumeId; }
            set { consumeId = value; }
        }
        /// <summary>[属性]优惠券类型</summary>
        public int? CouponsType
        {
            get { return couponsType; }
            set { couponsType = value; }
        }
        /// <summary>[属性]数量</summary>
        public int? Cnt
        {
            get { return cnt; }
            set { cnt = value; }
        }
        /// <summary>[属性]券号</summary>
        public string TicketNo
        {
            get { return ticketNo; }
            set { ticketNo = value; }
        }
        /// <summary>[属性]金额</summary>
        public double? Amount
        {
            get { return amount; }
            set { amount = value; }
        }


        #endregion EasyCode所生成的默认代码
    }
}
