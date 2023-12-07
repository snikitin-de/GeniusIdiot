namespace GeniusIdiotWinFormsApp
{
    partial class QuizResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResultForm));
            quizToolStrip = new ToolStrip();
            homeToolStripButton = new ToolStripButton();
            diagnoseLabel = new Label();
            rightAnswersCountLabel = new Label();
            rightAnswersPercentLabel = new Label();
            homeButton = new Button();
            quizToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // quizToolStrip
            // 
            quizToolStrip.Items.AddRange(new ToolStripItem[] { homeToolStripButton });
            quizToolStrip.Location = new Point(0, 0);
            quizToolStrip.Name = "quizToolStrip";
            quizToolStrip.Size = new Size(684, 25);
            quizToolStrip.TabIndex = 19;
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
            // diagnoseLabel
            // 
            diagnoseLabel.Anchor = AnchorStyles.None;
            diagnoseLabel.AutoSize = true;
            diagnoseLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            diagnoseLabel.Location = new Point(196, 107);
            diagnoseLabel.Name = "diagnoseLabel";
            diagnoseLabel.Size = new Size(142, 21);
            diagnoseLabel.TabIndex = 20;
            diagnoseLabel.Text = "User, ваш диагноз:";
            // 
            // rightAnswersCountLabel
            // 
            rightAnswersCountLabel.Anchor = AnchorStyles.None;
            rightAnswersCountLabel.AutoSize = true;
            rightAnswersCountLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rightAnswersCountLabel.Location = new Point(196, 141);
            rightAnswersCountLabel.Name = "rightAnswersCountLabel";
            rightAnswersCountLabel.Size = new Size(246, 21);
            rightAnswersCountLabel.TabIndex = 21;
            rightAnswersCountLabel.Text = "Количество правильных ответов:";
            // 
            // rightAnswersPercentLabel
            // 
            rightAnswersPercentLabel.Anchor = AnchorStyles.None;
            rightAnswersPercentLabel.AutoSize = true;
            rightAnswersPercentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rightAnswersPercentLabel.Location = new Point(196, 176);
            rightAnswersPercentLabel.Name = "rightAnswersPercentLabel";
            rightAnswersPercentLabel.Size = new Size(293, 21);
            rightAnswersPercentLabel.TabIndex = 22;
            rightAnswersPercentLabel.Text = "Вы ответили правильно на % вопросов.";
            // 
            // homeButton
            // 
            homeButton.Anchor = AnchorStyles.None;
            homeButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.Location = new Point(229, 211);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(226, 42);
            homeButton.TabIndex = 23;
            homeButton.Text = "Вернуться в главное меню";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // QuizResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(homeButton);
            Controls.Add(rightAnswersPercentLabel);
            Controls.Add(rightAnswersCountLabel);
            Controls.Add(diagnoseLabel);
            Controls.Add(quizToolStrip);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "QuizResultForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Гений-Идиот • Результаты викторины";
            FormClosing += QuizResultForm_FormClosing;
            Load += QuizResultForm_Load;
            quizToolStrip.ResumeLayout(false);
            quizToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip quizToolStrip;
        private ToolStripButton homeToolStripButton;
        private Label diagnoseLabel;
        private Label rightAnswersCountLabel;
        private Label rightAnswersPercentLabel;
        private Button homeButton;
    }
}