using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：查询参数数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    [Serializable]
    public class Parameter
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]条件文本</summary>
        private string sqlString;
        /// <summary>[变量]查询参数集</summary>
        private SqlParameter[] parameters;



        /// <summary>[属性]条件文本</summary>
        public string SqlString
        {
            get { return sqlString; }
            set { sqlString = value; }
        }
        /// <summary>[属性]查询参数集</summary>
        public SqlParameter[] Parameters
        {
            get { return parameters; }
            set { parameters = value; }
        }
       

        #endregion EasyCode所生成的默认代码
    }
}
