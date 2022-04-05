
namespace Sales
{
    partial class AddUserDialog
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            this.AddUserErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.AddButton = new System.Windows.Forms.Button();
            this.IsAdminFlag = new System.Windows.Forms.CheckBox();
            this.CodeBox = new System.Windows.Forms.TextBox();
            this.PassBox = new System.Windows.Forms.TextBox();
            this.PassBox2 = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.CancelvButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserErr)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(30, 9);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(117, 22);
            label1.TabIndex = 1;
            label1.Text = "Код продавца";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(30, 65);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(117, 17);
            label2.TabIndex = 3;
            label2.Text = "Пароль";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(30, 115);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(117, 28);
            label3.TabIndex = 4;
            label3.Text = "Повторите Пароль";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(192, 9);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(100, 22);
            label4.TabIndex = 8;
            label4.Text = "Имя";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUserErr
            // 
            this.AddUserErr.ContainerControl = this;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(206, 115);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // IsAdminFlag
            // 
            this.IsAdminFlag.AutoSize = true;
            this.IsAdminFlag.Location = new System.Drawing.Point(206, 85);
            this.IsAdminFlag.Name = "IsAdminFlag";
            this.IsAdminFlag.Size = new System.Drawing.Size(63, 19);
            this.IsAdminFlag.TabIndex = 2;
            this.IsAdminFlag.Text = "Админ";
            this.IsAdminFlag.UseVisualStyleBackColor = true;
            // 
            // CodeBox
            // 
            this.CodeBox.Location = new System.Drawing.Point(30, 33);
            this.CodeBox.Name = "CodeBox";
            this.CodeBox.Size = new System.Drawing.Size(117, 23);
            this.CodeBox.TabIndex = 5;
            // 
            // PassBox
            // 
            this.PassBox.Location = new System.Drawing.Point(30, 85);
            this.PassBox.Name = "PassBox";
            this.PassBox.PasswordChar = '*';
            this.PassBox.Size = new System.Drawing.Size(117, 23);
            this.PassBox.TabIndex = 6;
            // 
            // PassBox2
            // 
            this.PassBox2.Location = new System.Drawing.Point(30, 146);
            this.PassBox2.Name = "PassBox2";
            this.PassBox2.PasswordChar = '*';
            this.PassBox2.Size = new System.Drawing.Size(117, 23);
            this.PassBox2.TabIndex = 7;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(192, 34);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 23);
            this.NameBox.TabIndex = 9;
            // 
            // CancelvButton
            // 
            this.CancelvButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.CancelvButton.Location = new System.Drawing.Point(206, 146);
            this.CancelvButton.Name = "CancelvButton";
            this.CancelvButton.Size = new System.Drawing.Size(75, 23);
            this.CancelvButton.TabIndex = 10;
            this.CancelvButton.Text = "Отмена";
            this.CancelvButton.UseVisualStyleBackColor = false;
            // 
            // AddUserDialog
            // 
            this.AcceptButton = this.AddButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 186);
            this.ControlBox = false;
            this.Controls.Add(this.CancelvButton);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.PassBox2);
            this.Controls.Add(this.PassBox);
            this.Controls.Add(this.CodeBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(this.IsAdminFlag);
            this.Controls.Add(label1);
            this.Controls.Add(this.AddButton);
            this.Name = "AddUserDialog";
            this.Opacity = 0.8D;
            this.ShowInTaskbar = false;
            this.Text = "Добавить Пользователя";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.AddUserErr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider AddUserErr;
        private System.Windows.Forms.TextBox PassBox2;
        private System.Windows.Forms.TextBox PassBox;
        private System.Windows.Forms.TextBox CodeBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox IsAdminFlag;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Button CancelvButton;
    }
}