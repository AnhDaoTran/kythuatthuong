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
    public partial class Site1 : System.Web.UI.MasterPage
    {
        string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\THƯƠNG MẠI ĐIỆN TỬ IS384 R\QLBH\QLBH\App_Data\Database1.mdf';Integrated Security=True";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;

            try
            {
                string q = "select * from LoaiHang";
                SqlDataAdapter da = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                this.DataList1.DataSource = dt;
                this.DataList1.DataBind();
            }
            catch (SqlException ex)
            {
                Response.Write(ex.Message);
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            string maloai = ((LinkButton)sender).CommandArgument;
            Context.Items["ml"] = maloai;
            Server.Transfer("sanpham.aspx");
        }

        protected void DataList1_SelectedIndexChanged()
        {

        }
    }
}