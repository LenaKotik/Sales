
namespace Sales
{
    partial class DeviceSelectionForm
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.Head = new Sales.Header();
            this.DeviceBox = new System.Windows.Forms.ComboBox();
            this.VendorBox = new System.Windows.Forms.ComboBox();
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(343, 202);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(121, 23);
            label1.TabIndex = 1;
            label1.Text = "Тип устройства";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(626, 202);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(121, 23);
            label2.TabIndex = 3;
            label2.Text = "Производитель";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(911, 202);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(121, 23);
            label3.TabIndex = 5;
            label3.Text = "Модель устройства";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.Head.Location = new System.Drawing.Point(0, 0);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(1358, 116);
            this.Head.TabIndex = 0;
            this.Head.User = null;
            // 
            // DeviceBox
            // 
            this.DeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceBox.FormattingEnabled = true;
            this.DeviceBox.Location = new System.Drawing.Point(343, 228);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(121, 23);
            this.DeviceBox.TabIndex = 2;
            // 
            // VendorBox
            // 
            this.VendorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendorBox.FormattingEnabled = true;
            this.VendorBox.Location = new System.Drawing.Point(626, 228);
            this.VendorBox.Name = "VendorBox";
            this.VendorBox.Size = new System.Drawing.Size(121, 23);
            this.VendorBox.TabIndex = 4;
            // 
            // ModelBox
            // 
            this.ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(911, 228);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(121, 23);
            this.ModelBox.TabIndex = 6;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(649, 500);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 7;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // DeviceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(label3);
            this.Controls.Add(this.VendorBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.DeviceBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeviceSelection";
            this.Text = "DeviceSelection";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Header Head;
        private System.Windows.Forms.ComboBox DeviceBox;
        private System.Windows.Forms.ComboBox VendorBox;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.Button SearchButton;
    }
}