using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：退菜数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2016-2-17 10:26:09
    /// </summary>
    [Serializable]
    public class YWFoodReturn
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编码</summary>
        private int? id;
        /// <summary>[变量]菜品编码</summary>
        private int? food;
        /// <summary>[变量]退菜原因</summary>
        private int? reasonId;
        /// <summary>[变量]描述</summary>
        private string description;
        /// <summary>[变量]申请时间</summary>
        private string applyTime;
        /// <summary>[变量]申请人</summary>
        private string applyUser;
        /// <summary>[变量]审核时间</summary>
        private string approveTime;
        /// <summary>[变量]审核人</summary>
        private string approveUser;


        /// <summary>[属性]编码</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]菜品编码</summary>
        public int? Food
        {
            get { return food; }
            set { food = value; }
        }
        /// <summary>[属性]退菜原因</summary>
        public int? ReasonId
        {
            get { return reasonId; }
            set { reasonId = value; }
        }
        /// <summary>[属性]描述</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>[属性]申请时间</summary>
        public string ApplyTime
        {
            get { return applyTime; }
            set { applyTime = value; }
        }
        /// <summary>[属性]申请人</summary>
        public string ApplyUser
        {
            get { return applyUser; }
            set { applyUser = value; }
        }
        /// <summary>[属性]审核时间</summary>
        public string ApproveTime
        {
            get { return approveTime; }
            set { approveTime = value; }
        }
        /// <summary>[属性]审核人</summary>
        public string ApproveUser
        {
            get { return approveUser; }
            set { approveUser = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
