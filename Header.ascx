<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="GitLogin.Header" %>
   <div>

       <table border="0" width="100%">
    <tr>
        <td align="center" colspan="3">&nbsp;</td>
    </tr>
    <tr>
        <td align="left" valign="middle">
             <asp:Label ID="lblUserInfo" runat="server"></asp:Label>
        </td>
        <td align="center" valign="middle">
                                        &nbsp;</td>
        <td align="right" valign="top" width="100px">
            <asp:LinkButton ID="lbLogout" runat="server" CausesValidation="False" Font-Size="Smaller" OnClick="lbLogout_Click">sign out</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td colspan="3">
            <hr style="color: gray; height: 2px" />
        </td>
    </tr>
    <tr>
        <td align="center" colspan="3" style="height: 28px" valign="middle">
        </td>
    </tr>
    </table>

       </div>
    
