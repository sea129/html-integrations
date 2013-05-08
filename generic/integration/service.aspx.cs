using System;
using System.Web.UI;
using com.wiris.plugin.web;
using System.Collections.Generic;
using com.wiris.plugin.api;

namespace plugin_web
{
    public partial class service : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            PluginBuilder pb = DispatcherUtils.getPluginBuilder(Request);
            Dictionary<string, string> param = DispatcherUtils.getParameterMap(Request.Params);
            String service = Request.Params["service"];
            String r = pb.newTextService().service(service, param);
            Response.ContentType = "text/plain; charset=utf-8";
            Response.Write(r);
        }

        override protected void OnInit(EventArgs e)
        {
            this.Load += new System.EventHandler(this.Page_Load);
            base.OnInit(e);
        }

    }
}
