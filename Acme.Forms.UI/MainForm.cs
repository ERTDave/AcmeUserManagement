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

                MessageBox.Show(@"You must Logon to acces this area", @"Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (UserTabs.SelectedIndex == 0 && IsAuthenticated)
            {
                UserTabs.SelectedIndex = 1;
            }

            if (UserTabs.SelectedIndex == 1)
            {
                var employees = EmployeeService.GetEmployees();

                UsersGrid.DataSource = employees;
            }
        }

        private void LogonButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text))
            {
                MessageBox.Show(@"Please enter a username", @"Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show(@"Please enter a password", @"Username Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            if (ApplicationUserService.ValidateCredentials(Username.Text, Password.Text))
            {
                IsAuthenticated = true;

                UserTabs.SelectedIndex = 1;
            }
            else
            {
                MessageBox.Show(@"Invalid Credentials, please try again", @"Invalid Credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ApplicationUserService.SeedApplicationUsers();

            EmployeeService.SeedEmployeesData();
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

            var errorMessages = employee.Validate();

            if (errorMessages.IsValid)
            {
                EmployeeService.AddEmployee(employee);

                Firstname.Text = "";
                Surname.Text = "";
                WorkEmail.Text = "";
                PersonalEmail.Text = "";
                StartDate.Text = "";

                MessageBox.Show(@"The employee has been sucessfully added", @"Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(@"There are some problems with the form as follow" + Environment.NewLine + Environment.NewLine + string.Join(Environment.NewLine, errorMessages.Errors) , @"Form Problems", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            var employees = EmployeeService.GetEmployees(SearchText.Text);

            UsersGrid.DataSource = employees;
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {
            SearchText.Text = "";

            var employees = EmployeeService.GetEmployees();

            UsersGrid.DataSource = employees;
        }
    }
}
