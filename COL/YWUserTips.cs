using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：用户提示数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2016-1-25 16:42:49
    /// </summary>
    [Serializable]
    public class YWUserTips
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]用户名</summary>
        private string userName;
        /// <summary>[变量]提示1</summary>
        private int? tips1;
        /// <summary>[变量]提示2</summary>
        private int? tips2;
        /// <summary>[变量]提示3</summary>
        private int? tips3;
        /// <summary>[变量]提示4</summary>
        private int? tips4;
        /// <summary>[变量]提示5</summary>
        private int? tips5;
        /// <summary>[变量]提示6</summary>
        private int? tips6;
        /// <summary>[变量]提示7</summary>
        private int? tips7;
        /// <summary>[变量]提示8</summary>
        private int? tips8;
        /// <summary>[变量]提示9</summary>
        private int? tips9;
        /// <summary>[变量]提示10</summary>
        private int? tips10;
        /// <summary>[变量]提示11</summary>
        private int? tips11;
        /// <summary>[变量]提示12</summary>
        private int? tips12;
        /// <summary>[变量]提示13</summary>
        private int? tips13;
        /// <summary>[变量]提示14</summary>
        private int? tips14;
        /// <summary>[变量]提示15</summary>
        private int? tips15;
        /// <summary>[变量]提示16</summary>
        private int? tips16;
        /// <summary>[变量]提示17</summary>
        private int? tips17;
        /// <summary>[变量]提示18</summary>
        private int? tips18;
        /// <summary>[变量]提示19</summary>
        private int? tips19;
        /// <summary>[变量]提示20</summary>
        private int? tips20;


        /// <summary>[属性]用户名</summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        /// <summary>[属性]提示1</summary>
        public int? Tips1
        {
            get { return tips1; }
            set { tips1 = value; }
        }
        /// <summary>[属性]提示2</summary>
        public int? Tips2
        {
            get { return tips2; }
            set { tips2 = value; }
        }
        /// <summary>[属性]提示3</summary>
        public int? Tips3
        {
            get { return tips3; }
            set { tips3 = value; }
        }
        /// <summary>[属性]提示4</summary>
        public int? Tips4
        {
            get { return tips4; }
            set { tips4 = value; }
        }
        /// <summary>[属性]提示5</summary>
        public int? Tips5
        {
            get { return tips5; }
            set { tips5 = value; }
        }
        /// <summary>[属性]提示6</summary>
        public int? Tips6
        {
            get { return tips6; }
            set { tips6 = value; }
        }
        /// <summary>[属性]提示7</summary>
        public int? Tips7
        {
            get { return tips7; }
            set { tips7 = value; }
        }
        /// <summary>[属性]提示8</summary>
        public int? Tips8
        {
            get { return tips8; }
            set { tips8 = value; }
        }
        /// <summary>[属性]提示9</summary>
        public int? Tips9
        {
            get { return tips9; }
            set { tips9 = value; }
        }
        /// <summary>[属性]提示10</summary>
        public int? Tips10
        {
            get { return tips10; }
            set { tips10 = value; }
        }
        /// <summary>[属性]提示11</summary>
        public int? Tips11
        {
            get { return tips11; }
            set { tips11 = value; }
        }
        /// <summary>[属性]提示12</summary>
        public int? Tips12
        {
            get { return tips12; }
            set { tips12 = value; }
        }
        /// <summary>[属性]提示13</summary>
        public int? Tips13
        {
            get { return tips13; }
            set { tips13 = value; }
        }
        /// <summary>[属性]提示14</summary>
        public int? Tips14
        {
            get { return tips14; }
            set { tips14 = value; }
        }
        /// <summary>[属性]提示15</summary>
        public int? Tips15
        {
            get { return tips15; }
            set { tips15 = value; }
        }
        /// <summary>[属性]提示16</summary>
        public int? Tips16
        {
            get { return tips16; }
            set { tips16 = value; }
        }
        /// <summary>[属性]提示17</summary>
        public int? Tips17
        {
            get { return tips17; }
            set { tips17 = value; }
        }
        /// <summary>[属性]提示18</summary>
        public int? Tips18
        {
            get { return tips18; }
            set { tips18 = value; }
        }
        /// <summary>[属性]提示19</summary>
        public int? Tips19
        {
            get { return tips19; }
            set { tips19 = value; }
        }
        /// <summary>[属性]提示20</summary>
        public int? Tips20
        {
            get { return tips20; }
            set { tips20 = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return UserName;
        }

        #endregion EasyCode所生成的默认代码
    }
}
