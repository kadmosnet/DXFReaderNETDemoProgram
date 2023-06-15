using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXFReaderNET;
using DXFReaderNET.Entities;
namespace DXFReaderNETDemoProgram
{
#pragma warning disable IDE0017, IDE1006
    public partial class DimStyleSelector : Form
    {

        //internal DXFReaderNET.DXFReaderNETControl DXFReaderNETControl;
        public DimStyleSelector()
        {
            InitializeComponent();
        }
        bool onStart = true;
        internal List<DXFReaderNET.Tables.DimensionStyle> dimstylesBuffer = new List<DXFReaderNET.Tables.DimensionStyle>();
        //nternal DXFReaderNET.Collections.DimensionStyles dimstylesBuffer;// = new List<DXFReaderNET.Tables.DimensionStyle>();
        internal string currentDimStyle = "";
        private void DimStyleSelector_Load(object sender, EventArgs e)
        {

#if DEBUG
            buttonProperties.Visible = true;
            button2.Visible = true;


#else
            buttonProperties.Visible=false;
            button2.Visible=false;
           

#endif
        }

        private void ViewData(string dimstyle)
        {
            numericUpDownTextHeight.Value = (decimal)dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].TextHeight;
            numericUpDownTextOffset.Value = (decimal)dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].TextOffset;
            numericUpDownArrowSize.Value = (decimal)dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].ArrowSize;
            numericUpDownCenterMarkSize.Value = (decimal)dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].CenterMarkSize;
            numericUpDownBaseLineSpacing.Value = (decimal)dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].ExtLineExtend;
            numericUpDownOffset.Value = (decimal)dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].ExtLineOffset;
            switch (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimLengthUnits)
            {
                case DXFReaderNET.LinearUnitType.Architectural:
                    comboBoxLengthType.SelectedItem = "Architectural";
                    break;
                case DXFReaderNET.LinearUnitType.Engineering:
                    comboBoxLengthType.SelectedItem = "Engineering";
                    break;
                case DXFReaderNET.LinearUnitType.Fractional:
                    comboBoxLengthType.SelectedItem = "Fractional";
                    break;
                case DXFReaderNET.LinearUnitType.Decimal:
                    comboBoxLengthType.SelectedItem = "Decimal";
                    break;
                case DXFReaderNET.LinearUnitType.Scientific:
                    comboBoxLengthType.SelectedItem = "Scientific";
                    break;
                case DXFReaderNET.LinearUnitType.WindowsDesktop:
                    comboBoxLengthType.SelectedItem = "Windows desktop";
                    break;

            }
            comboBoxLengthType_SelectedIndexChanged(null, null);
            switch (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimAngularUnits)
            {
                case DXFReaderNET.AngleUnitType.DecimalDegrees:
                    comboBoxAngleType.SelectedItem = "Decimal degrees";
                    break;
                case DXFReaderNET.AngleUnitType.DegreesMinutesSeconds:
                    comboBoxAngleType.SelectedItem = "Degrees/Minutes/Seconds";
                    break;
                case DXFReaderNET.AngleUnitType.Gradians:
                    comboBoxAngleType.SelectedItem = "Gradians";
                    break;
                case DXFReaderNET.AngleUnitType.Radians:
                    comboBoxAngleType.SelectedItem = "Radians";
                    break;
                case DXFReaderNET.AngleUnitType.SurveyorUnits:
                    comboBoxAngleType.SelectedItem = "Surveyor's units";
                    break;


            }
            comboBoxAngleType_SelectedIndexChanged(null, null);

            if (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 != null)
            {
                switch (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1.Name.ToUpper())
                {
                    case "":
                        comboBoxDimArrow1.SelectedItem = "closed filled";
                        break;
                    case "_DOT": comboBoxDimArrow1.SelectedItem = "dot"; break;
                    case "_DOTSMALL": comboBoxDimArrow1.SelectedItem = "dot small"; break;
                    case "_DOTBLANK": comboBoxDimArrow1.SelectedItem = "dot blank"; break;
                    case "_ORIGIN": comboBoxDimArrow1.SelectedItem = "origin indicator"; break;
                    case "_ORIGIN2": comboBoxDimArrow1.SelectedItem = "origin indicator 2"; break;
                    case "_OPEN": comboBoxDimArrow1.SelectedItem = "open"; break;
                    case "_OPEN90": comboBoxDimArrow1.SelectedItem = "open 90 (right angle)"; break;
                    case "_OPEN30": comboBoxDimArrow1.SelectedItem = "open 30"; break;
                    case "_CLOSED": comboBoxDimArrow1.SelectedItem = "closed"; break;
                    case "_SMALL": comboBoxDimArrow1.SelectedItem = "dot small blank"; break;
                    case "_NONE": comboBoxDimArrow1.SelectedItem = "none"; break;
                    case "_OBLIQUE": comboBoxDimArrow1.SelectedItem = "oblique"; break;
                    case "_BOXFILLED": comboBoxDimArrow1.SelectedItem = "box filled"; break;
                    case "_BOXBLANK": comboBoxDimArrow1.SelectedItem = "box"; break;
                    case "_CLOSEDBLANK": comboBoxDimArrow1.SelectedItem = "closed blank"; break;
                    case "_DATUMFILLED": comboBoxDimArrow1.SelectedItem = "datum triangle filled"; break;
                    case "_DATUMBLANK": comboBoxDimArrow1.SelectedItem = "datum triangle"; break;
                    case "_INTEGRAL": comboBoxDimArrow1.SelectedItem = "integral"; break;
                    case "_ARCHTICK": comboBoxDimArrow1.SelectedItem = "architectural tick"; break;


                }
            }
            else
            {
                comboBoxDimArrow1.SelectedItem = "closed filled";
            }

            if (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 != null)
            {
                switch (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2.Name.ToUpper())
                {
                    case "":
                        comboBoxDimArrow2.SelectedItem = "closed filled";
                        break;
                    case "_DOT": comboBoxDimArrow2.SelectedItem = "dot"; break;
                    case "_DOTSMALL": comboBoxDimArrow2.SelectedItem = "dot small"; break;
                    case "_DOTBLANK": comboBoxDimArrow2.SelectedItem = "dot blank"; break;
                    case "_ORIGIN": comboBoxDimArrow2.SelectedItem = "origin indicator"; break;
                    case "_ORIGIN2": comboBoxDimArrow2.SelectedItem = "origin indicator 2"; break;
                    case "_OPEN": comboBoxDimArrow2.SelectedItem = "open"; break;
                    case "_OPEN90": comboBoxDimArrow2.SelectedItem = "open 90 (right angle)"; break;
                    case "_OPEN30": comboBoxDimArrow2.SelectedItem = "open 30"; break;
                    case "_CLOSED": comboBoxDimArrow2.SelectedItem = "closed"; break;
                    case "_SMALL": comboBoxDimArrow2.SelectedItem = "dot small blank"; break;
                    case "_NONE": comboBoxDimArrow2.SelectedItem = "none"; break;
                    case "_OBLIQUE": comboBoxDimArrow2.SelectedItem = "oblique"; break;
                    case "_BOXFILLED": comboBoxDimArrow2.SelectedItem = "box filled"; break;
                    case "_BOXBLANK": comboBoxDimArrow2.SelectedItem = "box"; break;
                    case "_CLOSEDBLANK": comboBoxDimArrow2.SelectedItem = "closed blank"; break;
                    case "_DATUMFILLED": comboBoxDimArrow2.SelectedItem = "datum triangle filled"; break;
                    case "_DATUMBLANK": comboBoxDimArrow2.SelectedItem = "datum triangle"; break;
                    case "_INTEGRAL": comboBoxDimArrow2.SelectedItem = "integral"; break;
                    case "_ARCHTICK": comboBoxDimArrow2.SelectedItem = "architectural tick"; break;


                }
            }
            else
            {
                comboBoxDimArrow2.SelectedItem = "closed filled";
            }
            if (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow != null)
            {

                switch (dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow.Name.ToUpper())
                {
                    case "":
                        comboBoxArrowLeader.SelectedItem = "closed filled";
                        break;
                    case "_DOT": comboBoxArrowLeader.SelectedItem = "dot"; break;
                    case "_DOTSMALL": comboBoxArrowLeader.SelectedItem = "dot small"; break;
                    case "_DOTBLANK": comboBoxArrowLeader.SelectedItem = "dot blank"; break;
                    case "_ORIGIN": comboBoxArrowLeader.SelectedItem = "origin indicator"; break;
                    case "_ORIGIN2": comboBoxArrowLeader.SelectedItem = "origin indicator 2"; break;
                    case "_OPEN": comboBoxArrowLeader.SelectedItem = "open"; break;
                    case "_OPEN90": comboBoxArrowLeader.SelectedItem = "open 90 (right angle)"; break;
                    case "_OPEN30": comboBoxArrowLeader.SelectedItem = "open 30"; break;
                    case "_CLOSED": comboBoxArrowLeader.SelectedItem = "closed"; break;
                    case "_SMALL": comboBoxArrowLeader.SelectedItem = "dot small blank"; break;
                    case "_NONE": comboBoxArrowLeader.SelectedItem = "none"; break;
                    case "_OBLIQUE": comboBoxArrowLeader.SelectedItem = "oblique"; break;
                    case "_BOXFILLED": comboBoxArrowLeader.SelectedItem = "box filled"; break;
                    case "_BOXBLANK": comboBoxArrowLeader.SelectedItem = "box"; break;
                    case "_CLOSEDBLANK": comboBoxArrowLeader.SelectedItem = "closed blank"; break;
                    case "_DATUMFILLED": comboBoxArrowLeader.SelectedItem = "datum triangle filled"; break;
                    case "_DATUMBLANK": comboBoxArrowLeader.SelectedItem = "datum triangle"; break;
                    case "_INTEGRAL": comboBoxArrowLeader.SelectedItem = "integral"; break;
                    case "_ARCHTICK": comboBoxArrowLeader.SelectedItem = "architectural tick"; break;


                }
            }
            else
            {
                comboBoxArrowLeader.SelectedItem = "closed filled";
            }
            //comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LengthPrecision;
            //comboBoxAnglePrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].AngularPrecision;

        }
        private void ViewStyle(string dimstyle)
        {
            if (onStart) return;
            dxfReaderNETControl1.Clear();
            dxfReaderNETControl1.DXF.RemoveEntities();

            dxfReaderNETControl1.AddLine(new Vector3(0, 0, 0), new Vector3(0, 16.66, 0), AciColor.Yellow.Index);
            dxfReaderNETControl1.AddAlignedDimension(dxfReaderNETControl1.DXF.Lines[dxfReaderNETControl1.DXF.Lines.Count - 1], 4, dimstyle);

            dxfReaderNETControl1.AddLine(new Vector3(0, 16.66, 0), new Vector3(14.11, 16.66, 0), AciColor.Yellow.Index);
            dxfReaderNETControl1.AddAlignedDimension(dxfReaderNETControl1.DXF.Lines[dxfReaderNETControl1.DXF.Lines.Count - 1], 4, dimstyle);

            dxfReaderNETControl1.AddLine(new Vector3(14.11, 16.66, 0), new Vector3(14.11, 14.6, 0), AciColor.Yellow.Index);
            dxfReaderNETControl1.AddLine(new Vector3(14.11, 14.6, 0), new Vector3(28, 14.6, 0), AciColor.Yellow.Index);

            dxfReaderNETControl1.AddLine(new Vector3(28, 14.6, 0), new Vector3(42, -8, 0), AciColor.Yellow.Index);
            dxfReaderNETControl1.AddAlignedDimension(dxfReaderNETControl1.DXF.Lines[dxfReaderNETControl1.DXF.Lines.Count - 1], 4, dimstyle);

            dxfReaderNETControl1.AddLine(new Vector3(42, -8, 0), new Vector3(8, -8, 0), AciColor.Yellow.Index);
            dxfReaderNETControl1.AddAngularDimension(new Vector3(42, -8, 0), new Vector3(33.57, 5.56, 0), new Vector3(26, -8, 0), 16, dimstyle);

            dxfReaderNETControl1.AddArc(new Vector3(8, -8, 0), new Vector3(2.18, -5.82, 0), new Vector3(0, 0, 0), AciColor.Yellow.Index);

            dxfReaderNETControl1.AddCircle(dxfReaderNETControl1.DXF.Arcs[dxfReaderNETControl1.DXF.Arcs.Count - 1].Center, 4, AciColor.Yellow.Index);

            dxfReaderNETControl1.AddRadialDimension(dxfReaderNETControl1.DXF.Arcs[dxfReaderNETControl1.DXF.Arcs.Count - 1], new Vector3(-7, -14, 0), dimstyle);
            dxfReaderNETControl1.ZoomExtents();
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.ZoomExtents();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
            ViewData(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

        }

        private void DimStyleSelector_Shown(object sender, EventArgs e)
        {


            //dxfReaderNETControl1.ZoomExtents();
            //dxfReaderNETControl1.Refresh();
            //dxfReaderNETControl1.ZoomExtents();
            dxfReaderNETControl1.DXF.DimensionStyles.Clear();
            foreach (DXFReaderNET.Tables.DimensionStyle _dimStyle in dimstylesBuffer)
            {
                dxfReaderNETControl1.DXF.DimensionStyles.Add(_dimStyle);
                ComboBox1.Items.Add(_dimStyle.Name.ToString());
            }
            label2.Text = "Current dimension style: " + currentDimStyle;
            ComboBox1.SelectedIndex = ComboBox1.FindString(currentDimStyle);
            onStart = false;
            ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
            ViewData(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.DrawingVariables.DimStyle = ComboBox1.Items[ComboBox1.SelectedIndex].ToString();


            label2.Text = "Current dimension style: " + dxfReaderNETControl1.DXF.DrawingVariables.DimStyle;
        }

        private void numericUpDownTextHeight_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].TextHeight = (double)numericUpDownTextHeight.Value;
                ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

            }
        }

        private void buttonProperties_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowProperties(dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()]);
        }

        private void numericUpDownTextOffset_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].TextOffset = (double)numericUpDownTextOffset.Value;
                ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

            }
        }

        private void numericUpDownArrowSize_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].ArrowSize = (double)numericUpDownArrowSize.Value;
                ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

            }
        }

        private void numericUpDownCenterMarkSize_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].CenterMarkSize = (double)numericUpDownCenterMarkSize.Value;
                ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

            }
        }

        private void numericUpDownBaseLineSpacing_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].ExtLineExtend = (double)numericUpDownBaseLineSpacing.Value;
                ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            InputDialog inputBox = new InputDialog();
            string oldStyleName = ComboBox1.Items[ComboBox1.SelectedIndex].ToString();
            inputBox.textBox1.Text = "Copy of " + oldStyleName;
            inputBox.label1.Text = "New style name";
            inputBox.ForceNumeric = false;

            if (inputBox.ShowDialog() == DialogResult.OK)
            {
                string newStyleName = inputBox.textBox1.Text;
                DXFReaderNET.Tables.DimensionStyle _dimStyle = new DXFReaderNET.Tables.DimensionStyle(newStyleName);

                _dimStyle = (DXFReaderNET.Tables.DimensionStyle)dxfReaderNETControl1.DXF.DimensionStyles[oldStyleName].Clone();
                _dimStyle.Name = newStyleName;
                dxfReaderNETControl1.DXF.DimensionStyles.Add(_dimStyle);

                ComboBox1.Items.Clear();

                foreach (DXFReaderNET.Tables.DimensionStyle d in dxfReaderNETControl1.DXF.DimensionStyles.Items)
                {
                    ComboBox1.Items.Add(d.Name.ToString());

                }



                ComboBox1.SelectedIndex = ComboBox1.FindString(newStyleName);

                ViewStyle(newStyleName);

            }
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            dimstylesBuffer.Clear();
            foreach (DXFReaderNET.Tables.DimensionStyle _dimStyle in dxfReaderNETControl1.DXF.DimensionStyles)
            {
                dimstylesBuffer.Add(_dimStyle);
            }
        }

        private void comboBoxLengthType_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxLengthPrecision.Enabled = true;
            switch (comboBoxLengthType.SelectedItem)
            {
                case "Architectural":
                    comboBoxLengthPrecision.Items.Clear();
                    comboBoxLengthPrecision.Items.Add("0'-0\"");
                    for (int k = 1; k <= 8; k++)
                    {
                        string s = "0'-0 1/";
                        int molt = 1;
                        for (int j = 1; j <= k; j++)
                        {
                            molt *= 2;
                        }
                        s += molt.ToString();
                        s += "\"";
                        comboBoxLengthPrecision.Items.Add(s);
                    }
                    dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimLengthUnits = LinearUnitType.Architectural;
                    //comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision;
                    break;
                case "Engineering":
                    comboBoxLengthPrecision.Items.Clear();
                    comboBoxLengthPrecision.Items.Add("0'-0\"");
                    for (int k = 1; k <= 8; k++)
                    {
                        string s = "0'-0.";
                        for (int j = 1; j <= k; j++)
                        {
                            s += "0";
                        }
                        s += "\"";
                        comboBoxLengthPrecision.Items.Add(s);
                    }
                    dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimLengthUnits = LinearUnitType.Engineering;
                    //comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision;
                    break;
                case "Fractional":
                    comboBoxLengthPrecision.Items.Clear();
                    comboBoxLengthPrecision.Items.Add("0");
                    for (int k = 1; k <= 8; k++)
                    {
                        string s = "0 1/";
                        int molt = 1;
                        for (int j = 1; j <= k; j++)
                        {
                            molt *= 2;
                        }
                        s += molt.ToString();
                        comboBoxLengthPrecision.Items.Add(s);
                    }
                    dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimLengthUnits = LinearUnitType.Fractional;
                    //comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision;
                    break;
                case "Decimal":
                    //Global.thisDXF.DrawingVariables.LUnits = DXFReaderNET.LinearUnitType.Decimal;
                    comboBoxLengthPrecision.Items.Clear();
                    comboBoxLengthPrecision.Items.Add("0");
                    for (int k = 1; k <= 8; k++)
                    {
                        string s = "0.";
                        for (int j = 1; j <= k; j++)
                        {
                            s += "0";
                        }
                        comboBoxLengthPrecision.Items.Add(s);
                    }
                    dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimLengthUnits = LinearUnitType.Decimal;
                    // comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision;
                    break;
                case "Scientific":
                    //Global.thisDXF.DrawingVariables.LUnits = DXFReaderNET.LinearUnitType.Scientific;
                    comboBoxLengthPrecision.Items.Clear();
                    comboBoxLengthPrecision.Items.Add("0E+01");
                    for (int k = 1; k <= 8; k++)
                    {
                        string s = "0.";
                        for (int j = 1; j <= k; j++)
                        {
                            s += "0";
                        }
                        s += "E+01";
                        comboBoxLengthPrecision.Items.Add(s);
                    }
                    dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimLengthUnits = LinearUnitType.Scientific;
                    //comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision;
                    break;
                case "Windows desktop":
                    comboBoxLengthPrecision.Items.Clear();
                    comboBoxLengthPrecision.Enabled = false;
                    dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimLengthUnits = LinearUnitType.WindowsDesktop;
                    //Global.thisDXF.DrawingVariables.LUnits = DXFReaderNET.LinearUnitType.WindowsDesktop;
                    break;

            }
            comboBoxLengthPrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision;
            ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
        }

        private void comboBoxAngleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxAngleType.SelectedItem)
            {
                case "Decimal degrees":
                case "Gradians":
                case "Radians":
                    comboBoxAnglePrecision.Items.Clear();
                    comboBoxAnglePrecision.Items.Add("0");
                    for (int k = 1; k <= 8; k++)
                    {
                        string s = "0.";
                        for (int j = 1; j <= k; j++)
                        {
                            s += "0";
                        }
                        if (comboBoxAngleType.SelectedItem.ToString() == "Gradians")
                        {
                            s += "g";
                        }
                        if (comboBoxAngleType.SelectedItem.ToString() == "Radians")
                        {
                            s += "r";
                        }
                        comboBoxAnglePrecision.Items.Add(s);
                    }
                    //comboBoxAnglePrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].AngularPrecision;

                    switch (comboBoxAngleType.SelectedItem)
                    {
                        case "Decimal degrees":
                            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimAngularUnits = AngleUnitType.DecimalDegrees;
                            break;
                        case "Gradians":
                            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimAngularUnits = AngleUnitType.Gradians;
                            break;
                        case "Radians":
                            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimAngularUnits = AngleUnitType.Radians;
                            break;
                    }

                    break;
                case "Degrees/Minutes/Seconds":
                case "Surveyor's units":

                    string preDir = "";
                    string postDir = "";
                    if (comboBoxAngleType.SelectedItem.ToString() == "Surveyor's units")
                    {
                        preDir = "N ";
                        postDir = " E";
                    }
                    comboBoxAnglePrecision.Items.Clear();
                    comboBoxAnglePrecision.Items.Add(preDir + "0d" + postDir);
                    comboBoxAnglePrecision.Items.Add(preDir + "0d00'" + postDir);
                    comboBoxAnglePrecision.Items.Add(preDir + "0d00'00\"" + postDir);
                    for (int k = 1; k <= 4; k++)
                    {
                        string s = "0d00'00.";
                        for (int j = 1; j <= k; j++)
                        {
                            s += "0";
                        }
                        s += "\"";

                        s = preDir + s + postDir;

                        comboBoxAnglePrecision.Items.Add(s);
                    }
                    //comboBoxAnglePrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].AngularPrecision;

                    switch (comboBoxAngleType.SelectedItem)
                    {
                        case "Degrees/Minutes/Seconds":
                            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimAngularUnits = AngleUnitType.DegreesMinutesSeconds;
                            break;
                        case "Surveyor's units":
                            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].DimAngularUnits = AngleUnitType.SurveyorUnits;
                            break;

                    }


                    break;


            }
            comboBoxAnglePrecision.SelectedIndex = dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].AngularPrecision;
            ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
        }

        private void comboBoxLengthPrecision_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].LengthPrecision = (short)comboBoxLengthPrecision.SelectedIndex;
            ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
        }

        private void comboBoxAnglePrecision_SelectedIndexChanged(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].AngularPrecision = (short)comboBoxAnglePrecision.SelectedIndex;
            ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());
        }

        private void comboBoxDimArrow1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dimstyle = ComboBox1.Items[ComboBox1.SelectedIndex].ToString();

            switch (comboBoxDimArrow1.SelectedItem)
            {
                case "dot":
                    dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Dot;
                    break;
                case "dot small": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.DotSmall; break;
                case "dot blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.DotBlank; break;
                case "origin indicator": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.OriginIndicator; break;
                case "origin indicator 2": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.OriginIndicator2; break;
                case "open": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Open; break;
                case "open 90 (right angle)": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Open90; break;
                case "open 30": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Open30; break;
                case "closed": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Closed; break;
                case "dot small blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.DotSmallBlank; break;
                case "none": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.None; break;
                case "oblique": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Oblique; break;
                case "box filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.BoxFilled; break;
                case "box": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Box; break;
                case "closed blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.ClosedBlank; break;
                case "datum triangle filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.DatumTriangleFilled; break;
                case "datum triangle": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.DatumTriangle; break;
                case "integral": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.Integral; break;
                case "architectural tick": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = DimensionArrowhead.ArchitecturalTick; break;
                case "closed filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow1 = null; break;




            }
            ViewStyle(dimstyle);
        }

        private void comboBoxDimArrow2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dimstyle = ComboBox1.Items[ComboBox1.SelectedIndex].ToString();

            switch (comboBoxDimArrow2.SelectedItem)
            {
                case "dot":
                    dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Dot;
                    break;
                case "dot small": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.DotSmall; break;
                case "dot blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.DotBlank; break;
                case "origin indicator": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.OriginIndicator; break;
                case "origin indicator 2": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.OriginIndicator2; break;
                case "open": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Open; break;
                case "open 90 (right angle)": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Open90; break;
                case "open 30": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Open30; break;
                case "closed": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Closed; break;
                case "dot small blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.DotSmallBlank; break;
                case "none": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.None; break;
                case "oblique": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Oblique; break;
                case "box filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.BoxFilled; break;
                case "box": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Box; break;
                case "closed blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.ClosedBlank; break;
                case "datum triangle filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.DatumTriangleFilled; break;
                case "datum triangle": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.DatumTriangle; break;
                case "integral": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.Integral; break;
                case "architectural tick": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = DimensionArrowhead.ArchitecturalTick; break;
                case "closed filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].DimArrow2 = null; break;




            }
            ViewStyle(dimstyle);
        }

        private void comboBoxArrowLeader_SelectedIndexChanged(object sender, EventArgs e)
        {
            string dimstyle = ComboBox1.Items[ComboBox1.SelectedIndex].ToString();

            switch (comboBoxArrowLeader.SelectedItem)
            {
                case "dot":
                    dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Dot;
                    break;
                case "dot small": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.DotSmall; break;
                case "dot blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.DotBlank; break;
                case "origin indicator": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.OriginIndicator; break;
                case "origin indicator 2": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.OriginIndicator2; break;
                case "open": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Open; break;
                case "open 90 (right angle)": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Open90; break;
                case "open 30": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Open30; break;
                case "closed": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Closed; break;
                case "dot small blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.DotSmallBlank; break;
                case "none": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.None; break;
                case "oblique": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Oblique; break;
                case "box filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.BoxFilled; break;
                case "box": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Box; break;
                case "closed blank": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.ClosedBlank; break;
                case "datum triangle filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.DatumTriangleFilled; break;
                case "datum triangle": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.DatumTriangle; break;
                case "integral": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.Integral; break;
                case "architectural tick": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = DimensionArrowhead.ArchitecturalTick; break;
                case "closed filled": dxfReaderNETControl1.DXF.DimensionStyles[dimstyle].LeaderArrow = null; break;

            }
            ViewStyle(dimstyle);
        }

        private void numericUpDownOffset_ValueChanged(object sender, EventArgs e)
        {
            if (ComboBox1.SelectedIndex >= 0)
            {
                dxfReaderNETControl1.DXF.DimensionStyles[ComboBox1.Items[ComboBox1.SelectedIndex].ToString()].ExtLineOffset = (double)numericUpDownOffset.Value;
                ViewStyle(ComboBox1.Items[ComboBox1.SelectedIndex].ToString());

            }
        }
    }

}
