using Common.Models;

namespace GeniusIdiotWinFormsApp
{
    public partial class LoginForm : Form
    {
        public bool isLogon = false;
        public User user = new User();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                var firstName = firstNameTextBox.Text;
                var lastName = lastNameTextBox.Text;
                var middleName = middleNameTextBox.Text;

                user = new User(firstName, lastName, middleName);
                isLogon = true;
                Close();
            }
        }

        private void firstNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (Validation.IsValidInput(firstNameTextBox, loginFormErrorProvider, e, out string errorMessageIsNullOrEmpty))
            {
                if (!Validation.IsValidLetters(firstNameTextBox, loginFormErrorProvider, e, out string errorMessageOnlyLetters))
                {
                    firstNameValidationLabel.Text = errorMessageOnlyLetters;
                    firstNameValidationLabel.Visible = true;
                }
                else
                {
                    firstNameValidationLabel.Visible = false;
                }
            }
            else
            {
                firstNameValidationLabel.Text = errorMessageIsNullOrEmpty;
                firstNameValidationLabel.Visible = true;
            }

        }

        private void lastNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Validation.IsValidLetters(lastNameTextBox, loginFormErrorProvider, e, out string errorMessageOnlyLetters))
            {
                lastNameValidationLabel.Text = errorMessageOnlyLetters;
                lastNameValidationLabel.Visible = true;
            }
            else
            {
                lastNameValidationLabel.Visible = false;
            }
        }

        private void middleNameTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!Validation.IsValidLetters(middleNameTextBox, loginFormErrorProvider, e, out string errorMessageOnlyLetters))
            {
                middleNameValidationLabel.Text = errorMessageOnlyLetters;
                middleNameValidationLabel.Visible = true;
            }
            else
            {
                middleNameValidationLabel.Visible = false;
            }
        }
    }
}
