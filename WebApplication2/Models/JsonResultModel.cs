using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication2.Models
{
    public class JsonResultModel
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
    }
}