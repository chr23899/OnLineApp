using System;
using System.Collections.Generic;
using System.Text;
using System.Web;

namespace Chr.OnlineApp.BLL
{
    public class Export
    {
        /// <summary> 
        /// 将DataTable数据导出到EXCEL，调用该方法后自动返回可下载的文件流 
        /// </summary> 
        /// <param name="dtData">要导出的数据源</param> 
        public static void DataTable1Excel(System.Data.DataTable dtData)
        {
            System.Web.UI.WebControls.GridView gvExport = null;
            // 当前对话 
            System.Web.HttpContext curContext = System.Web.HttpContext.Current;
            // IO用于导出并返回excel文件 
            System.IO.StringWriter strWriter = null;
            System.Web.UI.HtmlTextWriter htmlWriter = null;

            if (dtData != null)
            {
                // 设置编码和附件格式 
                curContext.Response.ContentType = "application/vnd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.GetEncoding("gb2312");
                curContext.Response.Charset = "utf-8";

                // 导出excel文件 
                strWriter = new System.IO.StringWriter();
                htmlWriter = new System.Web.UI.HtmlTextWriter(strWriter);
                // 为了解决gvData中可能进行了分页的情况，需要重新定义一个无分页的GridView 
                gvExport = new System.Web.UI.WebControls.GridView();
                gvExport.DataSource = dtData.DefaultView;
                gvExport.AllowPaging = false;
                gvExport.DataBind();

                // 返回客户端 
                gvExport.RenderControl(htmlWriter);
                curContext.Response.Write("<meta http-equiv=\"Content-Type\" content=\"text/html; charset=gb2312\" />" + strWriter.ToString());
                curContext.Response.End();
            }
        }




        /// <summary> 
        /// 直接输出Excel 
        /// </summary> 
        /// <param name="dtData"></param> 
        public static void DataTable2Excel(System.Data.DataTable dtData)
        {
            System.Web.UI.WebControls.DataGrid dgExport = null;
            // 当前对话 
            System.Web.HttpContext curContext = System.Web.HttpContext.Current;
            // IO用于导出并返回excel文件 
            System.IO.StringWriter strWriter = null;
            System.Web.UI.HtmlTextWriter htmlWriter = null;

            if (dtData != null)
            {
                // 设置编码和附件格式 
                curContext.Response.ContentType = "application/vnd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.UTF8;
                curContext.Response.Charset = "";

                // 导出excel文件 
                strWriter = new System.IO.StringWriter();
                htmlWriter = new System.Web.UI.HtmlTextWriter(strWriter);

                // 为了解决dgData中可能进行了分页的情况，需要重新定义一个无分页的DataGrid 
                dgExport = new System.Web.UI.WebControls.DataGrid();
                dgExport.DataSource = dtData.DefaultView;
                dgExport.AllowPaging = false;
                dgExport.DataBind();

                // 返回客户端 
                dgExport.RenderControl(htmlWriter);
                curContext.Response.Write(strWriter.ToString());
                curContext.Response.End();
            }
        }



        /// <summary> 
        /// dtData是要导出为Excel的DataTable,FileName是要导出的Excel文件名(不加.xls) 
        /// </summary> 
        /// <param name="dtData"></param> 
        /// <param name="FileName"></param> 
        public static void DataTable3Excel(System.Data.DataTable dtData, String FileName)
        {
            System.Web.UI.WebControls.GridView dgExport = null;
            //当前对话 
            System.Web.HttpContext curContext = System.Web.HttpContext.Current;
            //IO用于导出并返回excel文件 
            System.IO.StringWriter strWriter = null;
            System.Web.UI.HtmlTextWriter htmlWriter = null;

            if (dtData != null)
            {
                //设置编码和附件格式 
                //System.Web.HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8)作用是方式中文文件名乱码 
                curContext.Response.AddHeader("content-disposition", "attachment;filename=" + System.Web.HttpUtility.UrlEncode(FileName, System.Text.Encoding.UTF8) + ".xls");
                curContext.Response.ContentType = "application nd.ms-excel";
                curContext.Response.ContentEncoding = System.Text.Encoding.UTF8;
                curContext.Response.Charset = "GB2312";

                //导出Excel文件 
                strWriter = new System.IO.StringWriter();
                htmlWriter = new System.Web.UI.HtmlTextWriter(strWriter);

                //为了解决dgData中可能进行了分页的情况,需要重新定义一个无分页的GridView 
                dgExport = new System.Web.UI.WebControls.GridView();
                dgExport.DataSource = dtData.DefaultView;
                dgExport.AllowPaging = false;
                dgExport.DataBind();

                //下载到客户端 
                dgExport.RenderControl(htmlWriter);
                curContext.Response.Write(strWriter.ToString());
                curContext.Response.End();
            }
        }



    }
}
