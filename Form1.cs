using DXFReaderNET;
using DXFReaderNET.Entities;
using DXFReaderNET.Tables;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace DXFReaderNETDemoProgram
{
#pragma warning disable IDE0016, IDE0017, IDE0018, IDE0032, IDE0028, IDE0059, IDE1005, IDE1006
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region declarations

        private static Stack<string> UnDoStack = new Stack<string>();
        private static Stack<string> ReDoStack = new Stack<string>();



        private Vector2 panPointStart = Vector2.Zero;
        internal enum Commands
        {
            None,
            POINT,
            LINE,
            LINES,
            TRACE,
            MLINE,
            RAY,
            XLINE,
            CIRCLE_Center_Radius,
            CIRCLE_Diameter,
            CIRCLE_3Points,
            ELLIPSE,
            SLOT,
            LWPOLYLINE,
            POLYLINE,
            RECTANGLE,
            POLIGON,
            SOLID,
            SPLINE,
            ARCCenterStartAngleEndAngle,
            ARCStartPointMiddlePointEndPoint,
            ARCStartPointEndPointMiddlePoint,
            HATCH,
            HATCH_GRADIENT,
            INSERT,
            IMAGE,
            ATTACHPDF,
            TRIM,
            EXTEND,
            CHAMFER,
            OFFSET,
            JOIN,
            FILLET,
            NORMALIZE,
            COPY,
            MOVE,
            ROTATE,
            CREATEBLOCK,
            MIRROR,
            CREATELWPOLYLINE,
            CREATEBULGEDLWPOLYLINE,
            ARRAY,
            POLARARRAY,
            EXPLODEINSERT,
            EXPLODEDIMENSION,
            EXPLODEPOLYLINE,
            EXPLODESPLINE,
            EXPLODECIRCLE,
            EXPLODEELLIPSE,
            EXPLODEREGION,
            DIMENSION,
            TEXT,
            DISTANCE,
            AREA,
            LEADER,




        }

        internal enum FunctionsEnum
        {
            None,
            Point,
            Line1,
            Line2,
            Lines,
            EntityProperties,
            PrintEntityProperties,
            GetEntity,
            GetGroupEntities,
            ListXdata,
            GetEntities,
            GetEntities1,
            GetEntities2,
            CopyEntities1,
            CopyEntities2,
            MoveEntitiesRubber1,
            MoveEntitiesRubber2,
            MoveEntitiesRubber3,
            MoveEntities1,
            MoveEntities2,
            RotateEntities,
            RotateEntities1,
            RotateEntities2,
            ScaleEntities,
            ScaleEntities1,
            ScaleEntities2,
            Ungroup,
            Circle1,
            Circle2,
            Circle2p1,
            Circle2p2,
            Circle3p1,
            Circle3p2,
            Circle3p3,
            Ellipse1,
            Ellipse2,
            Ellipse3,
            ZoomWindow1,
            ZoomWindow2,
            Connect1,
            Connect2,
            Distance1,
            Distance2,
            LocatePoint,
            Radius,
            Area,
            LwPolyline,
            Polyline,
            PolylineLenght,
            Mline,
            Spline,
            SetLimits1,
            SetLimits2,
            Ray1,
            Ray2,
            Xline1,
            Xline2,
            Rectangle0,
            Rectangle1,
            Rectangle2,
            Trace1,
            Trace2,
            Solid1,
            Solid2,
            Solid3,
            Solid4,
            Polygon1,
            Polygon2,
            MoveEnt1,
            MoveEnt2,
            PlotWindow1,
            PlotWindow2,
            Image1,
            Image2,
            ImageFixedSize,
            PDFUnderlay,
            Hatch,
            HatchOutermost,
            HatchBoundaries,
            HatchPoint,
            HatchRecangle1,
            HatchRecangle2,
            GradientHatch,
            GradientHatchOutermost,
            GradientHatchBoundaries,
            GradientHatchPoint,
            GradientHatchRectangle1,
            GradientHatchRectangle2,
            Arc1,
            Arc2,
            Arc3,
            ArcCenterPStartPEnd1,
            ArcCenterPStartPEnd2,
            ArcCenterPStartPEnd3,
            ArcStartMiddleEnd1,
            ArcStartMiddleEnd2,
            ArcStartMiddleEnd3,
            ArcStartEndMiddle1,
            ArcStartEndMiddle2,
            ArcStartEndMiddle3,
            DrawPoint,
            DrawLine1,
            DrawLine2,
            DrawCircle1,
            DrawCircle2,
            DrawArc1,
            DrawArc2,
            DrawArc3,
            DrawPolygon,
            DrawImage1,
            DrawImage2,
            DrawImageFixedSize,
            DrawText,
            ExplodeInsert,
            ExplodeInsert1,
            ExplodeInsert2,
            ExplodeDimension,
            ExplodePoly,
            ExplodePoly1,
            ExplodePoly2,
            ExplodeCircle,
            ExplodeSpline,
            ExplodeSplineRect1,
            ExplodeSplineRect2,
            ExplodeArc,
            ExplodeEllipse,
            ExplodeEllipseArcs,
            ExplodeCircleArcs,
            ExplodeRegion,
            Offset1,
            Offset2,
            Trim1,
            Trim2,
            Extend1,
            Extend2,
            Fillet1,
            Fillet2,
            Chamfer1,
            Chamfer2,
            Join1,
            Join2,
            Slot1,
            Slot2,
            Block,
            Insert,
            RotateAxis1,
            RotateAxis2,
            Text,
            AlignedDimension1,
            AlignedDimension2,
            AlignedDimension3,
            AlignedDimensionLine1,
            AlignedDimensionLine2,
            LinearDimension1,
            LinearDimension2,
            LinearDimension3,
            LinearDimensionLine1,
            LinearDimensionLine2,
            AngularDimension2Lines1,
            AngularDimension2Lines2,
            AngularDimension2Lines3,
            AngularDimensionArc1,
            AngularDimensionArc2,
            AngularDimensionCenterStartEnd1,
            AngularDimensionCenterStartEnd2,
            AngularDimensionCenterStartEnd3,
            AngularDimensionCenterStartEnd4,
            DiametricDimension1,
            DiametricDimension2,
            RadialDimension1,
            RadialDimension2,
            WindowDrag,
            PointInsidePolygon,
            Array1,
            Array2,
            ArrayPolar,
            Contour,
            Orbit3D,
            Lw2Poly,
            Poly2Lw,
            Leader1,
            Leader2,
            Leader3,

        }
        //private string cmdCoord = "";
        private FunctionsEnum _CurrentFunction = FunctionsEnum.None;

        private Commands LastCommand = Commands.None;

        private FunctionsEnum CurrentFunction
        {
            get { return _CurrentFunction; }
            set
            {
                _CurrentFunction = value;
                ShowCommandLine();
            }
        }
        private int m_SelectedContours = 0;

        private double m_mlineScale = 20;
        List<DXFReaderNET.Objects.Group> addedContours = new List<DXFReaderNET.Objects.Group>();

        private double m_RectangleFilletRadius = 0;
        private int m_precision = 100;


        private Vector2 p = Vector2.Zero;
        private Vector2 p1 = Vector2.Zero;
        private Vector2 pstart = Vector2.Zero;
        private bool leftPressed = false;
        private Vector2 p2 = Vector2.Zero;
        private Vector2 p3 = Vector2.Zero;
        private Vector2 p4 = Vector2.Zero;
        private readonly char decimalSeparetor = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator.ToCharArray()[0];
        private readonly List<Vector2> vertexes = new List<Vector2>();
        private readonly List<EntityObject> Boundary = new List<EntityObject>();
        private readonly List<EntityObject> BoundaryOutermost = new List<EntityObject>();

        private readonly Cyotek.Windows.Forms.ColorPickerDialog Cdialog = new Cyotek.Windows.Forms.ColorPickerDialog();
        private string CurrentLoadDXFPath = Application.StartupPath;
        private string CurrentLoadRecoveryDXFPath = Application.StartupPath;
        private string CurrentLoadOBJPath = Application.StartupPath;
        private string CurrentSaveDXFPath = Application.StartupPath;
        private string CurrentSaveBMPPath = Application.StartupPath;
        private RubberBandType m_RubberBandType = RubberBandType.Dashed;
        private Color m_RubberBandColor = Color.FromArgb(150, 150, 150);

        private bool OnPlotPreview = false;

        private double VideoSize = 0;

        private readonly List<string> FileInfos = new List<string>();
        private readonly int maxMRUnumber = 15;
        private short PolygonSides = 6;

        private EntityObject m_filletLine1 = null;
        private EntityObject m_filletLine2 = null;



        private EntityObject m_entOffset = null;
        private List<EntityObject> m_entTrimBoundaries = new List<EntityObject>();
        private EntityObject m_entJoinBoundary = null;
        private EntityObject m_entExtendBoundary = null;

        private EntityObject m_entTrim = null;
        private string m_ImageFileName = "";
        private string m_ImageRotation = "0";
        private string m_TextRotation = "0";
        private string m_ImageTransparency = "0";
        private string m_PatternName = "SOLID";
        private string m_HatchRotation = "0";
        private string m_HatchBoundaries = "Choose single entities";
        private string m_HatchScale = "1";
        private string m_newBlockName = "";
        private string m_BlockName = "";
        private string m_BlockRotation = "0";
        private string m_BlockScale = "1";
        private string m_Text = "";
        private string m_DrawText = "";
        private double m_DrawTextHeight = 2.5;
        private FontStyle m_FontStyle = FontStyle.Regular;
        private StringAlignment m_Alignment = StringAlignment.Near;

        private string m_GradientPatternName = "Linear";
        private string m_GradientHatchRotation = "0";
        private string m_GradientHatchBoundaries = "Choose single entities";
        private string m_GradientHatchTransparency = "0";
        private bool m_GradientHatchCentered = true;
        private short m_GradientAciColor1 = 1;
        private short m_GradientAciColor2 = 5;

        private string m_PDFFileName = "";
        private string m_PDFRotation = "0";
        private string m_PDFScale = "1";
        private string m_PDFTransparency = "0";

        private bool m_PDFMonochrome = true;
        private Color CurrentDrawColor = Color.Red;
        private float CurrentDrawPenWidth = 0;
        private string CurrentDrawPenStyle = "Continuous";
        private float CurrentDrawDashLength = 10;
        private float CurrentDrawSkipLength = 10;

        private Pen DrawPen;
        private Vector2 pNoSnap;
        private double m_rotation = 0;
        private double m_scale = 1;
        private double m_offset = 0;

        private int m_ImageWidth = 0;
        private int m_ImageHeight = 0;
        private bool m_ImageScaleOnScreen = true;
        private bool m_ContinuousSelection = false;
        private bool m_ImageEmbed = false;
        private bool m_showCommandLine = false;
        private bool m_selectRotationOnScreen = false;
        private int m_ArrayColumns = 2;
        private int m_ArrayRows = 2;
        private int m_PolarArrayItems = 4;


        private EntityObject m_LastAddedEntity = null;
        private bool addedMultipleEntities = false;
        private EntityObject SelectedEntity = null;
        private Line SelectedLine = null;
        private Line SelectedLine1 = null;

        internal enum PrintTypeEnum
        {
            Drawing,
            EntityProperties,
            EntiesList
        }

        private PrintTypeEnum PrintType = PrintTypeEnum.Drawing;
        private readonly List<HatchPattern> hatchPatternsCustom = new List<HatchPattern>();

        #endregion


        private void Form1_Load(object sender, EventArgs e)
        {

            LoadRegistry();
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.SplitterDistance = 0;
            dxfReaderNETControl1.NewDrawing();
            ErrorLabel.Text = "";
            InitDrawing();

            ribbonButtonInquiryTest.Visible = false;
            //.Visible = false;
            ribbonButtonCommandLine.Visible = false;

            ribbonButtonPointInPolygon.Visible = false;
            ribbonPanelHelp.ButtonMoreVisible = false;
            ribbonButtonModifyFillet.Visible = false;
            ribbonButtonShowFilledAreas.Visible = false;
            ribbonButtonTruTOPS.Visible = false;
            ribbonButtonSplitSections.Visible = false;
            ribbonButtonRecoverDXFFIle.Visible = false;
            ribbonButtonPrintEntityProp.Visible = false;
            ribbonPanelHelp.ButtonMoreVisible = false;

            ribbonButton1SaveTest.Visible = false;


            ribbonButtonInquiryXdata.Visible = false;
            ribbonButtonPrintEntitiesList.Visible = false;
            ribbonButtonShowData.Visible = false;

            DrawPen = new Pen(CurrentDrawColor);
            DrawPen.Width = CurrentDrawPenWidth;
            if (CurrentDrawPenStyle == "Continuous")
            {
                DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            }
            else
            {
                DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                DrawPen.DashPattern = new float[] { CurrentDrawDashLength, CurrentDrawSkipLength };
            }
#if DEBUG
            ribbonButtonInquiryTest.Visible = true;
            //ribbonComboBoxLayout.Visible = true;
            ribbonButtonCommandLine.Visible = true;

            ribbonButtonPointInPolygon.Visible = true;
            ribbonPanelHelp.ButtonMoreVisible = true;
            ribbonButtonModifyFillet.Visible = true;
            ribbonButtonShowFilledAreas.Visible = true;
            ribbonButtonTruTOPS.Visible = true;
            ribbonButtonSplitSections.Visible = true;
            ribbonButtonRecoverDXFFIle.Visible = true;

            ribbonButton1SaveTest.Visible = true;

            ribbonButtonPrintEntityProp.Visible = true;
            ribbonPanelHelp.ButtonMoreVisible = true;
            ribbonButtonInquiryXdata.Visible = true;
            ribbonButtonPrintEntitiesList.Visible = true;
            ribbonButtonShowData.Visible = true;
#endif

            CheckContinuousSelection();

        }

        private void InitDrawing()
        {

            toolStripProgressBar1.Value = 0;
            AddLinetipes(dxfReaderNETControl1);
            AddLayerIfNotPresent("AUXILIARY");
            //dxfReaderNETControl1.DXF.Layers["AUXILIARY"].IsLocked = true;
            dxfReaderNETControl1.DXF.Layers["AUXILIARY"].Color = AciColor.FromCadIndex(10);
            dxfReaderNETControl1.DXF.Layers["AUXILIARY"].Linetype = dxfReaderNETControl1.DXF.Linetypes["ISO double-dash dot __ __ . __ __ . __ __ . __ _"];
            dxfReaderNETControl1.DXF.Layers["AUXILIARY"].Transparency.Value = 50;

            ribbonButtonViewTreeView.Checked = false;
            splitContainer1.SplitterDistance = 0;
            splitContainer1.IsSplitterFixed = true;
            TreeView1.Visible = false;
            //RefreshTree();

            hatchPatternsCustom.Clear();
            ribbonButtonUndo.Enabled = false;
            ribbonButtonRedo.Enabled = false;
            UnDoStack.Clear();
            ReDoStack.Clear();
            dxfReaderNETControl1.Dock = DockStyle.Fill;

            //printPreviewControl1.Dock = DockStyle.Fill;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            StatusLabel.Text = "";

            StatusLabelX.Text = "";
            StatusLabelY.Text = "";
            toolStripStatusLabelInfo.Text = "";
            StatusLabelGrid.Text = "";
            CurrentFunction = FunctionsEnum.None;

            this.Text = "DXFReader.NET Component - Demo Program";
            ribbonColors();
            SetSnapRibbon();
            ////////////////////////////////////////////////////////////////////////
            LoadLayersCombo();

            ////////////////////////////////////////////////////////////////////////

            ////////////////////////////////////////////////////////////////////////
            ribbonButtonModPropLayer.DropDownItems.Clear();

            foreach (DXFReaderNET.Tables.Layer layer in dxfReaderNETControl1.DXF.Layers)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = layer.Name;
                ribbonButtonModPropLayer.DropDownItems.Add(newItem);

            }

            ////////////////////////////////////////////////////////////////////////

            ///////////////////////////////////////////////////////////////////////////
            ribbonButtonModPropLineType.DropDownItems.Clear();

            foreach (DXFReaderNET.Tables.Linetype linetype in dxfReaderNETControl1.DXF.Linetypes)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = linetype.Name;
                ribbonButtonModPropLineType.DropDownItems.Add(newItem);

            }

            ///////////////////////////////////////////////////////////////////////////
            ///


            ///////////////////////////////////////////////////////////////////////////
            ribbonButtonModPropLineWeight.DropDownItems.Clear();
            List<Lineweight> lwl = Enum.GetValues(typeof(Lineweight)).Cast<Lineweight>().ToList();
            foreach (Lineweight lw in lwl)
            {

                RibbonButton newItem = new RibbonButton();
                newItem.Text = lw.ToString();
                ribbonButtonModPropLineWeight.DropDownItems.Add(newItem);

            }



            ///////////////////////////////////////////////////////////////////////////


            for (int k = ribbonButtonModPropGroup.DropDownItems.Count - 1; k > 0; k--)
            {
                ribbonButtonModPropGroup.DropDownItems.Remove(ribbonButtonModPropGroup.DropDownItems[k]);
            }

            if (dxfReaderNETControl1.DXF.Groups != null)
            {
                foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                {
                    RibbonButton newItem = new RibbonButton();
                    newItem.Text = _group.Name;
                    ribbonButtonModPropGroup.DropDownItems.Add(newItem);

                }
            }
            ////////////////////////////////////////////////////////////////////////

            FillComboDimStyles();


            ////////////////////////////////////////////////////////////////////////


            ribbonComboBoxTextStyle.DropDownItems.Clear();
            foreach (DXFReaderNET.Tables.TextStyle _TableSymbol in dxfReaderNETControl1.DXF.TextStyles.Items)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = _TableSymbol.Name;
                ribbonComboBoxTextStyle.DropDownItems.Add(newItem);
                if (dxfReaderNETControl1.DXF.CurrentTextStyle.ToLower() == _TableSymbol.Name.ToLower())
                {
                    ribbonComboBoxTextStyle.SelectedItem = newItem;
                }
            }

            ////////////////////////////////////////////////////////////////////////


            LoadViewsCombo();
            ////////////////////////////////////////////////////////////////////////
            LoadLtypesCombo();

            ////////////////////////////////////////////////////////////////////////




            ////////////////////////////////////////////////////////////////////////


            ribbonComboBoxLayout.DropDownItems.Clear();
            foreach (DXFReaderNET.Objects.Layout _layout in dxfReaderNETControl1.DXF.Layouts)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = _layout.Name;
                ribbonComboBoxLayout.DropDownItems.Add(newItem);

                if (dxfReaderNETControl1.DXF.ActiveLayout == _layout.Name)

                {
                    ribbonComboBoxLayout.SelectedItem = newItem;
                }

            }

            ////////////////////////////////////////////////////////////////////////
            ribbonComboBox3D.Image = ribbonButtonView3DTop.LargeImage;
            ribbonComboBox3D.TextBoxText = "";

            ribbonComboBoxRendering.Image = ribbonButtonRenderingWireframe.SmallImage;

            ribbonColorChooserColor.Color = dxfReaderNETControl1.DXF.CurrentColor.ToColor();
            ribbonLabelCurrentColor.Text = dxfReaderNETControl1.DXF.CurrentColor.ToString();



            ribbonTextBoxElevation.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.CurrentElevation);
            ribbonTextBoxThickness.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.CurrentThickness);
            ribbonTextBoxLtScale.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.CurrentLineTypeScale);

            ////////////////////////////////////////////////////////////////////////

            switch (m_RubberBandType)
            {
                case RubberBandType.Dashed:
                    ribbonButtonRubberBandStyle.SelectedItem = ribbonButtonRubberBandStyleDashed;
                    break;
                case RubberBandType.Solid:
                    ribbonButtonRubberBandStyle.SelectedItem = ribbonButtonRubberBandStyleSolid;
                    break;

            }

            ////////////////////////////////////////////////////////////////////////

            switch (dxfReaderNETControl1.PlotMode)
            {
                case PlotModeType.Display:
                    ribbonComboBoxPlotMode.SelectedItem = ribbonButtonPlotModeDisplay;
                    break;
                case PlotModeType.Extents:
                    ribbonComboBoxPlotMode.SelectedItem = ribbonButtonPlotModeExtents;
                    break;
                case PlotModeType.Limits:
                    ribbonComboBoxPlotMode.SelectedItem = ribbonButtonPlotModeLimits;
                    break;
                case PlotModeType.Window:
                    ribbonComboBoxPlotMode.SelectedItem = ribbonButtonPlotModeWindow;
                    break;
                case PlotModeType.Centered:
                    ribbonComboBoxPlotMode.SelectedItem = ribbonButtonPlotModeCentered;
                    break;
            }

            ////////////////////////////////////////////////////////////////////////
            switch (dxfReaderNETControl1.PlotRendering)
            {
                case PlotRenderingType.GrayScale:
                    ribbonComboBoxPlotRendering.SelectedItem = ribbonButtonPlotRenderingGrayScale;
                    break;
                case PlotRenderingType.Monochrome:
                    ribbonComboBoxPlotRendering.SelectedItem = ribbonButtonPlotRenderingMonochrome;
                    break;
                case PlotRenderingType.Color:
                    ribbonComboBoxPlotRendering.SelectedItem = ribbonButtonPlotRenderingColor;
                    break;

            }
            ////////////////////////////////////////////////////////////////////////
            switch (dxfReaderNETControl1.PlotRotation)
            {
                case PlotOrientationType.Portrait:
                    ribbonComboBoxPlotRotation.SelectedItem = ribbonButtonPlotRotationPortrait;
                    break;
                case PlotOrientationType.Landscape:
                    ribbonComboBoxPlotRotation.SelectedItem = ribbonButtonPlotRotationLandscape;
                    break;


            }

            ////////////////////////////////////////////////////////////////////////
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    ribbonComboBoxPlotUnits.SelectedItem = ribbonButtonPlotUnitsMillimeters;
                    break;
                case PlotUnitsType.Inchs:
                    ribbonComboBoxPlotUnits.SelectedItem = ribbonButtonPlotUnitsInchs;
                    break;


            }
            ////////////////////////////////////////////////////////////////////////
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    ribbonUpDownPlotMarginTop.TextBoxText = dxfReaderNETControl1.PlotMarginTop.ToString("###0");
                    ribbonUpDownPlotMarginBottom.TextBoxText = dxfReaderNETControl1.PlotMarginBottom.ToString("###0");
                    ribbonUpDownPlotMarginLeft.TextBoxText = dxfReaderNETControl1.PlotMarginLeft.ToString("###0");
                    ribbonUpDownPlotMarginRight.TextBoxText = dxfReaderNETControl1.PlotMarginRight.ToString("###0");
                    ribbonTextBoxPlotOriginX.TextBoxText = dxfReaderNETControl1.PlotOffset.X.ToString("###0");
                    ribbonTextBoxPlotOriginY.TextBoxText = dxfReaderNETControl1.PlotOffset.Y.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    ribbonUpDownPlotMarginTop.TextBoxText = dxfReaderNETControl1.PlotMarginTop.ToString("#0.0");
                    ribbonUpDownPlotMarginBottom.TextBoxText = dxfReaderNETControl1.PlotMarginBottom.ToString("#0.0");
                    ribbonUpDownPlotMarginLeft.TextBoxText = dxfReaderNETControl1.PlotMarginLeft.ToString("#0.0");
                    ribbonUpDownPlotMarginRight.TextBoxText = dxfReaderNETControl1.PlotMarginRight.ToString("#0.0");
                    ribbonTextBoxPlotOriginX.TextBoxText = dxfReaderNETControl1.PlotOffset.X.ToString("#0.00");
                    ribbonTextBoxPlotOriginY.TextBoxText = dxfReaderNETControl1.PlotOffset.Y.ToString("#0.00");

                    break;

            }
            ribbonUpDownPlotPenWidth.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.PlotPenWidth);
            ribbonTextBoxPlotScale.TextBoxText = dxfReaderNETControl1.PlotScale.ToString();

            ribbonUpDownPickBoxSize.TextBoxText = dxfReaderNETControl1.CursorSelectionSize.ToString("###0");
            ribbonUpDownRubberPenWidth.TextBoxText = dxfReaderNETControl1.RubberBandPenWidth.ToString("###0");

            ribbonUpDownZoomFactor.TextBoxText = dxfReaderNETControl1.ZoomInOutPercent.ToString("###0");

            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
            ShowStatusLabels();

            LastCommand = Commands.None;






            //dxfReaderNETControl1.HighlightNotContinuous = true;
        }

        private void ribbonColors()
        {
            ribbonColorChooserForeColor.Color = dxfReaderNETControl1.ForeColor;
            ribbonColorChooserBackColor.Color = dxfReaderNETControl1.BackColor;

            ribbonColorChooserGrid.Color = dxfReaderNETControl1.GridColor;
            ribbonColorChooserAxes.Color = dxfReaderNETControl1.AxesColor;
            ribbonColorChooserAxisX.Color = dxfReaderNETControl1.AxisXColor;
            ribbonColorChooserAxisY.Color = dxfReaderNETControl1.AxisYColor;
            ribbonColorChooserAxisZ.Color = dxfReaderNETControl1.AxisZColor;

            ribbonColorChooserHighlight.Color = dxfReaderNETControl1.HighlightColor;
            ribbonColorChooserHighlightMarker.Color = dxfReaderNETControl1.HighlightMarkerColor;
            ribbonColorChooserHighlightMarker2.Color = dxfReaderNETControl1.HighlightMarkerColor2;
            ribbonColorChooserRubberBand.Color = m_RubberBandColor;
            ribbonButtonHighlight.Checked = dxfReaderNETControl1.HighlightEntityOnHover;
            ribbonButtonCheckContHighligh.Checked = dxfReaderNETControl1.ContinuousHighlight;
            ribbonButton11.Checked = dxfReaderNETControl1.HighlightNotContinuous;
            ribbonButtonGrabPoints.Checked = dxfReaderNETControl1.HighlightGrabPoints;
            ribbonButtonContinuosSelection.Checked = m_ContinuousSelection;

            ribbonButtonModifySelectSingleMulti.Enabled = !m_ContinuousSelection;
            ribbonButtonModifySelectSinlge.Enabled = !m_ContinuousSelection;

            ribbonButtonShowAxes.Checked = dxfReaderNETControl1.ShowAxes;
            ribbonButtonShowBasepoint.Checked = dxfReaderNETControl1.ShowBasePoint;
            ribbonButtonShowLimits.Checked = dxfReaderNETControl1.ShowLimits;
            ribbonButtonShowgrid.Checked = dxfReaderNETControl1.ShowGrid;
            ribbonButtonGridRuler.Checked = dxfReaderNETControl1.ShowGridRuler;
            ribbonButtonAntialias.Checked = dxfReaderNETControl1.AntiAlias;
            ribbonColorChooserDrawMethodsColor.Color = CurrentDrawColor;
            ribbonButtonCommandLine.Checked = m_showCommandLine;
            //labelCommands.Visible = ribbonButtonCommandLine.Checked;
            panelCommands.Visible = ribbonButtonCommandLine.Checked;
            ribbonButtonShowExtents.Checked = dxfReaderNETControl1.ShowExtents;
            ribbonButtonGridInsideLimits.Checked = false;
            if (dxfReaderNETControl1.GridDisplay == GridDisplayType.InsideDrawingLimits)
            {
                ribbonButtonGridInsideLimits.Checked = true;
            }

            ribbonButtonHighlight.Checked = dxfReaderNETControl1.HighlightEntityOnHover;







        }

        private void SetSnapRibbon()
        {
            ribbonButtonObjectSnapEndpoint.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Endpoint);
            ribbonButtonObjectSnapMidpoint.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Midpoint);
            ribbonButtonObjectSnapCenter.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Center);
            ribbonButtonObjectSnapIntersection.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Intersection);
            ribbonButtonObjectSnapQuadrant.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Quadrant);
            ribbonButtonObjectSnapPerpendicular.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Perpendicular);
            ribbonButtonObjectSnapTangent.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Tangent);
            ribbonButtonObjectSnapInsertion.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Insertion);
            ribbonButtonObjectSnapNearest.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Nearest);
            ribbonButtonObjectSnapNode.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.Node);
            ribbonButtonObjectSnapGeometricCenter.Checked = dxfReaderNETControl1.ObjectOsnapMode.HasFlag(ObjectOsnapTypeFlags.GeometricCenter);
        }

        private void ShowStatusLabels()
        {

            if (dxfReaderNETControl1.ShowGrid)
            {
                StatusLabelGrid.Image = imageListStatusBar.Images[1];
            }
            else
            {
                StatusLabelGrid.Image = imageListStatusBar.Images[0];
            }


            if (dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode != 0)
            {
                StatusLabelOrtho.Image = imageListStatusBar.Images[3];
            }
            else
            {
                StatusLabelOrtho.Image = imageListStatusBar.Images[2];
            }


            if (dxfReaderNETControl1.DXF.VPorts["*Active"].SnapMode)
            {
                StatusLabelSnap.Image = imageListStatusBar.Images[5];
            }
            else
            {
                StatusLabelSnap.Image = imageListStatusBar.Images[4];
            }



        }

        private void ribbonButton6_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomExtents();
            // dxfReaderNETControl1.ZoomCenter();
        }

        private void ribbonButton5_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomLimits();
        }

        private void dxfReaderNETControl1_MouseMove(object sender, MouseEventArgs e)
        {

            p = dxfReaderNETControl1.CurrentWCSpoint;
            StatusLabelX.Text = "x: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X);
            StatusLabelY.Text = "y: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y);
            if (CurrentFunction == FunctionsEnum.Orbit3D)
            {
                dxfReaderNETControl1.Orbit(p, panPointStart);
                return;
            }

            if (e.Button == MouseButtons.Middle)
            {
                dxfReaderNETControl1.Pan(p, panPointStart);
                return;
            }

            if (e.Button == MouseButtons.Left && (CurrentFunction == FunctionsEnum.None || CurrentFunction == FunctionsEnum.GetEntities))
            {
                dxfReaderNETControl1.ShowRubberBandBox(pstart, p);
                leftPressed = true;
            }

            switch (CurrentFunction)
            {
                case FunctionsEnum.Slot2:
                    p2 = p;
                    List<EntityObject> slotEnts = new List<EntityObject>();

                    double r = Math.Abs(p2.Y - p1.Y) / 2;
                    Vector2 A = new Vector2(p1.X + r, p1.Y);
                    Vector2 B = new Vector2(p2.X - r, p1.Y);

                    Vector2 Ap = new Vector2(p1.X + r, p2.Y);
                    Vector2 Bp = new Vector2(p2.X - r, p2.Y);
                    double ang1 = 270;
                    double ang2 = 90;
                    if (p2.X - p1.X > 0)
                    {
                        if (Math.Abs(p2.X - p1.X) < 2 * r)
                        {
                            A = new Vector2(p1.X + r, p2.Y - r);
                            B = A;

                            Ap = A;
                            Bp = Ap;

                        }
                    }
                    else
                    {
                        if (Math.Abs(p2.X - p1.X) < 2 * r)
                        {
                            A = new Vector2(p1.X - r, p2.Y - r); ;
                            B = A;

                            Ap = A;
                            Bp = Ap;

                        }
                        else
                        {
                            A = new Vector2(p1.X - r, p1.Y);
                            B = new Vector2(p2.X + r, p1.Y);
                            Ap = new Vector2(p1.X - r, p2.Y);
                            Bp = new Vector2(p2.X + r, p2.Y);
                            ang1 = 90;
                            ang2 = 270;
                        }
                    }


                    Line l1 = new Line(A, B);
                    Line l2 = new Line(Ap, Bp);

                    Arc a1 = new Arc(Vector2.MidPoint(B, Bp), r, ang1, ang2);
                    Arc a2 = new Arc(Vector2.MidPoint(A, Ap), r, ang2, ang1);
                    slotEnts.Add(l1);
                    slotEnts.Add(l2);
                    slotEnts.Add(a1);
                    slotEnts.Add(a2);




                    dxfReaderNETControl1.ShowRubberBandEntities(slotEnts, Vector2.Zero, m_RubberBandColor, m_RubberBandType);
                    toolStripStatusLabelInfo.Text = "ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p1.Y);
                    break;

                case FunctionsEnum.DiametricDimension2:
                case FunctionsEnum.RadialDimension2:
                    if (SelectedEntity.Type == EntityType.Circle)
                        dxfReaderNETControl1.ShowRubberBandLine(((Circle)SelectedEntity).Center.ToVector2(), p, m_RubberBandColor, m_RubberBandType);
                    if (SelectedEntity.Type == EntityType.Arc)
                        dxfReaderNETControl1.ShowRubberBandLine(((Arc)SelectedEntity).Center.ToVector2(), p, m_RubberBandColor, m_RubberBandType);


                    break;

                case FunctionsEnum.LinearDimensionLine2:

                    double rotation = 0;
                    if (SelectedLine.StartPoint.X < SelectedLine.EndPoint.X)
                    {
                        if (p.X > SelectedLine.EndPoint.X || p.X < SelectedLine.StartPoint.X)
                        {
                            rotation = 90;
                        }
                    }
                    else
                    {
                        if (p.X < SelectedLine.EndPoint.X || p.X > SelectedLine.StartPoint.X)
                        {
                            rotation = 90;
                        }
                    }

                    dxfReaderNETControl1.ShowRubberBandLinearDimension(SelectedLine, p, rotation, m_RubberBandColor, m_RubberBandType);


                    break;

                case FunctionsEnum.LinearDimension3:

                    rotation = 0;

                    if (p.X > p2.X || p.X < p1.X)
                    {
                        rotation = 90;

                    }

                    dxfReaderNETControl1.ShowRubberBandLinearDimension(p1, p2, p, rotation, m_RubberBandColor, m_RubberBandType);


                    break;

                case FunctionsEnum.AlignedDimensionLine2:
                    dxfReaderNETControl1.ShowRubberBandAlignedDimension(SelectedLine, p, m_RubberBandColor, m_RubberBandType);
                    break;
                case FunctionsEnum.AlignedDimension3:
                    dxfReaderNETControl1.ShowRubberBandAlignedDimension(p1, p2, p, m_RubberBandColor, m_RubberBandType);
                    break;

                case FunctionsEnum.AngularDimensionArc2:
                    Arc arc = (Arc)SelectedEntity;
                    dxfReaderNETControl1.ShowRubberBandAngularDimension(arc.Center.ToVector2(), arc.Radius, arc.StartAngle, arc.EndAngle, p, m_RubberBandColor, m_RubberBandType);
                    break;
                case FunctionsEnum.GradientHatchBoundaries:
                case FunctionsEnum.HatchBoundaries:

                case FunctionsEnum.Leader2:
                case FunctionsEnum.Leader3:
                case FunctionsEnum.Lines:
                case FunctionsEnum.PolylineLenght:
                case FunctionsEnum.Polyline:
                case FunctionsEnum.LwPolyline:
                case FunctionsEnum.Mline:
                case FunctionsEnum.Area:
                case FunctionsEnum.DrawPolygon:
                    if (vertexes.Count > 0)
                    {

                        dxfReaderNETControl1.ShowRubberBandLine(vertexes[vertexes.Count - 1], p, null, RubberBandType.Dashed, true);
                        toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(vertexes[vertexes.Count - 1], p));
                        toolStripStatusLabelInfo.Text += " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - vertexes[vertexes.Count - 1].X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - vertexes[vertexes.Count - 1].Y);

                        double angXY = Vector2.Angle(vertexes[vertexes.Count - 1], p);
                        toolStripStatusLabelInfo.Text += " Angle: " + dxfReaderNETControl1.DXF.ToFormattedAngle(angXY);


                    }
                    break;







                case FunctionsEnum.DrawImageFixedSize:
                case FunctionsEnum.ImageFixedSize:

                    dxfReaderNETControl1.ShowRubberBandBox(p, m_ImageWidth, m_ImageHeight);


                    break;
                case FunctionsEnum.Rectangle2:
                    p2 = p;
                    if (m_RectangleFilletRadius != 0)
                    {
                        List<EntityObject> rectEnts = new List<EntityObject>();
                        double filletradius = 0;
                        double filletradius2 = 0;
                        double rr = m_RectangleFilletRadius;
                        if (Math.Abs(p2.X - p1.X) > Math.Abs(rr * 2) && Math.Abs(p2.Y - p1.Y) > Math.Abs(rr * 2))
                        {
                            filletradius = Math.Abs(rr);
                            filletradius2 = rr;
                        }


                        Vector2 pr1s = new Vector2(p1.X + filletradius, p1.Y);
                        Vector2 pr1e = new Vector2(p2.X - filletradius, p1.Y);
                        Vector2 pr2s = new Vector2(p2.X, p1.Y + filletradius);
                        Vector2 pr2e = new Vector2(p2.X, p2.Y - filletradius);
                        Vector2 pr3s = new Vector2(p2.X - filletradius, p2.Y);
                        Vector2 pr3e = new Vector2(p1.X + filletradius, p2.Y);
                        Vector2 pr4s = new Vector2(p1.X, p2.Y - filletradius);
                        Vector2 pr4e = new Vector2(p1.X, p1.Y + filletradius);

                        if ((p2.X - p1.X) < 0)
                        {
                            pr1e = new Vector2(p1.X - filletradius, p1.Y);
                            pr1s = new Vector2(p2.X + filletradius, p1.Y);
                            pr3e = new Vector2(p2.X + filletradius, p2.Y);
                            pr3s = new Vector2(p1.X - filletradius, p2.Y);


                        }
                        if ((p2.Y - p1.Y) < 0)
                        {
                            pr2e = new Vector2(p2.X, p1.Y - filletradius);
                            pr2s = new Vector2(p2.X, p2.Y + filletradius);

                            pr4e = new Vector2(p1.X, p2.Y + filletradius);
                            pr4s = new Vector2(p1.X, p1.Y - filletradius);
                        }
                        Arc a = new Arc();
                        Line lrect1 = new Line(pr1s, pr1e);
                        rectEnts.Add(lrect1);
                        a = new Arc(new Vector2(pr1e.X, pr2s.Y), filletradius, 270, 0);
                        if (filletradius2 < 0)
                        {

                            a = new Arc(new Vector2(pr1e.X - filletradius2, pr2s.Y + filletradius2), filletradius2, 270, 0);
                        }
                        rectEnts.Add(a);


                        Line lrect2 = new Line(pr2s, pr2e);
                        rectEnts.Add(lrect2);
                        a = new Arc(new Vector2(pr3s.X, pr2e.Y), filletradius, 0, 90);
                        if (filletradius2 < 0)
                        {
                            a = new Arc(new Vector2(pr3s.X - filletradius2, pr2e.Y - filletradius2), filletradius2, 0, 90);

                        }
                        rectEnts.Add(a);
                        Line lrect3 = new Line(pr3s, pr3e);
                        rectEnts.Add(lrect3);
                        a = new Arc(new Vector2(pr3e.X, pr4s.Y), filletradius, 90, 180);
                        if (filletradius2 < 0)
                        {

                            a = new Arc(new Vector2(pr3e.X + filletradius2, pr4s.Y - filletradius2), filletradius2, 90, 180);

                        }
                        rectEnts.Add(a);
                        Line lrect4 = new Line(pr4s, pr4e);
                        rectEnts.Add(lrect4);
                        a = new Arc(new Vector2(pr1s.X, pr4e.Y), filletradius, 180, 270);
                        if (filletradius2 < 0)
                        {
                            a = new Arc(new Vector2(pr1s.X + filletradius2, pr4e.Y + filletradius2), filletradius2, 180, 270);
                        }
                        rectEnts.Add(a);

                        dxfReaderNETControl1.ShowRubberBandEntities(rectEnts, Vector2.Zero, m_RubberBandColor, m_RubberBandType);

                    }
                    else
                    {
                        dxfReaderNETControl1.ShowRubberBandBox(p1, p2, m_RubberBandColor, m_RubberBandType);
                    }


                    toolStripStatusLabelInfo.Text = "Start point: x: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p1.X) + " y: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p1.Y) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p2.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p2.Y - p1.Y);
                    break;
                case FunctionsEnum.SetLimits2:
                case FunctionsEnum.Connect2:
                case FunctionsEnum.ZoomWindow2:
                case FunctionsEnum.Image2:
                case FunctionsEnum.DrawImage2:
                case FunctionsEnum.MoveEntitiesRubber2:
                case FunctionsEnum.PlotWindow2:
                case FunctionsEnum.GetEntities2:
                case FunctionsEnum.HatchRecangle2:
                case FunctionsEnum.GradientHatchRectangle2:

                case FunctionsEnum.ExplodeSplineRect2:
                case FunctionsEnum.ExplodePoly2:
                case FunctionsEnum.ExplodeInsert2:
                    dxfReaderNETControl1.ShowRubberBandBox(p1, p);
                    toolStripStatusLabelInfo.Text = "Start point: x: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p1.X) + " y: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p1.Y) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p1.Y);
                    break;


                case FunctionsEnum.Distance2:

                    dxfReaderNETControl1.ShowRubberBandLine(p1, p);
                    toolStripStatusLabelInfo.Text = "Distance: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p));
                    break;
                case FunctionsEnum.ArrayPolar:
                    p1 = p;

                    double stepAng = 360 / (double)m_PolarArrayItems;
                    //double radius = Vector2.Distance(p2, p1);
                    List<EntityObject> arrayPaEnts = new List<EntityObject>();
                    for (int k = 0; k < m_PolarArrayItems; k++)
                    {

                        foreach (EntityObject entPA in dxfReaderNETControl1.DXF.SelectedEntities)
                        {
                            EntityObject newEnt = (EntityObject)entPA.Clone();
                            dxfReaderNETControl1.DXF.ModifyEntity(ref newEnt, p1, null, 1, stepAng * k);

                            arrayPaEnts.Add(newEnt);

                        }

                    }

                    dxfReaderNETControl1.ShowRubberBandEntities(arrayPaEnts, Vector2.Zero);
                    break;
                case FunctionsEnum.Array2:

                    List<EntityObject> arrayEnts = new List<EntityObject>();



                    //double spacingX = Math.Abs(p.X - p1.X);
                    //double spacingY = Math.Abs(p.Y - p1.Y);

                    double spacingX = p.X - p1.X;
                    double spacingY = p.Y - p1.Y;



                    Vector2 displacement = Vector2.Zero;
                    for (int k = 0; k < m_ArrayRows; k++)
                    {
                        for (int j = 0; j < m_ArrayColumns; j++)
                        {

                            foreach (EntityObject entA in dxfReaderNETControl1.DXF.SelectedEntities)
                            {
                                EntityObject newEnt = (EntityObject)entA.Clone();
                                dxfReaderNETControl1.DXF.ModifyEntity(ref newEnt, Vector2.Zero, displacement);
                                arrayEnts.Add(newEnt);

                            }
                            displacement.X += spacingX;
                        }
                        displacement.Y += spacingY;
                        displacement.X = 0;
                    }




                    dxfReaderNETControl1.ShowRubberBandEntities(arrayEnts, Vector2.Zero);

                    break;



                case FunctionsEnum.Line2:
                case FunctionsEnum.Trace2:
                    dxfReaderNETControl1.ShowRubberBandLine(p1, p, m_RubberBandColor, m_RubberBandType);
                    toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p)) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p1.Y);
                    if (CurrentFunction == FunctionsEnum.Line2)
                    {
                        double angXY = Vector2.Angle(p1, p);
                        toolStripStatusLabelInfo.Text += " Angle: " + dxfReaderNETControl1.DXF.ToFormattedAngle(angXY);
                    }
                    break;

                case FunctionsEnum.CopyEntities2:
                case FunctionsEnum.DrawLine2:
                case FunctionsEnum.Arc2:
                case FunctionsEnum.ArcCenterPStartPEnd2:
                case FunctionsEnum.DrawArc2:

                case FunctionsEnum.Circle3p2:
                case FunctionsEnum.AlignedDimension2:
                case FunctionsEnum.LinearDimension2:

                    dxfReaderNETControl1.ShowRubberBandLine(p1, p);
                    toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p)) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p1.Y);
                    if (CurrentFunction == FunctionsEnum.Line2)
                    {
                        double angXY = Vector2.Angle(p1, p);
                        toolStripStatusLabelInfo.Text += " Angle: " + dxfReaderNETControl1.DXF.ToFormattedAngle(angXY);
                    }
                    break;

                case FunctionsEnum.ScaleEntities2:


                    m_scale = Vector2.Distance(p1, p) / 100;
                    List<EntityObject> scaleEnts = new List<EntityObject>();
                    foreach (EntityObject entity in dxfReaderNETControl1.DXF.SelectedEntities)
                    {
                        scaleEnts.Add((EntityObject)entity.Clone());
                    }

                    dxfReaderNETControl1.DXF.ModifyEntities(scaleEnts, p1, Vector2.Zero, m_scale, 0);

                    dxfReaderNETControl1.ShowRubberBandEntities(scaleEnts, Vector2.Zero);
                    toolStripStatusLabelInfo.Text = "Scale: " + dxfReaderNETControl1.DXF.ToFormattedUnit(m_scale);
                    break;

                case FunctionsEnum.RotateEntities2:
                    double angleRad = Vector2.Angle(p1, p);
                    m_rotation = angleRad * MathHelper.RadToDeg;
                    List<EntityObject> rotEnts = new List<EntityObject>();
                    foreach (EntityObject entity in dxfReaderNETControl1.DXF.SelectedEntities)
                    {
                        rotEnts.Add((EntityObject)entity.Clone());
                    }
                    dxfReaderNETControl1.DXF.ModifyEntities(rotEnts, p1, Vector2.Zero, 1, m_rotation);

                    dxfReaderNETControl1.ShowRubberBandEntities(rotEnts, Vector2.Zero);
                    toolStripStatusLabelInfo.Text = "Angle: " + dxfReaderNETControl1.DXF.ToFormattedAngle(angleRad);

                    break;

                case FunctionsEnum.MoveEntities2:

                    //dxfReaderNETControl1.ShowRubberBandEntities(dxfReaderNETControl1.DXF.SelectedEntities, p - p1, m_RubberBandColor, m_RubberBandType);
                    dxfReaderNETControl1.ShowRubberBandEntities(dxfReaderNETControl1.DXF.SelectedEntities, p - p1, null, m_RubberBandType);

                    break;
                case FunctionsEnum.Solid2:

                    dxfReaderNETControl1.ShowRubberBandLine(p1, p, m_RubberBandColor, m_RubberBandType, true);
                    toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p)) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p1.Y);
                    break;
                case FunctionsEnum.Solid3:

                    dxfReaderNETControl1.ShowRubberBandLine(p2, p, m_RubberBandColor, m_RubberBandType, true);
                    toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p2, p)) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p2.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p2.Y);
                    break;
                case FunctionsEnum.Solid4:

                    dxfReaderNETControl1.ShowRubberBandLine(p3, p, m_RubberBandColor, m_RubberBandType, true);
                    toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p3, p)) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p3.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p3.Y);
                    break;

                case FunctionsEnum.DrawCircle2:

                case FunctionsEnum.Circle2:

                    dxfReaderNETControl1.ShowRubberBandCircle(p1, Vector2.Distance(p1, p), m_RubberBandColor, m_RubberBandType);
                    //dxfReaderNETControl1.ShowRubberBandLine(p1, p, Color.Yellow, RubberBandType.Solid);
                    toolStripStatusLabelInfo.Text = "Radius: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p));
                    break;


                case FunctionsEnum.Insert:
                    List<EntityObject> blockEntities = new List<EntityObject>();
                    foreach (EntityObject entity in dxfReaderNETControl1.DXF.Blocks[m_BlockName].Entities)
                    {

                        blockEntities.Add((EntityObject)entity.Clone());
                        // dxfReaderNETControl1.DXF.ModifyEntities(blockEntities, dxfReaderNETControl1.DXF.Blocks[m_BlockName].Origin.ToVector2(), Vector2.Zero,  double.Parse(m_BlockScale , System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_BlockRotation, System.Globalization.CultureInfo.CurrentCulture));
                    }
                    dxfReaderNETControl1.ShowRubberBandEntities(blockEntities, p - dxfReaderNETControl1.DXF.Blocks[m_BlockName].Origin.ToVector2());

                    break;

                case FunctionsEnum.MoveEntitiesRubber3:

                    dxfReaderNETControl1.ShowRubberBandEntities(dxfReaderNETControl1.DXF.SelectedEntities, p - p2, m_RubberBandColor, m_RubberBandType);

                    break;
                case FunctionsEnum.MoveEnt2:

                    switch (SelectedEntity.Type)
                    {
                        case EntityType.Line:
                            dxfReaderNETControl1.ShowRubberBandLine(((Line)SelectedEntity).StartPoint.ToVector2() + p - p1, ((Line)SelectedEntity).EndPoint.ToVector2() + p - p1);

                            break;
                        case EntityType.Arc:
                            dxfReaderNETControl1.ShowRubberBandArc(((Arc)SelectedEntity).Center.ToVector2() + p - p1, ((Arc)SelectedEntity).Radius, ((Arc)SelectedEntity).StartAngle, ((Arc)SelectedEntity).EndAngle);
                            break;
                        case EntityType.Circle:
                            dxfReaderNETControl1.ShowRubberBandCircle(((Circle)SelectedEntity).Center.ToVector2() + p - p1, ((Circle)SelectedEntity).Radius);
                            break;
                        case EntityType.LightWeightPolyline:
                            vertexes.Clear();
                            foreach (LwPolylineVertex v in ((LwPolyline)SelectedEntity).Vertexes)
                            {
                                vertexes.Add(new Vector2(v.Position.X, v.Position.Y) + p - p1);
                            }
                            dxfReaderNETControl1.ShowRubberBandPolygon(vertexes, false);
                            break;

                        case EntityType.Polyline:
                            vertexes.Clear();
                            foreach (PolylineVertex v in ((Polyline)SelectedEntity).Vertexes)
                            {
                                vertexes.Add(new Vector2(v.Position.X, v.Position.Y) + p - p1);
                            }
                            dxfReaderNETControl1.ShowRubberBandPolygon(vertexes, false);
                            break;


                    }


                    break;
                case FunctionsEnum.Polygon2:
                    vertexes.Clear();
                    stepAng = 360 / (double)PolygonSides * MathHelper.DegToRad;

                    double Radius = Vector2.Distance(p, p1);
                    double Rotation = Vector2.Angle(p, p1);
                    if (PolygonSides % 2 != 0)
                    {
                        Rotation += stepAng / 2;
                    }
                    for (double k = 0; k < PolygonSides; k++)
                    {

                        vertexes.Add(new Vector2(p1.X + Radius * Math.Cos(stepAng * k + Rotation), p1.Y + Radius * Math.Sin(stepAng * k + Rotation)));
                    }
                    dxfReaderNETControl1.ShowRubberBandPolygon(vertexes, true, m_RubberBandColor, m_RubberBandType);

                    break;
                case FunctionsEnum.Spline:


                    //if (vertexes.Count == 1 || vertexes.Count == 2)
                    //{
                    //    dxfReaderNETControl1.ShowRubberBandLine(vertexes[vertexes.Count - 1], p, null, RubberBandType.Dashed, true);

                    //}
                    if (vertexes.Count > 2)
                    {

                        List<SplineVertex> splinevertexes = new List<SplineVertex>();
                        foreach (Vector2 v in vertexes)
                        {
                            SplineVertex splinevertex = new SplineVertex(v.X, v.Y, dxfReaderNETControl1.DXF.CurrentElevation);

                            splinevertexes.Add(splinevertex);
                        }
                        splinevertexes.Add(new SplineVertex(p.X, p.Y, dxfReaderNETControl1.DXF.CurrentElevation));

                        Spline mySpline = new Spline(splinevertexes);


                        List<Vector2> vertexes2 = new List<Vector2>();
                        vertexes2.Clear();

                        foreach (PolylineVertex v in mySpline.ToPolyline(50).Vertexes)
                        {

                            vertexes2.Add(new Vector2(v.Position.X, v.Position.Y));

                        }


                        dxfReaderNETControl1.ShowRubberBandPolygon(vertexes2, false);




                    }

                    break;
                case FunctionsEnum.Circle3p3:

                    Vector2 CenterPoint = MathHelper.CircleCenterFrom3Points(p1, p2, p);
                    double radius = Vector2.Distance(CenterPoint, p2);

                    dxfReaderNETControl1.ShowRubberBandCircle(CenterPoint, radius, m_RubberBandColor, m_RubberBandType);

                    toolStripStatusLabelInfo.Text = "Radius: " + dxfReaderNETControl1.DXF.ToFormattedUnit(radius);
                    break;
                case FunctionsEnum.Ray2:

                    double m = Vector2.Angle(p1, p);
                    p2 = new Vector2(p1.X + VideoSize * Math.Cos(m), p1.Y + VideoSize * Math.Sin(m));

                    dxfReaderNETControl1.ShowRubberBandLine(p1, p2);
                    toolStripStatusLabelInfo.Text = "Angle in XY Plane: " + dxfReaderNETControl1.DXF.ToFormattedAngle(m);
                    break;
                case FunctionsEnum.RotateAxis2:
                    m = Vector2.Angle(p1, p);
                    dxfReaderNETControl1.ShowRubberBandLine(p1, p);
                    toolStripStatusLabelInfo.Text = "Angle in XY Plane: " + dxfReaderNETControl1.DXF.ToFormattedAngle(m);

                    break;
                case FunctionsEnum.Xline2:

                    m = Vector2.Angle(p1, p);
                    p2 = new Vector2(p1.X + VideoSize * Math.Cos(m), p1.Y + VideoSize * Math.Sin(m));
                    p3 = new Vector2(p1.X + VideoSize * Math.Cos(m + MathHelper.PI), p1.Y + VideoSize * Math.Sin(m + MathHelper.PI));

                    //dxfReaderNETControl1.ShowRubberBandLine(p1, p2);
                    //dxfReaderNETControl1.ShowRubberBandLine(p1, p3);
                    dxfReaderNETControl1.ShowRubberBandLine(p2, p3);


                    toolStripStatusLabelInfo.Text = "Angle in XY Plane: " + dxfReaderNETControl1.DXF.ToFormattedAngle(m);
                    break;

                case FunctionsEnum.Ellipse2:

                    dxfReaderNETControl1.ShowRubberBandLine(p1, p, m_RubberBandColor, RubberBandType.Dashed, true);
                    toolStripStatusLabelInfo.Text = "Length: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p)) + " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X - p1.X) + " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y - p1.Y);
                    break;

                case FunctionsEnum.Ellipse3:

                    //////////////////////////////////////////////////////

                    vertexes.Clear();
                    int precision = 100;
                    Vector2 center = Vector2.MidPoint(p1, p2);
                    double beta = Vector2.Angle(p1, p2);
                    double majorAxis = Vector2.Distance(p1, p2);
                    double minorAxis = Vector2.Distance(center, p) * 2;
                    double sinbeta = Math.Sin(beta);
                    double cosbeta = Math.Cos(beta);
                    StatusLabel.Text = "Select other axis end point - Major axis: " + dxfReaderNETControl1.DXF.ToFormattedUnit(majorAxis) + " Minor axis: " + dxfReaderNETControl1.DXF.ToFormattedUnit(minorAxis);
                    double delta = MathHelper.TwoPI / precision;
                    for (int i = 0; i < precision; i++)
                    {
                        double angle = delta * i;
                        double sinalpha = Math.Sin(angle);
                        double cosalpha = Math.Cos(angle);

                        double pointX = 0.5 * (majorAxis * cosalpha * cosbeta - minorAxis * sinalpha * sinbeta);
                        double pointY = 0.5 * (majorAxis * cosalpha * sinbeta + minorAxis * sinalpha * cosbeta);

                        vertexes.Add(new Vector2(pointX, pointY) + center);
                    }

                    dxfReaderNETControl1.ShowRubberBandPolygon(vertexes, true, m_RubberBandColor, m_RubberBandType);
                    break;


                case FunctionsEnum.Circle2p2:


                    dxfReaderNETControl1.ShowRubberBandCircle(Vector2.MidPoint(p1, p), Vector2.Distance(p1, p) / 2, m_RubberBandColor, m_RubberBandType);
                    toolStripStatusLabelInfo.Text = "Radius: " + dxfReaderNETControl1.DXF.ToFormattedUnit(Vector2.Distance(p1, p) / 2);
                    break;

                case FunctionsEnum.DrawArc3:
                case FunctionsEnum.Arc3:
                case FunctionsEnum.ArcCenterPStartPEnd3:
                    dxfReaderNETControl1.ShowRubberBandArc(p1, Vector2.Distance(p1, p2), Vector2.Angle(p1, p2) * MathHelper.RadToDeg, Vector2.Angle(p1, p) * MathHelper.RadToDeg);
                    break;


                case FunctionsEnum.ArcStartMiddleEnd3:
                    CenterPoint = MathHelper.CircleCenterFrom3Points(p1, p2, p);
                    double StartAngle;
                    double EndAngle;
                    MathHelper.ArcAnglesFrom3Points(p1, p2, p, out StartAngle, out EndAngle);
                    radius = Vector2.Distance(CenterPoint, p2);

                    dxfReaderNETControl1.ShowRubberBandArc(CenterPoint, radius, StartAngle, EndAngle);



                    break;

                case FunctionsEnum.ArcStartEndMiddle3:
                    CenterPoint = MathHelper.CircleCenterFrom3Points(p1, p, p2);
                    MathHelper.ArcAnglesFrom3Points(p1, p, p2, out StartAngle, out EndAngle);
                    radius = Vector2.Distance(CenterPoint, p);
                    dxfReaderNETControl1.ShowRubberBandArc(CenterPoint, radius, StartAngle, EndAngle);



                    break;
            }
        }

        private void ribbonButton7_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomIn();
        }

        private void ribbonButton8_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomOut();
        }

        private void ribbonButton9_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.ZoomWindow1;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            StatusLabel.Text = "Select start point of the window";
        }

        private void ribbonButton11_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomPrevious();
        }

        private void ribbonButton12_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomNext();
        }

        private void dxfReaderNETControl1_MouseUp(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Middle)
            {
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                return;
            }
            if (leftPressed)
            {
                p1 = pstart;

                CurrentFunction = FunctionsEnum.GetEntities2;
                setPoint();
                leftPressed = false;
            }

            pNoSnap = dxfReaderNETControl1.CoordsToWorld(e.X, e.Y);
            if (e.Button == MouseButtons.Left)
            {

                if (dxfReaderNETControl1.ObjectOsnapMode != ObjectOsnapTypeFlags.None || dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode != 0)
                {
                    if (CurrentFunction != FunctionsEnum.Trim2 && CurrentFunction != FunctionsEnum.Extend2 && CurrentFunction != FunctionsEnum.Fillet2 && CurrentFunction != FunctionsEnum.EntityProperties)
                    {
                        p = dxfReaderNETControl1.CurrentWCSpoint;
                    }
                }

                setPoint();

            }
            else
            {

                //StatusLabel.Text = "";
                switch (CurrentFunction)
                {

                    case FunctionsEnum.GradientHatchBoundaries:
                        contextMenuStrip1.Visible = false;
                        InitStatus();
                        LwPolyline lw = new LwPolyline();
                        List<LwPolylineVertex> lwvertexes = new List<LwPolylineVertex>();
                        foreach (Vector2 v in vertexes)
                        {
                            LwPolylineVertex lwvertex = new LwPolylineVertex(v.X, v.Y);

                            lwvertexes.Add(lwvertex);
                        }
                        lw.Vertexes = lwvertexes;
                        lw.StartWidth = 0;
                        lw.EndWidth = 0;
                        lw.IsClosed = true;
                        Boundary.Add(lw);
                        m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), Boundary, BoundaryOutermost, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);

                        Boundary.Clear();
                        BoundaryOutermost.Clear();
                        vertexes.Clear();
                        break;
                    case FunctionsEnum.HatchBoundaries:
                        contextMenuStrip1.Visible = false;
                        InitStatus();
                        lw = new LwPolyline();
                        lwvertexes = new List<LwPolylineVertex>();
                        foreach (Vector2 v in vertexes)
                        {
                            LwPolylineVertex lwvertex = new LwPolylineVertex(v.X, v.Y);

                            lwvertexes.Add(lwvertex);
                        }
                        lw.Vertexes = lwvertexes;
                        lw.StartWidth = 0;
                        lw.EndWidth = 0;
                        lw.IsClosed = true;
                        Boundary.Add(lw);
                        m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, Boundary, BoundaryOutermost, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);
                        Boundary.Clear();
                        BoundaryOutermost.Clear();
                        vertexes.Clear();
                        break;


                    case FunctionsEnum.GradientHatchOutermost:
                        contextMenuStrip1.Visible = false;
                        InitStatus();
                        m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), Boundary, BoundaryOutermost, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);

                        if (m_GradientHatchTransparency != "0")
                        {
                            if (m_LastAddedEntity != null)
                            {
                                Hatch myHatch = dxfReaderNETControl1.DXF.Hatches[dxfReaderNETControl1.DXF.Hatches.Count - 1];
                                myHatch.Transparency = new Transparency(short.Parse(m_GradientHatchTransparency));
                            }
                        }

                        Boundary.Clear();
                        BoundaryOutermost.Clear();
                        break;

                    case FunctionsEnum.GradientHatch:
                        contextMenuStrip1.Visible = false;
                        if (MessageBox.Show("Do you want to select hollow parts?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            CurrentFunction = FunctionsEnum.GradientHatchOutermost;
                        }
                        else
                        {
                            InitStatus();
                            m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), Boundary, BoundaryOutermost, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);

                            if (m_GradientHatchTransparency != "0")
                            {
                                if (m_LastAddedEntity != null)
                                {
                                    Hatch myHatch = dxfReaderNETControl1.DXF.Hatches[dxfReaderNETControl1.DXF.Hatches.Count - 1];
                                    myHatch.Transparency = new Transparency(short.Parse(m_GradientHatchTransparency));
                                }
                            }

                            Boundary.Clear();
                            BoundaryOutermost.Clear();
                            break;
                        }
                        break;

                    case FunctionsEnum.HatchOutermost:
                        contextMenuStrip1.Visible = false;
                        InitStatus();
                        m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, Boundary, BoundaryOutermost, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);



                        Boundary.Clear();
                        BoundaryOutermost.Clear();
                        break;

                    case FunctionsEnum.Hatch:
                        contextMenuStrip1.Visible = false;
                        if (MessageBox.Show("Do you want to select hollow parts?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                        {
                            CurrentFunction = FunctionsEnum.HatchOutermost;
                            StatusLabel.Text = "Select entities with left mouse click. Right mouse clic to finish.";
                        }
                        else
                        {
                            InitStatus();
                            m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, Boundary, BoundaryOutermost, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);



                            Boundary.Clear();
                            BoundaryOutermost.Clear();
                            break;
                        }
                        break;

                    case FunctionsEnum.GetEntities:
                        //StatusLabel.Text = "";
                        //dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        //CurrentFunction = FunctionsEnum.None;

                        break;
                    case FunctionsEnum.Lines:
                    case FunctionsEnum.Spline:
                    case FunctionsEnum.LwPolyline:
                    case FunctionsEnum.Polyline:
                    case FunctionsEnum.Mline:
                        break;
                    case FunctionsEnum.PolylineLenght:


                        CurrentFunction = FunctionsEnum.None;
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        bool isClosed = MessageBox.Show("Close?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

                        if (isClosed)
                        {
                            StatusLabel.Text = "Lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit((MathHelper.PolygonLenght(vertexes, isClosed))) + " Area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(MathHelper.PolygonArea(vertexes));

                        }
                        else
                        {
                            StatusLabel.Text = "Lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit((MathHelper.PolygonLenght(vertexes, isClosed)));

                        }
                        vertexes.Clear();
                        break;

                    case FunctionsEnum.Area:
                        CurrentFunction = FunctionsEnum.None;
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        contextMenuStrip1.Visible = false;
                        StatusLabel.Text = "Area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(MathHelper.PolygonArea(vertexes)) + " Lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit((MathHelper.PolygonLenght(vertexes, true)));
                        vertexes.Clear();
                        break;
                    case FunctionsEnum.Solid4:
                        CurrentFunction = FunctionsEnum.None;
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        contextMenuStrip1.Visible = false;
                        p4 = p3;

                        m_LastAddedEntity = dxfReaderNETControl1.AddSolid(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p4.X, p4.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p3.X, p3.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);
                        break;
                    case FunctionsEnum.DrawPolygon:
                        contextMenuStrip1.Visible = false;
                        CurrentFunction = FunctionsEnum.None;
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        dxfReaderNETControl1.DrawPolygon(DrawPen, vertexes, ribbonButtonDrawMethodsFill.Checked, ribbonButtonDrawMethodsStore.Checked);
                        vertexes.Clear();
                        break;

                }
            }

            if (!addedMultipleEntities)
            {
                if (m_LastAddedEntity != null)
                {
                    if (m_LastAddedEntity.Type != EntityType.Hatch)
                    {
                        dxfReaderNETControl1.DrawEntity(m_LastAddedEntity);
                    }
                    else
                    {
                        dxfReaderNETControl1.Refresh();
                    }


                }
            }
            else
            {
                dxfReaderNETControl1.Refresh();
                addedMultipleEntities = false;

            }

        }

        private void ribbonColorChooserForeColor_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = dxfReaderNETControl1.ForeColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.ForeColor = colorDialog1.Color;
                ribbonColorChooserForeColor.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserBackColor_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = dxfReaderNETControl1.BackColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.BackColor = colorDialog1.Color;

                ribbonColorChooserBackColor.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserAxes_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = dxfReaderNETControl1.AxesColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.AxesColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserAxes.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserAxisX_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = dxfReaderNETControl1.AxisXColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.AxisXColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserAxisX.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserAxisY_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = dxfReaderNETControl1.AxisYColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.AxisYColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserAxisY.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserAxisZ_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = dxfReaderNETControl1.AxisZColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.AxisZColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserAxisZ.Color = colorDialog1.Color;
            }

        }

        private void ribbonColorChooserGrid_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = dxfReaderNETControl1.GridColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.GridColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserGrid.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserHighlight_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = dxfReaderNETControl1.HighlightColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.HighlightColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserHighlight.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserHighlightMarker_Click(object sender, EventArgs e)
        {


            colorDialog1.Color = dxfReaderNETControl1.HighlightMarkerColor;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.HighlightMarkerColor = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserHighlightMarker.Color = colorDialog1.Color;
            }
        }

        private void ribbonColorChooserHighlightMarker2_Click(object sender, EventArgs e)
        {

            colorDialog1.Color = dxfReaderNETControl1.HighlightMarkerColor2;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.HighlightMarkerColor2 = colorDialog1.Color;
                dxfReaderNETControl1.Refresh();
                ribbonColorChooserHighlightMarker2.Color = colorDialog1.Color;
            }
        }

        private void ribbonButtonLightColorScheme_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.LightColorScheme();
            ribbonColors();
        }

        private void ribbonButtonDefaultColorScheme_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DefaultColorScheme();
            ribbonColors();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    dxfReaderNETControl1.Refresh();
                    break;
                case Keys.F7:
                    dxfReaderNETControl1.ShowGrid = !dxfReaderNETControl1.ShowGrid;
                    ShowStatusLabels();
                    dxfReaderNETControl1.Refresh();
                    break;
                case Keys.F8:
                    if (dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode == 0)
                    {
                        dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode = 1;
                    }
                    else
                    {
                        dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode = 0;
                    }

                    ShowStatusLabels();

                    break;
                case Keys.F9:
                    dxfReaderNETControl1.DXF.VPorts["*Active"].SnapMode = !dxfReaderNETControl1.DXF.VPorts["*Active"].SnapMode;
                    ShowStatusLabels();

                    break;
                case Keys.Escape:
                    switch (CurrentFunction)
                    {
                        case FunctionsEnum.Trim2:
                            m_entTrimBoundaries.Clear();
                            dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                            StatusLabel.Text = "";
                            CurrentFunction = FunctionsEnum.None;
                            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                            dxfReaderNETControl1.Refresh();
                            break;
                        case FunctionsEnum.Trim1:
                            StatusLabel.Text = "Select objects to trim. ESC or right click to end.";
                            CurrentFunction = FunctionsEnum.Trim2;
                            break;
                        default:
                            CurrentFunction = FunctionsEnum.None;

                            CheckContinuousSelection();
                            StatusLabel.Text = "";
                            if (CurrentFunction != FunctionsEnum.Orbit3D)
                                dxfReaderNETControl1.Refresh();
                            break;
                    }

                    break;
                case Keys.Delete:
                    if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
                        ribbonButtonModifyDeleteSelected_Click(sender, e);
                    break;
                case Keys.A:
                    if (ModifierKeys == Keys.Control)
                    {
                        ribbonButtonModifySelectAll_Click(sender, e);
                    }
                    break;
                case Keys.Z:
                    if (ModifierKeys == Keys.Control)
                    {
                        UnDo();
                    }
                    break;
                case Keys.Y:
                    if (ModifierKeys == Keys.Control)
                    {
                        ReDo();
                    }
                    break;
                case Keys.S:
                    if (ModifierKeys == Keys.Control)
                    {
                        ribbonOrbMenuItem3_Click(sender, e);
                    }
                    break;

                case Keys.O:
                    if (ModifierKeys == Keys.Control)
                    {
                        ribbonOrbMenuItemOpen_Click(sender, e);
                    }
                    break;
                case Keys.NumPad9:
                case Keys.D9:
                    if (ModifierKeys == Keys.Control)
                    {
                        //labelCommands.Visible = !labelCommands.Visible;

                        //ribbonButtonCommandLine.Checked = labelCommands.Visible;
                    }
                    break;


                case Keys.M:
                    if (ModifierKeys == Keys.Control)
                    {
                        if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
                        {
                            ribbonButtonModifyCopyMove_Click(sender, e);
                        }
                    }
                    break;
                case Keys.C:
                    if (ModifierKeys == Keys.Control)
                    {
                        if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
                        {
                            ribbonButtonModidyCopyCopy_Click(sender, e);
                        }
                    }
                    break;
                case Keys.R:
                    if (ModifierKeys == Keys.Control)
                    {
                        if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
                        {
                            ribbonButtonModifyCopyRotate_Click(sender, e);
                        }
                    }
                    break;

            }




        }

        private void ribbonOrbMenuItem1_Click(object sender, EventArgs e)
        {

            if (DiscardChanges())
            {
                ErrorLabel.Text = "";
                dxfReaderNETControl1.NewDrawing();


                InitDrawing();

                //dxfReaderNETControl1.UnRegisterComponent();
            }

        }

        private bool DiscardChanges()
        {
            bool ret = true;
            if (dxfReaderNETControl1.DXF != null)
            {
                if (dxfReaderNETControl1.DXF.Modified)
                {
                    if (MessageBox.Show("The current drawing has been modified. Do you want to discard changes?", "DXFReader.NET Demo Program", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                    {
                        ret = false;
                    }
                }
            }
            return ret;
        }

        private void ribbonOrbOptionButtonExit_Click(object sender, EventArgs e)
        {
            if (DiscardChanges())
            {
                SaveRegistry();
                System.Environment.Exit(0);
            }
        }

        private void ribbonOrbMenuItemOpen_Click(object sender, EventArgs e)
        {
            if (DiscardChanges())
            {
                StatusLabel.Text = "";
                ErrorLabel.Text = "";
                openFileDialog1.DefaultExt = "dxf";
                openFileDialog1.Filter = "DXF|*.dxf|All files (*.*)|*.*";
                openFileDialog1.FileName = "";
                openFileDialog1.InitialDirectory = CurrentLoadDXFPath;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ReadDXF(openFileDialog1.FileName);

                }
            }
        }
        private void newRecent_Click(object sender, System.EventArgs e)
        {
            // Add event handler code here.
            // System.Diagnostics.Debugger.Break(); //stop
            if (DiscardChanges())
            {
                RibbonOrbRecentItem se = (RibbonOrbRecentItem)sender;

                ReadDXF(se.Value);
            }
        }
        private void AddMRU(string file_name)
        {
            if (FileInfos.Contains(file_name))
            {
                FileInfos.Remove(file_name);
            }
            if (FileInfos.Count >= maxMRUnumber)
            {
                FileInfos.Remove(FileInfos[maxMRUnumber - 1]);
            }
            FileInfos.Insert(0, file_name);

            ribbon1.OrbDropDown.RecentItems.Clear();
            int i = 0;
            foreach (string file_info in FileInfos)
            {
                if (i < maxMRUnumber)
                {
                    RibbonOrbRecentItem newRecent = new RibbonOrbRecentItem();
                    string mruitem = file_info;
                    if (mruitem.Length > 60)
                    {
                        mruitem = "[" + file_info.Substring(0, 25) + "...] " + Path.GetFileName(file_info);
                    }
                    newRecent.Text = mruitem;
                    newRecent.Value = file_info;
                    newRecent.Click += new EventHandler(newRecent_Click);
                    ribbon1.OrbDropDown.RecentItems.Add(newRecent);

                }
                i++;
            }

        }

        private void ribbonOrbMenuItem4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "dxf";
            saveFileDialog1.Filter = "DXF|*.dxf";
            saveFileDialog1.FileName = "";

            saveFileDialog1.Filter = "AutoCAD R10 DXF|*.dxf"; //1
            saveFileDialog1.Filter += "|AutoCAD R11 and R12 DXF|*.dxf"; //2
            saveFileDialog1.Filter += "|AutoCAD R13 DXF|*.dxf"; //3
            saveFileDialog1.Filter += "|AutoCAD R14 DXF|*.dxf"; //4
            saveFileDialog1.Filter += "|AutoCAD 2000 DXF|*.dxf"; //5
            saveFileDialog1.Filter += "|AutoCAD 2004 DXF|*.dxf"; //6
            saveFileDialog1.Filter += "|AutoCAD 2007 DXF|*.dxf"; //7
            saveFileDialog1.Filter += "|AutoCAD 2010 DXF|*.dxf"; //8
            saveFileDialog1.Filter += "|AutoCAD 2013 DXF|*.dxf"; //9
            saveFileDialog1.Filter += "|AutoCAD 2018 DXF|*.dxf"; //10

            saveFileDialog1.Filter += "|AutoCAD R10 binary DXF|*.dxf"; //11
            saveFileDialog1.Filter += "|AutoCAD R11 and R12 binary DXF|*.dxf"; //12
            saveFileDialog1.Filter += "|AutoCAD R13 binary DXF|*.dxf"; //13
            saveFileDialog1.Filter += "|AutoCAD R14 binary DXF|*.dxf"; //14
            saveFileDialog1.Filter += "|AutoCAD 2000 binary DXF|*.dxf"; //15
            saveFileDialog1.Filter += "|AutoCAD 2004 binary DXF|*.dxf"; //16
            saveFileDialog1.Filter += "|AutoCAD 2007 binary DXF|*.dxf"; //17
            saveFileDialog1.Filter += "|AutoCAD 2010 binary DXF|*.dxf"; //18
            saveFileDialog1.Filter += "|AutoCAD 2013 binary DXF|*.dxf"; //19
            saveFileDialog1.Filter += "|AutoCAD 2018 binary DXF|*.dxf"; //20

            switch (dxfReaderNETControl1.DXF.DrawingVariables.AcadVer)
            {
                case DXFReaderNET.Header.DxfVersion.AutoCad10:
                    saveFileDialog1.FilterIndex = 1;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad12:
                    saveFileDialog1.FilterIndex = 2;
                    break;

                case DXFReaderNET.Header.DxfVersion.AutoCad13:
                    saveFileDialog1.FilterIndex = 3;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad14:

                    saveFileDialog1.FilterIndex = 4;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad2000:
                    saveFileDialog1.FilterIndex = 5;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad2004:

                    saveFileDialog1.FilterIndex = 6;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad2007:
                    saveFileDialog1.FilterIndex = 7;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad2010:

                    saveFileDialog1.FilterIndex = 8;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad2013:

                    saveFileDialog1.FilterIndex = 9;
                    break;
                case DXFReaderNET.Header.DxfVersion.AutoCad2018:
                    saveFileDialog1.FilterIndex = 10;
                    break;

            }


            if (dxfReaderNETControl1.DXF.IsBinary) saveFileDialog1.FilterIndex += 10; ;

            saveFileDialog1.InitialDirectory = CurrentSaveDXFPath;
            if (dxfReaderNETControl1.FileName == null)
            {
                saveFileDialog1.FileName = "drawing.dxf";
            }
            else
            {
                saveFileDialog1.FileName = Path.GetFileName(dxfReaderNETControl1.FileName);
            }


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DXFReaderNET.Header.DxfVersion dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2013;
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                    case 11:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad10;
                        break;
                    case 2:
                    case 12:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad12;
                        break;
                    case 3:
                    case 13:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad13;
                        break;
                    case 4:
                    case 14:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad14;
                        break;
                    case 5:
                    case 15:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2000;
                        break;
                    case 6:
                    case 16:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2004;
                        break;
                    case 7:
                    case 17:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2007;
                        break;
                    case 8:
                    case 18:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2010;
                        break;
                    case 9:
                    case 19:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2013;
                        break;
                    case 10:
                    case 20:
                        dxfver = DXFReaderNET.Header.DxfVersion.AutoCad2018;
                        break;
                }
                if (saveFileDialog1.FilterIndex > 10) dxfReaderNETControl1.DXF.IsBinary = true;

                ErrorLabel.Text = "";
                dxfReaderNETControl1.WriteDXF(saveFileDialog1.FileName, dxfver, dxfReaderNETControl1.DXF.IsBinary);


                //if (dxfReaderNETControl1.WriteDXF(saveFileDialog1.FileName, dxfver, dxfReaderNETControl1.DXF.IsBinary))
                //{
                //    StatusLabel.Text = "DXF file saved";
                //    ErrorLabel.Text = "";
                //}
                //else
                //{
                //    StatusLabel.Text = "Error in saving DXF file";
                //}


                CurrentSaveDXFPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                AddMRU(saveFileDialog1.FileName);
                this.Text = "DXFReader.NET Component - Demo Program  - " + dxfReaderNETControl1.FileName;
                SaveRegistry();
            }
        }

        private void ribbonOrbMenuItem3_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.FileName != null)
            {
                ErrorLabel.Text = "";
                dxfReaderNETControl1.WriteDXF(dxfReaderNETControl1.FileName);
            }
            else
            {
                ribbonOrbMenuItem4_Click(sender, e);
            }
        }



        private void ribbonOrbMenuItem5_Click(object sender, EventArgs e)
        {
            OnPlotPreview = true;
            if (dxfReaderNETControl1.PlotMode == PlotModeType.Window)
            {
                CurrentFunction = FunctionsEnum.PlotWindow1;
                StatusLabel.Text = "Select start point of the ploting window";
            }
            else
            {
                PlotPreview();
            }
        }

        private void PlotPreview()
        {
            ribbon1.Visible = false;
            toolStripPlotPreview.Visible = true;

            printPreviewControl1.Visible = true;
            splitContainer1.Visible = false;

            printPreviewControl1.Top = toolStripPlotPreview.Top + toolStripPlotPreview.Height;
            printPreviewControl1.Width = dxfReaderNETControl1.Width;
            printPreviewControl1.Left = 0;
            printPreviewControl1.Height = this.ClientSize.Height - toolStripPlotPreview.Height - statusStrip1.Height;

            dxfReaderNETControl1.PlotPreview(printPreviewControl1);
        }

        private EntityObject EntityToPrint = null;
        private void PrintEntityProperties(EntityObject entity)
        {
            EntityToPrint = entity;
            ribbon1.Visible = false;
            toolStripPlotPreview.Visible = true;

            printPreviewControl1.Visible = true;
            splitContainer1.Visible = false;

            printPreviewControl1.Top = toolStripPlotPreview.Top + toolStripPlotPreview.Height;
            printPreviewControl1.Width = dxfReaderNETControl1.Width;
            printPreviewControl1.Left = 0;
            printPreviewControl1.Height = this.ClientSize.Height - toolStripPlotPreview.Height - statusStrip1.Height;

            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();



            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_PrintEntityProperties);

            printPreviewControl1.Document = doc;

            //dxfReaderNETControl1.PlotPreview(printPreviewControl1);
        }
        internal void _PrintEntityProperties(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string stringToPrint = "";
            PrintType = PrintTypeEnum.EntityProperties;
            stringToPrint += "Entity type: " + EntityToPrint.Type.ToString() + "\n\n";
            stringToPrint += "Handle: " + EntityToPrint.Handle;
            stringToPrint += "\n";
            stringToPrint += "Color: " + EntityToPrint.Color.ToString();
            stringToPrint += "\n";
            stringToPrint += "Layer: " + EntityToPrint.Layer.Name;
            stringToPrint += "\n";
            stringToPrint += "LineType: " + EntityToPrint.Linetype.Name;
            stringToPrint += "\n";
            switch (EntityToPrint.Type)
            {

                case EntityType.Arc:
                    Arc a = (Arc)EntityToPrint;

                    stringToPrint += "Start point: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.X) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.Y) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.Z);
                    stringToPrint += "\n";
                    stringToPrint += "End point: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.X) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.Y) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.Z);
                    stringToPrint += "\n";

                    stringToPrint += "Start angle: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedAngle(a.StartAngle * MathHelper.DegToRad);
                    stringToPrint += "\n";
                    stringToPrint += "End angle: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedAngle(a.EndAngle * MathHelper.DegToRad);
                    stringToPrint += "\n";

                    stringToPrint += "Radius: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.Radius);


                    stringToPrint += "Lenght: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(a.Lenght);

                    break;
                case EntityType.Line:
                    Line l = (Line)EntityToPrint;

                    stringToPrint += "Start point: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.X) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.Y) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.Z);
                    stringToPrint += "\n";
                    stringToPrint += "End point: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.X) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.Y) + ";";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.Z);
                    stringToPrint += "\n";
                    stringToPrint += "Lenght: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(l.Lenght);
                    stringToPrint += "\n";
                    stringToPrint += "Angle: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedAngle(Vector2.Angle(l.StartPoint.ToVector2(), l.EndPoint.ToVector2()));

                    break;
                case EntityType.LightWeightPolyline:
                    LwPolyline lw = (LwPolyline)EntityToPrint;

                    stringToPrint += "Vertexes #: ";
                    stringToPrint += lw.Vertexes.Count.ToString();
                    stringToPrint += "\n";
                    if (lw.IsClosed)
                    {
                        stringToPrint += "true";
                    }
                    else
                    {
                        stringToPrint += "false";
                    }
                    stringToPrint += "\n";
                    stringToPrint += "Lenght: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Lenght);
                    stringToPrint += "\n";
                    stringToPrint += "Area ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Area);
                    stringToPrint += "\n";
                    int nv = 0;
                    foreach (LwPolylineVertex v in lw.Vertexes)
                    {
                        stringToPrint += "Vertexes #: " + nv.ToString();
                        stringToPrint += " Position: ";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.X) + ";";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.Y);
                        stringToPrint += " Bulge: ";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Bulge);
                        stringToPrint += "\n";
                        nv++;
                    }

                    break;
                case EntityType.Polyline:
                    Polyline pl = (Polyline)EntityToPrint;

                    stringToPrint += "Vertexes #: ";
                    stringToPrint += pl.Vertexes.Count.ToString();
                    stringToPrint += "\n";
                    stringToPrint += "Closed: ";
                    if (pl.IsClosed)
                    {
                        stringToPrint += "true";
                    }
                    else
                    {
                        stringToPrint += "false";
                    }
                    stringToPrint += "\n";
                    stringToPrint += "Lenght: ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(pl.Lenght);
                    stringToPrint += "\n";
                    stringToPrint += "Area ";
                    stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(pl.Area);
                    stringToPrint += "\n";
                    nv = 0;
                    foreach (PolylineVertex v in pl.Vertexes)
                    {
                        stringToPrint += "Vertexes #: " + nv.ToString();
                        stringToPrint += " Position: ";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.X) + ";";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.Y) + ";";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.Z);
                        stringToPrint += " Bulge: ";
                        stringToPrint += dxfReaderNETControl1.DXF.ToFormattedUnit(v.Bulge);
                        stringToPrint += "\n";
                        nv++;
                    }

                    break;
            }
            e.Graphics.DrawString(stringToPrint, this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);
        }

        private void PrintEntitiesList()
        {

            ribbon1.Visible = false;
            toolStripPlotPreview.Visible = true;

            printPreviewControl1.Visible = true;
            splitContainer1.Visible = false;

            printPreviewControl1.Top = toolStripPlotPreview.Top + toolStripPlotPreview.Height;
            printPreviewControl1.Width = dxfReaderNETControl1.Width;
            printPreviewControl1.Left = 0;
            printPreviewControl1.Height = this.ClientSize.Height - toolStripPlotPreview.Height - statusStrip1.Height;

            System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();
            doc.DefaultPageSettings.Landscape = true;


            doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_PrintEntitiesList);

            printPreviewControl1.Document = doc;
        }

        internal void _PrintEntitiesList(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            SolidBrush BrushGrey = new SolidBrush(Color.FromArgb(250, 250, 250));

            e.Graphics.Clear(Color.White);
            bool threeD = false;
            System.Text.StringBuilder stringToPrint = new System.Text.StringBuilder();

            PrintType = PrintTypeEnum.EntiesList;
            int n = -1;
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Near;
            stringFormat.LineAlignment = StringAlignment.Near;
            float spT = 50;
            float spT2 = 80;
            float[] tabs = { spT, spT + 40, spT, spT2, spT2, spT2, spT2, spT2, spT, spT, spT, spT, spT, spT, spT };
            stringFormat.SetTabStops(0, tabs);

            stringToPrint.Append("#\tType\tHandle\tPoint 1\tPoint 2\tPoint 3\tPoint 4\tCenter\tRadius\tRotation\tAngle 1\tAngle 2\tLenght\tArea\tHei./Offs.\tValue\n");

            var newFont = new Font(this.Font.FontFamily, 6, this.Font.Style);
            float tH = 10F;
            e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.DarkGray, 10F, tH, stringFormat);


            stringToPrint.Clear();

            bool toggle = true;
            foreach (EntityObject EntityToPrint in dxfReaderNETControl1.DXF.Entities)
            {
                n++;
                if (n < 2000)
                {


                    stringToPrint.Append(n.ToString() + " ");
                    stringToPrint.Append("\t");

                    if (EntityToPrint.Type != EntityType.Dimension)
                    {
                        stringToPrint.Append(EntityToPrint.Type.ToString());
                    }
                    else
                    {
                        stringToPrint.Append("Dim." + ((Dimension)EntityToPrint).DimensionType.ToString());


                    }
                    stringToPrint.Append("\t");
                    stringToPrint.Append(" " + EntityToPrint.Handle);
                    stringToPrint.Append("\t");
                    switch (EntityToPrint.Type)
                    {
                        case EntityType.Dimension:
                            switch (((Dimension)EntityToPrint).DimensionType)
                            {
                                case DimensionType.Angular:

                                    Angular2LineDimension dimA = (Angular2LineDimension)(Dimension)EntityToPrint;


                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.StartFirstLine.X) + ";");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.StartFirstLine.Y));

                                    stringToPrint.Append("\t");


                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.EndFirstLine.X) + ";");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.EndFirstLine.Y));
                                    stringToPrint.Append("\t");


                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.StartSecondLine.X) + ";");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.StartSecondLine.Y));
                                    stringToPrint.Append("\t");


                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.EndSecondLine.X) + ";");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.EndSecondLine.Y));

                                    stringToPrint.Append("\t\t\t\t\t\t\t\t");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.Offset));
                                    stringToPrint.Append("\t");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(dimA.Measurement));




                                    break;
                            }
                            break;
                        case EntityType.Text:
                            Text text = (Text)EntityToPrint;


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(text.Position.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(text.Position.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(text.Position.Z));

                            stringToPrint.Append("\t\t\t\t\t\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedAngle(text.Rotation * MathHelper.DegToRad));
                            stringToPrint.Append("\t\t\t\t\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(text.Height));
                            stringToPrint.Append("\t");

                            stringToPrint.Append(text.Value);
                            break;
                        case EntityType.MText:
                            MText mtext = (MText)EntityToPrint;


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(mtext.Position.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(mtext.Position.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(mtext.Position.Z));

                            stringToPrint.Append("\t\t\t\t\t\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedAngle(mtext.Rotation * MathHelper.DegToRad));
                            stringToPrint.Append("\t\t\t\t\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(mtext.Height));
                            stringToPrint.Append("\t");

                            stringToPrint.Append(mtext.Value);
                            break;
                        case EntityType.Point:
                            DXFReaderNET.Entities.Point p = (DXFReaderNET.Entities.Point)EntityToPrint;


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(p.Position.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(p.Position.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Position.Z));



                            break;
                        case EntityType.Solid:
                            Solid s = (Solid)EntityToPrint;


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.FirstVertex.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.FirstVertex.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(s.FirstVertex.Z));
                            stringToPrint.Append("\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.SecondVertex.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.SecondVertex.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(s.SecondVertex.Z));
                            stringToPrint.Append("\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.ThirdVertex.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.ThirdVertex.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(s.ThirdVertex.Z));
                            stringToPrint.Append("\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.FourthVertex.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(s.FourthVertex.Y));

                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(s.FourthVertex.Z));
                            stringToPrint.Append("\t");


                            break;
                        case EntityType.Line:
                            Line l = (Line)EntityToPrint;


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.Z));

                            stringToPrint.Append("\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.Z));
                            stringToPrint.Append("\t\t\t\t\t\t\t\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(l.Lenght));

                            //stringToPrint.Append( " Angle: ";
                            //stringToPrint.Append( dxfReaderNETControl1.DXF.ToFormattedAngle(Vector2.Angle(l.StartPoint.ToVector2(), l.EndPoint.ToVector2()));

                            break;
                        case EntityType.Arc:
                            Arc a = (Arc)EntityToPrint;




                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.Z));
                            stringToPrint.Append("\t");


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.Z));

                            stringToPrint.Append("\t\t\t");


                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.Center.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.Center.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.Center.Z));

                            stringToPrint.Append("\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.Radius));


                            stringToPrint.Append("\t\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedAngle(a.StartAngle * MathHelper.DegToRad));
                            stringToPrint.Append("\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedAngle(a.EndAngle * MathHelper.DegToRad));


                            stringToPrint.Append("\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(a.Lenght));

                            //stringToPrint.Append( " Angle: ";
                            //stringToPrint.Append( dxfReaderNETControl1.DXF.ToFormattedAngle(Vector2.Angle(l.StartPoint.ToVector2(), l.EndPoint.ToVector2()));

                            break;
                        case EntityType.Circle:
                            Circle c = (Circle)EntityToPrint;
                            stringToPrint.Append("\t\t\t\t");

                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(c.Center.X) + ";");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(c.Center.Y));
                            if (threeD) stringToPrint.Append(";" + dxfReaderNETControl1.DXF.ToFormattedUnit(c.Center.Z));

                            stringToPrint.Append("\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(c.Radius));


                            stringToPrint.Append("\t\t\t\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(c.Lenght));
                            stringToPrint.Append("\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(c.Area));


                            break;
                        case EntityType.LightWeightPolyline:
                            LwPolyline lw = (LwPolyline)EntityToPrint;
                            //stringToPrint.Append("Entity type: LWPOLYLINE\n\n");
                            //stringToPrint.Append("Handle: " + EntityToPrint.Handle);
                            //stringToPrint.Append("\n");
                            //stringToPrint.Append("Vertexes #: ");
                            //stringToPrint.Append(lw.Vertexes.Count.ToString());
                            //stringToPrint.Append("\n");
                            //stringToPrint.Append("Lenght: ");
                            //stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Lenght));
                            //stringToPrint.Append("\n");
                            //stringToPrint.Append("Area ");
                            //stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Area));

                            stringToPrint.Append("\t\t\t\t\t\t\t\t\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Lenght));
                            stringToPrint.Append("\t");
                            stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Area));

                            stringToPrint.Append("\n");
                            tH += 10F;
                            if (toggle)
                            {
                                var rect = new RectangleF(10F, tH, 1000, 10f);

                                //Filling a rectangle before drawing the string.

                                e.Graphics.FillRectangle(BrushGrey, rect);
                                toggle = false;
                            }
                            else
                            {
                                toggle = true;
                            }
                            e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                            int nv = 0;
                            foreach (LwPolylineVertex v in lw.Vertexes)
                            {
                                stringToPrint.Clear();
                                stringToPrint.Append("\t\t");
                                stringToPrint.Append("#" + nv.ToString());
                                stringToPrint.Append("\t");
                                stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.X) + ";");
                                stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.Y));
                                //stringToPrint.Append(" Bulge: ");

                                if (!MathHelper.IsZero(v.Bulge))
                                {
                                    stringToPrint.Append("\t\t\t\t\t\t\t");
                                    stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedAngle(4 * Math.Atan(Math.Abs(v.Bulge)) * Math.Sign(v.Bulge)));


                                }
                                stringToPrint.Append("\n");
                                tH += 10F;
                                e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                                nv++;
                                stringToPrint.Clear();
                            }
                            //stringToPrint.Append("\n");
                            //tH += 10F;
                            //e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                            //toggle = !toggle;
                            break;

                        case EntityType.Spline:
                            Spline sp = (Spline)EntityToPrint;


                            stringToPrint.Append("\t\t\t\t\t\t\t\t\t");
                            stringToPrint.Append("");
                            stringToPrint.Append("\t");
                            stringToPrint.Append("");

                            stringToPrint.Append("\n");
                            tH += 10F;
                            if (toggle)
                            {
                                var rect = new RectangleF(10F, tH, 1000, 10f);

                                //Filling a rectangle before drawing the string.
                                e.Graphics.FillRectangle(BrushGrey, rect);
                                toggle = false;
                            }
                            else
                            {
                                toggle = true;
                            }
                            e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                            nv = 0;
                            foreach (SplineVertex cp in sp.ControlPoints)
                            {
                                stringToPrint.Clear();
                                stringToPrint.Append("\t\t");
                                stringToPrint.Append("#" + nv.ToString());
                                stringToPrint.Append("\t");
                                stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(cp.Position.X) + ";");
                                stringToPrint.Append(dxfReaderNETControl1.DXF.ToFormattedUnit(cp.Position.Y));

                                stringToPrint.Append("\n");
                                tH += 10F;
                                e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                                nv++;
                                stringToPrint.Clear();
                            }
                            //stringToPrint.Append("\n");
                            //tH += 10F;
                            //e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                            //toggle = !toggle;
                            break;
                    }
                    //stringToPrint.Append("\n");

                    if (stringToPrint.ToString().Length > 0)
                    {
                        tH += 10F;

                        if (toggle)
                        {
                            var rect = new RectangleF(10F, tH, 1000, 10f);

                            //Filling a rectangle before drawing the string.
                            e.Graphics.FillRectangle(BrushGrey, rect);
                            toggle = false;
                        }
                        else
                        {
                            toggle = true;
                        }

                        e.Graphics.DrawString(stringToPrint.ToString(), newFont, Brushes.Black, 10F, tH, stringFormat);
                        stringToPrint.Clear();
                    }
                }
            }



            //e.Graphics.DrawString(stringToPrint.ToString(), this.Font, Brushes.Black, e.MarginBounds, StringFormat.GenericTypographic);




        }


        private void ribbonButtonOpen_Click(object sender, EventArgs e)
        {
            ribbonOrbMenuItemOpen_Click(sender, e);
        }

        private void ribbonButtonZoomExt_Click(object sender, EventArgs e)
        {
            ribbonButton6_Click(sender, e);
        }


        private void LoadRegistry()
        {

            Registry.CurrentUser.OpenSubKey("Software", true).CreateSubKey("DXFReaderNETDemoProgram");


            this.Width = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wWidth", Screen.PrimaryScreen.Bounds.Width - 40);
            this.Height = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wHeight", Screen.PrimaryScreen.Bounds.Height - 60);
            this.Left = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wLeft", 20);
            this.Top = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wTop", 20);

            if (this.Left <= 20 || this.Top <= 20)
            {
                this.Left = 20;
                this.Top = 20;
            }
            if (this.Width <= 40 || this.Height <= 60)
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width - 40;
                this.Height = Screen.PrimaryScreen.Bounds.Height - 60;
            }
            if (this.Left + this.Width > Screen.PrimaryScreen.Bounds.Width)
            {
                this.Width = Screen.PrimaryScreen.Bounds.Width - this.Left - 40;

            }
            if (this.Top + this.Height > Screen.PrimaryScreen.Bounds.Height)
            {
                this.Height = Screen.PrimaryScreen.Bounds.Height - this.Top - 60;

            }
            string mWindowState = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "mWindowState", "").ToString();

            if (mWindowState == "Maximized") this.WindowState = FormWindowState.Maximized;

            dxfReaderNETControl1.HighlightEntityOnHover = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightEntityOnHover", false).ToString());
            dxfReaderNETControl1.ContinuousHighlight = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ContinuousHighlight", false).ToString());
            dxfReaderNETControl1.HighlightNotContinuous = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightNotContinuous", false).ToString());
            dxfReaderNETControl1.HighlightGrabPoints = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightGrabPoints", false).ToString());

            dxfReaderNETControl1.ShowAxes = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowAxes", false).ToString());
            dxfReaderNETControl1.ShowBasePoint = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowBasePoint", false).ToString());
            dxfReaderNETControl1.ShowLimits = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowLimits", false).ToString());
            dxfReaderNETControl1.ShowExtents = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowExtents", false).ToString());

            dxfReaderNETControl1.ShowGrid = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowGrid", true).ToString());
            dxfReaderNETControl1.ShowGridRuler = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowGridRuler", false).ToString());

            dxfReaderNETControl1.AntiAlias = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AntiAlias", false).ToString());

            dxfReaderNETControl1.ForeColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ForeColor", Color.White.ToArgb()));
            dxfReaderNETControl1.BackColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "BackColor", Color.FromArgb(33, 40, 48).ToArgb()));

            dxfReaderNETControl1.HighlightMarkerColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightMarkerColor", Color.FromArgb(255, 255, 0).ToArgb()));
            dxfReaderNETControl1.HighlightColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightColor", Color.FromArgb(255, 0, 0).ToArgb()));
            dxfReaderNETControl1.AxisXColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxisXColor", Color.FromArgb(72, 38, 43).ToArgb()));
            dxfReaderNETControl1.AxisYColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxisYColor", Color.FromArgb(34, 102, 39).ToArgb()));
            dxfReaderNETControl1.AxisZColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxisZColor", Color.FromArgb(32, 35, 175).ToArgb()));
            dxfReaderNETControl1.AxesColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxesColor", Color.FromArgb(255, 0, 0).ToArgb()));
            dxfReaderNETControl1.GridColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "GridColor", Color.FromArgb(38, 45, 55).ToArgb()));


            m_showCommandLine = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowCommandLine", false).ToString());
            m_selectRotationOnScreen = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "SelectRotationOnScreen", false).ToString());


            dxfReaderNETControl1.ObjectOsnapMode = (ObjectOsnapTypeFlags)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ObjectOsnapMode", 0);

            switch ((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandType", 0))
            {
                case 1:
                    m_RubberBandType = RubberBandType.Solid;
                    break;
                case 0:
                    m_RubberBandType = RubberBandType.Dashed;
                    break;
            }


            m_RubberBandColor = Color.FromArgb((int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandColor", Color.FromArgb(150, 150, 150).ToArgb()));

            dxfReaderNETControl1.GridDisplay = (GridDisplayType)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "GridDisplay", 0);

            dxfReaderNETControl1.PlotRotation = (PlotOrientationType)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotRotation", 0);
            dxfReaderNETControl1.PlotRendering = (PlotRenderingType)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotRendering", 0);
            dxfReaderNETControl1.PlotMode = (PlotModeType)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMode", 0);
            dxfReaderNETControl1.PlotUnits = (PlotUnitsType)Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotUnits", 0);

            CurrentLoadDXFPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentLoadDXFPath", CurrentLoadDXFPath).ToString();
            CurrentLoadRecoveryDXFPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentLoadRecoveryDXFPath", CurrentLoadRecoveryDXFPath).ToString();
            CurrentSaveDXFPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentSaveDXFPath", CurrentSaveDXFPath).ToString();


            CurrentLoadOBJPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentLoadOBJPath", CurrentLoadOBJPath).ToString();
            CurrentSaveBMPPath = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentSaveBMPPath", CurrentSaveBMPPath).ToString();




            dxfReaderNETControl1.PlotMarginTop = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginTop", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            dxfReaderNETControl1.PlotMarginBottom = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginBottom", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            dxfReaderNETControl1.PlotMarginLeft = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginLeft", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            dxfReaderNETControl1.PlotMarginRight = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginRight", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture);


            Vector2 po = new Vector2(float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotOffsetX", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture), float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotOffsetY", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture));
            dxfReaderNETControl1.PlotOffset = po;

            dxfReaderNETControl1.PlotScale = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotScale", 1.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            dxfReaderNETControl1.PlotPenWidth = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotPenWidth", 0.0F).ToString(), System.Globalization.CultureInfo.CurrentCulture);

            dxfReaderNETControl1.CursorSelectionSize = int.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CursorSelectionSize", 3).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            dxfReaderNETControl1.RubberBandPenWidth = int.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandPenWidth", 0).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            dxfReaderNETControl1.ZoomInOutPercent = float.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ZoomInOutPercent", 30).ToString(), System.Globalization.CultureInfo.CurrentCulture);


            m_GradientAciColor1 = short.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientAciColor1", 1).ToString(), System.Globalization.CultureInfo.CurrentCulture);
            m_GradientAciColor2 = short.Parse(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientAciColor2", 5).ToString(), System.Globalization.CultureInfo.CurrentCulture);

            m_PatternName = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_PatternName", "SOLID").ToString();
            m_HatchRotation = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_HatchRotation", "0").ToString();
            m_HatchBoundaries = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_HatchBoundaries", "Choose single entities").ToString();
            m_HatchScale = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_HatchScale", "1").ToString();
            m_GradientPatternName = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientPatternName", "Linear").ToString();
            m_GradientHatchRotation = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchRotation", "0").ToString();
            m_GradientHatchBoundaries = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchBoundaries", "Choose single entities").ToString();
            m_GradientHatchTransparency = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchTransparency", "0").ToString();


            m_GradientHatchCentered = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchCentered", true).ToString());

            m_ContinuousSelection = Convert.ToBoolean(Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_ContinuousSelection", true).ToString());




            for (int i = 0; i < maxMRUnumber; i++)
            {
                string file_name = Registry.GetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "mru" + i.ToString(), "").ToString();

                if (file_name != "")
                {
                    FileInfos.Add(file_name);


                    RibbonOrbRecentItem newRecent = new RibbonOrbRecentItem();
                    string mruitem = file_name;
                    if (mruitem.Length > 60)
                    {
                        mruitem = "[" + file_name.Substring(0, 25) + "...] " + Path.GetFileName(file_name);
                    }
                    newRecent.Text = mruitem;
                    newRecent.Value = file_name;



                    newRecent.Click += new EventHandler(newRecent_Click);
                    ribbon1.OrbDropDown.RecentItems.Add(newRecent);
                }
            }


        }

        private void SaveRegistry()
        {
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentLoadDXFPath", CurrentLoadDXFPath);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentLoadRecoveryDXFPath", CurrentLoadRecoveryDXFPath);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentSaveDXFPath", CurrentSaveDXFPath);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentLoadOBJPath", CurrentLoadOBJPath);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CurrentSaveBMPPath", CurrentSaveBMPPath);


            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "GridDisplay", System.Convert.ToInt32(dxfReaderNETControl1.GridDisplay));
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightEntityOnHover", dxfReaderNETControl1.HighlightEntityOnHover);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ContinuousHighlight", dxfReaderNETControl1.ContinuousHighlight);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightNotContinuous", dxfReaderNETControl1.HighlightNotContinuous);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightGrabPoints", dxfReaderNETControl1.HighlightGrabPoints);


            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowAxes", dxfReaderNETControl1.ShowAxes);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowBasePoint", dxfReaderNETControl1.ShowBasePoint);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowLimits", dxfReaderNETControl1.ShowLimits);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowExtents", dxfReaderNETControl1.ShowExtents);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowGrid", dxfReaderNETControl1.ShowGrid);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowGridRuler", dxfReaderNETControl1.ShowGridRuler);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AntiAlias", dxfReaderNETControl1.AntiAlias);


            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ShowCommandLine", m_showCommandLine);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "SelectRotationOnScreen", m_selectRotationOnScreen);


            switch (m_RubberBandType)
            {
                case RubberBandType.Solid:
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandType", 1);
                    break;
                case RubberBandType.Dashed:
                    Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandType", 0);
                    break;
            }



            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandColor", m_RubberBandColor.ToArgb());


            // Save the current entries.
            int i = 0;
            foreach (string file_info in FileInfos)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "mru" + i.ToString(), file_info);

                i++;
            }

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ForeColor", dxfReaderNETControl1.ForeColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "BackColor", dxfReaderNETControl1.BackColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightMarkerColor", dxfReaderNETControl1.HighlightMarkerColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "HighlightColor", dxfReaderNETControl1.HighlightColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxisXColor", dxfReaderNETControl1.AxisXColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxisYColor", dxfReaderNETControl1.AxisYColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxisZColor", dxfReaderNETControl1.AxisZColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "AxesColor", dxfReaderNETControl1.AxesColor.ToArgb());
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "GridColor", dxfReaderNETControl1.GridColor.ToArgb());

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wWidth", this.Width);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wHeight", this.Height);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wLeft", this.Left);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "wTop", this.Top);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "mWindowState", this.WindowState);


            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotRotation", System.Convert.ToInt32(dxfReaderNETControl1.PlotRotation));
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotRendering", System.Convert.ToInt32(dxfReaderNETControl1.PlotRendering));
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMode", System.Convert.ToInt32(dxfReaderNETControl1.PlotMode));
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotUnits", System.Convert.ToInt32(dxfReaderNETControl1.PlotUnits));

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginTop", dxfReaderNETControl1.PlotMarginTop);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginBottom", dxfReaderNETControl1.PlotMarginBottom);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginLeft", dxfReaderNETControl1.PlotMarginLeft);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotMarginRight", dxfReaderNETControl1.PlotMarginRight);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotOffsetX", dxfReaderNETControl1.PlotOffset.X);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotOffsetY", dxfReaderNETControl1.PlotOffset.Y);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotScale", dxfReaderNETControl1.PlotScale);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "PlotPenWidth", dxfReaderNETControl1.PlotPenWidth);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "CursorSelectionSize", dxfReaderNETControl1.CursorSelectionSize);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "RubberBandPenWidth", dxfReaderNETControl1.RubberBandPenWidth);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ZoomInOutPercent", dxfReaderNETControl1.ZoomInOutPercent);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_PatternName", m_PatternName);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_HatchRotation", m_HatchRotation);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_HatchBoundaries", m_HatchBoundaries);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_HatchScale", m_HatchScale);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientPatternName", m_GradientPatternName);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchRotation", m_GradientHatchRotation);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchBoundaries", m_GradientHatchBoundaries);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchTransparency", m_GradientHatchTransparency);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientHatchCentered", m_GradientHatchCentered);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientAciColor1", m_GradientAciColor1);
            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_GradientAciColor2", m_GradientAciColor2);

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "ObjectOsnapMode", System.Convert.ToInt32(dxfReaderNETControl1.ObjectOsnapMode));

            Registry.SetValue(@"HKEY_CURRENT_USER\Software\DXFReaderNETDemoProgram", "m_ContinuousSelection", m_ContinuousSelection);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!DiscardChanges())
            {
                e.Cancel = true;

            }
            else
            {
                SaveRegistry();
            }

        }




        private void CheckSnap()
        {
            if (dxfReaderNETControl1.ObjectOsnapMode != ObjectOsnapTypeFlags.None && CurrentFunction != FunctionsEnum.None)
            {
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairObjectSnap;
                if (CurrentFunction == FunctionsEnum.Area || CurrentFunction == FunctionsEnum.Distance1)
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairObjectSnapQuestionMark;
            }
        }

        private bool EntitesSelected()
        {
            return dxfReaderNETControl1.DXF.SelectedEntities.Count() > 0;
        }
        private void ribbonButtonObjectSnapEndpoint_Click(object sender, EventArgs e)
        {

            SetObjectSnapMode();

        }

        private void ribbonButtonObjectSnapMidpoint_Click(object sender, EventArgs e)
        {

            SetObjectSnapMode();
        }
        private void SetObjectSnapMode()
        {
            ObjectOsnapTypeFlags m_OsnapMode = ObjectOsnapTypeFlags.None;
            if (ribbonButtonObjectSnapEndpoint.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Endpoint;

            if (ribbonButtonObjectSnapMidpoint.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Midpoint;

            if (ribbonButtonObjectSnapCenter.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Center;

            if (ribbonButtonObjectSnapIntersection.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Intersection;

            if (ribbonButtonObjectSnapQuadrant.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Quadrant;

            if (ribbonButtonObjectSnapPerpendicular.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Perpendicular;

            if (ribbonButtonObjectSnapTangent.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Tangent;

            if (ribbonButtonObjectSnapInsertion.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Insertion;

            if (ribbonButtonObjectSnapNearest.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Nearest;

            if (ribbonButtonObjectSnapNode.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.Node;

            if (ribbonButtonObjectSnapGeometricCenter.Checked)
                m_OsnapMode |= ObjectOsnapTypeFlags.GeometricCenter;

            dxfReaderNETControl1.ObjectOsnapMode = m_OsnapMode;
            CheckSnap();
            if (dxfReaderNETControl1.HighlightGrabPoints)
            {
                dxfReaderNETControl1.Refresh();
            }
        }



        private void ribbonButtonObjectSnapQuadrant_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapPerpendicular_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapTangent_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapNode_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapNearest_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapInsertion_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapCenter_Click_1(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapIntersection_Click_1(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }





        private static DialogResult ShowInputDialog(ref string inputValue, string prompt, bool forceNumeric)
        {

            InputDialog inputBox = new InputDialog();
            inputBox.textBox1.Text = inputValue;
            inputBox.label1.Text = prompt;
            inputBox.ForceNumeric = forceNumeric;

            DialogResult result = inputBox.ShowDialog();
            inputValue = inputBox.textBox1.Text;
            return result;
        }


        private void ribbonButtonSave_Click(object sender, EventArgs e)
        {
            ribbonOrbMenuItem3_Click(sender, e);
        }

        private void ribbonButtonUndo_Click(object sender, EventArgs e)
        {
            UnDo();
        }

        private void ribbonButtonEllipse_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.Ellipse1;
            StatusLabel.Text = "Select axis start point";
            CheckSnap();
            LastCommand = Commands.ELLIPSE;
        }

        private void dxfReaderNETControl1_EndRead(object sender, EndReadEventArgs e)
        {

            StatusLabel.Text = "DXF file loaded";
            toolStripProgressBar1.Value = 0;
            Application.DoEvents();
        }

        private void dxfReaderNETControl1_EndDrawing(object sender, EndDrawingEventArgs e)
        {
            StatusLabel.Text = "";
            toolStripProgressBar1.Value = 0;
            Application.DoEvents();
            //CheckNotConnectedPoints();

        }

        private void ribbonButtonNew_Click(object sender, EventArgs e)
        {
            ribbonOrbMenuItem1_Click(sender, e);
        }


        private void ribbonButtonShowAxes_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowAxes = ribbonButtonShowAxes.Checked;
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonShowBasepoint_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowBasePoint = ribbonButtonShowBasepoint.Checked;
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonShowLimits_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowLimits = ribbonButtonShowLimits.Checked;
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonAntialias_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.AntiAlias = ribbonButtonAntialias.Checked;
            dxfReaderNETControl1.Refresh();
        }


        private void ribbonButtonDrawPolylineRectangle_Click(object sender, EventArgs e)
        {


            string inputValue = m_RectangleFilletRadius.ToString();

            if (!labelCommands.Visible)
            {

                if (ShowInputDialog(ref inputValue, "Rounded corners radius (negative for notched corners)", true) == DialogResult.OK)
                {
                    m_RectangleFilletRadius = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                    CurrentFunction = FunctionsEnum.Rectangle1;

                    StatusLabel.Text = "Select start corner of the rectangle";
                    LastCommand = Commands.RECTANGLE;
                    CheckSnap();
                }
            }
            else
            {
                labelCommands.Text = "RECTANGLE specify rounded corners radius (negative for notched corners):";
                txtCommand.Text = inputValue;
                //cmdCoord = inputValue;
                CurrentFunction = FunctionsEnum.Rectangle0;
            }


        }

        private void ribbonPanelProperites_ButtonMoreClick(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowLayers();
            LoadLayersCombo();

        }

        private void ribbonButtonDrawLineTrace_Click(object sender, EventArgs e)
        {
            string inputValue = dxfReaderNETControl1.DXF.DrawingVariables.Tracewidth.ToString();
            if (ShowInputDialog(ref inputValue, "Trace width", true) == DialogResult.OK)
            {
                double Tracewidth = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (Tracewidth > 0)
                {
                    dxfReaderNETControl1.DXF.DrawingVariables.Tracewidth = Tracewidth;
                    StartDrawLineTrace();
                }
            }
        }


        private void StartDrawLineTrace()
        {


            CurrentFunction = FunctionsEnum.Trace1;

            CheckSnap();
            StatusLabel.Text = "Select start point of the trace";
            LastCommand = Commands.TRACE;
        }
        private void ribbonButtonDrawPolylineSolid_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.Solid1;
            CheckSnap();
            StatusLabel.Text = "Select first point";
            LastCommand = Commands.SOLID;
        }

        private void ribbonButtonDrawPolylinePolygon_Click(object sender, EventArgs e)
        {
            string inputValue = PolygonSides.ToString();
            if (ShowInputDialog(ref inputValue, "Polygon sides", true) == DialogResult.OK)
            {
                short nSides = short.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (nSides > 2)
                {
                    PolygonSides = nSides;

                    CurrentFunction = FunctionsEnum.Polygon1;
                    CheckSnap();
                    StatusLabel.Text = "Select center point";
                    LastCommand = Commands.POLIGON;
                }
            }
        }

        private void ribbonButtonDrawImageImage_Click(object sender, EventArgs e)
        {
            ImageSelector imageSelector = new ImageSelector();
            imageSelector.TextBoxFileName.Text = m_ImageFileName;
            imageSelector.TextBoxRotation.Text = m_ImageRotation;
            imageSelector.ComboBox1.SelectedIndex = imageSelector.ComboBox1.FindString(m_ImageTransparency);
            imageSelector.checkBoxScaleOnScreen.Checked = m_ImageScaleOnScreen;
            imageSelector.checkBoxEmbedImage.Checked = m_ImageEmbed;
            if (imageSelector.ShowDialog() == DialogResult.OK)
            {
                m_ImageFileName = imageSelector.TextBoxFileName.Text;
                if (m_ImageFileName != "")
                {
                    m_ImageRotation = imageSelector.TextBoxRotation.Text;
                    m_ImageTransparency = imageSelector.ComboBox1.Text;



                    var imgsrc = new Bitmap(m_ImageFileName);
                    m_ImageWidth = imgsrc.Width;
                    m_ImageHeight = imgsrc.Height;
                    imgsrc.Dispose();
                    m_ImageScaleOnScreen = imageSelector.checkBoxScaleOnScreen.Checked;
                    m_ImageEmbed = imageSelector.checkBoxEmbedImage.Checked;
                    if (m_ImageScaleOnScreen)
                    {
                        StatusLabel.Text = "Select start corner of the image";
                        CurrentFunction = FunctionsEnum.Image1;
                    }
                    else
                    {
                        StatusLabel.Text = "Select the position of the image";
                        CurrentFunction = FunctionsEnum.ImageFixedSize;

                    }
                    CheckSnap();
                    LastCommand = Commands.IMAGE;
                }
            }
        }

        private void ribbonButtonDrawImagePDF_Click(object sender, EventArgs e)
        {

            PDFSelector pdfSelector = new PDFSelector();
            pdfSelector.TextBoxFileName.Text = m_PDFFileName;
            pdfSelector.TextBoxRotation.Text = m_PDFRotation;
            pdfSelector.TextBoxScale.Text = m_PDFScale;
            pdfSelector.ComboBox1.SelectedIndex = pdfSelector.ComboBox1.FindString(m_PDFTransparency);
            pdfSelector.checkBoxMonochrome.Checked = m_PDFMonochrome;
            if (pdfSelector.ShowDialog() == DialogResult.OK)
            {
                m_PDFFileName = pdfSelector.TextBoxFileName.Text;
                m_PDFRotation = pdfSelector.TextBoxRotation.Text;
                m_PDFTransparency = pdfSelector.ComboBox1.Text;
                m_PDFScale = pdfSelector.TextBoxScale.Text;
                m_PDFMonochrome = pdfSelector.checkBoxMonochrome.Checked;
                CurrentFunction = FunctionsEnum.PDFUnderlay;
                CheckSnap();
                StatusLabel.Text = "Select the position of the PDF underlay";
                LastCommand = Commands.ATTACHPDF;
            }
        }

        private void ribbonButtonDrawImage_Click(object sender, EventArgs e)
        {
            if (NumBlocks() > 0)
                ribbonButtonDrawInsertBlock_Click(sender, e);
        }

        private void ribbonButtonDrawLineSingle_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.LINE;
            CurrentFunction = FunctionsEnum.Line1;
            CheckSnap();
            StatusLabel.Text = "Select start point of the line";
        }

        private void ribbonButtonDrawLine_Click(object sender, EventArgs e)
        {
            ribbonButtonDrawLineSingle_Click(sender, e);
        }

        private void ribbonButtonDrawLineRay_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.RAY;
            VideoSize = Vector2.Distance(dxfReaderNETControl1.LowerLeftCorner, dxfReaderNETControl1.UpperRightCorner);
            StatusLabel.Text = "Select origin of the ray";
            CurrentFunction = FunctionsEnum.Ray1;
            CheckSnap();
        }

        private void ribbonButtonDrawContructionLine_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.XLINE;
            VideoSize = Vector2.Distance(dxfReaderNETControl1.LowerLeftCorner, dxfReaderNETControl1.UpperRightCorner);
            StatusLabel.Text = "Select origin of construction line";
            CurrentFunction = FunctionsEnum.Xline1;
            CheckSnap();
        }

        private void ribbonButtonDrawCircleRadius_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.CIRCLE_Center_Radius;
            StatusLabel.Text = "Select center point";
            CurrentFunction = FunctionsEnum.Circle1;
            CheckSnap();
        }

        private void ribbonButtonDrawCircle2Points_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.CIRCLE_Diameter;
            CurrentFunction = FunctionsEnum.Circle2p1;
            CheckSnap();
            StatusLabel.Text = "Select diameter start point";
        }

        private void ribbonButtonDrawCircle3Points_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.CIRCLE_3Points;
            StatusLabel.Text = "Select first point";
            CurrentFunction = FunctionsEnum.Circle3p1;
            CheckSnap();
        }

        private void ribbonButtonDrawCircle_Click(object sender, EventArgs e)
        {
            ribbonButtonDrawCircleRadius_Click(sender, e);
        }

        private void ribbonComboBox3D_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            switch (((RibbonComboBox)sender).SelectedItem.Text)
            {
                case "Top":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Top);
                    ribbonComboBox3D.Image = ribbonButtonView3DTop.SmallImage;

                    break;
                case "Bottom":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Bottom);
                    ribbonComboBox3D.Image = ribbonButtonView3DBottom.SmallImage;
                    break;
                case "Left":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Left);
                    ribbonComboBox3D.Image = ribbonButtonView3DLeft.SmallImage;
                    break;
                case "Right":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Right);
                    ribbonComboBox3D.Image = ribbonButtonView3DRight.SmallImage;
                    break;
                case "Front":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Front);
                    ribbonComboBox3D.Image = ribbonButtonView3DFront.SmallImage;
                    break;
                case "Back":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.Back);
                    ribbonComboBox3D.Image = ribbonButtonView3DBack.SmallImage;
                    break;
                case "SW Isometric":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.SW_Isometric);
                    ribbonComboBox3D.Image = ribbonButtonView3DSW.SmallImage;
                    break;
                case "SE Isometric":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.SE_Isometric);
                    ribbonComboBox3D.Image = ribbonButtonView3DSE.SmallImage;
                    break;
                case "NE Isometric":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.NE_Isometric);
                    ribbonComboBox3D.Image = ribbonButtonView3DNE.SmallImage;
                    break;
                case "NW Isometric":
                    dxfReaderNETControl1.DisplayPredefinedView(PredefinedViewType.NW_Isometric);
                    ribbonComboBox3D.Image = ribbonButtonView3DNW.SmallImage;
                    break;
            }

        }

        private void LoadViewsCombo()
        {
            ribbonComboBoxViews.DropDownItems.Clear();
            foreach (DXFReaderNET.Tables.View view in dxfReaderNETControl1.DXF.Views)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = view.Name;
                ribbonComboBoxViews.DropDownItems.Add(newItem);
            }
            RibbonButton newAddItem = new RibbonButton();
            newAddItem.Text = "Add view...";
            ribbonComboBoxViews.DropDownItems.Add(newAddItem);

            ribbonComboBoxViews.TextBoxText = "";

        }
        private void LoadLtypesCombo()
        {
            ribbonComboBoxLineTypes.DropDownItems.Clear();
            ribbonComboBoxLineTypes.DrawIconsBar = false;
            foreach (DXFReaderNET.Tables.Linetype linetype in dxfReaderNETControl1.DXF.Linetypes)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = linetype.Name;
                //if (linetype.Description.Trim() != "")
                //{
                //    newItem.Text += " - " + linetype.Description.Trim();

                //}
                ribbonComboBoxLineTypes.DropDownItems.Add(newItem);
                if (dxfReaderNETControl1.DXF.CurrentLineTypeName == linetype.Name)
                {
                    ribbonComboBoxLineTypes.SelectedItem = newItem;
                }
            }
            RibbonButton newAddItem = new RibbonButton();
            newAddItem.Text = "Add linetypes...";
            ribbonComboBoxLineTypes.DropDownItems.Add(newAddItem);
        }
        private void LoadLayersCombo()
        {
            ribbonComboBoxLayers.DropDownItems.Clear();
            ribbonComboBoxLayers.DrawIconsBar = false;
            foreach (DXFReaderNET.Tables.Layer layer in dxfReaderNETControl1.DXF.Layers)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = layer.Name;
                ribbonComboBoxLayers.DropDownItems.Add(newItem);
                if (dxfReaderNETControl1.DXF.CurrentLayer == layer.Name)
                {
                    ribbonComboBoxLayers.SelectedItem = newItem;
                }
            }
            RibbonButton newAddItem = new RibbonButton();
            newAddItem.Text = "Add layer...";
            ribbonComboBoxLayers.DropDownItems.Add(newAddItem);

        }

        private void ribbonComboBoxViews_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {
                if (((RibbonComboBox)sender).SelectedItem.Text != "Add view...")
                {
                    dxfReaderNETControl1.DisplayView(((RibbonComboBox)sender).SelectedItem.Text.Trim());
                }
                else
                {
                    string inputValue = "";

                    if (ShowInputDialog(ref inputValue, "New view name", false) == DialogResult.OK)
                    {
                        if (inputValue != "")
                        {
                            bool isPresent = false;
                            foreach (DXFReaderNET.Tables.View _view in dxfReaderNETControl1.DXF.Views)
                            {
                                if (_view.Name.Trim().ToLower() == inputValue.Trim().ToLower())
                                {
                                    isPresent = true;
                                    break;
                                }
                            }
                            if (!isPresent)
                            {
                                dxfReaderNETControl1.AddView(inputValue);
                                LoadViewsCombo();

                                foreach (RibbonButton item in ribbonComboBoxViews.DropDownItems)
                                {
                                    if (item.Text == inputValue)
                                    {
                                        ribbonComboBoxViews.SelectedItem = item;
                                        break;
                                    }
                                }


                            }

                        }
                    }
                }
            }

        }

        private void ribbonComboBoxRendering_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            switch (((RibbonComboBox)sender).SelectedItem.Text)
            {
                case "Wireframe":
                    dxfReaderNETControl1.Rendering = RenderingType.WireFrame;
                    ribbonComboBoxRendering.Image = ribbonButtonRenderingWireframe.SmallImage;
                    break;
                case "Shaded":
                    dxfReaderNETControl1.Rendering = RenderingType.Shaded;
                    ribbonComboBoxRendering.Image = ribbonButtonRenderingShaded.SmallImage;
                    break;
                case "Shaded edges":
                    dxfReaderNETControl1.Rendering = RenderingType.ShadedEdges;
                    ribbonComboBoxRendering.Image = ribbonButtonRenderingShadedEdges.SmallImage;
                    break;

            }
        }

        private void ribbonComboBoxLayers_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {



                if (((RibbonComboBox)sender).SelectedItem.Text != "Add layer...")
                {
                    dxfReaderNETControl1.DXF.CurrentLayer = ((RibbonComboBox)sender).SelectedItem.Text.Trim();
                }
                else
                {
                    string inputValue = "";

                    if (ShowInputDialog(ref inputValue, "New layer name", false) == DialogResult.OK)
                    {
                        if (inputValue != "")
                        {
                            bool isPresent = false;
                            foreach (DXFReaderNET.Tables.Layer _layer in dxfReaderNETControl1.DXF.Layers)
                            {
                                if (_layer.Name.Trim().ToLower() == inputValue.Trim().ToLower())
                                {
                                    isPresent = true;
                                    break;
                                }
                            }
                            if (!isPresent)
                            {
                                dxfReaderNETControl1.AddLayer(inputValue);
                                LoadLayersCombo();

                                foreach (RibbonButton item in ribbonComboBoxLayers.DropDownItems)
                                {
                                    if (item.Text == inputValue)
                                    {
                                        ribbonComboBoxLayers.SelectedItem = item;
                                        break;
                                    }
                                }
                                dxfReaderNETControl1.DXF.CurrentLayer = ((RibbonComboBox)sender).SelectedItem.Text.Trim();

                            }

                        }
                    }
                }





            }
        }

        private void ribbonColorChooserColor_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.CurrentColor = dxfReaderNETControl1.ShowPalette(dxfReaderNETControl1.DXF.CurrentColor);
            ribbonColorChooserColor.Color = dxfReaderNETControl1.DXF.CurrentColor.ToColor();
            ribbonLabelCurrentColor.Text = dxfReaderNETControl1.DXF.CurrentColor.ToString();
        }

        private void ribbonLabel3_Click(object sender, EventArgs e)
        {
            ribbonColorChooserColor_Click(sender, e);
        }

        private void ribbonLabelCurrentColor_Click(object sender, EventArgs e)
        {
            ribbonColorChooserColor_Click(sender, e);
        }

        private void ribbonPanelInquiry_ButtonMoreClick(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowDrawingInfo();
        }

        private void ribbonButtonInquiryMeasureDistance_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.Distance1;
            CheckSnap();
            StatusLabel.Text = "Select start point";
        }

        private void ribbonButtonInquiryMeasure_Click(object sender, EventArgs e)
        {
            ribbonButtonInquiryMeasureDistance_Click(sender, e);
        }

        private void ribbonButtonInquiryEntityInfo_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.EntityProperties;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select entity";
        }

        private void TestRoutine()
        {

        }
        private void FlattenEntities(IEnumerable<EntityObject> Entities)
        {
            foreach (EntityObject ent in Entities)
            {
                switch (ent.Type)
                {
                    case EntityType.Point:
                        ((DXFReaderNET.Entities.Point)ent).Position = new Vector3(((DXFReaderNET.Entities.Point)ent).Position.X, ((DXFReaderNET.Entities.Point)ent).Position.Y, 0);

                        break;
                    case EntityType.Line:
                        ((Line)ent).StartPoint = new Vector3(((Line)ent).StartPoint.X, ((Line)ent).StartPoint.Y, 0);
                        ((Line)ent).EndPoint = new Vector3(((Line)ent).EndPoint.X, ((Line)ent).EndPoint.Y, 0);

                        break;
                    case EntityType.Arc:

                        ((Arc)ent).Center = new Vector3(((Arc)ent).Center.X, ((Arc)ent).Center.Y, 0);

                        break;
                    case EntityType.Circle:

                        ((Circle)ent).Center = new Vector3(((Circle)ent).Center.X, ((Circle)ent).Center.Y, 0);

                        break;
                    case EntityType.Ellipse:

                        ((Ellipse)ent).Center = new Vector3(((Ellipse)ent).Center.X, ((Ellipse)ent).Center.Y, 0);

                        break;

                    case EntityType.Polyline:
                        Polyline polyline = (Polyline)ent;

                        for (int k = 0; k < polyline.Vertexes.Count; k++)
                        {
                            polyline.Vertexes[k].Position = new Vector3(polyline.Vertexes[k].Position.X, polyline.Vertexes[k].Position.Y, 0);

                        }

                        break;

                    case EntityType.Spline:
                        Spline spline = (Spline)ent;

                        for (int k = 0; k < spline.ControlPoints.Count; k++)
                        {
                            spline.ControlPoints[k].Position = new Vector3(spline.ControlPoints[k].Position.X, spline.ControlPoints[k].Position.Y, 0);

                        }

                        break;

                }
            }
        }
        private void ribbonButtonInquiryTest_Click(object sender, EventArgs e)
        {
            TestRoutine();

        }

        private void ribbonComboBoxLineTypes_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {

                if (((RibbonComboBox)sender).SelectedItem.Text != "Add linetypes...")
                {
                    dxfReaderNETControl1.DXF.CurrentLineTypeName = ((RibbonComboBox)sender).SelectedItem.Text.Trim();
                }
                else
                {
                    openFileDialog1.DefaultExt = "lin";
                    openFileDialog1.Filter = "ACAD lin file|*.lin|All files (*.*)|*.*";
                    openFileDialog1.FileName = "";

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        LoadLIN(openFileDialog1.FileName);
                        LoadLtypesCombo();
                    }
                }
            }
        }

        private void ribbonButtonDrawPolyline_Click(object sender, EventArgs e)
        {
            string inputValue = dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth.ToString();
            if (ShowInputDialog(ref inputValue, "Polyline width", true) == DialogResult.OK)
            {
                double Polylinewidth = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (Polylinewidth >= 0)
                {
                    dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth = Polylinewidth;
                    StartDrawPolyline();


                }
            }
        }
        private void StartDrawPolyline()
        {
            CurrentFunction = FunctionsEnum.Polyline;
            vertexes.Clear();
            CheckSnap();
            StatusLabel.Text = "Select points with left mouse click. Right mouse click to end.";
            LastCommand = Commands.POLYLINE;
        }
        private void ribbonButtonInquiryMeasureArea_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.Area;
            CheckSnap();
            vertexes.Clear();
            StatusLabel.Text = "Select points with left mouse click. Right mouse click to end.";
        }

        private void ribbonButtonDrawPoint_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Point;

            StatusLabel.Text = "Select point";
        }

        private void ribbonButtonDrawMethodsLine_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.DrawLine1;
            CheckSnap();
            StatusLabel.Text = "Select start point of the line";
        }



        private void ribbonButtonDrawMethodsPenWidth_Click(object sender, EventArgs e)
        {

            PenSelector penSelector = new PenSelector();
            penSelector.TextBoxPenWidth.Text = CurrentDrawPenWidth.ToString();
            penSelector.textBoxDashLength.Text = CurrentDrawDashLength.ToString();
            penSelector.textBoxSkipLength.Text = CurrentDrawSkipLength.ToString();
            penSelector.ComboBox1.SelectedIndex = penSelector.ComboBox1.FindString(CurrentDrawPenStyle);


            if (penSelector.ShowDialog() == DialogResult.OK)
            {
                CurrentDrawPenWidth = float.Parse(penSelector.TextBoxPenWidth.Text, System.Globalization.CultureInfo.CurrentCulture);
                CurrentDrawDashLength = float.Parse(penSelector.textBoxDashLength.Text, System.Globalization.CultureInfo.CurrentCulture);
                CurrentDrawSkipLength = float.Parse(penSelector.textBoxSkipLength.Text, System.Globalization.CultureInfo.CurrentCulture);

                CurrentDrawPenStyle = penSelector.ComboBox1.Text;
                DrawPen = new Pen(CurrentDrawColor);
                DrawPen.Width = CurrentDrawPenWidth;
                if (CurrentDrawPenStyle == "Continuous")
                {
                    DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                else
                {
                    DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                    DrawPen.DashPattern = new float[] { CurrentDrawDashLength, CurrentDrawSkipLength };
                }
            }
        }

        private void ribbonButton9_Click_1(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements();
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsCircle_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select center point";
            CurrentFunction = FunctionsEnum.DrawCircle1;
            CheckSnap();
        }

        private void ribbonButtonArcCenterStartEnd_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select center point";
            CurrentFunction = FunctionsEnum.Arc1;
            CheckSnap();
        }

        private void ribbonButtonArc_Click(object sender, EventArgs e)
        {
            ribbonButtonArcCenterStartEnd_Click(sender, e);
        }

        private void ribbonButtonArcStartMiddleEnd_Click(object sender, EventArgs e)
        {


            StatusLabel.Text = "Select start point";
            CurrentFunction = FunctionsEnum.ArcStartMiddleEnd1;
            CheckSnap();
        }

        private void ribbonButtonDrawMethodsArc_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select center point";
            CurrentFunction = FunctionsEnum.DrawArc1;
            CheckSnap();
        }

        private void ribbonColorChooserDrawMethodsColor_Click(object sender, EventArgs e)
        {
            Cdialog.Text = "Drawing methods pen color";
            Cdialog.Color = CurrentDrawColor;

            if (Cdialog.ShowDialog() == DialogResult.OK)
            {
                CurrentDrawColor = Cdialog.Color;
                ribbonColorChooserDrawMethodsColor.Color = CurrentDrawColor;

                DrawPen = new Pen(CurrentDrawColor);
                DrawPen.Width = CurrentDrawPenWidth;
                if (CurrentDrawPenStyle == "Continuous")
                {
                    DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                }
                else
                {
                    DrawPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Custom;
                    DrawPen.DashPattern = new float[] { CurrentDrawDashLength, CurrentDrawSkipLength };
                }
            }
        }

        private void ribbonButtonDrawMethodsPoint_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select point";
            CurrentFunction = FunctionsEnum.DrawPoint;
            CheckSnap();
        }

        private void ribbonButtonDrawMethodsPolygon_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.DrawPolygon;
            vertexes.Clear();
            StatusLabel.Text = "Select points with left mouse click. Right mouse click to end.";
            CheckSnap();
        }

        private void ribbonButtonDrawPolylinePolyline_Click(object sender, EventArgs e)
        {
            ribbonButtonDrawPolyline_Click(sender, e);
        }

        private void ribbonButtonDrawPolylineLwPolyline_Click(object sender, EventArgs e)
        {
            string inputValue = dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth.ToString();
            if (ShowInputDialog(ref inputValue, "Lightweight polyline width", true) == DialogResult.OK)
            {
                double Polylinewidth = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (Polylinewidth >= 0)
                {
                    dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth = Polylinewidth;

                    StartDrawLwPolyline();
                }
            }
        }
        private void StartDrawLwPolyline()
        {
            CurrentFunction = FunctionsEnum.LwPolyline;
            vertexes.Clear();
            StatusLabel.Text = "Select points with left mouse click. Right mouse click to end.";
            CheckSnap();
            LastCommand = Commands.LWPOLYLINE;
        }
        private void ribbonButtonDrawMethodsImage_Click(object sender, EventArgs e)
        {
            ImageSelector imageSelector = new ImageSelector();
            imageSelector.TextBoxFileName.Text = m_ImageFileName;
            imageSelector.TextBoxRotation.Text = m_ImageRotation;
            imageSelector.ComboBox1.SelectedIndex = imageSelector.ComboBox1.FindString(m_ImageTransparency);
            imageSelector.checkBoxScaleOnScreen.Checked = m_ImageScaleOnScreen;
            imageSelector.checkBoxEmbedImage.Visible = false;
            imageSelector.label6.Visible = false;
            if (imageSelector.ShowDialog() == DialogResult.OK)
            {
                m_ImageFileName = imageSelector.TextBoxFileName.Text;
                if (m_ImageFileName != "")
                {
                    m_ImageRotation = imageSelector.TextBoxRotation.Text;
                    m_ImageTransparency = imageSelector.ComboBox1.Text;


                    var imgsrc = new Bitmap(m_ImageFileName);
                    m_ImageWidth = imgsrc.Width;
                    m_ImageHeight = imgsrc.Height;
                    imgsrc.Dispose();
                    m_ImageScaleOnScreen = imageSelector.checkBoxScaleOnScreen.Checked;
                    if (m_ImageScaleOnScreen)
                    {
                        StatusLabel.Text = "Select start corner of the image";
                        CurrentFunction = FunctionsEnum.DrawImage1;
                    }
                    else
                    {
                        StatusLabel.Text = "Select the position of the image";
                        CurrentFunction = FunctionsEnum.DrawImageFixedSize;

                    }

                }
            }
        }

        private void ribbonButtonModifySelectSinlge_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.GetEntity;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select entity";
        }

        private void ribbonButtonModifySelect_Click(object sender, EventArgs e)
        {
            ribbonButtonModifySelectSinlge_Click(sender, e);
        }

        private void ribbonButtonModifySelectRectangle_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.GetEntities1;

            StatusLabel.Text = "Select start point of selection rectangle";
        }

        private void ribbonButtonModifySelectAll_Click(object sender, EventArgs e)
        {
            SelectAllEntities();
        }
        private void SelectAllEntities()
        {
            dxfReaderNETControl1.DXF.SelectedEntities.Clear();

            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {
                if (ent.IsVisible && dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsVisible && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsFrozen && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsLocked)
                {
                    if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                    {
                        dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);
                        ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                    }

                }
            }

            dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);
        }

        private void ribbonButtonModyfiSelectClear_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.SelectedEntities.Clear();
            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonModifyDeleteSelected_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveUndo();
                dxfReaderNETControl1.DXF.RemoveEntities(dxfReaderNETControl1.DXF.SelectedEntities);
                dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                dxfReaderNETControl1.Refresh();

            }

        }

        private void ribbonButtonModifyDelete_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
                ribbonButtonModifyDeleteSelected_Click(sender, e);
        }

        private void ribbonButtonModifyDeleteNotSelected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (dxfReaderNETControl1.DXF.SelectedEntities != null)
                {
                    SaveUndo();
                    foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
                    {
                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                        {
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                        }


                    }


                    //dxfReaderNETControl1.DXF.RemoveEntities();
                    //dxfReaderNETControl1.DXF.AddEntities(dxfReaderNETControl1.DXF.SelectedEntities);
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                    dxfReaderNETControl1.Refresh();
                }

            }
        }

        private void ribbonButtonModifyDeleteHandle_Click(object sender, EventArgs e)
        {
            string handle = "";
            if (ShowInputDialog(ref handle, "Delete entity with handle", false) == DialogResult.OK)
            {
                if (handle != "")
                {
                    dxfReaderNETControl1.DXF.RemoveObject(handle);
                    dxfReaderNETControl1.Refresh();
                }
            }
        }

        private void ribbonButtonModifyDeleteButHandle_Click(object sender, EventArgs e)
        {
            string handle = "";
            if (ShowInputDialog(ref handle, "Delete all entities BUT entity with handle", false) == DialogResult.OK)
            {
                if (handle != "")
                {
                    DXFReaderNET.Collections.EntityCollection myEntities = dxfReaderNETControl1.DXF.Entities;
                    for (int k = 0; k < myEntities.Count; k++)
                    {
                        if (myEntities[k].Handle.ToLower() != handle.ToLower())
                        {
                            dxfReaderNETControl1.DXF.RemoveObject(myEntities[k].Handle);
                        }
                    }

                    dxfReaderNETControl1.Refresh();
                }
            }
        }

        private void ribbonButtonModidyCopyCopy_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
            {

                CurrentFunction = FunctionsEnum.CopyEntities1;
                CheckSnap();
                StatusLabel.Text = "Select base point";
            }
        }

        private void ribbonButtonModifyCopyMove_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.MoveEntities1;
            CheckSnap();
            StatusLabel.Text = "Select base point";
        }

        private void ribbonButtonModifyCopy_Click(object sender, EventArgs e)
        {
            ribbonButtonModidyCopyCopy_Click(sender, e);
        }

        private void ribbonButtonModifyCopyRotate_Click(object sender, EventArgs e)
        {


            string inputValue = m_rotation.ToString();

            InputDialog inputBox = new InputDialog();
            inputBox.textBox1.Text = inputValue;
            inputBox.label1.Text = "Rotation angle [°]"; ;
            inputBox.ForceNumeric = true;
            inputBox.checkBoxInputDialog.Visible = true;
            inputBox.checkBoxInputDialog.Text = "Select rotation on screen";
            inputBox.checkBoxInputDialog.Checked = m_selectRotationOnScreen;
            DialogResult result = inputBox.ShowDialog();



            if (result == DialogResult.OK)
            {
                inputValue = inputBox.textBox1.Text;
                m_rotation = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                m_selectRotationOnScreen = inputBox.checkBoxInputDialog.Checked;
                if (inputBox.checkBoxInputDialog.Checked)
                {
                    CurrentFunction = FunctionsEnum.RotateEntities1;
                }
                else
                {
                    if (m_rotation != 0)
                    {
                        CurrentFunction = FunctionsEnum.RotateEntities;

                    }
                }
                CheckSnap();
                StatusLabel.Text = "Select base point";
            }



        }

        private void ribbonButtonModifyDelete_DropDownShowing(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 0)
            {
                ribbonButtonModifyDeleteSelected.Enabled = false;
                ribbonButtonModifyDeleteNotSelected.Enabled = false;
            }
            else
            {
                ribbonButtonModifyDeleteSelected.Enabled = true;
                ribbonButtonModifyDeleteNotSelected.Enabled = true;
            }

            if (dxfReaderNETControl1.DXF.Entities.Count == 0)
            {
                ribbonButtonDeleteSelectedEntities.Enabled = false;
                ribbonButtonDeleteEntitiesByColor.Enabled = false;
                ribbonButtonDeleteEntitiesByLayer.Enabled = false;
                ribbonButtonModifyDeleteHandle.Enabled = false;
                ribbonButtonModifyDeleteButHandle.Enabled = false;
                ribbonButtonModifyRemoveBlocks.Enabled = false;

                ribbonButtonDeleteEntitiesByLineType.Enabled = false;
                ribbonButtonDeleteCoincident.Enabled = false;
                ribbonButtonDeleteNotConnected.Enabled = false;
                ribbonButtonDeleteZeroLen.Enabled = false;
            }
            else
            {
                ribbonButtonDeleteSelectedEntities.Enabled = true;
                ribbonButtonDeleteEntitiesByColor.Enabled = true;
                ribbonButtonDeleteEntitiesByLayer.Enabled = true;
                ribbonButtonModifyDeleteHandle.Enabled = true;
                ribbonButtonModifyDeleteButHandle.Enabled = true;
                ribbonButtonModifyRemoveBlocks.Enabled = true;
                ribbonButtonDeleteEntitiesByLineType.Enabled = true;
                ribbonButtonDeleteCoincident.Enabled = true;
                ribbonButtonDeleteNotConnected.Enabled = true;
                ribbonButtonDeleteZeroLen.Enabled = true;
                if (dxfReaderNETControl1.DXF.Entities.Count < 2)
                    ribbonButtonDeleteCoincident.Enabled = false;

            }

        }

        private void ribbonButtonModifySelect_DropDownShowing(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 0)
            {
                ribbonButtonModyfiSelectClear.Enabled = false;
                ribbonButtonModyfiSelectShow.Enabled = false;

            }
            else
            {
                ribbonButtonModyfiSelectClear.Enabled = true;
                ribbonButtonModyfiSelectShow.Enabled = true;

            }
        }

        private void ribbonOrbMenuItemImport_Click(object sender, EventArgs e)
        {

            openFileDialog1.DefaultExt = "obj";
            openFileDialog1.Filter = "Wavefront .OBJ file|*.obj";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = CurrentLoadOBJPath;
            openFileDialog1.Title = "Import file";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (dxfReaderNETControl1.ReadOBJ(openFileDialog1.FileName))
                {
                    StatusLabel.Text = "File '" + openFileDialog1.FileName + "' imported.";
                    CurrentLoadOBJPath = Path.GetDirectoryName(openFileDialog1.FileName);
                }
            }
        }

        private void ribbonOrbMenuItemExport_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "jpg";
            saveFileDialog1.Filter = "JPEG (*.jpg)|*.jpg|PNG (*.png)|*.png|BMP (*.bmp)|*.bmp";
            saveFileDialog1.FileName = "";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.Title = "Export file";

            saveFileDialog1.InitialDirectory = CurrentSaveBMPPath;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentSaveBMPPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                switch (saveFileDialog1.FilterIndex)
                {
                    case 1:
                        dxfReaderNETControl1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        dxfReaderNETControl1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                        break;
                    case 3:
                        dxfReaderNETControl1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;

                }

            }
        }

        private void ribbonButtonSaveAs_Click(object sender, EventArgs e)
        {
            ribbonOrbMenuItem4_Click(sender, e);
        }

        private void ribbonButtonModifySelectSingleMulti_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.GetEntities;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select entities. ESC or right click to end.";
        }

        private void ribbonButtonModifyCopy_DropDownShowing(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 0)
            {
                foreach (RibbonButton item in ribbonButtonModifyCopy.DropDownItems)
                {
                    item.Enabled = false;
                }

            }
            else
            {
                foreach (RibbonButton item in ribbonButtonModifyCopy.DropDownItems)
                {
                    item.Enabled = true;
                }
            }
        }

        private void ribbonButtonDrawLineContinous_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.LINES;
            CurrentFunction = FunctionsEnum.Lines;
            CheckSnap();
            StatusLabel.Text = "Select points with left mouse click. Right mouse clic to end.";
            vertexes.Clear();
        }

        private void ribbonButtonSplineControlPoints_Click(object sender, EventArgs e)
        {
            LastCommand = Commands.SPLINE;
            CurrentFunction = FunctionsEnum.Spline;
            CheckSnap();
            StatusLabel.Text = "Select control points with left mouse click. Right mouse clic to end.";
        }



        private void ribbonButtonGridRuler_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowGridRuler = !dxfReaderNETControl1.ShowGridRuler;
        }

        private void ribbonButtonDrawHatchNormal_Click(object sender, EventArgs e)
        {
            HatchSelector hatchSelector = new HatchSelector();
            hatchSelector.TextBoxScale.Text = m_HatchScale;
            hatchSelector.TextBoxRotation.Text = m_HatchRotation;

            hatchSelector.ComboBox1.Items.Clear();

            hatchSelector.ComboBox1.Items.AddRange(new object[] {
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
            if (hatchPatternsCustom != null)
            {
                for (int k = 0; k < hatchPatternsCustom.Count; k++)
                {
                    hatchSelector.ComboBox1.Items.Add(hatchPatternsCustom[k].Name);
                }

            }
            hatchSelector.ComboBox1.SelectedIndex = hatchSelector.ComboBox1.FindString(m_PatternName);
            hatchSelector.comboBox2.SelectedIndex = hatchSelector.comboBox2.FindString(m_HatchBoundaries);


            if (hatchSelector.ShowDialog() == DialogResult.OK)
            {
                m_HatchScale = hatchSelector.TextBoxScale.Text;
                m_HatchRotation = hatchSelector.TextBoxRotation.Text;
                m_PatternName = hatchSelector.ComboBox1.Text;

                m_HatchBoundaries = hatchSelector.comboBox2.Text;
                CreateHatch();
                LastCommand = Commands.HATCH;
            }

        }
        private void CreateHatch()
        {
            Boundary.Clear();
            BoundaryOutermost.Clear();

            switch (m_HatchBoundaries)
            {
                case "Choose single entities":
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
                    StatusLabel.Text = "Select entities with left mouse click. Right mouse clic to finish.";
                    CurrentFunction = FunctionsEnum.Hatch;
                    break;
                case "Choose entities by rectangle":
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    StatusLabel.Text = "Select start point of selection rectangle";
                    CurrentFunction = FunctionsEnum.HatchRecangle1;
                    Boundary.Clear();
                    break;
                case "Define polygon":

                    StatusLabel.Text = "Select points with left mouse click. Right mouse clic to close.";
                    CurrentFunction = FunctionsEnum.HatchBoundaries;
                    CheckSnap();
                    break;
                case "Point inside entity":

                    StatusLabel.Text = "Select a point inside a closed entity.";
                    CurrentFunction = FunctionsEnum.HatchPoint;
                    CheckSnap();
                    break;
                case "Selected entities":
                    if (dxfReaderNETControl1.DXF.SelectedEntities.Count() > 0)
                    {
                        List<EntityObject> externalContour = new List<EntityObject>();
                        List<EntityObject> innerEntities = new List<EntityObject>();
                        FindBoundaries(dxfReaderNETControl1.DXF.SelectedEntities, out externalContour, out innerEntities);

                        m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, externalContour, innerEntities, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);

                        dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                        dxfReaderNETControl1.Refresh();
                    }
                    else
                    {
                        StatusLabel.Text = "There are no selected entities";
                    }

                    break;

            }
        }
        private void ribbonButtonDrawHatch_Click(object sender, EventArgs e)
        {
            ribbonButtonDrawHatchNormal_Click(sender, e);
        }



        private void ribbonButtonDrawHatchGradient_Click(object sender, EventArgs e)
        {
            GradientSelector gradientSelector = new GradientSelector();

            gradientSelector.TextBoxRotation.Text = m_GradientHatchRotation;
            gradientSelector.ComboBox1.SelectedIndex = gradientSelector.ComboBox1.FindString(m_GradientPatternName);
            gradientSelector.comboBox2.SelectedIndex = gradientSelector.comboBox2.FindString(m_GradientHatchBoundaries);
            gradientSelector.comboBox3.SelectedIndex = gradientSelector.comboBox3.FindString(m_GradientHatchTransparency);
            gradientSelector.checkBoxCentered.Checked = m_GradientHatchCentered;
            gradientSelector.buttonColor1.BackColor = AciColor.FromCadIndex(m_GradientAciColor1).ToColor();
            gradientSelector.buttonColor2.BackColor = AciColor.FromCadIndex(m_GradientAciColor2).ToColor();

            gradientSelector.buttonColor1.Tag = m_GradientAciColor1;
            gradientSelector.buttonColor2.Tag = m_GradientAciColor2;

            if (gradientSelector.ShowDialog() == DialogResult.OK)
            {
                LastCommand = Commands.HATCH_GRADIENT;
                m_GradientHatchCentered = gradientSelector.checkBoxCentered.Checked;
                m_GradientAciColor1 = (short)gradientSelector.buttonColor1.Tag;
                m_GradientAciColor2 = (short)gradientSelector.buttonColor2.Tag;

                m_GradientHatchRotation = gradientSelector.TextBoxRotation.Text;
                m_GradientPatternName = gradientSelector.ComboBox1.Text;

                m_GradientHatchBoundaries = gradientSelector.comboBox2.Text;
                m_GradientHatchTransparency = gradientSelector.comboBox3.Text;
                CreateGradientHatch();
            }
        }
        private void CreateGradientHatch()
        {
            Boundary.Clear();
            BoundaryOutermost.Clear();

            switch (m_GradientHatchBoundaries)
            {

                case "Choose single entities":
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
                    StatusLabel.Text = "Select entities with left mouse click. Right mouse clic to finish.";
                    CurrentFunction = FunctionsEnum.GradientHatch;
                    break;
                case "Choose entities by rectangle":
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    StatusLabel.Text = "Select start point of selection rectangle";
                    CurrentFunction = FunctionsEnum.GradientHatchRectangle1;
                    Boundary.Clear();
                    break;


                case "Define polygon":

                    StatusLabel.Text = "Select points with left mouse click. Right mouse clic to close.";
                    CurrentFunction = FunctionsEnum.GradientHatchBoundaries;
                    CheckSnap();
                    break;
                case "Point inside entity":

                    StatusLabel.Text = "Select a point inside a closed entity.";
                    CurrentFunction = FunctionsEnum.GradientHatchPoint;
                    CheckSnap();
                    break;

                case "Selected entities":
                    if (dxfReaderNETControl1.DXF.SelectedEntities.Count() > 0)
                    {
                        List<EntityObject> externalContour = new List<EntityObject>();
                        List<EntityObject> innerEntities = new List<EntityObject>();
                        FindBoundaries(dxfReaderNETControl1.DXF.SelectedEntities, out externalContour, out innerEntities);

                        m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), externalContour, innerEntities, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);
                        if (m_GradientHatchTransparency != "0")
                        {
                            if (m_LastAddedEntity != null)
                            {
                                Hatch myHatch = dxfReaderNETControl1.DXF.Hatches[dxfReaderNETControl1.DXF.Hatches.Count - 1];
                                myHatch.Transparency = new Transparency(short.Parse(m_GradientHatchTransparency));
                            }
                        }
                        dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                        dxfReaderNETControl1.Refresh();
                    }
                    else
                    {
                        StatusLabel.Text = "There are no selected entities";
                    }

                    break;

            }
        }

        private void ribbonButtonViewRefresh_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.Refresh();
        }



        private void ribbonButtonInquiryMeasurecenter_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.LocatePoint;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairQuestionMark;

            StatusLabel.Text = "Select the point with a mouse clic";

        }

        private void ribbonButtonInquiryMeasureRadius_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Radius;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;

            StatusLabel.Text = "Select circle or arc";
        }

        private void ribbonButtonInquiryMeasurePoly_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.PolylineLenght;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairQuestionMark;
            StatusLabel.Text = "Select points with left mouse click. Right mouse click to end.";
        }

        private void ribbonButtonModifyExplodeInsert_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButtonModifyExplodePoly_Click(object sender, EventArgs e)
        {

        }

        private void ribbonButtonModifyExplodeCircle_Click(object sender, EventArgs e)
        {
            string inputValue = m_precision.ToString();
            if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            {
                m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                CurrentFunction = FunctionsEnum.ExplodeCircle;
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
                StatusLabel.Text = "Select circle entity";
            }
        }

        private void ribbonButtonModifyExplodeArc_Click(object sender, EventArgs e)
        {
            string inputValue = m_precision.ToString();
            if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            {
                m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                CurrentFunction = FunctionsEnum.ExplodeArc;
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
                StatusLabel.Text = "Select arc entity";
            }
        }

        private void ribbonButtonModifyExplodeEllipse_Click(object sender, EventArgs e)
        {
            string inputValue = m_precision.ToString();
            if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            {
                m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                CurrentFunction = FunctionsEnum.ExplodeEllipse;
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
                StatusLabel.Text = "Select ellipse entity";
            }
        }

        private void ribbonButtonModifyLines2Poly_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //LwPolyline newPoly = new LwPolyline(dxfReaderNETControl1.DXF.SelectedEntities, false, 36);
                LwPolyline newPoly = new LwPolyline(dxfReaderNETControl1.DXF.SelectedEntities, false);
                if (newPoly != null)
                {
                    if (newPoly.Vertexes.Count > 0)
                    {
                        SaveUndo();
                        newPoly.Color = dxfReaderNETControl1.DXF.CurrentColor;
                        dxfReaderNETControl1.DXF.AddEntity(newPoly);
                        dxfReaderNETControl1.DXF.RemoveEntities(dxfReaderNETControl1.DXF.SelectedEntities);
                        dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                        ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        dxfReaderNETControl1.Refresh();
                    }
                }

            }
        }

        private void ribbonButtonModifyOffset_Click(object sender, EventArgs e)
        {
            string inputValue = m_offset.ToString();
            if (ShowInputDialog(ref inputValue, "Specify offset", true) == DialogResult.OK)
            {
                m_offset = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (m_offset != 0)
                {
                    CurrentFunction = FunctionsEnum.Offset1;

                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
                    StatusLabel.Text = "Select entity to offset";
                }
            }
        }

        private void ribbonButtonHelpRegister_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.RegisterComponent();
        }

        private void ribbonButtonHelpAbout_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.About();
        }

        private void ribbonButtonModifyBlock_Click(object sender, EventArgs e)
        {

            string inputValue = m_newBlockName;
            if (ShowInputDialog(ref inputValue, "Block name", false) == DialogResult.OK)
            {

                if (inputValue != "")
                {
                    m_newBlockName = inputValue.ToUpper();
                    bool blockExists = false;
                    foreach (DXFReaderNET.Blocks.Block blk in dxfReaderNETControl1.DXF.Blocks)
                    {
                        if (blk.Name.ToUpper() == m_newBlockName)
                        {
                            blockExists = true;
                            break;
                        }
                    }

                    if (blockExists)
                    {
                        StatusLabel.Text = "Block name already exists";
                    }
                    else
                    {

                        CurrentFunction = FunctionsEnum.Block;
                        CheckSnap();
                        StatusLabel.Text = "Select base point";

                    }
                }
            }


        }

        private void ribbonButtonDrawInsertBlock_Click(object sender, EventArgs e)
        {

            BlockSelector blockSelector = new BlockSelector();
            blockSelector.TextBoxScale.Text = m_BlockScale;
            blockSelector.TextBoxRotation.Text = m_BlockRotation;
            blockSelector.ComboBox1.Items.Clear();
            //blockSelector.DXFReaderNETControl = dxfReaderNETControl1;
            blockSelector.DXFReaderNETControl = new DXFReaderNETControl();


            foreach (DXFReaderNET.Blocks.Block _block in dxfReaderNETControl1.DXF.Blocks.Items)
            {
                if (_block.Entities.Count > 0 || _block.AttributeDefinitions.Count > 0)
                {
#if DEBUG

                    blockSelector.ComboBox1.Items.Add(_block.Name.ToString());
                    blockSelector.DXFReaderNETControl.DXF.Blocks.Add((DXFReaderNET.Blocks.Block)_block.Clone());
#else
  if (!_block.Name.StartsWith("*") && !_block.Name.StartsWith("_")) {

                        blockSelector.ComboBox1.Items.Add(_block.Name.ToString());

                        }
#endif

                }
            }

            if (m_BlockName != "")
            {
                blockSelector.ComboBox1.SelectedIndex = blockSelector.ComboBox1.FindString(m_BlockName);
            }
            if (blockSelector.ShowDialog() == DialogResult.OK)
            {

                m_BlockRotation = blockSelector.TextBoxRotation.Text;
                m_BlockName = blockSelector.ComboBox1.Text;
                m_BlockScale = blockSelector.TextBoxScale.Text;
                if (m_BlockName != "")
                {


                    CurrentFunction = FunctionsEnum.Insert;
                    StatusLabel.Text = "Select insertion point";
                    CheckSnap();
                }

            }
        }

        private void ribbonButtonModifyRotate_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.RotateAxis1;
            CheckSnap();
            StatusLabel.Text = "Select start point of the mirror axis";

        }


        private void ribbonButtonShowgrid_Click(object sender, EventArgs e)
        {
            StatusLabelGrid_Click(sender, e);
        }

        private void ribbonButtonAnnotationsDimensionAlignedStartEnd_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.AlignedDimension1;
            StatusLabel.Text = "Select start point";
            CheckSnap();
        }

        private void ribbonButtonAnnotationsDimensionAlignedLine_Click(object sender, EventArgs e)
        {

            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            CurrentFunction = FunctionsEnum.AlignedDimensionLine1;
            StatusLabel.Text = "Select line";
        }

        private void ribbonButtonAnnotationsText_Click(object sender, EventArgs e)
        {
            string inputValue = m_Text;
            if (ShowInputDialog(ref inputValue, "Text?", false) == DialogResult.OK)
            {

                if (inputValue != "")
                {
                    m_Text = inputValue;

                    inputValue = dxfReaderNETControl1.DXF.CurrentTextSize.ToString();
                    if (ShowInputDialog(ref inputValue, "Text height", true) == DialogResult.OK)
                    {
                        dxfReaderNETControl1.DXF.CurrentTextSize = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                        if (dxfReaderNETControl1.DXF.CurrentTextSize > 0)
                        {

                            CurrentFunction = FunctionsEnum.Text;
                            CheckSnap();
                            StatusLabel.Text = "Select insert point";
                        }
                    }

                }
            }
        }

        private void ribbonButtonAnnotationsDimensionLinearStartEnd_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.LinearDimension1;
            CheckSnap();
            StatusLabel.Text = "Select start point";
        }

        private void ribbonButtonAnnotationsDimensionLinearLine_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            CurrentFunction = FunctionsEnum.LinearDimensionLine1;
            StatusLabel.Text = "Select line";
        }

        private bool SelectLineFromEntity(EntityObject ent)
        {
            switch (ent.Type)
            {
                case EntityType.Line:

                    SelectedLine = (Line)ent;
                    p1 = p;
                    return true;

                case EntityType.LightWeightPolyline:
                    LwPolyline lw = (LwPolyline)ent;
                    SelectedLine = null;
                    for (int k = 0; k < lw.Vertexes.Count - 1; k++)
                    {
                        Vector2 ps = lw.Vertexes[k].Position;
                        Vector2 pe = lw.Vertexes[k + 1].Position;
                        double bulge = lw.Vertexes[k].Bulge;
                        if (MathHelper.IsZero(bulge))
                        {

                            if (MathHelper.PointOnLineSegment(ps, pe, p1))

                            {
                                SelectedLine = new Line();
                                SelectedLine.StartPoint = ps.ToVector3();
                                SelectedLine.EndPoint = pe.ToVector3();
                                break;

                            }
                        }
                    }
                    if (lw.IsClosed && SelectedLine == null)
                    {
                        Vector2 ps = lw.Vertexes[lw.Vertexes.Count - 1].Position;
                        Vector2 pe = lw.Vertexes[0].Position;
                        double bulge = lw.Vertexes[lw.Vertexes.Count - 1].Bulge;
                        if (MathHelper.IsZero(bulge))
                        {

                            if (MathHelper.PointOnLineSegment(ps, pe, p1))
                            {
                                SelectedLine = new Line();
                                SelectedLine.StartPoint = ps.ToVector3();
                                SelectedLine.EndPoint = pe.ToVector3();

                            }
                        }
                    }
                    if (SelectedLine != null)
                    {
                        return true;

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        return false;
                    }

                case EntityType.Polyline:
                    Polyline polyline = (Polyline)ent;
                    SelectedLine = null;
                    for (int k = 0; k < polyline.Vertexes.Count - 1; k++)
                    {
                        Vector2 ps = polyline.Vertexes[k].Position.ToVector2();
                        Vector2 pe = polyline.Vertexes[k + 1].Position.ToVector2();
                        double bulge = polyline.Vertexes[k].Bulge;
                        if (MathHelper.IsZero(bulge))
                        {

                            if (MathHelper.PointOnLineSegment(ps, pe, p1))
                            {
                                SelectedLine = new Line();
                                SelectedLine.StartPoint = ps.ToVector3();
                                SelectedLine.EndPoint = pe.ToVector3();
                                break;

                            }
                        }
                    }
                    if (polyline.IsClosed && SelectedLine == null)
                    {
                        Vector2 ps = polyline.Vertexes[polyline.Vertexes.Count - 1].Position.ToVector2();
                        Vector2 pe = polyline.Vertexes[0].Position.ToVector2();
                        double bulge = polyline.Vertexes[polyline.Vertexes.Count - 1].Bulge;
                        if (MathHelper.IsZero(bulge))
                        {

                            if (MathHelper.PointOnLineSegment(ps, pe, p1))
                            {
                                SelectedLine = new Line();
                                SelectedLine.StartPoint = ps.ToVector3();
                                SelectedLine.EndPoint = pe.ToVector3();

                            }
                        }
                    }
                    if (SelectedLine != null)
                    {
                        return true;

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                        return false;
                    }

                default:
                    StatusLabel.Text = "Selected entity is not a line";
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    return false;

            }


        }

        private void ribbonButtonAnnotationsDimensionAngular2Lines_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            CurrentFunction = FunctionsEnum.AngularDimension2Lines1;
            StatusLabel.Text = "Select first line";
        }

        private void ribbonButtonAnnotationsDimensionAngularArc_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            CurrentFunction = FunctionsEnum.AngularDimensionArc1;
            StatusLabel.Text = "Select arc";
        }

        private void ribbonButtonAnnotationsDimensionAngular3points_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.AngularDimensionCenterStartEnd1;
            StatusLabel.Text = "Select center point";
            CheckSnap();
        }

        private void ribbonButtonAnnotationsDimensionDiameter_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            CurrentFunction = FunctionsEnum.DiametricDimension1;
            StatusLabel.Text = "Select circle or arc";
        }

        private void ribbonButtonAnnotationsDimensionradius_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            CurrentFunction = FunctionsEnum.RadialDimension1;
            StatusLabel.Text = "Select circle or arc";
        }

        private void ribbonComboBoxDimensionStyle_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {
                dxfReaderNETControl1.DXF.DrawingVariables.DimStyle = ((RibbonComboBox)sender).SelectedItem.Text.Trim();
            }
        }


        private void ribbonButtonAnnotationsDimension_Click(object sender, EventArgs e)
        {
            ribbonButtonAnnotationsDimensionAlignedStartEnd_Click(sender, e);
        }

        private void ribbonButtonDrawMethodstext_Click(object sender, EventArgs e)
        {
            string inputValue = m_DrawText;

            InputText inputText = new InputText();
            inputText.textBox1.Text = inputValue;
            inputText.textBox2.Text = m_DrawTextHeight.ToString();
            //inputText.label1.Text = "Text?";
            inputText.ForceNumeric = false;
            inputText.TextBoxRotation.Text = m_TextRotation;


            inputText.checkBoxBold.Checked = false;
            if (m_FontStyle.HasFlag(FontStyle.Bold))
                inputText.checkBoxBold.Checked = true;


            inputText.checkBoxItalic.Checked = false;
            if (m_FontStyle.HasFlag(FontStyle.Italic))
                inputText.checkBoxItalic.Checked = true;


            inputText.checkBoxUnderline.Checked = false;
            if (m_FontStyle.HasFlag(FontStyle.Underline))
                inputText.checkBoxUnderline.Checked = true;


            inputText.checkBoxStrikeout.Checked = false;
            if (m_FontStyle.HasFlag(FontStyle.Strikeout))
                inputText.checkBoxStrikeout.Checked = true;


            switch (m_Alignment)
            {
                case StringAlignment.Near:
                    inputText.ComboBoxAlignment.SelectedIndex = 0;
                    break;
                case StringAlignment.Center:
                    inputText.ComboBoxAlignment.SelectedIndex = 1;
                    break;
                case StringAlignment.Far:
                    inputText.ComboBoxAlignment.SelectedIndex = 2;
                    break;

            }



            DialogResult result = inputText.ShowDialog();
            inputValue = inputText.textBox1.Text;
            m_DrawTextHeight = double.Parse(inputText.textBox2.Text, System.Globalization.CultureInfo.CurrentCulture);
            if (result == DialogResult.OK)
            {

                if (inputValue != "")
                {
                    m_DrawText = inputValue;

                    m_FontStyle = FontStyle.Regular;
                    if (inputText.checkBoxBold.Checked)
                        m_FontStyle |= FontStyle.Bold;
                    if (inputText.checkBoxItalic.Checked)
                        m_FontStyle |= FontStyle.Italic;
                    if (inputText.checkBoxUnderline.Checked)
                        m_FontStyle |= FontStyle.Underline;
                    if (inputText.checkBoxStrikeout.Checked)
                        m_FontStyle |= FontStyle.Strikeout;
                    m_TextRotation = inputText.TextBoxRotation.Text;


                    switch (inputText.ComboBoxAlignment.SelectedIndex)
                    {
                        case 0:
                            m_Alignment = StringAlignment.Near;
                            break;
                        case 1:
                            m_Alignment = StringAlignment.Center;
                            break;
                        case 2:
                            m_Alignment = StringAlignment.Far;
                            break;
                        case 3:
                            m_FontStyle = FontStyle.Underline;
                            break;
                        case 4:
                            m_FontStyle = FontStyle.Strikeout;
                            break;
                    }


                    if (m_DrawTextHeight > 0)
                    {

                        CurrentFunction = FunctionsEnum.DrawText;
                        CheckSnap();
                        StatusLabel.Text = "Select insert point";
                    }


                }
            }
        }

        private void ribbonButtonPropertiesUnits_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowDrawingUnits();
            ribbonTextBoxElevation.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.CurrentElevation);
            ribbonTextBoxThickness.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.CurrentThickness);
            ribbonTextBoxLtScale.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.CurrentLineTypeScale);

        }

        private void ribbonButtonDrawMethodsClearPoints_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Points);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsClearLines_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Lines);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsClearCircles_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Circles);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsClearArcs_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Arcs);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsClearPolygons_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Polygons);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsClearTexts_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Texts);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonDrawMethodsClearImages_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ClearDrawnElements(DrawElementsType.Images);
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonTextBoxLtScale_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }

        }

        private void ribbonTextBoxElevation_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonTextBoxThickness_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonTextBoxLtScale_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.CurrentLineTypeScale = double.Parse(ribbonTextBoxLtScale.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonTextBoxElevation_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.CurrentElevation = double.Parse(ribbonTextBoxElevation.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonTextBoxThickness_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.CurrentThickness = double.Parse(ribbonTextBoxThickness.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }


        private void ribbonColorChooserRubberBand_Click(object sender, EventArgs e)
        {


            colorDialog1.Color = m_RubberBandColor;


            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                m_RubberBandColor = colorDialog1.Color;

                ribbonColorChooserRubberBand.Color = colorDialog1.Color;
            }
        }

        private void ribbonButtonExplodeSplineSingle_Click(object sender, EventArgs e)
        {
            //string inputValue = m_precision.ToString();
            //if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            //{
            //    m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
            CurrentFunction = FunctionsEnum.ExplodeSpline;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select spline entity";
            //}
        }

        private void ribbonButtonExplodeSplineRectangle_Click(object sender, EventArgs e)
        {
            //string inputValue = m_precision.ToString();
            //if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            //{
            //m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
            CurrentFunction = FunctionsEnum.ExplodeSplineRect1;
            StatusLabel.Text = "Select start point of selection rectangle";
            //}
        }

        private void ribbonButtonPlotPreview_Click(object sender, EventArgs e)
        {
            ribbonOrbMenuItem5_Click(sender, e);
        }

        private void printPreviewControl1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)

            {
                case Keys.Escape:
                    printPreviewControl1.Visible = false;
                    splitContainer1.Visible = true;

                    break;

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            printPreviewControl1.Visible = false;
            splitContainer1.Visible = true;
            ribbon1.Visible = true;
            toolStripPlotPreview.Visible = false;
            OnPlotPreview = false;
            PrintType = PrintTypeEnum.Drawing;

        }

        private void ribbonOrbMenuItemPlot_Click(object sender, EventArgs e)
        {


            switch (PrintType)
            {
                case PrintTypeEnum.Drawing:
                    if (dxfReaderNETControl1.PlotMode == PlotModeType.Window && !OnPlotPreview)
                    {
                        CurrentFunction = FunctionsEnum.PlotWindow1;
                        StatusLabel.Text = "Select start point of the ploting window";
                    }
                    else
                    {

                        PlotDrawing();

                    }
                    break;
                case PrintTypeEnum.EntiesList:
                    PrintDialog pd = new PrintDialog();

                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();


                        if (pd.PrinterSettings.PrinterName != null)
                            doc.PrinterSettings.PrinterName = pd.PrinterSettings.PrinterName;

                        doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_PrintEntitiesList);
                        System.Drawing.Printing.PrintController printController = new System.Drawing.Printing.StandardPrintController();
                        doc.PrintController = printController;
                        doc.Print();
                    }
                    break;
                case PrintTypeEnum.EntityProperties:
                    pd = new PrintDialog();

                    if (pd.ShowDialog() == DialogResult.OK)
                    {
                        System.Drawing.Printing.PrintDocument doc = new System.Drawing.Printing.PrintDocument();


                        if (pd.PrinterSettings.PrinterName != null)
                            doc.PrinterSettings.PrinterName = pd.PrinterSettings.PrinterName;

                        doc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(_PrintEntityProperties);
                        System.Drawing.Printing.PrintController printController = new System.Drawing.Printing.StandardPrintController();
                        doc.PrintController = printController;
                        doc.Print();
                    }
                    break;

            }




        }

        private void PlotDrawing()
        {
            PrintDialog pd = new PrintDialog();

            if (pd.ShowDialog() == DialogResult.OK)
            {
                dxfReaderNETControl1.Plot(pd.PrinterSettings.PrinterName, pd.PrinterSettings.Copies);
            }
        }

        private void toolStripButtonPlot_Click(object sender, EventArgs e)
        {

            ribbonOrbMenuItemPlot_Click(sender, e);
        }

        private void ribbonButtonPlotModeDisplay_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMode = PlotModeType.Display;
        }

        private void ribbonButtonPlotModeExtents_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMode = PlotModeType.Extents;
        }

        private void ribbonButtonPlotModeLimits_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMode = PlotModeType.Limits;
        }

        private void ribbonButtonPlotModeWindow_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMode = PlotModeType.Window;
        }
        private void ribbonButtonPlotModeCentered_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMode = PlotModeType.Centered;
        }
        private void ribbonButtonPlotRenderingColor_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.Color;
        }

        private void ribbonButtonPlotRenderingGrayScale_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.GrayScale;
        }

        private void ribbonButtonPlotRenderingMonochrome_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotRendering = PlotRenderingType.Monochrome;
        }

        private void ribbonButtonPlotRotationPortrait_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotRotation = PlotOrientationType.Portrait;
        }

        private void ribbonButtonPlotRotationLandscape_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotRotation = PlotOrientationType.Landscape;
        }

        private void ribbonButtonPlotUnitsInchs_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotUnits = PlotUnitsType.Inchs;
        }

        private void ribbonButtonPlotUnitsMillimeters_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotUnits = PlotUnitsType.Millimeters;
        }

        private void ribbonButtonDrawPolylineSpline_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Spline;
            CheckSnap();
            vertexes.Clear();
            StatusLabel.Text = "Select control points with left mouse click. Right mouse clic to end.";
            LastCommand = Commands.SPLINE;
        }

        private void ribbonUpDownPlotMarginTop_DownButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginTop;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value > 0) value -= 1;
                    dxfReaderNETControl1.PlotMarginTop = value;
                    ribbonUpDownPlotMarginTop.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value > 0) value -= 0.1F;
                    dxfReaderNETControl1.PlotMarginTop = value;
                    ribbonUpDownPlotMarginTop.TextBoxText = value.ToString("#0.0");
                    break;


            }

        }

        private void ribbonUpDownPlotMarginTop_UpButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginTop;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value < 290) value += 1;
                    dxfReaderNETControl1.PlotMarginTop = value;
                    ribbonUpDownPlotMarginTop.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value < 11) value += 0.1F;
                    dxfReaderNETControl1.PlotMarginTop = value;
                    ribbonUpDownPlotMarginTop.TextBoxText = value.ToString("#0.0");
                    break;


            }

        }

        private void ribbonUpDownPlotMarginBottom_DownButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginBottom;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value > 0) value -= 1;
                    dxfReaderNETControl1.PlotMarginBottom = value;
                    ribbonUpDownPlotMarginBottom.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value > 0) value -= 0.1F;
                    dxfReaderNETControl1.PlotMarginBottom = value;
                    ribbonUpDownPlotMarginBottom.TextBoxText = value.ToString("#0.0");
                    break;


            }

        }

        private void ribbonUpDownPlotMarginBottom_UpButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginBottom;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value < 290) value += 1;
                    dxfReaderNETControl1.PlotMarginBottom = value;
                    ribbonUpDownPlotMarginBottom.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value < 11) value += 0.1F;
                    dxfReaderNETControl1.PlotMarginBottom = value;
                    ribbonUpDownPlotMarginBottom.TextBoxText = value.ToString("#0.0");
                    break;


            }

        }

        private void ribbonUpDownPlotMarginLeft_DownButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginLeft;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value > 0) value -= 1;
                    dxfReaderNETControl1.PlotMarginLeft = value;
                    ribbonUpDownPlotMarginLeft.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value > 0) value -= 0.1F;
                    dxfReaderNETControl1.PlotMarginLeft = value;
                    ribbonUpDownPlotMarginLeft.TextBoxText = value.ToString("#0.0");
                    break;


            }
        }

        private void ribbonUpDownPlotMarginLeft_UpButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginLeft;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value < 210) value += 1;
                    dxfReaderNETControl1.PlotMarginLeft = value;
                    ribbonUpDownPlotMarginLeft.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value < 8.5) value += 0.1F;
                    dxfReaderNETControl1.PlotMarginLeft = value;
                    ribbonUpDownPlotMarginLeft.TextBoxText = value.ToString("#0.0");
                    break;


            }
        }

        private void ribbonUpDownPlotMarginRight_DownButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginRight;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value > 0) value -= 1;
                    dxfReaderNETControl1.PlotMarginRight = value;
                    ribbonUpDownPlotMarginRight.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value > 0) value -= 0.1F;
                    dxfReaderNETControl1.PlotMarginRight = value;
                    ribbonUpDownPlotMarginRight.TextBoxText = value.ToString("#0.0");
                    break;


            }
        }

        private void ribbonUpDownPlotMarginRight_UpButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotMarginRight;
            switch (dxfReaderNETControl1.PlotUnits)
            {
                case PlotUnitsType.Millimeters:
                    if (value < 210) value += 1;
                    dxfReaderNETControl1.PlotMarginRight = value;
                    ribbonUpDownPlotMarginRight.TextBoxText = value.ToString("###0");
                    break;
                case PlotUnitsType.Inchs:
                    if (value < 8.5) value += 0.1F;
                    dxfReaderNETControl1.PlotMarginRight = value;
                    ribbonUpDownPlotMarginRight.TextBoxText = value.ToString("#0.0");
                    break;


            }
        }

        private void ribbonUpDownPlotMarginTop_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonUpDownPlotMarginTop_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMarginTop = float.Parse(ribbonUpDownPlotMarginTop.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonUpDownPlotMarginBottom_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonUpDownPlotMarginLeft_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonUpDownPlotMarginLeft_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMarginLeft = float.Parse(ribbonUpDownPlotMarginLeft.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonUpDownPlotMarginBottom_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMarginBottom = float.Parse(ribbonUpDownPlotMarginBottom.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonUpDownPlotMarginRight_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonUpDownPlotMarginRight_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotMarginRight = float.Parse(ribbonUpDownPlotMarginRight.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonTextBoxPlotOriginX_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonTextBoxPlotOriginX_TextBoxValidated(object sender, EventArgs e)
        {
            Vector2 po = new Vector2(float.Parse(ribbonTextBoxPlotOriginX.TextBoxText, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.PlotOffset.Y);
            dxfReaderNETControl1.PlotOffset = po;
        }

        private void ribbonTextBoxPlotOriginY_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonTextBoxPlotOriginY_TextBoxValidated(object sender, EventArgs e)
        {
            Vector2 po = new Vector2(dxfReaderNETControl1.PlotOffset.X, float.Parse(ribbonTextBoxPlotOriginY.TextBoxText, System.Globalization.CultureInfo.CurrentCulture));
            dxfReaderNETControl1.PlotOffset = po;
        }

        private void ribbonTextBoxPlotScale_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonTextBoxPlotScale_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotScale = float.Parse(ribbonTextBoxPlotScale.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonUpDownPlotPenWidth_DownButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotPenWidth;
            if (value > 0) value -= 1;
            dxfReaderNETControl1.PlotPenWidth = value;
            ribbonUpDownPlotPenWidth.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(value);
        }

        private void ribbonUpDownPlotPenWidth_UpButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.PlotPenWidth;
            if (value < 20) value += 1;
            dxfReaderNETControl1.PlotPenWidth = value;
            ribbonUpDownPlotPenWidth.TextBoxText = dxfReaderNETControl1.DXF.ToFormattedUnit(value);
        }

        private void ribbonUpDownPlotPenWidth_TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != decimalSeparetor))
            {
                e.Handled = true;
            }
        }

        private void ribbonUpDownPlotPenWidth_TextBoxValidated(object sender, EventArgs e)
        {
            dxfReaderNETControl1.PlotPenWidth = float.Parse(ribbonUpDownPlotPenWidth.TextBoxText, System.Globalization.CultureInfo.CurrentCulture);
        }

        private void ribbonButtonModifyCopyScale_Click(object sender, EventArgs e)
        {
            string inputValue = m_scale.ToString();

            InputDialog inputBox = new InputDialog();
            inputBox.textBox1.Text = inputValue;
            inputBox.label1.Text = "Scale factor"; ;
            inputBox.ForceNumeric = true;
            inputBox.checkBoxInputDialog.Visible = true;
            inputBox.checkBoxInputDialog.Text = "Select scale on screen";
            inputBox.checkBoxInputDialog.Checked = m_selectRotationOnScreen;
            DialogResult result = inputBox.ShowDialog();



            if (result == DialogResult.OK)
            {
                inputValue = inputBox.textBox1.Text;
                m_scale = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                m_selectRotationOnScreen = inputBox.checkBoxInputDialog.Checked;
                if (inputBox.checkBoxInputDialog.Checked)
                {
                    CurrentFunction = FunctionsEnum.ScaleEntities1;
                }
                else
                {
                    if (m_scale != 1)
                    {
                        CurrentFunction = FunctionsEnum.ScaleEntities;

                    }
                }
                CheckSnap();
                StatusLabel.Text = "Select base point";
            }



        }

        private void ribbonButton1SaveTest_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = "dxf";
            saveFileDialog1.Filter = "DXF|*.dxf";
            saveFileDialog1.FileName = "";



            saveFileDialog1.InitialDirectory = CurrentSaveDXFPath;
            if (dxfReaderNETControl1.FileName == null)
            {
                saveFileDialog1.FileName = "drawing.dxf";
            }
            else
            {
                saveFileDialog1.FileName = dxfReaderNETControl1.FileName;
            }


            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StatusLabel.Text = "";
                ErrorLabel.Text = "";

                if (dxfReaderNETControl1.WriteDXF(saveFileDialog1.FileName, DXFReaderNET.Header.DxfVersion.AutoCad2013, dxfReaderNETControl1.DXF.IsBinary))
                {
                    StatusLabel.Text = "DXF file saved";
                    ErrorLabel.Text = "";
                }
                else
                {
                    StatusLabel.Text = "Error in saving DXF file";
                }



                CurrentSaveDXFPath = Path.GetDirectoryName(saveFileDialog1.FileName);
                AddMRU(saveFileDialog1.FileName);

                SaveRegistry();
            }
        }

        private void StatusLabelGrid_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowGrid = !dxfReaderNETControl1.ShowGrid;
            ribbonButtonShowgrid.Checked = dxfReaderNETControl1.ShowGrid;
            ShowStatusLabels();
            dxfReaderNETControl1.Refresh();


        }

        private void StatusLabelOrtho_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode == 0)
            {
                dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode = 1;
            }
            else
            {
                dxfReaderNETControl1.DXF.DrawingVariables.OrthoMode = 0;
            }
            ShowStatusLabels();
        }

        private void StatusLabelSnap_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.DXF.VPorts["*Active"].SnapMode = !dxfReaderNETControl1.DXF.VPorts["*Active"].SnapMode;
            ShowStatusLabels();
        }

        private void ribbonComboBoxTextStyle_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {
                dxfReaderNETControl1.DXF.CurrentTextStyle = ((RibbonComboBox)sender).SelectedItem.Text.Trim();
            }
        }

        private void ribbonComboBoxLayout_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {
                dxfReaderNETControl1.DXF.ActiveLayout = ((RibbonComboBox)sender).SelectedItem.Text.Trim();
                dxfReaderNETControl1.Refresh();
                dxfReaderNETControl1.ZoomExtents();
                if (ribbonButtonViewTreeView.Checked)
                    RefreshTree();
            }
        }

        private void ribbonButtonDrawBlock_DropDownShowing(object sender, EventArgs e)
        {
            if (NumBlocks() == 0)
            {
                ribbonButtonDrawInsertBlock.Enabled = false;

            }
            else
            {
                ribbonButtonDrawInsertBlock.Enabled = true;

            }
        }

        private int NumBlocks()
        {
            int n = 0;
            foreach (DXFReaderNET.Blocks.Block _block in dxfReaderNETControl1.DXF.Blocks.Items)
            {
                if (_block.Entities.Count > 0 || _block.AttributeDefinitions.Count > 0)
                {
                    if (!_block.Name.StartsWith("*"))
                        n++;
                }
            }
            return n;
        }

        private void ribbonLabel6_Click(object sender, EventArgs e)
        {
            ribbonColorChooserForeColor_Click(sender, e);
        }

        private void ribbonButtonDrawEllipse_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select axis start point";
            CurrentFunction = FunctionsEnum.Ellipse1;
            LastCommand = Commands.ELLIPSE;
            CheckSnap();
        }
        int addedPat = 0;
        private void ribbonButtonDrawHatchPatterns_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = "pat";
            openFileDialog1.Filter = "Hatch Pattern definition file|*.pat|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                addedPat = 0;
                foreach (String file in openFileDialog1.FileNames)
                {
                    LoadPAT(file);
                }
            }
        }
        private void LoadPAT(string PATfilename)
        {

            List<HatchPattern> patterns = new List<HatchPattern>();
            patterns.Clear();
            patterns = dxfReaderNETControl1.ReadHatchPatternsFromFile(PATfilename);

            foreach (HatchPattern pattern in patterns)
            {
                bool namePresent = false;
                foreach (HatchPattern p2 in hatchPatternsCustom)
                {
                    if (p2.Name == pattern.Name)
                    {
                        namePresent = true;
                        break;
                    }

                }
                if (!namePresent)
                {
                    hatchPatternsCustom.Add(pattern);
                    addedPat++;
                }

            }

            StatusLabel.Text = "Added " + addedPat.ToString() + " patterns";

        }
        private void LoadLIN(string LINfilename)
        {
            List<string> newStyles = new List<string>();

            StreamReader myFile = new StreamReader(LINfilename);
            string l;

            while ((l = myFile.ReadLine()) != null)
            {
                if (l.StartsWith("*"))
                {


                    string lName = l.Split(',')[0].Substring(1).Trim();
                    newStyles.Add(lName);
                }


            }




            foreach (string lName in newStyles)
            {
                DXFReaderNET.Tables.Linetype newLinetype = DXFReaderNET.Tables.Linetype.FromFile(LINfilename, lName);
                dxfReaderNETControl1.DXF.Linetypes.Add(newLinetype);
            }



        }
        private void Form1_Resize(object sender, EventArgs e)
        {


            panelCommands.Width = 650;
            panelCommands.Left = statusStrip1.Width / 2 - panelCommands.Width / 2;
            panelCommands.Top = statusStrip1.Top - panelCommands.Height;
            labelCommands.Top = 2;
            labelCommands.Left = 0;
            txtCommand.Top = 2;

            txtCommand.BorderStyle = BorderStyle.None;


        }

        private void ribbonButtonCommandLine_Click(object sender, EventArgs e)
        {
            //labelCommands.Visible = ribbonButtonCommandLine.Checked;
            panelCommands.Visible = ribbonButtonCommandLine.Checked;
            m_showCommandLine = ribbonButtonCommandLine.Checked;
        }
        private void ShowCommandLine()
        {
            if (labelCommands.Visible)
            {
                //cmdCoord = "";
                switch (CurrentFunction)
                {
                    case FunctionsEnum.None:
                        labelCommands.Text = "";

                        break;

                    case FunctionsEnum.Slot2:
                        txtCommand.Text = "";
                        labelCommands.Text = "SLOT specify end corner:";

                        break;
                    case FunctionsEnum.Slot1:
                        txtCommand.Text = "";
                        labelCommands.Text = "SLOT specify start corner:";

                        break;
                    case FunctionsEnum.Rectangle2:
                        txtCommand.Text = "";
                        labelCommands.Text = "RECTANGLE specify end corner:";

                        break;
                    case FunctionsEnum.Rectangle1:
                        txtCommand.Text = "";
                        labelCommands.Text = "RECTANGLE specify start corner:";

                        break;
                    case FunctionsEnum.ArrayPolar:
                        txtCommand.Text = "";
                        labelCommands.Text = "POLAR ARRAY specify center:";

                        break;
                    case FunctionsEnum.Line1:
                        txtCommand.Text = "";
                        labelCommands.Text = "LINE specify start point:";

                        break;
                    case FunctionsEnum.Line2:
                        txtCommand.Text = "";
                        labelCommands.Text = "LINE specify end point:";
                        break;

                    case FunctionsEnum.Circle1:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify center:";
                        break;
                    case FunctionsEnum.Circle2:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify radius:";
                        break;
                    case FunctionsEnum.LwPolyline:
                        txtCommand.Text = "";
                        labelCommands.Text = "LWPOLYLINE specify vertex:";
                        break;
                    case FunctionsEnum.Mline:
                        txtCommand.Text = "";
                        labelCommands.Text = "MLINE specify vertex:";
                        break;

                    case FunctionsEnum.Circle2p1:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify start point of diameter:";
                        break;
                    case FunctionsEnum.Circle2p2:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify end point of diameter:";
                        break;

                    case FunctionsEnum.Circle3p1:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify first point:";
                        break;
                    case FunctionsEnum.Circle3p2:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify second point:";
                        break;
                    case FunctionsEnum.Circle3p3:
                        txtCommand.Text = "";
                        labelCommands.Text = "CIRCLE specify third point:";
                        break;

                }
                txtCommand.Left = labelCommands.Left + labelCommands.Width;
                txtCommand.Width = panelCommands.Width - txtCommand.Left;
                if (labelCommands.Text.Trim() != "")
                {
                    txtCommand.Enabled = true;
                    txtCommand.Focus();
                }
                else
                {
                    txtCommand.Enabled = false;
                    txtCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
                }
            }
        }
        private void InitStatus()
        {
            CheckContinuousSelection();
            StatusLabel.Text = "";
            SaveUndo();
            labelCommands.Text = "";
            txtCommand.Text = "";
            txtCommand.Enabled = false;
            txtCommand.BackColor = System.Drawing.SystemColors.ControlLightLight;
        }

        private void setPoint()
        {

            EntityObject ent = null;
            m_LastAddedEntity = null;
            addedMultipleEntities = false;
            switch (CurrentFunction)
            {
                case FunctionsEnum.Poly2Lw:
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {
                        InitStatus();
                        if (ent.Type == EntityType.Polyline)
                        {
                            List<LwPolylineVertex> Vertexes = new List<LwPolylineVertex>();
                            foreach (PolylineVertex v in ((Polyline)ent).Vertexes)
                            {
                                LwPolylineVertex vPl = new LwPolylineVertex();
                                vPl.Bulge = v.Bulge;
                                vPl.Position = v.Position.ToVector2();

                                Vertexes.Add(vPl);
                            }

                            double lwWid = (((Polyline)ent).StartWidth + ((Polyline)ent).EndWidth) / 2;
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.AddLightWeightPolyline(Vertexes, ((Polyline)ent).IsClosed, lwWid, ((Polyline)ent).Color.Index, ((Polyline)ent).Layer.Name, ((Polyline)ent).Linetype.Name);

                            dxfReaderNETControl1.Refresh();
                            break;
                        }
                    }
                    break;


                case FunctionsEnum.Lw2Poly:
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {
                        InitStatus();
                        if (ent.Type == EntityType.LightWeightPolyline)
                        {
                            List<PolylineVertex> VertexesP = new List<PolylineVertex>();
                            foreach (LwPolylineVertex v in ((LwPolyline)ent).Vertexes)
                            {
                                PolylineVertex vP = new PolylineVertex();
                                vP.Bulge = v.Bulge;
                                vP.Position = v.Position.ToVector3();

                                VertexesP.Add(vP);
                            }

                            double lwWid = (((LwPolyline)ent).StartWidth + ((LwPolyline)ent).EndWidth) / 2;
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.AddPolyline(VertexesP, ((LwPolyline)ent).IsClosed, lwWid, ((LwPolyline)ent).Color.Index, ((LwPolyline)ent).Layer.Name, ((LwPolyline)ent).Linetype.Name);

                            dxfReaderNETControl1.Refresh();
                            break;
                        }
                    }
                    break;
                case FunctionsEnum.Contour:

                    //CurrentFunction = FunctionsEnum.None;
                    //dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);

                    //bool isInAnotherContour = false;
                    //foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                    //{
                    //    foreach (EntityObject entity in _group.Entities)
                    //    {
                    //    }
                    //    if (_group.Entities.Contains(ent))
                    //    {
                    //        isInAnotherContour = true;
                    //        break;
                    //    }

                    //}

                    //if (!isInAnotherContour)
                    //{
                    if (ent != null)
                    {
                        DateTime StartTime = DateTime.Now;
                        List<EntityObject> contours = dxfReaderNETControl1.Contour(ent);
                        TimeSpan ElapsedTime = DateTime.Now.Subtract(StartTime);
                        toolStripStatusLabelInfo.Text = "Time: " + ElapsedTime.ToString(@"s\.fff\s");

                        //if (contours.Count > 0)
                        //{
                        //    string groupNameF = newGroupName(dxfReaderNETControl1, "CONTOUR");
                        //    DXFReaderNET.Objects.Group newGgroupF = new DXFReaderNET.Objects.Group(groupNameF);

                        foreach (EntityObject entity in contours)
                        {
                            //if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(entity))
                            //{
                            //newGgroupF.Entities.Add(entity);
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(entity);

                            dxfReaderNETControl1.HighLight(entity);
                            //}
                        }
                        //    dxfReaderNETControl1.DXF.Groups.Add(newGgroupF);
                        //    addedContours.Add(newGgroupF);
                        //    dxfReaderNETControl1.DXF.Modified = false;
                        ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        m_SelectedContours += 1;
                        StatusLabel.Text = "Select an entity of the contour. ESC to end. Selected contours: " + m_SelectedContours.ToString();
                        //}

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";

                    }
                    //}
                    //else
                    //{
                    //    StatusLabel.Text = "Contour is already defined";
                    //}
                    break;




                case FunctionsEnum.Ungroup:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {

                        bool isPresent = false;
                        DXFReaderNET.Objects.Group myGroup = new DXFReaderNET.Objects.Group();
                        foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                        {
                            if (_group.Entities.Contains(ent))
                            {
                                isPresent = true;
                                myGroup = _group;
                                break;
                            }

                        }
                        if (!isPresent)
                        {
                            StatusLabel.Text = "The selected entity is not part of a group";
                        }
                        else
                        {
                            myGroup.Entities.Clear();
                            dxfReaderNETControl1.DXF.Groups.Remove(myGroup);
                            StatusLabel.Text = "Entities ungrouped";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }

                    break;
                case FunctionsEnum.Slot2:
                    InitStatus();
                    p2 = p;
                    if (p1 != p2)
                    {

                        double r = Math.Abs(p2.Y - p1.Y) / 2;
                        Vector2 A = new Vector2(p1.X + r, p1.Y);
                        Vector2 B = new Vector2(p2.X - r, p1.Y);

                        Vector2 Ap = new Vector2(p1.X + r, p2.Y);
                        Vector2 Bp = new Vector2(p2.X - r, p2.Y);

                        if (p2.X - p1.X > 0)
                        {
                            if (Math.Abs(p2.X - p1.X) < 2 * r)
                            {
                                A = new Vector2(p1.X + r, p2.Y - r);
                                B = A;

                                Ap = A;
                                Bp = Ap;

                            }
                        }
                        else
                        {
                            if (Math.Abs(p2.X - p1.X) < 2 * r)
                            {
                                A = new Vector2(p1.X - r, p2.Y - r); ;
                                B = A;

                                Ap = A;
                                Bp = Ap;

                            }
                            else
                            {
                                A = new Vector2(p1.X - r, p1.Y);
                                B = new Vector2(p2.X + r, p1.Y);
                                Ap = new Vector2(p1.X - r, p2.Y);
                                Bp = new Vector2(p2.X + r, p2.Y);

                            }
                        }


                        List<LwPolylineVertex> polyVertexes = new List<LwPolylineVertex>();
                        polyVertexes.Add(new LwPolylineVertex(A.X, A.Y));
                        if (Vector2.Distance(A, B) != 0)
                            polyVertexes.Add(new LwPolylineVertex(B.X, B.Y));
                        polyVertexes[polyVertexes.Count - 1].Bulge = 1;
                        if (Vector2.Distance(B, Bp) != 0)
                            polyVertexes.Add(new LwPolylineVertex(Bp.X, Bp.Y));
                        if (Vector2.Distance(Bp, Ap) != 0)
                            polyVertexes.Add(new LwPolylineVertex(Ap.X, Ap.Y));
                        polyVertexes[polyVertexes.Count - 1].Bulge = 1;

                        m_LastAddedEntity = dxfReaderNETControl1.AddLightWeightPolyline(polyVertexes, true, 0, dxfReaderNETControl1.DXF.CurrentColor.Index);




                    }


                    break;
                case FunctionsEnum.Slot1:
                    CurrentFunction = FunctionsEnum.Slot2;
                    StatusLabel.Text = "Select end point";
                    p1 = p;
                    vertexes.Clear();
                    vertexes.Add(p);


                    break;
                case FunctionsEnum.Join2:
                    InitStatus();
                    p1 = p;
                    m_entTrim = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_entTrim != null)
                    {

                        if (!dxfReaderNETControl1.Join(m_entJoinBoundary, m_entTrim, p1))
                        {


                        }
                        else
                        {
                            dxfReaderNETControl1.Refresh();
                        }


                    }
                    else
                    {

                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }

                    m_entJoinBoundary = null;
                    break;
                case FunctionsEnum.Join1:
                    p1 = pNoSnap;
                    m_entJoinBoundary = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_entJoinBoundary != null)
                    {

                        dxfReaderNETControl1.HighLight(m_entJoinBoundary);
                        StatusLabel.Text = "Select second object";
                        CurrentFunction = FunctionsEnum.Join2;

                    }
                    else
                    {
                        CurrentFunction = FunctionsEnum.None;
                        CheckContinuousSelection();
                        StatusLabel.Text = "No entity found";

                    }
                    break;

                case FunctionsEnum.GradientHatchPoint:
                    InitStatus();
                    EntityObject contour = MathHelper.EntityOutsidePoint(AllVisibleEntities(), p);
                    if (contour != null)
                    {
                        Boundary.Add(MathHelper.EntityOutsidePoint(AllVisibleEntities(), p));

                        m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), Boundary, BoundaryOutermost, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);

                        if (m_GradientHatchTransparency != "0")
                        {
                            if (m_LastAddedEntity != null)
                            {
                                Hatch myHatch = dxfReaderNETControl1.DXF.Hatches[dxfReaderNETControl1.DXF.Hatches.Count - 1];
                                myHatch.Transparency = new Transparency(short.Parse(m_GradientHatchTransparency));
                            }
                        }
                    }



                    Boundary.Clear();
                    BoundaryOutermost.Clear();

                    break;
                case FunctionsEnum.HatchPoint:
                    InitStatus();
                    contour = MathHelper.EntityOutsidePoint(AllVisibleEntities(), p);
                    if (contour != null)
                    {
                        Boundary.Add(MathHelper.EntityOutsidePoint(AllVisibleEntities(), p));

                        m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, Boundary, BoundaryOutermost, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);


                    }



                    Boundary.Clear();
                    BoundaryOutermost.Clear();
                    break;
                case FunctionsEnum.RadialDimension2:

                    InitStatus();
                    switch (SelectedEntity.Type)
                    {
                        case EntityType.Arc:
                            m_LastAddedEntity = dxfReaderNETControl1.AddRadialDimension((Arc)SelectedEntity, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);
                            break;
                        case EntityType.Circle:
                            m_LastAddedEntity = dxfReaderNETControl1.AddRadialDimension((Circle)SelectedEntity, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);
                            break;
                    }


                    break;
                case FunctionsEnum.RadialDimension1:

                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Arc || ent.Type == EntityType.Circle)
                        {
                            SelectedEntity = ent;
                            StatusLabel.Text = "Select dimension position";
                            CurrentFunction = FunctionsEnum.RadialDimension2;
                        }
                        else
                        {
                            StatusLabel.Text = "Entity is not a circle or arc";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;

                case FunctionsEnum.DiametricDimension2:

                    InitStatus();
                    switch (SelectedEntity.Type)
                    {
                        case EntityType.Arc:
                            m_LastAddedEntity = dxfReaderNETControl1.AddDiametricDimension((Arc)SelectedEntity, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);
                            break;
                        case EntityType.Circle:
                            m_LastAddedEntity = dxfReaderNETControl1.AddDiametricDimension((Circle)SelectedEntity, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);
                            break;
                    }


                    break;
                case FunctionsEnum.DiametricDimension1:

                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Arc || ent.Type == EntityType.Circle)
                        {
                            SelectedEntity = ent;
                            StatusLabel.Text = "Select dimension position";
                            CurrentFunction = FunctionsEnum.DiametricDimension2;
                        }
                        else
                        {
                            StatusLabel.Text = "Entity is not a circle or arc";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;



                case FunctionsEnum.AngularDimensionCenterStartEnd4:
                    InitStatus();

                    m_LastAddedEntity = dxfReaderNETControl1.AddAngularDimension(p1.ToVector3(), p2.ToVector3(), p3.ToVector3(), p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.AngularDimensionCenterStartEnd3:
                    CheckContinuousSelection();
                    CurrentFunction = FunctionsEnum.AngularDimensionCenterStartEnd4;
                    StatusLabel.Text = "Select dimension position";
                    p3 = p;
                    break;

                case FunctionsEnum.AngularDimensionCenterStartEnd2:
                    CurrentFunction = FunctionsEnum.AngularDimensionCenterStartEnd3;
                    StatusLabel.Text = "Select end point";
                    p2 = p;
                    break;

                case FunctionsEnum.AngularDimensionCenterStartEnd1:
                    CurrentFunction = FunctionsEnum.AngularDimensionCenterStartEnd2;
                    StatusLabel.Text = "Select start point";
                    p1 = p;
                    break;


                case FunctionsEnum.AngularDimensionArc2:
                    InitStatus();

                    m_LastAddedEntity = dxfReaderNETControl1.AddAngularDimension((Arc)SelectedEntity, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.AngularDimensionArc1:


                    SelectedLine = null;
                    SelectedLine1 = null;

                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Arc)
                        {
                            SelectedEntity = ent;
                            StatusLabel.Text = "Select dimension position";
                            CurrentFunction = FunctionsEnum.AngularDimensionArc2;
                        }
                        else
                        {
                            StatusLabel.Text = "Entity is not an arc";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;


                case FunctionsEnum.AngularDimension2Lines3:
                    InitStatus();
                    m_LastAddedEntity = dxfReaderNETControl1.AddAngularDimension(SelectedLine, SelectedLine1, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.AngularDimension2Lines2:


                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Line)

                        {
                            SelectedLine1 = (Line)ent;
                            StatusLabel.Text = "Select dimension position";
                            CheckContinuousSelection();
                            CurrentFunction = FunctionsEnum.AngularDimension2Lines3;
                        }
                        else
                        {
                            StatusLabel.Text = "Entity is not a line";
                        }


                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;

                case FunctionsEnum.AngularDimension2Lines1:


                    SelectedLine = null;
                    SelectedLine1 = null;

                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Line)
                        {
                            SelectedLine = (Line)ent;
                            StatusLabel.Text = "Select second line";
                            CurrentFunction = FunctionsEnum.AngularDimension2Lines2;
                        }
                        else
                        {
                            StatusLabel.Text = "Entity is not a line";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;


                case FunctionsEnum.LinearDimensionLine2:
                    InitStatus();
                    p2 = p;

                    double dimrotation = 0;
                    if (SelectedLine.StartPoint.X < SelectedLine.EndPoint.X)
                    {
                        if (p.X > SelectedLine.EndPoint.X || p.X < SelectedLine.StartPoint.X)
                        {
                            dimrotation = 90;
                        }

                    }
                    else
                    {
                        if (p.X < SelectedLine.EndPoint.X || p.X > SelectedLine.StartPoint.X)
                        {
                            dimrotation = 90;
                        }
                    }

                    m_LastAddedEntity = dxfReaderNETControl1.AddLinearDimension(SelectedLine, p.ToVector3(), dimrotation, dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.LinearDimensionLine1:

                    p1 = p;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (SelectLineFromEntity(ent))
                        {
                            StatusLabel.Text = "Select dimension position";
                            CurrentFunction = FunctionsEnum.LinearDimensionLine2;
                        }


                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;

                case FunctionsEnum.LinearDimension3:
                    InitStatus();
                    p3 = p;

                    dimrotation = 0;

                    if (p.X > p2.X || p.X < p1.X)
                    {
                        dimrotation = 90;

                    }

                    m_LastAddedEntity = dxfReaderNETControl1.AddLinearDimension(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), p.ToVector3(), dimrotation, dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.LinearDimension2:
                    CurrentFunction = FunctionsEnum.LinearDimension3;
                    CheckContinuousSelection();
                    StatusLabel.Text = "Select dimension position";
                    p2 = p;
                    break;

                case FunctionsEnum.LinearDimension1:
                    CurrentFunction = FunctionsEnum.LinearDimension2;
                    StatusLabel.Text = "Select end point";
                    p1 = p;
                    break;


                case FunctionsEnum.AlignedDimensionLine2:
                    InitStatus();
                    p2 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddAlignedDimension(SelectedLine, p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.AlignedDimensionLine1:

                    p1 = p;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (SelectLineFromEntity(ent))
                        {
                            StatusLabel.Text = "Select dimension position";
                            CurrentFunction = FunctionsEnum.AlignedDimensionLine2;
                        }


                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;


                case FunctionsEnum.AlignedDimension3:
                    InitStatus();
                    p3 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddAlignedDimension(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), p.ToVector3(), dxfReaderNETControl1.DXF.DrawingVariables.DimStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.AlignedDimension2:
                    CurrentFunction = FunctionsEnum.AlignedDimension3;
                    CheckContinuousSelection();
                    StatusLabel.Text = "Select dimension position";
                    p2 = p;
                    break;

                case FunctionsEnum.AlignedDimension1:
                    CurrentFunction = FunctionsEnum.AlignedDimension2;
                    StatusLabel.Text = "Select end point";
                    p1 = p;
                    break;


                case FunctionsEnum.Text:
                    InitStatus();

                    p2 = p;
                    m_LastAddedEntity = dxfReaderNETControl1.AddText(m_Text, new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentTextSize, 0, TextAlignment.BaselineLeft, dxfReaderNETControl1.DXF.CurrentTextStyle, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.RotateAxis2:
                    InitStatus();
                    p2 = p;
                    double rotAngle = 180;// Vector2.Angle(p1, p2) * MathHelper.RadToDeg;
                    dxfReaderNETControl1.DXF.RotateEntitiesAboutAxis(dxfReaderNETControl1.DXF.SelectedEntities, rotAngle, p1.ToVector3(), p2.ToVector3());

                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                    break;

                case FunctionsEnum.RotateAxis1:
                    CurrentFunction = FunctionsEnum.RotateAxis2;
                    StatusLabel.Text = "Select end point of the mirror axis";
                    p1 = p;
                    break;

                case FunctionsEnum.Insert:
                    InitStatus();
                    p2 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddInsert(m_BlockName, new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), double.Parse(m_BlockRotation, System.Globalization.CultureInfo.CurrentCulture), new Vector3(double.Parse(m_BlockScale, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_BlockScale, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_BlockScale, System.Globalization.CultureInfo.CurrentCulture)));

                    break;
                case FunctionsEnum.Block:
                    InitStatus();

                    if (dxfReaderNETControl1.AddBlock(m_newBlockName, p.ToVector3(), dxfReaderNETControl1.DXF.SelectedEntities) != null)
                    {
                        StatusLabel.Text = "Block '" + m_newBlockName + "' created";
                        dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                        ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        dxfReaderNETControl1.Refresh();
                        m_newBlockName = "";
                    }

                    break;


                case FunctionsEnum.Offset2:
                    InitStatus();






                    if (dxfReaderNETControl1.Offset(m_entOffset, m_offset, p) == null)
                    {

                        StatusLabel.Text = "The selected entity is not suitable for offset";
                    }

                    CheckContinuousSelection();
                    dxfReaderNETControl1.Refresh();


                    break;

                case FunctionsEnum.Offset1:
                    CheckContinuousSelection();
                    m_entOffset = dxfReaderNETControl1.GetEntity(p);
                    if (m_entOffset != null)
                    {

                        StatusLabel.Text = "Select offset position";
                        CurrentFunction = FunctionsEnum.Offset2;

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;


                case FunctionsEnum.Trim2:
                    //InitStatus();
                    //CheckContinuousSelection();
                    m_entTrim = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_entTrim != null)
                    {

                        if (!dxfReaderNETControl1.Trim(m_entTrimBoundaries, m_entTrim, p))
                        {
                            StatusLabel.Text = "The selected  " + m_entTrim.Type.ToString() + " entity is not suitable for trim";

                        }
                        else
                        {

                            dxfReaderNETControl1.Refresh();
                        }


                    }
                    else
                    {

                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    m_entTrim = null;

                    break;
                case FunctionsEnum.Trim1:
                    //CheckContinuousSelection();
                    EntityObject boundary = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (boundary != null)
                    {
                        dxfReaderNETControl1.HighLight(boundary);
                        dxfReaderNETControl1.DXF.SelectedEntities.Add(boundary);
                        m_entTrimBoundaries.Add(boundary);

                    }
                    else
                    {

                        StatusLabel.Text = "No entity found";

                    }
                    break;


                case FunctionsEnum.Extend2:
                    //InitStatus();
                    m_entTrim = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_entTrim != null)
                    {
                        if (!dxfReaderNETControl1.Extend(m_entExtendBoundary, m_entTrim, p, true))
                        {
                            StatusLabel.Text = "The selected entity is not suitable for extend";

                        }
                        else
                        {
                            dxfReaderNETControl1.Refresh();
                        }

                    }
                    else
                    {

                        StatusLabel.Text = "No entity found";
                        //CheckContinuousSelection();
                    }

                    //m_entExtendBoundary = null;
                    break;
                case FunctionsEnum.Extend1:

                    m_entExtendBoundary = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_entExtendBoundary != null)
                    {

                        dxfReaderNETControl1.HighLight(m_entExtendBoundary);
                        StatusLabel.Text = "Select object to extend. ESC or right click to end.";
                        CurrentFunction = FunctionsEnum.Extend2;

                    }
                    else
                    {
                        CurrentFunction = FunctionsEnum.None;
                        CheckContinuousSelection();
                        StatusLabel.Text = "No entity found";

                    }
                    break;

                case FunctionsEnum.Fillet2:
                    InitStatus();
                    m_filletLine2 = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_filletLine2 != null)
                    {
                        if (!dxfReaderNETControl1.Fillet(m_filletLine1, m_filletLine2, dxfReaderNETControl1.DXF.DrawingVariables.FilletRad))
                        {
                            StatusLabel.Text = "The selected entities are not suitable for fillet";

                        }
                        else
                        {
                            dxfReaderNETControl1.Refresh();
                        }



                    }
                    else
                    {

                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }


                    break;
                case FunctionsEnum.Fillet1:

                    m_filletLine1 = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_filletLine1 != null)
                    {
                        switch (m_filletLine1.Type)
                        {
                            case EntityType.Line:
                                dxfReaderNETControl1.HighLight(m_filletLine1);
                                StatusLabel.Text = "Select second object";
                                CurrentFunction = FunctionsEnum.Fillet2;
                                break;


                            case EntityType.LightWeightPolyline:
                            case EntityType.Polyline:
                                if (!dxfReaderNETControl1.Fillet(m_filletLine1, null, dxfReaderNETControl1.DXF.DrawingVariables.FilletRad))
                                {
                                    StatusLabel.Text = "The selected polyline is not suitable for fillet";

                                }
                                else
                                {
                                    InitStatus();
                                    dxfReaderNETControl1.Refresh();
                                }

                                break;
                            default:
                                InitStatus();
                                StatusLabel.Text = "The selected object is not suitable for fillet";
                                break;

                        }


                    }
                    else
                    {
                        CurrentFunction = FunctionsEnum.None;
                        CheckContinuousSelection();
                        StatusLabel.Text = "No entity found";
                    }
                    break;

                case FunctionsEnum.Chamfer2:
                    InitStatus();
                    m_filletLine2 = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_filletLine2 != null)
                    {
                        if (!dxfReaderNETControl1.Chamfer(m_filletLine1, m_filletLine2, dxfReaderNETControl1.DXF.DrawingVariables.CHAMFERA, dxfReaderNETControl1.DXF.DrawingVariables.CHAMFERB))
                        {
                            StatusLabel.Text = "The selected entities are not suitable for chamfer";

                        }
                        else
                        {
                            dxfReaderNETControl1.Refresh();
                        }



                    }
                    else
                    {

                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }


                    break;
                case FunctionsEnum.Chamfer1:

                    m_filletLine1 = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (m_filletLine1 != null)
                    {
                        switch (m_filletLine1.Type)
                        {
                            case EntityType.Line:
                                dxfReaderNETControl1.HighLight(m_filletLine1);
                                StatusLabel.Text = "Select second line";
                                CurrentFunction = FunctionsEnum.Chamfer2;
                                break;
                            case EntityType.LightWeightPolyline:
                            case EntityType.Polyline:
                                InitStatus();



                                if (!dxfReaderNETControl1.Fillet(m_filletLine1, null, dxfReaderNETControl1.DXF.DrawingVariables.FilletRad))
                                {
                                    StatusLabel.Text = "The selected polyline is not suitable for fillet";

                                }
                                else
                                {
                                    dxfReaderNETControl1.Refresh();
                                }

                                break;


                        }


                    }
                    else
                    {
                        CurrentFunction = FunctionsEnum.None;
                        CheckContinuousSelection();
                        StatusLabel.Text = "No entity found";
                    }
                    break;


                case FunctionsEnum.ExplodeRegion:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        int nRLines = 0;
                        int nRArcs = 0;
                        switch (ent.Type)
                        {
                            case EntityType.Region:
                                List<EntityObject> newLines = new List<EntityObject>();
                                newLines = ((DXFReaderNET.Entities.Region)ent).Explode();

                                foreach (EntityObject lEnt in newLines)
                                {
                                    switch (lEnt.Type)
                                    {
                                        case EntityType.Line:
                                            nRLines++;
                                            break;
                                        case EntityType.Arc:
                                            nRArcs++;
                                            break;
                                    }

                                }
                                dxfReaderNETControl1.DXF.AddEntities(newLines);
                                dxfReaderNETControl1.DXF.RemoveEntity(ent);
                                dxfReaderNETControl1.Refresh();
                                StatusLabel.Text = "Region entity exploded into " + nRLines.ToString() + " new line(s) and " + nRArcs.ToString() + " new arc(s)";
                                break;

                            default:
                                StatusLabel.Text = "Selected entity is not a region";
                                break;
                        }


                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeInsert:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Insert)
                        {
                            List<EntityObject> insertEntities = new List<EntityObject>();
                            insertEntities = ((Insert)ent).Explode();
                            dxfReaderNETControl1.DXF.AddEntities(insertEntities);
                            //dxfReaderNETControl1.DXF.ModifyEntities(insertEntities, ((Insert)ent).Position.ToVector2(),  ((Insert)ent).Position.ToVector2() );//dxfReaderNETControl1.DXF.Blocks[((Insert)ent).Block.Name].Origin.ToVector2()-
                            //dxfReaderNETControl1.DXF.ModifyEntities(insertEntities, -dxfReaderNETControl1.DXF.Blocks[((Insert)ent).Block.Name].Origin.ToVector2());//dxfReaderNETControl1.DXF.Blocks[((Insert)ent).Block.Name].Origin.ToVector2()-
                            dxfReaderNETControl1.DXF.ModifyEntities(insertEntities, Vector2.Zero);

                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Insert entity exploded into " + insertEntities.Count.ToString() + " new entities";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not an insert";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeDimension:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Dimension)
                        {
                            int n = 0;
                            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Blocks[((Dimension)ent).Block.Name].Entities)
                            {
                                if (entity.Color.IsByBlock)
                                {
                                    entity.Color = AciColor.FromCadIndex(7);
                                }
                                dxfReaderNETControl1.DXF.AddEntity(entity);
                                n++;
                            }


                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Dimension entity exploded into " + n.ToString() + " new entities";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not an insert";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeSpline:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Spline)
                        {
                            List<EntityObject> insertEntities = new List<EntityObject>();
                            int precision = ((Spline)ent).ControlPoints.Count;

                            //if (precision < m_precision) precision = m_precision;
                            if (precision < 40) precision = 40;
                            dxfReaderNETControl1.DXF.AddEntity(((Spline)ent).ToPolyline(precision));
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Spline entity exploded into a new polyline";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not a spline";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeCircle:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Circle)
                        {
                            List<EntityObject> insertEntities = new List<EntityObject>();

                            dxfReaderNETControl1.DXF.AddEntity(((Circle)ent).ToPolyline(m_precision));
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Circle entity exploded into a new light weight polyline";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not a circle";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeArc:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Arc)
                        {

                            dxfReaderNETControl1.DXF.AddEntity(((Arc)ent).ToPolyline(m_precision));
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Arc entity exploded into a new light weight polyline";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not an Arc";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeEllipse:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Ellipse)
                        {

                            dxfReaderNETControl1.DXF.AddEntity(((Ellipse)ent).ToPolyline(m_precision));
                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Ellipse entity exploded into a new light weight polyline";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not an ellipse";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeEllipseArcs:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Ellipse)
                        {
                            LwPolyline ellipseLW = ((Ellipse)ent).ToPolyline(m_precision * 2);

                            for (int k = 0; k < ellipseLW.Vertexes.Count - 2; k += 2)
                            {

                                Vector3 sp = ellipseLW.Vertexes[k].Position.ToVector3();
                                Vector3 mp = ellipseLW.Vertexes[k + 1].Position.ToVector3();
                                Vector3 ep = ellipseLW.Vertexes[k + 2].Position.ToVector3();
                                dxfReaderNETControl1.AddArc(sp, mp, ep, ent.Color.Index);

                            }
                            if (((Ellipse)ent).IsFullEllipse)
                            {
                                Vector3 sp = ellipseLW.Vertexes[ellipseLW.Vertexes.Count - 2].Position.ToVector3();
                                Vector3 mp = ellipseLW.Vertexes[ellipseLW.Vertexes.Count - 1].Position.ToVector3();
                                Vector3 ep = ellipseLW.Vertexes[0].Position.ToVector3();
                                dxfReaderNETControl1.AddArc(sp, mp, ep, ent.Color.Index);

                            }

                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Ellipse entity exploded into " + m_precision.ToString() + " arcs";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not an ellipse";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.ExplodeCircleArcs:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Circle)
                        {
                            Circle c = (Circle)ent;
                            double sA = 360 / (double)m_precision;
                            for (double k = 0; k < m_precision; k++)
                            {
                                dxfReaderNETControl1.AddArc(c.Center, c.Radius, k * sA, (k + 1) * sA, c.Color.Index, c.Layer.Name, c.Linetype.Name);

                            }



                            dxfReaderNETControl1.DXF.RemoveEntity(ent);
                            dxfReaderNETControl1.Refresh();
                            StatusLabel.Text = "Circle entity exploded into " + m_precision.ToString() + " arcs";
                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not an circle";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;


                case FunctionsEnum.GradientHatch:
                case FunctionsEnum.Hatch:
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Circle || ent.Type == EntityType.LightWeightPolyline || ent.Type == EntityType.Polyline || ent.Type == EntityType.Line || ent.Type == EntityType.Arc || ent.Type == EntityType.Spline || ent.Type == EntityType.Ellipse)
                        {
                            Boundary.Add(ent);
                            dxfReaderNETControl1.HighLight(ent);
                        }
                    }
                    break;
                case FunctionsEnum.HatchOutermost:
                case FunctionsEnum.GradientHatchOutermost:
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Circle || ent.Type == EntityType.LightWeightPolyline || ent.Type == EntityType.Polyline || ent.Type == EntityType.Line || ent.Type == EntityType.Arc || ent.Type == EntityType.Spline || ent.Type == EntityType.Ellipse)
                        {
                            BoundaryOutermost.Add(ent);
                            dxfReaderNETControl1.HighLight(ent);
                        }
                    }
                    break;

                case FunctionsEnum.Ray2:
                    InitStatus();
                    p2 = p;
                    AddLayerIfNotPresent("AUXILIARY");
                    m_LastAddedEntity = dxfReaderNETControl1.AddRay(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X - p1.X, p2.Y - p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index, "AUXILIARY");

                    break;

                case FunctionsEnum.Ray1:
                    CurrentFunction = FunctionsEnum.Ray2;
                    StatusLabel.Text = "Select direction of ray";
                    p1 = p;
                    break;

                case FunctionsEnum.Xline2:
                    InitStatus();
                    p2 = p;
                    AddLayerIfNotPresent("AUXILIARY");
                    m_LastAddedEntity = dxfReaderNETControl1.AddXLine(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X - p1.X, p2.Y - p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index, "AUXILIARY");


                    break;

                case FunctionsEnum.Xline1:
                    CurrentFunction = FunctionsEnum.Xline2;
                    StatusLabel.Text = "Select direction of construction line";
                    p1 = p;
                    break;


                case FunctionsEnum.Circle3p3:
                    InitStatus();
                    p3 = p;
                    m_LastAddedEntity = dxfReaderNETControl1.AddCircle(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p3.X, p3.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.Circle3p2:
                    CurrentFunction = FunctionsEnum.Circle3p3;
                    StatusLabel.Text = "Select third point";
                    p2 = p;
                    break;

                case FunctionsEnum.Circle3p1:
                    CurrentFunction = FunctionsEnum.Circle3p2;
                    StatusLabel.Text = "Select second point";
                    p1 = p;
                    break;

                case FunctionsEnum.Circle2:
                    InitStatus();
                    p2 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddCircle(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), Vector2.Distance(p1, p2), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.Circle1:
                    CurrentFunction = FunctionsEnum.Circle2;
                    StatusLabel.Text = "Select radius";
                    p1 = p;
                    break;
                case FunctionsEnum.Line2:
                    InitStatus();
                    p2 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddLine(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.Line1:
                    CurrentFunction = FunctionsEnum.Line2;
                    StatusLabel.Text = "Select end point of the line";
                    p1 = p;
                    break;

                case FunctionsEnum.Leader3:
                    InitStatus();
                    p3 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddLeader(p1, p2, p3, m_Text);

                    if (m_Text != "")
                        dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.DXF.MTexts[dxfReaderNETControl1.DXF.MTexts.Count - 1]);
                    vertexes.Add(p3);
                    break;

                case FunctionsEnum.Leader2:
                    CurrentFunction = FunctionsEnum.Leader3;
                    StatusLabel.Text = "Select leader end point";
                    p2 = p;
                    vertexes.Add(p2);
                    break;
                case FunctionsEnum.Leader1:
                    CurrentFunction = FunctionsEnum.Leader2;
                    StatusLabel.Text = "Select leader next point";

                    p1 = p;
                    vertexes.Add(p1);
                    break;
                case FunctionsEnum.GradientHatchBoundaries:
                case FunctionsEnum.HatchBoundaries:
                case FunctionsEnum.Lines:
                case FunctionsEnum.Polyline:
                case FunctionsEnum.LwPolyline:
                case FunctionsEnum.PolylineLenght:
                case FunctionsEnum.Area:
                case FunctionsEnum.DrawPolygon:
                case FunctionsEnum.Mline:
                    vertexes.Add(p);
                    break;
                case FunctionsEnum.Spline:
                    HighlightPoint(Color.Red, p, 8);
                    vertexes.Add(p);
                    break;
                case FunctionsEnum.Radius:
                    InitStatus();
                    ent = dxfReaderNETControl1.GetEntity(p);
                    if (ent != null)
                    {
                        if (ent.Type == EntityType.Circle || ent.Type == EntityType.Arc)
                        {
                            if (ent.Type == EntityType.Circle)
                            {
                                StatusLabel.Text = "Radius: " + dxfReaderNETControl1.DXF.ToFormattedUnit(((Circle)ent).Radius);
                                StatusLabel.Text += " Diameter: " + dxfReaderNETControl1.DXF.ToFormattedUnit(((Circle)ent).Radius * 2);
                                StatusLabel.Text += " Area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(((Circle)ent).Radius * ((Circle)ent).Radius * MathHelper.PI);

                            }
                            if (ent.Type == EntityType.Arc)
                            {
                                StatusLabel.Text = "Radius: " + dxfReaderNETControl1.DXF.ToFormattedUnit(((Arc)ent).Radius);
                                StatusLabel.Text += " Diameter: " + dxfReaderNETControl1.DXF.ToFormattedUnit(((Arc)ent).Radius * 2);
                                StatusLabel.Text += " Lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit(((Arc)ent).Lenght);

                            }

                        }
                        else
                        {
                            StatusLabel.Text = "Selected entity is not a circle or arc";
                        }
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }

                    break;
                case FunctionsEnum.Point:
                    InitStatus();
                    m_LastAddedEntity = dxfReaderNETControl1.AddPoint(new Vector3(p.X, p.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.LocatePoint:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();

                    StatusLabel.Text = "X: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X);
                    StatusLabel.Text += " Y: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y);

                    break;
                case FunctionsEnum.GetGroupEntities:
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);

                    if (ent != null)
                    {
                        bool isPresent = false;
                        foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                        {
                            if (_group.Entities.Contains(ent))
                            {
                                foreach (EntityObject _ent in _group.Entities)
                                {

                                    if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(_ent))
                                    {
                                        dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);
                                        ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                                    }
                                    dxfReaderNETControl1.HighLight(_ent);

                                }
                                isPresent = true;

                            }

                        }
                        if (!isPresent)
                        {
                            StatusLabel.Text = "The selected entity is not part of a group";
                        }

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.GetEntity:
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {

                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                            dxfReaderNETControl1.HighLight(ent);
                        }
                        else
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Remove(ent);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                            //dxfReaderNETControl1.DrawEntity(ent);
                            dxfReaderNETControl1.Refresh();

                        }
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;
                case FunctionsEnum.MoveEnt1:
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {

                        CurrentFunction = FunctionsEnum.MoveEnt2;
                        SelectedEntity = ent;
                        p1 = p;

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }
                    break;

                case FunctionsEnum.GetEntities:
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {
                        StatusLabel.Text = EntityInfo(dxfReaderNETControl1, ent);
                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                            dxfReaderNETControl1.HighLight(ent);
                        }
                        else
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Remove(ent);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                            //dxfReaderNETControl1.DrawEntity(ent);
                            dxfReaderNETControl1.Refresh();

                        }
                    }


                    break;
                case FunctionsEnum.ListXdata:
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {
                        string strOutput = "";
                        foreach (DXFReaderNET.Tables.ApplicationRegistry appReg in dxfReaderNETControl1.DXF.ApplicationRegistries)
                        {
                            if (ent.XData.ContainsAppId(appReg.Name))
                            {
                                strOutput += "Registered Application Name: " + appReg.Name + System.Environment.NewLine;
                                foreach (XDataRecord xRec in ent.XData[appReg.Name].XDataRecord)
                                {

                                    strOutput += xRec.ToString() + System.Environment.NewLine;

                                }
                                strOutput += System.Environment.NewLine;
                            }
                        }

                        if (strOutput != "")
                        {
                            MessageBox.Show(strOutput, ent.CodeName + " " + ent.Handle + " - Extended Data");
                        }
                        else
                        {
                            StatusLabel.Text = "No extended data for entity present";
                        }
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        CheckContinuousSelection();
                    }

                    break;

                case FunctionsEnum.PrintEntityProperties:
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {
                        PrintEntityProperties(ent);
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                    }

                    break;

                case FunctionsEnum.EntityProperties:
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    if (ent != null)
                    {
                        dxfReaderNETControl1.PropertiesDialogText = "Entity properties";
                        dxfReaderNETControl1.ShowProperties(ent);
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                    }

                    break;


                case FunctionsEnum.SetLimits2:
                    InitStatus();
                    p2 = p;
                    toolStripStatusLabelInfo.Text = "";

                    dxfReaderNETControl1.SetLimits(p1, p2);
                    dxfReaderNETControl1.Refresh();
                    break;
                case FunctionsEnum.SetLimits1:
                    CurrentFunction = FunctionsEnum.SetLimits2;
                    StatusLabel.Text = "Select upper right corner";
                    p1 = p;
                    break;
                case FunctionsEnum.ZoomWindow2:
                    p2 = pNoSnap;
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    toolStripStatusLabelInfo.Text = "";
                    StatusLabel.Text = "";
                    dxfReaderNETControl1.ZoomWindow(p1, p2);
                    break;
                case FunctionsEnum.ZoomWindow1:
                    CurrentFunction = FunctionsEnum.ZoomWindow2;
                    StatusLabel.Text = "Select end point of the window";
                    p1 = pNoSnap;
                    break;

                case FunctionsEnum.Connect2:
                    p2 = pNoSnap;
                    AutoJoinEntities(dxfReaderNETControl1.GetEntities(p1, p2));
                    dxfReaderNETControl1.Refresh();
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    toolStripStatusLabelInfo.Text = "";
                    StatusLabel.Text = "";

                    break;
                case FunctionsEnum.Connect1:
                    CurrentFunction = FunctionsEnum.Connect2;
                    StatusLabel.Text = "Select end point of the window";
                    p1 = pNoSnap;
                    break;
                case FunctionsEnum.PlotWindow2:
                    p2 = pNoSnap;
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    toolStripStatusLabelInfo.Text = "";
                    StatusLabel.Text = "";
                    dxfReaderNETControl1.DXF.DrawingVariables.PLimMin = p1;
                    dxfReaderNETControl1.DXF.DrawingVariables.PLimMax = p2;

                    if (OnPlotPreview)
                    {
                        PlotPreview();
                    }
                    else
                    {
                        PlotDrawing();
                    }
                    break;
                case FunctionsEnum.PlotWindow1:
                    CurrentFunction = FunctionsEnum.PlotWindow2;
                    StatusLabel.Text = "Select end point of the ploting window";
                    p1 = pNoSnap;
                    break;



                case FunctionsEnum.ArrayPolar:
                    InitStatus();

                    toolStripStatusLabelInfo.Text = "";
                    p1 = p;
                    //p2 = MathHelper.EntitiesCenter(dxfReaderNETControl1.DXF.SelectedEntities);

                    double stepAng = 360 / (double)m_PolarArrayItems;
                    //double radius = Vector2.Distance(p2, p1);
                    for (double k = 0; k < m_PolarArrayItems; k++)
                    {


                        foreach (EntityObject entPA in dxfReaderNETControl1.DXF.SelectedEntities)
                        {
                            EntityObject newEnt = (EntityObject)entPA.Clone();
                            //dxfReaderNETControl1.DXF.ModifyEntity(ref newEnt, p1, new Vector2(p1.X + radius * Math.Cos((stepAng * k) * MathHelper.DegToRad), p1.Y + radius * Math.Sin((stepAng * k) * MathHelper.DegToRad)));
                            dxfReaderNETControl1.DXF.ModifyEntity(ref newEnt, p1, null, 1, stepAng * k);

                            dxfReaderNETControl1.DXF.AddEntity(newEnt);

                        }

                    }
                    dxfReaderNETControl1.DXF.RemoveEntities(dxfReaderNETControl1.DXF.SelectedEntities);
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                    dxfReaderNETControl1.Refresh();
                    break;

                case FunctionsEnum.Array2:
                    InitStatus();

                    p2 = p;
                    //double spacingX = Math.Abs(p2.X - p1.X);
                    //double spacingY = Math.Abs(p2.Y - p1.Y);
                    double spacingX = p2.X - p1.X;
                    double spacingY = p2.Y - p1.Y;

                    toolStripStatusLabelInfo.Text = "";



                    Vector2 displacement = Vector2.Zero;
                    //for (int k = 0; k < m_ArrayColumns; k++)
                    //{
                    //    for (int j = 0; j < m_ArrayRows; j++)

                    for (int k = 0; k < m_ArrayRows; k++)
                    {
                        for (int j = 0; j < m_ArrayColumns; j++)
                        {

                            foreach (EntityObject entA in dxfReaderNETControl1.DXF.SelectedEntities)
                            {
                                EntityObject newEnt = (EntityObject)entA.Clone();
                                dxfReaderNETControl1.DXF.ModifyEntity(ref newEnt, Vector2.Zero, displacement);
                                dxfReaderNETControl1.DXF.AddEntity(newEnt);

                            }
                            displacement.X += spacingX;
                        }
                        displacement.Y += spacingY;
                        displacement.X = 0;
                    }
                    dxfReaderNETControl1.DXF.RemoveEntities(dxfReaderNETControl1.DXF.SelectedEntities);
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                    dxfReaderNETControl1.Refresh();


                    break;
                case FunctionsEnum.Array1:
                    CurrentFunction = FunctionsEnum.Array2;

                    StatusLabel.Text = "Select end point of distance between items";
                    p1 = p;
                    break;

                case FunctionsEnum.Distance2:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();

                    p2 = p;
                    toolStripStatusLabelInfo.Text = "";


                    StatusLabel.Text = "Distance: " + dxfReaderNETControl1.DXF.ToFormattedUnit(DXFReaderNET.Vector2.Distance(p1, p2));
                    StatusLabel.Text += " Angle in XY Plane: " + dxfReaderNETControl1.DXF.ToFormattedAngle(DXFReaderNET.Vector2.Angle(p1, p2));

                    StatusLabel.Text += " ΔX: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p2.X - p1.X);
                    StatusLabel.Text += " ΔY: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p2.Y - p1.Y);


                    break;
                case FunctionsEnum.Distance1:
                    CurrentFunction = FunctionsEnum.Distance2;
                    StatusLabel.Text = "Select end point";
                    p1 = p;
                    break;


                case FunctionsEnum.Rectangle2:
                    InitStatus();
                    p2 = p;
                    if (p1 != p2)
                    {
                        if (m_RectangleFilletRadius == 0 || !(Math.Abs(p2.X - p1.X) > Math.Abs(m_RectangleFilletRadius * 2) && Math.Abs(p2.Y - p1.Y) > Math.Abs(m_RectangleFilletRadius * 2)))
                        {
                            List<LwPolylineVertex> polyVertexes = new List<LwPolylineVertex>();
                            polyVertexes.Add(new LwPolylineVertex(p1.X, p1.Y));
                            polyVertexes.Add(new LwPolylineVertex(p1.X, p2.Y));
                            polyVertexes.Add(new LwPolylineVertex(p2.X, p2.Y));
                            polyVertexes.Add(new LwPolylineVertex(p2.X, p1.Y));

                            m_LastAddedEntity = dxfReaderNETControl1.AddLightWeightPolyline(polyVertexes, true, 0, dxfReaderNETControl1.DXF.CurrentColor.Index);


                        }
                        else
                        {
                            double filletradius = 0;
                            double filletradius2 = 0;
                            double rr = m_RectangleFilletRadius;
                            if (Math.Abs(p2.X - p1.X) > rr * 2 && Math.Abs(p2.Y - p1.Y) > rr * 2)
                            {
                                filletradius = Math.Abs(rr);
                                filletradius2 = rr;
                            }

                            Vector2 pr1s = new Vector2(p1.X + filletradius, p1.Y);
                            Vector2 pr1e = new Vector2(p2.X - filletradius, p1.Y);
                            Vector2 pr2s = new Vector2(p2.X, p1.Y + filletradius);
                            Vector2 pr2e = new Vector2(p2.X, p2.Y - filletradius);
                            Vector2 pr3s = new Vector2(p2.X - filletradius, p2.Y);
                            Vector2 pr3e = new Vector2(p1.X + filletradius, p2.Y);
                            Vector2 pr4s = new Vector2(p1.X, p2.Y - filletradius);
                            Vector2 pr4e = new Vector2(p1.X, p1.Y + filletradius);
                            if ((p2.X - p1.X) < 0)
                            {
                                pr1s = new Vector2(p2.X + filletradius, p1.Y);
                                pr1e = new Vector2(p1.X - filletradius, p1.Y);

                                pr3s = new Vector2(p1.X - filletradius, p2.Y);
                                pr3e = new Vector2(p2.X + filletradius, p2.Y);

                                //pr1s = new Vector2(p2.X - filletradius, p1.Y);
                                //pr1e = new Vector2(p1.X + filletradius, p1.Y);

                                //pr3s = new Vector2(p1.X + filletradius, p2.Y);
                                //pr3e = new Vector2(p2.X - filletradius, p2.Y);


                            }
                            if ((p2.Y - p1.Y) < 0)
                            {
                                pr2e = new Vector2(p2.X, p1.Y - filletradius);
                                pr2s = new Vector2(p2.X, p2.Y + filletradius);

                                pr4e = new Vector2(p1.X, p2.Y + filletradius);
                                pr4s = new Vector2(p1.X, p1.Y - filletradius);

                                //pr2s = new Vector2(p2.X, p2.Y - filletradius);
                                //pr2e = new Vector2(p2.X, p1.Y + filletradius);

                                //pr4s = new Vector2(p1.X, p1.Y + filletradius);
                                //pr4e = new Vector2(p1.X, p2.Y - filletradius);

                            }
                            //goto salto;


                            //string groupNameR = newGroupName(dxfReaderNETControl1, "RECTANGLE");
                            //DXFReaderNET.Objects.Group newGgroupR = new DXFReaderNET.Objects.Group(groupNameR);

                            List<EntityObject> RectangleEntities = new List<EntityObject>();
                            EntityObject newEntity;

                            newEntity = dxfReaderNETControl1.AddLine(pr1s.ToVector3(), pr1e.ToVector3(), dxfReaderNETControl1.DXF.CurrentColor.Index);
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);
                            if (filletradius2 < 0)
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr1e.X - filletradius2, pr2s.Y + filletradius2, 0), filletradius, 90, 180, dxfReaderNETControl1.DXF.CurrentColor.Index);

                            }
                            else
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr1e.X, pr2s.Y, 0), filletradius, 270, 0, dxfReaderNETControl1.DXF.CurrentColor.Index);
                            }
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);

                            newEntity = dxfReaderNETControl1.AddLine(pr2s.ToVector3(), pr2e.ToVector3(), dxfReaderNETControl1.DXF.CurrentColor.Index);
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);
                            if (filletradius2 < 0)
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr3s.X - filletradius2, pr2e.Y - filletradius2, 0), filletradius, 180, 270, dxfReaderNETControl1.DXF.CurrentColor.Index);

                            }
                            else
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr3s.X, pr2e.Y, 0), filletradius, 0, 90, dxfReaderNETControl1.DXF.CurrentColor.Index);
                            }
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);

                            newEntity = dxfReaderNETControl1.AddLine(pr3s.ToVector3(), pr3e.ToVector3(), dxfReaderNETControl1.DXF.CurrentColor.Index);
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);

                            if (filletradius2 < 0)
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr3e.X + filletradius2, pr4s.Y - filletradius2, 0), filletradius, 270, 0, dxfReaderNETControl1.DXF.CurrentColor.Index);

                            }
                            else
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr3e.X, pr4s.Y, 0), filletradius, 90, 180, dxfReaderNETControl1.DXF.CurrentColor.Index);

                            }
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);

                            newEntity = dxfReaderNETControl1.AddLine(pr4s.ToVector3(), pr4e.ToVector3(), dxfReaderNETControl1.DXF.CurrentColor.Index);
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);
                            if (filletradius2 < 0)
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr1s.X + filletradius2, pr4e.Y + filletradius2, 0), filletradius, 0, 90, dxfReaderNETControl1.DXF.CurrentColor.Index);

                            }
                            else
                            {
                                newEntity = dxfReaderNETControl1.AddArc(new Vector3(pr1s.X, pr4e.Y, 0), filletradius, 180, 270, dxfReaderNETControl1.DXF.CurrentColor.Index);

                            }
                            RectangleEntities.Add((EntityObject)newEntity.Clone());
                            dxfReaderNETControl1.DXF.RemoveEntity(newEntity);
                            //newGgroupR.Entities.Add(m_LastAddedEntity);
                            m_LastAddedEntity = new LwPolyline(RectangleEntities, true);
                            ((LwPolyline)m_LastAddedEntity).Thickness = dxfReaderNETControl1.DXF.CurrentThickness;
                            ((LwPolyline)m_LastAddedEntity).Elevation = dxfReaderNETControl1.DXF.CurrentElevation;
                            m_LastAddedEntity.Layer = dxfReaderNETControl1.DXF.Layers[dxfReaderNETControl1.DXF.CurrentLayer];
                            m_LastAddedEntity.Linetype = dxfReaderNETControl1.DXF.Linetypes[dxfReaderNETControl1.DXF.CurrentLineTypeName];
                            dxfReaderNETControl1.DXF.AddEntity(m_LastAddedEntity);

                            //newGgroupR.Entities.Add(m_LastAddedEntity);
                            //dxfReaderNETControl1.DXF.Groups.Add(newGgroupR);
                            //addedMultipleEntities = true;


                            //salto:
                            //double tan90 = Math.Tan(MathHelper.HalfPI / 4);
                            //if (m_RectangleFilletRadius < 0) tan90 = -tan90;
                            //List<LwPolylineVertex> polyVertexes = new List<LwPolylineVertex>();
                            //polyVertexes.Add(new LwPolylineVertex(pr1s.X, pr1s.Y, 0));
                            //polyVertexes.Add(new LwPolylineVertex(pr1e.X, pr1e.Y, tan90));

                            //polyVertexes.Add(new LwPolylineVertex(pr2s.X, pr2s.Y, 0));
                            //polyVertexes.Add(new LwPolylineVertex(pr2e.X, pr2e.Y, tan90));

                            //polyVertexes.Add(new LwPolylineVertex(pr3s.X, pr3s.Y, 0));
                            //polyVertexes.Add(new LwPolylineVertex(pr3e.X, pr3e.Y, tan90));

                            //polyVertexes.Add(new LwPolylineVertex(pr4s.X, pr4s.Y, 0));
                            //polyVertexes.Add(new LwPolylineVertex(pr4e.X, pr4e.Y, tan90));


                            //m_LastAddedEntity = dxfReaderNETControl1.AddLightWeightPolyline(polyVertexes, true, 0, dxfReaderNETControl1.DXF.CurrentColor.Index);

                        }
                    }

                    break;

                case FunctionsEnum.Rectangle1:
                    CurrentFunction = FunctionsEnum.Rectangle2;
                    StatusLabel.Text = "Select end corner of the rectangle";
                    toolStripStatusLabelInfo.Text = "Start point: x: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.X) + "  y: " + dxfReaderNETControl1.DXF.ToFormattedUnit(p.Y);

                    p1 = p;
                    break;
                case FunctionsEnum.Trace2:
                    InitStatus();
                    p2 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddTrace(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.Trace1:
                    CurrentFunction = FunctionsEnum.Trace2;
                    StatusLabel.Text = "Select end point of the trace";
                    p1 = p;
                    break;


                case FunctionsEnum.Solid4:
                    InitStatus();
                    p4 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddSolid(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p4.X, p4.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p3.X, p3.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.Solid3:
                    CurrentFunction = FunctionsEnum.Solid4;
                    StatusLabel.Text = "Select fourth point or press right button to end";
                    p3 = p;
                    break;
                case FunctionsEnum.Solid2:
                    CurrentFunction = FunctionsEnum.Solid3;
                    StatusLabel.Text = "Select third point";
                    p2 = p;
                    break;
                case FunctionsEnum.Solid1:
                    CurrentFunction = FunctionsEnum.Solid2;
                    StatusLabel.Text = "Select second point";
                    p1 = p;
                    break;

                case FunctionsEnum.Polygon2:
                    InitStatus();
                    p2 = p;

                    m_LastAddedEntity = dxfReaderNETControl1.AddPolygon(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), Vector2.Distance(p1, p2), PolygonSides, Vector2.Angle(p1, p2) * MathHelper.RadToDeg, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.Polygon1:
                    CurrentFunction = FunctionsEnum.Polygon2;
                    StatusLabel.Text = "Select radius and rotation";
                    p1 = p;
                    break;


                case FunctionsEnum.ImageFixedSize:
                case FunctionsEnum.Image2:

                    InitStatus();
                    p2 = p;
                    double actualWidth = p2.X - p1.X;
                    double actualHeight = p2.Y - p1.Y;

                    if (CurrentFunction == FunctionsEnum.ImageFixedSize)
                    {
                        p1 = p;
                        actualWidth = m_ImageWidth;
                        actualHeight = m_ImageHeight;
                    }


                    if (!m_ImageEmbed)
                    {
                        m_LastAddedEntity = dxfReaderNETControl1.AddImage(m_ImageFileName, new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), actualWidth, actualHeight, double.Parse(m_ImageRotation, System.Globalization.CultureInfo.CurrentCulture), short.Parse(m_ImageTransparency, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    }
                    else
                    {
                        System.Drawing.Image bitmap = System.Drawing.Image.FromFile(m_ImageFileName);
                        m_LastAddedEntity = dxfReaderNETControl1.AddOle2Frame(bitmap, new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p1.X + actualWidth, p1.Y + actualHeight, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);
                    }

                    break;

                case FunctionsEnum.Image1:
                    CurrentFunction = FunctionsEnum.Image2;
                    StatusLabel.Text = "Select end corner of the image";
                    p1 = p;
                    break;


                case FunctionsEnum.PDFUnderlay:
                    InitStatus();
                    p1 = p;
                    double scale = double.Parse(m_PDFScale, System.Globalization.CultureInfo.CurrentCulture);
                    m_LastAddedEntity = dxfReaderNETControl1.AddPDFUnderlay(m_PDFFileName, new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), double.Parse(m_PDFRotation, System.Globalization.CultureInfo.CurrentCulture), new Vector3(scale, scale, 1), short.Parse(m_PDFTransparency, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index, m_PDFMonochrome);

                    break;

                case FunctionsEnum.Ellipse3:
                    InitStatus();
                    p3 = p;
                    Vector3 center = Vector2.MidPoint(p1, p2).ToVector3();
                    center.Z = dxfReaderNETControl1.DXF.CurrentElevation;
                    double rotation = Vector2.Angle(p1, p2) * MathHelper.RadToDeg;
                    double MajorAxis = Vector2.Distance(p1, p2);
                    //double MinorAxis = Vector2.Distance(center.ToVector2(), p3) * 2;
                    double MinorAxis = Vector2.Distance(Vector2.MidPoint(p1, p2), p) * 2;
                    if (MinorAxis > MajorAxis)
                    {
                        double b = MinorAxis;
                        MinorAxis = MajorAxis;
                        MajorAxis = b;
                        rotation += 90;
                    }
                    m_LastAddedEntity = dxfReaderNETControl1.AddEllipse(center, MajorAxis, MinorAxis, rotation, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.Ellipse2:
                    CurrentFunction = FunctionsEnum.Ellipse3;
                    StatusLabel.Text = "Select other axis end point";
                    p2 = p;
                    break;

                case FunctionsEnum.Ellipse1:
                    CurrentFunction = FunctionsEnum.Ellipse2;
                    StatusLabel.Text = "Select axis end point";
                    p1 = p;
                    break;

                case FunctionsEnum.Circle2p2:
                    InitStatus();
                    p2 = p;
                    center = Vector2.MidPoint(p1, p2).ToVector3();
                    center.Z = dxfReaderNETControl1.DXF.CurrentElevation;
                    m_LastAddedEntity = dxfReaderNETControl1.AddCircle(center, Vector2.Distance(p1, p2) / 2, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;

                case FunctionsEnum.Circle2p1:
                    CurrentFunction = FunctionsEnum.Circle2p2;
                    StatusLabel.Text = "Select diameter end point";
                    p1 = p;
                    break;

                case FunctionsEnum.DrawText:
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    CurrentFunction = FunctionsEnum.None;

                    p1 = p;
                    dxfReaderNETControl1.DrawText(DrawPen, m_DrawText, p1, m_DrawTextHeight, double.Parse(m_TextRotation, System.Globalization.CultureInfo.CurrentCulture), m_FontStyle, m_Alignment, ribbonButtonDrawMethodsStore.Checked);

                    break;

                case FunctionsEnum.DrawLine2:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    p2 = p;

                    dxfReaderNETControl1.DrawLine(DrawPen, p1, p2, ribbonButtonDrawMethodsStore.Checked);


                    break;

                case FunctionsEnum.DrawLine1:
                    CurrentFunction = FunctionsEnum.DrawLine2;
                    StatusLabel.Text = "Select end point of the line";
                    p1 = p;
                    break;

                case FunctionsEnum.DrawCircle2:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    p2 = p;
                    dxfReaderNETControl1.DrawCircle(DrawPen, p1, Vector2.Distance(p1, p2), ribbonButtonDrawMethodsFill.Checked, ribbonButtonDrawMethodsStore.Checked);

                    break;

                case FunctionsEnum.DrawCircle1:
                    CurrentFunction = FunctionsEnum.DrawCircle2;
                    StatusLabel.Text = "Select radius";
                    p1 = p;
                    break;
                case FunctionsEnum.Arc3:
                    InitStatus();

                    p3 = p;
                    m_LastAddedEntity = dxfReaderNETControl1.AddArc(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), Vector2.Distance(p1, p2), Vector2.Angle(p1, p2) * MathHelper.RadToDeg, Vector2.Angle(p1, p3) * MathHelper.RadToDeg, dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.Arc2:
                    CurrentFunction = FunctionsEnum.Arc3;
                    StatusLabel.Text = "Select end angle";
                    p2 = p;

                    break;

                case FunctionsEnum.Arc1:
                    CurrentFunction = FunctionsEnum.Arc2;
                    StatusLabel.Text = "Select start angle";
                    p1 = p;

                    break;



                case FunctionsEnum.ArcCenterPStartPEnd3:
                    InitStatus();

                    p3 = p;
                    m_LastAddedEntity = dxfReaderNETControl1.AddArc(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), Vector2.Distance(p1, p2), p2.ToVector3(), p3.ToVector3(), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.ArcCenterPStartPEnd2:
                    CurrentFunction = FunctionsEnum.ArcCenterPStartPEnd3;
                    StatusLabel.Text = "Select end Point";
                    p2 = p;

                    break;

                case FunctionsEnum.ArcCenterPStartPEnd1:
                    CurrentFunction = FunctionsEnum.ArcCenterPStartPEnd2;
                    StatusLabel.Text = "Select start point";
                    p1 = p;

                    break;

                case FunctionsEnum.ArcStartMiddleEnd3:
                    InitStatus();
                    p3 = p;
                    m_LastAddedEntity = dxfReaderNETControl1.AddArc(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p3.X, p3.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.ArcStartMiddleEnd2:
                    CurrentFunction = FunctionsEnum.ArcStartMiddleEnd3;
                    StatusLabel.Text = "Select end point";
                    p2 = p;

                    break;

                case FunctionsEnum.ArcStartMiddleEnd1:
                    CurrentFunction = FunctionsEnum.ArcStartMiddleEnd2;
                    StatusLabel.Text = "Select middle point";
                    p1 = p;
                    break;


                case FunctionsEnum.ArcStartEndMiddle3:
                    InitStatus();
                    p3 = p;
                    m_LastAddedEntity = dxfReaderNETControl1.AddArc(new Vector3(p1.X, p1.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p3.X, p3.Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(p2.X, p2.Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    break;
                case FunctionsEnum.ArcStartEndMiddle2:
                    CurrentFunction = FunctionsEnum.ArcStartEndMiddle3;
                    StatusLabel.Text = "Select middle point";
                    p2 = p;

                    break;

                case FunctionsEnum.ArcStartEndMiddle1:
                    CurrentFunction = FunctionsEnum.ArcStartEndMiddle2;
                    StatusLabel.Text = "Select end point";
                    p1 = p;
                    break;


                case FunctionsEnum.DrawArc3:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    p3 = p;

                    dxfReaderNETControl1.DrawArc(DrawPen, p1, Vector2.Distance(p1, p2), Vector2.Angle(p1, p2) * MathHelper.RadToDeg, Vector2.Angle(p1, p3) * MathHelper.RadToDeg, ribbonButtonDrawMethodsStore.Checked);

                    break;
                case FunctionsEnum.DrawArc2:
                    CurrentFunction = FunctionsEnum.DrawArc3;
                    StatusLabel.Text = "Select end angle";
                    p2 = p;
                    break;

                case FunctionsEnum.DrawArc1:
                    CurrentFunction = FunctionsEnum.DrawArc2;
                    StatusLabel.Text = "Select start angle";
                    p1 = p;
                    break;
                case FunctionsEnum.DrawPoint:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    p1 = p;
                    dxfReaderNETControl1.DrawPoint(DrawPen, p1, ribbonButtonDrawMethodsStore.Checked);
                    break;

                case FunctionsEnum.DrawImageFixedSize:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    p2 = p;
                    dxfReaderNETControl1.DrawImage(System.Drawing.Image.FromFile(m_ImageFileName), new Vector2(p2.X, p2.Y), m_ImageWidth, m_ImageHeight, float.Parse(m_ImageRotation, System.Globalization.CultureInfo.CurrentCulture), short.Parse(m_ImageTransparency, System.Globalization.CultureInfo.CurrentCulture), ribbonButtonDrawMethodsStore.Checked);

                    break;


                case FunctionsEnum.DrawImage2:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";
                    p2 = p;

                    dxfReaderNETControl1.DrawImage(System.Drawing.Image.FromFile(m_ImageFileName), new Vector2(p1.X, p1.Y), (float)(p2.X - p1.X), (float)(p2.Y - p1.Y), float.Parse(m_ImageRotation, System.Globalization.CultureInfo.CurrentCulture), short.Parse(m_ImageTransparency, System.Globalization.CultureInfo.CurrentCulture), ribbonButtonDrawMethodsStore.Checked);
                    break;

                case FunctionsEnum.DrawImage1:
                    CurrentFunction = FunctionsEnum.DrawImage2;
                    StatusLabel.Text = "Select end corner of the image";
                    p1 = p;
                    break;


                case FunctionsEnum.GetEntities2:

                    StatusLabel.Text = "";
                    p2 = p;

                    foreach (EntityObject entity in dxfReaderNETControl1.GetEntities(p1, p2))
                    {

                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(entity) && entity.Layer.Name.ToUpper() != "AUXILIARY")
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(entity);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        }
                    }


                    dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);
                    CheckContinuousSelection();
                    break;



                case FunctionsEnum.GetEntities1:
                    CurrentFunction = FunctionsEnum.GetEntities2;
                    StatusLabel.Text = "Select end point of selection rectangle";
                    p1 = p;
                    break;


                case FunctionsEnum.HatchRecangle2:
                    InitStatus();
                    p2 = p;

                    List<EntityObject> selectedEntities = dxfReaderNETControl1.GetEntities(p1, p2);

                    if (selectedEntities.Count() > 0)
                    {
                        List<EntityObject> externalContour = new List<EntityObject>();
                        List<EntityObject> innerEntities = new List<EntityObject>();
                        FindBoundaries(selectedEntities, out externalContour, out innerEntities);




                        m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, externalContour, innerEntities, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);

                    }


                    //m_LastAddedEntity = dxfReaderNETControl1.AddHatch(m_PatternName, Boundary, null, double.Parse(m_HatchRotation, System.Globalization.CultureInfo.CurrentCulture), double.Parse(m_HatchScale, System.Globalization.CultureInfo.CurrentCulture), dxfReaderNETControl1.DXF.CurrentColor.Index);



                    break;



                case FunctionsEnum.HatchRecangle1:
                    CurrentFunction = FunctionsEnum.HatchRecangle2;
                    StatusLabel.Text = "Select end point of selection rectangle";
                    p1 = p;
                    break;

                case FunctionsEnum.GradientHatchRectangle2:
                    InitStatus();
                    p2 = p;
                    selectedEntities = dxfReaderNETControl1.GetEntities(p1, p2);

                    if (selectedEntities.Count() > 0)
                    {
                        List<EntityObject> externalContour = new List<EntityObject>();
                        List<EntityObject> innerEntities = new List<EntityObject>();
                        FindBoundaries(selectedEntities, out externalContour, out innerEntities);




                        m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), externalContour, innerEntities, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);

                        if (m_GradientHatchTransparency != "0")
                        {
                            if (m_LastAddedEntity != null)
                            {
                                Hatch myHatch = dxfReaderNETControl1.DXF.Hatches[dxfReaderNETControl1.DXF.Hatches.Count - 1];
                                myHatch.Transparency = new Transparency(short.Parse(m_GradientHatchTransparency));
                            }
                        }
                    }



                    //m_LastAddedEntity = dxfReaderNETControl1.AddGradientHatch((HatchGradientPatternType)Enum.Parse(typeof(HatchGradientPatternType), m_GradientPatternName), Boundary, null, m_GradientAciColor1, m_GradientAciColor2, double.Parse(m_GradientHatchRotation, System.Globalization.CultureInfo.CurrentCulture), m_GradientHatchCentered);




                    break;



                case FunctionsEnum.GradientHatchRectangle1:
                    CurrentFunction = FunctionsEnum.GradientHatchRectangle2;
                    StatusLabel.Text = "Select end point of selection rectangle";
                    p1 = p;
                    break;

                case FunctionsEnum.ExplodeSplineRect2:
                    InitStatus();
                    p2 = p;
                    long n_splines = 0;
                    List<EntityObject> splines = dxfReaderNETControl1.GetEntities(p1, p2);
                    foreach (EntityObject myEnt in splines)


                    {
                        if (myEnt.Type == EntityType.Spline)
                        {
                            //int precision = (int)(((Spline)myEnt).CtrlPointTolerance / ((Spline)myEnt).FitTolerance / 10);
                            //if (precision == 0) precision = 100;


                            int precision = ((Spline)myEnt).ControlPoints.Count;
                            if (precision < 40) precision = 40;
                            //if (precision < m_precision) precision = m_precision;
                            dxfReaderNETControl1.DXF.AddEntity(((Spline)myEnt).ToPolyline(precision));
                            dxfReaderNETControl1.DXF.RemoveEntity(myEnt);
                            n_splines++;
                        }

                    }

                    dxfReaderNETControl1.Refresh();
                    StatusLabel.Text = n_splines.ToString() + " spline entities exploded into new polylines";
                    break;

                case FunctionsEnum.ExplodeSplineRect1:
                    CurrentFunction = FunctionsEnum.ExplodeSplineRect2;
                    StatusLabel.Text = "Select end point of selection rectangle";

                    p1 = p;
                    break;

                case FunctionsEnum.ExplodePoly:
                    CheckContinuousSelection();
                    ent = dxfReaderNETControl1.GetEntity(pNoSnap);
                    int nLines = 0;
                    int nArcs = 0;
                    string eType = "Lightweight polyline";
                    if (ent != null)
                    {
                        InitStatus();


                        switch (ent.Type)
                        {
                            case EntityType.LightWeightPolyline:

                                List<EntityObject> newLines = new List<EntityObject>();
                                newLines = ((LwPolyline)ent).Explode();

                                foreach (EntityObject lEnt in newLines)
                                {
                                    switch (lEnt.Type)
                                    {
                                        case EntityType.Line:
                                            nLines++;
                                            break;
                                        case EntityType.Arc:
                                            nArcs++;
                                            break;
                                    }

                                }

                                dxfReaderNETControl1.DXF.AddEntities(newLines);
                                dxfReaderNETControl1.DXF.RemoveEntity(ent);

                                break;



                            case EntityType.Polyline:
                                newLines = new List<EntityObject>();
                                newLines = ((Polyline)ent).Explode();

                                eType = "Polyline";
                                foreach (EntityObject lEnt in newLines)
                                {
                                    switch (lEnt.Type)
                                    {
                                        case EntityType.Line:
                                            nLines++;
                                            break;
                                        case EntityType.Arc:
                                            nArcs++;
                                            break;
                                    }

                                }
                                dxfReaderNETControl1.DXF.AddEntities(newLines);
                                dxfReaderNETControl1.DXF.RemoveEntity(ent);
                                break;
                        }

                        dxfReaderNETControl1.Refresh();

                        StatusLabel.Text = eType + " entity exploded into " + nLines.ToString() + " new line(s) and " + nArcs.ToString() + " new arc(s)";

                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";

                    }
                    break;

                case FunctionsEnum.ExplodePoly2:
                    Cursor.Current = Cursors.WaitCursor;
                    StatusLabel.Text = "Exploding polylines...";
                    Application.DoEvents();

                    InitStatus();
                    p2 = p;
                    int n_polylines = 0;
                    int n_lwpolylines = 0;
                    nLines = 0;
                    nArcs = 0;
                    List<EntityObject> polys = dxfReaderNETControl1.GetEntities(p1, p2);
                    foreach (EntityObject Pent in polys)
                    {

                        switch (Pent.Type)
                        {
                            case EntityType.LightWeightPolyline:
                                n_lwpolylines++;
                                List<EntityObject> newLines = new List<EntityObject>();
                                newLines = ((LwPolyline)Pent).Explode();

                                foreach (EntityObject lEnt in newLines)
                                {
                                    switch (lEnt.Type)
                                    {
                                        case EntityType.Line:
                                            nLines++;
                                            break;
                                        case EntityType.Arc:
                                            nArcs++;
                                            break;
                                    }

                                }

                                dxfReaderNETControl1.DXF.AddEntities(newLines);
                                dxfReaderNETControl1.DXF.RemoveEntity(Pent);

                                break;



                            case EntityType.Polyline:
                                newLines = new List<EntityObject>();
                                newLines = ((Polyline)Pent).Explode();
                                n_polylines++;

                                foreach (EntityObject lEnt in newLines)
                                {
                                    switch (lEnt.Type)
                                    {
                                        case EntityType.Line:
                                            nLines++;
                                            break;
                                        case EntityType.Arc:
                                            nArcs++;
                                            break;
                                    }

                                }
                                dxfReaderNETControl1.DXF.AddEntities(newLines);
                                dxfReaderNETControl1.DXF.RemoveEntity(Pent);
                                break;
                        }


                    }
                    dxfReaderNETControl1.Refresh();

                    StatusLabel.Text = n_lwpolylines.ToString() + " LwPolyline entities " + n_polylines.ToString() + " Polyline entities exploded into " + nLines.ToString() + " new line(s) and " + nArcs.ToString() + " new arc(s)";

                    Cursor.Current = Cursors.Default;
                    break;
                case FunctionsEnum.ExplodePoly1:
                    CurrentFunction = FunctionsEnum.ExplodePoly2;
                    StatusLabel.Text = "Select end point of selection rectangle";
                    p1 = p;
                    break;

                case FunctionsEnum.ExplodeInsert2:
                    Cursor.Current = Cursors.WaitCursor;
                    StatusLabel.Text = "Exploding inserts...";
                    Application.DoEvents();

                    InitStatus();
                    p2 = p;
                    int n_inserts = 0;
                    int n_entities = 0;
                    nLines = 0;
                    nArcs = 0;
                    List<EntityObject> insS = dxfReaderNETControl1.GetEntities(p1, p2);
                    foreach (EntityObject Ient in insS)
                    {
                        if (Ient.Type == EntityType.Insert)
                        {
                            List<EntityObject> insertEntities = new List<EntityObject>();
                            insertEntities = ((Insert)Ient).Explode();
                            n_inserts++;
                            dxfReaderNETControl1.DXF.AddEntities(insertEntities);
                            dxfReaderNETControl1.DXF.ModifyEntities(insertEntities, Vector2.Zero);

                            dxfReaderNETControl1.DXF.RemoveEntity(Ient);

                            n_entities += insertEntities.Count;

                        }


                    }
                    dxfReaderNETControl1.Refresh();

                    StatusLabel.Text = n_inserts.ToString() + " Insert entities exploded into " + n_entities.ToString() + " new entity(s)";

                    Cursor.Current = Cursors.Default;
                    break;

                case FunctionsEnum.ExplodeInsert1:
                    CurrentFunction = FunctionsEnum.ExplodeInsert2;
                    StatusLabel.Text = "Select end point of selection rectangle";
                    p1 = p;
                    break;
                case FunctionsEnum.MoveEntitiesRubber3:


                    InitStatus();
                    p3 = p;


                    dxfReaderNETControl1.DXF.ModifyEntities(dxfReaderNETControl1.DXF.SelectedEntities, p1, p3 - p2);
                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();

                    break;
                case FunctionsEnum.MoveEntitiesRubber2:
                    CurrentFunction = FunctionsEnum.MoveEntitiesRubber3;
                    p2 = p;
                    StatusLabel.Text = "Select traslation point";


                    foreach (EntityObject entity in dxfReaderNETControl1.GetEntities(p1, p2))
                    {

                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(entity))
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(entity);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        }
                    }

                    break;

                case FunctionsEnum.MoveEntitiesRubber1:
                    CurrentFunction = FunctionsEnum.MoveEntitiesRubber2;
                    StatusLabel.Text = "Select end point of selection rectangle";
                    p1 = p;
                    break;

                case FunctionsEnum.CopyEntities2:
                    InitStatus();
                    p2 = p;
                    List<EntityObject> newEntities = new List<EntityObject>();
                    foreach (EntityObject entity in dxfReaderNETControl1.DXF.SelectedEntities)
                    {
                        newEntities.Add((EntityObject)entity.Clone());
                    }


                    dxfReaderNETControl1.DXF.ModifyEntities(newEntities, p1, p2 - p1);
                    dxfReaderNETControl1.DXF.AddEntities(newEntities);
                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();

                    break;

                case FunctionsEnum.CopyEntities1:
                    CurrentFunction = FunctionsEnum.CopyEntities2;
                    StatusLabel.Text = "Select translation point";
                    p1 = p;
                    break;


                case FunctionsEnum.MoveEnt2:

                    InitStatus();
                    p2 = p;

                    dxfReaderNETControl1.DXF.ModifyEntity(ref SelectedEntity, p1, p2 - p1);


                    dxfReaderNETControl1.Refresh();

                    SelectedEntity = null;
                    break;

                case FunctionsEnum.MoveEntities2:
                    InitStatus();
                    p2 = p;

                    dxfReaderNETControl1.DXF.ModifyEntities(dxfReaderNETControl1.DXF.SelectedEntities, p1, p2 - p1);
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    dxfReaderNETControl1.Refresh();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();

                    break;

                case FunctionsEnum.MoveEntities1:
                    CurrentFunction = FunctionsEnum.MoveEntities2;
                    StatusLabel.Text = "Select translation point";
                    p1 = p;
                    break;


                case FunctionsEnum.RotateEntities:
                    InitStatus();
                    p1 = p;

                    dxfReaderNETControl1.DXF.ModifyEntities(dxfReaderNETControl1.DXF.SelectedEntities, p1, Vector2.Zero, 1, m_rotation);

                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();

                    break;
                case FunctionsEnum.RotateEntities2:

                    double angleRad = Vector2.Angle(p1, p);
                    m_rotation = angleRad * MathHelper.RadToDeg;


                    dxfReaderNETControl1.DXF.ModifyEntities(dxfReaderNETControl1.DXF.SelectedEntities, p1, Vector2.Zero, 1, m_rotation);

                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    InitStatus();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();


                    break;
                case FunctionsEnum.RotateEntities1:
                    CurrentFunction = FunctionsEnum.RotateEntities2;
                    StatusLabel.Text = "Select rotation";
                    p1 = p;
                    break;

                case FunctionsEnum.ScaleEntities:

                    p1 = p;

                    InitStatus();


                    dxfReaderNETControl1.DXF.ModifyEntities(dxfReaderNETControl1.DXF.SelectedEntities, p1, Vector2.Zero, m_scale, 0);

                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();

                    break;
                case FunctionsEnum.ScaleEntities2:



                    m_scale = Vector2.Distance(p1, p) / 100;
                    InitStatus();
                    dxfReaderNETControl1.DXF.ModifyEntities(dxfReaderNETControl1.DXF.SelectedEntities, p1, Vector2.Zero, m_scale, 0);

                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();

                    break;
                case FunctionsEnum.ScaleEntities1:
                    CurrentFunction = FunctionsEnum.ScaleEntities2;
                    StatusLabel.Text = "Select scale";
                    p1 = p;
                    break;

                case FunctionsEnum.PointInsidePolygon:
                    CurrentFunction = FunctionsEnum.None;
                    CheckContinuousSelection();
                    StatusLabel.Text = "";

                    if (MathHelper.PointInPolygon(dxfReaderNETControl1.DXF.SelectedEntities, p))
                    {
                        StatusLabel.Text = "Point is INSIDE selected entities";
                    }
                    else
                    {
                        StatusLabel.Text = "Point is OUTSIDE selected entities";
                    }
                    //EntityObject entFound = MathHelper.EntitiyOutsidePoint(dxfReaderNETControl1.DXF.SelectedEntities, p);
                    //if (entFound != null)
                    //{
                    //    dxfReaderNETControl1.HighLight(entFound);
                    //}
                    break;


            }


        }

        private void ribbonButtonModPropColor_Click(object sender, EventArgs e)
        {
            AciColor newColor = new AciColor();
            AciColor oldColor = new AciColor();
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 1)
            {
                oldColor = dxfReaderNETControl1.DXF.SelectedEntities[0].Color;
            }
            newColor = dxfReaderNETControl1.ShowPalette(oldColor);
            if (oldColor != newColor)
            {
                foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
                {
                    ent.Color = newColor;


                }
                dxfReaderNETControl1.Refresh();

                ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                dxfReaderNETControl1.DXF.Modified = true;
            }
        }

        private void ribbonButtonModifyProperties_DropDownShowing(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 0)
            {
                ribbonButtonModPropColor.Enabled = false;
                ribbonButtonModPropLayer.Enabled = false;
                ribbonButtonModPropLineType.Enabled = false;
                ribbonButtonModPropLineWeight.Enabled = false;
                ribbonButtonModPropGroup.Enabled = false;
                ribbonButtonModElev.Enabled = false;
                ribbonButtonModVisibilityOff.Enabled = false;

            }
            else
            {
                ribbonButtonModPropColor.Enabled = true;
                ribbonButtonModPropLayer.Enabled = true;
                ribbonButtonModPropLineType.Enabled = true;
                ribbonButtonModPropLineWeight.Enabled = true;
                ribbonButtonModPropGroup.Enabled = true;
                ribbonButtonModElev.Enabled = true;
                ribbonButtonModVisibilityOff.Enabled = true;

            }
            if (dxfReaderNETControl1.DXF.Entities.Count == 0)
            {
                ribbonButtonModVisibility.Enabled = false;


            }
            else
            {
                ribbonButtonModVisibility.Enabled = true;


            }


        }

        private void ribbonButtonModPropLayer_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            string newLayer = e.Item.Text;
            DXFReaderNET.Tables.Layer layer = dxfReaderNETControl1.DXF.Layers[newLayer];
            foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
            {

                ent.Layer = layer;


            }
            dxfReaderNETControl1.Refresh();


            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
            dxfReaderNETControl1.DXF.Modified = true;
        }

        private void ribbonButtonModPropLayer_DropDownShowing(object sender, EventArgs e)
        {
            foreach (RibbonButton layeItem in ribbonButtonModPropLayer.DropDownItems)
            {
                layeItem.Checked = false;

            }
            bool onlyOneLayer = true;
            string lName = "";
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 1)
            {

                lName = dxfReaderNETControl1.DXF.SelectedEntities[0].Layer.Name;

            }
            else
            {
                lName = dxfReaderNETControl1.DXF.SelectedEntities[0].Layer.Name;
                for (int k = 1; k < dxfReaderNETControl1.DXF.SelectedEntities.Count; k++)
                {
                    if (dxfReaderNETControl1.DXF.SelectedEntities[k].Layer.Name != lName)
                    {
                        onlyOneLayer = false;
                    }
                }
            }

            if (onlyOneLayer)
            {
                foreach (RibbonButton layeItem in ribbonButtonModPropLayer.DropDownItems)
                {

                    if (layeItem.Text == lName)
                    {
                        layeItem.Checked = true;
                    }
                }
            }
        }

        private void ribbonButtonModPropLineType_DropDownShowing(object sender, EventArgs e)
        {


            foreach (RibbonButton ltineItem in ribbonButtonModPropLineType.DropDownItems)
            {
                ltineItem.Checked = false;

            }
            bool onlyOneLtype = true;
            string ltName = "";
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 1)
            {

                ltName = dxfReaderNETControl1.DXF.SelectedEntities[0].Linetype.Name;

            }
            else
            {
                ltName = dxfReaderNETControl1.DXF.SelectedEntities[0].Linetype.Name;
                for (int k = 1; k < dxfReaderNETControl1.DXF.SelectedEntities.Count; k++)
                {
                    if (dxfReaderNETControl1.DXF.SelectedEntities[k].Linetype.Name != ltName)
                    {
                        onlyOneLtype = false;
                    }
                }
            }

            if (onlyOneLtype)
            {
                foreach (RibbonButton ltineItem in ribbonButtonModPropLineType.DropDownItems)
                {

                    if (ltineItem.Text == ltName)
                    {
                        ltineItem.Checked = true;
                    }
                }
            }
        }

        private void ribbonButtonModPropLineType_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            string newLtype = e.Item.Text;
            DXFReaderNET.Tables.Linetype ltype = dxfReaderNETControl1.DXF.Linetypes[newLtype];
            foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
            {

                ent.Linetype = ltype;


            }
            dxfReaderNETControl1.Refresh();

            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
            dxfReaderNETControl1.DXF.Modified = true;
        }


        private void ribbonButtonModPropLineWeight_DropDownShowing(object sender, EventArgs e)
        {


            foreach (RibbonButton ltineItem in ribbonButtonModPropLineWeight.DropDownItems)
            {
                ltineItem.Checked = false;

            }
            bool onlyOneLtype = true;

            Lineweight lw;
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 1)
            {

                lw = dxfReaderNETControl1.DXF.SelectedEntities[0].Lineweight;

            }
            else
            {
                lw = dxfReaderNETControl1.DXF.SelectedEntities[0].Lineweight;
                for (int k = 1; k < dxfReaderNETControl1.DXF.SelectedEntities.Count; k++)
                {
                    if (dxfReaderNETControl1.DXF.SelectedEntities[k].Lineweight != lw)
                    {
                        onlyOneLtype = false;
                    }
                }
            }

            if (onlyOneLtype)
            {
                foreach (RibbonButton ltineItem in ribbonButtonModPropLineWeight.DropDownItems)
                {

                    if (ltineItem.Text == lw.ToString())
                    {
                        ltineItem.Checked = true;
                    }
                }
            }
        }

        private void ribbonButtonModPropLineWeight_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            Lineweight newLweght;
            Enum.TryParse(e.Item.Text, out newLweght);
            foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
            {

                ent.Lineweight = newLweght;


            }
            dxfReaderNETControl1.Refresh();

            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
            dxfReaderNETControl1.DXF.Modified = true;
        }



        private void dxfReaderNETControl1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pstart = dxfReaderNETControl1.CurrentWCSpoint;
            }

            if (e.Button == MouseButtons.Middle)
            {
                dxfReaderNETControl1.Cursor = Cursors.Hand;
                panPointStart = dxfReaderNETControl1.CurrentWCSpoint;
            }

            if (e.Button == MouseButtons.Right)
            {
                if (CurrentFunction == FunctionsEnum.Orbit3D)
                {
                    CurrentFunction = FunctionsEnum.None;
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    StatusLabel.Text = "";
                    CheckContinuousSelection();
                }
            }
        }



        private void ribbonButtonInquiryXdata_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.ListXdata;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select entity";
        }

        private void dxfReaderNETControl1_DrawingStatus(object sender, DrawingStatusEventArgs e)
        {
            //if (!(CurrentFunction == FunctionsEnum.Pan))
            //{
            //    StatusLabel.Text = "Drawing DXF file " + e.Progress.ToString() + "%";
            //    Application.DoEvents();
            //}
        }

        private void dxfReaderNETControl1_ReadStatus(object sender, ReadStatusEventArgs e)
        {
            //StatusLabel.Text = "Reading DXF file " + e.Progress.ToString() + "%";

            toolStripProgressBar1.Value = e.Progress;
            //toolStripProgressBar1.Invalidate();
            //Application.DoEvents();

        }

        private void dxfReaderNETControl1_StartPlot(object sender, StartPlotEventArgs e)
        {
            StatusLabel.Text = "Plotting DXF file...";
            toolStripProgressBar1.Value = 0;
            Application.DoEvents();
        }

        private void dxfReaderNETControl1_EndPlot(object sender, EndPlotEventArgs e)
        {

            toolStripProgressBar1.Value = 0;
            StatusLabel.Text = "DXF file plotted";
            Application.DoEvents();
        }

        private void dxfReaderNETControl1_PlotStatus(object sender, PlotStatusEventArgs e)
        {
            //StatusLabel.Text = "Plotting DXF file " + e.Progress.ToString() + "%";
            //Application.DoEvents();

            toolStripProgressBar1.Value = e.Progress;
        }

        private void dxfReaderNETControl1_StartWrite(object sender, StartWriteEventArgs e)
        {
            StatusLabel.Text = "Saving DXF file...";
            toolStripProgressBar1.Value = 0;
            Application.DoEvents();
        }

        private void dxfReaderNETControl1_EndWrite(object sender, EndWriteEventArgs e)
        {

            if (ErrorLabel.Text.Trim() == "")
            {
                StatusLabel.Text = "DXF file saved";
            }
            else
            {
                StatusLabel.Text = "DXF file NOT saved";
            }
            toolStripProgressBar1.Value = 0;
            Application.DoEvents();
        }

        private void dxfReaderNETControl1_WriteStatus(object sender, WriteStatusEventArgs e)
        {
            //StatusLabel.Text = "Saving DXF file " + e.Progress.ToString() + "%";
            //Application.DoEvents();

            toolStripProgressBar1.Value = e.Progress;
        }

        private void dxfReaderNETControl1_StartDrawing(object sender, StartDrawingEventArgs e)
        {

            //StatusLabel.Text = "Drawing DXF file...";
            //Application.DoEvents();

        }

        private void dxfReaderNETControl1_StartRead(object sender, StartReadEventArgs e)
        {

            StatusLabel.Text = "Loading DXF file...";
            StatusLabel.Text = "Loading DXF file...";
            toolStripProgressBar1.Value = 0;
            Application.DoEvents();

        }

        private void dxfReaderNETControl1_Error(object sender, DXFReaderNET.ErrorEventArgs e)
        {
            ErrorLabel.Text = "";
            if (e.ErrorCode != 0)
            {
                toolStripProgressBar1.Value = 0;
                ErrorLabel.Text = "Error: " + e.ErrorCode.ToString() + " - " + e.ErrorString;
                Console.Beep(1000, 100);

            }
        }

        private void ribbonButtonModPropGroup_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            string menuText = e.Item.Text;
            if (menuText == "Add Group...")
            {
                string inputValue = "";
                if (ShowInputDialog(ref inputValue, "New group name", false) == DialogResult.OK)
                {
                    if (inputValue != "")
                    {

                        bool isPresent = false;
                        if (dxfReaderNETControl1.DXF.Groups != null)
                        {
                            foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                            {
                                if (_group.Name.Trim().ToLower() == inputValue.Trim().ToLower())
                                {
                                    isPresent = true;
                                    break;
                                }
                            }
                        }
                        if (!isPresent)
                        {
                            DXFReaderNET.Objects.Group newGgroup = new DXFReaderNET.Objects.Group(inputValue);

                            foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
                            {

                                newGgroup.Entities.Add(ent);

                            }
                            dxfReaderNETControl1.DXF.Groups.Add(newGgroup);
                            RibbonButton newItem = new RibbonButton();
                            newItem.Text = inputValue;
                            ribbonButtonModPropGroup.DropDownItems.Add(newItem);
                        }

                    }
                }
            }
            else
            {
                foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
                {

                    dxfReaderNETControl1.DXF.Groups[menuText].Entities.Add(ent);

                }

            }
        }

        private void ribbonButtonModifySelectGroup_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.GetGroupEntities;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select an entity of a group";
        }

        private void ribbonButtonModPropGroup_DropDownShowing(object sender, EventArgs e)
        {

        }

        private void ribbonButtonModifySelectHandle_Click(object sender, EventArgs e)
        {
            string handle = "";
            if (ShowInputDialog(ref handle, "Select entity with handle", false) == DialogResult.OK)
            {
                if (handle != "")
                {

                    EntityObject ent = null;
                    try
                    {
                        ent = (EntityObject)dxfReaderNETControl1.DXF.GetObjectByHandle(handle.ToUpper());
                    }
                    catch { }
                    if (ent != null)
                    {
                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        }

                        dxfReaderNETControl1.HighLight(ent);
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    }
                }
            }
        }

        private void ribbonButtonModifyExplodeRegion_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.ExplodeRegion;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select region entity";
        }

        private void ribbonButtonModyfiSelectShow_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);
        }



        private void ribbonButtonPointInPolygon_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
            {
                CurrentFunction = FunctionsEnum.PointInsidePolygon;

                StatusLabel.Text = "Select a point and check if is inside a polygon composed of selected lines, arcs and polylines";
            }
        }



        private void ribbonUpDownPickBoxSize_DownButtonClicked(object sender, MouseEventArgs e)
        {
            int value = dxfReaderNETControl1.CursorSelectionSize;
            if (value > 2) value -= 1;

            dxfReaderNETControl1.CursorSelectionSize = value;
            ribbonUpDownPickBoxSize.TextBoxText = value.ToString("##0");

        }

        private void ribbonUpDownPickBoxSize_UpButtonClicked(object sender, MouseEventArgs e)
        {
            int value = dxfReaderNETControl1.CursorSelectionSize;

            if (value < 25) value += 1;
            dxfReaderNETControl1.CursorSelectionSize = value;
            ribbonUpDownPickBoxSize.TextBoxText = value.ToString("##0");
        }

        private void ReadDXF(string dxfFileName)
        {
            //_ = dxfReaderNETControl1.ReadDXFAsync(dxfFileName);
            ErrorLabel.Text = "";
            if (dxfReaderNETControl1.ReadDXF(dxfFileName))
            //if (1==1)
            {

                InitDrawing();
                this.Text = "DXFReader.NET Component - Demo Program  - " + dxfFileName;
                AddMRU(dxfReaderNETControl1.FileName);

                CurrentLoadDXFPath = Path.GetDirectoryName(dxfFileName);
                SaveRegistry();

                if (ribbonButtonViewTreeView.Checked)
                {

                    RefreshTree();
                }
                //dxfReaderNETControl1.ZoomExtents();
                CheckContinuousSelection();
            }
            else
            {

                dxfReaderNETControl1.NewDrawing();
                InitDrawing();
                StatusLabel.Text = "Error in reading DXF file";
            }
        }

        private void ribbonButtonModifyRemoveBlocks_Click(object sender, EventArgs e)
        {
            RemoveUnUsedBlocks(dxfReaderNETControl1);

        }

        private void ribbonPanelHelp_ButtonMoreClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to unregister DXFReader.NET?", "DXFReader.NET Demo Program - Unregister DXFReader.NET", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dxfReaderNETControl1.UnRegisterComponent();
            }
        }

        private void ribbonButtonModifyTrim_Click(object sender, EventArgs e)
        {
            SaveUndo();
            CurrentFunction = FunctionsEnum.Trim1;
            m_entTrimBoundaries = new List<EntityObject>();
            dxfReaderNETControl1.DXF.SelectedEntities.Clear();
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select boundary objects. ESC or right click to end boundaries selection.";
        }

        private void ribbonButtonModifyExtend_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Extend1;

            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select boundary object";
        }

        private void ribbonButtonModifyFillet_Click(object sender, EventArgs e)
        {
            string inputValue = dxfReaderNETControl1.DXF.DrawingVariables.FilletRad.ToString();
            if (ShowInputDialog(ref inputValue, "Fillet radius", true) == DialogResult.OK)
            {
                double FilletRad = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (FilletRad >= 0)
                {
                    dxfReaderNETControl1.DXF.DrawingVariables.FilletRad = FilletRad;
                    CurrentFunction = FunctionsEnum.Fillet1;
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
                    StatusLabel.Text = "Select first object";
                }
            }
        }

        private void ribbonButtonDrawingLimits_Click(object sender, EventArgs e)
        {

            StatusLabel.Text = "Select lower left corner";
            CheckSnap();
            CurrentFunction = FunctionsEnum.SetLimits1;
        }

        internal enum PointShapeEnum
        {
            Square,
            Circle,
            Triangle,
            Cross
        }
        private void HighlightPoint(Color Color, Vector2 Position, int Size = 6, PointShapeEnum shape = PointShapeEnum.Square)
        {
            float s = dxfReaderNETControl1.PixelToWorld(Size);

            Pen myPen = new Pen(Color, 0);
            myPen.Width = 0F;
            switch (shape)
            {
                case PointShapeEnum.Circle:
                    dxfReaderNETControl1.DrawCircle(new Pen(Color, 0), Position, s / 2, false, false);
                    break;
                case PointShapeEnum.Square:
                    List<Vector2> vertexes = new List<Vector2>();

                    vertexes.Add(new Vector2(Position.X - s / 2, Position.Y - s / 2));
                    vertexes.Add(new Vector2(Position.X - s / 2 + s, Position.Y - s / 2));
                    vertexes.Add(new Vector2(Position.X - s / 2 + s, Position.Y - s / 2 + s));
                    vertexes.Add(new Vector2(Position.X - s / 2, Position.Y - s / 2 + s));
                    dxfReaderNETControl1.DrawPolygon(myPen, vertexes, false, false);
                    break;
                case PointShapeEnum.Triangle:
                    vertexes = new List<Vector2>();


                    double stepAng = (double)360 / 3;
                    for (double k = 0; k < 3; k++)
                    {

                        vertexes.Add(new Vector2(Position.X + s / 2 * Math.Cos((stepAng * k) * MathHelper.DegToRad), Position.Y + s / 2 * Math.Sin((stepAng * k) * MathHelper.DegToRad)));
                    }


                    dxfReaderNETControl1.DrawPolygon(myPen, vertexes, false, false);
                    break;
                case PointShapeEnum.Cross:
                    dxfReaderNETControl1.DrawLine(myPen, new Vector2(Position.X - s / 2, Position.Y - s / 2), new Vector2(Position.X - s / 2 + s, Position.Y - s / 2 + s));
                    dxfReaderNETControl1.DrawLine(myPen, new Vector2(Position.X - s / 2 + s, Position.Y - s / 2), new Vector2(Position.X - s / 2, Position.Y - s / 2 + s));

                    break;
            }
        }

        private void ribbonUpDownRubberPenWidth_DownButtonClicked(object sender, MouseEventArgs e)
        {
            int value = dxfReaderNETControl1.RubberBandPenWidth;
            if (value > 0) value -= 1;

            dxfReaderNETControl1.RubberBandPenWidth = value;
            ribbonUpDownRubberPenWidth.TextBoxText = value.ToString("##0");
        }

        private void ribbonUpDownRubberPenWidth_UpButtonClicked(object sender, MouseEventArgs e)
        {
            int value = dxfReaderNETControl1.RubberBandPenWidth;

            if (value < 25) value += 1;
            dxfReaderNETControl1.RubberBandPenWidth = value;
            ribbonUpDownRubberPenWidth.TextBoxText = value.ToString("##0");
        }
        private List<EntityObject> AllVisibleEntities()
        {
            List<EntityObject> allEnts = new List<EntityObject>();
            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {
                if (ent.IsVisible && dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsVisible && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsFrozen && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsLocked)
                {

                    allEnts.Add(ent);
                }
            }
            return allEnts;
        }
        private void ribbonButtonInquiryMeasureAreaSelected_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
            {
                double area = 0;
                double lenght = 0;

                //MathHelper.PolygonArea(vertexes)
                //(MathHelper.PolygonLenght(vertexes, true))

                foreach (EntityObject entity in dxfReaderNETControl1.DXF.SelectedEntities)
                {
                    switch (entity.Type)
                    {
                        case EntityType.Line:
                            lenght += ((Line)entity).Lenght;
                            break;
                        case EntityType.Arc:

                            lenght += ((Arc)entity).Lenght;
                            break;
                        case EntityType.Circle:
                            lenght += ((Circle)entity).Lenght;
                            area += ((Circle)entity).Area;

                            break;
                        case EntityType.Ellipse:
                            lenght += ((Ellipse)entity).Lenght;
                            area += ((Ellipse)entity).Area;

                            break;
                        case EntityType.LightWeightPolyline:
                            lenght += ((LwPolyline)entity).Lenght;
                            area += ((LwPolyline)entity).Area;
                            break;
                        case EntityType.Polyline:
                            lenght += ((Polyline)entity).Lenght;
                            area += ((Polyline)entity).Area;
                            break;

                        case EntityType.Spline:
                            lenght += ((Spline)entity).ToPolyline(100).Lenght;
                            area += ((Spline)entity).ToPolyline(100).Area;
                            break;
                    }
                }
                StatusLabel.Text = "Area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(area) + " Lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit(lenght);

            }


        }
        private void SaveUndo()
        {

            UnDoStack.Push(dxfReaderNETControl1.DXF.ToString());


            ribbonButtonUndo.Enabled = (UnDoStack.Count > 0);
            ribbonButtonRedo.Enabled = (ReDoStack.Count > 0);

        }


        private void UnDo()
        {
            if (UnDoStack.Count > 0)
            {

                ReDoStack.Push(dxfReaderNETControl1.DXF.ToString());
                dxfReaderNETControl1.DXF = dxfReaderNETControl1.DXF.FromString(UnDoStack.Pop());
                Refresh();
            }
            ribbonButtonUndo.Enabled = (UnDoStack.Count > 0);
            ribbonButtonRedo.Enabled = (ReDoStack.Count > 0);


        }
        private void ReDo()
        {
            if (ReDoStack.Count > 0)
            {
                UnDoStack.Push(dxfReaderNETControl1.DXF.ToString());
                dxfReaderNETControl1.DXF = dxfReaderNETControl1.DXF.FromString(ReDoStack.Pop());

                Refresh();
            }
            ribbonButtonUndo.Enabled = (UnDoStack.Count > 0);
            ribbonButtonRedo.Enabled = (ReDoStack.Count > 0);

        }
        private void ribbonButtonModifyArray_Click(object sender, EventArgs e)
        {
            string inputValue = m_ArrayColumns.ToString();
            if (ShowInputDialog(ref inputValue, "# of colums", true) == DialogResult.OK)
            {
                m_ArrayColumns = short.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (m_ArrayColumns > 0)
                {
                    inputValue = m_ArrayRows.ToString();
                    if (ShowInputDialog(ref inputValue, "# of rows", true) == DialogResult.OK)
                    {
                        m_ArrayRows = short.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                        if (m_ArrayRows > 1)
                        {
                            CurrentFunction = FunctionsEnum.Array1;
                            CheckSnap();


                            StatusLabel.Text = "Select start point of distance between items";
                        }
                    }

                }
            }
        }

        private void ribbonButtonModifyArrayPolar_Click(object sender, EventArgs e)
        {
            string inputValue = m_PolarArrayItems.ToString();
            if (ShowInputDialog(ref inputValue, "# of items", true) == DialogResult.OK)
            {
                m_PolarArrayItems = short.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (m_ArrayColumns > 1)
                {

                    CurrentFunction = FunctionsEnum.ArrayPolar;
                    CheckSnap();


                    StatusLabel.Text = "Select center point";
                }

            }
        }

        private void ribbonButtonShowFilledAreas_Click(object sender, EventArgs e)
        {
            SaveUndo();
            StatusLabel.Text = "";
            DateTime StartTime = DateTime.Now;
            //explode all inserts
            foreach (Insert i in dxfReaderNETControl1.DXF.Inserts)
            {
                List<EntityObject> insertEntities = i.Explode();
                dxfReaderNETControl1.DXF.AddEntities(insertEntities);
                dxfReaderNETControl1.DXF.ModifyEntities(insertEntities, Vector2.Zero);

            }

            List<EntityObject> entitesToDelete = new List<EntityObject>();
            List<EntityObject> allEntities = new List<EntityObject>();

            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
            {

                switch (entity.Type)
                {
                    case EntityType.Line:
                    case EntityType.Arc:
                    case EntityType.Circle:
                    case EntityType.Ellipse:
                    case EntityType.LightWeightPolyline:
                    case EntityType.Polyline:
                    case EntityType.Spline:

                        allEntities.Add(entity);
                        break;
                    default:
                        entitesToDelete.Add(entity);
                        break;
                }
            }

            //if (dxfReaderNETControl1.DXF.NotConnectedPoints(allEntities).Count == 0)
            //{


            dxfReaderNETControl1.DXF.RemoveEntities(entitesToDelete);

            RemoveUnUsedBlocks(dxfReaderNETControl1);
            ChangeNormalVector(dxfReaderNETControl1);


            ShowFilledAreas(dxfReaderNETControl1, allEntities);



            int InternalCountoursNumber = 0;
            double ExternalLenght = 0;
            double ExternalArea = 0;
            double InternalLenght = 0;
            double InternalArea = 0;
            bool ret = MathHelper.FindClosedAreaData(allEntities, out ExternalLenght, out ExternalArea, out InternalLenght, out InternalArea, out InternalCountoursNumber);


            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.DXF.Modified = false;

            if (ret)
            {
                TimeSpan ElapsedTime = DateTime.Now.Subtract(StartTime);
                StatusLabel.Text = "Time: " + ElapsedTime.ToString(@"s\.fff\s");
                StatusLabel.Text += " Ext. lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit(ExternalLenght);
                StatusLabel.Text += " Ext. area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(ExternalArea);
                StatusLabel.Text += " Int. lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit(InternalLenght);
                StatusLabel.Text += " Int. area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(InternalArea);
                StatusLabel.Text += " Filled area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(ExternalArea - InternalArea);
                StatusLabel.Text += " Int. countours #: " + InternalCountoursNumber.ToString();

            }

            else
            {
                StatusLabel.Text = "Closed area not found";
            }
            //}

            //else
            //{
            //    StatusLabel.Text = "There are not connected points";
            //}
        }
        private void RemoveUnUsedBlocks(DXFReaderNETControl myDXF)
        {
            List<DXFReaderNET.Blocks.Block> usedBlocks = new List<DXFReaderNET.Blocks.Block>();
            foreach (Insert insert in myDXF.DXF.Inserts)
            {
                if (!usedBlocks.Contains(insert.Block))
                    usedBlocks.Add(insert.Block);
            }
            foreach (Dimension dimension in myDXF.DXF.Dimensions)
            {
                if (!usedBlocks.Contains(dimension.Block))
                    usedBlocks.Add(dimension.Block);
            }
            List<DXFReaderNET.Blocks.Block> unUsedBlocks = new List<DXFReaderNET.Blocks.Block>();
            foreach (DXFReaderNET.Blocks.Block block in myDXF.DXF.Blocks)
            {
                if (!usedBlocks.Contains(block))
                    unUsedBlocks.Add(block);
            }

            bool AtLeastOneBlockRemoved = false;
            foreach (DXFReaderNET.Blocks.Block block in unUsedBlocks)
            {
                if (!block.Name.Contains("*Model_Space") && !block.Name.Contains("*Paper_Space"))
                {
                    myDXF.DXF.RemoveBlock(block);
                    AtLeastOneBlockRemoved = true;
                }

            }
            if (AtLeastOneBlockRemoved)
            {
                myDXF.DXF.Modified = true;
            }
        }
        private void ExplodeAllInserts(DXFReaderNETControl myDXF)
        {
            do
            {
                List<EntityObject> insertEntities = new List<EntityObject>();
                List<EntityObject> entitesToDelete = new List<EntityObject>();
                foreach (Insert insert in myDXF.DXF.Inserts)
                {
                    insertEntities.AddRange(insert.Explode());
                    entitesToDelete.Add(insert);

                }
                dxfReaderNETControl1.DXF.AddEntities(insertEntities);
                dxfReaderNETControl1.DXF.RemoveEntities(entitesToDelete);
            } while (myDXF.DXF.Inserts.Count() > 0);
        }
        private void ChangeNormalVector(DXFReaderNETControl myDXF)
        {

            List<EntityObject> allEntities = new List<EntityObject>();
            foreach (EntityObject entity in myDXF.DXF.Entities)
            {
                //if (entity.Normal == new Vector3(0,0,-1))
                if (entity.Normal != new Vector3(0, 0, 1))
                {
                    bool uniVector = false;
                    if (Math.Abs(entity.Normal.X) == 1 || Math.Abs(entity.Normal.Y) == 1 || Math.Abs(entity.Normal.Z) == 1)
                        uniVector = true;
                    switch (entity.Type)
                    {
                        case EntityType.Polyline:
                            List<PolylineVertex> polyvertexes = new List<PolylineVertex>();
                            foreach (PolylineVertex v in ((Polyline)entity).Vertexes)
                            {
                                Vector3 vp = MathHelper.Transform(v.Position, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                PolylineVertex vpv = new PolylineVertex(vp);
                                vpv.Bulge = v.Bulge;
                                polyvertexes.Add(vpv);
                            }
                            myDXF.AddPolyline(polyvertexes, ((Polyline)entity).IsClosed, ((Polyline)entity).StartWidth, entity.Color.Index, entity.Layer.Name);
                            allEntities.Add(entity);
                            break;
                        case EntityType.LightWeightPolyline:
                            List<LwPolylineVertex> lwpolyvertexes = new List<LwPolylineVertex>();
                            foreach (LwPolylineVertex v in ((LwPolyline)entity).Vertexes)
                            {
                                Vector3 vp = MathHelper.Transform(v.Position.ToVector3(), entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                lwpolyvertexes.Add(new LwPolylineVertex(vp.X, vp.Y, v.Bulge));
                            }
                            myDXF.AddLightWeightPolyline(lwpolyvertexes, ((LwPolyline)entity).IsClosed, ((LwPolyline)entity).StartWidth, entity.Color.Index, entity.Layer.Name);
                            allEntities.Add(entity);
                            break;
                        case EntityType.Arc:

                            if (uniVector)
                            {
                                Vector3 sp = MathHelper.Transform(((Arc)entity).StartPoint, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                Vector3 mp = MathHelper.Transform(((Arc)entity).MidPoint, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                Vector3 ep = MathHelper.Transform(((Arc)entity).EndPoint, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                //Vector3 cp = MathHelper.Transform(((Arc)entity).Center, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);

                                //double r1 = 0.001;
                                //myDXF.DrawCircle(new Pen(Color.Red), sp.ToVector2(), r1, false, true);
                                //myDXF.DrawCircle(new Pen(Color.Red), mp.ToVector2(), r1, false, true);
                                //myDXF.DrawCircle(new Pen(Color.Red), ep.ToVector2(), r1, false, true);
                                //myDXF.DrawCircle(new Pen(Color.Magenta ), cp.ToVector2(), r1, false, true);


                                //myDXF.AddArc(cp, Vector3.Distance(cp, sp), Vector2.Angle(cp.ToVector2(), sp.ToVector2()) * MathHelper.RadToDeg, Vector2.Angle(cp.ToVector2(), ep.ToVector2()) * MathHelper.RadToDeg, dxfReaderNETControl1.DXF.CurrentColor.Index);


                                myDXF.AddArc(sp, mp, ep, entity.Color.Index, entity.Layer.Name);

                            }
                            else
                            {
                                LwPolyline ArcoPoly = ((Arc)entity).ToPolyline(36);
                                lwpolyvertexes = new List<LwPolylineVertex>();
                                foreach (LwPolylineVertex v in ArcoPoly.Vertexes)
                                {
                                    Vector3 vp = MathHelper.Transform(v.Position.ToVector3(), entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                    lwpolyvertexes.Add(new LwPolylineVertex(vp.X, vp.Y));
                                }
                                myDXF.AddLightWeightPolyline(lwpolyvertexes, false, 0, entity.Color.Index, entity.Layer.Name);
                            }

                            allEntities.Add(entity);
                            break;
                        case EntityType.Line:
                            //Vector3 spL = MathHelper.Transform(((Line)entity).StartPoint, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);

                            //Vector3 epL = MathHelper.Transform(((Line)entity).EndPoint, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                            //myDXF.AddLine(spL, epL, entity.Color.Index, entity.Layer.Name);
                            //allEntities.Add(entity);
                            break;
                        case EntityType.Point:
                            Vector3 spP = MathHelper.Transform(((DXFReaderNET.Entities.Point)entity).Position, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);

                            myDXF.AddPoint(spP, entity.Color.Index, entity.Layer.Name);
                            allEntities.Add(entity);
                            break;
                        case EntityType.Circle:
                            if (uniVector)
                            {
                                Vector3 c = MathHelper.Transform(((Circle)entity).Center, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                double r = ((Circle)entity).Radius;


                                myDXF.AddCircle(c, r, entity.Color.Index, entity.Layer.Name);
                            }
                            else
                            {
                                LwPolyline cerchioPoly = ((Circle)entity).ToPolyline(36);


                                lwpolyvertexes = new List<LwPolylineVertex>();
                                foreach (LwPolylineVertex v in cerchioPoly.Vertexes)
                                {
                                    Vector3 vp = MathHelper.Transform(v.Position.ToVector3(), entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                    lwpolyvertexes.Add(new LwPolylineVertex(vp.X, vp.Y));
                                }
                                myDXF.AddLightWeightPolyline(lwpolyvertexes, true, 0, entity.Color.Index, entity.Layer.Name);

                            }

                            allEntities.Add(entity);
                            break;

                        case EntityType.Ellipse:
                            if (uniVector)
                            {
                                Vector3 c = MathHelper.Transform(((Ellipse)entity).Center, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                //double r = ((Circle)entity).Radius;
                                Vector3 mjp = ((Ellipse)entity).Center + new Vector3(((Ellipse)entity).MinorAxis / 2 * Math.Cos(((Ellipse)entity).Rotation * MathHelper.DegToRad), ((Ellipse)entity).MinorAxis / 2 * Math.Sin(((Ellipse)entity).Rotation * MathHelper.DegToRad), 0);
                                Vector3 mjpr = MathHelper.Transform(mjp, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                double newrot = 90 - Vector2.Angle(((Ellipse)entity).Center.ToVector2(), mjpr.ToVector2()) * MathHelper.RadToDeg;
                                myDXF.AddEllipse(((Ellipse)entity).Center, ((Ellipse)entity).MajorAxis, ((Ellipse)entity).MinorAxis, newrot, entity.Color.Index, entity.Layer.Name);

                            }
                            else
                            {
                                LwPolyline myPoly = new LwPolyline();
                                myPoly = ((Ellipse)entity).ToPolyline(36);




                                lwpolyvertexes = new List<LwPolylineVertex>();
                                foreach (LwPolylineVertex v in myPoly.Vertexes)
                                {
                                    Vector3 vp = MathHelper.Transform(v.Position.ToVector3(), entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                    lwpolyvertexes.Add(new LwPolylineVertex(vp.X, vp.Y));
                                }
                                myDXF.AddLightWeightPolyline(lwpolyvertexes, true, 0, entity.Color.Index, entity.Layer.Name);
                            }
                            allEntities.Add(entity);
                            break;
                        case EntityType.Spline:
                            Polyline spliPoly = ((Spline)entity).ToPolyline(36);
                            polyvertexes = new List<PolylineVertex>();
                            foreach (PolylineVertex v in spliPoly.Vertexes)
                            {
                                Vector3 vp = MathHelper.Transform(v.Position, entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                polyvertexes.Add(new PolylineVertex(vp));
                            }
                            myDXF.AddPolyline(polyvertexes, ((Spline)entity).IsClosed, 0, entity.Color.Index, entity.Layer.Name);
                            allEntities.Add(entity);
                            break;
                        case EntityType.Leader:

                            for (int k = 0; k < ((Leader)entity).Vertexes.Count; k++)
                            {
                                Vector3 vp = MathHelper.Transform(((Leader)entity).Vertexes[k].ToVector3(), entity.Normal, CoordinateSystem.Object, CoordinateSystem.World);
                                ((Leader)entity).Vertexes[k] = vp.ToVector2();
                            }
                            entity.Normal = Vector3.UnitZ;
                            break;
                        default:
                            entity.Normal = Vector3.UnitZ;
                            break;
                    }


                }

            }

            myDXF.DXF.RemoveEntities(allEntities);
        }


        private void ShowFilledAreas(DXFReaderNETControl myDXF, List<EntityObject> entities)
        {


            AddLayerIfNotPresent("SERVICE");




            DeleteAllEntitiesInServiceLayer(myDXF);
            List<EntityObject> externalContour = MathHelper.ExternalContour(entities);

            List<EntityObject> allEntities = new List<EntityObject>();
            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
            {
                if (!externalContour.Contains(entity))
                    allEntities.Add(entity);
            }

            List<LwPolyline> lws = dxfReaderNETControl1.EntitiesToLwPolylines(allEntities);

            List<EntityObject> BoundaryOutermost = new List<EntityObject>();
            foreach (LwPolyline l in lws)
            {

                BoundaryOutermost.Add(l);
            }

            // EntityObject myEnt = myDXF.AddHatch("SOLID", externalContour, BoundaryOutermost, 0, 1, AciColor.Red.Index, "SERVICE");

            EntityObject myEnt = myDXF.AddGradientHatch(HatchGradientPatternType.Cylinder, externalContour, BoundaryOutermost, 140, 180, 30, true, "SERVICE");

            if (myEnt != null)
            {
                Hatch myHatch = myDXF.DXF.Hatches[myDXF.DXF.Hatches.Count - 1];
                myHatch.Transparency = new Transparency(20);
            }


        }

        private static void DeleteAllEntitiesInServiceLayer(DXFReaderNETControl myDXF)
        {
            List<EntityObject> toDelete = new List<EntityObject>();
            foreach (EntityObject ent in myDXF.DXF.Entities)
            {

                if (ent.Layer.Name == "SERVICE")
                {
                    toDelete.Add(ent);
                }

            }
            if (toDelete.Count > 0)
            {
                myDXF.DXF.RemoveEntities(toDelete);

            }
        }
        private void ribbonButtonModElev_Click(object sender, EventArgs e)
        {
            string inputValue = dxfReaderNETControl1.DXF.CurrentElevation.ToString();
            if (ShowInputDialog(ref inputValue, "New elevation", true) == DialogResult.OK)
            {
                double newElev = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                inputValue = dxfReaderNETControl1.DXF.CurrentThickness.ToString();
                if (ShowInputDialog(ref inputValue, "New thickness", true) == DialogResult.OK)
                {
                    double newThick = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                    foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
                    {
                        Vector3 p = new Vector3();
                        switch (ent.Type)
                        {
                            case EntityType.Line:
                                ((Line)ent).Thickness = newThick;
                                p = new Vector3(((Line)ent).StartPoint.X, ((Line)ent).StartPoint.Y, newElev);
                                ((Line)ent).StartPoint = p;

                                p = new Vector3(((Line)ent).EndPoint.X, ((Line)ent).EndPoint.Y, newElev);
                                ((Line)ent).EndPoint = p;

                                break;

                            case EntityType.Arc:
                                ((Arc)ent).Thickness = newThick;
                                p = new Vector3(((Arc)ent).Center.X, ((Arc)ent).Center.Y, newElev);
                                ((Arc)ent).Center = p;
                                break;
                            case EntityType.Circle:
                                ((Circle)ent).Thickness = newThick;
                                p = new Vector3(((Circle)ent).Center.X, ((Circle)ent).Center.Y, newElev);
                                ((Circle)ent).Center = p;
                                break;


                            case EntityType.Ellipse:
                                ((Ellipse)ent).Thickness = newThick;
                                p = new Vector3(((Ellipse)ent).Center.X, ((Ellipse)ent).Center.Y, newElev);
                                ((Ellipse)ent).Center = p;
                                break;
                            case EntityType.Spline:
                                //((Spline)ent).Thickness = newThick;

                                break;
                            case EntityType.LightWeightPolyline:
                                ((LwPolyline)ent).Elevation = newElev;
                                ((LwPolyline)ent).Thickness = newThick;
                                break;
                            case EntityType.Polyline:
                                int n = 0;
                                ((Polyline)ent).Thickness = newThick;
                                for (n = 0; n < ((Polyline)ent).Vertexes.Count; n++)
                                {

                                    ((Polyline)ent).Vertexes[n].Position = new Vector3(((Polyline)ent).Vertexes[n].Position.X, ((Polyline)ent).Vertexes[n].Position.Y, newElev); ;
                                }

                                break;

                        }


                    }
                    dxfReaderNETControl1.Refresh();

                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                    dxfReaderNETControl1.DXF.Modified = true;
                }
            }
        }

        private void ribbonButtonHighlight_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.HighlightEntityOnHover = ribbonButtonHighlight.Checked;
            //dxfReaderNETControl1.Refresh();
        }



        private void DeleteTypedEntities(string entityType)
        {

            List<EntityObject> EntitiesToDelete = new List<EntityObject>();
            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
            {

                if (entity.CodeName == entityType)
                {
                    EntitiesToDelete.Add(entity);
                }

            }

            dxfReaderNETControl1.DXF.RemoveEntities(EntitiesToDelete);



        }
        private void AddLayerIfNotPresent(string layername)
        {
            bool isPresent = false;
            foreach (DXFReaderNET.Tables.Layer _layer in dxfReaderNETControl1.DXF.Layers)
            {
                if (_layer.Name.Trim().ToUpper() == layername)
                {
                    isPresent = true;
                }

            }
            if (!isPresent)
                dxfReaderNETControl1.AddLayer(layername);
        }


        private void ribbonButtonDeleteSelectedEntities_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();


            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {
                string codeName = ent.CodeName;
                if (codeName == "POLYLINE")
                {
                    if (ent.Type == EntityType.PolyfaceMesh)
                    {
                        codeName = "POLYLINE (Polyface Meshes)";
                    }
                }
                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }


            myEntities = myEntities.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var key in myEntities.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);

            }
            deleteEntities.Text = "Delete entities by type";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SaveUndo();

                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string sType = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();
                        DeleteTypedEntities(sType);

                        RemoveUnUsedBlocks(dxfReaderNETControl1);
                    }
                    dxfReaderNETControl1.Refresh();

                }
            }
        }

        private void ribbonButtonModifyJoin_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Join1;

            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select first object";
        }

        private void ribbonButtonDeleteEntitiesByColor_Click(object sender, EventArgs e)
        {
            DeleteObjects deleteObjects = new DeleteObjects();


            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {



                string codeName = ent.Color.ToString();

                if (codeName == "ByLayer")
                {
                    codeName = ent.Layer.Color.ToString();
                }


                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }





            foreach (var key in myEntities.Keys)
            {

                deleteObjects.listView1.Items.Add("          ");
                deleteObjects.listView1.View = System.Windows.Forms.View.SmallIcon;
                if (key.Contains(";"))
                {
                    int r = int.Parse(key.Split(';')[0]);
                    int g = int.Parse(key.Split(';')[1]);
                    int b = int.Parse(key.Split(';')[2]);
                    deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].BackColor = Color.FromArgb(255, r, g, b);
                    if (r == 255 && g == 255 && b == 255)
                    {
                        deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].Text = "White";

                    }

                }
                else
                {
                    deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].BackColor = AciColor.FromCadIndex(short.Parse(key)).ToColor();
                    if (short.Parse(key) == 7 || short.Parse(key) == 255)
                    {
                        deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].Text = "White";
                    }
                }
                deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].Tag = key;
            }

            deleteObjects.Text = "Delete entities by color";
            DialogResult result = deleteObjects.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveUndo();
                    for (int x = 0; x < deleteObjects.listView1.CheckedItems.Count; x++)
                    {
                        string key = deleteObjects.listView1.CheckedItems[x].Tag.ToString().Trim();

                        if (key.Contains(";"))
                        {
                            int r = int.Parse(key.Split(';')[0]);
                            int g = int.Parse(key.Split(';')[1]);
                            int b = int.Parse(key.Split(';')[2]);
                            DeleteEntitiesByColor(Color.FromArgb(255, r, g, b));
                        }
                        else
                        {
                            DeleteEntitiesByColor(AciColor.FromCadIndex(short.Parse(key)).ToColor());
                        }

                    }
                    RemoveUnUsedBlocks(dxfReaderNETControl1);
                    dxfReaderNETControl1.Refresh();

                }
            }
        }
        private void DeleteEntitiesByColor(Color colorS)
        {
            List<EntityObject> EntitiesToDelete = new List<EntityObject>();

            AciColor color = AciColor.FromTrueColor(colorS.ToArgb());


            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
            {

                AciColor entColor = entity.Color;
                if (entColor.IsByLayer)
                {
                    entColor = entity.Layer.Color;
                }

                if (entColor.Index == color.Index)
                {
                    EntitiesToDelete.Add(entity);
                }
                if (entity.Type == EntityType.Insert)
                {
                    foreach (EntityObject entityI in dxfReaderNETControl1.DXF.Blocks[((Insert)entity).Block.Name].Entities)
                    {
                        if (entityI.Color.Index == color.Index)
                        {
                            EntitiesToDelete.Add(entity);
                            break;
                        }
                    }
                }
                if (entity.Type == EntityType.Dimension)
                {
                    foreach (EntityObject entityI in dxfReaderNETControl1.DXF.Blocks[((Dimension)entity).Block.Name].Entities)
                    {
                        if (entityI.Color.Index == color.Index)
                        {
                            EntitiesToDelete.Add(entity);
                            break;
                        }
                    }
                }

            }

            dxfReaderNETControl1.DXF.RemoveEntities(EntitiesToDelete);




        }

        private void ribbonButtonDeleteEntitiesByLayer_Click(object sender, EventArgs e)
        {



            DeleteEntities deleteEntities = new DeleteEntities();


            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {

                string codeName = ent.Layer.Name;

                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }

            foreach (var key in myEntities.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);

            }
            deleteEntities.Text = "Delete entities by layer";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {

                    if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SaveUndo();
                        for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                        {
                            string layerN = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();
                            DeleteEntitiesByLayer(layerN);

                        }
                        RemoveUnUsedBlocks(dxfReaderNETControl1);
                        dxfReaderNETControl1.Refresh();
                    }

                }
            }

        }

        private void DeleteEntitiesByLayer(string layerName)
        {

            List<EntityObject> EntitiesToDelete = new List<EntityObject>();
            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
            {

                if (entity.Layer.Name.Trim().ToUpper() == layerName.Trim().ToUpper())
                {
                    EntitiesToDelete.Add(entity);
                }

            }

            dxfReaderNETControl1.DXF.RemoveEntities(EntitiesToDelete);



        }

        private void DeleteLinetypeEntities(string linetype)
        {

            List<EntityObject> EntitiesToDelete = new List<EntityObject>();
            foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
            {

                if (entity.Linetype.Name.Trim().ToUpper() == linetype.Trim().ToUpper())
                {
                    EntitiesToDelete.Add(entity);
                }

            }

            dxfReaderNETControl1.DXF.RemoveEntities(EntitiesToDelete);





        }


        private void ribbonButtonModifyChamfer_Click(object sender, EventArgs e)
        {
            string inputValue = dxfReaderNETControl1.DXF.DrawingVariables.CHAMFERA.ToString();
            if (ShowInputDialog(ref inputValue, "First chamfer distance", true) == DialogResult.OK)
            {
                double CHAMFERA = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (CHAMFERA >= 0)
                {
                    inputValue = dxfReaderNETControl1.DXF.DrawingVariables.CHAMFERB.ToString();
                    if (ShowInputDialog(ref inputValue, "Second chamfer distance", true) == DialogResult.OK)
                    {
                        double CHAMFERB = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                        if (CHAMFERB >= 0)
                        {
                            dxfReaderNETControl1.DXF.DrawingVariables.CHAMFERB = CHAMFERB;
                            dxfReaderNETControl1.DXF.DrawingVariables.CHAMFERA = CHAMFERA;
                            CurrentFunction = FunctionsEnum.Chamfer1;
                            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
                            StatusLabel.Text = "Select first line or polyline";
                        }
                    }


                }
            }
        }

        private void ribbonButtonDrawSlot_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Slot1;

            StatusLabel.Text = "Select start point";

            CheckSnap();
            LastCommand = Commands.SLOT;
        }


        private void ribbonButtonModifyUngroup_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Ungroup;

            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select group of entities";
        }

        private void ribbonButtonPrintEntityProp_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.PrintEntityProperties;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select entity";
        }

        private void AddLinetipes(DXFReaderNETControl myDXF)
        {
            List<double> segments = new List<double>();
            segments.Add(12);
            segments.Add(-3);
            DXFReaderNET.Tables.Linetype newLinetype = new DXFReaderNET.Tables.Linetype("ISO dash __ __ __ __ __ __ __ __ __ __ __ __ __", segments);
            myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-18);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO dash space __    __    __    __    __    __", segments);

            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(24);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO long-dash dot ____ . ____ . ____ . ____ . _", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(24);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO long-dash double-dot ____ .. ____ .. ____ .", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(24);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO long-dash triple-dot ____ ... ____ ... ____", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO dot . . . . . . . . . . . . . . . . . . . .", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            ////
            ///

            segments.Clear();
            segments.Add(24);
            segments.Add(-3);
            segments.Add(6);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO long-dash short-dash ____ __ ____ __ ____ _", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(24);
            segments.Add(-3);
            segments.Add(6);
            segments.Add(-3);
            segments.Add(6);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("long-dash double-short-dash ____ __ __ ____", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO dash dot __ . __ . __ . __ . __ . __ . __ .", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-3);
            segments.Add(12);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO double-dash dot __ __ . __ __ . __ __ . __ _", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO dash double-dot __ . . __ . . __ . . __ . .", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-3);
            segments.Add(12);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO double-dash double-dot __ __ . . __ __ . . _", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO dash triple-dot __ . . . __ . . . __ . . . _", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

            segments.Clear();
            segments.Add(12);
            segments.Add(-3);
            segments.Add(12);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            segments.Add(0);
            segments.Add(-3);
            newLinetype = new DXFReaderNET.Tables.Linetype("ISO double-dash triple-dot __ __ . . . __ __ . .", segments);
            if (!myDXF.DXF.Linetypes.Contains(newLinetype))
                myDXF.DXF.Linetypes.Add(newLinetype);

        }

        private void ribbonButtonPrintEntitiesList_Click(object sender, EventArgs e)
        {
            PrintEntitiesList();
        }

        private void ribbonButtonArcStartEndMiddle_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select start point";
            CurrentFunction = FunctionsEnum.ArcStartEndMiddle1;
            CheckSnap();
        }



        private void ribbonUpDownZoomFactor_DownButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.ZoomInOutPercent;
            if (value > 10) value -= 1;

            dxfReaderNETControl1.ZoomInOutPercent = value;
            ribbonUpDownZoomFactor.TextBoxText = value.ToString("##0");
        }

        private void ribbonUpDownZoomFactor_UpButtonClicked(object sender, MouseEventArgs e)
        {
            float value = dxfReaderNETControl1.ZoomInOutPercent;

            if (value < 50) value += 1;
            dxfReaderNETControl1.ZoomInOutPercent = value;
            ribbonUpDownZoomFactor.TextBoxText = value.ToString("##0");
        }

        private void ribbonButtonCheckContHighligh_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ContinuousHighlight = ribbonButtonCheckContHighligh.Checked;
        }

        private void ribbonButton11_Click_1(object sender, EventArgs e)
        {
            dxfReaderNETControl1.HighlightNotContinuous = ribbonButton11.Checked;
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonTablesLTYPE_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();



            foreach (DXFReaderNET.Tables.Linetype linetype in dxfReaderNETControl1.DXF.Linetypes)
            {
                string codeName = linetype.Name;
                if (codeName.ToLower() != "continuous" && codeName.ToLower() != "bylayer" && codeName.ToLower() != "byblock")
                {
                    deleteEntities.checkedListBox1.Items.Add(codeName, CheckState.Unchecked);
                }


            }



            deleteEntities.Text = "Delete line types";
            deleteEntities.ButtonOk.Text = "Delete selected line types";


            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure? Only line types without entities will be deleted.", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveUndo();
                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string lTypeName = deleteEntities.checkedListBox1.CheckedItems[x].ToString();//.Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        dxfReaderNETControl1.DXF.RemoveObject(dxfReaderNETControl1.DXF.Linetypes[lTypeName].Handle);


                    }


                }
            }
        }


        private void RefreshTree()
        {
            {

                TreeView1.Nodes.Clear();
                string cont = "";


                foreach (DXFReaderNET.Objects.Layout layout in dxfReaderNETControl1.DXF.Layouts)
                {
                    if (layout.Name == dxfReaderNETControl1.DXF.ActiveLayout)
                        cont = " (" + dxfReaderNETControl1.DXF.Layouts.GetReferences(layout).Count.ToString("###,###,###,###,###,##0") + ")";
                }




                // dxfReaderNETControl1.DXF.RemoveEntities(entities)



                TreeView1.Nodes.Add(new TreeNode("DXF"));
                TreeView1.Nodes[0].Nodes.Add(new TreeNode("HEADER")); // 0
                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("EXTMIN")); // 0
                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("EXTMAX")); // 1
                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("LIMMIN")); // 2
                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("LIMMAX")); // 3

                TreeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("X=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.ExtMin.X)));
                TreeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Y=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.ExtMin.Y)));
                TreeView1.Nodes[0].Nodes[0].Nodes[0].Nodes.Add(new TreeNode("Z=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.ExtMin.Z)));

                TreeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(new TreeNode("X=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.ExtMax.X)));
                TreeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Y=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.ExtMax.Y)));
                TreeView1.Nodes[0].Nodes[0].Nodes[1].Nodes.Add(new TreeNode("Z=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.ExtMax.Z)));

                TreeView1.Nodes[0].Nodes[0].Nodes[2].Nodes.Add(new TreeNode("X=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.LimMin.X)));
                TreeView1.Nodes[0].Nodes[0].Nodes[2].Nodes.Add(new TreeNode("Y=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.LimMin.Y)));


                TreeView1.Nodes[0].Nodes[0].Nodes[3].Nodes.Add(new TreeNode("X=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.LimMax.X)));
                TreeView1.Nodes[0].Nodes[0].Nodes[3].Nodes.Add(new TreeNode("Y=" + dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.LimMax.Y)));


                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("LTSCALE"));
                TreeView1.Nodes[0].Nodes[0].Nodes[TreeView1.Nodes[0].Nodes[0].Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.ToFormattedUnit(dxfReaderNETControl1.DXF.DrawingVariables.LtScale)));


                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("LUNITS"));
                TreeView1.Nodes[0].Nodes[0].Nodes[TreeView1.Nodes[0].Nodes[0].Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.DrawingVariables.LUnits.ToString()));

                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("INSUNITS"));
                TreeView1.Nodes[0].Nodes[0].Nodes[TreeView1.Nodes[0].Nodes[0].Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.DrawingVariables.InsUnits.ToString()));

                TreeView1.Nodes[0].Nodes[0].Nodes.Add(new TreeNode("HANDSEED"));
                TreeView1.Nodes[0].Nodes[0].Nodes[TreeView1.Nodes[0].Nodes[0].Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.DrawingVariables.HandleSeed.ToString()));
                string contT;

                //if (!dxfReaderNETControl1.DXF.Classes == null)
                //{
                //    contT = ""; if (dxfReaderNETControl1.DXF.Classes.Count() > 0)
                //        contT = " (" + dxfReaderNETControl1.DXF.Classes.Count.ToString("###,###,##0") + ")";


                //    TreeView1.Nodes[0].Nodes.Add(new TreeNode("CLASSES" + contT)); // 1
                //    foreach (var _class in dxfReaderNETControl1.DXF.Classes.Items)
                //    {
                //        TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes.Add(new TreeNode(_class.RecordName.ToString()));
                //        TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes.Count - 1].Tag = "CLASS";


                //        TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes.Count - 1].Nodes.Add(new TreeNode(_class.CppClassName.ToString() + " - " + _class.ApplicationName.ToString()));
                //    }
                //}
                //else
                TreeView1.Nodes[0].Nodes.Add(new TreeNode("CLASSES"));// 1
                TreeView1.Nodes[0].Nodes.Add(new TreeNode("TABLES")); // 2

                // contT = "" ': If dxfReaderNETControl1.DXF..Count() > 0 Then contT = " (" + dxfReaderNETControl1.DXF.Layers.Count.ToString("###,###,##0") + ")"
                // .Nodes[0].Nodes[2].Nodes.Add(New TreeNode("APPID" + contT))

                // contT = ""; if (dxfReaderNETControl1.DXF.ApplicationRegistries.Count() > 0))
                contT = " (" + dxfReaderNETControl1.DXF.ApplicationRegistries.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("APPID" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.ApplicationRegistries.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "APPID";
                }






                // contT = ""
                // .Nodes[0].Nodes[2].Nodes.Add(New TreeNode("BLOCK_RECORD" + contT))

                contT = ""; if (dxfReaderNETControl1.DXF.Blocks.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.Blocks.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("BLOCK_RECORD" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.Blocks.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Record.Handle.ToString() + " - " + t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "BLOCK_RECORD";
                }







                contT = ""; if (dxfReaderNETControl1.DXF.DimensionStyles.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.DimensionStyles.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("DIMSTYLE" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.DimensionStyles.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "DIMSTYLE";
                }




                contT = ""; if (dxfReaderNETControl1.DXF.Layers.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.Layers.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("LAYER" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.Layers.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "LAYER";
                }

                contT = ""; if (dxfReaderNETControl1.DXF.Linetypes.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.Linetypes.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("LTYPE" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.Linetypes.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "LTYPE";
                }

                contT = ""; if (dxfReaderNETControl1.DXF.TextStyles.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.TextStyles.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("STYLE" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.TextStyles.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "STYLE";
                }


                contT = ""; if (dxfReaderNETControl1.DXF.UCSs.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.UCSs.Count.ToString("###,###,##0") + ")";

                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("UCS" + contT));

                foreach (var t in dxfReaderNETControl1.DXF.UCSs.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "UCS";
                }

                contT = ""; if (dxfReaderNETControl1.DXF.Views.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.Views.Count.ToString("###,###,##0") + ")";

                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("VIEW" + contT));
                foreach (var t in dxfReaderNETControl1.DXF.Views.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));

                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "VIEW";
                }

                contT = ""; if (dxfReaderNETControl1.DXF.VPorts.Count() > 0)
                    contT = " (" + dxfReaderNETControl1.DXF.VPorts.Count.ToString("###,###,##0") + ")";

                TreeView1.Nodes[0].Nodes[2].Nodes.Add(new TreeNode("VPORT" + contT));
                foreach (var t in dxfReaderNETControl1.DXF.VPorts.Items)
                {
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Add(new TreeNode(t.Name));
                    TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes[TreeView1.Nodes[0].Nodes[2].Nodes.Count - 1].Nodes.Count - 1].Tag = "VPORT";
                }

                string contBlk = ""; if (dxfReaderNETControl1.DXF.Blocks.Count() > 0)
                    contBlk = " (" + dxfReaderNETControl1.DXF.Blocks.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes.Add(new TreeNode("BLOCKS" + contBlk)); // 3
                TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Tag = "BLOCKS";



                foreach (var block in dxfReaderNETControl1.DXF.Blocks.Items)
                {
                    TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes.Add(new TreeNode(block.Handle.ToString() + " - " + block.Name.ToString()));
                    TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[TreeView1.Nodes[0].Nodes.Count - 1].Nodes.Count - 1].Tag = "BLOCK";
                }


                TreeView1.Nodes[0].Nodes.Add(new TreeNode("ENTITIES" + cont)); // 4

                TreeView1.Nodes[0].Nodes.Add(new TreeNode("OBJECTS")); // 5
                TreeView1.Nodes[0].Nodes.Add(new TreeNode("THUMBNAILIMAGE")); // 6
                TreeView1.Nodes[0].Nodes.Add(new TreeNode("ACDSDATA")); // 7

                cont = "";

                if (dxfReaderNETControl1.DXF.AcdsSchemas.Count() > 0)
                {
                    cont = " (" + dxfReaderNETControl1.DXF.AcdsSchemas.Count.ToString("###,###,##0") + ")";

                    TreeView1.Nodes[0].Nodes[7].Nodes.Add(new TreeNode("ACDSSCHEMA" + cont));

                    foreach (var AcdsSchema in dxfReaderNETControl1.DXF.AcdsSchemas)
                    {
                        TreeView1.Nodes[0].Nodes[7].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes.Count - 1].Nodes.Add(new TreeNode(AcdsSchema.SchemaType.ToString()));

                        TreeView1.Nodes[0].Nodes[7].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes.Count - 1].Nodes.Count - 1].Tag = "ACDSSCHEMA";
                    }
                }

                cont = "";

                if (dxfReaderNETControl1.DXF.AcdsRecords.Count() > 0)
                {
                    cont = " (" + dxfReaderNETControl1.DXF.AcdsRecords.Count.ToString("###,###,##0") + ")";

                    TreeView1.Nodes[0].Nodes[7].Nodes.Add(new TreeNode("ACDSRECORD" + cont));

                    foreach (var AcdsRecord in dxfReaderNETControl1.DXF.AcdsRecords)
                    {
                        TreeView1.Nodes[0].Nodes[7].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes.Count - 1].Nodes.Add(new TreeNode(AcdsRecord.RecordHandle.ToString()));

                        TreeView1.Nodes[0].Nodes[7].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes[TreeView1.Nodes[0].Nodes[7].Nodes.Count - 1].Nodes.Count - 1].Tag = "ACDSRECORD";
                    }
                }
                // entities

                AddEntitiesTree(TreeView1.Nodes[0].Nodes[4]);
                // -------------------------------------
                // objects




                cont = ""; if (dxfReaderNETControl1.DXF.Layouts.Count() > 0)
                    cont = " (" + dxfReaderNETControl1.DXF.Layouts.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[5].Nodes.Add(new TreeNode("LAYOUTS" + cont));


                // If dxfReaderNETControl1.DXF.Layouts.Count() > 0 Then
                // For k = 0 To dxfReaderNETControl1.DXF.Layouts.Count - 1
                // .Nodes[0].Nodes[5].Nodes(.Nodes[0].Nodes[5].Nodes.Count - 1).Nodes.Add(New TreeNode(dxfReaderNETControl1.DXF.Layouts(k).Name()))
                // Next k
                // End If

                if (dxfReaderNETControl1.DXF.Layouts.Count() > 0)
                {
                    foreach (var layout in dxfReaderNETControl1.DXF.Layouts)
                    {
                        TreeView1.Nodes[0].Nodes[5].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes.Count - 1].Nodes.Add((new TreeNode(layout.Handle.ToString() + " - " + layout.Name.ToString())));

                        TreeView1.Nodes[0].Nodes[5].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes.Count - 1].Nodes.Count - 1].Tag = "LAYOUT";
                    }
                }


                cont = "";
                if (dxfReaderNETControl1.DXF.MlineStyles.Count() > 0)
                    cont = " (" + dxfReaderNETControl1.DXF.MlineStyles.Count.ToString("###,###,##0") + ")";
                TreeView1.Nodes[0].Nodes[5].Nodes.Add(new TreeNode("MLINESTYLE" + cont));





                if (dxfReaderNETControl1.DXF.MlineStyles.Count() > 0)
                {
                    foreach (DXFReaderNET.Objects.MLineStyle MlineStyle in dxfReaderNETControl1.DXF.MlineStyles)
                    {
                        TreeView1.Nodes[0].Nodes[5].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes.Count - 1].Nodes.Add(new TreeNode(MlineStyle.Handle.ToString() + " - " + MlineStyle.Name));
                        TreeView1.Nodes[0].Nodes[5].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes.Count - 1].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes[TreeView1.Nodes[0].Nodes[5].Nodes.Count - 1].Nodes.Count - 1].Tag = "MLINESTYLE";

                    }
                }
            }
        }

        private void AddEntitiesTree(TreeNode myNode)
        {
            string cont = "";
            string displayText = "";
            cont = "";
            if (dxfReaderNETControl1.DXF.Faces3d.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Faces3d.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("3DFACE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "3DFACE";
                if (dxfReaderNETControl1.DXF.Faces3d.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Faces3d.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Faces3d[k].Handle.ToString(), dxfReaderNETControl1.DXF.Faces3d[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }

            }
            cont = "";
            if (dxfReaderNETControl1.DXF.Solids3D.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Solids3D.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("3DSOLID" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "3DSOLID";
                if (dxfReaderNETControl1.DXF.Solids3D.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Solids3D.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Solids3D[k].Handle.ToString(), dxfReaderNETControl1.DXF.Solids3D[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = "";
            if (dxfReaderNETControl1.DXF.AcadProxyEntities.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.AcadProxyEntities.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("ACAD_PROXY_ENTITY" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "ACAD_PROXY_ENTITY";
                if (dxfReaderNETControl1.DXF.AcadProxyEntities.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.AcadProxyEntities.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.AcadProxyEntities[k].Handle.ToString(), dxfReaderNETControl1.DXF.AcadProxyEntities[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = "";
            if (dxfReaderNETControl1.DXF.Arcs.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Arcs.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("ARC" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "ARC";
                if (dxfReaderNETControl1.DXF.Arcs.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Arcs.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Arcs[k].Handle.ToString(), dxfReaderNETControl1.DXF.Arcs[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = "";
            if (dxfReaderNETControl1.DXF.AttributeDefinitions.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.AttributeDefinitions.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("ATTDEF" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "ATTDEF";


                if (dxfReaderNETControl1.DXF.AttributeDefinitions.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.AttributeDefinitions.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.AttributeDefinitions[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            // ---------------------------------------------------------------------------------------------------------------------

            cont = ""; if (dxfReaderNETControl1.DXF.Bodies.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Bodies.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("BODY" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "BODY";
                if (dxfReaderNETControl1.DXF.Bodies.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Bodies.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Bodies[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            // ---------------------------------------------------------------------------------------------------------------------


            cont = ""; if (dxfReaderNETControl1.DXF.Circles.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Circles.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("CIRCLE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "CIRCLE";
                if (dxfReaderNETControl1.DXF.Circles.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Circles.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Circles[k].Handle.ToString(), dxfReaderNETControl1.DXF.Circles[k].Handle.ToString());
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Dimensions.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Dimensions.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("DIMENSION" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "DIMENSION";
                if (dxfReaderNETControl1.DXF.Dimensions.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Dimensions.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Dimensions[k].Handle.ToString(), dxfReaderNETControl1.DXF.Dimensions[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Ellipses.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Ellipses.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("ELLIPSE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "ELLIPSE";
                if (dxfReaderNETControl1.DXF.Ellipses.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Ellipses.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Ellipses[k].Handle.ToString(), dxfReaderNETControl1.DXF.Ellipses[k].Handle.ToString());


                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Hatches.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Hatches.Count.ToString("###,###,##0") + ")";

                myNode.Nodes.Add(new TreeNode("HATCH" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "HATCH";
                if (dxfReaderNETControl1.DXF.Hatches.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Hatches.Count - 1; k++)
                    {
                        // myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(New TreeNode(dxfReaderNETControl1.DXF.Hatches[k].Pattern.Name.ToString()))
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Hatches[k].Handle.ToString() + " - " + dxfReaderNETControl1.DXF.Hatches[k].Pattern.Name.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Helixes.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Helixes.Count.ToString("###,###,##0") + ")";

                myNode.Nodes.Add(new TreeNode("HELIX" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "HELIX";
                if (dxfReaderNETControl1.DXF.Helixes.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Helixes.Count - 1; k++)
                    {
                        // myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(New TreeNode(dxfReaderNETControl1.DXF.Hatches[k].Pattern.Name.ToString()))
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Helixes[k].Handle.ToString()));

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = "";
            if (dxfReaderNETControl1.DXF.Images.Count() > 0)
            {
                {
                    cont = " (" + dxfReaderNETControl1.DXF.Images.Count.ToString("###,###,##0") + ")";
                    myNode.Nodes.Add(new TreeNode("IMAGE" + cont));
                    myNode.Nodes[myNode.Nodes.Count - 1].Tag = "IMAGE";

                    if (dxfReaderNETControl1.DXF.Images.Count() > 0)
                    {
                        for (var k = 0; k <= dxfReaderNETControl1.DXF.Images.Count - 1; k++)
                        {
                            myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Images[k].Handle.ToString()));
                            myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                        }
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Inserts.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Inserts.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("INSERT" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "INSERT";

                if (dxfReaderNETControl1.DXF.Inserts.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Inserts.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Inserts[k].Handle.ToString(), dxfReaderNETControl1.DXF.Inserts[k].Handle.ToString());
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                        AddInsertEntitiesTree(myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1], dxfReaderNETControl1.DXF.Inserts[k].Block.Entities);
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Leaders.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Leaders.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("LEADER" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "LEADER";

                if (dxfReaderNETControl1.DXF.Leaders.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Leaders.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Leaders[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Lines.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Lines.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("LINE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "LINE";

                if (dxfReaderNETControl1.DXF.Lines.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Lines.Count - 1; k++)
                    {
                        //displayText = dxfReaderNETControl1.DXF.Entities.IndexOf(dxfReaderNETControl1.DXF.Lines[k]).ToString() + " - " + dxfReaderNETControl1.DXF.Lines[k].Handle.ToString();
                        displayText = dxfReaderNETControl1.DXF.Lines[k].Handle.ToString();

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Lines[k].Handle.ToString(), displayText);
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.LwPolylines.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.LwPolylines.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("LWPOLYLINE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "LWPOLYLINE";


                if (dxfReaderNETControl1.DXF.LwPolylines.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.LwPolylines.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.LwPolylines[k].Handle.ToString(), dxfReaderNETControl1.DXF.LwPolylines[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.PolyfaceMeshes.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.PolyfaceMeshes.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("MESH" + cont));

                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "MESH";
                if (dxfReaderNETControl1.DXF.PolyfaceMeshes.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.PolyfaceMeshes.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.PolyfaceMeshes[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }

                if (dxfReaderNETControl1.DXF.Meshes.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Meshes.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Meshes[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.MLines.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.MLines.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("MLINE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "MLINE";
                if (dxfReaderNETControl1.DXF.MLines.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.MLines.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.MLines[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.MTexts.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.MTexts.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("MTEXT" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "MTEXT";


                if (dxfReaderNETControl1.DXF.MTexts.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.MTexts.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.MTexts[k].Handle.ToString(), dxfReaderNETControl1.DXF.MTexts[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.OleFrames.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.OleFrames.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("OLEFRAME" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "OLEFRAME";


                if (dxfReaderNETControl1.DXF.OleFrames.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.OleFrames.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.OleFrames[k].Handle.ToString(), dxfReaderNETControl1.DXF.OleFrames[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            // ---

            cont = ""; if (dxfReaderNETControl1.DXF.Ole2Frames.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Ole2Frames.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("OLE2FRAME" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "OLE2FRAME";


                if (dxfReaderNETControl1.DXF.Ole2Frames.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Ole2Frames.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Ole2Frames[k].Handle.ToString(), dxfReaderNETControl1.DXF.Ole2Frames[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Points.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Points.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("POINT" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "POINT";

                if (dxfReaderNETControl1.DXF.Points.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Points.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Points[k].Handle.ToString(), dxfReaderNETControl1.DXF.Points[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Polylines.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Polylines.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("POLYLINE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "POLYLINE";

                if (dxfReaderNETControl1.DXF.Polylines.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Polylines.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Polylines[k].Handle.ToString(), dxfReaderNETControl1.DXF.Polylines[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Rays.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Rays.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("RAY" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "RAY";
                if (dxfReaderNETControl1.DXF.Rays.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Rays.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Rays[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Regions.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Regions.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("REGION" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "REGION";
                if (dxfReaderNETControl1.DXF.Regions.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Regions.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Regions[k].Handle.ToString(), dxfReaderNETControl1.DXF.Regions[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Solids.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Solids.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("SOLID" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "SOLID";
                if (dxfReaderNETControl1.DXF.Solids.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Solids.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Solids[k].Handle.ToString(), dxfReaderNETControl1.DXF.Solids[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Splines.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Splines.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("SPLINE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "SPLINE";
                if (dxfReaderNETControl1.DXF.Splines.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Splines.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Splines[k].Handle.ToString(), dxfReaderNETControl1.DXF.Splines[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }


            cont = ""; if (dxfReaderNETControl1.DXF.Surfaces.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Surfaces.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("SURFACE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "SURFACE";
                if (dxfReaderNETControl1.DXF.Surfaces.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Surfaces.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Surfaces[k].Handle.ToString(), dxfReaderNETControl1.DXF.Surfaces[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }



            cont = ""; if (dxfReaderNETControl1.DXF.Texts.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Texts.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("TEXT" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "TEXT";
                if (dxfReaderNETControl1.DXF.Texts.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Texts.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Texts[k].Handle.ToString(), dxfReaderNETControl1.DXF.Texts[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Tolerances.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Tolerances.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("TOLERANCE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "TOLERANCE";
                if (dxfReaderNETControl1.DXF.Tolerances.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Tolerances.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Tolerances[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Traces.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Traces.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("TRACE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "TRACE";
                if (dxfReaderNETControl1.DXF.Traces.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Traces.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(dxfReaderNETControl1.DXF.Traces[k].Handle.ToString(), dxfReaderNETControl1.DXF.Traces[k].Handle.ToString());

                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }



            cont = ""; if (dxfReaderNETControl1.DXF.Underlays.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Underlays.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("UNDERLAY" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "UNDERLAY";
                if (dxfReaderNETControl1.DXF.Underlays.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Underlays.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Underlays[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }



            cont = ""; if (dxfReaderNETControl1.DXF.Viewports.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Viewports.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("VIEWPORT" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "VIEWPORT";
                if (dxfReaderNETControl1.DXF.Viewports.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Viewports.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Viewports[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }

            cont = ""; if (dxfReaderNETControl1.DXF.Wipeouts.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.Wipeouts.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("WIPEOUT" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "WIPEOUT";
                if (dxfReaderNETControl1.DXF.Wipeouts.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.Wipeouts.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.Wipeouts[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }



            cont = ""; if (dxfReaderNETControl1.DXF.XLines.Count() > 0)
            {
                cont = " (" + dxfReaderNETControl1.DXF.XLines.Count.ToString("###,###,##0") + ")";
                myNode.Nodes.Add(new TreeNode("XLINE" + cont));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = "XLINE";

                if (dxfReaderNETControl1.DXF.XLines.Count() > 0)
                {
                    for (var k = 0; k <= dxfReaderNETControl1.DXF.XLines.Count - 1; k++)
                    {
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(new TreeNode(dxfReaderNETControl1.DXF.XLines[k].Handle.ToString()));
                        myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                    }
                }
            }
        }


        private void AddInsertEntitiesTree(TreeNode myNode, DXFReaderNET.Collections.EntityCollection myEntities)
        {

            foreach (var ent in myEntities)
            {
                myNode.Nodes.Add(new TreeNode(ent.CodeName));
                myNode.Nodes[myNode.Nodes.Count - 1].Tag = ent.CodeName;

                myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Add(ent.Handle.ToString(), ent.Handle.ToString());

                myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1].Tag = "HANDLE";
                if (ent.CodeName == "INSERT")
                    AddInsertEntitiesTree(myNode.Nodes[myNode.Nodes.Count - 1].Nodes[myNode.Nodes[myNode.Nodes.Count - 1].Nodes.Count - 1], ((Insert)ent).Block.Entities);
            }
        }

        private void TreeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (e.Node.Tag)
                {
                    case "HANDLE":
                        {
                            string handle = e.Node.Text.Trim();
                            if (e.Node.Text.Contains("-"))
                                handle = e.Node.Text.Split('-')[0].Trim();
                            dxfReaderNETControl1.Refresh();
                            dxfReaderNETControl1.HighLight((EntityObject)dxfReaderNETControl1.DXF.GetObjectByHandle(handle));
                            break;
                        }

                    case "VIEW":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.Views.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "LAYER":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.Layers.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "DIMSTYLE":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.DimensionStyles.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "CLASS":
                        {
                            foreach (var c in dxfReaderNETControl1.DXF.Classes.Items)
                            {
                                if (c.RecordName.ToString() == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(c);
                            }

                            break;
                        }

                    case "APPID":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.ApplicationRegistries.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "LTYPE":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.Linetypes.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "STYLE":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.TextStyles.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "VPORT":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.VPorts.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }

                    case "UCS":
                        {
                            foreach (var t in dxfReaderNETControl1.DXF.UCSs.Items)
                            {
                                if (t.Name == e.Node.Text.Trim())
                                    dxfReaderNETControl1.ShowProperties(t);
                            }

                            break;
                        }
                    case "LAYOUT":
                    case "BLOCK":
                    case "BLOCK_RECORD":
                    case "ACDSRECORD":
                    case "ACDSSCHEMA":
                    case "MLINESTYLE":
                        {
                            string handle = e.Node.Text.Trim();
                            if (e.Node.Text.Contains("-"))
                                handle = e.Node.Text.Split('-')[0].Trim();

                            dxfReaderNETControl1.ShowProperties(handle);
                            break;
                        }





                }
            }
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            string Handle = e.Node.Text.Trim();
            //if (dxfReaderNETControl1.DXF.GetEntityByHandle(Handle) != null)
            dxfReaderNETControl1.ShowProperties(Handle);
        }

        private void ribbonButtonDeleteEntitiesByLineType_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();


            var myEntities = new Dictionary<string, int>();



            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {



                string codeName = ent.Linetype.Name;

                if (codeName == "ByLayer")
                {
                    codeName = ent.Linetype.Name;
                }


                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }


            foreach (var key in myEntities.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);

            }
            deleteEntities.Text = "Delete entities by line type";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SaveUndo();
                        for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                        {
                            string layerN = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();
                            DeleteLinetypeEntities(layerN);

                        }
                        RemoveUnUsedBlocks(dxfReaderNETControl1);
                        dxfReaderNETControl1.Refresh();
                    }

                }
            }
        }



        private void ribbonButtonInquiryMeasureFilledEmpty_Click(object sender, EventArgs e)
        {
            //StatusLabel.Text = FilledAndEmptyAreas(dxfReaderNETControl1);

            int InternalCountoursNumber = 0;
            double ExternalLenght = 0;
            double ExternalArea = 0;
            double InternalLenght = 0;
            double InternalArea = 0;
            bool ret = MathHelper.FindClosedAreaData(dxfReaderNETControl1.DXF.Entities, out ExternalLenght, out ExternalArea, out InternalLenght, out InternalArea, out InternalCountoursNumber);

            if (ret)
            {

                StatusLabel.Text = "Ext. lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit(ExternalLenght);
                StatusLabel.Text += " Ext. area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(ExternalArea);
                StatusLabel.Text += " Int. lenght: " + dxfReaderNETControl1.DXF.ToFormattedUnit(InternalLenght);
                StatusLabel.Text += " Int. area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(InternalArea);
                StatusLabel.Text += " Filled area: " + dxfReaderNETControl1.DXF.ToFormattedUnit(ExternalArea - InternalArea);
                StatusLabel.Text += " Int. countours #: " + InternalCountoursNumber.ToString();

                Vector2 extension = new Vector2(dxfReaderNETControl1.DXF.DrawingVariables.ExtMax.X - dxfReaderNETControl1.DXF.DrawingVariables.ExtMin.X, dxfReaderNETControl1.DXF.DrawingVariables.ExtMax.Y - dxfReaderNETControl1.DXF.DrawingVariables.ExtMin.Y);
                StatusLabel.Text += " Extension : " + dxfReaderNETControl1.DXF.ToFormattedUnit(extension.X) + " x " + dxfReaderNETControl1.DXF.ToFormattedUnit(extension.Y);

            }

            else
            {
                StatusLabel.Text = " Closed area not found";
            }

        }

        private void ribbonButton12_Click_1(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();


            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {
                string codeName = ent.CodeName;
                if (codeName == "POLYLINE")
                {
                    if (ent.Type == EntityType.PolyfaceMesh)
                    {
                        codeName = "POLYLINE (Polyface Meshes)";
                    }
                }
                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }


            myEntities = myEntities.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var key in myEntities.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);

            }
            deleteEntities.Text = "Select entities by type";
            deleteEntities.ButtonOk.Text = "Select entities";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string sType = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
                        {
                            if (ent.IsVisible && dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsVisible && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsLocked)
                            {
                                if (ent.CodeName == sType)
                                {
                                    if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                                    {
                                        dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);

                                    }
                                }
                            }
                        }

                    }
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();


                    dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);



                }

            }
        }

        private void ribbonButton13_Click_1(object sender, EventArgs e)
        {
            DeleteObjects deleteObjects = new DeleteObjects();


            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {



                string codeName = ent.Color.ToString();

                if (codeName == "ByLayer")
                {
                    codeName = ent.Layer.Color.ToString();
                }


                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }





            foreach (var key in myEntities.Keys)
            {

                deleteObjects.listView1.Items.Add("          ");
                deleteObjects.listView1.View = System.Windows.Forms.View.SmallIcon;
                if (key.Contains(";"))
                {
                    int r = int.Parse(key.Split(';')[0]);
                    int g = int.Parse(key.Split(';')[1]);
                    int b = int.Parse(key.Split(';')[2]);
                    deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].BackColor = System.Drawing.Color.FromArgb(255, r, g, b);
                    if (r == 255 && g == 255 && b == 255)
                    {
                        deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].Text = "White";

                    }

                }
                else
                {
                    deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].BackColor = AciColor.FromCadIndex(short.Parse(key)).ToColor();
                    if (short.Parse(key) == 7 || short.Parse(key) == 255)
                    {
                        deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].Text = "White";
                    }
                }
                deleteObjects.listView1.Items[deleteObjects.listView1.Items.Count - 1].Tag = key;
            }

            deleteObjects.Text = "Select entities by color";
            deleteObjects.ButtonOk.Text = "Select entities";
            DialogResult result = deleteObjects.ShowDialog();
            if (result == DialogResult.OK)
            {


                for (int x = 0; x < deleteObjects.listView1.CheckedItems.Count; x++)
                {
                    string key = deleteObjects.listView1.CheckedItems[x].Tag.ToString().Trim();

                    if (key.Contains(";"))
                    {
                        int r = int.Parse(key.Split(';')[0]);
                        int g = int.Parse(key.Split(';')[1]);
                        int b = int.Parse(key.Split(';')[2]);
                        SelectAllEntitiesByColor(dxfReaderNETControl1, System.Drawing.Color.FromArgb(255, r, g, b));
                    }
                    else
                    {
                        SelectAllEntitiesByColor(dxfReaderNETControl1, AciColor.FromCadIndex(short.Parse(key)).ToColor());
                    }

                }



            }
        }

        private void SelectAllEntitiesByColor(DXFReaderNETControl myDXF, System.Drawing.Color colorS)
        {
            List<EntityObject> EntitiesToDelete = new List<EntityObject>();

            AciColor color = AciColor.FromTrueColor(colorS.ToArgb());


            foreach (EntityObject entity in myDXF.DXF.Entities)
            {

                AciColor entColor = entity.Color;
                if (entColor.IsByLayer)
                {
                    entColor = entity.Layer.Color;
                }

                if (entColor.Index == color.Index)
                {
                    EntitiesToDelete.Add(entity);
                }
                if (entity.Type == EntityType.Insert)
                {
                    foreach (EntityObject entityI in myDXF.DXF.Blocks[((Insert)entity).Block.Name].Entities)
                    {
                        if (entityI.Color.Index == color.Index)
                        {
                            EntitiesToDelete.Add(entity);
                            break;
                        }
                    }
                }
                if (entity.Type == EntityType.Dimension)
                {
                    foreach (EntityObject entityI in myDXF.DXF.Blocks[((Dimension)entity).Block.Name].Entities)
                    {
                        if (entityI.Color.Index == color.Index)
                        {
                            EntitiesToDelete.Add(entity);
                            break;
                        }
                    }
                }

            }
            myDXF.DXF.SelectedEntities.Clear();

            myDXF.DXF.SelectedEntities.AddRange(EntitiesToDelete);


            myDXF.HighLight(myDXF.DXF.SelectedEntities);
            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();


        }

        private void ribbonButton14_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();


            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {

                string codeName = ent.Layer.Name;

                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }


            //myEntities = myEntities.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var key in myEntities.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);
                //deleteEntities.checkedListBoxControl1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);
            }

            deleteEntities.Text = "Select entities by layer";
            deleteEntities.ButtonOk.Text = "Select entities";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {

                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string layerN = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
                        {

                            if (entity.Layer.Name.Trim().ToUpper() == layerN.Trim().ToUpper())
                            {
                                if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(entity))
                                {

                                    dxfReaderNETControl1.DXF.SelectedEntities.Add(entity);
                                    dxfReaderNETControl1.HighLight(entity);
                                }
                            }

                        }



                    }

                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                }
            }
        }

        private void ribbonButton15_Click_1(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();

            var myEntities = new Dictionary<string, int>();


            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {



                string codeName = ent.Linetype.Name;

                if (codeName == "ByLayer")
                {
                    codeName = ent.Linetype.Name;
                }


                if (myEntities.ContainsKey(codeName))
                {
                    myEntities[codeName]++;
                }
                else
                {
                    myEntities.Add(codeName, 1);
                }


            }



            foreach (var key in myEntities.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);
                //deleteEntities.checkedListBoxControl1.Items.Add(key + " (" + myEntities[key].ToString() + ")", CheckState.Unchecked);
            }

            deleteEntities.Text = "Select entities by line type";
            deleteEntities.ButtonOk.Text = "Select entities";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {

                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string layerN = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();
                        SelectLinetypeEntities(dxfReaderNETControl1, layerN);

                    }


                }
            }

        }
        private void SelectLinetypeEntities(DXFReaderNETControl myDXF, string linetype)
        {

            List<EntityObject> EntitiesToDelete = new List<EntityObject>();
            foreach (EntityObject entity in myDXF.DXF.Entities)
            {

                if (entity.Linetype.Name.Trim().ToUpper() == linetype.Trim().ToUpper())
                {
                    EntitiesToDelete.Add(entity);
                }

            }
            myDXF.DXF.SelectedEntities.Clear();

            myDXF.DXF.SelectedEntities.AddRange(EntitiesToDelete);
            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
            myDXF.HighLight(myDXF.DXF.SelectedEntities);

        }

        private void ribbonButtonLines2PolyB_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveUndo();
                LwPolyline newPoly = new LwPolyline(dxfReaderNETControl1.DXF.SelectedEntities, true);
                if (newPoly != null)
                {
                    if (newPoly.Vertexes.Count > 0)
                    {
                        newPoly.Color = dxfReaderNETControl1.DXF.CurrentColor;
                        dxfReaderNETControl1.DXF.AddEntity(newPoly);
                        dxfReaderNETControl1.DXF.RemoveEntities(dxfReaderNETControl1.DXF.SelectedEntities);
                        dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                        dxfReaderNETControl1.Refresh();
                    }
                }

            }
        }

        private void ribbonButtonSelectContours_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Contour;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select an entity of the contour. ESC to end";
            m_SelectedContours = 0;
            addedContours = new List<DXFReaderNET.Objects.Group>();
        }

        private void ribbonPanelAnnotations_ButtonMoreClick(object sender, EventArgs e)
        {

            dxfReaderNETControl1.ShowDimStyles();
            FillComboDimStyles();
        }

        private void ribbonButtonModifyExplodeDimension_Click(object sender, EventArgs e)
        {

            CurrentFunction = FunctionsEnum.ExplodeDimension;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select dimension entity";
        }

        private void FillComboDimStyles()
        {
            ribbonComboBoxDimensionStyle.DropDownItems.Clear();
            foreach (DXFReaderNET.Tables.DimensionStyle _dimStyle in dxfReaderNETControl1.DXF.DimensionStyles.Items)
            {
                RibbonButton newItem = new RibbonButton();
                newItem.Text = _dimStyle.Name;
                ribbonComboBoxDimensionStyle.DropDownItems.Add(newItem);
                if (dxfReaderNETControl1.DXF.DrawingVariables.DimStyle.ToLower() == _dimStyle.Name.ToLower())
                {
                    ribbonComboBoxDimensionStyle.SelectedItem = newItem;
                }
            }
        }

        private void ribbonButtonOrbit3D_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Orbit3D;
            dxfReaderNETControl1.Cursor = Cursors.SizeAll;

            StatusLabel.Text = "3D Orbit - Press ESC or right click to exit";
        }

        private void ribbonButtonShowExtents_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowExtents = ribbonButtonShowExtents.Checked;
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonShowData_Click(object sender, EventArgs e)
        {
            ShowDrawingData();
        }
        private void ShowDrawingData()
        {
            string inputValue = dxfReaderNETControl1.DXF.CurrentTextSize.ToString();
            if (ShowInputDialog(ref inputValue, "Text height", true) == DialogResult.OK)
            {
                dxfReaderNETControl1.ClearDrawnElements();
                dxfReaderNETControl1.DXF.CurrentTextSize = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                int n = 0;
                Pen textColor = new Pen(Color.Yellow, 0);
                Pen pointsColor = new Pen(Color.Green, 0);
                Pen marksColor = new Pen(Color.Magenta, 0);
                Pen marksColorLine = new Pen(Color.Magenta, 0);
                marksColorLine.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
                Pen entColor = new Pen(Color.Cyan, 0);
                bool writeCoord = true;
                bool writeHandle = false;
                bool writeCircles = true;
                foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
                {
                    string coords = "";
                    string entInfo = "";
                    switch (ent.Type)
                    {
                        case EntityType.Line:

                            Line l = (Line)ent;
                            double angle = Vector2.Angle(l.StartPoint.ToVector2(), l.EndPoint.ToVector2()) * MathHelper.RadToDeg;
                            Vector2 lDir = l.Direction.ToVector2();
                            //lDir -= dxfReaderNETControl1.DXF.CurrentTextSize*10;
                            lDir.Normalize();


                            if (writeCoord)
                            {
                                coords = "S (" + dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(l.StartPoint.Y) + ")";

                                dxfReaderNETControl1.DrawText(textColor, coords, l.StartPoint.ToVector2() + lDir, dxfReaderNETControl1.DXF.CurrentTextSize / 2, angle, FontStyle.Regular, StringAlignment.Near, true);

                                coords = "E (" + dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(l.EndPoint.Y) + ")";

                                dxfReaderNETControl1.DrawText(textColor, coords, l.EndPoint.ToVector2() - lDir, dxfReaderNETControl1.DXF.CurrentTextSize / 2, angle, FontStyle.Regular, StringAlignment.Far, true);
                            }


                            entInfo = "#" + n.ToString() + " LINE";
                            if (writeHandle)
                            {
                                entInfo += " [" + l.Handle + "]";

                            }
                            dxfReaderNETControl1.DrawText(entColor, entInfo, Vector2.MidPoint(l.StartPoint.ToVector2(), l.EndPoint.ToVector2()), dxfReaderNETControl1.DXF.CurrentTextSize, angle, FontStyle.Regular, StringAlignment.Center, true);

                            if (writeCircles)
                            {
                                WritePointCircle(pointsColor, l.StartPoint.ToVector2());
                                WritePointCircle(pointsColor, l.EndPoint.ToVector2());
                            }
                            break;

                        case EntityType.Arc:

                            Arc a = (Arc)ent;
                            //angle = Vector2.Angle(a.StartPoint.ToVector2(), a.EndPoint.ToVector2()) * MathHelper.RadToDeg;
                            Line la = new Line(a.StartPoint.ToVector2(), a.EndPoint.ToVector2());
                            lDir = la.Direction.ToVector2();
                            if (writeCoord)
                            {
                                coords = "S (" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(a.StartPoint.Y) + ")";
                                coords += " ∠ " + dxfReaderNETControl1.DXF.ToFormattedAngle(a.StartAngle * MathHelper.DegToRad);

                                dxfReaderNETControl1.DrawText(textColor, coords, a.StartPoint.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);
                                //dxfReaderNETControl1.DrawText(textColor, coords, a.StartPoint.ToVector2() + lDir, dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);

                                coords = "E (" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(a.EndPoint.Y) + ")";
                                coords += " ∠ " + dxfReaderNETControl1.DXF.ToFormattedAngle(a.EndAngle * MathHelper.DegToRad);

                                dxfReaderNETControl1.DrawText(textColor, coords, a.EndPoint.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Far, true);
                                //dxfReaderNETControl1.DrawText(textColor, coords, a.EndPoint.ToVector2() - lDir, dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Far, true);



                            }

                            angle = Vector2.Angle(a.Center.ToVector2(), a.MidPoint.ToVector2()) * MathHelper.RadToDeg + 270;

                            entInfo = "#" + n.ToString() + " ARC";
                            if (writeHandle)
                            {
                                entInfo += " [" + a.Handle + "]";

                            }

                            dxfReaderNETControl1.DrawText(entColor, entInfo, a.MidPoint.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize, angle, FontStyle.Regular, StringAlignment.Center, true);
                            if (writeCircles)
                            {
                                WritePointCircle(pointsColor, a.StartPoint.ToVector2());
                                WritePointCircle(pointsColor, a.EndPoint.ToVector2());
                            }
                            if (writeCoord)
                            {
                                dxfReaderNETControl1.DrawLine(marksColor, a.Center.ToVector2() - new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), a.Center.ToVector2() + new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), true);
                                dxfReaderNETControl1.DrawLine(marksColor, a.Center.ToVector2() - new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), a.Center.ToVector2() + new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), true);

                                coords = "(" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.Center.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(a.Center.Y) + ")";
                                coords += " R" + dxfReaderNETControl1.DXF.ToFormattedUnit(a.Radius);
                                dxfReaderNETControl1.DrawText(marksColor, coords, a.Center.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);

                                dxfReaderNETControl1.DrawLine(marksColorLine, a.Center.ToVector2(), a.MidPoint.ToVector2(), true);


                            }
                            break;

                        case EntityType.Ellipse:

                            Ellipse e = (Ellipse)ent;

                            dxfReaderNETControl1.DrawLine(marksColor, e.Center.ToVector2() - new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), e.Center.ToVector2() + new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), true);
                            dxfReaderNETControl1.DrawLine(marksColor, e.Center.ToVector2() - new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), e.Center.ToVector2() + new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), true);

                            double beta = e.Rotation * MathHelper.DegToRad;
                            double sinbeta = Math.Sin(beta);
                            double cosbeta = Math.Cos(beta);


                            double pointX = 0.5 * (e.MajorAxis * cosbeta);
                            double pointY = 0.5 * (e.MajorAxis * sinbeta);



                            if (writeCoord)
                            {
                                coords = "(" + dxfReaderNETControl1.DXF.ToFormattedUnit(e.Center.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(e.Center.Y) + ")";
                                coords += " MajorAxis: " + dxfReaderNETControl1.DXF.ToFormattedUnit(e.MajorAxis);
                                dxfReaderNETControl1.DrawText(marksColor, coords, e.Center.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);

                                dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " ELLIPSE [" + e.Handle + "]", e.Center.ToVector2() + new Vector2(pointX, pointY), dxfReaderNETControl1.DXF.CurrentTextSize / 2, e.Rotation, FontStyle.Regular, StringAlignment.Center, true);
                            }

                            break;
                        case EntityType.Circle:

                            Circle c = (Circle)ent;

                            dxfReaderNETControl1.DrawLine(marksColor, c.Center.ToVector2() - new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), c.Center.ToVector2() + new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), true);
                            dxfReaderNETControl1.DrawLine(marksColor, c.Center.ToVector2() - new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), c.Center.ToVector2() + new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), true);
                            if (writeCoord)
                            {
                                coords = "(" + dxfReaderNETControl1.DXF.ToFormattedUnit(c.Center.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(c.Center.Y) + ")";
                                coords += " R" + dxfReaderNETControl1.DXF.ToFormattedUnit(c.Radius);
                                dxfReaderNETControl1.DrawText(marksColor, coords, c.Center.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);

                                dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " CIRCLE [" + c.Handle + "]", c.Center.ToVector2() + new Vector2(0, c.Radius), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Center, true);
                            }

                            break;
                        case EntityType.LightWeightPolyline:
                            LwPolyline lw = (LwPolyline)ent;
                            int nv = 0;
                            Vector2[] vA = new Vector2[lw.Vertexes.Count];

                            //foreach (LwPolylineVertex v in lw.Vertexes)
                            for (int k = 0; k < lw.Vertexes.Count; k++)
                            {

                                coords = nv.ToString();
                                int startIndex = nv;
                                int endIndex = nv + 1;
                                if (nv == lw.Vertexes.Count - 1)
                                {
                                    startIndex = lw.Vertexes.Count - 1;
                                    endIndex = 0;
                                }
                                if (writeCoord)
                                {
                                    coords += " (" + dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Vertexes[k].Position.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(lw.Vertexes[k].Position.Y) + ")"; ;
                                    if (lw.Vertexes[k].Bulge != 0)
                                    {
                                        coords += " ∠ " + dxfReaderNETControl1.DXF.ToFormattedAngle(4 * Math.Atan(Math.Abs(lw.Vertexes[k].Bulge)) * Math.Sign(lw.Vertexes[k].Bulge));


                                        MathHelper.BulgeParam(lw.Vertexes[startIndex].ToVector2(), lw.Vertexes[endIndex].ToVector2(), lw.Vertexes[k].Bulge, out Vector2 Center, out double R, out double StartAngle, out double EndAngle);

                                        if (writeCoord)
                                        {
                                            dxfReaderNETControl1.DrawLine(marksColor, Center - new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), Center + new Vector2(dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0), true);
                                            dxfReaderNETControl1.DrawLine(marksColor, Center - new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), Center + new Vector2(0, dxfReaderNETControl1.DXF.CurrentTextSize / 2), true);

                                            string coordsB = "(" + dxfReaderNETControl1.DXF.ToFormattedUnit(Center.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(Center.Y) + ")";
                                            coordsB += " R" + dxfReaderNETControl1.DXF.ToFormattedUnit(R);
                                            dxfReaderNETControl1.DrawText(marksColor, coordsB, Center, dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);
                                            double midAngle = (EndAngle - StartAngle) / 2 + StartAngle;
                                            if (EndAngle > StartAngle)
                                            {
                                                midAngle = (StartAngle - EndAngle) / 2 + EndAngle;
                                            }
                                            Vector2 midPoint = Center + new Vector2(R * Math.Cos(midAngle * MathHelper.DegToRad), R * Math.Sin(midAngle * MathHelper.DegToRad));
                                            dxfReaderNETControl1.DrawLine(marksColorLine, Center, midPoint, true);

                                        }

                                    }
                                }

                                angle = Vector2.Angle(lw.Vertexes[startIndex].ToVector2(), lw.Vertexes[endIndex].ToVector2()) * MathHelper.RadToDeg;

                                dxfReaderNETControl1.DrawText(textColor, coords, lw.Vertexes[k].Position, dxfReaderNETControl1.DXF.CurrentTextSize / 2, angle, FontStyle.Regular, StringAlignment.Near, true);
                                if (writeCircles)
                                {
                                    WritePointCircle(pointsColor, lw.Vertexes[k].Position);
                                }
                                nv++;
                            }

                            //dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " LWPOLYLINE [" + lw.Handle + "]", MathHelper.PolygonCenter(vA), dxfReaderNETControl1.DXF.CurrentTextSize, 0, FontStyle.Regular, StringAlignment.Center, true);
                            if (lw.Vertexes.Count > 1)
                            {
                                angle = Vector2.Angle(lw.Vertexes[0].ToVector2(), lw.Vertexes[1].ToVector2()) * MathHelper.RadToDeg;
                                dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " LWPOLYLINE [" + lw.Handle + "]", Vector2.MidPoint(lw.Vertexes[0].ToVector2(), lw.Vertexes[1].ToVector2()), dxfReaderNETControl1.DXF.CurrentTextSize, angle, FontStyle.Regular, StringAlignment.Center, true);

                            }


                            break;

                        case EntityType.Polyline:
                            Polyline p = (Polyline)ent;
                            nv = 0;
                            vA = new Vector2[p.Vertexes.Count];
                            foreach (PolylineVertex v in p.Vertexes)
                            {
                                coords = nv.ToString();
                                if (writeCoord)
                                {
                                    coords += " (" + dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.Y) + ")"; ;
                                    if (v.Bulge != 0)
                                    {
                                        coords += " ∠ " + dxfReaderNETControl1.DXF.ToFormattedAngle(4 * Math.Atan(Math.Abs(v.Bulge)) * Math.Sign(v.Bulge));
                                    }
                                }

                                vA[nv] = v.Position.ToVector2();

                                dxfReaderNETControl1.DrawText(textColor, coords, v.Position.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);
                                if (writeCircles)
                                {

                                    WritePointCircle(pointsColor, v.Position.ToVector2());
                                }
                                nv++;
                            }
                            // dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " POLYLINE [" + p.Handle + "]", MathHelper.PolygonCenter(vA), dxfReaderNETControl1.DXF.CurrentTextSize, 0, FontStyle.Regular, StringAlignment.Center, true);
                            if (p.Vertexes.Count > 1)
                            {
                                angle = Vector2.Angle(p.Vertexes[0].Position.ToVector2(), p.Vertexes[1].Position.ToVector2()) * MathHelper.RadToDeg;
                                dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " POLYLINE [" + p.Handle + "]", Vector2.MidPoint(p.Vertexes[0].Position.ToVector2(), p.Vertexes[1].Position.ToVector2()), dxfReaderNETControl1.DXF.CurrentTextSize, angle, FontStyle.Regular, StringAlignment.Center, true);

                            }
                            break;
                        case EntityType.Spline:
                            DXFReaderNET.Entities.Spline s = (DXFReaderNET.Entities.Spline)ent;
                            nv = 0;
                            vA = new Vector2[s.ControlPoints.Count];
                            foreach (SplineVertex v in s.ControlPoints)
                            {
                                coords = nv.ToString() + " (" + dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.X) + "; " + dxfReaderNETControl1.DXF.ToFormattedUnit(v.Position.Y) + ")"; ;



                                vA[nv] = v.Position.ToVector2();
                                if (writeCoord)
                                    dxfReaderNETControl1.DrawText(textColor, coords, v.Position.ToVector2(), dxfReaderNETControl1.DXF.CurrentTextSize / 2, 0, FontStyle.Regular, StringAlignment.Near, true);

                                if (writeCircles)
                                {
                                    WritePointCircle(pointsColor, v.Position.ToVector2());
                                }

                                nv++;
                            }
                            //dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " SPLINE [" + s.Handle + "]", MathHelper.PolygonCenter(vA), dxfReaderNETControl1.DXF.CurrentTextSize, 0, FontStyle.Regular, StringAlignment.Center, true);
                            if (s.ControlPoints.Count > 1)
                            {
                                angle = Vector2.Angle(vA[0], vA[1]) * MathHelper.RadToDeg;
                                dxfReaderNETControl1.DrawText(entColor, "#" + n.ToString() + " SPLINE [" + s.Handle + "]", Vector2.MidPoint(vA[0], vA[1]), dxfReaderNETControl1.DXF.CurrentTextSize, angle, FontStyle.Regular, StringAlignment.Center, true);

                            }
                            break;
                    }
                    n++;
                }
                //dxfReaderNETControl1.Refresh();
            }
        }
        private void WritePointCircle(Pen pen, Vector2 point)
        {
            double h = dxfReaderNETControl1.DXF.CurrentTextSize / 4;
            dxfReaderNETControl1.DrawCircle(pen, point, h, false, true);
            dxfReaderNETControl1.DrawLine(pen, point - new Vector2(0, h), point + new Vector2(0, h), true);
            dxfReaderNETControl1.DrawLine(pen, point - new Vector2(h, 0), point + new Vector2(h, 0), true);
        }
        private void ribbonButtonZoomCenter_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ZoomCenter();
        }

        private void ribbonButtonRedo_Click(object sender, EventArgs e)
        {
            ReDo();
        }



        private void ribbonButtonMultiLine_Click(object sender, EventArgs e)
        {


            string inputValue = m_mlineScale.ToString();
            if (ShowInputDialog(ref inputValue, "Spacing", true) == DialogResult.OK)
            {
                m_mlineScale = double.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);

                if (m_mlineScale >= 0)
                {
                    StartMultiLine();


                }
            }
        }
        private void StartMultiLine()
        {
            LastCommand = Commands.MLINE;
            CurrentFunction = FunctionsEnum.Mline;
            vertexes.Clear();
            StatusLabel.Text = "Select points with left mouse click. Right mouse click to end.";
            CheckSnap();
        }

        private void ribbonButtonNormalize_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveUndo();
                ChangeNormalVector(dxfReaderNETControl1);

            }
        }

        private void ribbonButtonShowSelectedEntitiesInfo_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
                dxfReaderNETControl1.ShowDrawingInfo(dxfReaderNETControl1.DXF.SelectedEntities);
        }

        private void ribbonButtonExplodePolySingle_Click(object sender, EventArgs e)
        {


            CurrentFunction = FunctionsEnum.ExplodePoly;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select polyline or light weight polyline entity";


        }

        private void ribbonButtonExplodePolyRect_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.ExplodePoly1;
            StatusLabel.Text = "Select start point of selection rectangle";
        }

        private void ribbonButtonDeleteCoincident_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<EntityObject> entitesToDelete = dxfReaderNETControl1.CoincidentEntities();

                if (entitesToDelete.Count > 0)
                {
                    SaveUndo();
                    dxfReaderNETControl1.DXF.RemoveEntities(entitesToDelete);
                    //dxfReaderNETControl1.DXF.ModifyEntities(entitesToDelete,Vector2.Zero,new Vector2(100, 100),1,0);
                    dxfReaderNETControl1.Refresh();




                }
            }
        }

        private void ribbonButtonExplodeInserSingle_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.ExplodeInsert;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
            StatusLabel.Text = "Select insert entity";
        }

        private void ribbonButtonExplodeInsertRect_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.ExplodeInsert1;
            StatusLabel.Text = "Select start point of selection rectangle";
        }


        private void FindBoundaries(List<EntityObject> selectedEntities, out List<EntityObject> externalContour, out List<EntityObject> innerEntities)
        {
            externalContour = MathHelper.ExternalContour(selectedEntities); //find external contour
                                                                            //System.Diagnostics.Debugger.Break(); //stop
            innerEntities = new List<EntityObject>();

            foreach (EntityObject entity in selectedEntities)
            {
                if (!externalContour.Contains(entity))
                {
                    innerEntities.Add(entity);
                }



            }
            List<LwPolyline> lws = dxfReaderNETControl1.EntitiesToLwPolylines(innerEntities);
            innerEntities.Clear();
            innerEntities.AddRange(lws);
        }

        private void ribbonButtonGridInsideLimits_Click(object sender, EventArgs e)
        {
            if (ribbonButtonGridInsideLimits.Checked)
            {
                dxfReaderNETControl1.GridDisplay = GridDisplayType.InsideDrawingLimits;
            }
            else
            {
                dxfReaderNETControl1.GridDisplay = GridDisplayType.Normal;
            }
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonTruTOPS_Click(object sender, EventArgs e)
        {
            AddLayerIfNotPresent("DIMENSION");
            dxfReaderNETControl1.DXF.Layers["DIMENSION"].IsLocked = true;
            dxfReaderNETControl1.DXF.Layers["DIMENSION"].Color = AciColor.Yellow;
            DXFReaderNET.Tables.Layer dimLayer = dxfReaderNETControl1.DXF.Layers["DIMENSION"];
            bool dimFound = false;
            foreach (DXFReaderNET.Blocks.Block _block in dxfReaderNETControl1.DXF.Blocks.Items)
            {
                if (_block.Name.Contains("DIM"))
                {
                    dimFound = true;
                    foreach (EntityObject ent in _block.Entities)
                    {
                        ent.Color = ent.Layer.Color;
                    }
                    dxfReaderNETControl1.AddInsert(_block.Name, Vector3.Zero);
                    dxfReaderNETControl1.DXF.Inserts[dxfReaderNETControl1.DXF.Inserts.Count - 1].Layer = dimLayer;


                }
            }
            if (dimFound)
            {
                dxfReaderNETControl1.DXF.RemoveEntities(dxfReaderNETControl1.DXF.Dimensions);
                dxfReaderNETControl1.Refresh();
                dxfReaderNETControl1.ZoomExtents();
            }
        }

        private void ribbonButtonDeleteNotConnected_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                SaveUndo();
                dxfReaderNETControl1.DXF.RemoveEntities(MathHelper.NotConnectedEntities(dxfReaderNETControl1.DXF.Entities));
                dxfReaderNETControl1.Refresh();


            }
        }

        private void ribbonDrawingInfo_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowDrawingInfo();
        }

        private void ribbonButtonRubberBandStyle_DropDownItemClicked(object sender, RibbonItemEventArgs e)
        {
            if (((RibbonComboBox)sender).SelectedItem.Text != "")
            {
                dxfReaderNETControl1.DXF.DrawingVariables.DimStyle = ((RibbonComboBox)sender).SelectedItem.Text.Trim();
            }

            switch (((RibbonComboBox)sender).SelectedItem.Text)
            {
                case "Dashed":
                    m_RubberBandType = RubberBandType.Dashed;
                    break;
                case "Solid":
                    m_RubberBandType = RubberBandType.Solid;
                    break;

            }
        }

        private void contextMenuStrip1_Opened(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.Entities.Count == 0)
            {
                selectEntitiesToolStripMenuItem.Enabled = false;
            }
            else
            {
                selectEntitiesToolStripMenuItem.Enabled = true;

            }
            menuLastCommand.Text = "Last command: " + LastCommand.ToString();
            menuLastCommand.Visible = false;
            toolStripSeparator1.Visible = false;

            if (dxfReaderNETControl1.DXF.SelectedEntities.Count == 0)
            {
                deleteSelectionsToolStripMenuItem.Enabled = false;

            }
            else
            {
                deleteSelectionsToolStripMenuItem.Enabled = true;
            }


            if (CurrentFunction == FunctionsEnum.None || CurrentFunction == FunctionsEnum.GetEntities)
            {
                if (LastCommand != Commands.None)
                {
                    menuLastCommand.Visible = true;
                    toolStripSeparator1.Visible = true;
                }
                enterToolStripMenuItem.Enabled = false;
                closeToolStripMenuItem.Enabled = false;

                cancelToolStripMenuItem.Enabled = false;
            }
            else
            {
                switch (CurrentFunction)
                {

                    case FunctionsEnum.Trim2:
                    case FunctionsEnum.Mline:
                    case FunctionsEnum.Lines:
                    case FunctionsEnum.LwPolyline:
                    case FunctionsEnum.Polyline:
                        enterToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = true;

                        cancelToolStripMenuItem.Enabled = true;
                        break;
                    case FunctionsEnum.Trim1:

                        enterToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = false;

                        cancelToolStripMenuItem.Enabled = true;
                        break;
                    case FunctionsEnum.GetEntities:

                        enterToolStripMenuItem.Enabled = true;
                        closeToolStripMenuItem.Enabled = false;

                        cancelToolStripMenuItem.Enabled = false;
                        break;
                }
            }

        }

        private void menuLastCommand_Click(object sender, EventArgs e)
        {
            ClickLastCommand();
        }

        private void ClickLastCommand()
        {
            switch (LastCommand)
            {
                case Commands.LEADER:

                    CurrentFunction = FunctionsEnum.Leader1;
                    CheckSnap();
                    StatusLabel.Text = "Select leader start point";
                    vertexes.Clear();
                    break;
                case Commands.LINE:
                    ribbonButtonDrawLineSingle_Click(null, null);
                    break;
                case Commands.POINT:
                    break;

                case Commands.LINES:
                    ribbonButtonDrawLineContinous_Click(null, null);
                    break;
                case Commands.TRACE:
                    StartDrawLineTrace();
                    break;
                case Commands.MLINE:
                    StartMultiLine();
                    break;
                case Commands.RAY:
                    ribbonButtonDrawLineRay_Click(null, null);
                    break;
                case Commands.XLINE:
                    ribbonButtonDrawContructionLine_Click(null, null);
                    break;
                case Commands.CIRCLE_Center_Radius:
                    ribbonButtonDrawCircleRadius_Click(null, null);
                    break;
                case Commands.CIRCLE_Diameter:
                    ribbonButtonDrawCircle2Points_Click(null, null);
                    break;
                case Commands.CIRCLE_3Points:
                    ribbonButtonDrawCircle3Points_Click(null, null);
                    break;
                case Commands.ELLIPSE:
                    ribbonButtonEllipse_Click(null, null);
                    break;
                case Commands.SLOT:
                    ribbonButtonDrawSlot_Click(null, null);
                    break;
                case Commands.LWPOLYLINE:
                    StartDrawLwPolyline();
                    break;
                case Commands.POLYLINE:
                    StartDrawPolyline();
                    break;
                case Commands.RECTANGLE:
                    ribbonButtonDrawPolylineRectangle_Click(null, null);
                    break;
                case Commands.POLIGON:
                    ribbonButtonDrawPolylinePolygon_Click(null, null);
                    break;
                case Commands.SOLID:
                    ribbonButtonDrawPolylineSolid_Click(null, null);
                    break;
                case Commands.SPLINE:
                    break;
                case Commands.ARCCenterStartAngleEndAngle:
                    break;
                case Commands.ARCStartPointMiddlePointEndPoint:
                    break;
                case Commands.ARCStartPointEndPointMiddlePoint:
                    break;
                case Commands.HATCH:
                    CreateHatch();
                    break;
                case Commands.HATCH_GRADIENT:
                    CreateGradientHatch();
                    break;
                case Commands.INSERT:
                    break;
                case Commands.IMAGE:
                    ribbonButtonDrawImageImage_Click(null, null);
                    break;
                case Commands.ATTACHPDF:
                    ribbonButtonDrawImagePDF_Click(null, null);
                    break;
                case Commands.TRIM:
                    break;
                case Commands.EXTEND:
                    break;
                case Commands.CHAMFER:
                    break;
                case Commands.OFFSET:
                    break;
                case Commands.JOIN:
                    break;
                case Commands.FILLET:
                    break;
                case Commands.NORMALIZE:
                    break;
                case Commands.COPY:
                    break;
                case Commands.MOVE:
                    break;
                case Commands.ROTATE:
                    break;
                case Commands.CREATEBLOCK:
                    break;
                case Commands.MIRROR:
                    break;
                case Commands.CREATELWPOLYLINE:
                    break;
                case Commands.CREATEBULGEDLWPOLYLINE:
                    break;
                case Commands.ARRAY:
                    break;
                case Commands.POLARARRAY:
                    break;
                case Commands.EXPLODEINSERT:
                    break;
                case Commands.EXPLODEDIMENSION:
                    break;
                case Commands.EXPLODEPOLYLINE:
                    break;
                case Commands.EXPLODESPLINE:
                    break;
                case Commands.EXPLODECIRCLE:
                    break;
                case Commands.EXPLODEELLIPSE:
                    break;
                case Commands.EXPLODEREGION:
                    break;
                case Commands.DIMENSION:
                    break;
                case Commands.TEXT:
                    break;
                case Commands.DISTANCE:
                    break;
                case Commands.AREA:
                    break;

            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (CurrentFunction)
            {

                case FunctionsEnum.Mline:
                    dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddMline(vertexes, true, m_mlineScale, dxfReaderNETControl1.DXF.CurrentColor.Index));
                    vertexes.Clear();
                    break;
                case FunctionsEnum.Lines:
                    DrawLines();
                    break;
                case FunctionsEnum.LwPolyline:
                    CreateLwPolyline(true);
                    break;
                case FunctionsEnum.Polyline:

                    CreatePolyline(true);


                    break;

                case FunctionsEnum.Spline:
                    CreateSpline(true);

                    break;
            }
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            CurrentFunction = FunctionsEnum.None;

        }


        private void enterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            switch (CurrentFunction)
            {
                case FunctionsEnum.Mline:
                    dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddMline(vertexes, false, m_mlineScale, dxfReaderNETControl1.DXF.CurrentColor.Index));
                    vertexes.Clear();
                    break;
                case FunctionsEnum.Lines:
                    DrawLines(false);
                    dxfReaderNETControl1.Refresh();
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    CurrentFunction = FunctionsEnum.None;
                    break;
                case FunctionsEnum.LwPolyline:
                    CreateLwPolyline(false);
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    CurrentFunction = FunctionsEnum.None;
                    break;
                case FunctionsEnum.Polyline:

                    CreatePolyline(false);
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    CurrentFunction = FunctionsEnum.None;

                    break;

                case FunctionsEnum.Spline:
                    CreateSpline(false);

                    break;

                case FunctionsEnum.Trim2:


                    break;
                case FunctionsEnum.Trim1:

                    StatusLabel.Text = "Select objects to trim. ESC or right click to end.";
                    CurrentFunction = FunctionsEnum.Trim2;
                    break;

                default:
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    CurrentFunction = FunctionsEnum.None;
                    StatusLabel.Text = "";
                    break;
            }

        }
        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.None;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            StatusLabel.Text = "";
            dxfReaderNETControl1.Refresh();
        }
        private void DrawLines(bool closed = true)
        {
            for (int k = 0; k < vertexes.Count - 1; k++)
            {
                dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddLine(new Vector3(vertexes[k].X, vertexes[k].Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(vertexes[k + 1].X, vertexes[k + 1].Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index));

            }

            if (closed)
                dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddLine(new Vector3(vertexes[vertexes.Count - 1].X, vertexes[vertexes.Count - 1].Y, dxfReaderNETControl1.DXF.CurrentElevation), new Vector3(vertexes[0].X, vertexes[0].Y, dxfReaderNETControl1.DXF.CurrentElevation), dxfReaderNETControl1.DXF.CurrentColor.Index));

        }
        private void CreateSpline(bool closed = false)
        {
            List<SplineVertex> splinevertexes = new List<SplineVertex>();
            foreach (Vector2 v in vertexes)
            {
                SplineVertex splinevertex = new SplineVertex(v.X, v.Y, dxfReaderNETControl1.DXF.CurrentElevation);

                splinevertexes.Add(splinevertex);
            }

            if (closed)
            {
                splinevertexes.Add(splinevertexes[0]);
            }

            dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddSpline(splinevertexes, closed, dxfReaderNETControl1.DXF.CurrentColor.Index));
        }
        private void CreateLwPolyline(bool closed = false)
        {
            //InitStatus();
            List<LwPolylineVertex> lwpolyvertexes = new List<LwPolylineVertex>();
            foreach (Vector2 v in vertexes)
            {
                LwPolylineVertex polyvertex = new LwPolylineVertex(v.X, v.Y);
                polyvertex.StartWidth = dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth;
                polyvertex.EndWidth = dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth;
                lwpolyvertexes.Add(polyvertex);
            }
            bool isClosed = closed;
            dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddLightWeightPolyline(lwpolyvertexes, isClosed, dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth, dxfReaderNETControl1.DXF.CurrentColor.Index));

            //vertexes.Clear();
        }

        private void CreatePolyline(bool closed = false)
        {
            //InitStatus();
            List<PolylineVertex> polyvertexes = new List<PolylineVertex>();
            foreach (Vector2 v in vertexes)
            {
                PolylineVertex polyvertex = new PolylineVertex(v.X, v.Y, 0);

                polyvertex.StartWidth = dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth;
                polyvertex.EndWidth = dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth;
                polyvertexes.Add(polyvertex);
            }
            bool isClosed = closed;// MessageBox.Show("Close?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
            dxfReaderNETControl1.DrawEntity(dxfReaderNETControl1.AddPolyline(polyvertexes, isClosed, dxfReaderNETControl1.DXF.DrawingVariables.Polylinewidth, dxfReaderNETControl1.DXF.CurrentColor.Index));

            //vertexes.Clear();
        }


        private void ribbonButtonGrabPoints_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.HighlightGrabPoints = ribbonButtonGrabPoints.Checked;
            dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonArcCenterStartPEndP_Click(object sender, EventArgs e)
        {
            StatusLabel.Text = "Select center point";
            CurrentFunction = FunctionsEnum.ArcCenterPStartPEnd1;
            CheckSnap();
        }

        private void ribbonButtonObjectSnapGeometricCenter_Click(object sender, EventArgs e)
        {
            SetObjectSnapMode();
        }

        private void ribbonButtonObjectSnapClear_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ObjectOsnapMode = ObjectOsnapTypeFlags.None;
            SetSnapRibbon();
            if (dxfReaderNETControl1.HighlightGrabPoints)
            {
                dxfReaderNETControl1.Refresh();
            }
        }

        private void ribbonButtonObjectSnapSelectAll_Click(object sender, EventArgs e)
        {
            ObjectOsnapTypeFlags m_OsnapMode = ObjectOsnapTypeFlags.None;

            m_OsnapMode |= ObjectOsnapTypeFlags.Endpoint;


            m_OsnapMode |= ObjectOsnapTypeFlags.Midpoint;


            m_OsnapMode |= ObjectOsnapTypeFlags.Center;


            m_OsnapMode |= ObjectOsnapTypeFlags.Intersection;


            m_OsnapMode |= ObjectOsnapTypeFlags.Quadrant;


            m_OsnapMode |= ObjectOsnapTypeFlags.Perpendicular;


            m_OsnapMode |= ObjectOsnapTypeFlags.Tangent;


            m_OsnapMode |= ObjectOsnapTypeFlags.Insertion;


            m_OsnapMode |= ObjectOsnapTypeFlags.Nearest;


            m_OsnapMode |= ObjectOsnapTypeFlags.Node;


            m_OsnapMode |= ObjectOsnapTypeFlags.GeometricCenter;

            dxfReaderNETControl1.ObjectOsnapMode = m_OsnapMode;
            SetSnapRibbon();
            if (dxfReaderNETControl1.HighlightGrabPoints)
            {
                dxfReaderNETControl1.Refresh();
            }
        }

        private void ribbonButtonModifyLw2Poly_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Lw2Poly;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select light weight polyline entity";
        }

        private void ribbonButtonModifyPoly2Lw_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Poly2Lw;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select polyline entity";
        }

        private void ribbonButtonTablesLayers_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();



            foreach (DXFReaderNET.Tables.Layer layer in dxfReaderNETControl1.DXF.Layers)
            {
                string codeName = layer.Name;
                if (codeName.ToLower() != "0")
                {
                    deleteEntities.checkedListBox1.Items.Add(codeName, CheckState.Unchecked);
                }


            }



            deleteEntities.Text = "Delete layers";
            deleteEntities.ButtonOk.Text = "Delete selected layers";


            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure? Only layers without entities will be deleted.", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    SaveUndo();

                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string layereName = deleteEntities.checkedListBox1.CheckedItems[x].ToString();//.Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        dxfReaderNETControl1.DXF.RemoveObject(dxfReaderNETControl1.DXF.Layers[layereName].Handle);


                    }


                }
            }
        }

        private void ribbonButtonModVisibilityOff_Click(object sender, EventArgs e)
        {
            if (dxfReaderNETControl1.DXF.SelectedEntities.Count > 0)
            {
                foreach (EntityObject ent in dxfReaderNETControl1.DXF.SelectedEntities)
                {
                    ent.IsVisible = false;


                }
                dxfReaderNETControl1.Refresh();
            }
        }

        private void ribbonButtonModVisibilityOn_Click(object sender, EventArgs e)
        {
            bool oneInvisible = false;
            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {
                if (!ent.IsVisible)
                {
                    ent.IsVisible = true;
                    oneInvisible = true;
                }



            }
            if (oneInvisible)
                dxfReaderNETControl1.Refresh();
        }

        private void ribbonButtonSelectGroup_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();


            var myGroups = new Dictionary<string, int>();
            if (dxfReaderNETControl1.DXF.Groups != null)
            {
                foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                {
                    //RibbonButton newItem = new RibbonButton();
                    //newItem.Text = _group.Name;
                    //ribbonButtonModPropGroup.DropDownItems.Add(newItem);

                    myGroups.Add(_group.Name, _group.Entities.Count);

                }
            }




            myGroups = myGroups.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var key in myGroups.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myGroups[key].ToString() + ")", CheckState.Unchecked);

            }
            deleteEntities.Text = "Select entities by group";
            deleteEntities.ButtonOk.Text = "Select entities";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {
                    dxfReaderNETControl1.DXF.SelectedEntities.Clear();
                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string sType = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        foreach (EntityObject ent in dxfReaderNETControl1.DXF.Groups[sType].Entities)
                        {
                            if (ent.IsVisible && dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsVisible && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsLocked)
                            {

                                if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                                {
                                    dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);

                                }

                            }
                        }

                    }
                    ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();


                    dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);



                }

            }
        }

        private void ribbonButtonDeleteZeroLen_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                List<EntityObject> entitesToDelete = dxfReaderNETControl1.CoincidentEntities();
                int prec = dxfReaderNETControl1.DXF.DrawingVariables.LUprec - 1;
                foreach (EntityObject entity in dxfReaderNETControl1.DXF.Entities)
                {

                    switch (entity.Type)
                    {


                        case EntityType.Line:
                            Line myLine = (Line)entity;

                            if (Math.Round(myLine.Lenght, prec) == 0)
                                entitesToDelete.Add(myLine);
                            break;
                        case EntityType.Arc:
                            Arc myArc = (Arc)entity;
                            if (Math.Round(myArc.Lenght, prec) == 0)
                                entitesToDelete.Add(myArc);
                            break;

                        case EntityType.Circle:
                            Circle myCircle = (Circle)entity;
                            if (Math.Round(myCircle.Lenght, prec) == 0)
                                entitesToDelete.Add(myCircle);

                            break;
                        case EntityType.Ellipse:
                            Ellipse myEllipse = (Ellipse)entity;
                            if (Math.Round(myEllipse.Lenght, prec) == 0)
                                entitesToDelete.Add(myEllipse);

                            break;
                        case EntityType.LightWeightPolyline:
                            LwPolyline myLwPolyline = (LwPolyline)entity;
                            if (Math.Round(myLwPolyline.Lenght, prec) == 0)
                                entitesToDelete.Add(myLwPolyline);
                            break;

                        case EntityType.Polyline:
                            Polyline myPolyline = (Polyline)entity;
                            if (Math.Round(myPolyline.Lenght, prec) == 0)
                                entitesToDelete.Add(myPolyline);
                            break;
                        //case EntityType.Spline:
                        //    Spline mySpline = (Spline)entity;
                        //    if (Math.Round(mySpline.Area, prec) == 0)
                        //        entitesToDelete.Add(mySpline);
                        //    break;

                        case EntityType.Solid:
                            Solid mySolid = (Solid)entity;
                            if (Math.Round(mySolid.Area, prec) == 0)
                                entitesToDelete.Add(mySolid);
                            break;

                        case EntityType.Trace:
                            Trace myTrace = (Trace)entity;
                            if (Math.Round(myTrace.Lenght, prec) == 0)
                                entitesToDelete.Add(myTrace);
                            break;




                    }
                }


                if (entitesToDelete.Count > 0)
                {
                    SaveUndo();
                    dxfReaderNETControl1.DXF.RemoveEntities(entitesToDelete);
                    //dxfReaderNETControl1.DXF.ModifyEntities(entitesToDelete,Vector2.Zero,new Vector2(100, 100),1,0);
                    dxfReaderNETControl1.Refresh();




                }
            }
        }



        private void ribbonButtonDeleteGroup_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();


            var myGroups = new Dictionary<string, int>();
            if (dxfReaderNETControl1.DXF.Groups != null)
            {
                foreach (DXFReaderNET.Objects.Group _group in dxfReaderNETControl1.DXF.Groups)
                {


                    myGroups.Add(_group.Name, _group.Entities.Count);

                }
            }




            myGroups = myGroups.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);


            foreach (var key in myGroups.Keys)
            {
                deleteEntities.checkedListBox1.Items.Add(key + " (" + myGroups[key].ToString() + ")", CheckState.Unchecked);

            }
            deleteEntities.Text = "Delete group definitions";
            deleteEntities.ButtonOk.Text = "Delete group definitions";
            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (deleteEntities.checkedListBox1.CheckedItems.Count > 0)
                {
                    if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        SaveUndo();
                        for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                        {
                            string sType = deleteEntities.checkedListBox1.CheckedItems[x].ToString().Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();
                            dxfReaderNETControl1.DXF.Groups.Remove(dxfReaderNETControl1.DXF.Groups[sType]);


                        }
                    }




                }
            }
        }

               
        private void ribbonButtonTablesDimStyles_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();



            foreach (DXFReaderNET.Tables.DimensionStyle dimstyle in dxfReaderNETControl1.DXF.DimensionStyles)
            {
                string codeName = dimstyle.Name;
                if (codeName.ToLower() != "standard")
                {
                    deleteEntities.checkedListBox1.Items.Add(codeName, CheckState.Unchecked);
                }


            }



            deleteEntities.Text = "Delete dimension styles";
            deleteEntities.ButtonOk.Text = "Delete selected dim. styles";


            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure? Only dimension styles without entities will be deleted.", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveUndo();
                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string itemName = deleteEntities.checkedListBox1.CheckedItems[x].ToString();//.Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        dxfReaderNETControl1.DXF.RemoveObject(dxfReaderNETControl1.DXF.DimensionStyles[itemName].Handle);


                    }


                }
            }
        }

        private void ribbonButtonTablesTextStyles_Click(object sender, EventArgs e)
        {
            DeleteEntities deleteEntities = new DeleteEntities();



            foreach (DXFReaderNET.Tables.TextStyle textstile in dxfReaderNETControl1.DXF.TextStyles)
            {
                string codeName = textstile.Name;
                if (codeName.ToLower() != "standard")
                {
                    deleteEntities.checkedListBox1.Items.Add(codeName, CheckState.Unchecked);
                }


            }



            deleteEntities.Text = "Delete text styles";
            deleteEntities.ButtonOk.Text = "Delete selected text style";


            DialogResult result = deleteEntities.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (MessageBox.Show("Are you sure? Only text styles without entities will be deleted.", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SaveUndo();
                    for (int x = 0; x < deleteEntities.checkedListBox1.CheckedItems.Count; x++)
                    {
                        string lTypeName = deleteEntities.checkedListBox1.CheckedItems[x].ToString();//.Substring(0, deleteEntities.checkedListBox1.CheckedItems[x].ToString().IndexOf(" (")).Trim();

                        dxfReaderNETControl1.DXF.RemoveObject(dxfReaderNETControl1.DXF.TextStyles[lTypeName].Handle);


                    }


                }
            }
        }

        private void AutoJoinEntities(IEnumerable<EntityObject> Entities)
        {

            List<Vector2> pointsNotConnected = dxfReaderNETControl1.DXF.NotConnectedPoints(Entities);
            //MathHelper.Epsilon = Math.Pow(10, -dxfReaderNETControl1.DXF.DrawingVariables.LUprec);
            double eps = Math.Pow(10, -dxfReaderNETControl1.DXF.DrawingVariables.LUprec) * 2;
            int n = 0;
            List<Vector2> points1 = new List<Vector2>();
            List<Vector2> points2 = new List<Vector2>();

            if (pointsNotConnected.Count > 1)
            {

                do
                {

                    for (int k = 0; k < pointsNotConnected.Count; k++)
                    {
                        for (int j = k + 1; j < pointsNotConnected.Count; j++)
                        {
                            double d = Vector2.Distance(pointsNotConnected[k], pointsNotConnected[j]);

                            if (d < eps)
                            {
                                //if (!points1.Contains(pointsNotConnected[k]) && !points2.Contains(pointsNotConnected[j]))
                                //{




                                points1.Add(pointsNotConnected[k]);
                                points2.Add(pointsNotConnected[j]);

                                //}

                            }
                        }
                    }

                    n++;
                } while (points1.Count < pointsNotConnected.Count / 2 && n < 10000);


            }
            List<EntityObject> allEntities = new List<EntityObject>();
            foreach (EntityObject entity in Entities)
            {

                allEntities.Add(entity);
            }
            for (int k = 0; k < points1.Count; k++)
            {
                EntityObject e1 = dxfReaderNETControl1.GetEntity(allEntities, points1[k]);
                if (e1 != null)
                    allEntities.Remove(e1);
                EntityObject e2 = dxfReaderNETControl1.GetEntity(allEntities, points2[k]);

                //dxfReaderNETControl1.AddLine(points1[k].ToVector3(), points2[k].ToVector3());
                dxfReaderNETControl1.Join(e1, e2, points1[k]);
            }
            //System.Diagnostics.Debugger.Break(); //stop




        }

        private void copyDisplayedAreaToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(dxfReaderNETControl1.Image);
            StatusLabel.Text = "Displayed image copied to clipboard";
        }

        private void deleteSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ribbonButtonModyfiSelectClear_Click(null, null);
        }

        private void selectEntitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ribbonButtonModifySelectSingleMulti_Click(null, null);
        }

        private void ribbonButtonSplitSections_Click(object sender, EventArgs e)
        {
            string dxfFileName = "";

            if (dxfReaderNETControl1.FileName != null)
            {
                dxfFileName = dxfReaderNETControl1.FileName;





                folderBrowserDialog1.SelectedPath = CurrentSaveDXFPath;
                if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                {

                    StatusLabel.Text = "Export start";
                    Application.DoEvents();
                    string dxfFname = dxfFileName;
                    string sectionsFileNamesPre = folderBrowserDialog1.SelectedPath + "\\" + Path.GetFileName(dxfFileName.Replace(".dxf", "")) + "_";
                    string secName = "";
                    string righe = "";

                    int n = 0;
                    foreach (string line in System.IO.File.ReadLines(dxfFname))
                    {
                        if (line.Trim().ToUpper() == "SECTION")
                        {
                            n = 0;
                        }
                        if (n == 2)
                        {
                            secName = line;
                        }
                        n++;
                        righe += line + System.Environment.NewLine;
                        if (line.Trim().ToUpper() == "ENDSEC")
                        {
                            System.IO.File.WriteAllText(sectionsFileNamesPre + secName + ".txt", righe);
                            righe = "";
                            ErrorLabel.Text = "Section " + secName + " exported";
                            Application.DoEvents();
                        }
                    }

                    //split delle entities
                    //string entfile = sectionsFileNamesPre + "ENTITIES.txt";
                    //string handle = "";
                    //righe = "";
                    //n = 0;
                    //foreach (string line in System.IO.File.ReadLines(entfile))
                    //{
                    //    if (line.Trim().ToUpper() == "LEADER")
                    //    {
                    //        n = 0;
                    //    }
                    //    if (n == 2)
                    //    {
                    //        handle = line;
                    //    }



                    //    n++;
                    //    righe += line + System.Environment.NewLine;
                    //    if (line.Trim().ToUpper() == "ENDSEC")
                    //    {
                    //        System.IO.File.WriteAllText(sectionsFileNamesPre + secName + ".txt", righe);
                    //        righe = "";
                    //    }
                    //}
                    ErrorLabel.Text = "";
                    StatusLabel.Text = "Export ended";

                }
            }
        }

        private void ribbonButtonObjectByHandle_Click(object sender, EventArgs e)
        {
            string handle = "";
            if (ShowInputDialog(ref handle, "Object handle", false) == DialogResult.OK)
            {
                if (handle != "")
                {

                    dxfReaderNETControl1.ShowProperties(handle);
                }
            }
        }

        private void ribbonButtonModifyExplodeEllipseArcs_Click(object sender, EventArgs e)
        {
            string inputValue = m_precision.ToString();

            if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            {
                m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                if (m_precision > 5)
                {
                    CurrentFunction = FunctionsEnum.ExplodeEllipseArcs;
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
                    StatusLabel.Text = "Select ellipse entity";
                }
                else
                {
                    CurrentFunction = FunctionsEnum.None;
                    StatusLabel.Text = "Precision is too little";
                }
            }
        }

        private void ribbonButtonModifyExplode_DropDownShowing(object sender, EventArgs e)
        {
            ribbonButtonModifyExplodeInsert.Enabled = false;
            ribbonButtonModifyExplodeDimension.Enabled = false;

            ribbonButtonModifyExplodePoly.Enabled = false;
            ribbonButtonModifyExplodeSpline.Enabled = false;
            ribbonButtonModifyExplodeCircle.Enabled = false;
            ribbonButtonModifyExplodeArc.Enabled = false;
            ribbonButtonModifyExplodeEllipse.Enabled = false;
            ribbonButtonModifyExplodeEllipseArcs.Enabled = false;
            ribbonButtonModifyExplodeCircleArcs.Enabled = false;
            ribbonButtonModifyLw2Poly.Enabled = false;
            ribbonButtonModifyPoly2Lw.Enabled = false;
            ribbonButtonModifyExplodeRegion.Enabled = false;
            ribbonButtonModifyUngroup.Enabled = false;

            if (dxfReaderNETControl1.DXF.Inserts.Count > 0)
                ribbonButtonModifyExplodeInsert.Enabled = true;

            if (dxfReaderNETControl1.DXF.Dimensions.Count > 0)
                ribbonButtonModifyExplodeDimension.Enabled = true;

            if (dxfReaderNETControl1.DXF.Splines.Count > 0)
                ribbonButtonModifyExplodeSpline.Enabled = true;

            if (dxfReaderNETControl1.DXF.Circles.Count > 0)
                ribbonButtonModifyExplodeCircle.Enabled = true;

            if (dxfReaderNETControl1.DXF.Arcs.Count > 0)
                ribbonButtonModifyExplodeArc.Enabled = true;

            if (dxfReaderNETControl1.DXF.Ellipses.Count > 0)
            {
                ribbonButtonModifyExplodeEllipse.Enabled = true;
                ribbonButtonModifyExplodeEllipseArcs.Enabled = true;
            }


            if (dxfReaderNETControl1.DXF.Circles.Count > 0)
            {

                ribbonButtonModifyExplodeCircleArcs.Enabled = true;
            }
            if (dxfReaderNETControl1.DXF.LwPolylines.Count > 0)
                ribbonButtonModifyLw2Poly.Enabled = true;

            if (dxfReaderNETControl1.DXF.LwPolylines.Count > 0 || dxfReaderNETControl1.DXF.Polylines.Count > 0)
                ribbonButtonModifyExplodePoly.Enabled = true;

            if (dxfReaderNETControl1.DXF.Polylines.Count > 0)
                ribbonButtonModifyPoly2Lw.Enabled = true;

            if (dxfReaderNETControl1.DXF.Regions.Count > 0)
                ribbonButtonModifyExplodeRegion.Enabled = true;

            if (dxfReaderNETControl1.DXF.Groups.Count > 0)
                ribbonButtonModifyUngroup.Enabled = true;



        }

        private void ribbonButtonLeader_Click(object sender, EventArgs e)
        {
            string inputValue = m_Text;
            if (ShowInputDialog(ref inputValue, "Annotation?", false) == DialogResult.OK)
            {
                m_Text = inputValue;
                LastCommand = Commands.LEADER;
                CurrentFunction = FunctionsEnum.Leader1;
                CheckSnap();
                StatusLabel.Text = "Select leader start point";
                vertexes.Clear();

            }
        }

        private void ribbonButtonModifyExplodeCircleArcs_Click(object sender, EventArgs e)
        {
            string inputValue = m_precision.ToString();

            if (ShowInputDialog(ref inputValue, "Precision", true) == DialogResult.OK)
            {
                m_precision = int.Parse(inputValue, System.Globalization.CultureInfo.CurrentCulture);
                if (m_precision > 1)
                {
                    CurrentFunction = FunctionsEnum.ExplodeCircleArcs;
                    dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquareQuestionMark;
                    StatusLabel.Text = "Select circle entity";
                }
                else
                {
                    CurrentFunction = FunctionsEnum.None;
                    StatusLabel.Text = "Precision is too little";
                }
            }
        }

        private void ribbonButtonPropertiesDimStyles_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowDimStyles();
            FillComboDimStyles();
        }

        private void ribbonButtonPropertiesLayers_Click(object sender, EventArgs e)
        {
            dxfReaderNETControl1.ShowLayers();
            LoadLayersCombo();
        }

        private void ribbonButtonViewTreeView_Click(object sender, EventArgs e)
        {
            if (ribbonButtonViewTreeView.Checked)
            {
                splitContainer1.SplitterDistance = 200;
                splitContainer1.IsSplitterFixed = false;
                TreeView1.Visible = true;
                RefreshTree();
            }
            else
            {
                splitContainer1.SplitterDistance = 0;
                splitContainer1.IsSplitterFixed = true;
                TreeView1.Visible = false;
            }
        }

        private void ribbonButtonContinuosSelection_Click(object sender, EventArgs e)
        {
            m_ContinuousSelection = ribbonButtonContinuosSelection.Checked;
            ribbonButtonModifySelectSingleMulti.Enabled = !m_ContinuousSelection;
            ribbonButtonModifySelectSinlge.Enabled = !m_ContinuousSelection;

            CheckContinuousSelection();
            StatusLabel.Text = "";
        }

        private void ribbonButtonSelectExtCont_Click(object sender, EventArgs e)
        {
            DateTime StartTime = DateTime.Now;
            dxfReaderNETControl1.DXF.SelectedEntities.Clear();

            dxfReaderNETControl1.DXF.SelectedEntities.AddRange(MathHelper.ExternalContour(dxfReaderNETControl1.DXF.Entities));

            dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);




            TimeSpan ElapsedTime = DateTime.Now.Subtract(StartTime);
            toolStripStatusLabelInfo.Text = "Time: " + ElapsedTime.ToString(@"s\.fff\s");
        }

        private void ribbonButtonSelectNumber_Click(object sender, EventArgs e)
        {
            string number = "";
            if (ShowInputDialog(ref number, "Select entity with number", false) == DialogResult.OK)
            {
                if (number != "")
                {

                    EntityObject ent = null;
                    try
                    {
                        ent = dxfReaderNETControl1.DXF.Entities[Int32.Parse(number)];
                    }
                    catch { }
                    if (ent != null)
                    {
                        if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                        {
                            dxfReaderNETControl1.DXF.SelectedEntities.Add(ent);
                            ribbonButtonShowSelectedEntitiesInfo.Enabled = EntitesSelected();
                        }

                        dxfReaderNETControl1.HighLight(ent);
                    }
                    else
                    {
                        StatusLabel.Text = "No entity found";
                        dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
                    }
                }
            }
        }

        private void ribbonButtonAllButSelected_Click(object sender, EventArgs e)
        {


            List<EntityObject> toSelect = new List<EntityObject>();
            foreach (EntityObject ent in dxfReaderNETControl1.DXF.Entities)
            {
                if (ent.IsVisible && dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsVisible && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsFrozen && !dxfReaderNETControl1.DXF.Layers[ent.Layer.Name].IsLocked)
                {
                    if (!dxfReaderNETControl1.DXF.SelectedEntities.Contains(ent))
                    {
                        toSelect.Add(ent);

                    }

                }
            }
            dxfReaderNETControl1.DXF.SelectedEntities.Clear();
            dxfReaderNETControl1.DXF.SelectedEntities.AddRange(toSelect);
            dxfReaderNETControl1.Refresh();
            dxfReaderNETControl1.HighLight(dxfReaderNETControl1.DXF.SelectedEntities);
        }

        private void CheckContinuousSelection()
        {
            if (m_ContinuousSelection)
            {
                CurrentFunction = FunctionsEnum.GetEntities;
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            }
            else
            {
                CurrentFunction = FunctionsEnum.None;
                dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            }
        }

        public static string EntityInfo(DXFReaderNETControl myDXF, EntityObject ent)
        {
            string s = "";
            string colorE = ent.Color.ToString();
            if (colorE == "ByLayer") colorE = myDXF.DXF.Layers[ent.Layer.Name].Color.ToString();

            switch (colorE)
            {
                case "1":
                    colorE = "Red";
                    break;
                case "2":
                    colorE = "Yellow";
                    break;
                case "3":
                    colorE = "Green";
                    break;
                case "4":
                    colorE = "Cyan";
                    break;
                case "5":
                    colorE = "Blue";
                    break;
                case "6":
                    colorE = "Magenta";
                    break;
                case "7":
                    colorE = "White";
                    break;
            }



            string ltE = ent.Linetype.Name;
            if (ltE == "ByLayer") ltE = myDXF.DXF.Layers[ent.Layer.Name].Linetype.Name;


            s = "Entity type: " + ent.Type.ToString() + "  - Color: " + colorE + " - Layer: " + ent.Layer.Name + " - Linetype: " + ltE;

            switch (ent.Type)
            {
                case EntityType.Line:
                    s += " - Length: " + myDXF.DXF.ToFormattedUnit(((Line)ent).Lenght);
                    s += " - Start point: (" + myDXF.DXF.ToFormattedUnit(((Line)ent).StartPoint.X) + ";" + myDXF.DXF.ToFormattedUnit(((Line)ent).StartPoint.Y) + ")";
                    s += " - End point: (" + myDXF.DXF.ToFormattedUnit(((Line)ent).EndPoint.X) + ";" + myDXF.DXF.ToFormattedUnit(((Line)ent).EndPoint.Y) + ")";

                    break;
                case EntityType.XLine:

                    s += " - Origin: (" + myDXF.DXF.ToFormattedUnit(((XLine)ent).Origin.X) + ";" + myDXF.DXF.ToFormattedUnit(((XLine)ent).Origin.Y) + ")";
                    s += " - Direction: (" + myDXF.DXF.ToFormattedUnit(((XLine)ent).Direction.X) + ";" + myDXF.DXF.ToFormattedUnit(((XLine)ent).Direction.Y) + ")";

                    break;
                case EntityType.Ray:

                    s += " - Origin: (" + myDXF.DXF.ToFormattedUnit(((Ray)ent).Origin.X) + ";" + myDXF.DXF.ToFormattedUnit(((Ray)ent).Origin.Y) + ")";
                    s += " - Direction: (" + myDXF.DXF.ToFormattedUnit(((Ray)ent).Direction.X) + ";" + myDXF.DXF.ToFormattedUnit(((Ray)ent).Direction.Y) + ")";

                    break;
                case EntityType.Arc:
                    s += " - Length: " + myDXF.DXF.ToFormattedUnit(((Arc)ent).Lenght);
                    s += " - Start point: (" + myDXF.DXF.ToFormattedUnit(((Arc)ent).StartPoint.X) + ";" + myDXF.DXF.ToFormattedUnit(((Arc)ent).StartPoint.Y) + ")";
                    s += " - End point: (" + myDXF.DXF.ToFormattedUnit(((Arc)ent).EndPoint.X) + ";" + myDXF.DXF.ToFormattedUnit(((Arc)ent).EndPoint.Y) + ")";
                    s += " - Start angle [°]: " + myDXF.DXF.ToFormattedUnit(((Arc)ent).StartAngle);
                    s += " - End angle  [°]: " + myDXF.DXF.ToFormattedUnit(((Arc)ent).EndAngle);
                    s += " - Radius: " + myDXF.DXF.ToFormattedUnit(((Arc)ent).Radius);
                    break;
                case EntityType.Circle:
                    s += " - Length: " + myDXF.DXF.ToFormattedUnit(((Circle)ent).Lenght);
                    s += " - Area: " + myDXF.DXF.ToFormattedUnit(((Circle)ent).Area);
                    s += " - Center point: (" + myDXF.DXF.ToFormattedUnit(((Circle)ent).Center.X) + ";" + myDXF.DXF.ToFormattedUnit(((Circle)ent).Center.Y) + ")";
                    s += " - Radius: " + myDXF.DXF.ToFormattedUnit(((Circle)ent).Radius);

                    break;
                case EntityType.LightWeightPolyline:
                    s += " - Length: " + myDXF.DXF.ToFormattedUnit(((LwPolyline)ent).Lenght);
                    if (((LwPolyline)ent).IsClosed)
                        s += " - Area: " + myDXF.DXF.ToFormattedUnit(((LwPolyline)ent).Area);

                    s += " - Vertexes #: " + ((LwPolyline)ent).Vertexes.Count.ToString();
                    break;
                case EntityType.Polyline:
                    s += " - Length: " + myDXF.DXF.ToFormattedUnit(((Polyline)ent).Lenght);
                    if (((Polyline)ent).IsClosed)
                        s += " - Area: " + myDXF.DXF.ToFormattedUnit(((Polyline)ent).Area);
                    s += " - Vertexes #: " + ((Polyline)ent).Vertexes.Count.ToString();
                    break;

                case EntityType.Insert:

                    s += " - Insert point: (" + myDXF.DXF.ToFormattedUnit(((Insert)ent).Position.X) + ";" + myDXF.DXF.ToFormattedUnit(((Insert)ent).Position.Y) + ")";
                    s += " - Block name: " + ((Insert)ent).Block.Name;

                    break;
            }


            foreach (DXFReaderNET.Objects.Group _group in myDXF.DXF.Groups)
            {
                if (_group.Entities.Contains(ent))
                {
                    s += " Group: " + _group.Name;
                    break;
                }

            }

            return s;
        }

        private void ribbonButtonRecoverDXFFIle_Click(object sender, EventArgs e)
        {

            StatusLabel.Text = "";
            ErrorLabel.Text = "";
            openFileDialog1.Title = "Recover DXF file";
            openFileDialog1.DefaultExt = "dxf";
            openFileDialog1.Filter = "DXF|*.dxf|All files (*.*)|*.*";
            openFileDialog1.FileName = "";
            openFileDialog1.InitialDirectory = CurrentLoadRecoveryDXFPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                CurrentLoadRecoveryDXFPath = Path.GetDirectoryName(openFileDialog1.FileName);
                dxfReaderNETControl1.RecoverDXFFile(openFileDialog1.FileName);
            }
        }


        private void ribbonButtonJoinTwoEntities_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Join1;

            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHairSquare;
            StatusLabel.Text = "Select first object";
        }

        private void ribbonButtonAutoJoinWindow_Click(object sender, EventArgs e)
        {
            CurrentFunction = FunctionsEnum.Connect1;
            dxfReaderNETControl1.CustomCursor = CustomCursorType.CrossHair;
            StatusLabel.Text = "Select start point of the window";
        }

        private void ribbonButtonAutoJoinAll_Click(object sender, EventArgs e)
        {


            if (MessageBox.Show("Are you sure?", "DXFReader.NET Demo Program", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveUndo();
                AutoJoinEntities(dxfReaderNETControl1.DXF.Entities);
                dxfReaderNETControl1.Refresh();

            }
        }



        private void txtCommand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string[] coords = txtCommand.Text.Trim().Split((char)44);
                double coordX = 0;
                double coordY = 0;
                float output;


                if (float.TryParse(coords[0], out output))
                {
                    coordX = double.Parse(coords[0].Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);

                }
                if (CurrentFunction == FunctionsEnum.Rectangle0)
                {
                    m_RectangleFilletRadius = coordX;

                    CurrentFunction = FunctionsEnum.Rectangle1;

                    StatusLabel.Text = "Select start corner of the rectangle";
                    LastCommand = Commands.RECTANGLE;
                    CheckSnap();
                    return;
                }



                if (coords.Length == 2)
                {
                    if (float.TryParse(coords[1], out output))
                    {

                        coordY = double.Parse(coords[1].Replace(",", "."), System.Globalization.CultureInfo.InvariantCulture);
                    }
                }
                p = new Vector2(coordX, coordY);
                switch (CurrentFunction)
                {
                    case FunctionsEnum.Circle2:
                        p = p1 + new Vector2(coordX, coordY);
                        break;
                }
                setPoint();
                if ((CurrentFunction == FunctionsEnum.LwPolyline || CurrentFunction == FunctionsEnum.Mline) && labelCommands.Visible)
                {
                    ShowCommandLine();
                }
                if (m_LastAddedEntity != null)
                {
                    if (m_LastAddedEntity.Type != EntityType.Hatch)
                    {
                        dxfReaderNETControl1.DrawEntity(m_LastAddedEntity);
                    }
                    else
                    {
                        dxfReaderNETControl1.Refresh();
                    }
                }
                e.Handled = true;
            }
        }

        private void txtCommand_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = CheckNumericValidChar(e.KeyChar, (sender as TextBox));
        }
        private bool CheckNumericValidChar(char key, TextBox textBox)
        {
            if (textBox.SelectedText.Length > 0 && key == '-')
            {
                return false;
            }

            if (key == (char)Keys.Escape)
            {
                return true;
            }

           
            if (!char.IsControl(key) && !char.IsDigit(key) && key != '-' && key != '.' && key != ',')
            {
                return true;
            }

            //only allow one decimal point
            //if (key == Global.decimalSeparetor && text.IndexOf(Global.decimalSeparetor) > -1)
            //{
            //    return true;
            //}

            if (key == '-' && textBox.Text.Length > 0)
            {
                return true;
            }



            return false;
        }

        private void ribbonButtonExplodeInsertAll_Click(object sender, EventArgs e)
        {
            ExplodeAllInserts(dxfReaderNETControl1);
        }

    }
}


