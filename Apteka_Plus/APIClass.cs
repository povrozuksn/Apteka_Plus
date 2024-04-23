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

        public static Dictionary<string, double> vals = new Dictionary<string, double>();

        public static void Weather()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://api.open-meteo.com/v1/forecast?latitude=54.19&longitude=48.22&hourly=temperature_2m&timezone=Europe%2FMoscow&forecast_days=1");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic w = JsonConvert.DeserializeObject(sReadData);
            int time = DateTime.Now.TimeOfDay.Hours;
            temper = w.hourly.temperature_2m[time].ToString();
        }

        public static void Vals()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://www.cbr-xml-daily.ru/daily_json.js");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            Stream stream = response.GetResponseStream();
            StreamReader sr = new StreamReader(stream);

            string sReadData = sr.ReadToEnd();
            response.Close();

            dynamic v = JsonConvert.DeserializeObject(sReadData);

            string usd = v.Valute.USD.Value.ToString();
            string eur = v.Valute.EUR.Value.ToString();
            string cny = v.Valute.CNY.Value.ToString();

            double Usd = Convert.ToDouble(usd);
            double Eur = Convert.ToDouble(eur);
            double Cny = Convert.ToDouble(cny);

            vals.Add("RUB", 1);
            vals.Add("USD", Usd);
            vals.Add("EUR", Eur);
            vals.Add("CNY", Cny);
        }
    }
}
