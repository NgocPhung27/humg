using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace LapTrinhQuanLyDb.Models
{
    public class AutoGenerateKey
    {
        //sinh mã tự động
        public string Generatekey(string id)
        {
            string strkey = "";
            string numpPart = "", 
            strPart = "", 
            strPhanSo = "";
            numpPart = Regex.Match(id, @"\d+").Value;
            strPart = Regex.Match(id, @"\D+").Value;

            int PhanSo = (Convert.ToInt32(numpPart) + 1);
            for (int i = 0; i < numpPart.Length - PhanSo.ToString().Length; i++)
            {
                strPhanSo += "0";
            }
            strPhanSo += PhanSo;
            //tách phần chữ
            strkey = strPart + strPhanSo;
            return strkey;
        }
       public string GetMD5(string strInput)
        {
            string str_md5 = "";
            byte[] arrOut = System.Text.Encoding.UTF8.GetBytes(strInput);
            MD5CryptoServiceProvider my_md5 = new MD5CryptoServiceProvider();
            arrOut = my_md5.ComputeHash(arrOut);
            foreach (byte b in arrOut) 
            {
                str_md5 += b.ToString("X2");
            }
            return str_md5;     

        }
  
    }
}