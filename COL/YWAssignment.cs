using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：基础对象名称数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：陈焕然
    /// 编写日期：2017/4/13 23:18:10
    /// </summary>
    [Serializable]
    public class YWAssignment
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]</summary>
        private int? id;
        /// <summary>[变量]</summary>
        private int? planId;
        /// <summary>[变量]</summary>
        private string planName;
        /// <summary>[变量]</summary>
        private int? courseId;
        /// <summary>[变量]</summary>
        private string courseName;
        /// <summary>[变量]</summary>
        private string createUserName;
        /// <summary>[变量]</summary>
        private int? createUserId;
        /// <summary>[变量]</summary>
        private string updateUserName;
        /// <summary>[变量]</summary>
        private int? updateUserId;
        /// <summary>[变量]</summary>
        private string title;
        /// <summary>[变量]</summary>
        private string content;
        /// <summary>[变量]</summary>
        private string link;
        /// <summary>[变量]</summary>
        private DateTime? createTime;
        /// <summary>[变量]</summary>
        private DateTime? updateTime;
        /// <summary>[变量]</summary>
        private int? status;
        /// <summary>[变量]</summary>
        private string alternate1;
        /// <summary>[变量]</summary>
        private string alternate2;
        /// <summary>[变量]</summary>
        private string alternate3;
        /// <summary>[变量]</summary>
        private string alternate4;
        /// <summary>[变量]</summary>
        private string alternate5;


        /// <summary>[属性]</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]</summary>
        public int? PlanId
        {
            get { return planId; }
            set { planId = value; }
        }
        /// <summary>[属性]</summary>
        public string PlanName
        {
            get { return planName; }
            set { planName = value; }
        }
        /// <summary>[属性]</summary>
        public int? CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        /// <summary>[属性]</summary>
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        /// <summary>[属性]</summary>
        public string CreateUserName
        {
            get { return createUserName; }
            set { createUserName = value; }
        }
        /// <summary>[属性]</summary>
        public int? CreateUserId
        {
            get { return createUserId; }
            set { createUserId = value; }
        }
        /// <summary>[属性]</summary>
        public string UpdateUserName
        {
            get { return updateUserName; }
            set { updateUserName = value; }
        }
        /// <summary>[属性]</summary>
        public int? UpdateUserId
        {
            get { return updateUserId; }
            set { updateUserId = value; }
        }
        /// <summary>[属性]</summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>[属性]</summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>[属性]</summary>
        public string Link
        {
            get { return link; }
            set { link = value; }
        }
        /// <summary>[属性]</summary>
        public DateTime? CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        /// <summary>[属性]</summary>
        public DateTime? UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
        }
        /// <summary>[属性]</summary>
        public int? Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate1
        {
            get { return alternate1; }
            set { alternate1 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate2
        {
            get { return alternate2; }
            set { alternate2 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate3
        {
            get { return alternate3; }
            set { alternate3 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate4
        {
            get { return alternate4; }
            set { alternate4 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate5
        {
            get { return alternate5; }
            set { alternate5 = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
