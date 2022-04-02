
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
            this.Head = new Sales.Header();
            this.PrintButton = new System.Windows.Forms.Button();
            this.PreviewBox = new System.Windows.Forms.PictureBox();
            this.PreviewErr = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewErr)).BeginInit();
            this.SuspendLayout();
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
            this.PrintButton.Location = new System.Drawing.Point(378, 247);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 23);
            this.PrintButton.TabIndex = 1;
            this.PrintButton.Text = "Печать";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // PreviewBox
            // 
            this.PreviewBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.PreviewBox.Location = new System.Drawing.Point(815, 211);
            this.PreviewBox.Name = "PreviewBox";
            this.PreviewBox.Size = new System.Drawing.Size(400, 400);
            this.PreviewBox.TabIndex = 2;
            this.PreviewBox.TabStop = false;
            // 
            // PreviewErr
            // 
            this.PreviewErr.ContainerControl = this;
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 673);
            this.Controls.Add(this.PreviewBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.Head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.PreviewBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewErr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Header Head;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.PictureBox PreviewBox;
        private System.Windows.Forms.ErrorProvider PreviewErr;
    }
}