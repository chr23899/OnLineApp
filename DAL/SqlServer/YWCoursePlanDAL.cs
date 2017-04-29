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
    /// 编写日期：2017/4/13 23:51:40
    /// </summary>
    public class YWCoursePlanDAL : DAL.Common.YWCoursePlanDAL
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，实现了父类中定义的抽象方法。请不要直接修改该区域中的任何代码，   
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>
        /// 将基础对象名称（YWCoursePlan）数据，采用INSERT操作插入到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCoursePlan">基础对象名称（YWCoursePlan）实例对象</param>
        public override int Insert(YWCoursePlan yWCoursePlan)
        {
            string sqlText = "INSERT INTO [YW_Course_Plan]"
                           + "([courseId],[courseName],[name],[content],[type],[pic],[video],[study],[test],[planTime],[startTime],[finishTime],[createTime],[updateTime],[status],"
                           + "[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5])"
                           + "VALUES"
                           + "(@courseId,@courseName,@name,@content,@type,@pic,@video,@study,@test,@planTime,@startTime,@finishTime,@createTime,@updateTime,@status,"
                           + "@Alternate1,@Alternate2,@Alternate3,@Alternate4,@Alternate5)";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@courseId"   , SqlDbType.Int      , 4  ){ Value = yWCoursePlan.CourseId   },
                new SqlParameter("@courseName" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.CourseName },
                new SqlParameter("@name"       , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Name       },
                new SqlParameter("@content"    , SqlDbType.NVarChar , 500){ Value = yWCoursePlan.Content    },
                new SqlParameter("@type"       , SqlDbType.NVarChar , 10 ){ Value = yWCoursePlan.Type       },
                new SqlParameter("@pic"        , SqlDbType.NVarChar , 500){ Value = yWCoursePlan.Pic        },
                new SqlParameter("@video"      , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Video      },
                new SqlParameter("@study"      , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Study      },
                new SqlParameter("@test"       , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Test       },
                new SqlParameter("@planTime"   , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.PlanTime   },
                new SqlParameter("@startTime"  , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.StartTime  },
                new SqlParameter("@finishTime" , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.FinishTime },
                new SqlParameter("@createTime" , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.CreateTime },
                new SqlParameter("@updateTime" , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.UpdateTime },
                new SqlParameter("@status"     , SqlDbType.Int      , 4  ){ Value = yWCoursePlan.Status     },
                new SqlParameter("@Alternate1" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate1 },
                new SqlParameter("@Alternate2" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate2 },
                new SqlParameter("@Alternate3" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate3 },
                new SqlParameter("@Alternate4" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate4 },
                new SqlParameter("@Alternate5" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate5 }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 将基础对象名称（YWCoursePlan）数据，根据主键“（Id）”采用UPDATE操作更新到数据库中，并返回受影响的行数。
        /// </summary>
        /// <param name="yWCoursePlan">基础对象名称（YWCoursePlan）实例对象</param>
        public override int Update(YWCoursePlan yWCoursePlan)
        {
            string sqlText = "UPDATE [YW_Course_Plan] SET "
                           + "[courseId]=@courseId,[courseName]=@courseName,[name]=@name,[content]=@content,[type]=@type,[pic]=@pic,[video]=@video,[study]=@study,"
                           + "[test]=@test,[planTime]=@planTime,[startTime]=@startTime,[finishTime]=@finishTime,[createTime]=@createTime,[updateTime]=@updateTime,"
                           + "[status]=@status,[Alternate1]=@Alternate1,[Alternate2]=@Alternate2,[Alternate3]=@Alternate3,[Alternate4]=@Alternate4,[Alternate5]=@Alternate5 "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@courseId"   , SqlDbType.Int      , 4  ){ Value = yWCoursePlan.CourseId   },
                new SqlParameter("@courseName" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.CourseName },
                new SqlParameter("@name"       , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Name       },
                new SqlParameter("@content"    , SqlDbType.NVarChar , 500){ Value = yWCoursePlan.Content    },
                new SqlParameter("@type"       , SqlDbType.NVarChar , 10 ){ Value = yWCoursePlan.Type       },
                new SqlParameter("@pic"        , SqlDbType.NVarChar , 500){ Value = yWCoursePlan.Pic        },
                new SqlParameter("@video"      , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Video      },
                new SqlParameter("@study"      , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Study      },
                new SqlParameter("@test"       , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Test       },
                new SqlParameter("@planTime"   , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.PlanTime   },
                new SqlParameter("@startTime"  , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.StartTime  },
                new SqlParameter("@finishTime" , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.FinishTime },
                new SqlParameter("@createTime" , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.CreateTime },
                new SqlParameter("@updateTime" , SqlDbType.DateTime , 8  ){ Value = yWCoursePlan.UpdateTime },
                new SqlParameter("@status"     , SqlDbType.Int      , 4  ){ Value = yWCoursePlan.Status     },
                new SqlParameter("@Alternate1" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate1 },
                new SqlParameter("@Alternate2" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate2 },
                new SqlParameter("@Alternate3" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate3 },
                new SqlParameter("@Alternate4" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate4 },
                new SqlParameter("@Alternate5" , SqlDbType.NVarChar , 50 ){ Value = yWCoursePlan.Alternate5 },
                new SqlParameter("@Id"         , SqlDbType.Int      , 4  ){ Value = yWCoursePlan.Id         }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }




        /// <summary>
        /// 根据基础对象名称（YWCoursePlan）的主键“（Id）”采用DELETE操作从数据库中删除相关记录，并返回受影响的行数。
        /// </summary>
        /// <param name="id">基础对象名称（YWCoursePlan）的主键“（Id）”</param>
        public override int Delete(int id)
        {
            string sqlText = "DELETE FROM [YW_Course_Plan] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };
            return SFL.SqlHelper.ExecuteNonQuery(sqlText, parameters);
        }


        /// <summary>
        /// 根据基础对象名称（YWCoursePlan）的主键“（Id）”从数据库中获取基础对象名称（YWCoursePlan）的实例。
        /// 成功从数据库中取得记录返回新基础对象名称（YWCoursePlan）的实例“，没有取到记录返回null值。
        /// </summary>
        /// <param name="id">基础对象名称（YWCoursePlan）的主键“（Id）”</param>
        public override YWCoursePlan GetDataById(int id)
        {
            YWCoursePlan yWCoursePlan = null;
            string sqlText = "SELECT [Id],[courseId],[courseName],[name],[content],[type],[pic],[video],[study],[test],[planTime],[startTime],[finishTime],[createTime],[updateTime],"
                           + "[status],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [YW_Course_Plan] "
                           + "WHERE [Id]=@Id";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@Id" , SqlDbType.Int , 4){ Value = id }
            };

            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, parameters);
            if (sqlDataReader.Read())
            {
                yWCoursePlan = new YWCoursePlan();
                ReadYWCoursePlanAllData(sqlDataReader, yWCoursePlan);
            }
            sqlDataReader.Close();
            return yWCoursePlan;
        }


        /// <summary>
        /// 从数据库中读取并返回所有基础对象名称（YWCoursePlan）List列表。
        /// </summary>
        public override List<YWCoursePlan> GetAllList()
        {
            string sqlText = "SELECT [Id],[courseId],[courseName],[name],[content],[type],[pic],[video],[study],[test],[planTime],[startTime],[finishTime],[createTime],[updateTime],"
                           + "[status],[Alternate1],[Alternate2],[Alternate3],[Alternate4],[Alternate5] "
                           + "FROM [YW_Course_Plan]";
            List<YWCoursePlan> list = new List<YWCoursePlan>();
            SqlDataReader sqlDataReader = SFL.SqlHelper.ExecuteReader(sqlText, null);
            while (sqlDataReader.Read())
            {
                YWCoursePlan yWCoursePlan = new YWCoursePlan();
                ReadYWCoursePlanAllData(sqlDataReader, yWCoursePlan);
                list.Add(yWCoursePlan);
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
