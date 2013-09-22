using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetWeather
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new System.Net.WebClient();

            var urlList = new List<string>(){
                "http://i.weather.com.cn/i/product/pic/l/sevp_nsmc_wxcl_asc_e99_achn_lno_py_20130922073000000.jpg",
                "http://i.weather.com.cn/i/product/pic/l/sevp_nsmc_wxcl_asc_e99_achn_lno_py_20130922070000000.jpg",
                "http://i.weather.com.cn/i/product/pic/m/sevp_nsmc_wxcl_asc_e99_achn_lno_py_20130921123000000.jpg"
            };

            DateTime dt;
            //dt = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd 00:00:00"));

            dt = DateTime.Parse(DateTime.Now.ToString("2013-09-01 00:00:00"));

            while (dt < DateTime.Now)
            {
                dt = dt.AddMinutes(30);

                var dynamicFileName = dt.ToString("yyyyMMddhhmm00000");

                string strURI = string.Format(
                    "http://i.weather.com.cn/i/product/pic/m/sevp_nsmc_wxcl_asc_e99_achn_lno_py_{0}.jpg"
                    , dynamicFileName);

                client.DownloadFile(strURI, "F:\\" + dynamicFileName + ".jpg");
            }
        }
    }
}
