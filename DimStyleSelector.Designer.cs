namespace DXFReaderNETDemoProgram
{
    partial class DimStyleSelector
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
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.numericUpDownTextHeight = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonProperties = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownTextOffset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownArrowSize = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownCenterMarkSize = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownBaseLineSpacing = new System.Windows.Forms.NumericUpDown();
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLengthPrecision = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBoxLengthType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxAnglePrecision = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxAngleType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxArrowLeader = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBoxDimArrow2 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxDimArrow1 = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownOffset = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrowSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenterMarkSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseLineSpacing)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk.Location = new System.Drawing.Point(523, 461);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(76, 24);
            this.ButtonOk.TabIndex = 5;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            this.ButtonOk.Click += new System.EventHandler(this.ButtonOk_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Location = new System.Drawing.Point(247, 12);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(366, 21);
            this.ComboBox1.TabIndex = 31;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 24);
            this.button2.TabIndex = 33;
            this.button2.Text = "New...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(30, 13);
            this.Label1.TabIndex = 35;
            this.Label1.Text = "Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Current dimension style:";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(606, 461);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(80, 24);
            this.ButtonCancel.TabIndex = 6;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTextHeight
            // 
            this.numericUpDownTextHeight.DecimalPlaces = 2;
            this.numericUpDownTextHeight.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownTextHeight.Location = new System.Drawing.Point(137, 42);
            this.numericUpDownTextHeight.Name = "numericUpDownTextHeight";
            this.numericUpDownTextHeight.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownTextHeight.TabIndex = 37;
            this.numericUpDownTextHeight.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTextHeight.ValueChanged += new System.EventHandler(this.numericUpDownTextHeight_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Text height";
            // 
            // buttonProperties
            // 
            this.buttonProperties.Location = new System.Drawing.Point(151, 14);
            this.buttonProperties.Name = "buttonProperties";
            this.buttonProperties.Size = new System.Drawing.Size(90, 21);
            this.buttonProperties.TabIndex = 39;
            this.buttonProperties.Text = "Properties...";
            this.buttonProperties.UseVisualStyleBackColor = true;
            this.buttonProperties.Click += new System.EventHandler(this.buttonProperties_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Text offset";
            // 
            // numericUpDownTextOffset
            // 
            this.numericUpDownTextOffset.DecimalPlaces = 3;
            this.numericUpDownTextOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownTextOffset.Location = new System.Drawing.Point(137, 68);
            this.numericUpDownTextOffset.Name = "numericUpDownTextOffset";
            this.numericUpDownTextOffset.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownTextOffset.TabIndex = 40;
            this.numericUpDownTextOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTextOffset.ValueChanged += new System.EventHandler(this.numericUpDownTextOffset_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Arrow size";
            // 
            // numericUpDownArrowSize
            // 
            this.numericUpDownArrowSize.DecimalPlaces = 2;
            this.numericUpDownArrowSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownArrowSize.Location = new System.Drawing.Point(137, 94);
            this.numericUpDownArrowSize.Name = "numericUpDownArrowSize";
            this.numericUpDownArrowSize.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownArrowSize.TabIndex = 42;
            this.numericUpDownArrowSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownArrowSize.ValueChanged += new System.EventHandler(this.numericUpDownArrowSize_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 45;
            this.label6.Text = "Center mark size";
            // 
            // numericUpDownCenterMarkSize
            // 
            this.numericUpDownCenterMarkSize.DecimalPlaces = 2;
            this.numericUpDownCenterMarkSize.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownCenterMarkSize.Location = new System.Drawing.Point(137, 120);
            this.numericUpDownCenterMarkSize.Name = "numericUpDownCenterMarkSize";
            this.numericUpDownCenterMarkSize.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownCenterMarkSize.TabIndex = 44;
            this.numericUpDownCenterMarkSize.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCenterMarkSize.ValueChanged += new System.EventHandler(this.numericUpDownCenterMarkSize_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Extend beyond dim lines";
            // 
            // numericUpDownBaseLineSpacing
            // 
            this.numericUpDownBaseLineSpacing.DecimalPlaces = 2;
            this.numericUpDownBaseLineSpacing.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownBaseLineSpacing.Location = new System.Drawing.Point(137, 146);
            this.numericUpDownBaseLineSpacing.Name = "numericUpDownBaseLineSpacing";
            this.numericUpDownBaseLineSpacing.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownBaseLineSpacing.TabIndex = 46;
            this.numericUpDownBaseLineSpacing.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBaseLineSpacing.ValueChanged += new System.EventHandler(this.numericUpDownBaseLineSpacing_ValueChanged);
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AntiAlias = true;
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            dxfDocument1.ActiveLayout = "Model";
            dxfDocument1.Comments = null;
            aciColor1.Index = ((short)(256));
            aciColor1.IsByBlock = false;
            aciColor1.IsByLayer = true;
            aciColor1.UseTrueColor = false;
            dxfDocument1.CurrentColor = aciColor1;
            dxfDocument1.CurrentElevation = 0D;
            dxfDocument1.CurrentLayer = "0";
            dxfDocument1.CurrentLineTypeName = "ByLayer";
            dxfDocument1.CurrentLineTypeScale = 1D;
            dxfDocument1.CurrentTextSize = 2.5D;
            dxfDocument1.CurrentTextStyle = "STANDARD";
            dxfDocument1.CurrentThickness = 0D;
            dxfDocument1.DateCreated = new System.DateTime(2020, 2, 13, 12, 8, 23, 61);
            dxfDocument1.DateLastEdited = new System.DateTime(2020, 2, 13, 12, 8, 23, 61);
            dxfDocument1.Handle = "0";
            dxfDocument1.IsBinary = false;
            dxfDocument1.Modified = false;
            dxfDocument1.Name = null;
            dxfDocument1.Owner = null;
            rasterVariables1.DisplayFrame = true;
            rasterVariables1.DisplayQuality = DXFReaderNET.Objects.ImageDisplayQuality.High;
            rasterVariables1.Handle = "2D";
            rasterVariables1.Owner = null;
            rasterVariables1.Units = DXFReaderNET.ImageUnits.Unitless;
            dxfDocument1.RasterVariables = rasterVariables1;
            dxfDocument1.ThumbnailImage = null;
            dxfDocument1.TotalEditTime = new System.DateTime(2020, 2, 13, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new System.DateTime(2020, 2, 13, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument1;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(247, 42);
            this.dxfReaderNETControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dxfReaderNETControl1.MouseWheelBehavior = DXFReaderNET.MouseWheelBehaviorType.Custom;
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(439, 398);
            this.dxfReaderNETControl1.TabIndex = 29;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxLengthPrecision);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxLengthType);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(4, 198);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 83);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Linear dimensions";
            // 
            // comboBoxLengthPrecision
            // 
            this.comboBoxLengthPrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLengthPrecision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLengthPrecision.FormattingEnabled = true;
            this.comboBoxLengthPrecision.Items.AddRange(new object[] {
            "Architectural",
            "Decimal",
            "Engineering",
            "Fractional",
            "Scientific",
            "Windows desktop"});
            this.comboBoxLengthPrecision.Location = new System.Drawing.Point(106, 46);
            this.comboBoxLengthPrecision.Name = "comboBoxLengthPrecision";
            this.comboBoxLengthPrecision.Size = new System.Drawing.Size(120, 21);
            this.comboBoxLengthPrecision.TabIndex = 39;
            this.comboBoxLengthPrecision.SelectedIndexChanged += new System.EventHandler(this.comboBoxLengthPrecision_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Precision";
            // 
            // comboBoxLengthType
            // 
            this.comboBoxLengthType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLengthType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLengthType.FormattingEnabled = true;
            this.comboBoxLengthType.Items.AddRange(new object[] {
            "Architectural",
            "Decimal",
            "Engineering",
            "Fractional",
            "Scientific",
            "Windows desktop"});
            this.comboBoxLengthType.Location = new System.Drawing.Point(106, 19);
            this.comboBoxLengthType.Name = "comboBoxLengthType";
            this.comboBoxLengthType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxLengthType.TabIndex = 37;
            this.comboBoxLengthType.SelectedIndexChanged += new System.EventHandler(this.comboBoxLengthType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Unit format";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxAnglePrecision);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.comboBoxAngleType);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(3, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 83);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Angular dimensions";
            // 
            // comboBoxAnglePrecision
            // 
            this.comboBoxAnglePrecision.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnglePrecision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAnglePrecision.FormattingEnabled = true;
            this.comboBoxAnglePrecision.Items.AddRange(new object[] {
            "Architectural",
            "Decimal",
            "Engineering",
            "Fractional",
            "Scientific",
            "Windows desktop"});
            this.comboBoxAnglePrecision.Location = new System.Drawing.Point(106, 46);
            this.comboBoxAnglePrecision.Name = "comboBoxAnglePrecision";
            this.comboBoxAnglePrecision.Size = new System.Drawing.Size(120, 21);
            this.comboBoxAnglePrecision.TabIndex = 39;
            this.comboBoxAnglePrecision.SelectedIndexChanged += new System.EventHandler(this.comboBoxAnglePrecision_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Precision";
            // 
            // comboBoxAngleType
            // 
            this.comboBoxAngleType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAngleType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAngleType.FormattingEnabled = true;
            this.comboBoxAngleType.Items.AddRange(new object[] {
            "Decimal degrees",
            "Degrees/Minutes/Seconds",
            "Gradians",
            "Radians",
            "Surveyor\'s units"});
            this.comboBoxAngleType.Location = new System.Drawing.Point(106, 19);
            this.comboBoxAngleType.Name = "comboBoxAngleType";
            this.comboBoxAngleType.Size = new System.Drawing.Size(120, 21);
            this.comboBoxAngleType.TabIndex = 37;
            this.comboBoxAngleType.SelectedIndexChanged += new System.EventHandler(this.comboBoxAngleType_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 36;
            this.label11.Text = "Unit format";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxArrowLeader);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboBoxDimArrow2);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.comboBoxDimArrow1);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(3, 376);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 104);
            this.groupBox3.TabIndex = 50;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Arrowheads";
            // 
            // comboBoxArrowLeader
            // 
            this.comboBoxArrowLeader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxArrowLeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxArrowLeader.FormattingEnabled = true;
            this.comboBoxArrowLeader.Items.AddRange(new object[] {
            "closed filled",
            "dot",
            "dot small",
            "dot blank",
            "origin indicator",
            "origin indicator 2",
            "open",
            "open 90 (right angle)",
            "open 30",
            "closed",
            "dot small blank",
            "none",
            "oblique",
            "box filled",
            "box",
            "closed blank",
            "datum triangle filled",
            "datum triangle",
            "integral",
            "architectural tick"});
            this.comboBoxArrowLeader.Location = new System.Drawing.Point(106, 73);
            this.comboBoxArrowLeader.Name = "comboBoxArrowLeader";
            this.comboBoxArrowLeader.Size = new System.Drawing.Size(120, 21);
            this.comboBoxArrowLeader.TabIndex = 41;
            this.comboBoxArrowLeader.SelectedIndexChanged += new System.EventHandler(this.comboBoxArrowLeader_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 73);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Leader";
            // 
            // comboBoxDimArrow2
            // 
            this.comboBoxDimArrow2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDimArrow2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDimArrow2.FormattingEnabled = true;
            this.comboBoxDimArrow2.Items.AddRange(new object[] {
            "closed filled",
            "dot",
            "dot small",
            "dot blank",
            "origin indicator",
            "origin indicator 2",
            "open",
            "open 90 (right angle)",
            "open 30",
            "closed",
            "dot small blank",
            "none",
            "oblique",
            "box filled",
            "box",
            "closed blank",
            "datum triangle filled",
            "datum triangle",
            "integral",
            "architectural tick"});
            this.comboBoxDimArrow2.Location = new System.Drawing.Point(106, 46);
            this.comboBoxDimArrow2.Name = "comboBoxDimArrow2";
            this.comboBoxDimArrow2.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDimArrow2.TabIndex = 39;
            this.comboBoxDimArrow2.SelectedIndexChanged += new System.EventHandler(this.comboBoxDimArrow2_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 38;
            this.label12.Text = "Second";
            // 
            // comboBoxDimArrow1
            // 
            this.comboBoxDimArrow1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDimArrow1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxDimArrow1.FormattingEnabled = true;
            this.comboBoxDimArrow1.Items.AddRange(new object[] {
            "closed filled",
            "dot",
            "dot small",
            "dot blank",
            "origin indicator",
            "origin indicator 2",
            "open",
            "open 90 (right angle)",
            "open 30",
            "closed",
            "dot small blank",
            "none",
            "oblique",
            "box filled",
            "box",
            "closed blank",
            "datum triangle filled",
            "datum triangle",
            "integral",
            "architectural tick"});
            this.comboBoxDimArrow1.Location = new System.Drawing.Point(106, 19);
            this.comboBoxDimArrow1.Name = "comboBoxDimArrow1";
            this.comboBoxDimArrow1.Size = new System.Drawing.Size(120, 21);
            this.comboBoxDimArrow1.TabIndex = 37;
            this.comboBoxDimArrow1.SelectedIndexChanged += new System.EventHandler(this.comboBoxDimArrow1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 36;
            this.label13.Text = "First";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 174);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(86, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Offset from origin";
            // 
            // numericUpDownOffset
            // 
            this.numericUpDownOffset.DecimalPlaces = 3;
            this.numericUpDownOffset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownOffset.Location = new System.Drawing.Point(136, 172);
            this.numericUpDownOffset.Name = "numericUpDownOffset";
            this.numericUpDownOffset.Size = new System.Drawing.Size(94, 20);
            this.numericUpDownOffset.TabIndex = 51;
            this.numericUpDownOffset.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownOffset.ValueChanged += new System.EventHandler(this.numericUpDownOffset_ValueChanged);
            // 
            // DimStyleSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(699, 496);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.numericUpDownOffset);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.numericUpDownBaseLineSpacing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownCenterMarkSize);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDownArrowSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDownTextOffset);
            this.Controls.Add(this.buttonProperties);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDownTextHeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.dxfReaderNETControl1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DimStyleSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dimension Style Manager";
            this.Load += new System.EventHandler(this.DimStyleSelector_Load);
            this.Shown += new System.EventHandler(this.DimStyleSelector_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTextOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownArrowSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCenterMarkSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBaseLineSpacing)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOffset)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button ButtonOk;
        internal DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        internal System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.NumericUpDown numericUpDownTextHeight;
        internal System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonProperties;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.NumericUpDown numericUpDownTextOffset;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.NumericUpDown numericUpDownArrowSize;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.NumericUpDown numericUpDownCenterMarkSize;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.NumericUpDown numericUpDownBaseLineSpacing;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBoxLengthPrecision;
        internal System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBoxLengthType;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxAnglePrecision;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxAngleType;
        internal System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBoxArrowLeader;
        internal System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox comboBoxDimArrow2;
        internal System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxDimArrow1;
        internal System.Windows.Forms.Label label13;
        internal System.Windows.Forms.Label label15;
        internal System.Windows.Forms.NumericUpDown numericUpDownOffset;
    }
}