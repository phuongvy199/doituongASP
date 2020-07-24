using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace sever_control
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {// request
         /*Response.Write("Url: "+ Request.Url.ToString());
           Response.Write("<br> cookie:  "+Request.Cookies.ToString());
           Response.Write("<br> browser: " + Request.Browser.ToString());
           Response.Write("<br> querystring: " + Request.QueryString.ToString());
         */

            //response
            //  Response.Redirect("https://www.google.com/");

            /* session
            Session["taikhoan"] = "caovy";
            Response.Write(Session["taikhoan"].ToString());
            */
            /*  DataTable dt = new DataTable();
              dt.Columns.Add("1");
              dt.Columns.Add("2");
              dt.Columns.Add("3");
              dt.Columns.Add("4");
              Session["dtvalue"] = dt.Columns.Count.ToString();
              Response.Write(Session["dtvalue"].ToString());

      */

            // cookie

            HttpCookie cookie = new HttpCookie("name");
            cookie.Value = "caovy";
            cookie.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(cookie);
            string svalue = cookie.Value;
            Response.Write(svalue);


        }
    }
}