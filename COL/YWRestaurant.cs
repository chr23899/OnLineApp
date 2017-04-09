using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：餐厅数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWRestaurant
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]机构编号</summary>
        private int? org;
        /// <summary>[变量]名称</summary>
        private string name;
        /// <summary>[变量]餐厅类别</summary>
        private int? restaurantType;
        /// <summary>[变量]授权类型</summary>
        private int? roleType;
        /// <summary>[变量]到期时间</summary>
        private string finishTime;
        /// <summary>[变量]状态</summary>
        private string state;
        /// <summary>[变量]评分</summary>
        private int? score;
        /// <summary>[变量]地址</summary>
        private string address;
        /// <summary>[变量]电话</summary>
        private string phone;
        /// <summary>[变量]负责人</summary>
        private string owner;
        /// <summary>[变量]订餐电话</summary>
        private string bookPhones;
        /// <summary>[变量]简介</summary>
        private string description;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]机构编号</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]名称</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]餐厅类别</summary>
        public int? RestaurantType
        {
            get { return restaurantType; }
            set { restaurantType = value; }
        }
        /// <summary>[属性]授权类型</summary>
        public int? RoleType
        {
            get { return roleType; }
            set { roleType = value; }
        }
        /// <summary>[属性]到期时间</summary>
        public string FinishTime
        {
            get { return finishTime; }
            set { finishTime = value; }
        }
        /// <summary>[属性]状态</summary>
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        /// <summary>[属性]评分</summary>
        public int? Score
        {
            get { return score; }
            set { score = value; }
        }
        /// <summary>[属性]地址</summary>
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        /// <summary>[属性]电话</summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>[属性]负责人</summary>
        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        /// <summary>[属性]订餐电话</summary>
        public string BookPhones
        {
            get { return bookPhones; }
            set { bookPhones = value; }
        }
        /// <summary>[属性]简介</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
