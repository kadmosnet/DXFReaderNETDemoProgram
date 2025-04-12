namespace DXFReaderNETDemoProgram
{
    partial class BlockSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BlockSelector));
            DXFReaderNET.DxfDocument dxfDocument2 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor2 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables2 = new DXFReaderNET.Objects.RasterVariables();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.TextBoxRotation = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBoxScale = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.checkBoxExploded = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(205, 284);
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
            this.ButtonOk.Location = new System.Drawing.Point(112, 284);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(88, 24);
            this.ButtonOk.TabIndex = 3;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // TextBoxRotation
            // 
            this.TextBoxRotation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxRotation.Location = new System.Drawing.Point(124, 195);
            this.TextBoxRotation.Name = "TextBoxRotation";
            this.TextBoxRotation.Size = new System.Drawing.Size(168, 20);
            this.TextBoxRotation.TabIndex = 18;
            this.TextBoxRotation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRotation_KeyPress);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(124, 12);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(168, 21);
            this.ComboBox1.TabIndex = 17;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 198);
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
            this.Label1.Size = new System.Drawing.Size(63, 13);
            this.Label1.TabIndex = 14;
            this.Label1.Text = "Block name";
            // 
            // TextBoxScale
            // 
            this.TextBoxScale.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxScale.Location = new System.Drawing.Point(124, 224);
            this.TextBoxScale.Name = "TextBoxScale";
            this.TextBoxScale.Size = new System.Drawing.Size(168, 20);
            this.TextBoxScale.TabIndex = 30;
            this.TextBoxScale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxScale_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Scale";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 171);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "Show origin");
            this.pictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(276, 171);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "Zoom on full extents");
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfDocument2.ActiveLayout = "Model";
            dxfDocument2.Comments = null;
            aciColor2.Index = ((short)(256));
            aciColor2.IsByBlock = false;
            aciColor2.IsByLayer = true;
            aciColor2.UseTrueColor = false;
            dxfDocument2.CurrentColor = aciColor2;
            dxfDocument2.CurrentElevation = 0D;
            dxfDocument2.CurrentLayer = "0";
            dxfDocument2.CurrentLineTypeName = "ByLayer";
            dxfDocument2.CurrentLineTypeScale = 1D;
            dxfDocument2.CurrentTextSize = 2.5D;
            dxfDocument2.CurrentTextStyle = "STANDARD";
            dxfDocument2.CurrentThickness = 0D;
            dxfDocument2.DateCreated = new System.DateTime(2020, 2, 13, 12, 8, 23, 61);
            dxfDocument2.DateLastEdited = new System.DateTime(2020, 2, 13, 12, 8, 23, 61);
            dxfDocument2.Handle = "0";
            dxfDocument2.IsBinary = false;
            dxfDocument2.Modified = false;
            dxfDocument2.Name = null;
            dxfDocument2.Owner = null;
            rasterVariables2.DisplayFrame = true;
            rasterVariables2.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables2.Handle = "2D";
            rasterVariables2.Owner = null;
            rasterVariables2.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument2.RasterVariables = rasterVariables2;
            dxfDocument2.ThumbnailImage = null;
            dxfDocument2.TotalEditTime = new System.DateTime(2020, 2, 13, 0, 0, 0, 0);
            dxfDocument2.TotalEditTimeDays = 0;
            dxfDocument2.UserTimer = new System.DateTime(2020, 2, 13, 0, 0, 0, 0);
            dxfDocument2.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument2;
            this.dxfReaderNETControl1.FileName = null;
          
            
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(124, 39);
            this.dxfReaderNETControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(168, 126);
            this.dxfReaderNETControl1.TabIndex = 28;
            // 
            // checkBoxExploded
            // 
            this.checkBoxExploded.AutoSize = true;
            this.checkBoxExploded.Location = new System.Drawing.Point(124, 250);
            this.checkBoxExploded.Name = "checkBoxExploded";
            this.checkBoxExploded.Size = new System.Drawing.Size(15, 14);
            this.checkBoxExploded.TabIndex = 34;
            this.checkBoxExploded.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Exploded";
            // 
            // BlockSelector
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(304, 319);
            this.Controls.Add(this.checkBoxExploded);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TextBoxScale);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Controls.Add(this.TextBoxRotation);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BlockSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DXFReader.NET Demo Program - Block";
            this.Load += new System.EventHandler(this.BlockSelector_Load);
            this.Shown += new System.EventHandler(this.BlockSelector_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonOk;
        internal System.Windows.Forms.TextBox TextBoxRotation;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        internal System.Windows.Forms.TextBox TextBoxScale;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        internal System.Windows.Forms.CheckBox checkBoxExploded;
        internal System.Windows.Forms.Label label4;
    }
}