using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonitorEmployeeTracker
{
    public partial class WorkHourEntryForm : Form
    {
        //Connecting to our db
        private string connectionString = DbConfig.GetInfoFromDataBaseConfig();
        public WorkHourEntryForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT EmployeeID, FirstName + ' ' + LastName AS FullName FROM Employees", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cmbEmployee.DataSource = table;
                    cmbEmployee.DisplayMember = "FullName";
                    cmbEmployee.ValueMember = "EmployeeID";
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
        //Save event method after employeed input his/her hours work on specific worked
        private void btnSave_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO WorkHours (EmployeeID, DateWorked, HoursWorked) VALUES (@EmployeeID, @DateWorked, @HoursWorked)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", (int)cmbEmployee.SelectedValue);
                    cmd.Parameters.AddWithValue("@DateWorked", dtpDate.Value.Date);
                    cmd.Parameters.AddWithValue("@HoursWorked", decimal.Parse(txtHoursWorked.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Work hours saved successfully.");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
