namespace png2bclim
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
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GB_Options = new System.Windows.Forms.GroupBox();
            this.CB_Out = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CHK_NoCrop = new System.Windows.Forms.CheckBox();
            this.CHK_AutoSavePNG = new System.Windows.Forms.CheckBox();
            this.PaletteBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.L_FileFormat = new System.Windows.Forms.Label();
            this.L_TileHeight = new System.Windows.Forms.Label();
            this.L_TileWidth = new System.Windows.Forms.Label();
            this.L_Height = new System.Windows.Forms.Label();
            this.L_Width = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.L_SQREC = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GB_Options.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.B_Open_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(93, 11);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(153, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // GB_Options
            // 
            this.GB_Options.Controls.Add(this.L_SQREC);
            this.GB_Options.Controls.Add(this.comboBox1);
            this.GB_Options.Controls.Add(this.CB_Out);
            this.GB_Options.Location = new System.Drawing.Point(12, 42);
            this.GB_Options.Name = "GB_Options";
            this.GB_Options.Size = new System.Drawing.Size(135, 89);
            this.GB_Options.TabIndex = 10;
            this.GB_Options.TabStop = false;
            this.GB_Options.Text = "BCLIM Output Format";
            // 
            // CB_Out
            // 
            this.CB_Out.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Out.FormattingEnabled = true;
            this.CB_Out.Items.AddRange(new object[] {
            "0 - L8",
            "1 - A8",
            "2 - LA4",
            "3 - LA8",
            "4 - HILO8",
            "5 - RGB565",
            "6 - RGB8 (24bit)",
            "7 - RGBA5551",
            "X - ColorPalette",
            "8 - RGBA4444",
            "9 - RGBA8888",
            "A - ETC1",
            "B - ETC1A4",
            "C - L4",
            "D - A4"});
            this.CB_Out.Location = new System.Drawing.Point(7, 19);
            this.CB_Out.Name = "CB_Out";
            this.CB_Out.Size = new System.Drawing.Size(121, 21);
            this.CB_Out.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CHK_NoCrop);
            this.groupBox1.Controls.Add(this.CHK_AutoSavePNG);
            this.groupBox1.Location = new System.Drawing.Point(12, 137);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 65);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PNG Output Options";
            // 
            // CHK_NoCrop
            // 
            this.CHK_NoCrop.AutoSize = true;
            this.CHK_NoCrop.Location = new System.Drawing.Point(13, 42);
            this.CHK_NoCrop.Name = "CHK_NoCrop";
            this.CHK_NoCrop.Size = new System.Drawing.Size(109, 17);
            this.CHK_NoCrop.TabIndex = 1;
            this.CHK_NoCrop.Text = "Don\'t Crop Result";
            this.CHK_NoCrop.UseVisualStyleBackColor = true;
            // 
            // CHK_AutoSavePNG
            // 
            this.CHK_AutoSavePNG.AutoSize = true;
            this.CHK_AutoSavePNG.Location = new System.Drawing.Point(14, 19);
            this.CHK_AutoSavePNG.Name = "CHK_AutoSavePNG";
            this.CHK_AutoSavePNG.Size = new System.Drawing.Size(97, 17);
            this.CHK_AutoSavePNG.TabIndex = 0;
            this.CHK_AutoSavePNG.Text = "Autosave PNG";
            this.CHK_AutoSavePNG.UseVisualStyleBackColor = true;
            // 
            // PaletteBox
            // 
            this.PaletteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaletteBox.Location = new System.Drawing.Point(153, 37);
            this.PaletteBox.Name = "PaletteBox";
            this.PaletteBox.Size = new System.Drawing.Size(80, 10);
            this.PaletteBox.TabIndex = 28;
            this.PaletteBox.TabStop = false;
            this.PaletteBox.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.L_FileFormat);
            this.groupBox2.Controls.Add(this.L_TileHeight);
            this.groupBox2.Controls.Add(this.L_TileWidth);
            this.groupBox2.Controls.Add(this.L_Height);
            this.groupBox2.Controls.Add(this.L_Width);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(12, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(135, 95);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details:";
            this.groupBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "FileFormat:";
            // 
            // L_FileFormat
            // 
            this.L_FileFormat.AutoSize = true;
            this.L_FileFormat.Location = new System.Drawing.Point(88, 20);
            this.L_FileFormat.Name = "L_FileFormat";
            this.L_FileFormat.Size = new System.Drawing.Size(27, 13);
            this.L_FileFormat.TabIndex = 26;
            this.L_FileFormat.Text = "(fmt)";
            // 
            // L_TileHeight
            // 
            this.L_TileHeight.AutoSize = true;
            this.L_TileHeight.Location = new System.Drawing.Point(88, 73);
            this.L_TileHeight.Name = "L_TileHeight";
            this.L_TileHeight.Size = new System.Drawing.Size(22, 13);
            this.L_TileHeight.TabIndex = 20;
            this.L_TileHeight.Text = "(th)";
            // 
            // L_TileWidth
            // 
            this.L_TileWidth.AutoSize = true;
            this.L_TileWidth.Location = new System.Drawing.Point(88, 60);
            this.L_TileWidth.Name = "L_TileWidth";
            this.L_TileWidth.Size = new System.Drawing.Size(24, 13);
            this.L_TileWidth.TabIndex = 19;
            this.L_TileWidth.Text = "(tw)";
            // 
            // L_Height
            // 
            this.L_Height.AutoSize = true;
            this.L_Height.Location = new System.Drawing.Point(88, 46);
            this.L_Height.Name = "L_Height";
            this.L_Height.Size = new System.Drawing.Size(19, 13);
            this.L_Height.TabIndex = 18;
            this.L_Height.Text = "(h)";
            // 
            // L_Width
            // 
            this.L_Width.AutoSize = true;
            this.L_Width.Location = new System.Drawing.Point(88, 33);
            this.L_Width.Name = "L_Width";
            this.L_Width.Size = new System.Drawing.Size(21, 13);
            this.L_Width.TabIndex = 17;
            this.L_Width.Text = "(w)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Image Width:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Image Height:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Tile Width:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Tile Height:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0 - Rectangle (>64)",
            "1 - Square (Override)"});
            this.comboBox1.Location = new System.Drawing.Point(7, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // L_SQREC
            // 
            this.L_SQREC.AutoSize = true;
            this.L_SQREC.Location = new System.Drawing.Point(9, 46);
            this.L_SQREC.Name = "L_SQREC";
            this.L_SQREC.Size = new System.Drawing.Size(101, 13);
            this.L_SQREC.TabIndex = 2;
            this.L_SQREC.Text = "Square / Rectangle";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 315);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PaletteBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GB_Options);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.MinimumSize = new System.Drawing.Size(385, 210);
            this.Name = "Form1";
            this.Text = "BCLIM Tool";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GB_Options.ResumeLayout(false);
            this.GB_Options.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaletteBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox GB_Options;
        private System.Windows.Forms.ComboBox CB_Out;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CHK_NoCrop;
        private System.Windows.Forms.CheckBox CHK_AutoSavePNG;
        private System.Windows.Forms.PictureBox PaletteBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_FileFormat;
        private System.Windows.Forms.Label L_TileHeight;
        private System.Windows.Forms.Label L_TileWidth;
        private System.Windows.Forms.Label L_Height;
        private System.Windows.Forms.Label L_Width;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_SQREC;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

