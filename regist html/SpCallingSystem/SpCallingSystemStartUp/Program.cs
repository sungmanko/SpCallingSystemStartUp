using System.Linq;
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
                resultStr += "※※※　パラメータ取得結果　※※※" + "\r\n" + "\r\n";
<<<<<<< HEAD

                resultStr += "カナ氏名：" + System.Web.HttpUtility.UrlDecode(parameters[0]) + "\r\n";
                resultStr += "顧客氏名：" + System.Web.HttpUtility.UrlDecode(parameters[1]) + "\r\n";
                resultStr += "自宅電話：" + System.Web.HttpUtility.UrlDecode(parameters[2]) + "\r\n";
                resultStr += "携帯電話：" + System.Web.HttpUtility.UrlDecode(parameters[3]) + "\r\n";
                resultStr += "会社電話：" + System.Web.HttpUtility.UrlDecode(parameters[4]) + "\r\n";
                resultStr += "不通フラグ：" + System.Web.HttpUtility.UrlDecode(parameters[5]) + "\r\n";
=======
                resultStr += "受付のパラメータ原本：" + args[0].ToString();
                resultStr += "カナ氏名：" + System.Web.HttpUtility.UrlDecode(parameters[1]) + "\r\n";
                resultStr += "顧客氏名：" + System.Web.HttpUtility.UrlDecode(parameters[2]) + "\r\n";
                resultStr += "自宅電話：" + System.Web.HttpUtility.UrlDecode(parameters[3]) + "\r\n";
                resultStr += "携帯電話：" + System.Web.HttpUtility.UrlDecode(parameters[4]) + "\r\n";
                resultStr += "会社電話：" + System.Web.HttpUtility.UrlDecode(parameters[5]) + "\r\n";
                resultStr += "不通フラグ：" + System.Web.HttpUtility.UrlDecode(parameters[6]) + "\r\n";
>>>>>>> e6f15dd9cacce4745cdc97a3623c3df5d9ba324f

                MessageBox.Show(resultStr, "【SP架電システム―サンプル】", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        /// <summary>
        /// BOMを調べて、文字コードを判別する。
        /// </summary>
        /// <param name="bytes">文字コードを調べるデータ。</param>
        /// <returns>BOMが見つかった時は、対応するEncodingオブジェクト。
        /// 見つからなかった時は、null。</returns>
        public static System.Text.Encoding DetectEncodingFromBOM(byte[] bytes)
        {
            if (bytes.Length < 2)
            {
                return null;
            }
            if ((bytes[0] == 0xfe) && (bytes[1] == 0xff))
            {
                //UTF-16 BE
                return new System.Text.UnicodeEncoding(true, true);
            }
            if ((bytes[0] == 0xff) && (bytes[1] == 0xfe))
            {
                if ((4 <= bytes.Length) &&
                    (bytes[2] == 0x00) && (bytes[3] == 0x00))
                {
                    //UTF-32 LE
                    return new System.Text.UTF32Encoding(false, true);
                }
                //UTF-16 LE
                return new System.Text.UnicodeEncoding(false, true);
            }
            if (bytes.Length < 3)
            {
                return null;
            }
            if ((bytes[0] == 0xef) && (bytes[1] == 0xbb) && (bytes[2] == 0xbf))
            {
                //UTF-8
                return new System.Text.UTF8Encoding(true, true);
            }
            if (bytes.Length < 4)
            {
                return null;
            }
            if ((bytes[0] == 0x00) && (bytes[1] == 0x00) &&
                (bytes[2] == 0xfe) && (bytes[3] == 0xff))
            {
                //UTF-32 BE
                return new System.Text.UTF32Encoding(true, true);
            }

            return null;
        }
    }
}
