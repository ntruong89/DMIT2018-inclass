﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="ReservationBySpecialEvent.aspx.cs" Inherits="ReservationBySpecialEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <asp:Label ID="Label1" runat="server" Text="Search"></asp:Label>
    <asp:DropDownList ID="DropDownList1" runat="server">
    </asp:DropDownList>
    <asp:LinkButton ID="LinkButton1" runat="server">Reservations</asp:LinkButton>
    <asp:GridView ID="GridView1" runat="server">
    </asp:GridView>
</asp:Content>

