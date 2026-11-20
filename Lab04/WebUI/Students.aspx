<%@ Page Title="School Management" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Students.aspx.cs" Inherits="WebUI.StudentsPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="page-heading"><div><p class="eyebrow">HOMEWORK</p><h1>School Management System</h1><p>Lab 2 Student Management rebuilt with Web Forms and 3-Tier Architecture.</p></div></div>
    <div class="panel form-grid four">
        <div><label>ID</label><asp:TextBox ID="txtId" runat="server" CssClass="input" TextMode="Number" /></div>
        <div><label>Student name</label><asp:TextBox ID="txtName" runat="server" CssClass="input" /></div>
        <div><label>Date of birth</label><asp:TextBox ID="txtDateOfBirth" runat="server" CssClass="input" TextMode="Date" /></div>
        <div><label>City</label><asp:TextBox ID="txtCity" runat="server" CssClass="input" /></div>
        <div><label>Age</label><asp:TextBox ID="txtAge" runat="server" CssClass="input" TextMode="Number" /></div>
        <div><label>Year of enroll</label><asp:TextBox ID="txtYear" runat="server" CssClass="input" TextMode="Number" /></div>
        <div><label>Major</label><asp:TextBox ID="txtMajor" runat="server" CssClass="input" /></div>
        <div><label>GPA (0-4)</label><asp:TextBox ID="txtGpa" runat="server" CssClass="input" /></div>
        <div class="actions">
            <asp:Button ID="btnAdd" runat="server" Text="Add" CssClass="button primary" OnClick="btnAdd_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="button" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="button danger" OnClick="btnDelete_Click" OnClientClick="return confirm('Delete this student?');" />
            <asp:Button ID="btnClear" runat="server" Text="Clear" CssClass="button ghost" OnClick="btnClear_Click" />
        </div>
        <asp:Label ID="lblMessage" runat="server" />
    </div>
    <div class="panel table-wrap"><asp:GridView ID="gvStudents" runat="server" AutoGenerateColumns="false" DataKeyNames="StudentId" CssClass="grid" OnSelectedIndexChanged="gvStudents_SelectedIndexChanged">
        <Columns>
            <asp:CommandField ShowSelectButton="true" SelectText="Select" /><asp:BoundField DataField="StudentId" HeaderText="ID" /><asp:BoundField DataField="StudentName" HeaderText="Name" />
            <asp:BoundField DataField="DateOfBirth" HeaderText="Birth date" DataFormatString="{0:yyyy-MM-dd}" /><asp:BoundField DataField="City" HeaderText="City" /><asp:BoundField DataField="Age" HeaderText="Age" />
            <asp:BoundField DataField="YearOfEnroll" HeaderText="Enroll year" /><asp:BoundField DataField="Major" HeaderText="Major" /><asp:BoundField DataField="GPA" HeaderText="GPA" DataFormatString="{0:0.00}" />
        </Columns>
    </asp:GridView></div>
</asp:Content>
