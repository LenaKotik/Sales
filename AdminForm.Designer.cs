
namespace Sales
{
    partial class AdminForm
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
            this.HistLabel = new System.Windows.Forms.Label();
            this.GoBackButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.HistoryView = new System.Windows.Forms.ListBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HistLabel
            // 
            this.HistLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistLabel.Location = new System.Drawing.Point(583, 371);
            this.HistLabel.Name = "HistLabel";
            this.HistLabel.Size = new System.Drawing.Size(251, 32);
            this.HistLabel.TabIndex = 3;
            this.HistLabel.Text = "История операций";
            this.HistLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GoBackButton.Location = new System.Drawing.Point(13, 14);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(86, 33);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddUserButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddUserButton.Location = new System.Drawing.Point(22, 117);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(229, 41);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Добавить пользователя";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // HistoryView
            // 
            this.HistoryView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HistoryView.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HistoryView.FormattingEnabled = true;
            this.HistoryView.ItemHeight = 21;
            this.HistoryView.Location = new System.Drawing.Point(0, 421);
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.Size = new System.Drawing.Size(800, 214);
            this.HistoryView.TabIndex = 4;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProductButton.Location = new System.Drawing.Point(22, 237);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(229, 38);
            this.AddProductButton.TabIndex = 5;
            this.AddProductButton.Text = "Добавить модель";
            this.AddProductButton.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 635);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.HistoryView);
            this.Controls.Add(this.HistLabel);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.GoBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Label HistLabel;
        private System.Windows.Forms.ListBox HistoryView;
        private System.Windows.Forms.Button AddProductButton;
    }
}