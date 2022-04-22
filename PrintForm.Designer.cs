
namespace Sales
{
    partial class PrintForm
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
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            this.Head = new Sales.Header();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.PreviewErr = new System.Windows.Forms.ErrorProvider(this.components);
            this.ModelBox = new System.Windows.Forms.ComboBox();
            this.VendorBox = new System.Windows.Forms.ComboBox();
            this.DeviceBox = new System.Windows.Forms.ComboBox();
            this.RightPanel = new System.Windows.Forms.Panel();
            this.MaterialLabel = new System.Windows.Forms.Label();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.DeviceLabel = new System.Windows.Forms.Label();
            this.VendorLabel = new System.Windows.Forms.Label();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.PrintDialog = new System.Windows.Forms.PrintDialog();
            this.ClientPhoneBox = new System.Windows.Forms.TextBox();
            this.ClientNameBox = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewErr)).BeginInit();
            this.RightPanel.SuspendLayout();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(44, 248);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(214, 23);
            label3.TabIndex = 11;
            label3.Text = "Модель устройства";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(44, 125);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(214, 23);
            label2.TabIndex = 9;
            label2.Text = "Производитель";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(44, 4);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(214, 23);
            label1.TabIndex = 7;
            label1.Text = "Тип устройства";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(44, 361);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(214, 23);
            label4.TabIndex = 15;
            label4.Text = "Тип";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Head
            // 
            this.Head.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Head.Dock = System.Windows.Forms.DockStyle.Top;
            this.Head.Location = new System.Drawing.Point(0, 0);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(1370, 112);
            this.Head.TabIndex = 0;
            this.Head.User = null;
            // 
            // PrintButton
            // 
            this.PrintButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PrintButton.Location = new System.Drawing.Point(0, 499);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(355, 46);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // PreviewBox
            // 
            this.PreviewBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PreviewBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PreviewBox.Location = new System.Drawing.Point(449, 171);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(516, 600);
            this.PreviewBox.TabIndex = 2;
            this.PreviewBox.TabStop = false;
            // 
            // PreviewErr
            // 
            this.PreviewErr.ContainerControl = this;
            // 
            // ModelBox
            // 
            this.ModelBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModelBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelBox.FormattingEnabled = true;
            this.ModelBox.Location = new System.Drawing.Point(44, 274);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(214, 33);
            this.ModelBox.TabIndex = 12;
            // 
            // VendorBox
            // 
            this.VendorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VendorBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VendorBox.FormattingEnabled = true;
            this.VendorBox.Location = new System.Drawing.Point(44, 151);
            this.VendorBox.Name = "VendorBox";
            this.VendorBox.Size = new System.Drawing.Size(214, 33);
            this.VendorBox.TabIndex = 10;
            // 
            // DeviceBox
            // 
            this.DeviceBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeviceBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceBox.FormattingEnabled = true;
            this.DeviceBox.Location = new System.Drawing.Point(44, 30);
            this.DeviceBox.Name = "DeviceBox";
            this.DeviceBox.Size = new System.Drawing.Size(214, 33);
            this.DeviceBox.TabIndex = 8;
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RightPanel.Controls.Add(this.MaterialLabel);
            this.RightPanel.Controls.Add(this.TypeLabel);
            this.RightPanel.Controls.Add(this.DeviceLabel);
            this.RightPanel.Controls.Add(this.VendorLabel);
            this.RightPanel.Controls.Add(this.ModelLabel);
            this.RightPanel.Controls.Add(this.PrintButton);
            this.RightPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RightPanel.Location = new System.Drawing.Point(1003, 145);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Size = new System.Drawing.Size(355, 545);
            this.RightPanel.TabIndex = 14;
            // 
            // MaterialLabel
            // 
            this.MaterialLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaterialLabel.Location = new System.Drawing.Point(3, 447);
            this.MaterialLabel.Name = "MaterialLabel";
            this.MaterialLabel.Size = new System.Drawing.Size(349, 49);
            this.MaterialLabel.TabIndex = 6;
            this.MaterialLabel.Text = "Плёнка:";
            this.MaterialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TypeLabel
            // 
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.Location = new System.Drawing.Point(3, 363);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(349, 49);
            this.TypeLabel.TabIndex = 5;
            this.TypeLabel.Text = "Тип:";
            this.TypeLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DeviceLabel
            // 
            this.DeviceLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DeviceLabel.Location = new System.Drawing.Point(6, 11);
            this.DeviceLabel.Name = "DeviceLabel";
            this.DeviceLabel.Size = new System.Drawing.Size(349, 49);
            this.DeviceLabel.TabIndex = 4;
            this.DeviceLabel.Text = "Устройство:";
            this.DeviceLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // VendorLabel
            // 
            this.VendorLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VendorLabel.Location = new System.Drawing.Point(3, 149);
            this.VendorLabel.Name = "VendorLabel";
            this.VendorLabel.Size = new System.Drawing.Size(349, 49);
            this.VendorLabel.TabIndex = 3;
            this.VendorLabel.Text = "Производитель:";
            this.VendorLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ModelLabel
            // 
            this.ModelLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModelLabel.Location = new System.Drawing.Point(0, 251);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(349, 49);
            this.ModelLabel.TabIndex = 2;
            this.ModelLabel.Text = "Модель:";
            this.ModelLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Location = new System.Drawing.Point(44, 387);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(214, 33);
            this.TypeBox.TabIndex = 16;
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SearchButton.Location = new System.Drawing.Point(74, 458);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(159, 46);
            this.SearchButton.TabIndex = 17;
            this.SearchButton.Text = "Найти";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // LeftPanel
            // 
            this.LeftPanel.Controls.Add(this.ClientNameBox);
            this.LeftPanel.Controls.Add(this.ClientPhoneBox);
            this.LeftPanel.Controls.Add(label3);
            this.LeftPanel.Controls.Add(this.SearchButton);
            this.LeftPanel.Controls.Add(label1);
            this.LeftPanel.Controls.Add(this.TypeBox);
            this.LeftPanel.Controls.Add(this.DeviceBox);
            this.LeftPanel.Controls.Add(label4);
            this.LeftPanel.Controls.Add(label2);
            this.LeftPanel.Controls.Add(this.VendorBox);
            this.LeftPanel.Controls.Add(this.ModelBox);
            this.LeftPanel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LeftPanel.Location = new System.Drawing.Point(145, 72);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(298, 618);
            this.LeftPanel.TabIndex = 18;
            // 
            // PrintDialog
            // 
            this.PrintDialog.UseEXDialog = true;
            // 
            // ClientPhoneBox
            // 
            this.ClientPhoneBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientPhoneBox.Location = new System.Drawing.Point(74, 520);
            this.ClientPhoneBox.Name = "ClientPhoneBox";
            this.ClientPhoneBox.PlaceholderText = "Телефон клиента";
            this.ClientPhoneBox.Size = new System.Drawing.Size(159, 32);
            this.ClientPhoneBox.TabIndex = 18;
            // 
            // ClientNameBox
            // 
            this.ClientNameBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClientNameBox.Location = new System.Drawing.Point(74, 572);
            this.ClientNameBox.Name = "ClientNameBox";
            this.ClientNameBox.PlaceholderText = "Имя клиента";
            this.ClientNameBox.Size = new System.Drawing.Size(159, 32);
            this.ClientNameBox.TabIndex = 19;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewErr)).EndInit();
            this.RightPanel.ResumeLayout(false);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Header Head;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.ErrorProvider PreviewErr;
        private System.Windows.Forms.ComboBox ModelBox;
        private System.Windows.Forms.ComboBox VendorBox;
        private System.Windows.Forms.ComboBox DeviceBox;
        private System.Windows.Forms.Panel RightPanel;
        private System.Windows.Forms.Label DeviceLabel;
        private System.Windows.Forms.Label VendorLabel;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.PrintDialog PrintDialog;
        private System.Windows.Forms.Label MaterialLabel;
        private System.Windows.Forms.TextBox ClientNameBox;
        private System.Windows.Forms.TextBox ClientPhoneBox;
    }
}