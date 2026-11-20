<%@ Page Title="Customer Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="WebUI.CustomerPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-heading"><div><p class="eyebrow">EXERCISE 1</p><h1>Customer Management</h1></div></div>
    <div class="panel form-grid">
        <div><label>ID</label><asp:TextBox ID="txtId" runat="server" CssClass="input" TextMode="Number" /></div>
        <div><label>Name</label><asp:TextBox ID="txtName" runat="server" CssClass="input" /></div>
        <div><label>Email</label><asp:TextBox ID="txtEmail" runat="server" CssClass="input" TextMode="Email" /></div>
        <div class="actions">
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="button primary" OnClick="btnAdd_Click" />
            <asp:Button ID="btnGet" runat="server" Text="Get" CssClass="button" OnClick="btnGet_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button danger" OnClick="btnDelete_Click" OnClientClick="return confirm('Delete this customer?');" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button ghost" OnClick="btnClear_Click" />
        </div>
        <asp:Label ID="lblMessage" runat="server" />
    </div>
    <div class="panel table-wrap">
        <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" DataKeyNames="Id" CssClass="grid" OnSelectedIndexChanged="gvCustomers_SelectedIndexChanged">
            <Columns>
                <asp:CommandField ShowSelectButton="true" SelectText="Select" />
                <asp:BoundField DataField="Id" HeaderText="ID" />
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
            </Columns>
        </asp:GridView>
    </div>
</asp:Content>
