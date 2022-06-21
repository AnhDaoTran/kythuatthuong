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
    public partial class sanpham : System.Web.UI.Page
    {
        //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\QLBH\QLBH\App_Data\BanHangmdf.mdf;Integrated Security=True";
        xuly xl = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q;
            if (Context.Items["ml"] == null)
                q = "select * from MatHang";
            else
            {
                string maloai = Context.Items["ml"].ToString();
                q = "select * from MatHang where MaLoai = '" + maloai + "'";
            }
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(q, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                this.DataList1.DataSource = xl.getdata(q);
                this.DataList1.DataBind();

            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }


        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            string mahang = ((LinkButton)sender).CommandArgument;
            Context.Items["mh"] = mahang;
            Server.Transfer("chitietsp.aspx");
        }
    }
}