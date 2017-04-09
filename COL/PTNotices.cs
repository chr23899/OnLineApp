using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：提示消息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2013-11-27 11:49:58
    /// </summary>
    [Serializable]
    public class PTNotices
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]类别</summary>
        private string typeId;
        /// <summary>[变量]机构范围</summary>
        private string orgRange;
        /// <summary>[变量]角色范围</summary>
        private string roleScope;
        /// <summary>[变量]用户范围</summary>
        private string userRange;
        /// <summary>[变量]作者</summary>
        private string author;
        /// <summary>[变量]发布时间</summary>
        private string releaseTime;
        /// <summary>[变量]已读状态</summary>
        private string readStatus;
        /// <summary>[变量]标题</summary>
        private string title;
        /// <summary>[变量]正文</summary>
        private string content;
        /// <summary>[变量]附件地址</summary>
        private string attachment;
        /// <summary>[变量]图片地址</summary>
        private string pictureAddress;
        /// <summary>[变量]备用１</summary>
        private string alternate1;
        /// <summary>[变量]备用２</summary>
        private string alternate2;
        /// <summary>[变量]备用３</summary>
        private string alternate3;
        /// <summary>[变量]备用４</summary>
        private string alternate4;
        /// <summary>[变量]备用５</summary>
        private string alternate5;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]类别</summary>
        public string TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }
        /// <summary>[属性]机构范围</summary>
        public string OrgRange
        {
            get { return orgRange; }
            set { orgRange = value; }
        }
        /// <summary>[属性]角色范围</summary>
        public string RoleScope
        {
            get { return roleScope; }
            set { roleScope = value; }
        }
        /// <summary>[属性]用户范围</summary>
        public string UserRange
        {
            get { return userRange; }
            set { userRange = value; }
        }
        /// <summary>[属性]作者</summary>
        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        /// <summary>[属性]发布时间</summary>
        public string ReleaseTime
        {
            get { return releaseTime; }
            set { releaseTime = value; }
        }
        /// <summary>[属性]已读状态</summary>
        public string ReadStatus
        {
            get { return readStatus; }
            set { readStatus = value; }
        }
        /// <summary>[属性]标题</summary>
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        /// <summary>[属性]正文</summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>[属性]附件地址</summary>
        public string Attachment
        {
            get { return attachment; }
            set { attachment = value; }
        }
        /// <summary>[属性]图片地址</summary>
        public string PictureAddress
        {
            get { return pictureAddress; }
            set { pictureAddress = value; }
        }
        /// <summary>[属性]备用１</summary>
        public string Alternate1
        {
            get { return alternate1; }
            set { alternate1 = value; }
        }
        /// <summary>[属性]备用２</summary>
        public string Alternate2
        {
            get { return alternate2; }
            set { alternate2 = value; }
        }
        /// <summary>[属性]备用３</summary>
        public string Alternate3
        {
            get { return alternate3; }
            set { alternate3 = value; }
        }
        /// <summary>[属性]备用４</summary>
        public string Alternate4
        {
            get { return alternate4; }
            set { alternate4 = value; }
        }
        /// <summary>[属性]备用５</summary>
        public string Alternate5
        {
            get { return alternate5; }
            set { alternate5 = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Title;
        }

        #endregion EasyCode所生成的默认代码
    }
}
