<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="booking.aspx.cs" Inherits="booking" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
    .auto-style1 {
        width: 47%;
        background-color: #666699;
    }
    .auto-style2 {
        width: 120px;
    }
    .auto-style3 {
        width: 120px;
        height: 192px;
    }
    .auto-style4 {
        height: 192px;
        background-color: #669999;
    }
    .auto-style5 {
        width: 120px;
        height: 26px;
    }
    .auto-style6 {
        height: 26px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Booking"></asp:Label>
<br />
<br />
<table border="2" class="auto-style1">
    <tr>
        <td class="auto-style5">Customer Name</td>
        <td class="auto-style6">
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Address</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style3">Select Date </td>
        <td class="auto-style4">
            <asp:Calendar ID="Calendar1" runat="server" style="background-color: #FFFFFF"></asp:Calendar>
        </td>
    </tr>
    <tr>
        <td class="auto-style2">Select Time</td>
        <td>start time<asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>10:00 AM</asp:ListItem>
            <asp:ListItem>10:30 AM</asp:ListItem>
            <asp:ListItem>11:00 AM</asp:ListItem>
            <asp:ListItem>11:30 AM</asp:ListItem>
            <asp:ListItem>12:00 AM</asp:ListItem>
            <asp:ListItem>12:30 AM</asp:ListItem>
            <asp:ListItem>1:00 AM</asp:ListItem>
            <asp:ListItem>1:30 AM</asp:ListItem>
            </asp:DropDownList>
&nbsp;End Time<asp:DropDownList ID="DropDownList2" runat="server">
                <asp:ListItem>10:00 AM</asp:ListItem>
                <asp:ListItem>10:30 AM</asp:ListItem>
                <asp:ListItem>11:00 AM</asp:ListItem>
                <asp:ListItem>11:30 AM</asp:ListItem>
                <asp:ListItem>12:00 AM</asp:ListItem>
                <asp:ListItem>12:30 AM</asp:ListItem>
                <asp:ListItem>1:00 AM</asp:ListItem>
                <asp:ListItem>1:30 AM</asp:ListItem>
            </asp:DropDownList>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Check Availibility" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>
            <asp:Label ID="Label2" runat="server"></asp:Label>
            <br />
            <br />
            <asp:RadioButtonList ID="RadioButtonList1" runat="server" Visible="False">
                <asp:ListItem>Miloni</asp:ListItem>
                <asp:ListItem>Sukhjit</asp:ListItem>
                <asp:ListItem>Igho</asp:ListItem>
                <asp:ListItem>Krupali</asp:ListItem>
            </asp:RadioButtonList>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Book now" />
        </td>
    </tr>
    <tr>
        <td class="auto-style2">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
<br />
<asp:Label ID="Label3" runat="server"></asp:Label>
<br />
<br />
</asp:Content>

