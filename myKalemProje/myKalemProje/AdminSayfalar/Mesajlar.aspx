<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Mesajlar.aspx.cs" Inherits="DiziYorumProje.AdminSayfalar.Mesajlar" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="table table-bordered">
        <tr>
            <th>ID</th>
            <th>AD SOYAD</th>
            <th>MAIL</th>
            <th>TELEFON</th>
            <th>KONU</th>
            <th>MESAJ</th>
            <th>SİL</th>
        </tr>
        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>
                <tr>
                    <td><%# Eval("MESAJID") %></td>
                    <td><%# Eval("ADSOYAD") %></td>
                    <td><%# Eval("MAIL") %></td>
                    <td><%# Eval("TELEFON") %></td>
                    <td><%# Eval("KONU") %></td>
                    <td><%# Eval("MESAJ") %></td>
                    <td>
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# "MesajSil.Aspx?MESAJID=" +Eval("MESAJID") %>' CssClass="btn btn-danger">Sil</asp:HyperLink></td>
                </tr>
            </ItemTemplate>
        </asp:Repeater>
    </table>
</asp:Content>
