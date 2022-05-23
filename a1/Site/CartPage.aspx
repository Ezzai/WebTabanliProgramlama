<%@ Page Title="" Language="C#" MasterPageFile="~/Site/TreeSeller.Master" AutoEventWireup="true" CodeBehind="CartPage.aspx.cs" Inherits="a1.Site.CartPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      <style type="text/css">
      .hiddencol
      {
        display: none;
      }
    </style>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="MyTreeTypes" runat="server">

<% foreach (var treeType in GetAllTreeTypes()){ %>
   <div class="custom-control custom-checkbox d-flex align-items-center mb-2">
       <label class="custom-control-label"><%=treeType.Name%> <span class="text-muted"></span></label>
   </div>
<%  } %>
                                    
</asp:Content>


<asp:Content ID="Content3" ContentPlaceHolderID="MyTrees" runat="server">

    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">

        <ContentTemplate>
            <asp:GridView ID="Grd_Cart" AutoGenerateColumns="false" AllowPaging="true"  CssClass="cart-area section-padding-0-100 clearfix" Width="300%" BackImageUrl="img/bg-img/1.jpg"  runat="server">
                <Columns>

                    <asp:BoundField DataField="TreeId" ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="TreeName" ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="TreeUnitPrice" ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="Quantity" ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="Photo" ItemStyle-CssClass="hiddencol"/>

                    <asp:TemplateField>
                        <ItemTemplate>
                           <section>
                                <div class="single-product-area mb-100">
                                    <div class="card" style="width: 18rem;">
                                      <img src="/Site/img/bg-img/<%#Eval("Photo")%>" class="card-img-top" alt="...">

                                      <div class="card-body">
                                        <h5 class="card-title">Name: <%#Eval("TreeName")%></h5>
                                      </div>

                                      <ul class="list-group list-group-flush">
                                        <li class="list-group-item">UnitPrice: <%#Eval("TreeUnitPrice")%></li>
                                        <li class="list-group-item">UnitsInStock: <%#Eval("Quantity")%></li>
                                      </ul>

                                      <div class="card-body">
                                        <asp:LinkButton ID="Lnk_DeleteToCart" CommandArgument='<%#Eval("TreeId")%>' runat="server" OnCommand="Lnk_DeleteToCart_Command" > Delete To Cart <a href="#"><i class="icon_close"></i></a></asp:LinkButton>
                                      </div>
                                </div>
                               </div>

                         </section>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div>
                                <!-- Cart Totals -->
                                <div class="col-12 col-lg-6  ">
                                    <div class="cart-totals-area mt-70">
                                        <h5 class="title--">Cart Total</h5>
                                        <div class="total d-flex justify-content-between ">
                                            <h5>Total</h5>
                                            <asp:Label ID="lbl_Total" runat="server" Text=""></asp:Label>
                                        </div>
                                        <div class="checkout-btn">
                                            <asp:LinkButton ID="Lnk_Order" CssClass="btn alazea-btn w-200" OnClick="Lnk_Order_Click" runat="server">PROCEED TO CHECKOUT</asp:LinkButton>
                                        </div>
                                    </div>
                                </div>

                            </div>
        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>
