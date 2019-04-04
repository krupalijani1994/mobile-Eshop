<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="change password.aspx.cs" Inherits="admin_change_password" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <div>
    <center><h3 style="color:Black">Change Password </h3></center> </div>
    
<%--    <center>
            <p>
                 <asp:Label ID="lblop" runat="server" Text="Old Password:"></asp:Label>
                  <asp:TextBox ID="txtopassword" runat="server" ></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rf1" runat="server" ControlToValidate="txtopassword" ErrorMessage="*"></asp:RequiredFieldValidator>
             </p>
     </center>--%>
         
     <center>    
             <p>   
                  <asp:Label ID="lblnpw" runat="server" Text=" New Password:"></asp:Label>
                  <asp:TextBox ID="txtnewPassword" runat="server" TextMode="Password"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="rf2" runat="server" ControlToValidate="txtnewPassword" ErrorMessage="*"></asp:RequiredFieldValidator>
            </p>
     </center>
     <center>   
            <p> 
                 <asp:Label ID="lblrpw" runat="server" Text="Confirm Password:"></asp:Label>
                 <asp:TextBox ID="txtconfirmpassword" runat="server" TextMode="Password"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rf3" runat="server" ControlToValidate="txtconfirmpassword" ErrorMessage="*"></asp:RequiredFieldValidator>
            </p>
            <p> 
                 <asp:Button ID="btnsave" runat="server" onclick="btnsave_Click" Text="Save" />
            </p>
     </center>    
</asp:Content>

