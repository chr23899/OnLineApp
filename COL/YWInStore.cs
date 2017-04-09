using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：入库记录数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWInStore
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
        /// <summary>[变量]入库数量</summary>
        private double? storageQuantity;
        /// <summary>[变量]入库单位</summary>
        private string storageUnit;
        /// <summary>[变量]入库时间</summary>
        private string storageTime;
        /// <summary>[变量]确认人</summary>
        private string confirmUser;
        /// <summary>[变量]购买人</summary>
        private string buyUser;
        /// <summary>[变量]购买时间</summary>
        private string buyTime;
        /// <summary>[变量]结算总价</summary>
        private double? accountPrice;
        /// <summary>[变量]关联采购记录</summary>
        private int? buying;
        /// <summary>[变量]货物归属</summary>
        private int? belongOrg;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]备注</summary>
        private string notes;


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
        /// <summary>[属性]入库数量</summary>
        public double? StorageQuantity
        {
            get { return storageQuantity; }
            set { storageQuantity = value; }
        }
        /// <summary>[属性]入库单位</summary>
        public string StorageUnit
        {
            get { return storageUnit; }
            set { storageUnit = value; }
        }
        /// <summary>[属性]入库时间</summary>
        public string StorageTime
        {
            get { return storageTime; }
            set { storageTime = value; }
        }
        /// <summary>[属性]确认人</summary>
        public string ConfirmUser
        {
            get { return confirmUser; }
            set { confirmUser = value; }
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
        /// <summary>[属性]结算总价</summary>
        public double? AccountPrice
        {
            get { return accountPrice; }
            set { accountPrice = value; }
        }
        /// <summary>[属性]关联采购记录</summary>
        public int? Buying
        {
            get { return buying; }
            set { buying = value; }
        }
        /// <summary>[属性]货物归属</summary>
        public int? BelongOrg
        {
            get { return belongOrg; }
            set { belongOrg = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
