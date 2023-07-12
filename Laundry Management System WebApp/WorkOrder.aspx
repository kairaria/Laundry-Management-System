<%@ Page Title="WorkOrder" Language="vb" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="WorkOrder.aspx.vb" Inherits="Laundry_Management_System_WebApp.frmWorkOrder" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
	<div class="row" style="padding-top:30px;padding-bottom:30px;padding-left:30px;padding-right:30px; background:MediumAquamarine;" >		
			<p>
				<asp:TextBox ID="txtSearchCustomer" runat="server" style="margin-right:50px" Width="800px">Search by Name or Phone Number</asp:TextBox>
				<asp:Button ID="btnSearchCustomer" runat="server" style="margin-right:100px" BorderStyle="None" Height="30px" Text="Search" Width="154px" />
				<asp:CheckBox ID="cbxAddNewCust" runat="server" AutoPostBack="True" Text="Add New Customer" />				
			</p>				
			<p>
				<asp:Label ID="lblCustName" runat="server" style="margin-right:30px" Text="Customer Name" Font-Bold="True"></asp:Label>
				<asp:TextBox ID="txtCustName" runat="server" style="margin-right:30px" Width="400px"></asp:TextBox>
				<asp:Label ID="lblPhoneNumber" runat="server" style="margin-right:30px" Text="Phone Number" Font-Bold="True"></asp:Label>
				<asp:TextBox ID="txtCustPhoneNum" runat="server" style="margin-right:30px" Width="400px" TextMode="Phone"></asp:TextBox>
				<asp:Button ID="btnAddCustomer" runat="server" style="margin-left:30px" BorderStyle="None" Height="30px" Text="Add" Width="150px" />
			</p>		
	</div>
	<div class="container" style="padding-top:30px;padding-bottom:30px; min-height: 200px; max-height: 200px; overflow-y:inherit; background:#000000" >		
			<p>
				<asp:GridView ID="dgvWorkOrderItems" runat="server" HorizontalAlign="Center" ForeColor="White">
				</asp:GridView>
				</p>		
	</div>
	<div class="container" style="padding-top:30px;padding-bottom:30px;padding-left:30px;padding-right:30px;background:MediumAquamarine;min-height: 240px;max-width:880px;" id="pnWorkOrderItem" runat="server">
		
			<div class="col-md-4">
				<p>
					<asp:Label ID="lblWorkOrderID" runat="server" Text="WorkOrder ID"></asp:Label>					
				</p>
				<p>					
					<asp:Label ID="lblServiceItem" runat="server" Text="Service Item" Font-Bold="True"></asp:Label>
					<asp:DropDownList ID="cboServiceItem" runat="server" Width="400px"></asp:DropDownList>		
				</p>
				<p>
					<asp:Label ID="lblColour" runat="server" Text="Colour" Font-Bold="True"></asp:Label>
					<asp:TextBox ID="txtColour" runat="server" style="margin-right:30px" Width="40px" Height="30px" TextMode="Color"></asp:TextBox>
					<asp:Label ID="lblQty" runat="server" Text="Quantity" Font-Bold="True"></asp:Label>
					<asp:TextBox ID="txtQuantity" runat="server" Width="50px" Height="30px"></asp:TextBox>
				</p>
				<p>
					<asp:Label ID="lblComments" runat="server" Text="Comments" Font-Bold="True"></asp:Label>
					<asp:TextBox ID="txtComments" runat="server" Width="400px"></asp:TextBox>
				</p>

				</div>
		<div class="col-md-4">
			<asp:Label ID="Label1" runat="server" style="margin-left:30px;" Text="Service Type" Font-Bold="True"></asp:Label>
				<asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-left:30px;">
					<asp:ListItem Value="rdbRegular">Regular (Wash, Press/Fold)</asp:ListItem>
					<asp:ListItem Value="rdbPress">Press Only</asp:ListItem>
					<asp:ListItem Value="rdbRepeat (Regular)">Repeat Regular</asp:ListItem>
					<asp:ListItem Value="rdbRepeat (Press)">Repeat Press</asp:ListItem>
				</asp:RadioButtonList>
				

				</div>
		<div class="col-md-2">
				<p>
					<asp:Button ID="btnAddItem" runat="server" style="margin-top:30px;" Text="Add Item" Height="50px" Font-Bold="True" BorderStyle="Double" ForeColor="Yellow" BackColor="#000000" Width="150px" />

					<asp:Button ID="btnDeleteWorkItem" runat="server" style="margin-top:10px;" Text="Delete Item" Height="50px" Font-Bold="True" BorderStyle="Solid" ForeColor="Red" BackColor="#000000"  Width="150px"/>
				</p>							
		</div>
	</div>
	<div class="container" style="padding-top:10px;padding-bottom:10px;padding-left:10px;padding-right:10px;background:MediumAquamarine;max-width:500px;" >
		<div class="col-md-5">
			<asp:Button ID="btnSaveWorkOrder" runat="server" style="margin-top:10px;" Text="Save WorkOrder" Height="50px" Font-Bold="True" BorderStyle="Double" ForeColor="Blue" BackColor="#000000" Width="200px" />
			</div>
		<div class="col-md-5">
			<asp:Button ID="btnVoidWorkOrder" runat="server" style="margin-top:10px;margin-left:40px;" Text="Cancel/Delete Work Order" Height="50px" Font-Bold="True" BorderStyle="Double" ForeColor="Red" BackColor="#000000" Width="200px" />
			</div>

</div>

</asp:Content>
