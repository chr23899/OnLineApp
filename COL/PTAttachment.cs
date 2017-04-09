using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace OnlineApp.COL
{
    /// <summary>
    /// 对象名称：附件信息数据实体类（数据实体层）
    /// 对象说明：该类作为数据载体，供业务逻辑层、数据访问层调用。
    /// 作者姓名：chr
    /// 编写日期：2014-1-28 10:09:09
    /// </summary>
    [Serializable]
    public class PTAttachment
    {
        #region EasyCode所生成的默认代码
        //﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉﹉
        //  此区域的代码为EasyCode所自动生成，主要用于定义该类的变量属性。请不要直接修改该区域中的任何代码，  
        //  或在该区域中添加任何自定义代码，当该类发生变更时，您可以随时使用EasyCode重新生成覆盖其中的代码。  
        //﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍﹍


        /// <summary>[变量]编号</summary>
        private int? id;
        /// <summary>[变量]文件名</summary>
        private string fileName;
        /// <summary>[变量]文件大小</summary>
        private int? fileSize;
        /// <summary>[变量]上传日期</summary>
        private string uploadDate;
        /// <summary>[变量]功能</summary>
        private string functionName;
        /// <summary>[变量]上传者</summary>
        private string userName;
        /// <summary>[变量]备注</summary>
        private string notes;


        /// <summary>[属性]编号</summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
        /// <summary>[属性]文件名</summary>
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        /// <summary>[属性]文件大小</summary>
        public int? FileSize
        {
            get { return fileSize; }
            set { fileSize = value; }
        }
        /// <summary>[属性]上传日期</summary>
        public string UploadDate
        {
            get { return uploadDate; }
            set { uploadDate = value; }
        }
        /// <summary>[属性]功能</summary>
        public string FunctionName
        {
            get { return functionName; }
            set { functionName = value; }
        }
        /// <summary>[属性]上传者</summary>
        public string UserName
        {
            get { return userName; }
            set { userName = value; }
        }
        /// <summary>[属性]备注</summary>
        public string Notes
        {
            get { return notes; }
            set { notes = value; }
        }

        /// <summary>已重写的ToString方法，当该类作为其它类的一个属性时，在数据控件中可以直接绑定并显示其有意义的名称。</summary>
        public override string ToString()
        {
            return FileName;
        }

        #endregion EasyCode所生成的默认代码
    }
}
