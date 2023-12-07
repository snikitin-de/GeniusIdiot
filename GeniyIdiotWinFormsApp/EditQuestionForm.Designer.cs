namespace GeniusIdiotWinFormsApp
{
    partial class EditQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditQuestionForm));
            questionsDataGridView = new DataGridView();
            questionText = new DataGridViewTextBoxColumn();
            addQuestionButton = new Button();
            editQuestionErrorProvider = new ErrorProvider(components);
            editQuestionToolStrip = new ToolStrip();
            homeToolStripButton = new ToolStripButton();
            questionTextLabel = new Label();
            answerTextBox = new TextBox();
            answerTextlLabel = new Label();
            questionTextBox = new TextBox();
            questionTextValidationLabel = new Label();
            answerValidationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)editQuestionErrorProvider).BeginInit();
            editQuestionToolStrip.SuspendLayout();
            SuspendLayout();
            // 
            // questionsDataGridView
            // 
            questionsDataGridView.AllowUserToAddRows = false;
            questionsDataGridView.AllowUserToResizeRows = false;
            questionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            questionsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            questionsDataGridView.BorderStyle = BorderStyle.None;
            questionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { questionText });
            questionsDataGridView.Location = new Point(0, 28);
            questionsDataGridView.Name = "questionsDataGridView";
            questionsDataGridView.ReadOnly = true;
            questionsDataGridView.RowTemplate.Height = 25;
            questionsDataGridView.ShowEditingIcon = false;
            questionsDataGridView.ShowRowErrors = false;
            questionsDataGridView.Size = new Size(684, 152);
            questionsDataGridView.TabIndex = 0;
            // 
            // questionText
            // 
            questionText.HeaderText = "Текст вопроса";
            questionText.Name = "questionText";
            questionText.ReadOnly = true;
            // 
            // addQuestionButton
            // 
            addQuestionButton.Anchor = AnchorStyles.None;
            addQuestionButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            addQuestionButton.Location = new Point(261, 305);
            addQuestionButton.Margin = new Padding(3, 15, 3, 50000);
            addQuestionButton.Name = "addQuestionButton";
            addQuestionButton.Size = new Size(163, 42);
            addQuestionButton.TabIndex = 15;
            addQuestionButton.Text = "Добавить";
            addQuestionButton.UseVisualStyleBackColor = true;
            addQuestionButton.Click += addQuestionButton_Click;
            // 
            // editQuestionErrorProvider
            // 
            editQuestionErrorProvider.ContainerControl = this;
            // 
            // editQuestionToolStrip
            // 
            editQuestionToolStrip.Items.AddRange(new ToolStripItem[] { homeToolStripButton });
            editQuestionToolStrip.Location = new Point(0, 0);
            editQuestionToolStrip.Name = "editQuestionToolStrip";
            editQuestionToolStrip.Size = new Size(684, 25);
            editQuestionToolStrip.TabIndex = 20;
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
            // questionTextLabel
            // 
            questionTextLabel.Anchor = AnchorStyles.None;
            questionTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextLabel.Location = new Point(109, 197);
            questionTextLabel.Margin = new Padding(3, 15, 3, 0);
            questionTextLabel.Name = "questionTextLabel";
            questionTextLabel.Size = new Size(112, 26);
            questionTextLabel.TabIndex = 11;
            questionTextLabel.Text = "Текст вопроса";
            // 
            // answerTextBox
            // 
            answerTextBox.Anchor = AnchorStyles.None;
            answerTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answerTextBox.Location = new Point(227, 250);
            answerTextBox.Name = "answerTextBox";
            answerTextBox.Size = new Size(365, 29);
            answerTextBox.TabIndex = 12;
            answerTextBox.Validating += answerTextBox_Validating;
            // 
            // answerTextlLabel
            // 
            answerTextlLabel.Anchor = AnchorStyles.None;
            answerTextlLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            answerTextlLabel.Location = new Point(93, 253);
            answerTextlLabel.Name = "answerTextlLabel";
            answerTextlLabel.Size = new Size(128, 23);
            answerTextlLabel.TabIndex = 13;
            answerTextlLabel.Text = "Ответ на вопрос";
            // 
            // questionTextBox
            // 
            questionTextBox.Anchor = AnchorStyles.None;
            questionTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            questionTextBox.Location = new Point(227, 194);
            questionTextBox.Margin = new Padding(3, 15, 3, 3);
            questionTextBox.MaxLength = 75;
            questionTextBox.Name = "questionTextBox";
            questionTextBox.Size = new Size(365, 29);
            questionTextBox.TabIndex = 14;
            questionTextBox.Validating += questionTextBox_Validating;
            // 
            // questionTextValidationLabel
            // 
            questionTextValidationLabel.Anchor = AnchorStyles.None;
            questionTextValidationLabel.AutoSize = true;
            questionTextValidationLabel.ForeColor = Color.Red;
            questionTextValidationLabel.Location = new Point(227, 229);
            questionTextValidationLabel.Name = "questionTextValidationLabel";
            questionTextValidationLabel.Size = new Size(152, 15);
            questionTextValidationLabel.TabIndex = 21;
            questionTextValidationLabel.Text = "Валидация текста вопроса";
            questionTextValidationLabel.Visible = false;
            // 
            // answerValidationLabel
            // 
            answerValidationLabel.Anchor = AnchorStyles.None;
            answerValidationLabel.AutoSize = true;
            answerValidationLabel.ForeColor = Color.Red;
            answerValidationLabel.Location = new Point(227, 285);
            answerValidationLabel.Name = "answerValidationLabel";
            answerValidationLabel.Size = new Size(163, 15);
            answerValidationLabel.TabIndex = 22;
            answerValidationLabel.Text = "Валидация ответа на вопрос";
            answerValidationLabel.Visible = false;
            // 
            // EditQuestionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(answerValidationLabel);
            Controls.Add(questionTextValidationLabel);
            Controls.Add(editQuestionToolStrip);
            Controls.Add(addQuestionButton);
            Controls.Add(questionTextBox);
            Controls.Add(answerTextlLabel);
            Controls.Add(answerTextBox);
            Controls.Add(questionTextLabel);
            Controls.Add(questionsDataGridView);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "EditQuestionForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Гений-Идиот • Редактирование вопросов";
            FormClosing += editQuestionForm_FormClosing;
            Load += editQuestionForm_Load;
            ((System.ComponentModel.ISupportInitialize)questionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)editQuestionErrorProvider).EndInit();
            editQuestionToolStrip.ResumeLayout(false);
            editQuestionToolStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView questionsDataGridView;
        private Button addQuestionButton;
        private ErrorProvider editQuestionErrorProvider;
        private ToolStrip editQuestionToolStrip;
        private ToolStripButton homeToolStripButton;
        private DataGridViewTextBoxColumn questionText;
        private TextBox questionTextBox;
        private Label answerTextlLabel;
        private TextBox answerTextBox;
        private Label questionTextLabel;
        private Label answerValidationLabel;
        private Label questionTextValidationLabel;
    }
}