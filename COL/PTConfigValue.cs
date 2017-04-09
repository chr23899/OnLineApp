using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：配置值数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    [Serializable]
    public class PTConfigValue
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]配置项</summary>
        private string configItem;
        /// <summary>[变量]当前值</summary>
        private string currentValue;
        /// <summary>[变量]适用对象</summary>
        private string target;
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
        /// <summary>[属性]配置项</summary>
        public string ConfigItem
        {
            get { return configItem; }
            set { configItem = value; }
        }
        /// <summary>[属性]当前值</summary>
        public string CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }
        /// <summary>[属性]适用对象</summary>
        public string Target
        {
            get { return target; }
            set { target = value; }
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

        #endregion EasyCode所生成的默认代码
    }
}
