<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Home.aspx.cs" Inherits="Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<style>
    .header {
        color: red;
        text-align: center;
        width: 40px;
        height: 25px;
        font-size: 18px;
        font-weight: bold;
    }
    .cell {
        color: grey;
        padding: 5px;
        border: 1px solid black !IMPORTANT;
        text-align: center;
        width: 40px;
        height: 25px;
    }

    .table {
        border: 1px solid black !IMPORTANT;
    }
    .sum{
        color: green;
        text-align: center;
        width: 40px;
        height: 25px;
        font-size: 18px;
        font-weight: bold;
    }
    .avg{
        color: orange;
        text-align: center;
        width: 40px;
        height: 25px;
        font-size: 18px;
        font-weight: bold;
    }
</style>

<head>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="row">
            Give a table value : 
            <asp:TextBox ID="txtNumber" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" Text="Submit" runat="server" OnClick="Button1_Click"></asp:Button>
        </div>
        <div>
            <asp:Table ID="MulitiplicationTable" runat="server"></asp:Table>
        </div>
        <asp:Label ID="Label1" runat="server"></asp:Label>
    </form>
</body>
</html>
