using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：日志数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2016-1-16 10:55:02
    /// </summary>
    [Serializable]
    public class YWLog
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]业务类别</summary>
        private YWDictionary yWType;
        /// <summary>[变量]业务数据编号</summary>
        private int? yWRecordId;
        /// <summary>[变量]操作人</summary>
        private PTUsers opr;
        /// <summary>[变量]操作时间</summary>
        private DateTime? oprTime;
        /// <summary>[变量]描述</summary>
        private string description;
        /// <summary>[变量]备用1</summary>
        private string backup1;
        /// <summary>[变量]备用2</summary>
        private string backup2;
        /// <summary>[变量]备用3</summary>
        private string backup3;
        /// <summary>[变量]备用4</summary>
        private string backup4;
        /// <summary>[变量]备用5</summary>
        private string backup5;
        /// <summary>[变量]备用6</summary>
        private string backup6;
        /// <summary>[变量]备用7</summary>
        private string backup7;
        /// <summary>[变量]备用8</summary>
        private string backup8;
        /// <summary>[变量]备用9</summary>
        private string backup9;
        /// <summary>[变量]备用10</summary>
        private string backup10;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]业务类别</summary>
        public YWDictionary YWType
        {
            get { return yWType; }
            set { yWType = value; }
        }
        /// <summary>[属性]业务数据编号</summary>
        public int? YWRecordId
        {
            get { return yWRecordId; }
            set { yWRecordId = value; }
        }
        /// <summary>[属性]操作人</summary>
        public PTUsers Opr
        {
            get { return opr; }
            set { opr = value; }
        }
        /// <summary>[属性]操作时间</summary>
        public DateTime? OprTime
        {
            get { return oprTime; }
            set { oprTime = value; }
        }
        /// <summary>[属性]描述</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>[属性]备用1</summary>
        public string Backup1
        {
            get { return backup1; }
            set { backup1 = value; }
        }
        /// <summary>[属性]备用2</summary>
        public string Backup2
        {
            get { return backup2; }
            set { backup2 = value; }
        }
        /// <summary>[属性]备用3</summary>
        public string Backup3
        {
            get { return backup3; }
            set { backup3 = value; }
        }
        /// <summary>[属性]备用4</summary>
        public string Backup4
        {
            get { return backup4; }
            set { backup4 = value; }
        }
        /// <summary>[属性]备用5</summary>
        public string Backup5
        {
            get { return backup5; }
            set { backup5 = value; }
        }
        /// <summary>[属性]备用6</summary>
        public string Backup6
        {
            get { return backup6; }
            set { backup6 = value; }
        }
        /// <summary>[属性]备用7</summary>
        public string Backup7
        {
            get { return backup7; }
            set { backup7 = value; }
        }
        /// <summary>[属性]备用8</summary>
        public string Backup8
        {
            get { return backup8; }
            set { backup8 = value; }
        }
        /// <summary>[属性]备用9</summary>
        public string Backup9
        {
            get { return backup9; }
            set { backup9 = value; }
        }
        /// <summary>[属性]备用10</summary>
        public string Backup10
        {
            get { return backup10; }
            set { backup10 = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Id.ToString();
        }

        #endregion EasyCode所生成的默认代码
    }
}
