using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace QLBH
{
    public partial class chitietsp : System.Web.UI.Page
    {
        xuly x = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
          
            string q;
            if (Context.Items["mh"] == null)
                q = "select * from MatHang";
            else
            {
                string mahang = Context.Items["mh"].ToString();
                q = "select * from MatHang where MaHang = '" + mahang + "'";
            }
            try
            {
                this.DataList1.DataSource = x.getdata(q);
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }


    }
}