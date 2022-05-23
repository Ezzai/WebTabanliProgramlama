<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RegisterControl.ascx.cs" Inherits="a1.Controls.RegisterControl" %>

<div class="auth">
        <div class="auth-container">
            <div class="auth-logo">

            </div>
            <div  class="auth-form">
                <h1>Register</h1>
                <div class="auth-input ">
                    <label for="FirstName">
                        FirstName
                    </label>       
                    <asp:TextBox ID="tbx_FirstName" placeholder="FirstName" runat="server"></asp:TextBox>
                 
                </div>
                <div class="auth-input ">
                    <label for="LastName">
                        LastName
                    </label>       
                    <asp:TextBox ID="tbx_LastName" placeholder="LastName" runat="server"></asp:TextBox>
                 
                </div>
                <div class="auth-input ">
                    <label for="email">
                        E-Mail
                    </label>       
                    <asp:TextBox ID="tbx_Email" placeholder="Email" runat="server"></asp:TextBox>
                 
                </div>

                <div class="auth-input ">
                    <label for="Password">
                        Password
                    </label>       
                    <asp:TextBox ID="tbx_Password" placeholder="Password" runat="server"></asp:TextBox>
                 
                </div>

                <div class="auth-input ">
                    <label for="City">
                        City
                    </label>       
                    <asp:TextBox ID="tbx_City" placeholder="City" runat="server"></asp:TextBox>
                 
                </div>

                <div class="auth-input ">
                    <label for="Address">
                        Address
                    </label>       
                    <asp:TextBox ID="tbx_Address" placeholder="Address" runat="server"></asp:TextBox>
                 
                </div>

                <div class="auth-input ">
                    <label for="Phone">
                        Phone
                    </label>       
                    <asp:TextBox ID="tbx_Phone" placeholder="Phone" runat="server"></asp:TextBox>
                 
                </div>
                
                <div class="auth-input ">
                    <label for="SecurityQuestion">
                       SecurityQuestion
                    </label>       
                    <asp:DropDownList ID="DropDown_SecurityQuestions" runat="server"></asp:DropDownList>
                </div>
                <div class="auth-input">
                    <label for="SecurityQuestionAnswer">
                       SecurityQuestionAnswer
                    </label>
                    <asp:TextBox ID="tbx_SecurityQuestionAnswer" placeholder="SecurityQuestionAnswer" runat="server"></asp:TextBox>
                </div>
                

                <asp:Button ID="btn_Register" OnClick="Btn_Register_Click" CssClass="auth-btn" runat="server" Text="Register" />
                <asp:Label ID="lbl_Register" runat="server" Text=""></asp:Label>
            </div>
          
        </div>
    </div>

