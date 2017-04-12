using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：餐桌数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWTable
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]名称</summary>
        private string name;
        /// <summary>[变量]餐桌类别</summary>
        private string tableType;
        /// <summary>[变量]标准人数</summary>
        private int? stdCapacity;
        /// <summary>[变量]最大容量</summary>
        private int? maxCapacity;
        /// <summary>[变量]最低消费</summary>
        private int? minConsumption;
        /// <summary>[变量]照片</summary>
        private string photo;
        /// <summary>[变量]简介</summary>
        private string description;
        /// <summary>[变量]负责人</summary>
        private string owner;
        /// <summary>[变量]参与人</summary>
        private string others;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]名称</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]餐桌类别</summary>
        public string TableTypeId
        {
            get { return tableType; }
            set { tableType = value; }
        }
        /// <summary>[属性]标准人数</summary>
        public int? StdCapacity
        {
            get { return stdCapacity; }
            set { stdCapacity = value; }
        }
        /// <summary>[属性]最大容量</summary>
        public int? MaxCapacity
        {
            get { return maxCapacity; }
            set { maxCapacity = value; }
        }
        /// <summary>[属性]最低消费</summary>
        public int? MinConsumption
        {
            get { return minConsumption; }
            set { minConsumption = value; }
        }
        /// <summary>[属性]照片</summary>
        public string Photo
        {
            get { return photo; }
            set { photo = value; }
        }
        /// <summary>[属性]简介</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>[属性]负责人</summary>
        public string OwnerUserName
        {
            get { return owner; }
            set { owner = value; }
        }
        /// <summary>[属性]参与人</summary>
        public string Others
        {
            get { return others; }
            set { others = value; }
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
            return Name;
        }

        #endregion EasyCode所生成的默认代码
    }
}
