﻿namespace Steganography
{
    partial class MainForm
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
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblEncodeFilePath = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.gbxEncode = new System.Windows.Forms.GroupBox();
            this.btnEncode = new System.Windows.Forms.Button();
            this.tbxTextToEncode = new System.Windows.Forms.TextBox();
            this.gbxDecode = new System.Windows.Forms.GroupBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.tbxHiddenMessage = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblDecodeFilePath = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.gbxEncode.SuspendLayout();
            this.gbxDecode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.Location = new System.Drawing.Point(504, 28);
            this.pbxImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(652, 538);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // lblEncodeFilePath
            // 
            this.lblEncodeFilePath.AutoSize = true;
            this.lblEncodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncodeFilePath.Location = new System.Drawing.Point(19, 75);
            this.lblEncodeFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEncodeFilePath.Name = "lblEncodeFilePath";
            this.lblEncodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblEncodeFilePath.TabIndex = 1;
            this.lblEncodeFilePath.Text = "No file selected";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(23, 30);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(125, 37);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.EncodeBrowseBtnClick);
            // 
            // gbxEncode
            // 
            this.gbxEncode.Controls.Add(this.btnEncode);
            this.gbxEncode.Controls.Add(this.tbxTextToEncode);
            this.gbxEncode.Controls.Add(this.btnBrowse);
            this.gbxEncode.Controls.Add(this.lblEncodeFilePath);
            this.gbxEncode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEncode.Location = new System.Drawing.Point(16, 28);
            this.gbxEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEncode.Name = "gbxEncode";
            this.gbxEncode.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxEncode.Size = new System.Drawing.Size(480, 266);
            this.gbxEncode.TabIndex = 3;
            this.gbxEncode.TabStop = false;
            this.gbxEncode.Text = "Encode";
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(260, 30);
            this.btnEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(112, 37);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.EncodeBtnClick);
            // 
            // tbxTextToEncode
            // 
            this.tbxTextToEncode.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTextToEncode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTextToEncode.Location = new System.Drawing.Point(23, 106);
            this.tbxTextToEncode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxTextToEncode.Multiline = true;
            this.tbxTextToEncode.Name = "tbxTextToEncode";
            this.tbxTextToEncode.Size = new System.Drawing.Size(435, 132);
            this.tbxTextToEncode.TabIndex = 4;
            this.tbxTextToEncode.Text = "Enter your text here...";
            this.tbxTextToEncode.Click += new System.EventHandler(this.TextBoxEncodeClicked);
            this.tbxTextToEncode.Leave += new System.EventHandler(this.TextBoxEncodeFocusLeft);
            // 
            // gbxDecode
            // 
            this.gbxDecode.Controls.Add(this.btnDecode);
            this.gbxDecode.Controls.Add(this.tbxHiddenMessage);
            this.gbxDecode.Controls.Add(this.button1);
            this.gbxDecode.Controls.Add(this.lblDecodeFilePath);
            this.gbxDecode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxDecode.Location = new System.Drawing.Point(16, 300);
            this.gbxDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDecode.Name = "gbxDecode";
            this.gbxDecode.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxDecode.Size = new System.Drawing.Size(480, 266);
            this.gbxDecode.TabIndex = 5;
            this.gbxDecode.TabStop = false;
            this.gbxDecode.Text = "Decode";
            // 
            // btnDecode
            // 
            this.btnDecode.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(259, 30);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(125, 37);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.DecodeBtnClick);
            // 
            // tbxHiddenMessage
            // 
            this.tbxHiddenMessage.BackColor = System.Drawing.SystemColors.Window;
            this.tbxHiddenMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxHiddenMessage.Location = new System.Drawing.Point(23, 112);
            this.tbxHiddenMessage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxHiddenMessage.Multiline = true;
            this.tbxHiddenMessage.Name = "tbxHiddenMessage";
            this.tbxHiddenMessage.ReadOnly = true;
            this.tbxHiddenMessage.Size = new System.Drawing.Size(435, 132);
            this.tbxHiddenMessage.TabIndex = 4;
            this.tbxHiddenMessage.Text = "Hidden message...";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(23, 30);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DecodeBrowseBtnClick);
            // 
            // lblDecodeFilePath
            // 
            this.lblDecodeFilePath.AutoSize = true;
            this.lblDecodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecodeFilePath.Location = new System.Drawing.Point(19, 80);
            this.lblDecodeFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDecodeFilePath.Name = "lblDecodeFilePath";
            this.lblDecodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblDecodeFilePath.TabIndex = 1;
            this.lblDecodeFilePath.Text = "No file selected";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1172, 592);
            this.Controls.Add(this.gbxDecode);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.gbxEncode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.gbxEncode.ResumeLayout(false);
            this.gbxEncode.PerformLayout();
            this.gbxDecode.ResumeLayout(false);
            this.gbxDecode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblEncodeFilePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.GroupBox gbxEncode;
        private System.Windows.Forms.TextBox tbxTextToEncode;
        private System.Windows.Forms.GroupBox gbxDecode;
        private System.Windows.Forms.TextBox tbxHiddenMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDecodeFilePath;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
    }
}

