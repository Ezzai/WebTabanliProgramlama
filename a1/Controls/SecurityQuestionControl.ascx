<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SecurityQuestionControl.ascx.cs" Inherits="a1.Controls.SecurityQuestionControl" %>

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
                    <asp:Label ID="lbl_Email" runat="server" Text=""></asp:Label>
                 
                </div>
                 <div class="auth-input ">
                    <label for="SecurityQuestion">
                        SecurityQuestion
                    </label>       
                    <asp:Label ID="lbl_SecurityQuestion" runat="server" Text=""></asp:Label>
                 
                </div>
                 <div class="auth-input ">
                    <label for="SecurityQuestionAnswer">
                       SecurityQuestionAnswer
                    </label>       
                    <asp:TextBox ID="tbx_SecurityQuestionAnswer" placeholder="SecurityQuestionAnswer" runat="server"></asp:TextBox>
                 
                </div>

                <asp:Button ID="btn_SecurityQuestion" OnClick="btn_SecurityQuestion_Click" CssClass="auth-btn" runat="server" Text="SecurityQuestion" />
                <asp:Label ID="lbl_SecurityQuestionControl" runat="server" Text=""></asp:Label>
            </div>
            
        </div>
    </div>
