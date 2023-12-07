using System.Text.RegularExpressions;

namespace GeniusIdiotWinFormsApp
{
    public class Validation
    {
        public static bool IsValidNumber(Control control, ErrorProvider errorProvider, System.ComponentModel.CancelEventArgs e, out string errorMessage)
        {
            try
            {
                var userInput = Convert.ToInt32(control.Text);

                errorMessage = string.Empty;
                errorProvider.SetError(control, errorMessage);
                return true;
            }
            catch (FormatException)
            {
                if (string.IsNullOrEmpty(control.Text))
                {
                    errorMessage = "Поле не может быть пустым!";
                } else
                {
                    errorMessage = "Вы ввели строку! Пожалуйста, введите число!";
                }

                errorProvider.SetError(control, errorMessage);
                e.Cancel = true;
                return false;
            }
            catch (OverflowException)
            {
                errorMessage = $"Вы ввели число больше, чем {int.MaxValue}! Пожалуйста, введите меньшее число!";
                errorProvider.SetError(control, errorMessage);
                e.Cancel = true;
                return false;
            }
        }

        public static bool IsValidLetters(Control control, ErrorProvider errorProvider, System.ComponentModel.CancelEventArgs e, out string errorMessage)
        {
            var regexOnlyLetters = new Regex(@"[^A-Za-zА-Яа-яЁё]+", RegexOptions.Compiled);

            if (regexOnlyLetters.Matches(control.Text).Count > 0)
            {
                errorMessage = "Поле не может содержать никакие символы кроме букв!";
                errorProvider.SetError(control, errorMessage);
                e.Cancel = true;
                return false;
            }
            else
            {
                errorMessage = string.Empty;
                errorProvider.SetError(control, string.Empty);
                return true;
            }
        }

        public static bool IsValidInput(Control control, ErrorProvider errorProvider, System.ComponentModel.CancelEventArgs e, out string errorMessage)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                errorMessage = "Поле не может быть пустым!";
                errorProvider.SetError(control, errorMessage);
                e.Cancel = true;
                return false;
            }
            else
            {
                errorMessage = string.Empty;
                errorProvider.SetError(control, errorMessage);
                return true;
            }
        }
    }
}
