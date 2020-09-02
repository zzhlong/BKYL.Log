﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace BKYL.Log.Common
{
    /// <summary>
    /// 帮助类
    /// </summary>
    public static class UtilHelper
    {
        /// <summary>
        /// 过滤掉换行
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static string filterLine(this string message)
        {
            if (message == null)
                return "";
            return message.Replace("\r", "").Replace("\n", "");
        }

        #region 格式化容量大小
        /// <summary>
        /// 格式化容量大小
        /// </summary>
        /// <param name="size">容量（B）</param>
        /// <returns>已格式化的容量</returns>
        public static string FormatSize(double size)
        {
            double d = (double)size;
            int i = 0;
            while ((d > 1024) && (i < 5))
            {
                d /= 1024;
                i++;
            }
            string[] unit = { "B", "KB", "MB", "GB", "TB" };
            return (string.Format("{0} {1}", Math.Round(d, 2), unit[i]));
        }
        #endregion
    }
}