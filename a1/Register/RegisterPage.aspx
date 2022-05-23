<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="a1.Register.RegisterPage" %>

<%@ Register Src="~/Controls/RegisterControl.ascx" TagPrefix="uc1" TagName="RegisterControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="/Register/assets/style.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:RegisterControl runat="server" id="RegisterControl" />
        </div>
    </form>
</body>
</html>
