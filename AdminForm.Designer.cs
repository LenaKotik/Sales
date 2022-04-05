
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
            System.Windows.Forms.Label label1;
            this.GoBackButton = new System.Windows.Forms.Button();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.HistoryView = new System.Windows.Forms.DataGridView();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(54, 100);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(240, 23);
            label1.TabIndex = 3;
            label1.Text = "История операций";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GoBackButton
            // 
            this.GoBackButton.Location = new System.Drawing.Point(13, 13);
            this.GoBackButton.Name = "GoBackButton";
            this.GoBackButton.Size = new System.Drawing.Size(75, 23);
            this.GoBackButton.TabIndex = 0;
            this.GoBackButton.Text = "Назад";
            this.GoBackButton.UseVisualStyleBackColor = true;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(623, 126);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(165, 35);
            this.AddUserButton.TabIndex = 1;
            this.AddUserButton.Text = "Добавить пользователя";
            this.AddUserButton.UseVisualStyleBackColor = true;
            // 
            // HistoryView
            // 
            this.HistoryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryView.Location = new System.Drawing.Point(54, 126);
            this.HistoryView.Name = "HistoryView";
            this.HistoryView.ReadOnly = true;
            this.HistoryView.RowTemplate.Height = 25;
            this.HistoryView.Size = new System.Drawing.Size(240, 218);
            this.HistoryView.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(label1);
            this.Controls.Add(this.HistoryView);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.GoBackButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.HistoryView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GoBackButton;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.DataGridView HistoryView;
        private System.Windows.Forms.Label label1;
    }
}