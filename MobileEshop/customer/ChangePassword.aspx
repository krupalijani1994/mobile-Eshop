<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="ChangePassword.aspx.cs" Inherits="customer_ChangePassword" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
      <script src="js/JavaScript.js"></script>
    <link href="css/StyleSheet.css" rel="stylesheet" />
	
    <center>
	<div id="newsletter">
                                      
                    <p>
                          &nbsp;</p>  
                   &nbsp;
                    <p>
                      
                        <asp:Label ID="lblnewpass" runat="server" Text="Label">New Password:</asp:Label> 
                       
                       <asp:TextBox ID="txtnpass" runat="server" CssClass="txt_field" TextMode ="Password" Height="20px" Width="197px"></asp:TextBox>
                   </p> 
                           
         <p> 
                 <asp:Label ID="lblrpw" runat="server" Text="Confirm Password:"></asp:Label>

                 <asp:TextBox ID="txtconfirmpassword" runat="server" TextMode="Password" Height="20px" Width="197px"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="rf3" runat="server" ControlToValidate="txtconfirmpassword" ErrorMessage="*"></asp:RequiredFieldValidator>
            </p>
                    
                    <asp:Button ID="btnok" runat="server" Text="Ok" CssClass="subscribe_btn" OnClick="btnok_Click1" 
                            />
        
                      <div class="cleaner"></div>
                  
                    <div class="cleaner"></div>
                </div>
	</center>
</asp:Content>

