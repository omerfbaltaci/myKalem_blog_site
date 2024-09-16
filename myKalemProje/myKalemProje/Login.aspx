<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DiziYorumProje.Login" %>

<!--A Design by W3layouts
   Author: W3layout
   Author URL: http://w3layouts.com
   License: Creative Commons Attribution 3.0 Unported
   License URL: http://creativecommons.org/licenses/by/3.0/
   -->
<!DOCTYPE html>
<html lang="en">
   <head>
      <title>ADMIN GIRIS</title>
      <!-- Meta tags -->
      <meta name="viewport" content="width=device-width, initial-scale=1" />
      <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
      <meta name="keywords" content="Gaze Sign up & login Form Responsive Widget, Audio and Video players, Login Form Web Template, Flat Pricing Tables, Flat Drop-Downs, Sign-Up Web Templates, Flat Web Templates, Login Sign-up Responsive Web Template, Smartphone Compatible Web Template, Free Web Designs for Nokia, Samsung, LG, Sony Ericsson, Motorola Web Design"
         />
      <script>
         addEventListener("load", function () { setTimeout(hideURLbar, 0); }, false); function hideURLbar() { window.scrollTo(0, 1); }
      </script>
      <!-- Meta tags -->
      <!--stylesheets-->
       <link href="web/css/bootstrap.css" rel="stylesheet" />
      <link href="/web2/css/styles.css" rel='stylesheet' type='text/css' media="all">
      <!--//style sheet end here-->
      <link href="//fonts.googleapis.com/css?family=Source+Sans+Pro:400,600,700" rel="stylesheet">
   </head>
   <body>
      <div class="mid-class">
         <div class="art-right-w3ls">
            
           <div class="container">
	<div class="screen">
		<div class="screen__content">
			<form action="#" method="post" runat="server" class="login">
				<div class="login__field">
					<i class="login__icon fas fa-user"></i>
					 <asp:TextBox ID="TextBox1" runat="server"  class="login__input" placeholder="Kullanıcı adınız"></asp:TextBox>
				</div>
				<div class="login__field">
					<i class="login__icon fas fa-lock"></i>
				<asp:TextBox ID="TextBox2" runat="server" class="login__input" placeholder="Şifreniz" TextMode="Password"></asp:TextBox>
					
				</div>
				 <div class="btnn">
                   <asp:Button ID="Button1" runat="server" Text="Giriş Yap" CssClass="button login__submit" OnClick="Button1_Click" />
               </div>			
			</form>
			<div class="social-login">
				<h3>Admin Giris</h3>			
			</div>
		</div>
		<div class="screen__background">
			<span class="screen__background__shape screen__background__shape4"></span>
			<span class="screen__background__shape screen__background__shape3"></span>		
			<span class="screen__background__shape screen__background__shape2"></span>
			<span class="screen__background__shape screen__background__shape1"></span>
		</div>		
	</div>
</div>
           
       
      </div>
      <footer class="bottem-wthree-footer">
         
      </footer>
   </body>
</html>
