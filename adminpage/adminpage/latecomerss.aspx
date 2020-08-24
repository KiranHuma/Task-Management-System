<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="latecomerss.aspx.cs" Inherits="adminpage.latecomerss" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<!--
Template Name: Olester
Author: <a href="http://www.os-templates.com/">OS Templates</a>
Author URI: http://www.os-templates.com/
Licence: Free to use under our free template licence terms
Licence URI: http://www.os-templates.com/template-terms
-->

<head>
<title>Late Comers</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
<link href="../layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
</head>
<body id="top">
    <form id="form1" runat="server">
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row1">
  <header id="header" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <div id="logo">
      <h1>
          <asp:Image ID="Image1" runat="server" Height="114px" 
              ImageUrl="~/images/Time-Attendance.jpg" Width="214px" />
        </h1>
        <h1><a href="../index.html">Task Manangment</a></h1>
      <p>System</p>
    </div>
    <!-- ################################################################################################ -->
  </header>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row2">
  <nav id="mainav" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <ul class="clear">
      <li><a href="../home.aspx">Home</a></li>
      <li class="active"><a class="drop" href="#">User Details</a>
        <ul>
          <li><a href="home.aspx">Regester</a></li>
          <li><a href="taskdisplay.aspx">Display User Task</a></li>
          <li class="active"><a href="displayattendnce.aspx">Display User Attendance</a></li>
          
        </ul>
      </li>
     
      <li><a href="latecomerss.aspx">LateComers</a></li>
        <li><a href="edituser.aspx">Edit Details</a></li>
     <li><a href="#">Reports</a></li>
      <li><a href="#">Account Settings</a></li>
      <li><a href="#">Contact Us</a></li>
    
    </ul>
    <!-- ################################################################################################ -->
  </nav>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper overlay bgded" style="background-image:url('http://localhost:54919/images/attendance.png')">
  <div id="breadcrumb" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <ul>
      <li><a href="#">Home</a></li>
      <li><a href="#">User Details</a></li>
      <li><a href="#">Late Comers</a></li>
    </ul>
    <!-- ################################################################################################ -->
  </div>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row3">
  <main class="container hoc clear"> 
    <!-- main body -->
    <!-- ################################################################################################ -->
    <div class="content"> 
      <!-- ################################################################################################ -->
      <h1>See User Task In Details</h1>
        <p>
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" 
                AutoGenerateColumns="False" BackColor="LightGoldenrodYellow" BorderColor="Tan" 
                BorderWidth="1px" CellPadding="2" ForeColor="Black" GridLines="None" 
                Height="50px" OnPageIndexChanging="OnPageIndexChanging" 
                style="margin-left: 0px; margin-right: 0px; text-align: center;" Width="1044px">
                <AlternatingRowStyle BackColor="PaleGoldenrod" />
                <Columns>
                    <asp:BoundField DataField="id" HeaderText="ID" ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="nam" HeaderText="Name" ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="designation" HeaderText="Designation" 
                        ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="dte" HeaderText="Date" ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="tme" HeaderText="Time" ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="attndce" HeaderText="Attendence" 
                        ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="status" HeaderText="Status" ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="dayy" HeaderText="Day" ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="ltme" HeaderText="Leave Time" 
                        ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                    <asp:BoundField DataField="wrkinghrs" HeaderText="Working Hours" 
                        ItemStyle-Width="150px">
                    <ItemStyle Width="150px" />
                    </asp:BoundField>
                </Columns>
                <FooterStyle BackColor="Tan" />
                <HeaderStyle BackColor="Tan" Font-Bold="True" />
                <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                    HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
                <SortedAscendingCellStyle BackColor="#FAFAE7" />
                <SortedAscendingHeaderStyle BackColor="#DAC09E" />
                <SortedDescendingCellStyle BackColor="#E1DB9C" />
                <SortedDescendingHeaderStyle BackColor="#C2A47B" />
            </asp:GridView>
        </p>
        <p>
            &nbsp;</p>
        <div id="comments">
            <div class="block clear">
            &nbsp;
          </div>
          <div>
            &nbsp;&nbsp;&nbsp;
          </div>
      </div>
      <!-- ################################################################################################ -->
    </div>
    <!-- ################################################################################################ -->
    <!-- / main body -->
    <div class="clear"></div>
  </main>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row4">
  <footer id="footer" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <div class="one_quarter first">
      <h6 class="title">&nbsp;</h6>
      <p>&nbsp;</p>
    </div>
    <div class="one_quarter">
      <article>
        <h2 class="nospace font-x1">Qoute Of Today</h2>
        <p><span style="color: rgb(24, 24, 24); font-family: Merriweather, Georgia, serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
            “A man is a success if he gets up in the morning and gets to bed at night, and 
            in between he does what he wants to do.”<span class="Apple-converted-space">&nbsp;</span></span></p>
      </article>
    </div>
    <div class="one_quarter">
      <h6 class="title">Contact To</h6>
        <fieldset>
          <legend>Newsletter:</legend>
          <input class="btmspace-15" type="text" value="" placeholder="Email">
          <button type="submit" value="submit">Submit</button>
        </fieldset>
      <ul class="faico clear">
        <li><a class="faicon-facebook" href="#"><i class="fa fa-facebook"></i></a></li>
        <li><a class="faicon-twitter" href="#"><i class="fa fa-twitter"></i></a></li>
        <li><a class="faicon-linkedin" href="#"><i class="fa fa-linkedin"></i></a></li>
        <li><a class="faicon-google-plus" href="#"><i class="fa fa-google-plus"></i></a></li>
        <li><a class="faicon-instagram" href="#"><i class="fa fa-instagram"></i></a></li>
        <li><a class="faicon-tumblr" href="#"><i class="fa fa-tumblr"></i></a></li>
      </ul>
    </div>
    <!-- ################################################################################################ -->
  </footer>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row5">
  <div id="copyright" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <p class="fl_left">Copyright &copy; 2015 - All Rights Reserved - <a href="#">Domain Name</a></p>
    <p class="fl_right">Template by <a target="_blank" href="http://www.os-templates.com/" title="Free Website Templates">OS Templates</a></p>
    <!-- ################################################################################################ -->
  </div>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<a id="backtotop" href="#top"><i class="fa fa-chevron-up"></i></a>
<!-- JAVASCRIPTS -->
<script src="../layout/scripts/jquery.min.js"></script>
<script src="../layout/scripts/jquery.backtotop.js"></script>
<script src="../layout/scripts/jquery.mobilemenu.js"></script>
<!-- IE9 Placeholder Support -->
<script src="../layout/scripts/jquery.placeholder.min.js"></script>
<!-- / IE9 Placeholder Support -->
    </form>
</body>
</html>

