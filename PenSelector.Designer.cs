namespace DXFReaderNETDemoProgram
{
    partial class PenSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PenSelector));
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonOk = new System.Windows.Forms.Button();
            this.TextBoxPenWidth = new System.Windows.Forms.TextBox();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.textBoxDashLength = new System.Windows.Forms.TextBox();
            this.labelDashLength = new System.Windows.Forms.Label();
            this.labelSkipLength = new System.Windows.Forms.Label();
            this.textBoxSkipLength = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Location = new System.Drawing.Point(171, 133);
            this.ButtonCancel.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(88, 24);
            this.ButtonCancel.TabIndex = 10;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonOk
            // 
            this.ButtonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonOk.Location = new System.Drawing.Point(74, 133);
            this.ButtonOk.Name = "ButtonOk";
            this.ButtonOk.Size = new System.Drawing.Size(88, 24);
            this.ButtonOk.TabIndex = 9;
            this.ButtonOk.Text = "Ok";
            this.ButtonOk.UseVisualStyleBackColor = true;
            // 
            // TextBoxPenWidth
            // 
            this.TextBoxPenWidth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxPenWidth.Location = new System.Drawing.Point(128, 12);
            this.TextBoxPenWidth.Name = "TextBoxPenWidth";
            this.TextBoxPenWidth.Size = new System.Drawing.Size(131, 20);
            this.TextBoxPenWidth.TabIndex = 2;
            this.TextBoxPenWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxRotation_KeyPress);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "Continuous",
            "Dashed"});
            this.ComboBox1.Location = new System.Drawing.Point(128, 38);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(131, 21);
            this.ComboBox1.TabIndex = 25;
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(9, 15);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(54, 13);
            this.Label2.TabIndex = 23;
            this.Label2.Text = "Pen width";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(9, 41);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(50, 13);
            this.Label1.TabIndex = 22;
            this.Label1.Text = "Pen style";
            // 
            // textBoxDashLength
            // 
            this.textBoxDashLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxDashLength.Location = new System.Drawing.Point(128, 65);
            this.textBoxDashLength.Name = "textBoxDashLength";
            this.textBoxDashLength.Size = new System.Drawing.Size(131, 20);
            this.textBoxDashLength.TabIndex = 26;
            // 
            // labelDashLength
            // 
            this.labelDashLength.AutoSize = true;
            this.labelDashLength.Location = new System.Drawing.Point(9, 67);
            this.labelDashLength.Name = "labelDashLength";
            this.labelDashLength.Size = new System.Drawing.Size(64, 13);
            this.labelDashLength.TabIndex = 27;
            this.labelDashLength.Text = "Dash length";
            // 
            // labelSkipLength
            // 
            this.labelSkipLength.AutoSize = true;
            this.labelSkipLength.Location = new System.Drawing.Point(9, 93);
            this.labelSkipLength.Name = "labelSkipLength";
            this.labelSkipLength.Size = new System.Drawing.Size(60, 13);
            this.labelSkipLength.TabIndex = 28;
            this.labelSkipLength.Text = "Skip length";
            // 
            // textBoxSkipLength
            // 
            this.textBoxSkipLength.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSkipLength.Location = new System.Drawing.Point(128, 91);
            this.textBoxSkipLength.Name = "textBoxSkipLength";
            this.textBoxSkipLength.Size = new System.Drawing.Size(131, 20);
            this.textBoxSkipLength.TabIndex = 29;
            // 
            // PenSelector
            // 
            this.AcceptButton = this.ButtonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonCancel;
            this.ClientSize = new System.Drawing.Size(271, 168);
            this.Controls.Add(this.textBoxSkipLength);
            this.Controls.Add(this.labelSkipLength);
            this.Controls.Add(this.textBoxDashLength);
            this.Controls.Add(this.labelDashLength);
            this.Controls.Add(this.TextBoxPenWidth);
            this.Controls.Add(this.ComboBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ButtonOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PenSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DXFReader.NET Demo Program - Pen style";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button ButtonCancel;
        internal System.Windows.Forms.Button ButtonOk;
        internal System.Windows.Forms.TextBox TextBoxPenWidth;
        internal System.Windows.Forms.ComboBox ComboBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox textBoxDashLength;
        internal System.Windows.Forms.Label labelDashLength;
        internal System.Windows.Forms.Label labelSkipLength;
        internal System.Windows.Forms.TextBox textBoxSkipLength;
    }
}