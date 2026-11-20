<%@ Page Title="Main" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="WebUI.MainPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <section class="hero">
        <p class="eyebrow">WELCOME</p>
        <h1>Three-Tier Management System</h1>
        <p>Choose a module below. All pages call the Business Logic Layer, which accesses SQL Server through the Data Access Layer.</p>
    </section>
    <section class="cards">
        <a class="card" href="Customer.aspx"><h2>Customers</h2><p>Complete CRUD required by Exercise 1.</p></a>
        <a class="card" href="Product.aspx"><h2>Products</h2><p>Manage product prices and stock.</p></a>
        <a class="card" href="Supplier.aspx"><h2>Suppliers</h2><p>Manage supplier contact information.</p></a>
        <a class="card" href="Students.aspx"><h2>School Management</h2><p>Lab 2 homework rebuilt as Web Forms 3-Tier.</p></a>
    </section>
</asp:Content>
