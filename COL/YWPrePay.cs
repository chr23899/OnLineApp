using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：预支数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWPrePay
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]借款类型</summary>
        private int? lentType;
        /// <summary>[变量]借款原因</summary>
        private int? lentCause;
        /// <summary>[变量]预支金额</summary>
        private double? lentAmount;
        /// <summary>[变量]预支时间</summary>
        private string lentTime;
        /// <summary>[变量]预计归还时间</summary>
        private string aboutReturnTime;
        /// <summary>[变量]预支人</summary>
        private string borrowUser;
        /// <summary>[变量]批准人</summary>
        private string confirmUser;
        /// <summary>[变量]付款人</summary>
        private string payUser;
        /// <summary>[变量]已还金额</summary>
        private double? returnAmount;
        /// <summary>[变量]状态</summary>
        private int? state;
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
        /// <summary>[属性]借款类型</summary>
        public int? LentType
        {
            get { return lentType; }
            set { lentType = value; }
        }
        /// <summary>[属性]借款原因</summary>
        public int? LentCause
        {
            get { return lentCause; }
            set { lentCause = value; }
        }
        /// <summary>[属性]预支金额</summary>
        public double? LentAmount
        {
            get { return lentAmount; }
            set { lentAmount = value; }
        }
        /// <summary>[属性]预支时间</summary>
        public string LentTime
        {
            get { return lentTime; }
            set { lentTime = value; }
        }
        /// <summary>[属性]预计归还时间</summary>
        public string AboutReturnTime
        {
            get { return aboutReturnTime; }
            set { aboutReturnTime = value; }
        }
        /// <summary>[属性]预支人</summary>
        public string BorrowUser
        {
            get { return borrowUser; }
            set { borrowUser = value; }
        }
        /// <summary>[属性]批准人</summary>
        public string ConfirmUser
        {
            get { return confirmUser; }
            set { confirmUser = value; }
        }
        /// <summary>[属性]付款人</summary>
        public string PayUser
        {
            get { return payUser; }
            set { payUser = value; }
        }
        /// <summary>[属性]已还金额</summary>
        public double? ReturnAmount
        {
            get { return returnAmount; }
            set { returnAmount = value; }
        }
        /// <summary>[属性]状态</summary>
        public int? State
        {
            get { return state; }
            set { state = value; }
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

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return LentAmount.ToString();
        }

        #endregion EasyCode所生成的默认代码
    }
}
