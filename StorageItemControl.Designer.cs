
namespace Sales
{
    partial class StorageItemControl
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AmountUpDown = new System.Windows.Forms.NumericUpDown();
            this.EditButt = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(291, 47);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(85, 32);
            label1.TabIndex = 3;
            label1.Text = "Кол-во: ";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.Location = new System.Drawing.Point(23, 47);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(166, 32);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(23, 47);
            this.NameBox.Margin = new System.Windows.Forms.Padding(5);
            this.NameBox.Name = "NameBox";
            this.NameBox.PlaceholderText = "Введите значение";
            this.NameBox.Size = new System.Drawing.Size(166, 32);
            this.NameBox.TabIndex = 1;
            this.NameBox.Visible = false;
            // 
            // AmountUpDown
            // 
            this.AmountUpDown.Location = new System.Drawing.Point(384, 47);
            this.AmountUpDown.Name = "AmountUpDown";
            this.AmountUpDown.Size = new System.Drawing.Size(120, 32);
            this.AmountUpDown.TabIndex = 2;
            // 
            // EditButt
            // 
            this.EditButt.Location = new System.Drawing.Point(197, 47);
            this.EditButt.Name = "EditButt";
            this.EditButt.Size = new System.Drawing.Size(60, 32);
            this.EditButt.TabIndex = 4;
            this.EditButt.Text = "ред.";
            this.EditButt.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Red;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.Location = new System.Drawing.Point(436, 3);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(78, 29);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Text = "удалить";
            this.DeleteButton.UseVisualStyleBackColor = false;
            // 
            // StorageItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButt);
            this.Controls.Add(label1);
            this.Controls.Add(this.AmountUpDown);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NameLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StorageItemControl";
            this.Size = new System.Drawing.Size(517, 100);
            ((System.ComponentModel.ISupportInitialize)(this.AmountUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.NumericUpDown AmountUpDown;
        private System.Windows.Forms.Button EditButt;
        private System.Windows.Forms.Button DeleteButton;
    }
}
