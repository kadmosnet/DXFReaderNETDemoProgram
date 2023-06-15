namespace DXFReaderNETDemoProgram
{
    partial class GradientSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GradientSelector));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.TextBoxRotation = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.ImageList1 = new System.Windows.Forms.ImageList(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxCentered = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonColor1 = new System.Windows.Forms.Button();
            this.buttonColor2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(198, 320);
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
            this.ButtonOk.Location = new System.Drawing.Point(101, 320);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(88, 24);
            this.ButtonOk.TabIndex = 3;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
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
            // TextBoxRotation
            // 
            this.TextBoxRotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRotation.Location = new System.Drawing.Point(124, 206);
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
            "Linear",
            "Cylinder",
            "InvCylinder",
            "Spherical",
            "InvSpherical",
            "Hemispherical",
            "InvHemispherical",
            "Curved",
            "InvCurved"});
            this.ComboBox1.Location = new System.Drawing.Point(124, 12);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(162, 21);
            this.ComboBox1.TabIndex = 17;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(9, 238);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(50, 13);
            this.Label3.TabIndex = 16;
            this.Label3.Text = "Centered";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 208);
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
            this.Label1.Size = new System.Drawing.Size(70, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Gradient type";
            // 
            // ImageList1
            // 
            this.ImageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList1.ImageStream")));
            this.ImageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList1.Images.SetKeyName(0, "Linear.png");
            this.ImageList1.Images.SetKeyName(1, "Cylinder.png");
            this.ImageList1.Images.SetKeyName(2, "InvCylinder.png");
            this.ImageList1.Images.SetKeyName(3, "Spherical.png");
            this.ImageList1.Images.SetKeyName(4, "InvSpherical.png");
            this.ImageList1.Images.SetKeyName(5, "Hemispherical.png");
            this.ImageList1.Images.SetKeyName(6, "InvHemispherical.png");
            this.ImageList1.Images.SetKeyName(7, "Curved.png");
            this.ImageList1.Images.SetKeyName(8, "InvCurved.png");
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
            "Point inside entity",
            "Selected entities"});
            this.comboBox2.Location = new System.Drawing.Point(124, 285);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(162, 21);
            this.comboBox2.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Boundaries";
            // 
            // checkBoxCentered
            // 
            this.checkBoxCentered.AutoSize = true;
            this.checkBoxCentered.Location = new System.Drawing.Point(124, 238);
            this.checkBoxCentered.Name = "checkBoxCentered";
            this.checkBoxCentered.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCentered.TabIndex = 23;
            this.checkBoxCentered.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Color1";
            // 
            // buttonColor1
            // 
            this.buttonColor1.CausesValidation = false;
            this.buttonColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor1.Location = new System.Drawing.Point(58, 39);
            this.buttonColor1.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColor1.Name = "buttonColor1";
            this.buttonColor1.Size = new System.Drawing.Size(48, 24);
            this.buttonColor1.TabIndex = 25;
            this.toolTip1.SetToolTip(this.buttonColor1, "Select color 1");
            this.buttonColor1.UseVisualStyleBackColor = true;
            this.buttonColor1.Click += new System.EventHandler(this.buttonColor1_Click);
            // 
            // buttonColor2
            // 
            this.buttonColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonColor2.Location = new System.Drawing.Point(58, 78);
            this.buttonColor2.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColor2.Name = "buttonColor2";
            this.buttonColor2.Size = new System.Drawing.Size(48, 24);
            this.buttonColor2.TabIndex = 27;
            this.toolTip1.SetToolTip(this.buttonColor2, "Select color 2");
            this.buttonColor2.UseVisualStyleBackColor = true;
            this.buttonColor2.Click += new System.EventHandler(this.buttonColor2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Color2";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40",
            "50",
            "60",
            "70",
            "80",
            "90"});
            this.comboBox3.Location = new System.Drawing.Point(124, 258);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(162, 21);
            this.comboBox3.TabIndex = 29;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Transparency";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // GradientSelector
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(301, 355);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonColor2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonColor1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxCentered);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.TextBoxRotation);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GradientSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DXFReader.NET Demo Program - Gradient";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonOk;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.TextBox TextBoxRotation;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ImageList ImageList1;
        internal System.Windows.Forms.ComboBox comboBox2;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.CheckBox checkBoxCentered;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Button buttonColor1;
        internal System.Windows.Forms.Button buttonColor2;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.ComboBox comboBox3;
        internal System.Windows.Forms.Label label7;
    }
}