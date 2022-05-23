<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PasswordChange.aspx.cs" Inherits="a1.ForgotPassword.PasswordChange" %>

<%@ Register Src="~/Controls/PasswordChangeControl.ascx" TagPrefix="uc1" TagName="PasswordChangeControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="/Register/assets/style.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:PasswordChangeControl runat="server" id="PasswordChangeControl" />
        </div>
    </form>
</body>
</html>
