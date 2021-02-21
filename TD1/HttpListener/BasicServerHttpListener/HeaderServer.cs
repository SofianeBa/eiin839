using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class HeaderServer
    {
        public HttpListenerRequest collection;
        public Object[] infos;
        public int i;

        public HeaderServer(HttpListenerRequest headerCollection)
        {
            this.collection = headerCollection;
            
            this.infos[0] = "Accept header : " + [HttpRequestHeader.Accept.ToString()];
            this.infos[1] = "Accept Language header : " + [HttpRequestHeader.AcceptLanguage.ToString()];
            this.infos[2] = "Accept Charset header : " + [HttpRequestHeader.AcceptCharset.ToString()];
            this.infos[3] = "Allow header : " + [HttpRequestHeader.Allow.ToString()];
            this.infos[4] = "Authorization header : " + [HttpRequestHeader.Authorization.ToString()];
            this.infos[5] = "Cookie header : " + [HttpRequestHeader.Cookie.ToString()];
            this.infos[6] = "From header : " + [HttpRequestHeader.From.ToString()];
            this.infos[7] = "User-Agent header : " + [HttpRequestHeader.UserAgent.ToString()];


        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder("");

            for (j = 0; j <= 6; j++)
            {
                sb.Append(this.infos[j]+'\n');
            }

            return sb.ToString();
        }


    }
}
