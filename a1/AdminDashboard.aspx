<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="AdminDashboard.aspx.cs" Inherits="a1.AdminDashboard" %>

<asp:Content ID="Content2" ContentPlaceHolderID="Trees" runat="server">
     <div class="row">
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-green green">
                            <div class="panel-left pull-left green">
                                <i class="fa fa-bar-chart-o fa-5x"></i>
                                
                            </div>
                            <div class="panel-right pull-right">
								<h3>
                                    <asp:Label ID="lbl_Trees" runat="server" Text=""></asp:Label>
								</h3>
                               <strong> Trees</strong>
                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-blue blue">
                              <div class="panel-left pull-left blue">
                                <i class="fa fa-shopping-cart fa-5x"></i>
								</div>
                                
                            <div class="panel-right pull-right">
							<h3>
                                <asp:Label ID="lbl_TreeOrders" runat="server" Text=""></asp:Label></h3>
                               <strong> TreeOrders</strong>

                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-red red">
                            <div class="panel-left pull-left red">
                                <i class="fa fa fa-comments fa-5x"></i>
                               
                            </div>
                            <div class="panel-right pull-right">
							 <h3>
                                 <asp:Label ID="lbl_Customers" runat="server" Text=""></asp:Label></h3>
                               <strong> Customers </strong>

                            </div>
                        </div>
                    </div>
                    <div class="col-md-3 col-sm-12 col-xs-12">
                        <div class="panel panel-primary text-center no-boder bg-color-brown brown">
                            <div class="panel-left pull-left brown">
                                <i class="fa fa-users fa-5x"></i>
                                
                            </div>
                            <div class="panel-right pull-right">
							<h3>
                                <asp:Label ID="lbl_TreeTypes" runat="server" Text=""></asp:Label> </h3>
                             <strong>TreeTypes</strong>

                            </div>
                        </div>
                    </div>
                </div>
				
		
		<div class="row">
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>Trees</h4>
						<div class="easypiechart" id="easypiechart-blue" data-percent="<%=TreesPersent()%>" ><span class="percent"><%=TreesPersent()%>%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>TreeOrders</h4>
						<div class="easypiechart" id="easypiechart-orange" data-percent="<%=TreeOrdersPersent()%>" ><span class="percent"><%=TreeOrdersPersent()%>%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>Customers</h4>
						<div class="easypiechart" id="easypiechart-teal" data-percent="<%=CustomersPersent()%>" ><span class="percent"><%=CustomersPersent()%>%</span>
						</div>
					</div>
				</div>
			</div>
			<div class="col-xs-6 col-md-3">
				<div class="panel panel-default">
					<div class="panel-body easypiechart-panel">
						<h4>TreeTypes</h4>
						<div class="easypiechart" id="easypiechart-red" data-percent="<%= TreeTypesPersent() %>" ><span class="percent"><%= TreeTypesPersent() %>%</span>
						</div>
					</div>
				</div>
			</div>
		</div><!--/.row-->
    
                <div class="row">
                   
                    <div class="col-md-8 col-sm-12 col-xs-12">

                        <div class="panel panel-default">
                            <div class="panel-heading">
                                Responsive Table Example
                            </div> 
                            <div class="panel-body">
                                <div class="table-responsive">
                                    <table class="table table-striped table-bordered table-hover">
                                        <thead>
                                            <tr>
                                                <th>Id</th>
                                                <th>TreeTypeId</th>
                                                 <th>UnitPrice</th>
                                                <th>UnitsInStock</th>
                                                 <th>Name</th>


                                            </tr>
                                        </thead>
                                        <tbody>
                                            <%foreach (var tree in TreesGetAll()){ %>
                                            <tr>
                                                <td><%= tree.Id %></td>
                                                <td><%= tree.TreeTypeId %></td>
                                                <td><%= tree.UnitPrice %></td>
                                                <td><%= tree.UnitsInStock %></td>
                                                <td><%= tree.Name %></td>

                                            </tr>
                                            <% } %>
                                        </tbody>
                                     </table>
                                    <table class="table table-striped table-bordered table-hover">
                                        <thead>
                                            <tr>
                                                <th>Id</th>
                                                 <th>Name</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            <%foreach (var treeType in TreeTypesGetAll()){ %>
                                            <tr>
                                                <td><%= treeType.Id %></td>
                                                <td><%= treeType.Name %></td>

                                            </tr>
                                            <% } %>
                                        </tbody>
                                     </table>
                                </div>
                            </div>
                        </div>
        </div>
     </div>
</asp:Content>
