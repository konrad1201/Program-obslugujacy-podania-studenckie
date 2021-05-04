<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StypendiumRektora.aspx.cs" Inherits="WebApplication5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Listy Rankingowe Stypendium Rektora</title>
    <style type="text/css">
        #form1 {
            height: 181px;
        }
    </style>
</head>
<body style="height: 183px">
    <form id="form1" runat="server">
        <div>
            <h1> Wpisz numer wydziału dla którego chcesz wygenerować listy. </h1>
               <p> <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                   </p>
                
           <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns = "false"> 
                <columns>
                    <asp:BoundField DataField ="Department" HeaderText ="Wydział" />
                    <asp:BoundField DataField ="Index_Number" HeaderText ="Nr Albumu" />
                    <asp:BoundField DataField ="Year" HeaderText ="Rok" />
                    <asp:BoundField DataField ="Semester" HeaderText ="Semestr" />
                    <asp:BoundField DataField ="Average" HeaderText ="Średnia" />                   
                </columns>
            </asp:GridView>
        </div>
        
        
        
    </form>
</body>
</html>
