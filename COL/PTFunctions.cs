using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：系统功能列表数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    [Serializable]
    public class PTFunctions
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private string id;
        /// <summary>[变量]上级编号</summary>
        private string fatherNumber;
        /// <summary>[变量]功能名称</summary>
        private string functionName;
        /// <summary>[变量]功能类型</summary>
        private string functionTypeId;
        /// <summary>[变量]路径</summary>
        private string functionPath;
        /// <summary>[变量]功能描述</summary>
        private string description;
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


        /// <summary>[属性]编号</summary>
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]上级编号</summary>
        public string FatherNumber
        {
            get { return fatherNumber; }
            set { fatherNumber = value; }
        }
        /// <summary>[属性]功能名称</summary>
        public string FunctionName
        {
            get { return functionName; }
            set { functionName = value; }
        }
        /// <summary>[属性]功能类型</summary>
        public string FunctionTypeId
        {
            get { return functionTypeId; }
            set { functionTypeId = value; }
        }
        /// <summary>[属性]路径</summary>
        public string FunctionPath
        {
            get { return functionPath; }
            set { functionPath = value; }
        }
        /// <summary>[属性]功能描述</summary>
        public string Description
        {
            get { return description; }
            set { description = value; }
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
            return FunctionName;
        }

        #endregion EasyCode所生成的默认代码
    }
}
