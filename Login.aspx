<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="GitLogin.Login" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login-page</title>
    <link href="css/style-login.css" rel="stylesheet" />
</head>
<body>
         <form id="form1" runat="server">
    <div class="login-popup">
  	 <div class="box">
  	 	 <div class="img-area">
  	 	 	<div class="img">
  	 	 	</div>
  	 	 	<h1>"YOUR LOGO"</h1>
  	 	 </div>
  	 	 <div class="form">
  	 	 	<div class="close">&times;</div>
  	 	 	<h1>Login form ...</h1>
  	 	 	<form>
  	 	 		<div class="form-group">
                        <asp:TextBox ID="txtUserName" runat="server" placeholder="User name..." class="form-control"></asp:TextBox>
  	 	 		        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtUserName" 
                            Display="None" ErrorMessage="Required field (User name)" ForeColor="Red"></asp:RequiredFieldValidator>
  	 	 		</div>
  	 	 		<div class="form-group">
                    <asp:TextBox ID="txtPassword" runat="server" placeholder="Password..." class="form-control" TextMode="Password"></asp:TextBox>
  	 	 		    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPassword" 
                        Display="None" ErrorMessage="Required field (Password)" ForeColor="Red"></asp:RequiredFieldValidator>
                    <br />
                    <asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
  	 	 		</div>
                    <asp:Button ID="btnPrijava" runat="server" Text="LOGIN" class="btn" OnClick="btnPrijava_Click" />
  	 	 	<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    </form>
  	 	 </div>
  	 </div>
  </div>
             <script src="js/script.js"></script>
    </form>
	</body>
</html>
