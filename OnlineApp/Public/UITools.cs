using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Web;
using OnlineApp.BLL;
using OnlineApp.COL;
using System.Data.SqlClient;
using System.Data;
using System.Web.Script.Serialization;


namespace OnlineApp.Public
{
    public class UITools
    {
        /// <summary>
        /// 公共方法：验证登陆账号和密码
        /// </summary>
        public static bool UserCheck(string strUserName, string strPassword)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT * FROM [PT_USER]  WHERE [UserName]=@UserName AND [Password]=@Password";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = strUserName},
                new SqlParameter("@Password"   , SqlDbType.NVarChar , 50 ){ Value = strPassword},
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count != 0)
            { 
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
        /// <summary>
        /// 公共方法：判断当前用户是否是超级管理员（用来做针对管理员的特殊处理）
        /// </summary>
        public static bool IsAdmin()
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = " SELECT * FROM [PT_USER] WHERE [UserName]=@UserName AND [RoleId]=@RoleId";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = HttpContext.Current.User.Identity.Name},
                new SqlParameter("@RoleId"   , SqlDbType.NVarChar , 50 ){ Value = "1"},
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        /// <summary>
        /// 内部方法：获取当前页面所在的路径名
        /// </summary>
        public static string GetCurrentPathName()
        {
            string requestPath = System.Web.HttpContext.Current.Request.PhysicalPath;
            System.IO.DirectoryInfo moduleDir = new System.IO.DirectoryInfo(requestPath);
            string moduleRunPath = moduleDir.Parent.Name;
            return moduleRunPath;
        }

        /// <summary>
        /// 公共方法：获取当前用户的信息
        /// </summary>
        public static PTUsers GetCurrentUserInfo()
        {
            return BLL.PTUsersBLL.GetDataByUserName(HttpContext.Current.User.Identity.Name);
        }
        
        /// <summary>
        /// 公共方法：根据积分值返回图标HTML
        /// </summary>
        public static string GetPointHtml(string strPoint)
        {
            int iPoint = Convert.ToInt32(strPoint);
            string strPointHtml = "";
            int iHuangGuan = iPoint / 2500;
            for (int a = 0; a < iHuangGuan; a++)
            {
                strPointHtml += @"<i class=""icon-gift""> </i>";
            }
            iPoint = iPoint % 2500;
            int iZuanshi = iPoint / 500;
            for (int a = 0; a < iZuanshi; a++)
            {
                strPointHtml += @"<i class=""icon-coffee""> </i>";
            }
            iPoint = iPoint % 500;
            int iXin = iPoint / 100;
            for (int a = 0; a < iXin; a++)
            {
                strPointHtml += @"<i class=""icon-heart""> </i>";
            }
            iPoint = iPoint % 100;
            if (iPoint > 49)
            {
                strPointHtml += @"<i class=""icon-heart-empty""> </i>";
            }
            return strPointHtml;
        }
        /// <summary>
        /// 公共方法：根据功能名称判断当前用户的操作权限
        /// </summary>
        public static bool AllowCurrentUser(string strPath)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = "SELECT * FROM [PT_FUNCTION],[PT_RoleLink],[PT_UserLink] WHERE [PT_FUNCTION].[Id]=[PT_RoleLink].[FunctionId] AND [PT_RoleLink].[RoleId]=[PT_UserLink].[RoleId] AND [PT_UserLink].[UserName]=@UserName AND [PT_FUNCTION].[FunctionPath]=@FunctionPath AND [PT_FUNCTION].[StateId] > '0' ORDER BY [Id] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = HttpContext.Current.User.Identity.Name},
                new SqlParameter("@FunctionPath"   , SqlDbType.NVarChar , 50 ){ Value = strPath},
            };
            parameter.Parameters = parameters;
            DataTable dt = CommonToolsBLL.GetAllListByParams(parameter);
            if (dt.Rows.Count != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 内部方法：获取某一功能节点所有下级子功能的列表，参数为节点功能编号
        /// </summary>
        private static List<PTFunctions> GetAllSubPath(string strFunctionId)
        {
            //构建查询条件
            Parameter parameter = new Parameter();
            parameter.SqlString = ",[PT_RoleLink],[PT_UserLink] WHERE [PT_FUNCTION].[Id]=[PT_RoleLink].[FunctionId] AND [PT_RoleLink].[RoleId]=[PT_UserLink].[RoleId] AND [PT_UserLink].[UserName]=@UserName AND [PT_FUNCTION].[FatherNumber]=@FatherNumber AND [PT_FUNCTION].[StateId] > '0' ORDER BY [Id] ";
            SqlParameter[] parameters = 
            {
                new SqlParameter("@UserName"   , SqlDbType.NVarChar , 50 ){ Value = HttpContext.Current.User.Identity.Name},
                new SqlParameter("@FatherNumber"   , SqlDbType.NVarChar , 50 ){ Value = strFunctionId},
            };
            parameter.Parameters = parameters;
            //查询数据
            return null;// BLL.PTFunctionsBLL.GetListByParams(parameter);
        }
        
        /// <summary>
        /// 公共方法：获取某一功能节点及其所有下级子功能的HTML文本，参数为节点功能编号
        /// </summary>
        public static string GetAllPathHtml(string strFunctionId)
        {
            //填充列表开始之前的HTML文本
            string strMenuHtml = @""; //此处可添加ul以外的前缀内容
            //获取根节点下的所有子节点
            List<PTFunctions> pTFunctionList = GetAllSubPath(strFunctionId);
            if (pTFunctionList.Count != 0)
            {
                strMenuHtml += "<ul>";
                //遍历所有子节点，填充子项或子列表
                foreach (PTFunctions pTFunctions in pTFunctionList)
                {
                    //获取该子节点下的所有子节点
                    List<PTFunctions> subFunctionList = GetAllSubPath(pTFunctions.Id);
                    //有子列表的情况
                    if (subFunctionList.Count != 0)
                    {
                        //填充子项
                        strMenuHtml += @"<li class=""openable";
                        //遍历该子项的所有子节点，如果当前正在打开的页面在其中，则激活active open 样式。
                        foreach (PTFunctions subFunctions in subFunctionList)
                        {
                            if (subFunctions.FunctionPath == GetCurrentPathName())
                            {
                                strMenuHtml += @" active open";

                            }
                        }
                        strMenuHtml += @""" ><a href=""#""><span class=""menu-icon""><i class=""" + pTFunctions.Alternate1 + @"""></i></span><span class=""text"">" + pTFunctions.FunctionName + @"</span><span class=""badge badge-success"">" + subFunctionList.Count + @"</span><span class=""menu-hover""></span></a><ul class=""submenu"">";
                        //填充子项下面的子列表
                        foreach (PTFunctions subFunctions in subFunctionList)
                        {
                            strMenuHtml += @"<li";
                            //如果当前项是正在打开的页面，则激活active样式
                            if (subFunctions.FunctionPath == GetCurrentPathName())
                            {
                                strMenuHtml += @" class=""active"" ";
                                
                            }
                            strMenuHtml += @"><a href=""../" + subFunctions.FunctionPath + @"""><span class=""submenu-label"">" + subFunctions.FunctionName + @"</span></a></li>";
                        }
                        strMenuHtml += @"</ul>";
                    }
                    //无子列表的情况
                    else
                    {
                        strMenuHtml += @"<li";
                        if (pTFunctions.FunctionPath == GetCurrentPathName())
                        {
                            strMenuHtml += @" class=""active"" ";
                        }
                        strMenuHtml += @"><a href=""../" + pTFunctions.FunctionPath + @"""><span class=""menu-icon""><i class=""" + pTFunctions.Alternate1 + @"""></i></span><span class=""text"">" + pTFunctions.FunctionName + @"</span><span class=""menu-hover""></span></a></li>";
                    }
                }
                strMenuHtml += "</ul>";
               
            } 
            return strMenuHtml;
        }
        /// <summary>
        /// 公共方法：获取某一功能节点及其所有下级子功能的HTML文本，参数为节点功能编号(前台左侧栏菜单)
        /// </summary>
        public static string GetAllPathHtml2(string strFunctionId)
        {
            //填充列表开始之前的HTML文本
            string strMenuHtml = "";
            //获取根节点下的所有子节点
            List<PTFunctions> pTFunctionList = GetAllSubPath(strFunctionId);
            if (pTFunctionList.Count != 0)
            {

                //遍历所有子节点，填充子项或子列表
                foreach (PTFunctions pTFunctions in pTFunctionList)
                {

                    strMenuHtml += @"<a class=""list-group-item";
                    if (pTFunctions.FunctionPath == GetCurrentPathName())
                    {
                        strMenuHtml += @" active";
                    }
                    strMenuHtml += @""" href=""../" + pTFunctions.FunctionPath + @"""><span  class=""hidden-xs"">" + pTFunctions.FunctionName + @"</span></a>";

                }

            }
            return strMenuHtml;
        }
        /// <summary>
        /// 公共方法：获取某一功能节点及其所有下级子功能的HTML文本，参数为节点功能编号(前台导航)
        /// </summary>
        public static string GetAllPathHtml3(string strFunctionId)
        {
            //填充列表开始之前的HTML文本
            string strMenuHtml = "";
            //获取根节点下的所有子节点
            List<PTFunctions> pTFunctionList = GetAllSubPath(strFunctionId);
            if (pTFunctionList.Count != 0)
            {
                
                //遍历所有子节点，填充子项或子列表
                foreach (PTFunctions pTFunctions in pTFunctionList)
                {
                    strMenuHtml += @"<li class=""visible-xs-block";
                    if (pTFunctions.FunctionPath == GetCurrentPathName())
                    {
                        strMenuHtml += @" active";
                    }
                    strMenuHtml += @"""><a href=""../" + pTFunctions.FunctionPath + @"""><span>" + pTFunctions.FunctionName + @"</span></a></li>";
                    
                    
                }
                
            }
            return strMenuHtml;
        }
         
        /// <summary>
        /// 内部方法：获取某一功能编号的站点地图HTML文本
        /// </summary>
        private static string  GetAllMapHtml(string strFunctionId)
        {
            PTFunctions pTFunctions = BLL.PTFunctionsBLL.GetDataById(strFunctionId);
            if (pTFunctions.FatherNumber == "0")
            {
                return @"<li><a href=""../" + pTFunctions.FunctionPath + @"""><i class=""fa fa-home""></i> 首页</a></li>";
            }
            else
            {
                string strHref = "";
                if(pTFunctions.FunctionTypeId != "2")
                {
                    strHref = @"#";
                }
                else
                {
                    strHref = @"../" + pTFunctions.FunctionPath;
                }
                return GetAllMapHtml(pTFunctions.FatherNumber) + @"<li class=""active""><a href=""" + strHref + @""">" + pTFunctions.FunctionName + @"</a></li>";
            }
        }
        /// <summary>
        /// 公共方法：根据某一提示信息，组装一个提示框HTML
        /// </summary>
        public static string ShowMessage(string strMessage, string strType)
        {
            string strResult = @"<div class=""alert alert-" + strType + @" no-margin"">";
            strResult += "<strong>系统提示：</strong>" + strMessage + @"</div>";
            return strResult;	
        }
        /// <summary>
        /// 公共方法：list转化为jaon
        /// </summary>
        public static string ListToJson(IList objList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //JSON序列化
            return serializer.Serialize(objList);
        }
        /// <summary>
        /// 公共方法：json转化为list
        /// </summary>
        public static List<Object> JsonToList(string strJson)
        {
            if (strJson == null || strJson == "")
            {
                return new List<Object>();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<List<Object>>(strJson);
        }
        /// <summary>
        /// 公共方法：object转化为jaon
        /// </summary>
        public static string ObjectToJson(Object objList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //JSON序列化
            return serializer.Serialize(objList);
        }
        /// <summary>
        /// 公共方法：json转化为object
        /// </summary>
        public static Object JsonToObject(string strJson)
        {
            if (strJson == null || strJson == "")
            {
                return new List<Object>();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<Object>(strJson);
        }

        /// <summary>
        /// 公共方法：datatable转化为jaon
        /// </summary>
        public static string DataTableToJson(DataTable dt)
        {
            
            string strResult = "[";
            for (int i = 0; i < dt.Rows.Count; i++ )
            {
                if (i > 0)
                {
                    strResult += ",";
                }
                strResult += "{";
                for (int j = 0; j < dt.Columns.Count; j++ )
                {
                    if (j > 0)
                    {
                        strResult += ",";
                    }
                    strResult += "\"" + dt.Columns[j].ColumnName + "\":";
                    if (dt.Columns[j].DataType.IsValueType)
                    {
                        strResult += dt.Rows[i][j].ToString();
                    }
                    else
                    {
                        strResult += "\"" + dt.Rows[i][j].ToString() + "\"";
                    }
                }
                strResult += "}";
            }
            strResult += "]";
            return strResult;
        }

        /// <summary>
        /// 公共方法：根据callback处理接口返回值（JsonP/Json）
        /// </summary>
        public static void OutputJson(HttpContext context, string strCallBack, string strJson)
        {
            if (strCallBack != null && strCallBack != "")
            {
                context.Response.ContentType = "application/x-javascript";
                context.Response.Write(strCallBack + "(" + strJson + ");");
            }
            else
            {
                context.Response.ContentType = "text/plain";
                context.Response.Write(strJson);
            }
            context.Response.End();
            
        } 

        /// <summary>
        /// 公共方法：附件list转化为json
        /// </summary>
        public static string AttachmentListToJson(List<PTAttachment> yWAttachmentList)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            //JSON序列化
            return serializer.Serialize(yWAttachmentList);
        }
        /// <summary>
        /// 公共方法：附件jaon转化为list
        /// </summary>
        public static List<PTAttachment> AttachmentJsonToList(string strAttachmentJson)
        {
            if (strAttachmentJson == null || strAttachmentJson == "")
            {
                return new List<PTAttachment>();
            }
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<List<PTAttachment>>(strAttachmentJson);
        }

        /// <summary>
        /// 公共方法：上传附件，并把信息加入到json中，用于多附件上传的功能
        /// </summary>
        public static string AttachmentUploadToJson(string strAttachmentJson, string strOrderName, string strAbsolutePath, HttpFileCollection FileCollect)
        {
            List<PTAttachment> pTAttachmentlist = AttachmentJsonToList(strAttachmentJson);
            if (FileCollect.Count > 0)          //如果集合的数量大于0
            {
                for (int iFile = 0; iFile < FileCollect.Count; iFile++)
                {
                    if (FileCollect[iFile].FileName != "" && FileCollect[iFile].FileName != null)
                    {
                        HttpPostedFile FileSave = FileCollect[iFile];  //用key获取单个文件对象HttpPostedFile
                        string strFileName = FileSave.FileName.Substring(0, FileSave.FileName.LastIndexOf("."));
                        string strFileType = FileSave.FileName.Substring(FileSave.FileName.LastIndexOf("."));
                        string AbsolutePath = "";
                        if (strOrderName != "" && strOrderName != null)
                        {
                            AbsolutePath += strOrderName;
                        }
                        else
                        {
                            AbsolutePath += strFileName;
                        }
                        AbsolutePath += DateTime.Now.ToString("_yy-MM-dd-hh-mm-ss") + strFileType;
                        FileSave.SaveAs(strAbsolutePath + @"/" + AbsolutePath);              //将上传的东西保存
                        PTAttachment pTAttachment = new PTAttachment();
                        pTAttachment.FileName = AbsolutePath;
                        pTAttachment.UploadDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                        pTAttachment.UserName = GetCurrentUserInfo().UserName;
                        pTAttachment.Notes = strAbsolutePath + @"/" + AbsolutePath;
                        PTAttachmentBLL.Insert(pTAttachment);
                        pTAttachmentlist.Add(pTAttachment);
                    }
                }
            }
            return AttachmentListToJson(pTAttachmentlist);
        }

        /// <summary>
        /// 公共方法：上传附件，并放入指定名称的指定位置，已存在的话就替换，用于头像等单文件上传
        /// </summary>
        public static string AttachmentUpload(string strOrderName, string strAbsolutePath, HttpFileCollection FileCollect)
        {
            string strUploadFileName = GetCurrentUserInfo().Alternate2;
            if (FileCollect.Count > 0)          //如果集合的数量大于0
            {
                
                if (FileCollect[0].FileName != "" && FileCollect[0].FileName != null)
                {
                    HttpPostedFile FileSave = FileCollect[0];  //用key获取单个文件对象HttpPostedFile
                    string strFileName = FileSave.FileName.Substring(0, FileSave.FileName.LastIndexOf("."));
                    string strFileType = FileSave.FileName.Substring(FileSave.FileName.LastIndexOf("."));
                    string AbsolutePath = "";
                    if (strOrderName != "" && strOrderName != null)
                    {
                        AbsolutePath += strOrderName;
                    }
                    else
                    {
                        AbsolutePath += strFileName;
                    }
                    AbsolutePath += strFileType;
                    FileSave.SaveAs(strAbsolutePath + @"/" + AbsolutePath);              //将上传的东西保存
                    PTAttachment pTAttachment = new PTAttachment();
                    pTAttachment.FileName = AbsolutePath;
                    pTAttachment.UploadDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                    pTAttachment.UserName = GetCurrentUserInfo().UserName;
                    pTAttachment.FileSize = FileSave.ContentLength;
                    pTAttachment.Notes = strAbsolutePath + @"/" + AbsolutePath;
                    PTAttachmentBLL.Insert(pTAttachment);
                    strUploadFileName = AbsolutePath;
                }
                
            }
            return strUploadFileName;
            
        }

        
    }
}