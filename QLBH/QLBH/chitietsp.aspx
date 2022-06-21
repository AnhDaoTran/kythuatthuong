<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="chitietsp.aspx.cs" Inherits="QLBH.chitietsp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .hinh{
            width:200px;
        }
        .tensp{
            color:blue;
            font-weight:bold;
            font-size:30px;
        }
        .giasp{
            color:red;
            font-size:20px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DataList ID="DataList1" runat="server">
        <ItemTemplate>
            <table>
                <tr>
                    
                    <td>

                    </td>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text='<%# Eval("TenHang") %>' CssClass="tensp" ></asp:Label>
                    </td>
                </tr>

                <tr>
                    <td>
                        <asp:Image ID="Image2" runat="server" ImageUrl='<%# "~/images/" + Eval("Hinh") %>' CssClass="hinh"/>
                        <br />
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("DonGia", "{0:0,0}") %>' CssClass="giasp"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text='<%# Eval("MoTa") %>'></asp:Label>
                        
                        
                    </td>
                </tr>
            </table>
            
            <br />
           
            
        </ItemTemplate>
        
    </asp:DataList>
</asp:Content>