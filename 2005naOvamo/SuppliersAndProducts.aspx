﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SuppliersAndProducts.aspx.cs" Inherits="_2005naOvamo.SuppliersAndProducts" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">



    <%@ Page Language="C#" CodeFile="SuppliersAndProducts.aspx.cs"
    AutoEventWireup="true" Inherits="SuppliersAndProducts" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN"
    "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
    <link href="Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>
            Suppliers and Their Products</h2>
        <p>
            <asp:GridView ID="GridView1" runat="server"
             AutoGenerateColumns="False"
             CssClass="DataWebControlStyle">
                <HeaderStyle CssClass="HeaderStyle" />
                <AlternatingRowStyle CssClass="AlternatingRowStyle" />
                <Columns>
                    <asp:BoundField DataField="CompanyName"
                      HeaderText="Supplier" />
                    <asp:TemplateField HeaderText="Products">
                        <ItemTemplate>
                            <asp:BulletedList ID="BulletedList1"
                             runat="server" DataSource="<%# ((Northwind.SuppliersRow) ((System.Data.DataRowView) Container.DataItem).Row).GetProducts() %>"
                                 DataTextField="ProductName">
                            </asp:BulletedList>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
             </p>
    </div>
    </form>
</body>
</html>
</asp:Content>
