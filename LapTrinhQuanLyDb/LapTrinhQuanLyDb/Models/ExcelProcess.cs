using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Data.OleDb;

namespace LapTrinhQuanLyDb.Models
{
    public class ExcelProcess
    {
        public DataTable ReadDataFromExcelFile ( string filepath, bool removeRqw0)
        {
            string connectionString = "";
            string fileExtention = filepath.Substring(filepath.Length - 4).ToLower();
            if (fileExtention.IndexOf("xlsx")<0)
            {
                connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filepath + ";Extended Properties= Excel 8.0";
            }
            else 
            {
                connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + filepath + ";Extended Properties=\" Excel 12.0 Xml;HDR=NO\"";
            }
            //Tạo đối tượng kết nối
            OleDbConnection oledbCoon = new OleDbConnection(connectionString);
            DataTable data = null;
            try 
            {
                //mở kết nối
                oledbCoon.Open();
                //tạo đối tượng OledbConmand và query data từ sheet vó tên là " sheet 1"
                OleDbCommand cmd = new OleDbCommand("select * from [Sheet 1$]", oledbCoon);
                //tạo đối tượng OledbDataAdapter để thực thi việc query lấy dữ liệu từ tập tin excel
                //
                OleDbDataAdapter oleda = new OleDbDataAdapter();
                oleda.SelectCommand = cmd;
                // tạo đối tượng dataset để hứng dữ liệu từ tập tin excel
                DataSet ds = new DataSet();
                //đổ dữ liệu từ tập excel vào DataSet
                oleda.Fill(ds);
                data = ds.Tables[0];
                if(removeRqw0==true)
                {
                    data.Rows.RemoveAt(0);
                }    
            }
            catch
            {
            }
            finally
            {
                //dóng chuỗi kết nối
                oledbCoon.Close();
            }
            return data;
        }
    }
}