using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace shop.web
{
    public partial class loai : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            csdl.csdl.ConnectionString = "Data Source=DESKTOP-CQ5U2G4\\SQLEXPRESS;Initial Catalog=QLBH;Integrated Security=True";
            SqlCommand sqlcmd = new SqlCommand("select * from LOAISP");
            drploai.DataSource.csdl.csdl.getData(sqlcmd);
    }
}