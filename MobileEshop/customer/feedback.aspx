<%@ Page Title="" Language="C#" MasterPageFile="~/customer/MasterPage.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="customer_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link href="../css/feedbackstyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <h2>Feel free to leave a feedback</h2>

<div class="container">
    <div class="row">
    <div class="col-25">
      <label for="fname">First Name</label>
    </div>
    <div class="col-75">
        <asp:textbox runat="server" ID="txtname" ></asp:textbox>
    
    </div>
  </div>
  <div class="row">
    <div class="col-25">
      <label for="Email">Email</label>
    </div>
    <div class="col-75">
  <asp:textbox runat="server" ID="txtemail" ></asp:textbox>
    </div>
  </div>
  <div class="row">
    <div class="col-25">
        <asp:label runat="server" text="Phone No"></asp:label>
  
    </div>
    <div class="col-75">
        <asp:textbox runat="server" ID="txtcon"></asp:textbox>
    </div>
  </div>
  <div class="row">
    <div class="col-25">
      <label for="subject">Subject</label>
    </div>
    <div class="col-75">
<asp:textbox runat="server" ID="txtmsg" style="height:200px"></asp:textbox>
    </div>
  </div>
  <div class="row">
      <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
   

  </div>

</div>
</asp:Content>

