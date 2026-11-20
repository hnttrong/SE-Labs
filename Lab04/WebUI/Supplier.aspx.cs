using BLL;
using DAL;
using System;

namespace WebUI
{
    public partial class SupplierPage : AuthenticatedPage
    {
        private readonly SupplierService _service = new SupplierService();
        protected void Page_Load(object sender, EventArgs e) { if (!IsPostBack) BindGrid(); }
        private void BindGrid() { gvSuppliers.DataSource = _service.GetAll(); gvSuppliers.DataBind(); }
        private Supplier ReadForm()
        {
            int id; int.TryParse(txtId.Text, out id);
            return new Supplier { SupplierId = id, SupplierName = txtName.Text.Trim(), Phone = txtPhone.Text.Trim(), Email = txtEmail.Text.Trim() };
        }
        protected void btnAdd_Click(object sender, EventArgs e) { Execute(() => _service.Add(ReadForm()), "Supplier added."); }
        protected void btnUpdate_Click(object sender, EventArgs e) { Execute(() => _service.Update(ReadForm()), "Supplier updated."); }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id; if (!int.TryParse(txtId.Text, out id)) { ShowMessage(lblMessage, "Enter a valid ID.", false); return; }
            Execute(() => { if (!_service.Delete(id)) throw new InvalidOperationException("Supplier not found."); }, "Supplier deleted.");
        }
        protected void btnClear_Click(object sender, EventArgs e) { ClearForm(); }
        protected void gvSuppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = _service.GetById(Convert.ToInt32(gvSuppliers.SelectedDataKey.Value));
            if (item == null) return;
            txtId.Text = item.SupplierId.ToString(); txtName.Text = item.SupplierName; txtPhone.Text = item.Phone; txtEmail.Text = item.Email;
        }
        private void ClearForm() { txtId.Text = txtName.Text = txtPhone.Text = txtEmail.Text = string.Empty; lblMessage.Text = string.Empty; }
        private void Execute(Action action, string success)
        {
            try { action(); BindGrid(); ClearForm(); ShowMessage(lblMessage, success, true); }
            catch (Exception ex) { ShowMessage(lblMessage, ex.Message, false); }
        }
    }
}
