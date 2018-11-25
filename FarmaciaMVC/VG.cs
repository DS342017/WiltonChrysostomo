using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace FarmaciaMVC
{
    

    public class VG
    {
        public static HttpClient WebApiClient = new HttpClient();
        static VG()
        {          
            WebApiClient.BaseAddress = new Uri("http://localhost:59633/api/");
                
            WebApiClient.DefaultRequestHeaders.Clear();
                     
            WebApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}