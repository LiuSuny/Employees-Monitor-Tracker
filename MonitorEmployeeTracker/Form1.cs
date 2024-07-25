using System;
using System.Windows.Forms;

namespace MonitorEmployeeTracker
{
    /// <summary>
    /// основная форма, которая отображающая другие формы
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод события, который управлял формой нашего сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnManageEmployees_Click_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }
        /// <summary>
        /// Метод события, который показывает часы и дату нашего сотрудника при нажатии на него
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnterWorkHours_Click_Click(object sender, EventArgs e)
        {
            WorkHourEntryForm workHourEntryForm = new WorkHourEntryForm();
            workHourEntryForm.ShowDialog();
        }

        /// <summary>
        /// Метод событий, показывающий статистику сотрудника и отдела компании
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnViewStatistics_Click_Click(object sender, EventArgs e)
        {
            StatisticsForm statisticsForm = new StatisticsForm();
            statisticsForm.ShowDialog();
        }
    }
}
