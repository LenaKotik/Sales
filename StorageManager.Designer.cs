
namespace Sales
{
    partial class StorageManager
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
            System.Windows.Forms.Panel panel1;
            System.Windows.Forms.Label label1;
            this.OpenBranchButt = new System.Windows.Forms.Button();
            this.BranchUpDown = new System.Windows.Forms.NumericUpDown();
            this.ItemsBox = new System.Windows.Forms.GroupBox();
            this.AddButt = new System.Windows.Forms.Button();
            this.SaveButt = new System.Windows.Forms.Button();
            this.ItemErr = new System.Windows.Forms.ErrorProvider(this.components);
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BranchUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemErr)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panel1.Controls.Add(this.SaveButt);
            panel1.Controls.Add(this.AddButt);
            panel1.Controls.Add(this.OpenBranchButt);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(this.BranchUpDown);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(346, 410);
            panel1.TabIndex = 0;
            // 
            // OpenBranchButt
            // 
            this.OpenBranchButt.Location = new System.Drawing.Point(117, 288);
            this.OpenBranchButt.Name = "OpenBranchButt";
            this.OpenBranchButt.Size = new System.Drawing.Size(93, 31);
            this.OpenBranchButt.TabIndex = 2;
            this.OpenBranchButt.Text = "Открыть";
            this.OpenBranchButt.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(71, 130);
            label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(189, 25);
            label1.TabIndex = 1;
            label1.Text = "Выберите филиал";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BranchUpDown
            // 
            this.BranchUpDown.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BranchUpDown.Location = new System.Drawing.Point(71, 188);
            this.BranchUpDown.Margin = new System.Windows.Forms.Padding(5);
            this.BranchUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.BranchUpDown.Name = "BranchUpDown";
            this.BranchUpDown.Size = new System.Drawing.Size(189, 32);
            this.BranchUpDown.TabIndex = 0;
            // 
            // ItemsBox
            // 
            this.ItemsBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.ItemsBox.Location = new System.Drawing.Point(346, 0);
            this.ItemsBox.Name = "ItemsBox";
            this.ItemsBox.Size = new System.Drawing.Size(541, 410);
            this.ItemsBox.TabIndex = 4;
            this.ItemsBox.TabStop = false;
            this.ItemsBox.Text = "Содержимое склада";
            // 
            // AddButt
            // 
            this.AddButt.Location = new System.Drawing.Point(289, 355);
            this.AddButt.Name = "AddButt";
            this.AddButt.Size = new System.Drawing.Size(50, 50);
            this.AddButt.TabIndex = 0;
            this.AddButt.UseVisualStyleBackColor = true;
            // 
            // SaveButt
            // 
            this.SaveButt.Location = new System.Drawing.Point(108, 355);
            this.SaveButt.Name = "SaveButt";
            this.SaveButt.Size = new System.Drawing.Size(117, 31);
            this.SaveButt.TabIndex = 3;
            this.SaveButt.Text = "Сохранить";
            this.SaveButt.UseVisualStyleBackColor = true;
            // 
            // ItemErr
            // 
            this.ItemErr.ContainerControl = this;
            // 
            // StorageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 410);
            this.Controls.Add(this.ItemsBox);
            this.Controls.Add(panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "StorageManager";
            this.Text = "Менеджмент склада";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BranchUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemErr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown BranchUpDown;
        private System.Windows.Forms.Button OpenBranchButt;
        private System.Windows.Forms.GroupBox ItemsBox;
        private System.Windows.Forms.Button AddButt;
        private System.Windows.Forms.Button SaveButt;
        private System.Windows.Forms.ErrorProvider ItemErr;
    }
}