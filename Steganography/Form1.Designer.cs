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
            ((System.ComponentModel.ISupportInitialize)(this.pbxSelectedImage)).BeginInit();
            this.gbxEncode.SuspendLayout();
            this.gbxDecode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxSelectedImage
            // 
            this.pbxSelectedImage.Location = new System.Drawing.Point(378, 23);
            this.pbxSelectedImage.Name = "pbxSelectedImage";
            this.pbxSelectedImage.Size = new System.Drawing.Size(489, 437);
            this.pbxSelectedImage.TabIndex = 0;
            this.pbxSelectedImage.TabStop = false;
            // 
            // lblEncodeFilePath
            // 
            this.lblEncodeFilePath.AutoSize = true;
            this.lblEncodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncodeFilePath.Location = new System.Drawing.Point(14, 61);
            this.lblEncodeFilePath.Name = "lblEncodeFilePath";
            this.lblEncodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblEncodeFilePath.TabIndex = 1;
            this.lblEncodeFilePath.Text = "No file selected";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(17, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(94, 30);
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
            this.gbxEncode.Location = new System.Drawing.Point(12, 23);
            this.gbxEncode.Name = "gbxEncode";
            this.gbxEncode.Size = new System.Drawing.Size(360, 216);
            this.gbxEncode.TabIndex = 3;
            this.gbxEncode.TabStop = false;
            this.gbxEncode.Text = "Encode";
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(195, 24);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(84, 30);
            this.btnEncode.TabIndex = 6;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.EncodeBtnClick);
            // 
            // tbxTextToEncode
            // 
            this.tbxTextToEncode.BackColor = System.Drawing.SystemColors.Window;
            this.tbxTextToEncode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxTextToEncode.Location = new System.Drawing.Point(17, 86);
            this.tbxTextToEncode.Multiline = true;
            this.tbxTextToEncode.Name = "tbxTextToEncode";
            this.tbxTextToEncode.Size = new System.Drawing.Size(327, 108);
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
            this.gbxDecode.Location = new System.Drawing.Point(12, 244);
            this.gbxDecode.Name = "gbxDecode";
            this.gbxDecode.Size = new System.Drawing.Size(360, 216);
            this.gbxDecode.TabIndex = 5;
            this.gbxDecode.TabStop = false;
            this.gbxDecode.Text = "Decode";
            // 
            // btnDecode
            // 
            this.btnDecode.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecode.Location = new System.Drawing.Point(194, 24);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(94, 30);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.DecodeBtnClick);
            // 
            // tbxHiddenMessage
            // 
            this.tbxHiddenMessage.BackColor = System.Drawing.SystemColors.Window;
            this.tbxHiddenMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxHiddenMessage.Location = new System.Drawing.Point(17, 91);
            this.tbxHiddenMessage.Multiline = true;
            this.tbxHiddenMessage.Name = "tbxHiddenMessage";
            this.tbxHiddenMessage.Size = new System.Drawing.Size(327, 108);
            this.tbxHiddenMessage.TabIndex = 4;
            this.tbxHiddenMessage.Text = "Hidden message...";
            this.tbxHiddenMessage.Click += new System.EventHandler(this.TextBoxDecodeClicked);
            this.tbxHiddenMessage.TextChanged += new System.EventHandler(this.TextBoxDecodeClicked);
            this.tbxHiddenMessage.Leave += new System.EventHandler(this.TextBoxDecodeFocusLeft);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(17, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.DecodeBrowseBtnClick);
            // 
            // lblDecodeFilePath
            // 
            this.lblDecodeFilePath.AutoSize = true;
            this.lblDecodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecodeFilePath.Location = new System.Drawing.Point(14, 65);
            this.lblDecodeFilePath.Name = "lblDecodeFilePath";
            this.lblDecodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblDecodeFilePath.TabIndex = 1;
            this.lblDecodeFilePath.Text = "No file selected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(879, 481);
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
        private System.Windows.Forms.TextBox tbxTextToEncode;
        private System.Windows.Forms.GroupBox gbxDecode;
        private System.Windows.Forms.TextBox tbxHiddenMessage;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblDecodeFilePath;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.Button btnDecode;
    }
}

