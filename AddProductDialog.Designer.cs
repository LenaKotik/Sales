
namespace Sales
{
    partial class AddProductDialog
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
            this.DeviceBox = new System.Windows.Forms.ComboBox();
            this.DeviceNVBox = new System.Windows.Forms.TextBox();
            this.VendorNVBox = new System.Windows.Forms.TextBox();
            this.VendorBox = new System.Windows.Forms.ComboBox();
            this.ModelNVBox = new System.Windows.Forms.TextBox();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.TypeNVBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.ProductOFD = new System.Windows.Forms.OpenFileDialog();
            this.LoadB = new System.Windows.Forms.Button();
            this.SubmitEP = new System.Windows.Forms.ErrorProvider(this.components);
            this.CancelB = new System.Windows.Forms.Button();
            this.SubmitB = new System.Windows.Forms.Button();
            this.MaterialBox = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SubmitEP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(17, 13);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 21);
            label1.TabIndex = 0;
            label1.Text = "Тип устройства";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(17, 72);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 21);
            label2.TabIndex = 3;
            label2.Text = "Производитель";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(258, 13);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 21);
            label3.TabIndex = 6;
            label3.Text = "Модель";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(258, 74);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(121, 21);
            label4.TabIndex = 9;
            label4.Text = "Тип";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeviceBox
            // 
            this.DeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceBox.FormattingEnabled = true;
            this.DeviceBox.Location = new System.Drawing.Point(17, 37);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(121, 23);
            this.DeviceBox.TabIndex = 1;
            // 
            // DeviceNVBox
            // 
            this.DeviceNVBox.Location = new System.Drawing.Point(143, 37);
            this.DeviceNVBox.Name = "DeviceNVBox";
            this.DeviceNVBox.PlaceholderText = "Новое значение";
            this.DeviceNVBox.Size = new System.Drawing.Size(100, 23);
            this.DeviceNVBox.TabIndex = 2;
            this.DeviceNVBox.Visible = false;
            // 
            // VendorNVBox
            // 
            this.VendorNVBox.Location = new System.Drawing.Point(143, 96);
            this.VendorNVBox.Name = "VendorNVBox";
            this.VendorNVBox.PlaceholderText = "Новое значение";
            this.VendorNVBox.Size = new System.Drawing.Size(100, 23);
            this.VendorNVBox.TabIndex = 5;
            this.VendorNVBox.Visible = false;
            // 
            // VendorBox
            // 
            this.VendorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendorBox.FormattingEnabled = true;
            this.VendorBox.Location = new System.Drawing.Point(17, 96);
            this.VendorBox.Name = "VendorBox";
            this.VendorBox.Size = new System.Drawing.Size(121, 23);
            this.VendorBox.TabIndex = 4;
            // 
            // ModelNVBox
            // 
            this.ModelNVBox.Location = new System.Drawing.Point(384, 37);
            this.ModelNVBox.Name = "ModelNVBox";
            this.ModelNVBox.PlaceholderText = "Новое значение";
            this.ModelNVBox.Size = new System.Drawing.Size(100, 23);
            this.ModelNVBox.TabIndex = 8;
            this.ModelNVBox.Visible = false;
            // 
            // ModelBox
            // 
            this.ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(258, 37);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(121, 23);
            this.ModelBox.TabIndex = 7;
            // 
            // TypeNVBox
            // 
            this.TypeNVBox.Location = new System.Drawing.Point(384, 98);
            this.TypeNVBox.Name = "TypeNVBox";
            this.TypeNVBox.PlaceholderText = "Новое значение";
            this.TypeNVBox.Size = new System.Drawing.Size(100, 23);
            this.TypeNVBox.TabIndex = 11;
            this.TypeNVBox.Visible = false;
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(258, 98);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(121, 23);
            this.TypeBox.TabIndex = 10;
            // 
            // ProductOFD
            // 
            this.ProductOFD.DefaultExt = "eps";
            this.ProductOFD.FileName = "openFileDialog1";
            this.ProductOFD.ReadOnlyChecked = true;
            this.ProductOFD.ValidateNames = false;
            // 
            // LoadB
            // 
            this.LoadB.Location = new System.Drawing.Point(348, 172);
            this.LoadB.Name = "LoadB";
            this.LoadB.Size = new System.Drawing.Size(75, 23);
            this.LoadB.TabIndex = 13;
            this.LoadB.Text = "Загрузить";
            this.LoadB.UseVisualStyleBackColor = true;
            // 
            // SubmitEP
            // 
            this.SubmitEP.ContainerControl = this;
            // 
            // CancelB
            // 
            this.CancelB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CancelB.Location = new System.Drawing.Point(63, 172);
            this.CancelB.Name = "CancelB";
            this.CancelB.Size = new System.Drawing.Size(75, 23);
            this.CancelB.TabIndex = 15;
            this.CancelB.Text = "Отмена";
            this.CancelB.UseVisualStyleBackColor = false;
            // 
            // SubmitB
            // 
            this.SubmitB.Location = new System.Drawing.Point(203, 172);
            this.SubmitB.Name = "SubmitB";
            this.SubmitB.Size = new System.Drawing.Size(75, 23);
            this.SubmitB.TabIndex = 16;
            this.SubmitB.Text = "Добавить";
            this.SubmitB.UseVisualStyleBackColor = true;
            // 
            // MaterialBox
            // 
            this.MaterialBox.Location = new System.Drawing.Point(191, 143);
            this.MaterialBox.Name = "MaterialBox";
            this.MaterialBox.PlaceholderText = "Тип плёнки";
            this.MaterialBox.Size = new System.Drawing.Size(100, 23);
            this.MaterialBox.TabIndex = 17;
            // 
            // AddProductDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 207);
            this.ControlBox = false;
            this.Controls.Add(this.MaterialBox);
            this.Controls.Add(this.SubmitB);
            this.Controls.Add(this.CancelB);
            this.Controls.Add(this.LoadB);
            this.Controls.Add(this.TypeNVBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(label4);
            this.Controls.Add(this.ModelNVBox);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.VendorNVBox);
            this.Controls.Add(this.VendorBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.DeviceNVBox);
            this.Controls.Add(this.DeviceBox);
            this.Controls.Add(label1);
            this.Name = "AddProductDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "AddProductDialog";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.SubmitEP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox DeviceBox;
        private System.Windows.Forms.TextBox DeviceNVBox;
        private System.Windows.Forms.TextBox VendorNVBox;
        private System.Windows.Forms.ComboBox VendorBox;
        private System.Windows.Forms.TextBox ModelNVBox;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.TextBox TypeNVBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.OpenFileDialog ProductOFD;
        private System.Windows.Forms.Button LoadB;
        private System.Windows.Forms.ErrorProvider SubmitEP;
        private System.Windows.Forms.Button CancelB;
        private System.Windows.Forms.Button SubmitB;
        private System.Windows.Forms.TextBox MaterialBox;
    }
}