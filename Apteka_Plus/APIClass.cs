using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;

namespace Apteka_Plus
{
    public static class APIClass
    {
        public static string temper;

        public static void Weather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.open-meteo.com/v1/forecast?latitude=52.52&longitude=13.41&hourly=temperature_2m");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic w = JsonConvert.DeserializeObject(sReadData);
            temper = w.hourly.temperature_2m[12].ToString();
        }
    }
}
