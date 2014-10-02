<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Net Pay Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       <h1> Net Pay Calculator </h1>
        <br />
        Hourly Wage:<br />
        <asp:TextBox ID="Wage" runat="server"></asp:TextBox>
        <br />
        <br />
        Number of hours worked:<br />
        <asp:TextBox ID="Hours" runat="server"></asp:TextBox>
        <br />
        <br />
        Pre-tax deductions:<br />
        <asp:TextBox ID="PTDeduct" runat="server"></asp:TextBox>
        <br />
        <br />
        After-tax deductions:<br />
        <asp:TextBox ID="ATDeduct" runat="server"></asp:TextBox>
        <br />
        <br />
        Net Pay:<br />
        <asp:TextBox ID="NetPay" runat="server" Width="619px" BorderStyle="Double"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Calculate" runat="server" Text="Calculate" Font-Bold="True" Width="133px" />
       <br />
       <br />
        <asp:Button ID="Clear" runat="server" Text="Clear" Font-Bold="True" Width="133px" />
    
    </div>
    </form>
</body>
</html>
