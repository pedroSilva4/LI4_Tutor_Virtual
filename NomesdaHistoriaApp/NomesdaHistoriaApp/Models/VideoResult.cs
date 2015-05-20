using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Hosting;
using System.IO;

namespace NomesdaHistoriaApp.Models
{
    public class VideoResult : ActionResult
    {
        public String url {get ; set;}
        public VideoResult(String url) {
            this.url = url;
        }

        public override void ExecuteResult(ControllerContext context)
        {
            var videoFilePath = HostingEnvironment.MapPath(this.url);

            var file = new FileInfo(videoFilePath);
            if (file.Exists)
            {
                var stream = file.OpenRead();
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)file.Length);
                context.HttpContext.Response.BinaryWrite(bytes);

            }
        }

    }
}