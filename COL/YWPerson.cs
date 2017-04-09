using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：人员数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWPerson
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
        /// <summary>[变量]姓名</summary>
        private string name;
        /// <summary>[变量]性别</summary>
        private string sex;
        /// <summary>[变量]出生年月</summary>
        private string birth;
        /// <summary>[变量]入职时间</summary>
        private string entryTime;
        /// <summary>[变量]电话</summary>
        private string phone;
        /// <summary>[变量]身份证号</summary>
        private string iDCardId;
        /// <summary>[变量]评分</summary>
        private int? score;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;


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
        /// <summary>[属性]姓名</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]性别</summary>
        public string Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        /// <summary>[属性]出生年月</summary>
        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        /// <summary>[属性]入职时间</summary>
        public string EntryTime
        {
            get { return entryTime; }
            set { entryTime = value; }
        }
        /// <summary>[属性]电话</summary>
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        /// <summary>[属性]身份证号</summary>
        public string IDCardId
        {
            get { return iDCardId; }
            set { iDCardId = value; }
        }
        /// <summary>[属性]评分</summary>
        public int? Score
        {
            get { return score; }
            set { score = value; }
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
