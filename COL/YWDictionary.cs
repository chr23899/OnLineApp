using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：数据字典数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-8 9:36:12
    /// </summary>
    [Serializable]
    public class YWDictionary
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编码</summary>
        private int? id;
        /// <summary>[变量]类别</summary>
        private string dictionaryType;
        /// <summary>[变量]识别码</summary>
        private string codeId;
        /// <summary>[变量]名称</summary>
        private string name;
        /// <summary>[变量]描述</summary>
        private string description;
        /// <summary>[变量]备用１</summary>
        private string backup1;
        /// <summary>[变量]备用２</summary>
        private string backup2;
        /// <summary>[变量]备用３</summary>
        private string backup3;
        /// <summary>[变量]备用４</summary>
        private string backup4;
        /// <summary>[变量]备用５</summary>
        private string backup5;
        /// <summary>[变量]备用６</summary>
        private string backup6;
        /// <summary>[变量]备用７</summary>
        private string backup7;
        /// <summary>[变量]备用８</summary>
        private string backup8;
        /// <summary>[变量]备用９</summary>
        private string backup9;
        /// <summary>[变量]备用１０</summary>
        private string backup10;


        /// <summary>[属性]编码</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]类别</summary>
        public string DictionaryType
        {
            get { return dictionaryType; }
            set { dictionaryType = value; }
        }
        /// <summary>[属性]识别码</summary>
        public string CodeId
        {
            get { return codeId; }
            set { codeId = value; }
        }
        /// <summary>[属性]名称</summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        /// <summary>[属性]描述</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        /// <summary>[属性]备用１</summary>
        public string Backup1
        {
            get { return backup1; }
            set { backup1 = value; }
        }
        /// <summary>[属性]备用２</summary>
        public string Backup2
        {
            get { return backup2; }
            set { backup2 = value; }
        }
        /// <summary>[属性]备用３</summary>
        public string Backup3
        {
            get { return backup3; }
            set { backup3 = value; }
        }
        /// <summary>[属性]备用４</summary>
        public string Backup4
        {
            get { return backup4; }
            set { backup4 = value; }
        }
        /// <summary>[属性]备用５</summary>
        public string Backup5
        {
            get { return backup5; }
            set { backup5 = value; }
        }
        /// <summary>[属性]备用６</summary>
        public string Backup6
        {
            get { return backup6; }
            set { backup6 = value; }
        }
        /// <summary>[属性]备用７</summary>
        public string Backup7
        {
            get { return backup7; }
            set { backup7 = value; }
        }
        /// <summary>[属性]备用８</summary>
        public string Backup8
        {
            get { return backup8; }
            set { backup8 = value; }
        }
        /// <summary>[属性]备用９</summary>
        public string Backup9
        {
            get { return backup9; }
            set { backup9 = value; }
        }
        /// <summary>[属性]备用１０</summary>
        public string Backup10
        {
            get { return backup10; }
            set { backup10 = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return Name;
        }

        #endregion EasyCode所生成的默认代码
    }
}
