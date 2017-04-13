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
    /// 编写日期：2017/4/13 23:20:39
    /// </summary>
    [Serializable]
    public class YWExamQuestion
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]</summary>
        private int? id;
        /// <summary>[变量]</summary>
        private int? examId;
        /// <summary>[变量]</summary>
        private int? type;
        /// <summary>[变量]</summary>
        private string pic;
        /// <summary>[变量]</summary>
        private double? score;
        /// <summary>[变量]</summary>
        private string chance1;
        /// <summary>[变量]</summary>
        private string chance2;
        /// <summary>[变量]</summary>
        private string chance3;
        /// <summary>[变量]</summary>
        private string chance4;
        /// <summary>[变量]</summary>
        private string chance5;
        /// <summary>[变量]</summary>
        private string content;
        /// <summary>[变量]</summary>
        private string chanceAnswer;
        /// <summary>[变量]</summary>
        private string objectAnswer;
        /// <summary>[变量]</summary>
        private string objectPic;
        /// <summary>[变量]</summary>
        private DateTime? createTime;
        /// <summary>[变量]</summary>
        private DateTime? updateTime;
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
        public int? ExamId
        {
            get { return examId; }
            set { examId = value; }
        }
        /// <summary>[属性]</summary>
        public int? Type
        {
            get { return type; }
            set { type = value; }
        }
        /// <summary>[属性]</summary>
        public string Pic
        {
            get { return pic; }
            set { pic = value; }
        }
        /// <summary>[属性]</summary>
        public double? Score
        {
            get { return score; }
            set { score = value; }
        }
        /// <summary>[属性]</summary>
        public string Chance1
        {
            get { return chance1; }
            set { chance1 = value; }
        }
        /// <summary>[属性]</summary>
        public string Chance2
        {
            get { return chance2; }
            set { chance2 = value; }
        }
        /// <summary>[属性]</summary>
        public string Chance3
        {
            get { return chance3; }
            set { chance3 = value; }
        }
        /// <summary>[属性]</summary>
        public string Chance4
        {
            get { return chance4; }
            set { chance4 = value; }
        }
        /// <summary>[属性]</summary>
        public string Chance5
        {
            get { return chance5; }
            set { chance5 = value; }
        }
        /// <summary>[属性]</summary>
        public string Content
        {
            get { return content; }
            set { content = value; }
        }
        /// <summary>[属性]</summary>
        public string ChanceAnswer
        {
            get { return chanceAnswer; }
            set { chanceAnswer = value; }
        }
        /// <summary>[属性]</summary>
        public string ObjectAnswer
        {
            get { return objectAnswer; }
            set { objectAnswer = value; }
        }
        /// <summary>[属性]</summary>
        public string ObjectPic
        {
            get { return objectPic; }
            set { objectPic = value; }
        }
        /// <summary>[属性]</summary>
        public DateTime? CreateTime
        {
            get { return createTime; }
            set { createTime = value; }
        }
        /// <summary>[属性]</summary>
        public DateTime? UpdateTime
        {
            get { return updateTime; }
            set { updateTime = value; }
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
