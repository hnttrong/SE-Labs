using BLL;
using DAL;
using System;

namespace WebUI
{
    public partial class CustomerPage : AuthenticatedPage
    {
        private readonly CustomerService _service = new CustomerService();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) BindGrid();
        }

        private void BindGrid()
        {
            gvCustomers.DataSource = _service.GetAll();
            gvCustomers.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Execute(() => _service.Add(new Customer { Name = txtName.Text.Trim(), Email = txtEmail.Text.Trim() }), "Customer added.");
        }

        protected void btnGet_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id)) { ShowMessage(lblMessage, "Enter a valid ID.", false); return; }
            var customer = _service.GetById(id);
            if (customer == null) { ShowMessage(lblMessage, "Customer not found.", false); return; }
            Fill(customer);
            ShowMessage(lblMessage, "Customer loaded.", true);
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id)) { ShowMessage(lblMessage, "Enter a valid ID.", false); return; }
            Execute(() => _service.Update(new Customer { Id = id, Name = txtName.Text.Trim(), Email = txtEmail.Text.Trim() }), "Customer updated.");
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(txtId.Text, out id)) { ShowMessage(lblMessage, "Enter a valid ID.", false); return; }
            Execute(() => { if (!_service.Delete(id)) throw new InvalidOperationException("Customer not found."); }, "Customer deleted.");
        }

        protected void btnClear_Click(object sender, EventArgs e) { ClearForm(); }

        protected void gvCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var customer = _service.GetById(Convert.ToInt32(gvCustomers.SelectedDataKey.Value));
            if (customer != null) Fill(customer);
        }

        private void Fill(Customer customer)
        {
            txtId.Text = customer.Id.ToString(); txtName.Text = customer.Name; txtEmail.Text = customer.Email;
        }

        private void ClearForm() { txtId.Text = txtName.Text = txtEmail.Text = string.Empty; lblMessage.Text = string.Empty; }

        private void Execute(Action action, string success)
        {
            try { action(); BindGrid(); ClearForm(); ShowMessage(lblMessage, success, true); }
            catch (Exception ex) { ShowMessage(lblMessage, ex.Message, false); }
        }
    }
}
