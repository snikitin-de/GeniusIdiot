namespace GeniusIdiotWinFormsApp
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            saveQuestionsPathLabel = new Label();
            saveQuestionsPathButton = new Button();
            saveQuestionsFileDialog = new SaveFileDialog();
            saveQuizResultsPathLabel = new Label();
            saveQuizResultsPathButton = new Button();
            saveFilePathsGroupBox = new GroupBox();
            saveQuizResultsFileDialog = new SaveFileDialog();
            settingsToolStrip = new ToolStrip();
            homeToolStripButton = new ToolStripButton();
            saveFilePathsGroupBox.SuspendLayout();
            settingsToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // saveQuestionsPathLabel
            // 
            saveQuestionsPathLabel.AutoSize = true;
            saveQuestionsPathLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveQuestionsPathLabel.Location = new Point(23, 44);
            saveQuestionsPathLabel.Name = "saveQuestionsPathLabel";
            saveQuestionsPathLabel.Size = new Size(251, 21);
            saveQuestionsPathLabel.TabIndex = 1;
            saveQuestionsPathLabel.Text = "Путь сохранения файла вопросов";
            // 
            // saveQuestionsPathButton
            // 
            saveQuestionsPathButton.Location = new Point(448, 36);
            saveQuestionsPathButton.Name = "saveQuestionsPathButton";
            saveQuestionsPathButton.Size = new Size(132, 36);
            saveQuestionsPathButton.TabIndex = 2;
            saveQuestionsPathButton.Text = "Выбрать";
            saveQuestionsPathButton.UseVisualStyleBackColor = true;
            saveQuestionsPathButton.Click += saveQuestionsPathButton_Click;
            // 
            // saveQuizResultsPathLabel
            // 
            saveQuizResultsPathLabel.AutoSize = true;
            saveQuizResultsPathLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveQuizResultsPathLabel.Location = new Point(23, 101);
            saveQuizResultsPathLabel.Name = "saveQuizResultsPathLabel";
            saveQuizResultsPathLabel.Size = new Size(353, 21);
            saveQuizResultsPathLabel.TabIndex = 3;
            saveQuizResultsPathLabel.Text = "Путь сохранения файла результатов викторины";
            // 
            // saveQuizResultsPathButton
            // 
            saveQuizResultsPathButton.Location = new Point(448, 93);
            saveQuizResultsPathButton.Margin = new Padding(3, 15, 3, 3);
            saveQuizResultsPathButton.Name = "saveQuizResultsPathButton";
            saveQuizResultsPathButton.Size = new Size(132, 36);
            saveQuizResultsPathButton.TabIndex = 4;
            saveQuizResultsPathButton.Text = "Выбрать";
            saveQuizResultsPathButton.UseVisualStyleBackColor = true;
            saveQuizResultsPathButton.Click += saveQuizResultsPathButton_Click;
            // 
            // saveFilePathsGroupBox
            // 
            saveFilePathsGroupBox.Anchor = AnchorStyles.None;
            saveFilePathsGroupBox.Controls.Add(saveQuizResultsPathButton);
            saveFilePathsGroupBox.Controls.Add(saveQuestionsPathLabel);
            saveFilePathsGroupBox.Controls.Add(saveQuizResultsPathLabel);
            saveFilePathsGroupBox.Controls.Add(saveQuestionsPathButton);
            saveFilePathsGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            saveFilePathsGroupBox.Location = new Point(41, 98);
            saveFilePathsGroupBox.Name = "saveFilePathsGroupBox";
            saveFilePathsGroupBox.Size = new Size(602, 165);
            saveFilePathsGroupBox.TabIndex = 5;
            saveFilePathsGroupBox.TabStop = false;
            saveFilePathsGroupBox.Text = "Пути сохранения файлов";
            // 
            // settingsToolStrip
            // 
            settingsToolStrip.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            settingsToolStrip.Items.AddRange(new ToolStripItem[] { homeToolStripButton });
            settingsToolStrip.Location = new Point(0, 0);
            settingsToolStrip.Name = "settingsToolStrip";
            settingsToolStrip.Size = new Size(684, 25);
            settingsToolStrip.TabIndex = 20;
            // 
            // homeToolStripButton
            // 
            homeToolStripButton.Image = (Image)resources.GetObject("homeToolStripButton.Image");
            homeToolStripButton.ImageTransparentColor = Color.Magenta;
            homeToolStripButton.Name = "homeToolStripButton";
            homeToolStripButton.Size = new Size(116, 22);
            homeToolStripButton.Text = "В главное меню";
            homeToolStripButton.Click += homeToolStripButton_Click;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(settingsToolStrip);
            Controls.Add(saveFilePathsGroupBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "SettingsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Гений-Идиот • Настройки";
            FormClosing += SettingsForm_FormClosing;
            Load += settingsForm_Load;
            saveFilePathsGroupBox.ResumeLayout(false);
            saveFilePathsGroupBox.PerformLayout();
            settingsToolStrip.ResumeLayout(false);
            settingsToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label saveQuestionsPathLabel;
        private Button saveQuestionsPathButton;
        private SaveFileDialog saveQuestionsFileDialog;
        private Label saveQuizResultsPathLabel;
        private Button saveQuizResultsPathButton;
        private GroupBox saveFilePathsGroupBox;
        private SaveFileDialog saveQuizResultsFileDialog;
        private ToolStrip settingsToolStrip;
        private ToolStripButton homeToolStripButton;
    }
}