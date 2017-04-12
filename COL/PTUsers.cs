using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：基本用户信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    [Serializable]
    public class PTUsers
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]用户名</summary>
        private string userName;
        /// <summary>[变量]密码</summary>
        private string password;
        /// <summary>[变量]机构编号</summary>
        private int? orgId;
        /// <summary>[变量]昵称</summary>
        private string nickname;
        /// <summary>[变量]状态</summary>
        private string stateId;
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
        /// <summary>[变量]账户余额</summary>
        private decimal? balance;
        /// <summary>[变量]有效期</summary>
        private DateTime? validityDT;
        /// <summary>[变量]职位</summary>
        private string position;
        /// <summary>[变量]公司</summary>
        private string company;
        /// <summary>[变量]电话</summary>
        private string tel;
        /// <summary>[变量]ＱＱ</summary>
        private string qQ;
        /// <summary>[变量]微信</summary>
        private string weChat;
        /// <summary>[变量]邮箱</summary>
        private string email;
        /// <summary>[变量]主页</summary>
        private string homePage;
        /// <summary>[变量]是否完成问卷</summary>
        private int? isQA;
        /// <summary>[变量]上级用户</summary>
        private PTUsers superiorUser;
        /// <summary>[变量]连续签到天数</summary>
        private int? signDays;
        /// <summary>[变量]最后签到日期</summary>
        private DateTime? signDateTime;
        /// <summary>[变量]邀请码</summary>
        private string invCode;
        /// <summary>[变量]支付宝</summary>
        private string alipay;
        /// <summary>[变量]用户等级</summary>
        private string levelId;
        /// <summary>[变量]用户类型</summary>
        private string type;
        /// <summary>[变量]用户层级</summary>
        private string layer;
        /// <summary>[变量]用户备注</summary>
        private string note;

        /// <summary>[属性]用户等级</summary>
        public string LevelId
        {
            get { return levelId; }
            set { levelId = value; }
        }

        /// <summary>[属性]用户类型</summary>
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        /// <summary>[属性]用户等级</summary>
        public string Layer
        {
            get { return layer; }
            set { layer = value; }
        }

        /// <summary>[属性]备注</summary>
        public string Note
        {
            get { return note; }
            set { note = value; }
        }

        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]用户名</summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        /// <summary>[属性]密码</summary>
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        /// <summary>[属性]机构编号</summary>
        public int? OrgId
        {
            get { return orgId; }
            set { orgId = value; }
        }
        /// <summary>[属性]昵称</summary>
        public string Nickname
        {
            get { return nickname; }
            set { nickname = value; }
        }
        /// <summary>[属性]状态</summary>
        public string StateId
        {
            get { return stateId; }
            set { stateId = value; }
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
            return Nickname;
        }
        /// <summary>[属性]账户余额</summary>
        public decimal? Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        /// <summary>[属性]有效期</summary>
        public DateTime? ValidityDT
        {
            get { return validityDT; }
            set { validityDT = value; }
        }
        /// <summary>[属性]职位</summary>
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        /// <summary>[属性]公司</summary>
        public string Company
        {
            get { return company; }
            set { company = value; }
        }
        /// <summary>[属性]电话</summary>
        public string Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        /// <summary>[属性]ＱＱ</summary>
        public string QQ
        {
            get { return qQ; }
            set { qQ = value; }
        }
        /// <summary>[属性]微信</summary>
        public string WeChat
        {
            get { return weChat; }
            set { weChat = value; }
        }
        /// <summary>[属性]邮箱</summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        /// <summary>[属性]主页</summary>
        public string HomePage
        {
            get { return homePage; }
            set { homePage = value; }
        }
        /// <summary>[属性]是否完成问卷</summary>
        public int? IsQA
        {
            get { return isQA; }
            set { isQA = value; }
        }
        /// <summary>[属性]上级用户</summary>
        public PTUsers SuperiorUser
        {
            get { return superiorUser; }
            set { superiorUser = value; }
        }
        /// <summary>[属性]连续签到天数</summary>
        public int? SignDays
        {
            get { return signDays; }
            set { signDays = value; }
        }
        /// <summary>[属性]最后签到日期</summary>
        public DateTime? SignDateTime
        {
            get { return signDateTime; }
            set { signDateTime = value; }
        }
        /// <summary>[属性]邀请码</summary>
        public string InvCode
        {
            get { return invCode; }
            set { invCode = value; }
        }
        /// <summary>[属性]支付宝</summary>
        public string Alipay
        {
            get { return alipay; }
            set { alipay = value; }
        }
        #endregion EasyCode所生成的默认代码
    }
}
