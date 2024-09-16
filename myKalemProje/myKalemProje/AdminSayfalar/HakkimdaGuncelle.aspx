<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="HakkimdaGuncelle.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.HakkimdaGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server" class="form-group">
        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" placeholder="Hakkımda"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" Text="Kaydet" CssClass="btn btn-success" OnClick="Button1_Click" />
    </form>
</asp:Content>
