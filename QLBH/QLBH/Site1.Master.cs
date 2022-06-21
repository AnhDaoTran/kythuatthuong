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
        //string con = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\QLBH\QLBH\App_Data\BanHangmdf.mdf;Integrated Security=True";
        xuly kn = new xuly();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack) return;
            string q = "select * from LoaiHang";
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(q, con);
                //DataTable dt = new DataTable();
                //da.Fill(dt);
                this.DataList1.DataSource = kn.getdata(q);
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

        protected void Login1_Authenticate(object sender, AuthenticateEventArgs e)
        {
            string ten = this.Login1.UserName;
            string matkhau = this.Login1.Password;
            string sql = "select * from KhachHang where TenDangNhap='" + ten + "' and Matkhau ='" + matkhau + "'";                DataTable table = new DataTable();
            try
            {
                //SqlDataAdapter da = new SqlDataAdapter(sql, u);
                //da.Fill(table);
            }
            catch (SqlException err)
            {
                Response.Write("<b>Error</b>" + err.Message + "<p/>");
            }
            if (table.Rows.Count != 0)
            {
                Response.Cookies["TenDangNhap"].Value = ten;
                Server.Transfer("sanpham.aspx");
            }
            else this.Login1.FailureText = "Tên đăng nhập hay mật khẩu không đúng!";
        }
    }
}