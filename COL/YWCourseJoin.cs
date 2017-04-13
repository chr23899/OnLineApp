using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace Chr.OnlineApp.COL
{
    /// <summary>
    /// 对象名称：基础对象名称数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：陈焕然
    /// 编写日期：2017/4/13 23:23:42
    /// </summary>
    [Serializable]
    public class YWCourseJoin
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]</summary>
        private int? id;
        /// <summary>[变量]</summary>
        private int? courseId;
        /// <summary>[变量]</summary>
        private string courseName;
        /// <summary>[变量]</summary>
        private int? planId;
        /// <summary>[变量]</summary>
        private int? status;
        /// <summary>[变量]</summary>
        private string teacherName;
        /// <summary>[变量]</summary>
        private int? teacherId;
        /// <summary>[变量]</summary>
        private string studentName;
        /// <summary>[变量]</summary>
        private int? studentId;
        /// <summary>[变量]</summary>
        private DateTime? lastTime;
        /// <summary>[变量]</summary>
        private string alternate1;
        /// <summary>[变量]</summary>
        private string alternate2;
        /// <summary>[变量]</summary>
        private string alternate3;
        /// <summary>[变量]</summary>
        private string alternate4;
        /// <summary>[变量]</summary>
        private string alternate5;


        /// <summary>[属性]</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]</summary>
        public int? CourseId
        {
            get { return courseId; }
            set { courseId = value; }
        }
        /// <summary>[属性]</summary>
        public string CourseName
        {
            get { return courseName; }
            set { courseName = value; }
        }
        /// <summary>[属性]</summary>
        public int? PlanId
        {
            get { return planId; }
            set { planId = value; }
        }
        /// <summary>[属性]</summary>
        public int? Status
        {
            get { return status; }
            set { status = value; }
        }
        /// <summary>[属性]</summary>
        public string TeacherName
        {
            get { return teacherName; }
            set { teacherName = value; }
        }
        /// <summary>[属性]</summary>
        public int? TeacherId
        {
            get { return teacherId; }
            set { teacherId = value; }
        }
        /// <summary>[属性]</summary>
        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }
        /// <summary>[属性]</summary>
        public int? StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }
        /// <summary>[属性]</summary>
        public DateTime? LastTime
        {
            get { return lastTime; }
            set { lastTime = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate1
        {
            get { return alternate1; }
            set { alternate1 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate2
        {
            get { return alternate2; }
            set { alternate2 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate3
        {
            get { return alternate3; }
            set { alternate3 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate4
        {
            get { return alternate4; }
            set { alternate4 = value; }
        }
        /// <summary>[属性]</summary>
        public string Alternate5
        {
            get { return alternate5; }
            set { alternate5 = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
