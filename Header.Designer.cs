
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
            this.Profile = new System.Windows.Forms.Panel();
            this.Username = new System.Windows.Forms.Label();
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
            // Header
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Profile);
            this.Name = "Header";
            this.Size = new System.Drawing.Size(1406, 112);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Profile;
        private System.Windows.Forms.Label Username;
    }
}
