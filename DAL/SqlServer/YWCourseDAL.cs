using System;
using System.Text;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Collections.Generic;
using Chr.OnlineApp.COL;
using Chr.OnlineApp.SFL;

namespace Chr.OnlineApp.DAL.SqlServer
{
    /// <summary>
    /// 对象名称：基础对象名称SQL Server数据访问子类（数据访问层）
    /// 对象说明：提供“基础对象名称类（业务逻辑层）”针对SQL Server的“增删改查”等各种数据访问方法，继承通用数据访问父类。
    /// 调用说明：通常不需要直接实例化本类，而使用“基础对象名称类（业务逻辑层）”中的DataAccess属性来调用本类所实现的方法。
    /// 作者姓名：陈焕然
    /// 编写日期：2017/4/13 23:47:11
    /// </summary>
    public class YWCourseDAL : DAL.Common.YWCourseDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将基础对象名称（YWCourse）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCourse">基础对象名称（YWCourse）实例对象</param>
        public override int Insert(YWCourse yWCourse)
        {
            string sqlText = "INSERT INTO [YW_Course]"
                           + "([courseName],[linkBook],[teacherName],[teacherId],[content],[title],[span],[show],[courseNum],[pic],[createTime],[updateTime],[updateUserName],"
                           + "[updateUserId],[status],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5])"
                           + "VALUES"
                           + "(@courseName,@linkBook,@teacherName,@teacherId,@content,@title,@span,@show,@courseNum,@pic,@createTime,@updateTime,@updateUserName,"
                           + "@updateUserId,@status,@Alternate1,@Alternate2,@Alternate3,@Alternate4,@Alternate5)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@courseName"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.CourseName     },
                new SqlParameter("@linkBook"       , SqlDbType.NVarChar , 50 ){ Value = yWCourse.LinkBook       },
                new SqlParameter("@teacherName"    , SqlDbType.NVarChar , 20 ){ Value = yWCourse.TeacherName    },
                new SqlParameter("@teacherId"      , SqlDbType.Int      , 4  ){ Value = yWCourse.TeacherId      },
                new SqlParameter("@content"        , SqlDbType.NVarChar , 500){ Value = yWCourse.Content        },
                new SqlParameter("@title"          , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Title          },
                new SqlParameter("@span"           , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Span           },
                new SqlParameter("@show"           , SqlDbType.NVarChar , 10 ){ Value = yWCourse.Show           },
                new SqlParameter("@courseNum"      , SqlDbType.Int      , 4  ){ Value = yWCourse.CourseNum      },
                new SqlParameter("@pic"            , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Pic            },
                new SqlParameter("@createTime"     , SqlDbType.DateTime , 8  ){ Value = yWCourse.CreateTime     },
                new SqlParameter("@updateTime"     , SqlDbType.DateTime , 8  ){ Value = yWCourse.UpdateTime     },
                new SqlParameter("@updateUserName" , SqlDbType.NVarChar , 20 ){ Value = yWCourse.UpdateUserName },
                new SqlParameter("@updateUserId"   , SqlDbType.Int      , 4  ){ Value = yWCourse.UpdateUserId   },
                new SqlParameter("@status"         , SqlDbType.Int      , 4  ){ Value = yWCourse.Status         },
                new SqlParameter("@Alternate1"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate1     },
                new SqlParameter("@Alternate2"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate2     },
                new SqlParameter("@Alternate3"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate3     },
                new SqlParameter("@Alternate4"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate4     },
                new SqlParameter("@Alternate5"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate5     }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将基础对象名称（YWCourse）数据，根据主键“（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCourse">基础对象名称（YWCourse）实例对象</param>
        public override int Update(YWCourse yWCourse)
        {
            string sqlText = "UPDATE [YW_Course] SET "
                           + "[courseName]=@courseName,[linkBook]=@linkBook,[teacherName]=@teacherName,[teacherId]=@teacherId,[content]=@content,[title]=@title,"
                           + "[span]=@span,[show]=@show,[courseNum]=@courseNum,[pic]=@pic,[createTime]=@createTime,[updateTime]=@updateTime,[updateUserName]=@updateUserName,"
                           + "[updateUserId]=@updateUserId,[status]=@status,[Alternate1]=@Alternate1,[Alternate2]=@Alternate2,[Alternate3]=@Alternate3,[Alternate4]=@Alternate4,"
                           + "[Alternate5]=@Alternate5 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@courseName"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.CourseName     },
                new SqlParameter("@linkBook"       , SqlDbType.NVarChar , 50 ){ Value = yWCourse.LinkBook       },
                new SqlParameter("@teacherName"    , SqlDbType.NVarChar , 20 ){ Value = yWCourse.TeacherName    },
                new SqlParameter("@teacherId"      , SqlDbType.Int      , 4  ){ Value = yWCourse.TeacherId      },
                new SqlParameter("@content"        , SqlDbType.NVarChar , 500){ Value = yWCourse.Content        },
                new SqlParameter("@title"          , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Title          },
                new SqlParameter("@span"           , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Span           },
                new SqlParameter("@show"           , SqlDbType.NVarChar , 10 ){ Value = yWCourse.Show           },
                new SqlParameter("@courseNum"      , SqlDbType.Int      , 4  ){ Value = yWCourse.CourseNum      },
                new SqlParameter("@pic"            , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Pic            },
                new SqlParameter("@createTime"     , SqlDbType.DateTime , 8  ){ Value = yWCourse.CreateTime     },
                new SqlParameter("@updateTime"     , SqlDbType.DateTime , 8  ){ Value = yWCourse.UpdateTime     },
                new SqlParameter("@updateUserName" , SqlDbType.NVarChar , 20 ){ Value = yWCourse.UpdateUserName },
                new SqlParameter("@updateUserId"   , SqlDbType.Int      , 4  ){ Value = yWCourse.UpdateUserId   },
                new SqlParameter("@status"         , SqlDbType.Int      , 4  ){ Value = yWCourse.Status         },
                new SqlParameter("@Alternate1"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate1     },
                new SqlParameter("@Alternate2"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate2     },
                new SqlParameter("@Alternate3"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate3     },
                new SqlParameter("@Alternate4"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate4     },
                new SqlParameter("@Alternate5"     , SqlDbType.NVarChar , 50 ){ Value = yWCourse.Alternate5     },
                new SqlParameter("@Id"             , SqlDbType.Int      , 4  ){ Value = yWCourse.Id             }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据基础对象名称（YWCourse）的主键“（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础对象名称（YWCourse）的主键“（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YW_Course] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据基础对象名称（YWCourse）的主键“（Id）”从数据库中获取基础对象名称（YWCourse）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWCourse）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWCourse）的主键“（Id）”</param>
        public override YWCourse GetDataById(int id)
        {
            YWCourse yWCourse = null;
            string sqlText = "SELECT [Id],[courseName],[linkBook],[teacherName],[teacherId],[content],[title],[span],[show],[courseNum],[pic],[createTime],[updateTime],"
                           + "[updateUserName],[updateUserId],[status],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [YW_Course] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWCourse = new YWCourse();
                ReadYWCourseAllData(sqlDataReader, yWCourse);
            }
            sqlDataReader.Close();
            return yWCourse;
        }


        /// <summary>
        /// 从数据库中读取并返回所有基础对象名称（YWCourse）List列表。
        /// </summary>
        public override List<YWCourse> GetAllList()
        {
            string sqlText = "SELECT [Id],[courseName],[linkBook],[teacherName],[teacherId],[content],[title],[span],[show],[courseNum],[pic],[createTime],[updateTime],"
                           + "[updateUserName],[updateUserId],[status],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [YW_Course]";
            List<YWCourse> list = new List<YWCourse>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                YWCourse yWCourse = new YWCourse();
                ReadYWCourseAllData(sqlDataReader, yWCourse);
                list.Add(yWCourse);
            }
            sqlDataReader.Close();
            return list;
        }

         

        #endregion EasyCode所生成的默认代码

        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  说明：以下区域的代码为设计开发人员所编写，主要为扩展该数据访问类的功能，而定义的变量、属性及相关数据访问方法。  
        //  注意：为了保证该项目的多数据库支持与扩展性，请先在本类的父类中对相关抽象方法进行定义，再在本类中进行具体实现。
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍










    }
}
