﻿using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.DAL;
using Chr.OnlineApp.SFL;

namespace Chr.OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：用户角色关联业务逻辑类（业务逻辑层）
    /// 对象说明：关联用户和角色，多对多关系．
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-8-6 15:37:18
    /// </summary>
    public class PTUserLinkBLL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要提供该类的基本业务逻辑。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 返回与本类相关联的数据访问类。通常本类需要访问自身关联的数据访问类，与数据库进行交互时，应优先使用该属性，
        /// 本类调用业务逻辑层其它业务逻辑类时，应当优先使用其它类中公开的方法，而不优先使用其它类中的DataAccess属性。
        /// </summary>
        internal static DAL.Common.PTUserLinkDAL DataAccess
        {
            get
            {
                return DAL.Common.PTUserLinkDAL.Instance;
            }
        }


        /// <summary>
        /// 对用户角色关联（PTUserLink）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="pTUserLink">用户角色关联（PTUserLink）实例对象</param>
        public static void CheckValid(PTUserLink pTUserLink)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(pTUserLink.RoleId))
                throw new CustomException("“角色编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(pTUserLink.UserName))
                throw new CustomException("“用户编号”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(pTUserLink.UserName , 50))
                throw new CustomException("“用户编号”编号长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将用户角色关联（PTUserLink）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTUserLink">用户角色关联（PTUserLink）实例对象</param>
        public static int Insert(PTUserLink pTUserLink)
        {
            CheckValid(pTUserLink);
            return DataAccess.Insert(pTUserLink);
        }


        /// <summary>
        /// 将用户角色关联（PTUserLink）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="pTUserLink">用户角色关联（PTUserLink）实例对象</param>
        public static int Update(PTUserLink pTUserLink)
        {
            CheckValid(pTUserLink);
            return DataAccess.Update(pTUserLink);
        }


        /// <summary>
        /// 根据用户角色关联（PTUserLink）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">用户角色关联（PTUserLink）的主键“编号（Id）”</param>
        public static int Delete(int id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据用户角色关联（PTUserLink）的主键“编号（Id）”从数据库中获取用户角色关联（PTUserLink）的实例。
        /// 成功从数据库中取得记录返回新用户角色关联（PTUserLink）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">用户角色关联（PTUserLink）的主键“编号（Id）”</param>
        public static PTUserLink GetDataById(int id)
        {
            return DataAccess.GetDataById(id);
        }


        /// <summary>
        /// 根据用户角色关联（PTUserLink）的主键“编号（Id）”从数据库中获取用户角色关联（PTUserLink）的实例。
        /// 成功从数据库中取得记录返回新用户角色关联（PTUserLink）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">用户角色关联（PTUserLink）的主键“编号（Id）”</param>
        public static PTUserLink GetDataById(string id)
        {
            if(!DataValid.IsInt(id))
                throw new CustomException("系统传入参数类型错误，请您通过系统提供的按钮或链接，来访问相关功能模块。", ExceptionType.Error,
                    "详细信息：通常造成该错误的原因为，您尝试通过直接输入地址来访问系统的相关功能模块而造成。请您单击“确定”按钮返回上一页面，如多次重试后仍出现此错误，请您与系统管理员联系。");

            return DataAccess.GetDataById(Convert.ToInt32(id));
        }


       


        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        





    }
}
