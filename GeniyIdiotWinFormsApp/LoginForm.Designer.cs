namespace GeniusIdiotWinFormsApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            middleNameLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            middleNameTextBox = new TextBox();
            loginButton = new Button();
            greetingLabel = new Label();
            loginFormErrorProvider = new ErrorProvider(components);
            firstNameValidationLabel = new Label();
            lastNameValidationLabel = new Label();
            middleNameValidationLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)loginFormErrorProvider).BeginInit();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.Anchor = AnchorStyles.None;
            firstNameLabel.AutoSize = true;
            firstNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameLabel.Location = new Point(222, 88);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(41, 21);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "Имя";
            // 
            // lastNameLabel
            // 
            lastNameLabel.Anchor = AnchorStyles.None;
            lastNameLabel.AutoSize = true;
            lastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameLabel.Location = new Point(188, 148);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(75, 21);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Фамилия";
            // 
            // middleNameLabel
            // 
            middleNameLabel.Anchor = AnchorStyles.None;
            middleNameLabel.AutoSize = true;
            middleNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameLabel.Location = new Point(186, 208);
            middleNameLabel.Name = "middleNameLabel";
            middleNameLabel.Size = new Size(77, 21);
            middleNameLabel.TabIndex = 2;
            middleNameLabel.Text = "Отчество";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Anchor = AnchorStyles.None;
            firstNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            firstNameTextBox.Location = new Point(269, 85);
            firstNameTextBox.MaximumSize = new Size(350, 0);
            firstNameTextBox.MaxLength = 50;
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(230, 29);
            firstNameTextBox.TabIndex = 3;
            firstNameTextBox.Validating += firstNameTextBox_Validating;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Anchor = AnchorStyles.None;
            lastNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameTextBox.Location = new Point(269, 145);
            lastNameTextBox.MaxLength = 50;
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(230, 29);
            lastNameTextBox.TabIndex = 4;
            lastNameTextBox.Validating += lastNameTextBox_Validating;
            // 
            // middleNameTextBox
            // 
            middleNameTextBox.Anchor = AnchorStyles.None;
            middleNameTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            middleNameTextBox.Location = new Point(269, 205);
            middleNameTextBox.MaxLength = 50;
            middleNameTextBox.Name = "middleNameTextBox";
            middleNameTextBox.Size = new Size(230, 29);
            middleNameTextBox.TabIndex = 5;
            middleNameTextBox.Validating += middleNameTextBox_Validating;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.None;
            loginButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            loginButton.Location = new Point(261, 272);
            loginButton.Margin = new Padding(3, 15, 3, 3);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(163, 42);
            loginButton.TabIndex = 6;
            loginButton.Text = "Войти";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // greetingLabel
            // 
            greetingLabel.Anchor = AnchorStyles.None;
            greetingLabel.AutoSize = true;
            greetingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            greetingLabel.Location = new Point(163, 46);
            greetingLabel.Margin = new Padding(3, 0, 3, 15);
            greetingLabel.Name = "greetingLabel";
            greetingLabel.Size = new Size(359, 21);
            greetingLabel.TabIndex = 7;
            greetingLabel.Text = "Добро пожаловать в программу \"Гений-Идиот\"!";
            // 
            // loginFormErrorProvider
            // 
            loginFormErrorProvider.ContainerControl = this;
            // 
            // firstNameValidationLabel
            // 
            firstNameValidationLabel.Anchor = AnchorStyles.None;
            firstNameValidationLabel.AutoSize = true;
            firstNameValidationLabel.ForeColor = Color.Red;
            firstNameValidationLabel.Location = new Point(272, 122);
            firstNameValidationLabel.Name = "firstNameValidationLabel";
            firstNameValidationLabel.Size = new Size(105, 15);
            firstNameValidationLabel.TabIndex = 8;
            firstNameValidationLabel.Text = "Валидация имени";
            firstNameValidationLabel.Visible = false;
            // 
            // lastNameValidationLabel
            // 
            lastNameValidationLabel.Anchor = AnchorStyles.None;
            lastNameValidationLabel.AutoSize = true;
            lastNameValidationLabel.ForeColor = Color.Red;
            lastNameValidationLabel.Location = new Point(272, 182);
            lastNameValidationLabel.Name = "lastNameValidationLabel";
            lastNameValidationLabel.Size = new Size(121, 15);
            lastNameValidationLabel.TabIndex = 9;
            lastNameValidationLabel.Text = "Валидация фамилии";
            lastNameValidationLabel.Visible = false;
            // 
            // middleNameValidationLabel
            // 
            middleNameValidationLabel.Anchor = AnchorStyles.None;
            middleNameValidationLabel.AutoSize = true;
            middleNameValidationLabel.ForeColor = Color.Red;
            middleNameValidationLabel.Location = new Point(273, 242);
            middleNameValidationLabel.Name = "middleNameValidationLabel";
            middleNameValidationLabel.Size = new Size(118, 15);
            middleNameValidationLabel.TabIndex = 10;
            middleNameValidationLabel.Text = "Валидация отчество";
            middleNameValidationLabel.Visible = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(684, 361);
            Controls.Add(middleNameValidationLabel);
            Controls.Add(lastNameValidationLabel);
            Controls.Add(firstNameValidationLabel);
            Controls.Add(greetingLabel);
            Controls.Add(firstNameTextBox);
            Controls.Add(middleNameLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Controls.Add(loginButton);
            Controls.Add(lastNameTextBox);
            Controls.Add(middleNameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(700, 400);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Гений-Идиот • Авторизация";
            ((System.ComponentModel.ISupportInitialize)loginFormErrorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label middleNameLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox middleNameTextBox;
        private Button loginButton;
        private Label greetingLabel;
        private ErrorProvider loginFormErrorProvider;
        private Label middleNameValidationLabel;
        private Label lastNameValidationLabel;
        private Label firstNameValidationLabel;
    }
}