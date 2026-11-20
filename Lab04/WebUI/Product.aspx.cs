using BLL;
using DAL;
using System;

namespace WebUI
{
    public partial class ProductPage : AuthenticatedPage
    {
        private readonly ProductService _service = new ProductService();
        protected void Page_Load(object sender, EventArgs e) { if (!IsPostBack) BindGrid(); }
        private void BindGrid() { gvProducts.DataSource = _service.GetAll(); gvProducts.DataBind(); }

        private Product ReadForm()
        {
            decimal price; int stock;
            if (!decimal.TryParse(txtPrice.Text, out price)) throw new ArgumentException("Price is invalid.");
            if (!int.TryParse(txtStock.Text, out stock)) throw new ArgumentException("Stock is invalid.");
            int id; int.TryParse(txtId.Text, out id);
            return new Product { ProductId = id, ProductName = txtName.Text.Trim(), Price = price, Stock = stock };
        }

        protected void btnAdd_Click(object sender, EventArgs e) { Execute(() => _service.Add(ReadForm()), "Product added."); }
        protected void btnUpdate_Click(object sender, EventArgs e) { Execute(() => _service.Update(ReadForm()), "Product updated."); }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id; if (!int.TryParse(txtId.Text, out id)) { ShowMessage(lblMessage, "Enter a valid ID.", false); return; }
            Execute(() => { if (!_service.Delete(id)) throw new InvalidOperationException("Product not found."); }, "Product deleted.");
        }
        protected void btnClear_Click(object sender, EventArgs e) { ClearForm(); }
        protected void gvProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = _service.GetById(Convert.ToInt32(gvProducts.SelectedDataKey.Value));
            if (item == null) return;
            txtId.Text = item.ProductId.ToString(); txtName.Text = item.ProductName; txtPrice.Text = item.Price.ToString("0.##"); txtStock.Text = item.Stock.ToString();
        }
        private void ClearForm() { txtId.Text = txtName.Text = txtPrice.Text = txtStock.Text = string.Empty; lblMessage.Text = string.Empty; }
        private void Execute(Action action, string success)
        {
            try { action(); BindGrid(); ClearForm(); ShowMessage(lblMessage, success, true); }
            catch (Exception ex) { ShowMessage(lblMessage, ex.Message, false); }
        }
    }
}
