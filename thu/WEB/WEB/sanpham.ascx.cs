using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WEB
{
    public partial class sanpham : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //chuỗi connect
            if (!IsPostBack)
            {
                SqlCommand sqlcmd = new SqlCommand("select * from SANPHAM");
                DataTable dt = SQLDB.SQLDB.GetData(sqlcmd);
                drpSP.DataSource = dt;
                drpSP.DataValueField = "MASP";
                drpSP.DataTextField = "MASP";
                drpSP.DataBind();
            }

        }

        protected void drpSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand sqlcmd = new SqlCommand("select * from SANPHAM where masp = @MASP");
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.Parameters.AddWithValue("@MASP", drpSP.SelectedValue.ToString());
            rptNews.DataSource = SQLDB.SQLDB.GetData(sqlcmd);
            rptNews.DataBind();
        }
    }
}