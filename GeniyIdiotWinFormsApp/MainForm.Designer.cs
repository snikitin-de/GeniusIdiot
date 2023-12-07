namespace GeniusIdiotWinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            greetingLabel = new Label();
            mainFormMenuStrip = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            showQuizResultsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripSeparator();
            editQuestionToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            changeUserToolStripMenuItem = new ToolStripMenuItem();
            restartAppToolStripMenuItem = new ToolStripMenuItem();
            exitAppToolStripMenuItem = new ToolStripMenuItem();
            startQuizButton = new Button();
            showQuizResultsButton = new Button();
            mainFormMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // greetingLabel
            // 
            greetingLabel.Anchor = AnchorStyles.None;
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            greetingLabel.Location = new Point(164, 132);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(357, 21);
            greetingLabel.TabIndex = 4;
            greetingLabel.Text = "добро пожаловать в программу \"Гений-Идиот\"!";
            // 
            // mainFormMenuStrip
            // 
            mainFormMenuStrip.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            mainFormMenuStrip.Location = new Point(0, 0);
            mainFormMenuStrip.Name = "mainFormMenuStrip";
            mainFormMenuStrip.Size = new Size(684, 24);
            mainFormMenuStrip.TabIndex = 6;
            mainFormMenuStrip.Text = "mainFormMenuStrip";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { showQuizResultsToolStripMenuItem, toolStripMenuItem4, editQuestionToolStripMenuItem, settingsToolStripMenuItem, toolStripMenuItem3, changeUserToolStripMenuItem, restartAppToolStripMenuItem, exitAppToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // showQuizResultsToolStripMenuItem
            // 
            showQuizResultsToolStripMenuItem.Name = "showQuizResultsToolStripMenuItem";
            showQuizResultsToolStripMenuItem.Size = new Size(228, 22);
            showQuizResultsToolStripMenuItem.Text = "Просмотреть результаты";
            showQuizResultsToolStripMenuItem.Click += showQuizResultsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(225, 6);
            // 
            // editQuestionToolStripMenuItem
            // 
            editQuestionToolStripMenuItem.Name = "editQuestionToolStripMenuItem";
            editQuestionToolStripMenuItem.Size = new Size(228, 22);
            editQuestionToolStripMenuItem.Text = "Редактирование вопросов";
            editQuestionToolStripMenuItem.Click += editQuestionToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(228, 22);
            settingsToolStripMenuItem.Text = "Настройки";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(225, 6);
            // 
            // changeUserToolStripMenuItem
            // 
            changeUserToolStripMenuItem.Name = "changeUserToolStripMenuItem";
            changeUserToolStripMenuItem.Size = new Size(228, 22);
            changeUserToolStripMenuItem.Text = "Сменить пользователя";
            changeUserToolStripMenuItem.Click += changeUserToolStripMenuItem_Click;
            // 
            // restartAppToolStripMenuItem
            // 
            restartAppToolStripMenuItem.Name = "restartAppToolStripMenuItem";
            restartAppToolStripMenuItem.Size = new Size(228, 22);
            restartAppToolStripMenuItem.Text = "Перезапустить приложение";
            restartAppToolStripMenuItem.Click += restartAppToolStripMenuItem_Click;
            // 
            // exitAppToolStripMenuItem
            // 
            exitAppToolStripMenuItem.Name = "exitAppToolStripMenuItem";
            exitAppToolStripMenuItem.Size = new Size(228, 22);
            exitAppToolStripMenuItem.Text = "Выйти из приложения";
            exitAppToolStripMenuItem.Click += exitAppToolStripMenuItem_Click;
            // 
            // startQuizButton
            // 
            startQuizButton.Anchor = AnchorStyles.None;
            startQuizButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            startQuizButton.Location = new Point(183, 174);
            startQuizButton.Name = "startQuizButton";
            startQuizButton.Size = new Size(155, 54);
            startQuizButton.TabIndex = 12;
            startQuizButton.Text = "Начать викторину";
            startQuizButton.UseVisualStyleBackColor = true;
            startQuizButton.Click += startQuizButton_Click;
            // 
            // showQuizResultsButton
            // 
            showQuizResultsButton.Anchor = AnchorStyles.None;
            showQuizResultsButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            showQuizResultsButton.Location = new Point(346, 174);
            showQuizResultsButton.Name = "showQuizResultsButton";
            showQuizResultsButton.Size = new Size(155, 54);
            showQuizResultsButton.TabIndex = 13;
            showQuizResultsButton.Text = "Просмотреть результаты";
            showQuizResultsButton.UseVisualStyleBackColor = true;
            showQuizResultsButton.Click += showQuizResultsButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(showQuizResultsButton);
            Controls.Add(startQuizButton);
            Controls.Add(greetingLabel);
            Controls.Add(mainFormMenuStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = mainFormMenuStrip;
            MinimumSize = new Size(700, 400);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот • Главное меню";
            Load += mainForm_Load;
            mainFormMenuStrip.ResumeLayout(false);
            mainFormMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label greetingLabel;
        private MenuStrip mainFormMenuStrip;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem showQuizResultsToolStripMenuItem;
        private ToolStripMenuItem addQuestionToolStripMenuItem;
        private ToolStripMenuItem editQuestionToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem restartAppToolStripMenuItem;
        private ToolStripMenuItem exitAppToolStripMenuItem;
        private ToolStripMenuItem редактированиеToolStripMenuItem;
        private ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem changeUserToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem ToolStripMenuItem;
        private ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private Button startQuizButton;
        private Button showQuizResultsButton;
    }
}