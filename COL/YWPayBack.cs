using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：还款数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWPayBack
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]关联预支</summary>
        private int? prePay;
        /// <summary>[变量]还款金额</summary>
        private double? returnAmount;
        /// <summary>[变量]还款时间</summary>
        private string returnTime;
        /// <summary>[变量]还款人</summary>
        private string returnUser;
        /// <summary>[变量]收款人</summary>
        private string receiveUser;
        /// <summary>[变量]备注</summary>
        private string notes;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]关联预支</summary>
        public int? PrePay
        {
            get { return prePay; }
            set { prePay = value; }
        }
        /// <summary>[属性]还款金额</summary>
        public double? ReturnAmount
        {
            get { return returnAmount; }
            set { returnAmount = value; }
        }
        /// <summary>[属性]还款时间</summary>
        public string ReturnTime
        {
            get { return returnTime; }
            set { returnTime = value; }
        }
        /// <summary>[属性]还款人</summary>
        public string ReturnUser
        {
            get { return returnUser; }
            set { returnUser = value; }
        }
        /// <summary>[属性]收款人</summary>
        public string ReceiveUser
        {
            get { return receiveUser; }
            set { receiveUser = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
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
