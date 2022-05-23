<%@ Page Title="" Language="C#" MasterPageFile="~/Site/TreeSeller.Master" AutoEventWireup="true" CodeBehind="AdminTreeSell.aspx.cs" Inherits="a1.Site.AdminTreeSell" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
      .hiddencol
      {
        display: none;
        border: none;
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
            <asp:GridView ID="Grd_Trees" AutoGenerateColumns="false" AllowPaging="true"  OnPageIndexChanging="Grd_Trees_PageIndexChanging" Width="400%" PageSize="1" BackImageUrl="img/bg-img/1.jpg"  runat="server">
                <Columns>

                    <asp:BoundField DataField="Id"  ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="TreeTypeName" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="Name"  ItemStyle-CssClass="hiddencol" />
                    <asp:BoundField DataField="UnitPrice" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="UnitsInStock" ItemStyle-CssClass="hiddencol"  />
                    <asp:BoundField DataField="Photo" ItemStyle-CssClass="hiddencol" />

                    <asp:TemplateField>
                        <ItemTemplate>
                          <section>
                                <div class="single-product-area mb-50">
                                    <div class="card" style="width: 18rem;">
                                  <img src="img/bg-img/<%#Eval("Photo")%>" class="card-img-top" alt="...">

                                  <div class="card-body">
                                    <h5 class="card-title">Name: <%#Eval("Name")%></h5>
                                    <p class="card-text">Type: <%#Eval("TreeTypeName")%></p>
                                  </div>

                                  <ul class="list-group list-group-flush">
                                    <li class="list-group-item">UnitPrice: <%#Eval("UnitPrice")%></li>
                                    <li class="list-group-item">UnitsInStock: <%#Eval("UnitsInStock")%></li>
                                  </ul>

                                  <div class="card-body">
                                    <asp:LinkButton ID="Lnk_AddToCart" CssClass="add-to-cart-btn" CommandArgument='<%#Eval("Id")%>' OnCommand="Lnk_AddToCart_Command" runat="server">Add To Cart</asp:LinkButton>
                                  </div>
                                </div>
                               </div>

                              

                         </section>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
                <PagerStyle CssClass="btn-block btn-success" />
            </asp:GridView>
        </ContentTemplate>

    </asp:UpdatePanel>
</asp:Content>