using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：角色权限关联表数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    [Serializable]
    public class PTRoleLink
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]序号</summary>
        private int? id;
        /// <summary>[变量]角色编号</summary>
        private int? roleId;
        /// <summary>[变量]功能编号</summary>
        private string functionId;


        /// <summary>[属性]序号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]角色编号</summary>
        public int? RoleId
        {
            get { return roleId; }
            set { roleId = value; }
        }
        /// <summary>[属性]功能编号</summary>
        public string FunctionId
        {
            get { return functionId; }
            set { functionId = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
