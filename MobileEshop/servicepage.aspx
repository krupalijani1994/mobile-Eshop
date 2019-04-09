<%@ Page Title="" Language="C#" MasterPageFile="~/user.master" AutoEventWireup="true" CodeFile="servicepage.aspx.cs" Inherits="servicepage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style>
    .column {
    float: left;
    padding: 10px;
}

    /* Left and right column */
    .column.side {
        width: 25%;
    }

    /* Middle column */
    .column.middle {
        width: 50%;
        float:left;
       /*top:50px;*/
        position:relative;
        left:5%;
    }

/* Clear floats after the columns */
.row:after {
    content: "";
    display: table;
    clear: both;
}
        </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
 
   

<div class="row">
  <div class="column side">
    <h1 style=" text-align: center; margin-right: 60px;">  Home Demo Service</h1>
    <p style="text-align:center"> 
    booking the home demo service is easy click on the date which you would like to ask for the demo ...
        The booking system is currently not available...
        call on the number given on the page in thge On-help call they will book for you. 

       </p>

      <div style="text-align: center;">
           <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
          
      </div>
    

        <p>
            <asp:Button ID="Button1" runat="server" Text="Book service" OnClick="Button1_Click" style="font-weight: 700; top: 535px; left: 76px; float: none; height: 26px; width: 123px" />

        </p>
        
  </div>
  
  
    
    
    <div  class="column middle">
        <%--<div style="max-width:200px">--%>
	<h1>Office Dropin  </h1>
      
        <!--<attach map> </attach>-->
                        
                <%--<div class="img_border"  style="   margin-top: -296px; margin-left: 400px;" >--%>
                
              <iframe src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2421.6701880638875!2d-1.1418310840063303!3d52.62980393583798!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x4879ddcfc377f7cd%3A0xd91c9efcc41fdd79!2sDe+Montfort+University!5e0!3m2!1sen!2suk!4v1554390322851!5m2!1sen!2suk" width="600" height="450" frameborder="0" style="border:0" allowfullscreen></iframe>
            
        	<%--</div>--%>


    
</div>

  <div class="column side">
    <h1 style="margin-left:105px;">On call Help </h1>
  <p>
      <img src="images/help.jpeg" />
  </p> 
      <h1> call us on 
          0123456789 </h1>
</div>
      
    </div>
</asp:Content>

