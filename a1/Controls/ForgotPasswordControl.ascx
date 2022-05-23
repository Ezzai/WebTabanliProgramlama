<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ForgotPasswordControl.ascx.cs" Inherits="a1.Controls.ForgotPasswordControl" %>


<div class="auth">
        <div class="auth-container">
            <div class="auth-logo">

            </div>
            <div  class="auth-form">
                <h1>ForgotPassword</h1>
                <div class="auth-input ">
                    <label for="email">
                        E-Mail
                    </label>       
                    <asp:TextBox ID="tbx_Email" placeholder="Email" runat="server"></asp:TextBox>
                 
                </div>

                <asp:Button ID="btn_ForgotPassword" OnClick="Btn_ForgotPassword_Click" CssClass="auth-btn" runat="server" Text="ForgotPassword" />
                <asp:Label ID="lbl_ForgotPassword" runat="server" Text=""></asp:Label>
            </div>
            
        </div>
    </div>