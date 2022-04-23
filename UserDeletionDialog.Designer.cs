
namespace Sales
{
    partial class UserDeletionDialog
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
            this.OkButton = new System.Windows.Forms.Button();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.DeletionErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DeletionErr)).BeginInit();
            this.SuspendLayout();
            // 
            // OkButton
            // 
            this.OkButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OkButton.Location = new System.Drawing.Point(118, 73);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(111, 35);
            this.OkButton.TabIndex = 0;
            this.OkButton.Text = "Ок";
            this.OkButton.UseVisualStyleBackColor = true;
            // 
            // CodeBox
            // 
            this.CodeBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeBox.Location = new System.Drawing.Point(97, 24);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.PlaceholderText = "Код продавца";
            this.CodeBox.Size = new System.Drawing.Size(153, 32);
            this.CodeBox.TabIndex = 1;
            // 
            // DeletionErr
            // 
            this.DeletionErr.ContainerControl = this;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Red;
            this.CancelButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.Location = new System.Drawing.Point(236, 77);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(89, 31);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = false;
            // 
            // UserDeletionDialog
            // 
            this.AcceptButton = this.OkButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(337, 127);
            this.ControlBox = false;
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(this.OkButton);
            this.Name = "UserDeletionDialog";
            this.Text = "Удалить пользователя";
            ((System.ComponentModel.ISupportInitialize)(this.DeletionErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.ErrorProvider DeletionErr;
        private System.Windows.Forms.Button CancelButton;
    }
}