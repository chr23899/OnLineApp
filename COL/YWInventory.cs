using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：盘存记录数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWInventory
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
        /// <summary>[变量]库存总数</summary>
        private double? totalStorge;
        /// <summary>[变量]实际总数</summary>
        private double? actualTotal;
        /// <summary>[变量]是否对应</summary>
        private bool? match;
        /// <summary>[变量]盘存人</summary>
        private string inventoryUser;
        /// <summary>[变量]盘存时间</summary>
        private string inventoryTime;
        /// <summary>[变量]修正值</summary>
        private double? updateValue;
        /// <summary>[变量]修正确认人</summary>
        private string updateConfirmUser;
        /// <summary>[变量]修正时间</summary>
        private string updateTime;
        /// <summary>[变量]盘存单位</summary>
        private int? inventoryOrg;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;


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
        /// <summary>[属性]库存总数</summary>
        public double? TotalStorge
        {
            get { return totalStorge; }
            set { totalStorge = value; }
        }
        /// <summary>[属性]实际总数</summary>
        public double? ActualTotal
        {
            get { return actualTotal; }
            set { actualTotal = value; }
        }
        /// <summary>[属性]是否对应</summary>
        public bool? Match
        {
            get { return match; }
            set { match = value; }
        }
        /// <summary>[属性]盘存人</summary>
        public string InventoryUser
        {
            get { return inventoryUser; }
            set { inventoryUser = value; }
        }
        /// <summary>[属性]盘存时间</summary>
        public string InventoryTime
        {
            get { return inventoryTime; }
            set { inventoryTime = value; }
        }
        /// <summary>[属性]修正值</summary>
        public double? UpdateValue
        {
            get { return updateValue; }
            set { updateValue = value; }
        }
        /// <summary>[属性]修正确认人</summary>
        public string UpdateConfirmUser
        {
            get { return updateConfirmUser; }
            set { updateConfirmUser = value; }
        }
        /// <summary>[属性]修正时间</summary>
        public string UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        /// <summary>[属性]盘存单位</summary>
        public int? InventoryOrg
        {
            get { return inventoryOrg; }
            set { inventoryOrg = value; }
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
