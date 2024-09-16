<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="iletisim.aspx.cs" Inherits="DiziYorumProje.iletisim" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  
<div class="contact-content">
	 <div class="container">
		     <div class="contact-info">
			 <h2>İletişim</h2>
			 <p>pvogvam</p>
			 <div class="contact-details">				 
			 <form runat="server">
                 <asp:TextBox ID="TextBox1" runat="server" placeholder="Ad Soyad" required="" Width="1117"></asp:TextBox>
				 <br>
                 <asp:TextBox ID="TextBox2" runat="server" placeholder="Mail" required="" Width="1117"></asp:TextBox>
				 <br>
                 <asp:TextBox ID="TextBox3" runat="server" placeholder="Telefon" required="" Width="1117"></asp:TextBox>
				 <br>
                 <asp:TextBox ID="TextBox4" runat="server" placeholder="Konu" required=""  Width="1117"></asp:TextBox>
				 <br>
                 <asp:TextBox ID="TextBox5" runat="server" placeholder="Mesajınız" required="" TextMode="MultiLine" Height="100"></asp:TextBox>
                 <asp:Button ID="Button1" runat="server" Text="Gönder" OnClick="Button1_Click" />
			 </form>
		  </div>
		  <div class="contact-details">
			 
			  <div class="clearfix"></div>
	     </div>		 


			 </div>
	 </div>
</asp:Content>
