using System;
using System.Text;
using System.Data;
using System.Collections.Generic;
using OnlineApp.COL;
using OnlineApp.DAL;
using OnlineApp.SFL;

namespace OnlineApp.BLL
{
    /// <summary>
    /// 对象名称：提示消息类型（码表）业务逻辑类（业务逻辑层）
    /// 对象说明：用于定义和储存提示消息类别，单层码表
    /// 调用说明：本类提供了各种业务逻辑方法，供用户界面层或其它业务逻辑层中的类进行调用。
    /// 作者姓名：chr
    /// 编写日期：2013-11-26 11:32:54
    /// </summary>
    public class PTNoticeTypeBLL
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
        internal static DAL.Common.PTNoticeTypeDAL DataAccess
        {
            get
            {
                return DAL.Common.PTNoticeTypeDAL.Instance;
            }
        }


        /// <summary>
        /// 对提示消息类型（码表）（NoticeType）实例对象，进行数据有效性检查。
        /// </summary>
        /// <param name="noticeType">提示消息类型（码表）（NoticeType）实例对象</param>
        public static void CheckValid(PTNoticeType noticeType)
        {
            #region 检查各属性是否符合空值约束
            if (DataValid.IsNull(noticeType.Id))
                throw new CustomException("“编号”不能为空，请您确认输入是否正确。");

            if (DataValid.IsNull(noticeType.Name))
                throw new CustomException("“名称”不能为空，请您确认输入是否正确。");

            #endregion

            #region 检查字符串是否超出规定长度
            if (DataValid.IsOutLength(noticeType.Id , 50))
                throw new CustomException("“编号”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(noticeType.Name , 50))
                throw new CustomException("“名称”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            if (DataValid.IsOutLength(noticeType.Description , 50))
                throw new CustomException("“描述”长度不能超过 50 个汉字或字符，请您确认输入是否正确。");

            #endregion
        }


        /// <summary>
        /// 将提示消息类型（码表）（NoticeType）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="noticeType">提示消息类型（码表）（NoticeType）实例对象</param>
        public static int Insert(PTNoticeType noticeType)
        {
            CheckValid(noticeType);
            return DataAccess.Insert(noticeType);
        }


        /// <summary>
        /// 将提示消息类型（码表）（NoticeType）数据，根据主键“编号（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="noticeType">提示消息类型（码表）（NoticeType）实例对象</param>
        public static int Update(PTNoticeType noticeType)
        {
            CheckValid(noticeType);
            return DataAccess.Update(noticeType);
        }


        /// <summary>
        /// 根据提示消息类型（码表）（NoticeType）的主键“编号（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">提示消息类型（码表）（NoticeType）的主键“编号（Id）”</param>
        public static int Delete(string id)
        {
            return DataAccess.Delete(id);
        }


        /// <summary>
        /// 根据提示消息类型（码表）（NoticeType）的主键“编号（Id）”从数据库中获取提示消息类型（码表）（NoticeType）的实例。
        /// 成功从数据库中取得记录返回新提示消息类型（码表）（NoticeType）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">提示消息类型（码表）（NoticeType）的主键“编号（Id）”</param>
        public static PTNoticeType GetDataById(string id)
        {
            return DataAccess.GetDataById(id);
        }


      

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该业务逻辑类的功能，而定义的变量、属性及相关业务逻辑处理方法。  
        //  注意：用户界面层应当只需调用本层便可完成所有操作，本类对关联的数据访问类调用，应当只通过类中的DataAccess属性实现。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍

        /// <summary>
        /// 获取所有内容信息
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllList()
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT [Id],[Name],[Description] FROM [PT_NoticeType] ";

            return BLL.CommonToolsBLL.GetAllListByParams(parameter);
        }






    }
}
