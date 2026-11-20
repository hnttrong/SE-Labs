<%@ Page Title="Supplier Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="WebUI.SupplierPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-heading"><div><p class="eyebrow">EXERCISE 3</p><h1>Supplier Management</h1></div></div>
    <div class="panel form-grid four">
        <div><label>ID</label><asp:TextBox ID="txtId" runat="server" CssClass="input" TextMode="Number" /></div>
        <div><label>Supplier name</label><asp:TextBox ID="txtName" runat="server" CssClass="input" /></div>
        <div><label>Phone</label><asp:TextBox ID="txtPhone" runat="server" CssClass="input" /></div>
        <div><label>Email</label><asp:TextBox ID="txtEmail" runat="server" CssClass="input" TextMode="Email" /></div>
        <div class="actions">
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="button primary" OnClick="btnAdd_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button danger" OnClick="btnDelete_Click" OnClientClick="return confirm('Delete this supplier?');" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button ghost" OnClick="btnClear_Click" />
        </div>
        <asp:Label ID="lblMessage" runat="server" />
    </div>
    <div class="panel table-wrap"><asp:GridView ID="gvSuppliers" runat="server" AutoGenerateColumns="false" DataKeyNames="SupplierId" CssClass="grid" OnSelectedIndexChanged="gvSuppliers_SelectedIndexChanged">
        <Columns><asp:CommandField ShowSelectButton="true" SelectText="Select" /><asp:BoundField DataField="SupplierId" HeaderText="ID" /><asp:BoundField DataField="SupplierName" HeaderText="Supplier" /><asp:BoundField DataField="Phone" HeaderText="Phone" /><asp:BoundField DataField="Email" HeaderText="Email" /></Columns>
    </asp:GridView></div>
</asp:Content>
