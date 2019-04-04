<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="contactus.aspx.cs" Inherits="contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div id="templatemo_main">
            <h2>Contact Information</h2>
            <div class="col col23">
            	
              <div id="contact_form" style="width:360px; margin:6px 0px 0px 20px" >
                       
                            <p>
                                <asp:Label ID="lblname" runat="server" Text="Name:" Width="120px"></asp:Label>
                                <asp:TextBox ID="txtname" runat="server" CssClass="conttxt" Width="160px"></asp:TextBox>
                           
                                <asp:Label ID="lblemail" runat="server" Text="Email:" Width="120"></asp:Label>
                                 <asp:TextBox ID="txtemail" runat="server" CssClass="conttxt" Width="160px"></asp:TextBox>
                                
                               <asp:Label ID="lblcontactno" runat="server" Text="Contact No:" Width="120"></asp:Label>
                                  <asp:TextBox ID="txtcon" runat="server" CssClass="conttxt" Width="160px"></asp:TextBox>
                          
                            </p>
                            <p>
                          
                               <asp:Label ID="lblmsg" runat="server" Text="Message:" Width="120"></asp:Label>
                                <asp:TextBox ID="txtmsg" runat="server" CssClass="cnttext" TextMode="MultiLine"></asp:TextBox>

                            </p>

                            <div class="cleaner h20">
                            </div>
                       <asp:Button ID="btnsend" runat="server" Text="Sent" CssClass="sent" 
                                ValidationGroup="Sent"/>
                            <asp:Button ID="btnreset" runat="server" Text="Reset" CssClass="resent" 
                               ValidationGroup="Reset"/>
                             
                 </div>
            </div>
            
            <div class="col col13 no_margin_right">
           
            	<h4> Address</h4>
                <h3>Mobile E-Shop</h3>
                  
                    
                <strong>Phone:</strong>+44 9898989898<br />
               
                
                
                
                <div class="cleaner h40"></div>
               </div>
                
                <div class="img_border"  style="   margin-top: -296px; margin-left: 400px;" >
                
              <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2421.6701880638875!2d-1.1418310840063303!3d52.62980393583798!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4879ddcfc377f7cd%3A0xd91c9efcc41fdd79!2sDe+Montfort+University!5e0!3m2!1sen!2suk!4v1554390322851!5m2!1sen!2suk" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
            
        	</div>
			<div class="cleaner"></div>
        </div>
</asp:Content>

