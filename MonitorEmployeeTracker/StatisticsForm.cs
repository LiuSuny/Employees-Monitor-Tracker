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
    /// Class that display salary and taxes
    /// </summary>
    public partial class StatisticsForm : Form
    {
        //Connecting to our db
        private string connectionString = DbConfig.GetInfoFromDataBaseConfig();

        public StatisticsForm()
        {
            InitializeComponent();          
            InitializeComboBox();         
        }
      
        private void InitializeComboBox()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT DateWorked FROM WorkHours", conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cmbMonth.DataSource = table;
                    cmbMonth.DisplayMember = "DateWorked";
                    cmbMonth.ValueMember = "DateWorked";
                }
            }catch(Exception ex)
            {
                throw ex;
            }
           
        }
        private void btnGeneralStatistics_Click(object sender, EventArgs e)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
            SELECT 
                SUM(wh.HoursWorked) AS TotalHours, 
                SUM(wh.HoursWorked * e.RatePerHour) AS TotalSalary, 
                SUM(wh.HoursWorked * e.RatePerHour * s.SalaryTax / 100) AS TotalTax
            FROM 
                WorkHours wh
            JOIN 
                Employees e ON wh.EmployeeID = e.EmployeeID
            CROSS JOIN 
                (SELECT TOP 1 SalaryTax FROM Settings ORDER BY SettingID DESC) s";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        decimal totalHours = reader.IsDBNull(0) ? 0 : reader.GetDecimal(0);
                        decimal totalSalary = reader.IsDBNull(1) ? 0 : reader.GetDecimal(1);
                        decimal totalTax = reader.IsDBNull(2) ? 0 : reader.GetDecimal(2);


                        DataTable table = new DataTable();
                        table.Columns.Add("Description");
                        table.Columns.Add("Value");

                        table.Rows.Add("Total Hours Worked", totalHours);
                        table.Rows.Add("Total Salary Paid", totalSalary);
                        table.Rows.Add("Total Taxes Paid", totalTax);

                        dataGridViewStatistics.DataSource = table;
                    }
                    else
                    {
                        // Debugging: Print if no rows were returned
                        Console.WriteLine("No rows returned.");
                    }
                }
            }catch(Exception ex)
            {
                throw ex;
            }
           
        }

        private void btnDepartmentStatistics_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Department, SUM(HoursWorked) AS TotalHours, SUM(HoursWorked * RatePerHour) AS TotalSalary FROM WorkHours wh JOIN Employees e ON wh.EmployeeID = e.EmployeeID GROUP BY Department";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    // Display statistics in a suitable format
                    dataGridViewStatistics.DataSource = table;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnEmployeeRatings_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT FirstName, LastName, SUM(HoursWorked) AS TotalHours FROM WorkHours wh JOIN Employees e ON wh.EmployeeID = e.EmployeeID GROUP BY FirstName, LastName ORDER BY TotalHours DESC";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("Employee Ratings (Total Hours Worked This Month):");
                    while (reader.Read())
                    {
                        string firstName = reader.GetString(0);
                        string lastName = reader.GetString(1);
                        decimal totalHours = reader.GetDecimal(2);
                        sb.AppendLine($"{firstName} {lastName}: {totalHours} hours");
                    }
                    MessageBox.Show(sb.ToString(), "Employee Ratings");
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }

        private void btnDepartmentRatings_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Department, SUM(HoursWorked) AS TotalHours FROM WorkHours wh JOIN Employees e ON wh.EmployeeID = e.EmployeeID GROUP BY Department ORDER BY TotalHours DESC";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridViewStatistics.DataSource = table;
                }
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
