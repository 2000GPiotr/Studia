using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Web;

namespace Zadanie1
{
    public class Handler : IHttpHandler
    {
        public bool IsReusable => true;

        public void ProcessRequest(HttpContext context)
        {
            context.Response.AppendHeader("Content-type", "text/html");
            context.Response.Write("handler obsługuje " + context.Request.Url + "<br/>");
            context.Response.Write("typ rządania to " + context.Request.HttpMethod + "<br/>");
            context.Response.Write("nagłówki HTTP to " + context.Request.Headers + "<br/>");
            
            if(context.Request.HttpMethod == "POST")
            {
                using (var sr = new StreamReader(context.Request.InputStream))
                {
                    string body = sr.ReadToEnd();
                    context.Response.Write("ciało żądania " + body + "<br/>");
                }
            }
            
            context.Response.End();
        }
    }
}