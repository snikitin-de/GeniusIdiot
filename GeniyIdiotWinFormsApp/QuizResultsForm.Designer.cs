namespace GeniusIdiotWinFormsApp
{
    partial class QuizResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizResultsForm));
            quizResultsDataGridView = new DataGridView();
            userFullName = new DataGridViewTextBoxColumn();
            rightAnswerCount = new DataGridViewTextBoxColumn();
            rightAnswerPercent = new DataGridViewTextBoxColumn();
            Diagnose = new DataGridViewTextBoxColumn();
            showQuizResultsToolStrip = new ToolStrip();
            homeToolStripButton = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)quizResultsDataGridView).BeginInit();
            showQuizResultsToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // quizResultsDataGridView
            // 
            quizResultsDataGridView.AllowUserToAddRows = false;
            quizResultsDataGridView.AllowUserToDeleteRows = false;
            quizResultsDataGridView.AllowUserToResizeRows = false;
            quizResultsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            quizResultsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            quizResultsDataGridView.BorderStyle = BorderStyle.None;
            quizResultsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            quizResultsDataGridView.Columns.AddRange(new DataGridViewColumn[] { userFullName, rightAnswerCount, rightAnswerPercent, Diagnose });
            quizResultsDataGridView.Location = new Point(0, 28);
            quizResultsDataGridView.Name = "quizResultsDataGridView";
            quizResultsDataGridView.ReadOnly = true;
            quizResultsDataGridView.RowTemplate.Height = 25;
            quizResultsDataGridView.ShowEditingIcon = false;
            quizResultsDataGridView.ShowRowErrors = false;
            quizResultsDataGridView.Size = new Size(684, 333);
            quizResultsDataGridView.TabIndex = 0;
            // 
            // userFullName
            // 
            userFullName.HeaderText = "ФИО пользователя";
            userFullName.Name = "userFullName";
            userFullName.ReadOnly = true;
            // 
            // rightAnswerCount
            // 
            rightAnswerCount.HeaderText = "Количество правильных ответов";
            rightAnswerCount.Name = "rightAnswerCount";
            rightAnswerCount.ReadOnly = true;
            // 
            // rightAnswerPercent
            // 
            rightAnswerPercent.HeaderText = "Процент правильных ответов";
            rightAnswerPercent.Name = "rightAnswerPercent";
            rightAnswerPercent.ReadOnly = true;
            // 
            // Diagnose
            // 
            Diagnose.HeaderText = "Диагноз пользователя";
            Diagnose.Name = "Diagnose";
            Diagnose.ReadOnly = true;
            // 
            // showQuizResultsToolStrip
            // 
            showQuizResultsToolStrip.Items.AddRange(new ToolStripItem[] { homeToolStripButton });
            showQuizResultsToolStrip.Location = new Point(0, 0);
            showQuizResultsToolStrip.Name = "showQuizResultsToolStrip";
            showQuizResultsToolStrip.Size = new Size(684, 25);
            showQuizResultsToolStrip.TabIndex = 19;
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
            // QuizResultsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(showQuizResultsToolStrip);
            Controls.Add(quizResultsDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "QuizResultsForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Гений-Идиот • Результаты викторин";
            FormClosing += QuizResultsForm_FormClosing;
            Load += quizResultsForm_Load;
            ((System.ComponentModel.ISupportInitialize)quizResultsDataGridView).EndInit();
            showQuizResultsToolStrip.ResumeLayout(false);
            showQuizResultsToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView quizResultsDataGridView;
        private DataGridViewTextBoxColumn userFullName;
        private DataGridViewTextBoxColumn rightAnswerCount;
        private DataGridViewTextBoxColumn rightAnswerPercent;
        private DataGridViewTextBoxColumn Diagnose;
        private ToolStrip showQuizResultsToolStrip;
        private ToolStripButton homeToolStripButton;
    }
}