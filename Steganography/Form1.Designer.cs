namespace Steganography
{
    partial class Form1
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
            this.pbxSelectedImage = new System.Windows.Forms.PictureBox();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbxEncode = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedImage)).BeginInit();
            this.gbxEncode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxSelectedImage
            // 
            this.pbxSelectedImage.Location = new System.Drawing.Point(294, 23);
            this.pbxSelectedImage.Name = "pbxSelectedImage";
            this.pbxSelectedImage.Size = new System.Drawing.Size(376, 338);
            this.pbxSelectedImage.TabIndex = 0;
            this.pbxSelectedImage.TabStop = false;
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilePath.Location = new System.Drawing.Point(6, 50);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "No file selected";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // gbxEncode
            // 
            this.gbxEncode.Controls.Add(this.textBox1);
            this.gbxEncode.Controls.Add(this.btnBrowse);
            this.gbxEncode.Controls.Add(this.lblFilePath);
            this.gbxEncode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEncode.Location = new System.Drawing.Point(12, 23);
            this.gbxEncode.Name = "gbxEncode";
            this.gbxEncode.Size = new System.Drawing.Size(276, 172);
            this.gbxEncode.TabIndex = 3;
            this.gbxEncode.TabStop = false;
            this.gbxEncode.Text = "Encode";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Location = new System.Drawing.Point(9, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(261, 53);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Enter your text here...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.pbxSelectedImage);
            this.Controls.Add(this.gbxEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedImage)).EndInit();
            this.gbxEncode.ResumeLayout(false);
            this.gbxEncode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSelectedImage;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gbxEncode;
        private System.Windows.Forms.TextBox textBox1;
    }
}

