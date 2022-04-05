
namespace Sales
{
    partial class AuthorizationForm
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
            System.Windows.Forms.Label label1;
            this.FormPanel = new System.Windows.Forms.Panel();
            this.codeBox = new System.Windows.Forms.TextBox();
            this.AuthButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.QuitButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.FormPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Top;
            label1.Font = new System.Drawing.Font("Constantia", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(0, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(1315, 85);
            label1.TabIndex = 0;
            label1.Text = "Вход";
            label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FormPanel
            // 
            this.FormPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.FormPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FormPanel.Controls.Add(this.codeBox);
            this.FormPanel.Controls.Add(this.AuthButton);
            this.FormPanel.Controls.Add(this.passwordBox);
            this.FormPanel.Location = new System.Drawing.Point(573, 206);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(200, 100);
            this.FormPanel.TabIndex = 5;
            // 
            // codeBox
            // 
            this.codeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeBox.Location = new System.Drawing.Point(46, 32);
            this.codeBox.Name = "codeBox";
            this.codeBox.PlaceholderText = "Код продавца";
            this.codeBox.Size = new System.Drawing.Size(100, 23);
            this.codeBox.TabIndex = 3;
            // 
            // AuthButton
            // 
            this.AuthButton.Location = new System.Drawing.Point(56, 61);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(80, 23);
            this.AuthButton.TabIndex = 4;
            this.AuthButton.Text = "Войти";
            this.AuthButton.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordBox.Location = new System.Drawing.Point(46, 3);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "Пароль";
            this.passwordBox.Size = new System.Drawing.Size(100, 23);
            this.passwordBox.TabIndex = 2;
            // 
            // QuitButton
            // 
            this.QuitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.QuitButton.Location = new System.Drawing.Point(634, 393);
            this.QuitButton.Name = "QuitButton";
            this.QuitButton.Size = new System.Drawing.Size(75, 23);
            this.QuitButton.TabIndex = 6;
            this.QuitButton.Text = "Выйти";
            this.QuitButton.UseVisualStyleBackColor = false;
            // 
            // AuthorizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 450);
            this.Controls.Add(this.QuitButton);
            this.Controls.Add(this.FormPanel);
            this.Controls.Add(label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AuthorizationForm";
            this.Text = "Авторизация";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormPanel.ResumeLayout(false);
            this.FormPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox codeBox;
        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Button QuitButton;
    }
}

