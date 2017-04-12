using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：原料数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWMaterial
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
        /// <summary>[变量]简称</summary>
        private string shortName;
        /// <summary>[变量]原料类别</summary>
        private int? materialType;
        /// <summary>[变量]标准单位</summary>
        private string stdUnit;
        /// <summary>[变量]原料归属</summary>
        private int? belongType;
        /// <summary>[变量]存放要求</summary>
        private string storageRules;
        /// <summary>[变量]其它单位</summary>
        private string otherUnits;
        /// <summary>[变量]最少存储量</summary>
        private int? minStorage;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]盘存周期</summary>
        private int? inventoryCycle;


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
        /// <summary>[属性]简称</summary>
        public string ShortName
        {
            get { return shortName; }
            set { shortName = value; }
        }
        /// <summary>[属性]原料类别</summary>
        public int? MaterialType
        {
            get { return materialType; }
            set { materialType = value; }
        }
        /// <summary>[属性]标准单位</summary>
        public string StdUnit
        {
            get { return stdUnit; }
            set { stdUnit = value; }
        }
        /// <summary>[属性]原料归属</summary>
        public int? BelongType
        {
            get { return belongType; }
            set { belongType = value; }
        }
        /// <summary>[属性]存放要求</summary>
        public string StorageRules
        {
            get { return storageRules; }
            set { storageRules = value; }
        }
        /// <summary>[属性]其它单位</summary>
        public string OtherUnits
        {
            get { return otherUnits; }
            set { otherUnits = value; }
        }
        /// <summary>[属性]最少存储量</summary>
        public int? MinStorage
        {
            get { return minStorage; }
            set { minStorage = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]盘存周期</summary>
        public int? InventoryCycle
        {
            get { return inventoryCycle; }
            set { inventoryCycle = value; }
        }
        

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion EasyCode所生成的默认代码
    }
}
