<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="a1.Login.LoginPage" %>

<%@ Register Src="~/Controls/LoginControl.ascx" TagPrefix="uc1" TagName="LoginControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
     <link rel="stylesheet" href="/Login/assets/style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:LoginControl runat="server" ID="LoginControl" />
        </div>
    </form>
</body>
</html>
