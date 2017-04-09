using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：出库数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：牛大宝
    /// 编写日期：2014-11-7 18:00:35
    /// </summary>
    [Serializable]
    public class YWOutStore
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]项目</summary>
        private int? material;
        /// <summary>[变量]出库数量</summary>
        private double? outQuantity;
        /// <summary>[变量]出库单位</summary>
        private string outUnit;
        /// <summary>[变量]出库时间</summary>
        private string outTime;
        /// <summary>[变量]确认人</summary>
        private string confirmUser;
        /// <summary>[变量]确认单位</summary>
        private int? confirmOrg;
        /// <summary>[变量]领用人</summary>
        private string takeUser;
        /// <summary>[变量]领用时间</summary>
        private string takeTime;
        /// <summary>[变量]领用单位</summary>
        private int? takeOrg;
        /// <summary>[变量]所属餐厅</summary>
        private int? org;
        /// <summary>[变量]备注</summary>
        private string notes;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]项目</summary>
        public int? Material
        {
            get { return material; }
            set { material = value; }
        }
        /// <summary>[属性]出库数量</summary>
        public double? OutQuantity
        {
            get { return outQuantity; }
            set { outQuantity = value; }
        }
        /// <summary>[属性]出库单位</summary>
        public string OutUnit
        {
            get { return outUnit; }
            set { outUnit = value; }
        }
        /// <summary>[属性]出库时间</summary>
        public string OutTime
        {
            get { return outTime; }
            set { outTime = value; }
        }
        /// <summary>[属性]确认人</summary>
        public string ConfirmUser
        {
            get { return confirmUser; }
            set { confirmUser = value; }
        }
        /// <summary>[属性]确认单位</summary>
        public int? ConfirmOrg
        {
            get { return confirmOrg; }
            set { confirmOrg = value; }
        }
        /// <summary>[属性]领用人</summary>
        public string TakeUser
        {
            get { return takeUser; }
            set { takeUser = value; }
        }
        /// <summary>[属性]领用时间</summary>
        public string TakeTime
        {
            get { return takeTime; }
            set { takeTime = value; }
        }
        /// <summary>[属性]领用单位</summary>
        public int? TakeOrg
        {
            get { return takeOrg; }
            set { takeOrg = value; }
        }
        /// <summary>[属性]所属餐厅</summary>
        public int? Org
        {
            get { return org; }
            set { org = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        #endregion EasyCode所生成的默认代码
    }
}
