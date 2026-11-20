<%@ Page Title="Product Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Product.aspx.cs" Inherits="WebUI.ProductPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-heading"><div><p class="eyebrow">EXERCISE 3</p><h1>Product Management</h1></div></div>
    <div class="panel form-grid four">
        <div><label>ID</label><asp:TextBox ID="txtId" runat="server" CssClass="input" TextMode="Number" /></div>
        <div><label>Product name</label><asp:TextBox ID="txtName" runat="server" CssClass="input" /></div>
        <div><label>Price</label><asp:TextBox ID="txtPrice" runat="server" CssClass="input" /></div>
        <div><label>Stock</label><asp:TextBox ID="txtStock" runat="server" CssClass="input" TextMode="Number" /></div>
        <div class="actions">
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="button primary" OnClick="btnAdd_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button danger" OnClick="btnDelete_Click" OnClientClick="return confirm('Delete this product?');" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button ghost" OnClick="btnClear_Click" />
        </div>
        <asp:Label ID="lblMessage" runat="server" />
    </div>
    <div class="panel table-wrap"><asp:GridView ID="gvProducts" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductId" CssClass="grid" OnSelectedIndexChanged="gvProducts_SelectedIndexChanged">
        <Columns><asp:CommandField ShowSelectButton="true" SelectText="Select" /><asp:BoundField DataField="ProductId" HeaderText="ID" /><asp:BoundField DataField="ProductName" HeaderText="Product" /><asp:BoundField DataField="Price" HeaderText="Price" DataFormatString="{0:N0}" /><asp:BoundField DataField="Stock" HeaderText="Stock" /></Columns>
    </asp:GridView></div>
</asp:Content>
