namespace Steganography
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.lblEncodeFilePath = new System.Windows.Forms.Label();
            this.btnEncode = new System.Windows.Forms.Button();
            this.tbxTextToEncode = new System.Windows.Forms.TextBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.lblDecodeFilePath = new System.Windows.Forms.Label();
            this.tbxHiddenMessage = new System.Windows.Forms.TextBox();
            this.btnDecode = new MaterialSkin.Controls.MaterialFlatButton();
            this.button1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnBrowse = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.White;
            this.pbxImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxImage.BackgroundImage")));
            this.pbxImage.Location = new System.Drawing.Point(378, 79);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(504, 464);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 0;
            this.pbxImage.TabStop = false;
            // 
            // lblEncodeFilePath
            // 
            this.lblEncodeFilePath.AutoSize = true;
            this.lblEncodeFilePath.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEncodeFilePath.Location = new System.Drawing.Point(9, 191);
            this.lblEncodeFilePath.Name = "lblEncodeFilePath";
            this.lblEncodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblEncodeFilePath.TabIndex = 1;
            this.lblEncodeFilePath.Text = "No file selected";
            // 
            // btnEncode
            // 
            this.btnEncode.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncode.Location = new System.Drawing.Point(223, 140);
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
            this.tbxTextToEncode.Location = new System.Drawing.Point(12, 220);
            this.tbxTextToEncode.Multiline = true;
            this.tbxTextToEncode.Name = "tbxTextToEncode";
            this.tbxTextToEncode.Size = new System.Drawing.Size(327, 108);
            this.tbxTextToEncode.TabIndex = 4;
            this.tbxTextToEncode.Text = "Enter your text here...";
            this.tbxTextToEncode.Click += new System.EventHandler(this.TextBoxEncodeClicked);
            this.tbxTextToEncode.Leave += new System.EventHandler(this.TextBoxEncodeFocusLeft);
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.Location = new System.Drawing.Point(782, 0);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 6;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // lblDecodeFilePath
            // 
            this.lblDecodeFilePath.AutoSize = true;
            this.lblDecodeFilePath.BackColor = System.Drawing.Color.Transparent;
            this.lblDecodeFilePath.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDecodeFilePath.Location = new System.Drawing.Point(9, 433);
            this.lblDecodeFilePath.Name = "lblDecodeFilePath";
            this.lblDecodeFilePath.Size = new System.Drawing.Size(86, 13);
            this.lblDecodeFilePath.TabIndex = 1;
            this.lblDecodeFilePath.Text = "No file selected";
            // 
            // tbxHiddenMessage
            // 
            this.tbxHiddenMessage.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbxHiddenMessage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxHiddenMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxHiddenMessage.Location = new System.Drawing.Point(12, 458);
            this.tbxHiddenMessage.Multiline = true;
            this.tbxHiddenMessage.Name = "tbxHiddenMessage";
            this.tbxHiddenMessage.ReadOnly = true;
            this.tbxHiddenMessage.Size = new System.Drawing.Size(344, 85);
            this.tbxHiddenMessage.TabIndex = 4;
            this.tbxHiddenMessage.Text = "Hidden message...";
            // 
            // btnDecode
            // 
            this.btnDecode.AutoSize = true;
            this.btnDecode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecode.Depth = 0;
            this.btnDecode.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDecode.Icon = null;
            this.btnDecode.Location = new System.Drawing.Point(283, 381);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnDecode.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Primary = false;
            this.btnDecode.Size = new System.Drawing.Size(73, 36);
            this.btnDecode.TabIndex = 7;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Depth = 0;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Icon = null;
            this.button1.Location = new System.Drawing.Point(12, 381);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.button1.MouseState = MaterialSkin.MouseState.HOVER;
            this.button1.Name = "button1";
            this.button1.Primary = false;
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel1.Location = new System.Drawing.Point(12, 342);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 9;
            this.metroSetLabel1.Text = "DECODE";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.Location = new System.Drawing.Point(12, 368);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider1.Size = new System.Drawing.Size(344, 4);
            this.metroSetDivider1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 10;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroLite";
            this.metroSetDivider1.Thickness = 1;
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.Location = new System.Drawing.Point(12, 124);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider2.Size = new System.Drawing.Size(344, 4);
            this.metroSetDivider2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetDivider2.StyleManager = null;
            this.metroSetDivider2.TabIndex = 12;
            this.metroSetDivider2.Text = "metroSetDivider2";
            this.metroSetDivider2.ThemeAuthor = "Narwin";
            this.metroSetDivider2.ThemeName = "MetroLite";
            this.metroSetDivider2.Thickness = 1;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel2.Location = new System.Drawing.Point(12, 98);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 13;
            this.metroSetLabel2.Text = "ENCODE";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBrowse.Depth = 0;
            this.btnBrowse.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBrowse.Icon = null;
            this.btnBrowse.Location = new System.Drawing.Point(12, 137);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBrowse.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Primary = false;
            this.btnBrowse.Size = new System.Drawing.Size(76, 36);
            this.btnBrowse.TabIndex = 14;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(891, 558);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetDivider2);
            this.Controls.Add(this.lblEncodeFilePath);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.metroSetDivider1);
            this.Controls.Add(this.tbxTextToEncode);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.lblDecodeFilePath);
            this.Controls.Add(this.tbxHiddenMessage);
            this.Controls.Add(this.pbxImage);
            this.HeaderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "MainForm";
            this.SmallLineColor1 = System.Drawing.SystemColors.ControlDarkDark;
            this.SmallLineColor2 = System.Drawing.SystemColors.ControlDarkDark;
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private System.Windows.Forms.Label lblEncodeFilePath;
        private System.Windows.Forms.TextBox tbxTextToEncode;
        private System.Windows.Forms.Button btnEncode;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private System.Windows.Forms.Label lblDecodeFilePath;
        private System.Windows.Forms.TextBox tbxHiddenMessage;
        private MaterialSkin.Controls.MaterialFlatButton btnDecode;
        private MaterialSkin.Controls.MaterialFlatButton button1;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnBrowse;
    }
}

