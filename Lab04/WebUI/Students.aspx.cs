using BLL;
using DAL;
using System;

namespace WebUI
{
    public partial class StudentsPage : AuthenticatedPage
    {
        private readonly StudentService _service = new StudentService();
        protected void Page_Load(object sender, EventArgs e) { if (!IsPostBack) BindGrid(); }
        private void BindGrid() { gvStudents.DataSource = _service.GetAll(); gvStudents.DataBind(); }
        private Student ReadForm()
        {
            DateTime birth; int age; int year; decimal gpa;
            if (!DateTime.TryParse(txtDateOfBirth.Text, out birth)) throw new ArgumentException("Date of birth is invalid.");
            if (!int.TryParse(txtAge.Text, out age)) throw new ArgumentException("Age is invalid.");
            if (!int.TryParse(txtYear.Text, out year)) throw new ArgumentException("Enrollment year is invalid.");
            decimal? parsedGpa = null;
            if (!string.IsNullOrWhiteSpace(txtGpa.Text))
            {
                if (!decimal.TryParse(txtGpa.Text, out gpa)) throw new ArgumentException("GPA is invalid.");
                parsedGpa = gpa;
            }
            int id; int.TryParse(txtId.Text, out id);
            return new Student { StudentId = id, StudentName = txtName.Text.Trim(), DateOfBirth = birth, City = txtCity.Text.Trim(), Age = age, YearOfEnroll = year, Major = txtMajor.Text.Trim(), GPA = parsedGpa };
        }
        protected void btnAdd_Click(object sender, EventArgs e) { Execute(() => _service.Add(ReadForm()), "Student added."); }
        protected void btnUpdate_Click(object sender, EventArgs e) { Execute(() => _service.Update(ReadForm()), "Student updated."); }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int id; if (!int.TryParse(txtId.Text, out id)) { ShowMessage(lblMessage, "Enter a valid ID.", false); return; }
            Execute(() => { if (!_service.Delete(id)) throw new InvalidOperationException("Student not found."); }, "Student deleted.");
        }
        protected void btnClear_Click(object sender, EventArgs e) { ClearForm(); }
        protected void gvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = _service.GetById(Convert.ToInt32(gvStudents.SelectedDataKey.Value));
            if (item == null) return;
            txtId.Text = item.StudentId.ToString(); txtName.Text = item.StudentName; txtDateOfBirth.Text = item.DateOfBirth.ToString("yyyy-MM-dd");
            txtCity.Text = item.City; txtAge.Text = item.Age.ToString(); txtYear.Text = item.YearOfEnroll.ToString(); txtMajor.Text = item.Major; txtGpa.Text = item.GPA?.ToString("0.00");
        }
        private void ClearForm()
        {
            txtId.Text = txtName.Text = txtDateOfBirth.Text = txtCity.Text = txtAge.Text = txtYear.Text = txtMajor.Text = txtGpa.Text = string.Empty; lblMessage.Text = string.Empty;
        }
        private void Execute(Action action, string success)
        {
            try { action(); BindGrid(); ClearForm(); ShowMessage(lblMessage, success, true); }
            catch (Exception ex) { ShowMessage(lblMessage, ex.Message, false); }
        }
    }
}
