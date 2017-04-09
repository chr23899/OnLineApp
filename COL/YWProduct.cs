using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：菜品数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWProduct
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
        /// <summary>[变量]菜品类别</summary>
        private int? productType;
        /// <summary>[变量]辣度</summary>
        private int? hotDegree;
        /// <summary>[变量]菜品归属</summary>
        private int? blongOrg;
        /// <summary>[变量]评分</summary>
        private int? score;
        /// <summary>[变量]标准价格</summary>
        private double? stdPrice;
        /// <summary>[变量]会员价格</summary>
        private double? memberPrice;
        /// <summary>[变量]状态</summary>
        private string state;
        /// <summary>[变量]制作时间</summary>
        private int? makeTime;
        /// <summary>[变量]原料</summary>
        private string materials;
        /// <summary>[变量]简介</summary>
        private string description;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]切配数量</summary>
        private int? cutCnt;


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
        /// <summary>[属性]菜品类别</summary>
        public int? ProductType
        {
            get { return productType; }
            set { productType = value; }
        }
        /// <summary>[属性]辣度</summary>
        public int? HotDegree
        {
            get { return hotDegree; }
            set { hotDegree = value; }
        }
        /// <summary>[属性]菜品归属</summary>
        public int? BlongOrg
        {
            get { return blongOrg; }
            set { blongOrg = value; }
        }
        /// <summary>[属性]评分</summary>
        public int? Score
        {
            get { return score; }
            set { score = value; }
        }
        /// <summary>[属性]标准价格</summary>
        public double? StdPrice
        {
            get { return stdPrice; }
            set { stdPrice = value; }
        }
        /// <summary>[属性]会员价格</summary>
        public double? MemberPrice
        {
            get { return memberPrice; }
            set { memberPrice = value; }
        }
        /// <summary>[属性]状态</summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>[属性]制作时间</summary>
        public int? MakeTime
        {
            get { return makeTime; }
            set { makeTime = value; }
        }
        /// <summary>[属性]原料</summary>
        public string Materials
        {
            get { return materials; }
            set { materials = value; }
        }
        /// <summary>[属性]简介</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]切配数量</summary>
        public int? CutCnt
        {
            get { return cutCnt; }
            set { cutCnt = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion EasyCode所生成的默认代码
    }
}
