﻿
namespace Sales
{
    partial class Header
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.Profile = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.AdminButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LogOutButton = new System.Windows.Forms.Button();
            this.BackDrawPanel = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            this.ButtonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Profile
            // 
            this.Profile.Location = new System.Drawing.Point(1250, 3);
            this.Profile.Name = "Profile";
            this.Profile.Size = new System.Drawing.Size(100, 100);
            this.Profile.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.Font = new System.Drawing.Font("Sitka Banner", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Username.Location = new System.Drawing.Point(1065, 29);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(179, 49);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(195)))), ((int)(((byte)(195)))));
            this.ButtonsPanel.Controls.Add(this.AdminButton);
            this.ButtonsPanel.Controls.Add(this.button3);
            this.ButtonsPanel.Controls.Add(this.button2);
            this.ButtonsPanel.Controls.Add(this.LogOutButton);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 119);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(1400, 40);
            this.ButtonsPanel.TabIndex = 2;
            // 
            // AdminButton
            // 
            this.AdminButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AdminButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AdminButton.Location = new System.Drawing.Point(869, 3);
            this.AdminButton.Name = "AdminButton";
            this.AdminButton.Size = new System.Drawing.Size(110, 34);
            this.AdminButton.TabIndex = 3;
            this.AdminButton.Text = "Админ";
            this.AdminButton.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(985, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "OtherButton";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(1101, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "SomeButton";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // LogOutButton
            // 
            this.LogOutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LogOutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LogOutButton.Location = new System.Drawing.Point(1217, 3);
            this.LogOutButton.Name = "LogOutButton";
            this.LogOutButton.Size = new System.Drawing.Size(110, 34);
            this.LogOutButton.TabIndex = 0;
            this.LogOutButton.Text = "Выйти";
            this.LogOutButton.UseVisualStyleBackColor = false;
            // 
            // BackDrawPanel
            // 
            this.BackDrawPanel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackDrawPanel.Location = new System.Drawing.Point(3, 29);
            this.BackDrawPanel.Name = "BackDrawPanel";
            this.BackDrawPanel.Size = new System.Drawing.Size(50, 50);
            this.BackDrawPanel.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            label1.Location = new System.Drawing.Point(59, 43);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(73, 30);
            label1.TabIndex = 3;
            label1.Text = "Назад";
            // 
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(label1);
            this.Controls.Add(this.BackDrawPanel);
            this.Controls.Add(this.ButtonsPanel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Profile);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1406, 162);
            this.ButtonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Profile;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button LogOutButton;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button AdminButton;
        private System.Windows.Forms.Panel BackDrawPanel;
    }
}