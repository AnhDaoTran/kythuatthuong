<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="sanpham.aspx.cs" Inherits="QLBH.sanpham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .hinh{
            width:200px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server" RepeatColumns="3">
    <ItemTemplate>
        <asp:Label ID="Label1" runat="server" Text='<%# Eval("TenHang") %>'></asp:Label>
        <br />
        <asp:Image ID="Image1" runat="server" ImageUrl='<%# "~/images/"+Eval("Hinh") %>' CssClass="hinh" />
        <br />
        <asp:Label ID="Label2" runat="server" Text='<%# Eval("DonGia") %>'></asp:Label>
    </ItemTemplate>
</asp:DataList>
</asp:Content>
