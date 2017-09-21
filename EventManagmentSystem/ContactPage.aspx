<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ContactPage.aspx.cs" Inherits="EventManagmentSystem.ContactPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1 style="color:white">Contact us</h1>
    <h4 style="color:white">
        <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </h4>
<p style="color:white">
        <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>
<p style="color:white">
        <asp:Label ID="Label3" runat="server" Text="Message"></asp:Label>
&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Height="98px" Width="325px"></asp:TextBox>
    </p>
<p style="color:white">
        &nbsp;</p>
<p style="color:white">
        &nbsp;</p>
<p style="color:white">
        &nbsp;</p>
<p style="color:white">
        &nbsp;</p>
<p style="color:white">
        &nbsp;</p>
    
</asp:Content>
