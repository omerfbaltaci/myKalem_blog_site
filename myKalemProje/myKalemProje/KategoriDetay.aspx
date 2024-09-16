<%@ Page Title="" Language="C#" MasterPageFile="~/Kullanici.Master" AutoEventWireup="true" CodeBehind="KategoriDetay.aspx.cs" Inherits="DiziYorumProje.KategoriDetay" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="content-grids">
            <div class="col-md-8 content-main">
                <asp:Repeater ID="Repeater1" runat="server">
                    <ItemTemplate>
                        <div class="content-grid">
                            <div class="content-grid-info">
                                
                                <div class="post-info">
                                    <h4><a href="MakaleDetay.Aspx?MAKALEID=<%# Eval("MAKALEID")%>"><%# Eval("MAKALEBASLIK") %></a>  <%# Eval("MAKALETARIH")%></h4>
                                    <p><%# Eval("MAKALEICERIK")%></p>
                                    <a href="MakaleDetay.Aspx?MAKALEID=<%# Eval("MAKALEID")%>"><span></span>Devamını Oku</a>
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                </asp:Repeater>

            </div>
            <div class="col-md-4 content-right">
                <div class="recent">
                    <h3>En Son Makaleler</h3>
                    <ul>
                        <asp:Repeater ID="Repeater3" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%#Eval("MAKALEBASLIK")%></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="comments">
                    <h3>Son Yorumlar</h3>
                    <asp:Repeater ID="Repeater4" runat="server">
                        <ItemTemplate>
                            <ul>
                                <li><a href="#"><%#Eval("KULLANICIAD")%> - <%#Eval("YORUMICERIK")%></a></li>
                            </ul>
                        </ItemTemplate>
                    </asp:Repeater>
                </div>
                <div class="categories">
                    <h3>Kategoriler</h3>
                    <ul>
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="KategoriDetay.Aspx?KATEGORIID=<%# Eval("KATEGORIID")%>"><%# Eval("KATEGORIAD") %></a> </li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                <div class="clearfix"></div>
            </div>
            <div class="clearfix"></div>
        </div>
    </div>

</asp:Content>