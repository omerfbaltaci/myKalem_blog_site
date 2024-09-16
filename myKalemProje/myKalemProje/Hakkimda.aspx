<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="Hakkimda.aspx.cs" Inherits="DiziYorumProje.Hakkimda" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <div class="about-section">
            <div class="about-grid">
                <h3 style="color: #fff">HAKKIMIZDA</h3>
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <p style="color:#808080"><%# Eval("ACIKLAMA") %></p>
                    </ItemTemplate>
                </asp:Repeater>
            </div>
        </div>
    </div>
</asp:Content>
