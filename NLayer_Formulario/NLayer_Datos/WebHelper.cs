using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;

namespace NLayer_Datos
{
    public static class WebHelper
    {
        static WebClient client;
        static string rutaBase;

        static WebHelper()
        {
            client = new WebClient();
            client.Encoding = Encoding.UTF8;
            rutaBase = ConfigurationManager.AppSettings["URL_API"];
            client.Headers.Add("ContentType", "Aplicaction/json");
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
        }

        public static string Get(string url)
        {
            string uri = rutaBase + url;
            string responseString = client.DownloadString(uri);
            return responseString;
        }

        public static string Post(string url, NameValueCollection parametros)
        {
            string uri = rutaBase + url;
            try
            {
                var response = client.UploadValues(uri, parametros);
                var responseString = Encoding.Default.GetString(response);
                return responseString;
            }
            catch (Exception)
            { 
                return "{ \"isOk\":false,   \"id\":-1 , \"error al llamado\"}";
            }
        }

    }
}
