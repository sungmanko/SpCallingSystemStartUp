﻿using System.Linq;
using System.Windows;

namespace SpCallingSystemStartUp
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args != null && args.Count() > 0)
            {
                string[] parameters = args[0].Split('/');
                string resultStr = string.Empty;
                resultStr += "【SP架電システム起動時処理スタブ】" + "\r\n" + "\r\n";

                resultStr += "　　カナ氏名：" + parameters[0] + "\r\n";
                resultStr += "　　顧客氏名：" + parameters[1] + "\r\n";
                resultStr += "　　自宅電話：" + parameters[2] + "\r\n";
                resultStr += "　　携帯電話：" + parameters[3] + "\r\n";
                resultStr += "　　会社電話：" + parameters[4] + "\r\n";
                resultStr += "　　不通フラグ：" + parameters[5] + "\r\n";
                
                MessageBox.Show(resultStr);
            }
        }
    }
}
