<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmBingoGame.aspx.cs" Inherits="katapol_project.FrmBingoGame" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BingoGame</title>

    <script src="js/js.js" type="text/javascript"></script>
</head>
<body>
    <form id="FrmBingoGame" runat="server">
    <div>
        <br />
        <br />
        Input : <asp:TextBox ID="txtInput" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" OnClientClick="return CheckInputBingo()"/>
            
        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        <%--<table>
            <tr>
                <td id="t1" width="50px" onclick="ClickNumber('t1')">
                    1</td>
                <td width="50px">
                    
                    2</td>
                <td width="50px">
                    
                    3</td>
                <td width="50px">
                    
                    4</td>
                <td width="50px">
                    
                    5</td>
            </tr>
            <tr>
                <td width="50px">
                    
                    6</td>
                <td width="50px">
                    
                    7</td>
                <td width="50px">
                    
                    8</td>
                <td width="50px">
                    
                    9</td>
                <td width="50px">
                    
                    10</td>
            </tr>
            <tr>
                <td width="50px">
                    
                    11</td>
                <td width="50px">
                    
                    12</td>
                <td width="50px">
                    
                    13</td>
                <td width="50px">
                    
                    14</td>
                <td width="50px">
                    
                    15</td>
            </tr>
            <tr>
                <td width="50px">
                    
                    16</td>
                <td width="50px">
                    
                    17</td>
                <td width="50px">
                    
                    18</td>
                <td width="50px">
                    
                    19</td>
                <td width="50px">
                    
                    20</td>
            </tr>
            <tr>
                <td width="50px">
                    
                    21</td>
                <td width="50px">
                    
                    22</td>
                <td width="50px">
                    
                    23</td>
                <td width="50px">
                    
                    24</td>
                <td width="50px">
                    
                    25</td>
            </tr>
        </table>--%>
    </div>
    </form>
</body>
</html>
