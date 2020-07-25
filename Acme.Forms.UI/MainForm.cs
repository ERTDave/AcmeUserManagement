using System;
using System.Windows.Forms;
using Acme.Models;
using Acme.Services.Implementations;

namespace Acme.Forms.UI
{
    public partial class MainForm : Form
    {
        protected bool IsAuthenticated;

        protected ApplicationUserService ApplicationUserService = new ApplicationUserService();

        protected EmployeeService EmployeeService = new EmployeeService();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UserTabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTabs.SelectedIndex > 0 && !IsAuthenticated)
            {
                UserTabs.SelectedIndex = 0;

                MessageBox.Show(@"You must Logon to acces this area", @"Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (UserTabs.SelectedIndex == 0 && IsAuthenticated)
            {
                UserTabs.SelectedIndex = 1;
            }
        }

        private void LogonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show(@"Please enter a username", @"Username Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show(@"Please enter a password", @"Username Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            if (ApplicationUserService.ValidateCredentials(Username.Text, Password.Text))
            {
                IsAuthenticated = true;

                UserTabs.SelectedIndex = 1;

                var employees = EmployeeService.GetEmployees();

                UsersGrid.DataSource = employees;
            }
            else
            {
                MessageBox.Show(@"Invalid Credentials, please try again", @"Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplicationUserService.SeedApplicationUsers();

            EmployeeService.SeedEmployeesData();
        }

        private void AddEmployeesTab_Click(object sender, EventArgs e)
        {

        }

        private void AddEmployeeButton_Click(object sender, EventArgs e)
        {
            var employee = new Employee
            {
                Firstname = Firstname.Text,
                Surname = Surname.Text,
                WorkEmail = WorkEmail.Text,
                PersonalEmail = PersonalEmail.Text,
                StartDate = DateTime.Parse(StartDate.Text)
            };

            EmployeeService.AddEmployee(employee);

            Firstname.Text = "";
            Surname.Text = "";
            WorkEmail.Text = "";
            PersonalEmail.Text = "";
            StartDate.Text = "";

            MessageBox.Show(@"The employee has been sucessfully added", @"Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var employees = EmployeeService.GetEmployees(SearchText.Text);

            UsersGrid.DataSource = employees;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            var employees = EmployeeService.GetEmployees();

            UsersGrid.DataSource = employees;
        }
    }
}
