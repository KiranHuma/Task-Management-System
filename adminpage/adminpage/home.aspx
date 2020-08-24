<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="adminpage.WebForm1" %>

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
<title>Home</title>
<meta charset="utf-8">
<meta name="viewport" content="width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=no">
<link href="layout/styles/layout.css" rel="stylesheet" type="text/css" media="all">
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
        <h1><a href="index.html">Task Managment</a></h1>
      
   
      <p>&nbsp;<asp:Label ID="Label2" runat="server" style="font-size: x-large" 
        Text="Total employees"></asp:Label>
&nbsp;&nbsp;&nbsp; are &nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label" style="font-size: large"></asp:Label>
    </h3>
<p>&nbsp;</p></p>

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
      <li class="active"><a href="home.aspx">Home</a></li>
      <li><a class="drop" href="#">Users Details</a>
        <ul>
          <li><a href="#reg" >Register</a></li>
          <li><a href="taskdisplay.aspx">Display User Task</a></li>
          <li><a href="displayattendnce.aspx">Display User Attendance</a></li>
         
        </ul>
      </li>
      
       <li><a href="latecomerss.aspx">LateComers</a></li>
        <li><a href="edituser.aspx">Edit Details</a></li>
      <li><a href="#">Reports</a></li>
      <li><a href="#">Account Settings</a></li>
      <li><a href="#">Contact Us</a></li>
      <li><a href="#">About</a></li>
    </ul>
    <!-- ################################################################################################ -->
  </nav>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper overlay bgded" 
     style="background-image:url('images/attendance.png'); background-repeat: no-repeat;">
  <section id="pageintro" class="hoc clear"> 
    <!-- ################################################################################################ -->
   <a id="reg"></a>
    <h2 class="heading">Create New User</h2>
    <p>
 
 <asp:TextBox  ID="iid" runat="server" placeholder="Type ID" height="33px" 
        width="220px" ForeColor="Black" ></asp:TextBox>
 <asp:TextBox ID="login" runat="server" placeholder="Type Username" 
        autocomplete="off" Height="33px" width="220px" ForeColor="Black"></asp:TextBox>
 <asp:TextBox ID="pwd" runat="server" placeholder="password" autocomplete="off" 
        height="33px" width="220px" ForeColor="Black"></asp:TextBox>
<asp:TextBox ID="nam" runat="server" placeholder="Type designation" 
        autocomplete="off" height="33px" width="220px" ForeColor="Black"></asp:TextBox>
<asp:TextBox ID="age" runat="server" placeholder="age" autocomplete="off" 
        height="33px" width="220px" ForeColor="Black"></asp:TextBox>
<asp:TextBox ID="sex" runat="server" placeholder="Gender" height="33px" 
        width="220px" ForeColor="Black"  ></asp:TextBox>
<asp:TextBox ID="contactno" runat="server" placeholder="Contact number" 
        autocomplete="off" height="33px" width="220px" ForeColor="Black" ></asp:TextBox>
 <asp:TextBox ID="userrtype" runat="server" height="33px" 
        width="220px" ForeColor="Black">2 for managr and 3 for user</asp:TextBox> 
<asp:Button ID="Button2" runat="server"  
       class="btn btn-primary btn-block btn-large" onclick="Button1_Click" Text="Save" 
       Width="148px" />
 
 </p>
    <footer><a class="btn" href="#">Down</a></footer>
    <!-- ################################################################################################ -->
  </section>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row3">
  <main class="container hoc clear"> 
    <!-- main body -->
    <!-- ################################################################################################ -->
 
    <hr class="btmspace-80">
  
   
    <!-- ################################################################################################ -->
    <!-- / main body -->
    <div class="clear"></div>
  </main>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper flex-wrapper overlay bgded" style="background-image:url('images/demo/backgrounds/02.png')">
  <div id="testimonials" class="hoc flexslider clear"> 
    <!-- ################################################################################################ -->
    <ul class="slides clear">
      <li>
        <div class="flex-content">
          <figure><img class="circle btmspace-15" src="images/images.jpg" alt="">
            <figcaption><strong>Name</strong><br>
              <em>Position, Company Name</em></figcaption>
          </figure>
          <blockquote>Success is not final, failure is not fatal: it is the courage to continue that counts. 
        </div>
      </li>
      <li>
        <div class="flex-content">
          <figure><img class="circle btmspace-15" src="images/business_user.png" alt="">
            <figcaption><strong>J.Doe</strong><br>
              <em>Position, Company Name</em></figcaption>
          </figure>
          <blockquote> There are no secrets to success. It is the result of preparation, hard work, and learning from failure. </blockquote>

        </div>
      </li>
      <li>
        <div class="flex-content">
          <figure><img class="circle btmspace-15" src="images/business_user.png" alt="">
            <figcaption><strong>J.Doe</strong><br>
              <em>Position, Company Name</em></figcaption>
          </figure>
          <blockquote>Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful. </blockquote>

        </div>
      </li>
    </ul>
    <!-- ################################################################################################ -->
  </div>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper flex-wrapper row3">
  <section id="latest" class="hoc flexslider"> 
    <!-- ################################################################################################ -->
    <div class="center btmspace-50">
      <h2 class="heading">Success</h2>
      <p><span style="color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
          Success is no accident. It is hard work, perseverance, learning, studying, 
          sacrifice and most of all, love of what you are doing or learning to do.<span 
              class="Apple-converted-space">&nbsp;</span></span><br 
              style="box-sizing: border-box; color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255);" />
          <span style="color: rgb(51, 51, 51); font-family: &quot;Helvetica Neue&quot;, Helvetica, Arial, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: normal; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); display: inline !important; float: none;">
          <span class="Apple-converted-space">&nbsp;</span></span></p>
    </div>
    <!-- ################################################################################################ -->
    <ul class="carousel-items">
      <li><a href="#">
        <figure><img src="images/business_user.png" alt="">
          <figcaption>
            <time datetime="2045-04-06">6<sup>th</sup> April</time>
            <h2 class="heading">Latest</h2>
            <p>Success is no accident. It is hard work, perseverance, learning, studying, 
          sacrifice and most of all, love of what you are doing or learning to do.&hellip;</p>
          </figcaption>
        </figure>
        </a></li>
      <li><a href="#">
        <figure><img src="images/attendance.png" alt="">
          <figcaption>
            <time datetime="2017-04-06">6<sup>th</sup> April</time>
            <h2 class="heading">Latest</h2>
            <p>Success is not the key to happiness. Happiness is the key to success. If you love what you are doing, you will be successful. &hellip;</p>
          </figcaption>
        </figure>
        </a></li>
      <li><a href="#">
        <figure><img src="images/images.jpg" alt="">
          <figcaption>
            <time datetime="2017-04-06">6<sup>th</sup> April</time>
            <h2 class="heading">Latest</h2>
            
            <p>Success is not the key to happiness. Happiness is the key to success.&hellip;</p>
          </figcaption>
        </figure>
        </a></li>
      <li><a href="#">
        <figure><img src="images/images.jpg" alt="">
          <figcaption>
            <time datetime="2017-04-06">6<sup>th</sup> April</time>
            <h2 class="heading">Latest</h2>
            <p>Happiness is the key to success&hellip;</p>
          </figcaption>
        </figure>
        </a></li>
    </ul>
    <!-- ################################################################################################ -->
  </section>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row0">
  <section id="clients" class="hoc clear"> 
    <!-- ################################################################################################ -->
    <h2 class="center btmspace-30">More</h2>
    <ul class="nospace group">
      <li class="one_quarter first"><a href="#"><img src="images/images.jpg" alt=""></a></li>
      <li class="one_quarter"><a href="#"><img src="images/images.jpg" alt=""></a></li>
      <li class="one_quarter"><a href="#"><img src="images/images.jpg" alt=""></a></li>
      <li class="one_quarter"><a href="#"><img src="images/images.jpg" alt=""></a></li>
    </ul>
    <!-- ################################################################################################ -->
  </section>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<div class="wrapper row4">
  <footer id="footer" class="hoc clear"> 
    <!-- ################################################################################################ -->
   
    <div class="one_quarter">
      <h6 class="title">Important</h6>
      <article>
        <h2 class="nospace font-x1"><a href="#">Note</a></h2>
        <time class="smallfont" datetime="2045-04-06">Friday, 6<sup>th</sup> April 2017</time>
        <p>Contact us if any issue using this appp
      </article>
    </div>
    <div class="one_quarter">
      <h6 class="title">Contact</h6>
      <form class="btmspace-30" method="post" action="#">
        <fieldset>
          <legend>Newsletter:</legend>
          <input class="btmspace-15" type="text" value="" placeholder="Email">
          <button type="submit" value="submit">Submit</button>
        </fieldset>
      </form>
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
    
    <!-- ################################################################################################ -->
  </div>
</div>
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<!-- ################################################################################################ -->
<a id="backtotop" href="#top"><i class="fa fa-chevron-up"></i></a>
<!-- JAVASCRIPTS -->
<script src="layout/scripts/jquery.min.js"></script>
<script src="layout/scripts/jquery.backtotop.js"></script>
<script src="layout/scripts/jquery.mobilemenu.js"></script>
<!-- IE9 Placeholder Support -->
<script src="layout/scripts/jquery.placeholder.min.js"></script>
<!-- / IE9 Placeholder Support -->
<!-- Homepage specific -->
<script src="layout/scripts/jquery.flexslider-min.js"></script>
</form>
</body>
</html>