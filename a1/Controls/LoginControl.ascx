<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginControl.ascx.cs" Inherits="a1.Controls.LoginControl" %>

<div class="auth">
        <div class="auth-container">
            <div class="auth-logo">

            </div>
            <div  class="auth-form">
                <h1>Login</h1>
                <div class="auth-input ">
                    <label for="email">
                        E-Mail
                    </label>       
                    <asp:TextBox ID="tbx_Email" placeholder="Email" runat="server"></asp:TextBox>
                 
                </div>
                <div class="auth-input">
                    <label for="password">
                        Password
                    </label>
                    <asp:TextBox ID="tbx_Password" placeholder="Password" runat="server"></asp:TextBox>
                </div>
                 <asp:LinkButton ID="lnk_ForgotPassword" OnClick="lnk_ForgotPassword_Click" CssClass="auth-reset" runat="server">ForgotPassword</asp:LinkButton>

                <asp:Button ID="btn_Login" OnClick="btn_Login_Click" CssClass="auth-btn" runat="server" Text="Login" />
                <asp:Label ID="lbl_Login" runat="server" Text=""></asp:Label>
            </div>
            <div class="auth-bottom">
                Don't have an account yet? <asp:LinkButton ID="lnk_Register" OnClick="lnk_Register_Click" CssClass="auth-reset" runat="server">Create Now</asp:LinkButton>
            </div>
        </div>
    </div>
