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
    /// <summary>
    /// Employees data class
    /// </summary>
    public partial class EmployeeForm : Form
    {
        //Connecting to our db
        private string connectionString = DbConfig.GetInfoFromDataBaseConfig();
        public EmployeeForm()
        {
            InitializeComponent();
            LoadEmployees();
        }

        //Method to load all data from our our db employees table
        private void LoadEmployees()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Employees", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewEmployees.DataSource = table;
                }
            }catch (Exception ex)
            {
                throw ex;
            }
        }
        //Add event method after inputing required data
        private void btnAdd_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO Employees (FirstName, LastName, Department, RatePerHour) VALUES (@FirstName, @LastName, @Department, @RatePerHour)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@RatePerHour", decimal.Parse(txtRatePerHour.Text));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadEmployees();
           
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Update event method 
        private void btnUpdate_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Employees SET FirstName = @FirstName, LastName = @LastName, Department = @Department, RatePerHour = @RatePerHour WHERE EmployeeID = @EmployeeID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text);
                    cmd.Parameters.AddWithValue("@RatePerHour", decimal.Parse(txtRatePerHour.Text));
                    cmd.Parameters.AddWithValue("@EmployeeID", (int)dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadEmployees();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Delete event method 
        private void btnDelete_Click_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@EmployeeID", (int)dataGridViewEmployees.SelectedRows[0].Cells["EmployeeID"].Value);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                LoadEmployees();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
