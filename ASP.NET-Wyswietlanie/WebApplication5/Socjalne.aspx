﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Socjalne.aspx.cs" Inherits="WebApplication5.Socjalne" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server" link href = "bootstrap-superhero.css" rel="stylesheet" type="text/css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title> Sprwadź czy otrzymałeś stypendium socjalne</title>

    <style type="text/css">
        #form1 {
            height: 181px;
        }
    </style>
</head>
    <body style="height: 183px">
    <form id="form3" runat="server">

        <div>
            <h1> Wpisz swój numer indeksu, aby sprawdzić czy dostałeś stypendium </h1>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
   
               <style>
body {
  background-image: url('serowiec.png');
  background-repeat: no-repeat;
  background-attachment: fixed;
  background-size: 100% 100%;
}
</style>

            <asp:Button ID="Button1" runat="server" Text="Sprawdź" OnClick="Button1_Click" />


              <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns = "False" BackColor="White"  HorizontalAlign="Center" BorderColor="Black" BorderStyle="None" BorderWidth="1px" CellPadding="4"> 
                <columns>
                    <asp:BoundField DataField ="Department" HeaderText ="Wydział" />
                    <asp:BoundField DataField ="Index_Number" HeaderText ="Nr Albumu" />
                    <asp:BoundField DataField ="Year" HeaderText ="Rok" />
                    <asp:BoundField DataField ="Semester" HeaderText ="Semestr" />


                    </columns>

                  <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="Green" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="Green" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
            <asp:GridView ID="GridView5" runat="server" AutoGenerateColumns = "False"  HorizontalAlign="Center" BackColor="White" BorderColor="Black" BorderStyle="None" BorderWidth="1px" CellPadding="4" > 
                <columns>
                    <asp:BoundField DataField ="Department" HeaderText ="Wydział" />
                    <asp:BoundField DataField ="Index_Number" HeaderText ="Nr Albumu" />
                    <asp:BoundField DataField ="Year" HeaderText ="Rok" />
                    <asp:BoundField DataField ="Semester" HeaderText ="Semestr" />
                    
                </columns>
                <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
                <PagerStyle BackColor="Red" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="Red" ForeColor="#330099" />
                <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                <SortedAscendingCellStyle BackColor="#FEFCEB" />
                <SortedAscendingHeaderStyle BackColor="#AF0101" />
                <SortedDescendingCellStyle BackColor="#F6F0C0" />
                <SortedDescendingHeaderStyle BackColor="#7E0000" />
            </asp:GridView>
</div>

        </form>
</body>
</html>
