<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="QLBH.sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .motsp{
            margin:5px;
            text-align:center;
        }
        .hinh{
            width:200px;
            height:250px;
        }
        .gia{
            font-size:20px;
            font-weight:bold;
            color:red;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
    <ItemTemplate>
        <div class="motsp">
            <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHang") %>'></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+Eval("Hinh") %>' CssClass="hinh" />
        <br />
        Giá: <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia","{0:0,0}") %>' CssClass="gia"></asp:Label>
            <br />
            <asp:LinkButton ID="LinkButton3" runat="server" CommandArgument='<%# Eval("MaHang") %>' OnClick="LinkButton3_Click">Chi tiết</asp:LinkButton>
        </div>
    </ItemTemplate>
</asp:DataList>
</asp:Content>
