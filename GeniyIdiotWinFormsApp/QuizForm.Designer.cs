namespace GeniusIdiotWinFormsApp
{
    partial class QuizForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            answerTextlLabel = new Label();
            nextButton = new Button();
            userAnswerTextBox = new TextBox();
            questionTextLabel = new Label();
            questionNumberLabel = new Label();
            quizFormErrorProvider = new ErrorProvider(components);
            quizStatusStrip = new StatusStrip();
            quizProgressToolStripStatusLabel = new ToolStripStatusLabel();
            QuizProgressToolStripProgressBar = new ToolStripProgressBar();
            quizToolStrip = new ToolStrip();
            homeToolStripButton = new ToolStripButton();
            userAnswerValidationLabel = new Label();
            questionTimeLeftLabel = new Label();
            questionTimeLeftProgressBar = new ProgressBar();
            questionTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)quizFormErrorProvider).BeginInit();
            quizStatusStrip.SuspendLayout();
            quizToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // answerTextlLabel
            // 
            answerTextlLabel.Anchor = AnchorStyles.None;
            answerTextlLabel.AutoSize = true;
            answerTextlLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answerTextlLabel.Location = new Point(36, 152);
            answerTextlLabel.Name = "answerTextlLabel";
            answerTextlLabel.Size = new Size(131, 21);
            answerTextlLabel.TabIndex = 12;
            answerTextlLabel.Text = "Ответ на вопрос:";
            // 
            // nextButton
            // 
            nextButton.Anchor = AnchorStyles.None;
            nextButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nextButton.Location = new Point(273, 244);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(155, 42);
            nextButton.TabIndex = 11;
            nextButton.Text = "Далее";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // userAnswerTextBox
            // 
            userAnswerTextBox.Anchor = AnchorStyles.None;
            userAnswerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            userAnswerTextBox.Location = new Point(213, 149);
            userAnswerTextBox.Name = "userAnswerTextBox";
            userAnswerTextBox.Size = new Size(435, 29);
            userAnswerTextBox.TabIndex = 10;
            userAnswerTextBox.KeyDown += userAnswerTextBox_KeyDown;
            userAnswerTextBox.Validating += userAnswerTextBox_Validating;
            // 
            // questionTextLabel
            // 
            questionTextLabel.Anchor = AnchorStyles.None;
            questionTextLabel.AutoSize = true;
            questionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextLabel.Location = new Point(36, 113);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(114, 21);
            questionTextLabel.TabIndex = 9;
            questionTextLabel.Text = "Текст вопроса:";
            // 
            // questionNumberLabel
            // 
            questionNumberLabel.Anchor = AnchorStyles.None;
            questionNumberLabel.AutoSize = true;
            questionNumberLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionNumberLabel.Location = new Point(36, 74);
            questionNumberLabel.Name = "questionNumberLabel";
            questionNumberLabel.Size = new Size(84, 21);
            questionNumberLabel.TabIndex = 8;
            questionNumberLabel.Text = "Вопрос №";
            // 
            // quizFormErrorProvider
            // 
            quizFormErrorProvider.ContainerControl = this;
            // 
            // quizStatusStrip
            // 
            quizStatusStrip.Items.AddRange(new ToolStripItem[] { quizProgressToolStripStatusLabel, QuizProgressToolStripProgressBar });
            quizStatusStrip.Location = new Point(0, 339);
            quizStatusStrip.Name = "quizStatusStrip";
            quizStatusStrip.Size = new Size(684, 22);
            quizStatusStrip.TabIndex = 17;
            quizStatusStrip.Text = "statusStrip1";
            // 
            // quizProgressToolStripStatusLabel
            // 
            quizProgressToolStripStatusLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            quizProgressToolStripStatusLabel.Name = "quizProgressToolStripStatusLabel";
            quizProgressToolStripStatusLabel.Size = new Size(173, 17);
            quizProgressToolStripStatusLabel.Text = "Прогресс прохождения 0/0";
            // 
            // QuizProgressToolStripProgressBar
            // 
            QuizProgressToolStripProgressBar.Name = "QuizProgressToolStripProgressBar";
            QuizProgressToolStripProgressBar.Size = new Size(100, 16);
            // 
            // quizToolStrip
            // 
            quizToolStrip.Items.AddRange(new ToolStripItem[] { homeToolStripButton });
            quizToolStrip.Location = new Point(0, 0);
            quizToolStrip.Name = "quizToolStrip";
            quizToolStrip.Size = new Size(684, 25);
            quizToolStrip.TabIndex = 18;
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
            // userAnswerValidationLabel
            // 
            userAnswerValidationLabel.Anchor = AnchorStyles.None;
            userAnswerValidationLabel.AutoSize = true;
            userAnswerValidationLabel.ForeColor = Color.Red;
            userAnswerValidationLabel.Location = new Point(216, 184);
            userAnswerValidationLabel.Name = "userAnswerValidationLabel";
            userAnswerValidationLabel.Size = new Size(163, 15);
            userAnswerValidationLabel.TabIndex = 22;
            userAnswerValidationLabel.Text = "Валидация ответа на вопрос";
            userAnswerValidationLabel.Visible = false;
            // 
            // questionTimeLeftLabel
            // 
            questionTimeLeftLabel.Anchor = AnchorStyles.None;
            questionTimeLeftLabel.AutoSize = true;
            questionTimeLeftLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionTimeLeftLabel.Location = new Point(36, 207);
            questionTimeLeftLabel.Name = "questionTimeLeftLabel";
            questionTimeLeftLabel.Size = new Size(145, 21);
            questionTimeLeftLabel.TabIndex = 23;
            questionTimeLeftLabel.Text = "Осталось времени:";
            // 
            // questionTimeLeftProgressBar
            // 
            questionTimeLeftProgressBar.Anchor = AnchorStyles.None;
            questionTimeLeftProgressBar.Location = new Point(213, 205);
            questionTimeLeftProgressBar.MarqueeAnimationSpeed = 10;
            questionTimeLeftProgressBar.Maximum = 10;
            questionTimeLeftProgressBar.Name = "questionTimeLeftProgressBar";
            questionTimeLeftProgressBar.Size = new Size(435, 23);
            questionTimeLeftProgressBar.Step = 0;
            questionTimeLeftProgressBar.Style = ProgressBarStyle.Continuous;
            questionTimeLeftProgressBar.TabIndex = 24;
            // 
            // questionTimer
            // 
            questionTimer.Interval = 1000;
            questionTimer.Tick += questionTimer_Tick;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(questionTimeLeftProgressBar);
            Controls.Add(questionTimeLeftLabel);
            Controls.Add(userAnswerValidationLabel);
            Controls.Add(quizToolStrip);
            Controls.Add(quizStatusStrip);
            Controls.Add(answerTextlLabel);
            Controls.Add(nextButton);
            Controls.Add(userAnswerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionNumberLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "QuizForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Гений-Идиот • Викторина";
            FormClosing += QuizForm_FormClosing;
            Load += QuizForm_Load;
            ((System.ComponentModel.ISupportInitialize)quizFormErrorProvider).EndInit();
            quizStatusStrip.ResumeLayout(false);
            quizStatusStrip.PerformLayout();
            quizToolStrip.ResumeLayout(false);
            quizToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label answerTextlLabel;
        private Button nextButton;
        private TextBox userAnswerTextBox;
        private Label questionTextLabel;
        private Label questionNumberLabel;
        private ErrorProvider quizFormErrorProvider;
        private StatusStrip quizStatusStrip;
        private ToolStripStatusLabel quizProgressToolStripStatusLabel;
        private ToolStripProgressBar QuizProgressToolStripProgressBar;
        private ToolStrip quizToolStrip;
        private ToolStripButton homeToolStripButton;
        private Label userAnswerValidationLabel;
        private ProgressBar questionTimeLeftProgressBar;
        private Label questionTimeLeftLabel;
        private System.Windows.Forms.Timer questionTimer;
    }
}