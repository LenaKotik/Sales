
namespace Sales
{
    partial class PasswordConfirmationDialog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label1;
            this.ConfirmationB = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.PasswordErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(363, 66);
            label1.TabIndex = 0;
            label1.Text = "Чтобы совершить данное действие необходимо подтвердить пароль";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfirmationB
            // 
            this.ConfirmationB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ConfirmationB.Location = new System.Drawing.Point(128, 169);
            this.ConfirmationB.Name = "ConfirmationB";
            this.ConfirmationB.Size = new System.Drawing.Size(133, 31);
            this.ConfirmationB.TabIndex = 1;
            this.ConfirmationB.Text = "Подтвердить";
            this.ConfirmationB.UseVisualStyleBackColor = true;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordBox.Location = new System.Drawing.Point(128, 101);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.PlaceholderText = "Пароль";
            this.PasswordBox.Size = new System.Drawing.Size(133, 32);
            this.PasswordBox.TabIndex = 2;
            // 
            // PasswordErr
            // 
            this.PasswordErr.ContainerControl = this;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(277, 169);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 31);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // PasswordConfirmationDialog
            // 
            this.AcceptButton = this.ConfirmationB;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(387, 212);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.ConfirmationB);
            this.Controls.Add(label1);
            this.Name = "PasswordConfirmationDialog";
            this.Text = "Подтвердите пароль";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConfirmationB;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.ErrorProvider PasswordErr;
        private System.Windows.Forms.Button CancelButton;
    }
}