<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PasswordChangeControl.ascx.cs" Inherits="a1.Controls.PasswordChangeControl" %>

<div class="auth">
        <div class="auth-container">
            <div class="auth-logo">

            </div>
            <div  class="auth-form">
                <h1>PasswordChange</h1>
                <div class="auth-input ">
                    <label for="NewPassword">
                        NewPassword
                    </label>       
                    <asp:TextBox ID="tbx_NewPassword" placeholder="NewPassword" runat="server"></asp:TextBox>
                 
                </div>
                 <div class="auth-input ">
                    <label for="PasswordVerification">
                        PasswordVerification
                    </label>       
                   <asp:TextBox ID="tbx_PasswordVerification" placeholder="PasswordVerification" runat="server"></asp:TextBox>
                 
                </div>
                 

                <asp:Button ID="btn_PasswordChange" OnClick="Btn_PasswordChange_Click" CssClass="auth-btn" runat="server" Text="PasswordChange" />
                <asp:Label ID="lbl_PasswordChange" runat="server" Text=""></asp:Label>
            </div>
            
        </div>
    </div>
