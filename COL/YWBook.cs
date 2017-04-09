using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：预订数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWBook
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]座位</summary>
        private int? bookTable;
        /// <summary>[变量]预订时间</summary>
        private string bookTime;
        /// <summary>[变量]客户姓名</summary>
        private string customerName;
        /// <summary>[变量]客户电话</summary>
        private string customerPhone;
        /// <summary>[变量]预计人数</summary>
        private int? reachNumber;
        /// <summary>[变量]预计到店时间</summary>
        private string reachTime;
        /// <summary>[变量]消费时间段</summary>
        private int? consumeTimeBlock;
        /// <summary>[变量]接单人</summary>
        private string orderUser;
        /// <summary>[变量]接单时间</summary>
        private string orderTime;
        /// <summary>[变量]预订折扣</summary>
        private double? bookOff;
        /// <summary>[变量]预定状态</summary>
        private int? bookState;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]座位</summary>
        public int? BookTable
        {
            get { return bookTable; }
            set { bookTable = value; }
        }
        /// <summary>[属性]预订时间</summary>
        public string BookTime
        {
            get { return bookTime; }
            set { bookTime = value; }
        }
        /// <summary>[属性]客户姓名</summary>
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        /// <summary>[属性]客户电话</summary>
        public string CustomerPhone
        {
            get { return customerPhone; }
            set { customerPhone = value; }
        }
        /// <summary>[属性]预计人数</summary>
        public int? ReachNumber
        {
            get { return reachNumber; }
            set { reachNumber = value; }
        }
        /// <summary>[属性]预计到店时间</summary>
        public string ReachTime
        {
            get { return reachTime; }
            set { reachTime = value; }
        }
        /// <summary>[属性]消费时间段</summary>
        public int? ConsumeTimeBlock
        {
            get { return consumeTimeBlock; }
            set { consumeTimeBlock = value; }
        }
        /// <summary>[属性]接单人</summary>
        public string OrderUser
        {
            get { return orderUser; }
            set { orderUser = value; }
        }
        /// <summary>[属性]接单时间</summary>
        public string OrderTime
        {
            get { return orderTime; }
            set { orderTime = value; }
        }
        /// <summary>[属性]预订折扣</summary>
        public double? BookOff
        {
            get { return bookOff; }
            set { bookOff = value; }
        }
        /// <summary>[属性]预定状态</summary>
        public int? BookState
        {
            get { return bookState; }
            set { bookState = value; }
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
            return CustomerPhone;
        }

        #endregion EasyCode所生成的默认代码
    }
}
