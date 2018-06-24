<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmFormulaCalculation.aspx.cs" Inherits="katapol_project.FrmFormulaCalculation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>FormulaCalculation</title>

    <script src="js/js.js" type="text/javascript"></script>
</head>
<body>
    <form id="FrmFormulaCalculation" runat="server">
        <div>
            Input : <asp:TextBox ID="txtInputCalculation" runat="server" onblur="ReplaceSpace()"></asp:TextBox>
            
            <br />
            <br />
            
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
                onclick="btnSubmit_Click" OnClientClick="return CheckInputCalculation();"/>

            <br />
            <br />
            
            Result : <asp:Label ID="lblOutput" runat="server" Text="Label"></asp:Label>
        </div>
    </form>
</body>
</html>
