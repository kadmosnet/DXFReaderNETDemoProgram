namespace DXFReaderNETDemoProgram
{
    partial class HatchSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HatchSelector));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxScale = new System.Windows.Forms.TextBox();
            this.TextBoxRotation = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(198, 301);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(88, 24);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk.Location = new System.Drawing.Point(101, 301);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(88, 24);
            this.ButtonOk.TabIndex = 3;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.White;
            this.PictureBox1.Location = new System.Drawing.Point(124, 39);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(162, 162);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 20;
            this.PictureBox1.TabStop = false;
            // 
            // TextBoxScale
            // 
            this.TextBoxScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxScale.Location = new System.Drawing.Point(124, 233);
            this.TextBoxScale.Name = "TextBoxScale";
            this.TextBoxScale.Size = new System.Drawing.Size(162, 20);
            this.TextBoxScale.TabIndex = 19;
            this.TextBoxScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxScale_KeyPress);
            // 
            // TextBoxRotation
            // 
            this.TextBoxRotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRotation.Location = new System.Drawing.Point(124, 207);
            this.TextBoxRotation.Name = "TextBoxRotation";
            this.TextBoxRotation.Size = new System.Drawing.Size(162, 20);
            this.TextBoxRotation.TabIndex = 18;
            this.TextBoxRotation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRotation_KeyPress);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "SOLID",
            "ANGLE",
            "ANSI31",
            "ANSI32",
            "ANSI33",
            "ANSI34",
            "ANSI35",
            "ANSI36",
            "ANSI37",
            "ANSI38",
            "AR-B816",
            "AR-B816C",
            "AR-B88",
            "AR-BRELM",
            "AR-BRSTD",
            "AR-CONC",
            "AR-HBONE",
            "AR-PARQ1",
            "AR-RROOF",
            "AR-RSHKE",
            "AR-SAND",
            "BOX",
            "BRASS",
            "BRICK",
            "BRSTONE",
            "CLAY",
            "CORK",
            "CROSS",
            "DASH",
            "DOLMIT",
            "DOTS",
            "EARTH",
            "ESCHER",
            "FLEX",
            "GRASS",
            "GRATE",
            "GRAVEL",
            "HEX",
            "HONEY",
            "HOUND",
            "INSUL",
            "ACAD_ISO02W100",
            "ACAD_ISO03W100",
            "ACAD_ISO04W100",
            "ACAD_ISO05W100",
            "ACAD_ISO06W100",
            "ACAD_ISO07W100",
            "ACAD_ISO08W100",
            "ACAD_ISO09W100",
            "ACAD_ISO10W100",
            "ACAD_ISO11W100",
            "ACAD_ISO12W100",
            "ACAD_ISO13W100",
            "ACAD_ISO14W100",
            "ACAD_ISO15W100",
            "LINE",
            "MUDST",
            "NET",
            "NET3",
            "PLAST",
            "PLASTI",
            "SACNCR",
            "SQUARE",
            "STARS",
            "STEEL",
            "SWAMP",
            "TRANS",
            "TRIANG",
            "ZIGZAG"});
            this.ComboBox1.Location = new System.Drawing.Point(124, 12);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(162, 21);
            this.ComboBox1.TabIndex = 17;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 235);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(34, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Scale";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 210);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(89, 13);
            this.Label2.TabIndex = 15;
            this.Label2.Text = "Rotation angle [°]";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Pattern type";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "ACAD_ISO02W100.png");
            this.ImageList1.Images.SetKeyName(1, "ACAD_ISO03W100.png");
            this.ImageList1.Images.SetKeyName(2, "ACAD_ISO04W100.png");
            this.ImageList1.Images.SetKeyName(3, "ACAD_ISO05W100.png");
            this.ImageList1.Images.SetKeyName(4, "ACAD_ISO06W100.png");
            this.ImageList1.Images.SetKeyName(5, "ACAD_ISO07W100.png");
            this.ImageList1.Images.SetKeyName(6, "ACAD_ISO08W100.png");
            this.ImageList1.Images.SetKeyName(7, "ACAD_ISO09W100.png");
            this.ImageList1.Images.SetKeyName(8, "ACAD_ISO10W100.png");
            this.ImageList1.Images.SetKeyName(9, "ACAD_ISO11W100.png");
            this.ImageList1.Images.SetKeyName(10, "ACAD_ISO12W100.png");
            this.ImageList1.Images.SetKeyName(11, "ACAD_ISO13W100.png");
            this.ImageList1.Images.SetKeyName(12, "ACAD_ISO14W100.png");
            this.ImageList1.Images.SetKeyName(13, "ACAD_ISO15W100.png");
            this.ImageList1.Images.SetKeyName(14, "ANGLE.png");
            this.ImageList1.Images.SetKeyName(15, "ANSI31.png");
            this.ImageList1.Images.SetKeyName(16, "ANSI32.png");
            this.ImageList1.Images.SetKeyName(17, "ANSI33.png");
            this.ImageList1.Images.SetKeyName(18, "ANSI34.png");
            this.ImageList1.Images.SetKeyName(19, "ANSI35.png");
            this.ImageList1.Images.SetKeyName(20, "ANSI36.png");
            this.ImageList1.Images.SetKeyName(21, "ANSI37.png");
            this.ImageList1.Images.SetKeyName(22, "ANSI38.png");
            this.ImageList1.Images.SetKeyName(23, "AR-B88.png");
            this.ImageList1.Images.SetKeyName(24, "AR-B816.png");
            this.ImageList1.Images.SetKeyName(25, "AR-B816C.png");
            this.ImageList1.Images.SetKeyName(26, "AR-BRELM.png");
            this.ImageList1.Images.SetKeyName(27, "AR-BRSTD.png");
            this.ImageList1.Images.SetKeyName(28, "AR-CONC.png");
            this.ImageList1.Images.SetKeyName(29, "AR-HBONE.png");
            this.ImageList1.Images.SetKeyName(30, "AR-PARQ1.png");
            this.ImageList1.Images.SetKeyName(31, "AR-RROOF.png");
            this.ImageList1.Images.SetKeyName(32, "AR-RSHKE.png");
            this.ImageList1.Images.SetKeyName(33, "AR-SAND.png");
            this.ImageList1.Images.SetKeyName(34, "BOX.png");
            this.ImageList1.Images.SetKeyName(35, "BRASS.png");
            this.ImageList1.Images.SetKeyName(36, "BRICK.png");
            this.ImageList1.Images.SetKeyName(37, "BRSTONE.png");
            this.ImageList1.Images.SetKeyName(38, "CLAY.png");
            this.ImageList1.Images.SetKeyName(39, "CORK.png");
            this.ImageList1.Images.SetKeyName(40, "CROSS.png");
            this.ImageList1.Images.SetKeyName(41, "DASH.png");
            this.ImageList1.Images.SetKeyName(42, "DOLMIT.png");
            this.ImageList1.Images.SetKeyName(43, "DOTS.png");
            this.ImageList1.Images.SetKeyName(44, "EARTH.png");
            this.ImageList1.Images.SetKeyName(45, "ESCHER.png");
            this.ImageList1.Images.SetKeyName(46, "FLEX.png");
            this.ImageList1.Images.SetKeyName(47, "GRASS.png");
            this.ImageList1.Images.SetKeyName(48, "GRATE.png");
            this.ImageList1.Images.SetKeyName(49, "GRAVEL.png");
            this.ImageList1.Images.SetKeyName(50, "HEX.png");
            this.ImageList1.Images.SetKeyName(51, "HONEY.png");
            this.ImageList1.Images.SetKeyName(52, "HOUND.png");
            this.ImageList1.Images.SetKeyName(53, "INSUL.png");
            this.ImageList1.Images.SetKeyName(54, "LINE.png");
            this.ImageList1.Images.SetKeyName(55, "MUDST.png");
            this.ImageList1.Images.SetKeyName(56, "NET.png");
            this.ImageList1.Images.SetKeyName(57, "NET3.png");
            this.ImageList1.Images.SetKeyName(58, "PLAST.png");
            this.ImageList1.Images.SetKeyName(59, "PLASTI.png");
            this.ImageList1.Images.SetKeyName(60, "SACNCR.png");
            this.ImageList1.Images.SetKeyName(61, "SOLID.png");
            this.ImageList1.Images.SetKeyName(62, "SQUARE.png");
            this.ImageList1.Images.SetKeyName(63, "STARS.png");
            this.ImageList1.Images.SetKeyName(64, "STEEL.png");
            this.ImageList1.Images.SetKeyName(65, "SWAMP.png");
            this.ImageList1.Images.SetKeyName(66, "TRANS.png");
            this.ImageList1.Images.SetKeyName(67, "TRIANG.png");
            this.ImageList1.Images.SetKeyName(68, "ZIGZAG.png");
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Choose single entities",
            "Choose entities by rectangle",
            "Define polygon",
            "Point inside entity"});
            this.comboBox2.Location = new System.Drawing.Point(124, 259);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Boundaries";
            // 
            // HatchSelector
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(298, 336);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBoxScale);
            this.Controls.Add(this.TextBoxRotation);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "HatchSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DXFReader.NET Demo Program - Hatch";
            this.Load += new System.EventHandler(this.HatchSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonOk;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox TextBoxScale;
        internal System.Windows.Forms.TextBox TextBoxRotation;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Label label4;
    }
}