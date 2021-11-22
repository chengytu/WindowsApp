using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Deployment;


namespace BusModels
{
    public class CommData
    {
       
        public static SysUser usermember { get; set; }//用户信息
       

        //判定是不是数值
        public static bool IsDecimal(string numStr)
        {
            try
            {
                decimal num = Convert.ToDecimal(numStr);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool ToDouble(string numStr)
        {
            try
            {
                Double num = Convert.ToDouble(numStr);
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }

        public static byte ToByte(string numStr)
        {
            byte num = 0;
            try
            {
                num = Convert.ToByte(numStr);
            }
            catch (Exception)
            {
                return num;
            }
            return num;

        }
        /// <summary>
        /// byte[] 转string
        /// </summary>
        /// <param name="bytes"></param>
        /// <returns></returns>
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("D2");
                }
            }
            return returnStr;
        }

    }
}


