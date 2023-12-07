using Common;

namespace GeniusIdiotWinFormsApp
{
    public partial class SettingsForm : Form
    {
        private FileProvider settingsFileProvider;
        private SettingsStorage settingsStorage;
        private bool isClosedByMenuButton = false;

        public SettingsForm()
        {
            InitializeComponent();
        }

        private void settingsForm_Load(object sender, EventArgs e)
        {
            var filter = "JSON files (*.json)|*.json";

            saveQuestionsFileDialog.Filter = filter;
            saveQuizResultsFileDialog.Filter = filter;
            settingsFileProvider = MainForm.SettingsFileProvider;
            settingsStorage = new SettingsStorage(settingsFileProvider);
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isClosedByMenuButton)
            {
                Application.Exit();
            }
        }

        private void homeToolStripButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите выйти в главное меню?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                isClosedByMenuButton = true;
                Close();
            }
        }

        private void saveQuestionsPathButton_Click(object sender, EventArgs e)
        {
            if (saveQuestionsFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = saveQuestionsFileDialog.FileName;

            if (settingsStorage.IsSettingExists("questionsPath"))
            {
                settingsStorage.UpdateValue("questionsPath", filename);
                settingsStorage.Save();
            }
            else
            {
                settingsStorage.Add("questionsPath", filename);
                settingsStorage.Save();
            }

            MessageBox.Show($"Для вступления настроек в силу требуется перезапуск программы!");
        }

        private void saveQuizResultsPathButton_Click(object sender, EventArgs e)
        {
            if (saveQuizResultsFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var filename = saveQuizResultsFileDialog.FileName;

            if (settingsStorage.IsSettingExists("quizResultsPath"))
            {
                settingsStorage.UpdateValue("quizResultsPath", filename);
                settingsStorage.Save();
            }
            else
            {
                settingsStorage.Add("quizResultsPath", filename);
                settingsStorage.Save();
            }

            MessageBox.Show($"Для вступления настроек в силу требуется перезапуск программы!");
        }
    }
}
