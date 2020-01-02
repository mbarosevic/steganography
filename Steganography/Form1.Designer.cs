﻿namespace Steganography
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
            this.lblEncodeFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbxEncode = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxDecode = new System.Windows.Forms.GroupBox();
            this.tbxHiddenMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDecodeFilePath = new System.Windows.Forms.Label();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedImage)).BeginInit();
            this.gbxEncode.SuspendLayout();
            this.gbxDecode.SuspendLayout();
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
            // lblEncodeFilePath
            // 
            this.lblEncodeFilePath.AutoSize = true;
            this.lblEncodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncodeFilePath.Location = new System.Drawing.Point(6, 50);
            this.lblEncodeFilePath.Name = "lblEncodeFilePath";
            this.lblEncodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblEncodeFilePath.TabIndex = 1;
            this.lblEncodeFilePath.Text = "No file selected";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(6, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(83, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.EncodeBrowseBtnClick);
            // 
            // gbxEncode
            // 
            this.gbxEncode.Controls.Add(this.btnEncode);
            this.gbxEncode.Controls.Add(this.textBox1);
            this.gbxEncode.Controls.Add(this.btnBrowse);
            this.gbxEncode.Controls.Add(this.lblEncodeFilePath);
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
            // gbxDecode
            // 
            this.gbxDecode.Controls.Add(this.btnDecode);
            this.gbxDecode.Controls.Add(this.tbxHiddenMessage);
            this.gbxDecode.Controls.Add(this.button1);
            this.gbxDecode.Controls.Add(this.lblDecodeFilePath);
            this.gbxDecode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDecode.Location = new System.Drawing.Point(13, 221);
            this.gbxDecode.Name = "gbxDecode";
            this.gbxDecode.Size = new System.Drawing.Size(275, 140);
            this.gbxDecode.TabIndex = 5;
            this.gbxDecode.TabStop = false;
            this.gbxDecode.Text = "Decode";
            // 
            // tbxHiddenMessage
            // 
            this.tbxHiddenMessage.BackColor = System.Drawing.SystemColors.Window;
            this.tbxHiddenMessage.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbxHiddenMessage.Location = new System.Drawing.Point(9, 77);
            this.tbxHiddenMessage.Multiline = true;
            this.tbxHiddenMessage.Name = "tbxHiddenMessage";
            this.tbxHiddenMessage.Size = new System.Drawing.Size(261, 53);
            this.tbxHiddenMessage.TabIndex = 4;
            this.tbxHiddenMessage.Text = "Hidden message...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DecodeBrowseBtnClick);
            // 
            // lblDecodeFilePath
            // 
            this.lblDecodeFilePath.AutoSize = true;
            this.lblDecodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecodeFilePath.Location = new System.Drawing.Point(6, 50);
            this.lblDecodeFilePath.Name = "lblDecodeFilePath";
            this.lblDecodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblDecodeFilePath.TabIndex = 1;
            this.lblDecodeFilePath.Text = "No file selected";
            // 
            // btnDecode
            // 
            this.btnDecode.Location = new System.Drawing.Point(194, 24);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // btnEncode
            // 
            this.btnEncode.Location = new System.Drawing.Point(195, 24);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(75, 23);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(697, 382);
            this.Controls.Add(this.gbxDecode);
            this.Controls.Add(this.pbxSelectedImage);
            this.Controls.Add(this.gbxEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedImage)).EndInit();
            this.gbxEncode.ResumeLayout(false);
            this.gbxEncode.PerformLayout();
            this.gbxDecode.ResumeLayout(false);
            this.gbxDecode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSelectedImage;
        private System.Windows.Forms.Label lblEncodeFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gbxEncode;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gbxDecode;
        private System.Windows.Forms.TextBox tbxHiddenMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDecodeFilePath;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
    }
}
