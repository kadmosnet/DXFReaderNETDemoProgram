namespace DXFReaderNETDemoProgram
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            DXFReaderNET.DxfDocument dxfDocument1 = new DXFReaderNET.DxfDocument();
            DXFReaderNET.AciColor aciColor1 = new DXFReaderNET.AciColor();
            DXFReaderNET.Objects.RasterVariables rasterVariables1 = new DXFReaderNET.Objects.RasterVariables();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItemNew = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemOpen = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSave = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemSaveAs = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator5 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonOrbMenuItemImport = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemExport = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonSeparator9 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonOrbMenuItemPlotPreview = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItemPlot = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbOptionButtonExit = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonButtonNew = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonOpen = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSave = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSaveAs = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotPreview = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomExt = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonUndo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRedo = new System.Windows.Forms.RibbonButton();
            this.ribbonTabHome = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelDraw = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonDrawLine = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawLineSingle = new System.Windows.Forms.RibbonButton();
            this.ribbonButton29 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton30 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawLineContinous = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator13 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawLineTrace = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonMultiLine = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator15 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawLineRay = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawContructionLine = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator6 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawPoint = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawPolyline = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawPolylineLwPolyline = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawPolylinePolyline = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator14 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawPolylineRectangle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawPolylinePolygon = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawPolylineSolid = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator16 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawPolylineSpline = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawCircle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawCircleRadius = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawCircle2Points = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawCircle3Points = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawEllipse = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator18 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDrawSlot = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonArc = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonArcCenterStartEnd = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonArcCenterStartPEndP = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonArcStartMiddleEnd = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonArcStartEndMiddle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawHatch = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawHatchNormal = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawHatchGradient = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawHatchPatterns = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawBlock = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawInsertBlock = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawImageImage = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawImagePDF = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelModify = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonModifySelect = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifySelectSinlge = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifySelectSingleMulti = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifySelectHandle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSelectNumber = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifySelectGroup = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifySelectRectangle = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifySelectAll = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAllButSelected = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator7 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButton12 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton13 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton14 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton15 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSelectGroup = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator20 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonModyfiSelectShow = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModyfiSelectClear = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator21 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonSelectContours = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSelectExtCont = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyDelete = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyDeleteSelected = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyDeleteNotSelected = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator8 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonModifyDeleteHandle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyDeleteButHandle = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator10 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonModifyRemoveBlocks = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator17 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDeleteSelectedEntities = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteEntitiesByColor = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteEntitiesByLayer = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteEntitiesByLineType = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator19 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonDeleteCoincident = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteZeroLen = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteNotConnected = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator22 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonButtonTables = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTablesDimStyles = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTablesLayers = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTablesLTYPE = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTablesTextStyles = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjects = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDeleteGroup = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyProperties = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModPropColor = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModPropLayer = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModPropLineType = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModPropLineWeight = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModPropGroup = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonGroupAdd = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModElev = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModVisibility = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModVisibilityOff = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModVisibilityOn = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyCopy = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModidyCopyCopy = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyCopyMove = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyCopyRotate = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyCopyScale = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyLines2Poly = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonLines2PolyB = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyBlock = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyRotate = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyArray = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyArrayPolar = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplode = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeInsert = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodeInserSingle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodeInsertRect = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodeInsertAll = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeDimension = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodePoly = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodePolySingle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodePolyRect = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeSpline = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodeSplineSingle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonExplodeSplineRectangle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeCircle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeArc = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeEllipse = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeEllipseArcs = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeCircleArcs = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyLw2Poly = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyPoly2Lw = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExplodeRegion = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyUngroup = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyOffset = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyTrim = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyExtend = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyFillet = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyChamfer = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonModifyJoin = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonJoinTwoEntities = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAutoJoinWindow = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAutoJoinAll = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonNormalize = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelAnnotations = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonAnnotationsText = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimension = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAligned = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAlignedLine = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionLinear = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionLinearStartEnd = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionLinearLine = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAngular = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAngular2Lines = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAngularArc = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionAngular3points = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionDiameter = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAnnotationsDimensionradius = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonLeader = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxDimensionStyle = new System.Windows.Forms.RibbonComboBox();
            this.ribbonComboBox1 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonComboBoxTextStyle = new System.Windows.Forms.RibbonComboBox();
            this.ribbonComboBoxLayout = new System.Windows.Forms.RibbonComboBox();
            this.ribbonPanelProperites = new System.Windows.Forms.RibbonPanel();
            this.ribbonComboBoxLayers = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButton1 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxLineTypes = new System.Windows.Forms.RibbonComboBox();
            this.ribbonItemGroupCurrentColor = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel3 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserColor = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonLabel1 = new System.Windows.Forms.RibbonLabel();
            this.ribbonLabelCurrentColor = new System.Windows.Forms.RibbonLabel();
            this.ribbonTextBoxElevation = new System.Windows.Forms.RibbonTextBox();
            this.ribbonTextBoxThickness = new System.Windows.Forms.RibbonTextBox();
            this.ribbonTextBoxLtScale = new System.Windows.Forms.RibbonTextBox();
            this.ribbonButtonPropertiesUnits = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPropertiesLayers = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPropertiesDimStyles = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelObjectSnap = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonObjectSnapEndpoint = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapMidpoint = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapQuadrant = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapPerpendicular = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapTangent = new System.Windows.Forms.RibbonButton();
            this.ribbonButton28 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapInsertion = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapNearest = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapNode = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapCenter = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapGeometricCenter = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapIntersection = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapSelectAll = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectSnapClear = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelNavigate = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonZoomExtents = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomLimits = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomIn = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomOut = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomWindow = new System.Windows.Forms.RibbonButton();
            this.ribbonButton10 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomPrev = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomNext = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonZoomCenter = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelView = new System.Windows.Forms.RibbonPanel();
            this.ribbonComboBox3D = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonView3DTop = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DBottom = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DLeft = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DRight = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DFront = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DBack = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DSW = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DSE = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DNE = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonView3DNW = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxRendering = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonRenderingWireframe = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRenderingShaded = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRenderingShadedEdges = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxViews = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonViewRefresh = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonOrbit3D = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonViewTreeView = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelInquiryMeasure = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonInquiryMeasure = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasureDistance = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasureArea = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasurePoly = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasureRadius = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasurecenter = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasureAreaSelected = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryMeasureFilledEmpty = new System.Windows.Forms.RibbonButton();
            this.ribbonDrawingInfo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryEntityInfo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowSelectedEntitiesInfo = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonObjectByHandle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryXdata = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonInquiryTest = new System.Windows.Forms.RibbonButton();
            this.ribbonButton1SaveTest = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPointInPolygon = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowFilledAreas = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPrintEntityProp = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPrintEntitiesList = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowData = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonTruTOPS = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonSplitSections = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRecoverDXFFIle = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelDrawMethods = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonDrawMethodsLine = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsCircle = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodstext = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsPoint = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsArc = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsImage = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsPolygon = new System.Windows.Forms.RibbonButton();
            this.ribbonColorChooserDrawMethodsColor = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonButtonDrawMethodsPenWidth = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsFill = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsStore = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClear = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearPoints = new System.Windows.Forms.RibbonButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton7 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton8 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton9 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearLines = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearCircles = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearArcs = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearPolygons = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearTexts = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawMethodsClearImages = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelHelp = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonHelpRegister = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonHelpAbout = new System.Windows.Forms.RibbonButton();
            this.ribbonTabFormat = new System.Windows.Forms.RibbonTab();
            this.ribbonPanelColors = new System.Windows.Forms.RibbonPanel();
            this.ribbonItemGroup1 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel6 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserForeColor = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup2 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel5 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserBackColor = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup3 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel7 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserGrid = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonItemGroup4 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel8 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserAxisX = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup5 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel9 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserAxisY = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup6 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel10 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserAxisZ = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonItemGroup7 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel11 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserHighlight = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup8 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel12 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserHighlightMarker = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup9 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel13 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserHighlightMarker2 = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonSeparator4 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonItemGroup10 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel14 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserAxes = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonItemGroup11 = new System.Windows.Forms.RibbonItemGroup();
            this.ribbonLabel15 = new System.Windows.Forms.RibbonLabel();
            this.ribbonColorChooserRubberBand = new System.Windows.Forms.RibbonColorChooser();
            this.ribbonButtonRubberBandStyle = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonRubberBandStyleDashed = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonRubberBandStyleSolid = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonLightColorScheme = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDefaultColorScheme = new System.Windows.Forms.RibbonButton();
            this.ribbonPanelAspect = new System.Windows.Forms.RibbonPanel();
            this.ribbonButtonShowAxes = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowBasepoint = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowLimits = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonAntialias = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowgrid = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonGridRuler = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCommandLine = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonDrawingLimits = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonHighlight = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonCheckContHighligh = new System.Windows.Forms.RibbonButton();
            this.ribbonButton11 = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonShowExtents = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonGridInsideLimits = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonGrabPoints = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonContinuosSelection = new System.Windows.Forms.RibbonButton();
            this.ribbonUpDownPickBoxSize = new System.Windows.Forms.RibbonUpDown();
            this.ribbonUpDownRubberPenWidth = new System.Windows.Forms.RibbonUpDown();
            this.ribbonUpDownZoomFactor = new System.Windows.Forms.RibbonUpDown();
            this.ribbonPanelPlotSettings = new System.Windows.Forms.RibbonPanel();
            this.ribbonComboBoxPlotMode = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonPlotModeDisplay = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotModeExtents = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotModeLimits = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotModeWindow = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotModeCentered = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxPlotRendering = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonPlotRenderingGrayScale = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotRenderingMonochrome = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotRenderingColor = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxPlotRotation = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonPlotRotationPortrait = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotRotationLandscape = new System.Windows.Forms.RibbonButton();
            this.ribbonComboBoxPlotUnits = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButtonPlotUnitsMillimeters = new System.Windows.Forms.RibbonButton();
            this.ribbonButtonPlotUnitsInchs = new System.Windows.Forms.RibbonButton();
            this.ribbonTextBoxPlotOriginX = new System.Windows.Forms.RibbonTextBox();
            this.ribbonTextBoxPlotOriginY = new System.Windows.Forms.RibbonTextBox();
            this.ribbonSeparator12 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonLabel2 = new System.Windows.Forms.RibbonLabel();
            this.ribbonUpDownPlotMarginTop = new System.Windows.Forms.RibbonUpDown();
            this.ribbonUpDownPlotMarginLeft = new System.Windows.Forms.RibbonUpDown();
            this.ribbonLabel4 = new System.Windows.Forms.RibbonLabel();
            this.ribbonUpDownPlotMarginBottom = new System.Windows.Forms.RibbonUpDown();
            this.ribbonUpDownPlotMarginRight = new System.Windows.Forms.RibbonUpDown();
            this.ribbonSeparator11 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonTextBoxPlotScale = new System.Windows.Forms.RibbonTextBox();
            this.ribbonUpDownPlotPenWidth = new System.Windows.Forms.RibbonUpDown();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ErrorLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelGrid = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelOrtho = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelSnap = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelX = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabelY = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.ribbonOrbRecentItem10 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.printPreviewControl1 = new System.Windows.Forms.PrintPreviewControl();
            this.ribbonOrbRecentItem7 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonComboBox3 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonComboBox4 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.toolStripPlotPreview = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonPlot = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.ribbonComboBox2 = new System.Windows.Forms.RibbonComboBox();
            this.ribbonDescriptionMenuItem1 = new System.Windows.Forms.RibbonDescriptionMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.imageListStatusBar = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TreeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuLastCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.enterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectEntitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.copyDisplayedAreaToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelCommands = new System.Windows.Forms.Panel();
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.labelCommands = new System.Windows.Forms.Label();
            this.dxfReaderNETControl1 = new DXFReaderNET.DXFReaderNETControl();
            this.statusStrip1.SuspendLayout();
            this.toolStripPlotPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panelCommands.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ribbon1
            // 
            this.ribbon1.BackColor = System.Drawing.SystemColors.Control;
            this.ribbon1.Cursor = System.Windows.Forms.Cursors.Default;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemNew);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemOpen);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSave);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemSaveAs);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator5);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemImport);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemExport);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonSeparator9);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemPlotPreview);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItemPlot);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.ribbonOrbOptionButtonExit);
            this.ribbon1.OrbDropDown.RecentItemsCaption = "Recent files";
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 430);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "File";
            // 
            // 
            // 
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonNew);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonOpen);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonSave);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonSaveAs);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonPlotPreview);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonZoomExt);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonUndo);
            this.ribbon1.QuickAccessToolbar.Items.Add(this.ribbonButtonRedo);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1400, 156);
            this.ribbon1.TabIndex = 14;
            this.ribbon1.Tabs.Add(this.ribbonTabHome);
            this.ribbon1.Tabs.Add(this.ribbonTabFormat);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(5, 26, 20, 0);
            this.ribbon1.TabSpacing = 4;
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Black;
            // 
            // ribbonOrbMenuItemNew
            // 
            this.ribbonOrbMenuItemNew.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.Image")));
            this.ribbonOrbMenuItemNew.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.LargeImage")));
            this.ribbonOrbMenuItemNew.Name = "ribbonOrbMenuItemNew";
            this.ribbonOrbMenuItemNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.SmallImage")));
            this.ribbonOrbMenuItemNew.Text = "New";
            this.ribbonOrbMenuItemNew.ToolTip = "Creates a new drawing";
            this.ribbonOrbMenuItemNew.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemNew.ToolTipImage")));
            this.ribbonOrbMenuItemNew.ToolTipTitle = "New";
            this.ribbonOrbMenuItemNew.Click += new System.EventHandler(this.ribbonOrbMenuItem1_Click);
            // 
            // ribbonOrbMenuItemOpen
            // 
            this.ribbonOrbMenuItemOpen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemOpen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemOpen.Image")));
            this.ribbonOrbMenuItemOpen.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemOpen.LargeImage")));
            this.ribbonOrbMenuItemOpen.Name = "ribbonOrbMenuItemOpen";
            this.ribbonOrbMenuItemOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemOpen.SmallImage")));
            this.ribbonOrbMenuItemOpen.Text = "Open";
            this.ribbonOrbMenuItemOpen.ToolTip = "Opens an existing drawing file.";
            this.ribbonOrbMenuItemOpen.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemOpen.ToolTipImage")));
            this.ribbonOrbMenuItemOpen.ToolTipTitle = "Open";
            this.ribbonOrbMenuItemOpen.Click += new System.EventHandler(this.ribbonOrbMenuItemOpen_Click);
            // 
            // ribbonOrbMenuItemSave
            // 
            this.ribbonOrbMenuItemSave.AltKey = "";
            this.ribbonOrbMenuItemSave.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.Image")));
            this.ribbonOrbMenuItemSave.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.LargeImage")));
            this.ribbonOrbMenuItemSave.Name = "ribbonOrbMenuItemSave";
            this.ribbonOrbMenuItemSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.SmallImage")));
            this.ribbonOrbMenuItemSave.Text = "Save";
            this.ribbonOrbMenuItemSave.ToolTip = "Saves current drawing.";
            this.ribbonOrbMenuItemSave.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSave.ToolTipImage")));
            this.ribbonOrbMenuItemSave.ToolTipTitle = "Save";
            this.ribbonOrbMenuItemSave.Click += new System.EventHandler(this.ribbonOrbMenuItem3_Click);
            // 
            // ribbonOrbMenuItemSaveAs
            // 
            this.ribbonOrbMenuItemSaveAs.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSaveAs.Image")));
            this.ribbonOrbMenuItemSaveAs.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSaveAs.LargeImage")));
            this.ribbonOrbMenuItemSaveAs.Name = "ribbonOrbMenuItemSaveAs";
            this.ribbonOrbMenuItemSaveAs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSaveAs.SmallImage")));
            this.ribbonOrbMenuItemSaveAs.Text = "Save as";
            this.ribbonOrbMenuItemSaveAs.ToolTip = "Saves current drawing with a new name.";
            this.ribbonOrbMenuItemSaveAs.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemSaveAs.ToolTipImage")));
            this.ribbonOrbMenuItemSaveAs.ToolTipTitle = "Save as";
            this.ribbonOrbMenuItemSaveAs.Click += new System.EventHandler(this.ribbonOrbMenuItem4_Click);
            // 
            // ribbonSeparator5
            // 
            this.ribbonSeparator5.Name = "ribbonSeparator5";
            // 
            // ribbonOrbMenuItemImport
            // 
            this.ribbonOrbMenuItemImport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemImport.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemImport.Image")));
            this.ribbonOrbMenuItemImport.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemImport.LargeImage")));
            this.ribbonOrbMenuItemImport.Name = "ribbonOrbMenuItemImport";
            this.ribbonOrbMenuItemImport.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemImport.SmallImage")));
            this.ribbonOrbMenuItemImport.Text = "Import OBJ file";
            this.ribbonOrbMenuItemImport.ToolTip = "Imports a Wavefront OBJ file";
            this.ribbonOrbMenuItemImport.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemImport.ToolTipImage")));
            this.ribbonOrbMenuItemImport.ToolTipTitle = "Import";
            this.ribbonOrbMenuItemImport.Click += new System.EventHandler(this.ribbonOrbMenuItemImport_Click);
            // 
            // ribbonOrbMenuItemExport
            // 
            this.ribbonOrbMenuItemExport.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemExport.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemExport.Image")));
            this.ribbonOrbMenuItemExport.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemExport.LargeImage")));
            this.ribbonOrbMenuItemExport.Name = "ribbonOrbMenuItemExport";
            this.ribbonOrbMenuItemExport.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemExport.SmallImage")));
            this.ribbonOrbMenuItemExport.Text = "Export image";
            this.ribbonOrbMenuItemExport.ToolTip = "Exports a bitmap image of current drawing";
            this.ribbonOrbMenuItemExport.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemExport.ToolTipImage")));
            this.ribbonOrbMenuItemExport.ToolTipTitle = "Export";
            this.ribbonOrbMenuItemExport.Click += new System.EventHandler(this.ribbonOrbMenuItemExport_Click);
            // 
            // ribbonSeparator9
            // 
            this.ribbonSeparator9.Name = "ribbonSeparator9";
            // 
            // ribbonOrbMenuItemPlotPreview
            // 
            this.ribbonOrbMenuItemPlotPreview.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemPlotPreview.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlotPreview.Image")));
            this.ribbonOrbMenuItemPlotPreview.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlotPreview.LargeImage")));
            this.ribbonOrbMenuItemPlotPreview.Name = "ribbonOrbMenuItemPlotPreview";
            this.ribbonOrbMenuItemPlotPreview.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlotPreview.SmallImage")));
            this.ribbonOrbMenuItemPlotPreview.Text = "Plot preview";
            this.ribbonOrbMenuItemPlotPreview.ToolTip = "Displays plot preview.";
            this.ribbonOrbMenuItemPlotPreview.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlotPreview.ToolTipImage")));
            this.ribbonOrbMenuItemPlotPreview.ToolTipTitle = "Plot preview";
            this.ribbonOrbMenuItemPlotPreview.Click += new System.EventHandler(this.ribbonOrbMenuItem5_Click);
            // 
            // ribbonOrbMenuItemPlot
            // 
            this.ribbonOrbMenuItemPlot.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItemPlot.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlot.Image")));
            this.ribbonOrbMenuItemPlot.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlot.LargeImage")));
            this.ribbonOrbMenuItemPlot.Name = "ribbonOrbMenuItemPlot";
            this.ribbonOrbMenuItemPlot.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlot.SmallImage")));
            this.ribbonOrbMenuItemPlot.Text = "Plot";
            this.ribbonOrbMenuItemPlot.ToolTip = "Prints the current drawing";
            this.ribbonOrbMenuItemPlot.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItemPlot.ToolTipImage")));
            this.ribbonOrbMenuItemPlot.ToolTipTitle = "Plot";
            this.ribbonOrbMenuItemPlot.Click += new System.EventHandler(this.ribbonOrbMenuItemPlot_Click);
            // 
            // ribbonOrbOptionButtonExit
            // 
            this.ribbonOrbOptionButtonExit.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButtonExit.Image")));
            this.ribbonOrbOptionButtonExit.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButtonExit.LargeImage")));
            this.ribbonOrbOptionButtonExit.Name = "ribbonOrbOptionButtonExit";
            this.ribbonOrbOptionButtonExit.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButtonExit.SmallImage")));
            this.ribbonOrbOptionButtonExit.Text = "Exit";
            this.ribbonOrbOptionButtonExit.ToolTip = "Exit program";
            this.ribbonOrbOptionButtonExit.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButtonExit.ToolTipImage")));
            this.ribbonOrbOptionButtonExit.ToolTipTitle = "Exit";
            this.ribbonOrbOptionButtonExit.Click += new System.EventHandler(this.ribbonOrbOptionButtonExit_Click);
            // 
            // ribbonButtonNew
            // 
            this.ribbonButtonNew.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNew.Image")));
            this.ribbonButtonNew.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNew.LargeImage")));
            this.ribbonButtonNew.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonNew.Name = "ribbonButtonNew";
            this.ribbonButtonNew.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNew.SmallImage")));
            this.ribbonButtonNew.Text = "ribbonButton29";
            this.ribbonButtonNew.ToolTip = "Creates a new drawing";
            this.ribbonButtonNew.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNew.ToolTipImage")));
            this.ribbonButtonNew.ToolTipTitle = "New";
            this.ribbonButtonNew.Click += new System.EventHandler(this.ribbonButtonNew_Click);
            // 
            // ribbonButtonOpen
            // 
            this.ribbonButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.Image")));
            this.ribbonButtonOpen.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.LargeImage")));
            this.ribbonButtonOpen.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonOpen.Name = "ribbonButtonOpen";
            this.ribbonButtonOpen.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.SmallImage")));
            this.ribbonButtonOpen.Text = "ribbonButtonOpen";
            this.ribbonButtonOpen.ToolTip = "Opens an existing drawing file.";
            this.ribbonButtonOpen.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOpen.ToolTipImage")));
            this.ribbonButtonOpen.ToolTipTitle = "Open";
            this.ribbonButtonOpen.Click += new System.EventHandler(this.ribbonButtonOpen_Click);
            // 
            // ribbonButtonSave
            // 
            this.ribbonButtonSave.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.Image")));
            this.ribbonButtonSave.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.LargeImage")));
            this.ribbonButtonSave.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonSave.Name = "ribbonButtonSave";
            this.ribbonButtonSave.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.SmallImage")));
            this.ribbonButtonSave.Text = "ribbonButton29";
            this.ribbonButtonSave.ToolTip = "Saves current drawing.";
            this.ribbonButtonSave.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSave.ToolTipImage")));
            this.ribbonButtonSave.ToolTipTitle = "Save";
            this.ribbonButtonSave.Click += new System.EventHandler(this.ribbonButtonSave_Click);
            // 
            // ribbonButtonSaveAs
            // 
            this.ribbonButtonSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSaveAs.Image")));
            this.ribbonButtonSaveAs.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSaveAs.LargeImage")));
            this.ribbonButtonSaveAs.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonSaveAs.Name = "ribbonButtonSaveAs";
            this.ribbonButtonSaveAs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSaveAs.SmallImage")));
            this.ribbonButtonSaveAs.Text = "ribbonButton6";
            this.ribbonButtonSaveAs.ToolTip = "Saves current drawing with a new name.";
            this.ribbonButtonSaveAs.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSaveAs.ToolTipImage")));
            this.ribbonButtonSaveAs.ToolTipTitle = "Save as";
            this.ribbonButtonSaveAs.Click += new System.EventHandler(this.ribbonButtonSaveAs_Click);
            // 
            // ribbonButtonPlotPreview
            // 
            this.ribbonButtonPlotPreview.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotPreview.Image")));
            this.ribbonButtonPlotPreview.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotPreview.LargeImage")));
            this.ribbonButtonPlotPreview.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPlotPreview.Name = "ribbonButtonPlotPreview";
            this.ribbonButtonPlotPreview.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotPreview.SmallImage")));
            this.ribbonButtonPlotPreview.Text = "ribbonButton11";
            this.ribbonButtonPlotPreview.ToolTip = "Displays plot preview.";
            this.ribbonButtonPlotPreview.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotPreview.ToolTipImage")));
            this.ribbonButtonPlotPreview.ToolTipTitle = "Plot preview";
            this.ribbonButtonPlotPreview.Click += new System.EventHandler(this.ribbonButtonPlotPreview_Click);
            // 
            // ribbonButtonZoomExt
            // 
            this.ribbonButtonZoomExt.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExt.Image")));
            this.ribbonButtonZoomExt.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExt.LargeImage")));
            this.ribbonButtonZoomExt.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomExt.Name = "ribbonButtonZoomExt";
            this.ribbonButtonZoomExt.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExt.SmallImage")));
            this.ribbonButtonZoomExt.Text = "ribbonButtonZoomExt";
            this.ribbonButtonZoomExt.ToolTip = "Zooms to display the maximum extents of all objects.";
            this.ribbonButtonZoomExt.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExt.ToolTipImage")));
            this.ribbonButtonZoomExt.ToolTipTitle = "Zoom Extents";
            this.ribbonButtonZoomExt.Click += new System.EventHandler(this.ribbonButtonZoomExt_Click);
            // 
            // ribbonButtonUndo
            // 
            this.ribbonButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.Image")));
            this.ribbonButtonUndo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.LargeImage")));
            this.ribbonButtonUndo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonUndo.Name = "ribbonButtonUndo";
            this.ribbonButtonUndo.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.SmallImage")));
            this.ribbonButtonUndo.Text = "ribbonButton29";
            this.ribbonButtonUndo.ToolTip = "Undo last action";
            this.ribbonButtonUndo.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonUndo.ToolTipImage")));
            this.ribbonButtonUndo.ToolTipTitle = "Undo";
            this.ribbonButtonUndo.Click += new System.EventHandler(this.ribbonButtonUndo_Click);
            // 
            // ribbonButtonRedo
            // 
            this.ribbonButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.Image")));
            this.ribbonButtonRedo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.LargeImage")));
            this.ribbonButtonRedo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonRedo.Name = "ribbonButtonRedo";
            this.ribbonButtonRedo.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.SmallImage")));
            this.ribbonButtonRedo.Text = "ribbonButton16";
            this.ribbonButtonRedo.ToolTip = "Redo last action";
            this.ribbonButtonRedo.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRedo.ToolTipImage")));
            this.ribbonButtonRedo.ToolTipTitle = "Redo";
            this.ribbonButtonRedo.Click += new System.EventHandler(this.ribbonButtonRedo_Click);
            // 
            // ribbonTabHome
            // 
            this.ribbonTabHome.Name = "ribbonTabHome";
            this.ribbonTabHome.Panels.Add(this.ribbonPanelDraw);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelModify);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelAnnotations);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelProperites);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelObjectSnap);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelNavigate);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelView);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelInquiryMeasure);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelDrawMethods);
            this.ribbonTabHome.Panels.Add(this.ribbonPanelHelp);
            this.ribbonTabHome.Text = "Home";
            // 
            // ribbonPanelDraw
            // 
            this.ribbonPanelDraw.ButtonMoreVisible = false;
            this.ribbonPanelDraw.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelDraw.Image")));
            this.ribbonPanelDraw.Items.Add(this.ribbonButtonDrawLine);
            this.ribbonPanelDraw.Items.Add(this.ribbonButtonDrawPolyline);
            this.ribbonPanelDraw.Items.Add(this.ribbonButtonDrawCircle);
            this.ribbonPanelDraw.Items.Add(this.ribbonButtonArc);
            this.ribbonPanelDraw.Items.Add(this.ribbonButtonDrawHatch);
            this.ribbonPanelDraw.Items.Add(this.ribbonButtonDrawBlock);
            this.ribbonPanelDraw.Name = "ribbonPanelDraw";
            this.ribbonPanelDraw.Text = "Draw";
            // 
            // ribbonButtonDrawLine
            // 
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonDrawLineSingle);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonDrawLineContinous);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonSeparator13);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonDrawLineTrace);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonMultiLine);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonSeparator15);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonDrawLineRay);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonDrawContructionLine);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonSeparator6);
            this.ribbonButtonDrawLine.DropDownItems.Add(this.ribbonButtonDrawPoint);
            this.ribbonButtonDrawLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLine.Image")));
            this.ribbonButtonDrawLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLine.LargeImage")));
            this.ribbonButtonDrawLine.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawLine.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawLine.Name = "ribbonButtonDrawLine";
            this.ribbonButtonDrawLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLine.SmallImage")));
            this.ribbonButtonDrawLine.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonDrawLine.Text = "Line";
            this.ribbonButtonDrawLine.ToolTip = "Creates LINE entities";
            this.ribbonButtonDrawLine.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLine.ToolTipImage")));
            this.ribbonButtonDrawLine.ToolTipTitle = "Line";
            this.ribbonButtonDrawLine.Click += new System.EventHandler(this.ribbonButtonDrawLine_Click);
            // 
            // ribbonButtonDrawLineSingle
            // 
            this.ribbonButtonDrawLineSingle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawLineSingle.DropDownItems.Add(this.ribbonButton29);
            this.ribbonButtonDrawLineSingle.DropDownItems.Add(this.ribbonButton30);
            this.ribbonButtonDrawLineSingle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineSingle.Image")));
            this.ribbonButtonDrawLineSingle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineSingle.LargeImage")));
            this.ribbonButtonDrawLineSingle.Name = "ribbonButtonDrawLineSingle";
            this.ribbonButtonDrawLineSingle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineSingle.SmallImage")));
            this.ribbonButtonDrawLineSingle.Text = "Single";
            this.ribbonButtonDrawLineSingle.Click += new System.EventHandler(this.ribbonButtonDrawLineSingle_Click);
            // 
            // ribbonButton29
            // 
            this.ribbonButton29.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton29.Image")));
            this.ribbonButton29.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton29.LargeImage")));
            this.ribbonButton29.Name = "ribbonButton29";
            this.ribbonButton29.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton29.SmallImage")));
            this.ribbonButton29.Text = "ribbonButton29";
            // 
            // ribbonButton30
            // 
            this.ribbonButton30.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton30.Image")));
            this.ribbonButton30.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton30.LargeImage")));
            this.ribbonButton30.Name = "ribbonButton30";
            this.ribbonButton30.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton30.SmallImage")));
            this.ribbonButton30.Text = "ribbonButton30";
            // 
            // ribbonButtonDrawLineContinous
            // 
            this.ribbonButtonDrawLineContinous.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawLineContinous.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineContinous.Image")));
            this.ribbonButtonDrawLineContinous.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineContinous.LargeImage")));
            this.ribbonButtonDrawLineContinous.Name = "ribbonButtonDrawLineContinous";
            this.ribbonButtonDrawLineContinous.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineContinous.SmallImage")));
            this.ribbonButtonDrawLineContinous.Text = "Continous";
            this.ribbonButtonDrawLineContinous.Click += new System.EventHandler(this.ribbonButtonDrawLineContinous_Click);
            // 
            // ribbonSeparator13
            // 
            this.ribbonSeparator13.Name = "ribbonSeparator13";
            // 
            // ribbonButtonDrawLineTrace
            // 
            this.ribbonButtonDrawLineTrace.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawLineTrace.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineTrace.Image")));
            this.ribbonButtonDrawLineTrace.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineTrace.LargeImage")));
            this.ribbonButtonDrawLineTrace.Name = "ribbonButtonDrawLineTrace";
            this.ribbonButtonDrawLineTrace.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineTrace.SmallImage")));
            this.ribbonButtonDrawLineTrace.Text = "Trace";
            this.ribbonButtonDrawLineTrace.Click += new System.EventHandler(this.ribbonButtonDrawLineTrace_Click);
            // 
            // ribbonButtonMultiLine
            // 
            this.ribbonButtonMultiLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonMultiLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonMultiLine.Image")));
            this.ribbonButtonMultiLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonMultiLine.LargeImage")));
            this.ribbonButtonMultiLine.Name = "ribbonButtonMultiLine";
            this.ribbonButtonMultiLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonMultiLine.SmallImage")));
            this.ribbonButtonMultiLine.Text = "Multi line";
            this.ribbonButtonMultiLine.Click += new System.EventHandler(this.ribbonButtonMultiLine_Click);
            // 
            // ribbonSeparator15
            // 
            this.ribbonSeparator15.Name = "ribbonSeparator15";
            // 
            // ribbonButtonDrawLineRay
            // 
            this.ribbonButtonDrawLineRay.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawLineRay.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineRay.Image")));
            this.ribbonButtonDrawLineRay.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineRay.LargeImage")));
            this.ribbonButtonDrawLineRay.Name = "ribbonButtonDrawLineRay";
            this.ribbonButtonDrawLineRay.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawLineRay.SmallImage")));
            this.ribbonButtonDrawLineRay.Text = "Ray";
            this.ribbonButtonDrawLineRay.Click += new System.EventHandler(this.ribbonButtonDrawLineRay_Click);
            // 
            // ribbonButtonDrawContructionLine
            // 
            this.ribbonButtonDrawContructionLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawContructionLine.DropDownItems.Add(this.ribbonButton4);
            this.ribbonButtonDrawContructionLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawContructionLine.Image")));
            this.ribbonButtonDrawContructionLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawContructionLine.LargeImage")));
            this.ribbonButtonDrawContructionLine.Name = "ribbonButtonDrawContructionLine";
            this.ribbonButtonDrawContructionLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawContructionLine.SmallImage")));
            this.ribbonButtonDrawContructionLine.Text = "Construction line";
            this.ribbonButtonDrawContructionLine.Click += new System.EventHandler(this.ribbonButtonDrawContructionLine_Click);
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.LargeImage")));
            this.ribbonButton4.Name = "ribbonButton4";
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            this.ribbonButton4.Text = "ribbonButton4";
            // 
            // ribbonSeparator6
            // 
            this.ribbonSeparator6.Name = "ribbonSeparator6";
            // 
            // ribbonButtonDrawPoint
            // 
            this.ribbonButtonDrawPoint.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPoint.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPoint.Image")));
            this.ribbonButtonDrawPoint.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPoint.LargeImage")));
            this.ribbonButtonDrawPoint.Name = "ribbonButtonDrawPoint";
            this.ribbonButtonDrawPoint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPoint.SmallImage")));
            this.ribbonButtonDrawPoint.Text = "Point";
            this.ribbonButtonDrawPoint.ToolTipTitle = "Point";
            this.ribbonButtonDrawPoint.Click += new System.EventHandler(this.ribbonButtonDrawPoint_Click);
            // 
            // ribbonButtonDrawPolyline
            // 
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonButtonDrawPolylineLwPolyline);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonButtonDrawPolylinePolyline);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonSeparator14);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonButtonDrawPolylineRectangle);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonButtonDrawPolylinePolygon);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonButtonDrawPolylineSolid);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonSeparator16);
            this.ribbonButtonDrawPolyline.DropDownItems.Add(this.ribbonButtonDrawPolylineSpline);
            this.ribbonButtonDrawPolyline.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolyline.Image")));
            this.ribbonButtonDrawPolyline.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolyline.LargeImage")));
            this.ribbonButtonDrawPolyline.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawPolyline.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawPolyline.Name = "ribbonButtonDrawPolyline";
            this.ribbonButtonDrawPolyline.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolyline.SmallImage")));
            this.ribbonButtonDrawPolyline.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonDrawPolyline.Text = "Polyline";
            this.ribbonButtonDrawPolyline.ToolTip = "Creates POLYLINE/TRACE/SPLINE entities";
            this.ribbonButtonDrawPolyline.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolyline.ToolTipImage")));
            this.ribbonButtonDrawPolyline.ToolTipTitle = "Polyline";
            this.ribbonButtonDrawPolyline.Click += new System.EventHandler(this.ribbonButtonDrawPolyline_Click);
            // 
            // ribbonButtonDrawPolylineLwPolyline
            // 
            this.ribbonButtonDrawPolylineLwPolyline.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPolylineLwPolyline.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineLwPolyline.Image")));
            this.ribbonButtonDrawPolylineLwPolyline.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineLwPolyline.LargeImage")));
            this.ribbonButtonDrawPolylineLwPolyline.Name = "ribbonButtonDrawPolylineLwPolyline";
            this.ribbonButtonDrawPolylineLwPolyline.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineLwPolyline.SmallImage")));
            this.ribbonButtonDrawPolylineLwPolyline.Text = "Lightweight polyline";
            this.ribbonButtonDrawPolylineLwPolyline.Click += new System.EventHandler(this.ribbonButtonDrawPolylineLwPolyline_Click);
            // 
            // ribbonButtonDrawPolylinePolyline
            // 
            this.ribbonButtonDrawPolylinePolyline.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPolylinePolyline.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylinePolyline.Image")));
            this.ribbonButtonDrawPolylinePolyline.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylinePolyline.LargeImage")));
            this.ribbonButtonDrawPolylinePolyline.Name = "ribbonButtonDrawPolylinePolyline";
            this.ribbonButtonDrawPolylinePolyline.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylinePolyline.SmallImage")));
            this.ribbonButtonDrawPolylinePolyline.Text = "Polyline";
            this.ribbonButtonDrawPolylinePolyline.Click += new System.EventHandler(this.ribbonButtonDrawPolylinePolyline_Click);
            // 
            // ribbonSeparator14
            // 
            this.ribbonSeparator14.Name = "ribbonSeparator14";
            // 
            // ribbonButtonDrawPolylineRectangle
            // 
            this.ribbonButtonDrawPolylineRectangle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPolylineRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineRectangle.Image")));
            this.ribbonButtonDrawPolylineRectangle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineRectangle.LargeImage")));
            this.ribbonButtonDrawPolylineRectangle.Name = "ribbonButtonDrawPolylineRectangle";
            this.ribbonButtonDrawPolylineRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineRectangle.SmallImage")));
            this.ribbonButtonDrawPolylineRectangle.Text = "Rectangle";
            this.ribbonButtonDrawPolylineRectangle.Click += new System.EventHandler(this.ribbonButtonDrawPolylineRectangle_Click);
            // 
            // ribbonButtonDrawPolylinePolygon
            // 
            this.ribbonButtonDrawPolylinePolygon.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPolylinePolygon.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylinePolygon.Image")));
            this.ribbonButtonDrawPolylinePolygon.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylinePolygon.LargeImage")));
            this.ribbonButtonDrawPolylinePolygon.Name = "ribbonButtonDrawPolylinePolygon";
            this.ribbonButtonDrawPolylinePolygon.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylinePolygon.SmallImage")));
            this.ribbonButtonDrawPolylinePolygon.Text = "Polygon";
            this.ribbonButtonDrawPolylinePolygon.Click += new System.EventHandler(this.ribbonButtonDrawPolylinePolygon_Click);
            // 
            // ribbonButtonDrawPolylineSolid
            // 
            this.ribbonButtonDrawPolylineSolid.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPolylineSolid.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineSolid.Image")));
            this.ribbonButtonDrawPolylineSolid.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineSolid.LargeImage")));
            this.ribbonButtonDrawPolylineSolid.Name = "ribbonButtonDrawPolylineSolid";
            this.ribbonButtonDrawPolylineSolid.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineSolid.SmallImage")));
            this.ribbonButtonDrawPolylineSolid.Text = "Solid";
            this.ribbonButtonDrawPolylineSolid.Click += new System.EventHandler(this.ribbonButtonDrawPolylineSolid_Click);
            // 
            // ribbonSeparator16
            // 
            this.ribbonSeparator16.Name = "ribbonSeparator16";
            // 
            // ribbonButtonDrawPolylineSpline
            // 
            this.ribbonButtonDrawPolylineSpline.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawPolylineSpline.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineSpline.Image")));
            this.ribbonButtonDrawPolylineSpline.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineSpline.LargeImage")));
            this.ribbonButtonDrawPolylineSpline.Name = "ribbonButtonDrawPolylineSpline";
            this.ribbonButtonDrawPolylineSpline.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawPolylineSpline.SmallImage")));
            this.ribbonButtonDrawPolylineSpline.Text = "Spline";
            this.ribbonButtonDrawPolylineSpline.Click += new System.EventHandler(this.ribbonButtonDrawPolylineSpline_Click);
            // 
            // ribbonButtonDrawCircle
            // 
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonButtonDrawCircleRadius);
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonButtonDrawCircle2Points);
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonButtonDrawCircle3Points);
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonSeparator1);
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonButtonDrawEllipse);
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonSeparator18);
            this.ribbonButtonDrawCircle.DropDownItems.Add(this.ribbonButtonDrawSlot);
            this.ribbonButtonDrawCircle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle.Image")));
            this.ribbonButtonDrawCircle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle.LargeImage")));
            this.ribbonButtonDrawCircle.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawCircle.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawCircle.Name = "ribbonButtonDrawCircle";
            this.ribbonButtonDrawCircle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle.SmallImage")));
            this.ribbonButtonDrawCircle.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonDrawCircle.Text = "Circle";
            this.ribbonButtonDrawCircle.ToolTip = "Creates CIRCLE entities";
            this.ribbonButtonDrawCircle.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle.ToolTipImage")));
            this.ribbonButtonDrawCircle.ToolTipTitle = "Circle";
            this.ribbonButtonDrawCircle.Click += new System.EventHandler(this.ribbonButtonDrawCircle_Click);
            // 
            // ribbonButtonDrawCircleRadius
            // 
            this.ribbonButtonDrawCircleRadius.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawCircleRadius.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircleRadius.Image")));
            this.ribbonButtonDrawCircleRadius.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircleRadius.LargeImage")));
            this.ribbonButtonDrawCircleRadius.Name = "ribbonButtonDrawCircleRadius";
            this.ribbonButtonDrawCircleRadius.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircleRadius.SmallImage")));
            this.ribbonButtonDrawCircleRadius.Text = "Center, radius";
            this.ribbonButtonDrawCircleRadius.Click += new System.EventHandler(this.ribbonButtonDrawCircleRadius_Click);
            // 
            // ribbonButtonDrawCircle2Points
            // 
            this.ribbonButtonDrawCircle2Points.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawCircle2Points.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle2Points.Image")));
            this.ribbonButtonDrawCircle2Points.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle2Points.LargeImage")));
            this.ribbonButtonDrawCircle2Points.Name = "ribbonButtonDrawCircle2Points";
            this.ribbonButtonDrawCircle2Points.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle2Points.SmallImage")));
            this.ribbonButtonDrawCircle2Points.Text = "2 points";
            this.ribbonButtonDrawCircle2Points.Click += new System.EventHandler(this.ribbonButtonDrawCircle2Points_Click);
            // 
            // ribbonButtonDrawCircle3Points
            // 
            this.ribbonButtonDrawCircle3Points.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawCircle3Points.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle3Points.Image")));
            this.ribbonButtonDrawCircle3Points.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle3Points.LargeImage")));
            this.ribbonButtonDrawCircle3Points.Name = "ribbonButtonDrawCircle3Points";
            this.ribbonButtonDrawCircle3Points.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawCircle3Points.SmallImage")));
            this.ribbonButtonDrawCircle3Points.Text = "3 points";
            this.ribbonButtonDrawCircle3Points.Click += new System.EventHandler(this.ribbonButtonDrawCircle3Points_Click);
            // 
            // ribbonSeparator1
            // 
            this.ribbonSeparator1.Name = "ribbonSeparator1";
            // 
            // ribbonButtonDrawEllipse
            // 
            this.ribbonButtonDrawEllipse.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawEllipse.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawEllipse.Image")));
            this.ribbonButtonDrawEllipse.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawEllipse.LargeImage")));
            this.ribbonButtonDrawEllipse.Name = "ribbonButtonDrawEllipse";
            this.ribbonButtonDrawEllipse.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawEllipse.SmallImage")));
            this.ribbonButtonDrawEllipse.Text = "Ellipse";
            this.ribbonButtonDrawEllipse.Click += new System.EventHandler(this.ribbonButtonDrawEllipse_Click);
            // 
            // ribbonSeparator18
            // 
            this.ribbonSeparator18.Name = "ribbonSeparator18";
            // 
            // ribbonButtonDrawSlot
            // 
            this.ribbonButtonDrawSlot.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawSlot.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawSlot.Image")));
            this.ribbonButtonDrawSlot.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawSlot.LargeImage")));
            this.ribbonButtonDrawSlot.Name = "ribbonButtonDrawSlot";
            this.ribbonButtonDrawSlot.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawSlot.SmallImage")));
            this.ribbonButtonDrawSlot.Text = "Slot";
            this.ribbonButtonDrawSlot.Click += new System.EventHandler(this.ribbonButtonDrawSlot_Click);
            // 
            // ribbonButtonArc
            // 
            this.ribbonButtonArc.DropDownItems.Add(this.ribbonButtonArcCenterStartEnd);
            this.ribbonButtonArc.DropDownItems.Add(this.ribbonButtonArcCenterStartPEndP);
            this.ribbonButtonArc.DropDownItems.Add(this.ribbonButtonArcStartMiddleEnd);
            this.ribbonButtonArc.DropDownItems.Add(this.ribbonButtonArcStartEndMiddle);
            this.ribbonButtonArc.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArc.Image")));
            this.ribbonButtonArc.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArc.LargeImage")));
            this.ribbonButtonArc.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonArc.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonArc.Name = "ribbonButtonArc";
            this.ribbonButtonArc.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArc.SmallImage")));
            this.ribbonButtonArc.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonArc.Text = "Arc";
            this.ribbonButtonArc.ToolTip = "Creates ARC entities";
            this.ribbonButtonArc.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArc.ToolTipImage")));
            this.ribbonButtonArc.ToolTipTitle = "Arc";
            this.ribbonButtonArc.Click += new System.EventHandler(this.ribbonButtonArc_Click);
            // 
            // ribbonButtonArcCenterStartEnd
            // 
            this.ribbonButtonArcCenterStartEnd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonArcCenterStartEnd.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcCenterStartEnd.Image")));
            this.ribbonButtonArcCenterStartEnd.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcCenterStartEnd.LargeImage")));
            this.ribbonButtonArcCenterStartEnd.Name = "ribbonButtonArcCenterStartEnd";
            this.ribbonButtonArcCenterStartEnd.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcCenterStartEnd.SmallImage")));
            this.ribbonButtonArcCenterStartEnd.Text = "Center point, start angle, end angle";
            this.ribbonButtonArcCenterStartEnd.Click += new System.EventHandler(this.ribbonButtonArcCenterStartEnd_Click);
            // 
            // ribbonButtonArcCenterStartPEndP
            // 
            this.ribbonButtonArcCenterStartPEndP.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonArcCenterStartPEndP.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcCenterStartPEndP.Image")));
            this.ribbonButtonArcCenterStartPEndP.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcCenterStartPEndP.LargeImage")));
            this.ribbonButtonArcCenterStartPEndP.Name = "ribbonButtonArcCenterStartPEndP";
            this.ribbonButtonArcCenterStartPEndP.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcCenterStartPEndP.SmallImage")));
            this.ribbonButtonArcCenterStartPEndP.Text = "Center point, start point, end point";
            this.ribbonButtonArcCenterStartPEndP.Click += new System.EventHandler(this.ribbonButtonArcCenterStartPEndP_Click);
            // 
            // ribbonButtonArcStartMiddleEnd
            // 
            this.ribbonButtonArcStartMiddleEnd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonArcStartMiddleEnd.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcStartMiddleEnd.Image")));
            this.ribbonButtonArcStartMiddleEnd.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcStartMiddleEnd.LargeImage")));
            this.ribbonButtonArcStartMiddleEnd.Name = "ribbonButtonArcStartMiddleEnd";
            this.ribbonButtonArcStartMiddleEnd.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcStartMiddleEnd.SmallImage")));
            this.ribbonButtonArcStartMiddleEnd.Text = "Start point, middle point, end point";
            this.ribbonButtonArcStartMiddleEnd.Click += new System.EventHandler(this.ribbonButtonArcStartMiddleEnd_Click);
            // 
            // ribbonButtonArcStartEndMiddle
            // 
            this.ribbonButtonArcStartEndMiddle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonArcStartEndMiddle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcStartEndMiddle.Image")));
            this.ribbonButtonArcStartEndMiddle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcStartEndMiddle.LargeImage")));
            this.ribbonButtonArcStartEndMiddle.Name = "ribbonButtonArcStartEndMiddle";
            this.ribbonButtonArcStartEndMiddle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonArcStartEndMiddle.SmallImage")));
            this.ribbonButtonArcStartEndMiddle.Text = "Start point, end point, middle point ";
            this.ribbonButtonArcStartEndMiddle.Click += new System.EventHandler(this.ribbonButtonArcStartEndMiddle_Click);
            // 
            // ribbonButtonDrawHatch
            // 
            this.ribbonButtonDrawHatch.DropDownItems.Add(this.ribbonButtonDrawHatchNormal);
            this.ribbonButtonDrawHatch.DropDownItems.Add(this.ribbonButtonDrawHatchGradient);
            this.ribbonButtonDrawHatch.DropDownItems.Add(this.ribbonButtonDrawHatchPatterns);
            this.ribbonButtonDrawHatch.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatch.Image")));
            this.ribbonButtonDrawHatch.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatch.LargeImage")));
            this.ribbonButtonDrawHatch.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawHatch.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawHatch.Name = "ribbonButtonDrawHatch";
            this.ribbonButtonDrawHatch.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatch.SmallImage")));
            this.ribbonButtonDrawHatch.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonDrawHatch.Text = "Hatch";
            this.ribbonButtonDrawHatch.ToolTip = "Creates HATCH entities";
            this.ribbonButtonDrawHatch.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatch.ToolTipImage")));
            this.ribbonButtonDrawHatch.ToolTipTitle = "Hatch";
            this.ribbonButtonDrawHatch.Click += new System.EventHandler(this.ribbonButtonDrawHatch_Click);
            // 
            // ribbonButtonDrawHatchNormal
            // 
            this.ribbonButtonDrawHatchNormal.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawHatchNormal.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchNormal.Image")));
            this.ribbonButtonDrawHatchNormal.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchNormal.LargeImage")));
            this.ribbonButtonDrawHatchNormal.Name = "ribbonButtonDrawHatchNormal";
            this.ribbonButtonDrawHatchNormal.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchNormal.SmallImage")));
            this.ribbonButtonDrawHatchNormal.Text = "Hatch";
            this.ribbonButtonDrawHatchNormal.Click += new System.EventHandler(this.ribbonButtonDrawHatchNormal_Click);
            // 
            // ribbonButtonDrawHatchGradient
            // 
            this.ribbonButtonDrawHatchGradient.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawHatchGradient.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchGradient.Image")));
            this.ribbonButtonDrawHatchGradient.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchGradient.LargeImage")));
            this.ribbonButtonDrawHatchGradient.Name = "ribbonButtonDrawHatchGradient";
            this.ribbonButtonDrawHatchGradient.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchGradient.SmallImage")));
            this.ribbonButtonDrawHatchGradient.Text = "Gradient";
            this.ribbonButtonDrawHatchGradient.ToolTipTitle = "Gradient";
            this.ribbonButtonDrawHatchGradient.Click += new System.EventHandler(this.ribbonButtonDrawHatchGradient_Click);
            // 
            // ribbonButtonDrawHatchPatterns
            // 
            this.ribbonButtonDrawHatchPatterns.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawHatchPatterns.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchPatterns.Image")));
            this.ribbonButtonDrawHatchPatterns.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchPatterns.LargeImage")));
            this.ribbonButtonDrawHatchPatterns.Name = "ribbonButtonDrawHatchPatterns";
            this.ribbonButtonDrawHatchPatterns.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawHatchPatterns.SmallImage")));
            this.ribbonButtonDrawHatchPatterns.Text = "Load PAT file...";
            this.ribbonButtonDrawHatchPatterns.Click += new System.EventHandler(this.ribbonButtonDrawHatchPatterns_Click);
            // 
            // ribbonButtonDrawBlock
            // 
            this.ribbonButtonDrawBlock.DropDownItems.Add(this.ribbonButtonDrawInsertBlock);
            this.ribbonButtonDrawBlock.DropDownItems.Add(this.ribbonButtonDrawImageImage);
            this.ribbonButtonDrawBlock.DropDownItems.Add(this.ribbonButtonDrawImagePDF);
            this.ribbonButtonDrawBlock.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawBlock.Image")));
            this.ribbonButtonDrawBlock.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawBlock.LargeImage")));
            this.ribbonButtonDrawBlock.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawBlock.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawBlock.Name = "ribbonButtonDrawBlock";
            this.ribbonButtonDrawBlock.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawBlock.SmallImage")));
            this.ribbonButtonDrawBlock.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonDrawBlock.Text = "Image";
            this.ribbonButtonDrawBlock.ToolTip = "Creates INSERT/IMAGE entities or attach PDF files";
            this.ribbonButtonDrawBlock.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawBlock.ToolTipImage")));
            this.ribbonButtonDrawBlock.ToolTipTitle = "Insert";
            this.ribbonButtonDrawBlock.DropDownShowing += new System.EventHandler(this.ribbonButtonDrawBlock_DropDownShowing);
            this.ribbonButtonDrawBlock.Click += new System.EventHandler(this.ribbonButtonDrawImage_Click);
            // 
            // ribbonButtonDrawInsertBlock
            // 
            this.ribbonButtonDrawInsertBlock.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawInsertBlock.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawInsertBlock.Image")));
            this.ribbonButtonDrawInsertBlock.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawInsertBlock.LargeImage")));
            this.ribbonButtonDrawInsertBlock.Name = "ribbonButtonDrawInsertBlock";
            this.ribbonButtonDrawInsertBlock.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawInsertBlock.SmallImage")));
            this.ribbonButtonDrawInsertBlock.Text = "Insert block";
            this.ribbonButtonDrawInsertBlock.Click += new System.EventHandler(this.ribbonButtonDrawInsertBlock_Click);
            // 
            // ribbonButtonDrawImageImage
            // 
            this.ribbonButtonDrawImageImage.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawImageImage.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawImageImage.Image")));
            this.ribbonButtonDrawImageImage.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawImageImage.LargeImage")));
            this.ribbonButtonDrawImageImage.Name = "ribbonButtonDrawImageImage";
            this.ribbonButtonDrawImageImage.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawImageImage.SmallImage")));
            this.ribbonButtonDrawImageImage.Text = "Add image";
            this.ribbonButtonDrawImageImage.Click += new System.EventHandler(this.ribbonButtonDrawImageImage_Click);
            // 
            // ribbonButtonDrawImagePDF
            // 
            this.ribbonButtonDrawImagePDF.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawImagePDF.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawImagePDF.Image")));
            this.ribbonButtonDrawImagePDF.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawImagePDF.LargeImage")));
            this.ribbonButtonDrawImagePDF.Name = "ribbonButtonDrawImagePDF";
            this.ribbonButtonDrawImagePDF.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawImagePDF.SmallImage")));
            this.ribbonButtonDrawImagePDF.Text = "Attach PDF file";
            this.ribbonButtonDrawImagePDF.Click += new System.EventHandler(this.ribbonButtonDrawImagePDF_Click);
            // 
            // ribbonPanelModify
            // 
            this.ribbonPanelModify.ButtonMoreVisible = false;
            this.ribbonPanelModify.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelModify.Image")));
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifySelect);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyDelete);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyProperties);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyCopy);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyExplode);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyOffset);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyTrim);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyExtend);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyFillet);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyChamfer);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonModifyJoin);
            this.ribbonPanelModify.Items.Add(this.ribbonButtonNormalize);
            this.ribbonPanelModify.Name = "ribbonPanelModify";
            this.ribbonPanelModify.Text = "Modify";
            // 
            // ribbonButtonModifySelect
            // 
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModifySelectSinlge);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModifySelectSingleMulti);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModifySelectHandle);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonSelectNumber);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModifySelectGroup);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModifySelectRectangle);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModifySelectAll);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonAllButSelected);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonSeparator7);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButton12);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButton13);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButton14);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButton15);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonSelectGroup);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonSeparator20);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModyfiSelectShow);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonModyfiSelectClear);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonSeparator21);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonSelectContours);
            this.ribbonButtonModifySelect.DropDownItems.Add(this.ribbonButtonSelectExtCont);
            this.ribbonButtonModifySelect.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelect.Image")));
            this.ribbonButtonModifySelect.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelect.LargeImage")));
            this.ribbonButtonModifySelect.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifySelect.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifySelect.Name = "ribbonButtonModifySelect";
            this.ribbonButtonModifySelect.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelect.SmallImage")));
            this.ribbonButtonModifySelect.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonModifySelect.Text = "Select";
            this.ribbonButtonModifySelect.ToolTip = "Selects single entity";
            this.ribbonButtonModifySelect.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelect.ToolTipImage")));
            this.ribbonButtonModifySelect.ToolTipTitle = "Select";
            this.ribbonButtonModifySelect.DropDownShowing += new System.EventHandler(this.ribbonButtonModifySelect_DropDownShowing);
            this.ribbonButtonModifySelect.Click += new System.EventHandler(this.ribbonButtonModifySelect_Click);
            // 
            // ribbonButtonModifySelectSinlge
            // 
            this.ribbonButtonModifySelectSinlge.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifySelectSinlge.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectSinlge.Image")));
            this.ribbonButtonModifySelectSinlge.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectSinlge.LargeImage")));
            this.ribbonButtonModifySelectSinlge.Name = "ribbonButtonModifySelectSinlge";
            this.ribbonButtonModifySelectSinlge.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectSinlge.SmallImage")));
            this.ribbonButtonModifySelectSinlge.Text = "Select single entity";
            this.ribbonButtonModifySelectSinlge.Click += new System.EventHandler(this.ribbonButtonModifySelectSinlge_Click);
            // 
            // ribbonButtonModifySelectSingleMulti
            // 
            this.ribbonButtonModifySelectSingleMulti.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifySelectSingleMulti.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectSingleMulti.Image")));
            this.ribbonButtonModifySelectSingleMulti.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectSingleMulti.LargeImage")));
            this.ribbonButtonModifySelectSingleMulti.Name = "ribbonButtonModifySelectSingleMulti";
            this.ribbonButtonModifySelectSingleMulti.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectSingleMulti.SmallImage")));
            this.ribbonButtonModifySelectSingleMulti.Text = "Select single entity continuously";
            this.ribbonButtonModifySelectSingleMulti.Click += new System.EventHandler(this.ribbonButtonModifySelectSingleMulti_Click);
            // 
            // ribbonButtonModifySelectHandle
            // 
            this.ribbonButtonModifySelectHandle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifySelectHandle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectHandle.Image")));
            this.ribbonButtonModifySelectHandle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectHandle.LargeImage")));
            this.ribbonButtonModifySelectHandle.Name = "ribbonButtonModifySelectHandle";
            this.ribbonButtonModifySelectHandle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectHandle.SmallImage")));
            this.ribbonButtonModifySelectHandle.Text = "Select single entity with handle";
            this.ribbonButtonModifySelectHandle.Click += new System.EventHandler(this.ribbonButtonModifySelectHandle_Click);
            // 
            // ribbonButtonSelectNumber
            // 
            this.ribbonButtonSelectNumber.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonSelectNumber.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectNumber.Image")));
            this.ribbonButtonSelectNumber.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectNumber.LargeImage")));
            this.ribbonButtonSelectNumber.Name = "ribbonButtonSelectNumber";
            this.ribbonButtonSelectNumber.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectNumber.SmallImage")));
            this.ribbonButtonSelectNumber.Text = "Select single entity by number";
            this.ribbonButtonSelectNumber.Click += new System.EventHandler(this.ribbonButtonSelectNumber_Click);
            // 
            // ribbonButtonModifySelectGroup
            // 
            this.ribbonButtonModifySelectGroup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifySelectGroup.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectGroup.Image")));
            this.ribbonButtonModifySelectGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectGroup.LargeImage")));
            this.ribbonButtonModifySelectGroup.Name = "ribbonButtonModifySelectGroup";
            this.ribbonButtonModifySelectGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectGroup.SmallImage")));
            this.ribbonButtonModifySelectGroup.Text = "Select all entities of a group";
            this.ribbonButtonModifySelectGroup.Click += new System.EventHandler(this.ribbonButtonModifySelectGroup_Click);
            // 
            // ribbonButtonModifySelectRectangle
            // 
            this.ribbonButtonModifySelectRectangle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifySelectRectangle.DropDownItems.Add(this.ribbonButton5);
            this.ribbonButtonModifySelectRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectRectangle.Image")));
            this.ribbonButtonModifySelectRectangle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectRectangle.LargeImage")));
            this.ribbonButtonModifySelectRectangle.Name = "ribbonButtonModifySelectRectangle";
            this.ribbonButtonModifySelectRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectRectangle.SmallImage")));
            this.ribbonButtonModifySelectRectangle.Text = "Select entities with a rectangle";
            this.ribbonButtonModifySelectRectangle.Click += new System.EventHandler(this.ribbonButtonModifySelectRectangle_Click);
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.LargeImage")));
            this.ribbonButton5.Name = "ribbonButton5";
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "ribbonButton5";
            // 
            // ribbonButtonModifySelectAll
            // 
            this.ribbonButtonModifySelectAll.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifySelectAll.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectAll.Image")));
            this.ribbonButtonModifySelectAll.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectAll.LargeImage")));
            this.ribbonButtonModifySelectAll.Name = "ribbonButtonModifySelectAll";
            this.ribbonButtonModifySelectAll.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifySelectAll.SmallImage")));
            this.ribbonButtonModifySelectAll.Text = "Select all entities";
            this.ribbonButtonModifySelectAll.Click += new System.EventHandler(this.ribbonButtonModifySelectAll_Click);
            // 
            // ribbonButtonAllButSelected
            // 
            this.ribbonButtonAllButSelected.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAllButSelected.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAllButSelected.Image")));
            this.ribbonButtonAllButSelected.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAllButSelected.LargeImage")));
            this.ribbonButtonAllButSelected.Name = "ribbonButtonAllButSelected";
            this.ribbonButtonAllButSelected.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAllButSelected.SmallImage")));
            this.ribbonButtonAllButSelected.Text = "Select all entities BUT selected";
            this.ribbonButtonAllButSelected.Click += new System.EventHandler(this.ribbonButtonAllButSelected_Click);
            // 
            // ribbonSeparator7
            // 
            this.ribbonSeparator7.Name = "ribbonSeparator7";
            // 
            // ribbonButton12
            // 
            this.ribbonButton12.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton12.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton12.Image")));
            this.ribbonButton12.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton12.LargeImage")));
            this.ribbonButton12.Name = "ribbonButton12";
            this.ribbonButton12.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton12.SmallImage")));
            this.ribbonButton12.Text = "Select entites by type";
            this.ribbonButton12.Click += new System.EventHandler(this.ribbonButton12_Click_1);
            // 
            // ribbonButton13
            // 
            this.ribbonButton13.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton13.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton13.Image")));
            this.ribbonButton13.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton13.LargeImage")));
            this.ribbonButton13.Name = "ribbonButton13";
            this.ribbonButton13.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton13.SmallImage")));
            this.ribbonButton13.Text = "Select entities by color";
            this.ribbonButton13.Click += new System.EventHandler(this.ribbonButton13_Click_1);
            // 
            // ribbonButton14
            // 
            this.ribbonButton14.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton14.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton14.Image")));
            this.ribbonButton14.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton14.LargeImage")));
            this.ribbonButton14.Name = "ribbonButton14";
            this.ribbonButton14.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton14.SmallImage")));
            this.ribbonButton14.Text = "Select entities by layer";
            this.ribbonButton14.Click += new System.EventHandler(this.ribbonButton14_Click);
            // 
            // ribbonButton15
            // 
            this.ribbonButton15.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButton15.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton15.Image")));
            this.ribbonButton15.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton15.LargeImage")));
            this.ribbonButton15.Name = "ribbonButton15";
            this.ribbonButton15.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton15.SmallImage")));
            this.ribbonButton15.Text = "Select entities by line type";
            this.ribbonButton15.Click += new System.EventHandler(this.ribbonButton15_Click_1);
            // 
            // ribbonButtonSelectGroup
            // 
            this.ribbonButtonSelectGroup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonSelectGroup.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectGroup.Image")));
            this.ribbonButtonSelectGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectGroup.LargeImage")));
            this.ribbonButtonSelectGroup.Name = "ribbonButtonSelectGroup";
            this.ribbonButtonSelectGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectGroup.SmallImage")));
            this.ribbonButtonSelectGroup.Text = "Select entities by group";
            this.ribbonButtonSelectGroup.Click += new System.EventHandler(this.ribbonButtonSelectGroup_Click);
            // 
            // ribbonSeparator20
            // 
            this.ribbonSeparator20.Name = "ribbonSeparator20";
            // 
            // ribbonButtonModyfiSelectShow
            // 
            this.ribbonButtonModyfiSelectShow.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModyfiSelectShow.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModyfiSelectShow.Image")));
            this.ribbonButtonModyfiSelectShow.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModyfiSelectShow.LargeImage")));
            this.ribbonButtonModyfiSelectShow.Name = "ribbonButtonModyfiSelectShow";
            this.ribbonButtonModyfiSelectShow.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModyfiSelectShow.SmallImage")));
            this.ribbonButtonModyfiSelectShow.Text = "Show selected entities";
            this.ribbonButtonModyfiSelectShow.Click += new System.EventHandler(this.ribbonButtonModyfiSelectShow_Click);
            // 
            // ribbonButtonModyfiSelectClear
            // 
            this.ribbonButtonModyfiSelectClear.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModyfiSelectClear.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModyfiSelectClear.Image")));
            this.ribbonButtonModyfiSelectClear.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModyfiSelectClear.LargeImage")));
            this.ribbonButtonModyfiSelectClear.Name = "ribbonButtonModyfiSelectClear";
            this.ribbonButtonModyfiSelectClear.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModyfiSelectClear.SmallImage")));
            this.ribbonButtonModyfiSelectClear.Text = "Clear selected entities";
            this.ribbonButtonModyfiSelectClear.Click += new System.EventHandler(this.ribbonButtonModyfiSelectClear_Click);
            // 
            // ribbonSeparator21
            // 
            this.ribbonSeparator21.Name = "ribbonSeparator21";
            // 
            // ribbonButtonSelectContours
            // 
            this.ribbonButtonSelectContours.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonSelectContours.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectContours.Image")));
            this.ribbonButtonSelectContours.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectContours.LargeImage")));
            this.ribbonButtonSelectContours.Name = "ribbonButtonSelectContours";
            this.ribbonButtonSelectContours.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectContours.SmallImage")));
            this.ribbonButtonSelectContours.Text = "Select contours";
            this.ribbonButtonSelectContours.Click += new System.EventHandler(this.ribbonButtonSelectContours_Click);
            // 
            // ribbonButtonSelectExtCont
            // 
            this.ribbonButtonSelectExtCont.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonSelectExtCont.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectExtCont.Image")));
            this.ribbonButtonSelectExtCont.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectExtCont.LargeImage")));
            this.ribbonButtonSelectExtCont.Name = "ribbonButtonSelectExtCont";
            this.ribbonButtonSelectExtCont.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSelectExtCont.SmallImage")));
            this.ribbonButtonSelectExtCont.Text = "Select external contour";
            this.ribbonButtonSelectExtCont.Click += new System.EventHandler(this.ribbonButtonSelectExtCont_Click);
            // 
            // ribbonButtonModifyDelete
            // 
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonModifyDeleteSelected);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonModifyDeleteNotSelected);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonSeparator8);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonModifyDeleteHandle);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonModifyDeleteButHandle);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonSeparator10);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonModifyRemoveBlocks);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonSeparator17);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteSelectedEntities);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteEntitiesByColor);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteEntitiesByLayer);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteEntitiesByLineType);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonSeparator19);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteCoincident);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteZeroLen);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonDeleteNotConnected);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonSeparator22);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonTables);
            this.ribbonButtonModifyDelete.DropDownItems.Add(this.ribbonButtonObjects);
            this.ribbonButtonModifyDelete.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDelete.Image")));
            this.ribbonButtonModifyDelete.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDelete.LargeImage")));
            this.ribbonButtonModifyDelete.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyDelete.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyDelete.Name = "ribbonButtonModifyDelete";
            this.ribbonButtonModifyDelete.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDelete.SmallImage")));
            this.ribbonButtonModifyDelete.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonModifyDelete.Text = "Delete selected entities";
            this.ribbonButtonModifyDelete.ToolTip = "Deletes single entity";
            this.ribbonButtonModifyDelete.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDelete.ToolTipImage")));
            this.ribbonButtonModifyDelete.ToolTipTitle = "Delete";
            this.ribbonButtonModifyDelete.DropDownShowing += new System.EventHandler(this.ribbonButtonModifyDelete_DropDownShowing);
            this.ribbonButtonModifyDelete.Click += new System.EventHandler(this.ribbonButtonModifyDelete_Click);
            // 
            // ribbonButtonModifyDeleteSelected
            // 
            this.ribbonButtonModifyDeleteSelected.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyDeleteSelected.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteSelected.Image")));
            this.ribbonButtonModifyDeleteSelected.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteSelected.LargeImage")));
            this.ribbonButtonModifyDeleteSelected.Name = "ribbonButtonModifyDeleteSelected";
            this.ribbonButtonModifyDeleteSelected.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteSelected.SmallImage")));
            this.ribbonButtonModifyDeleteSelected.Text = "Delete selected entities";
            this.ribbonButtonModifyDeleteSelected.Click += new System.EventHandler(this.ribbonButtonModifyDeleteSelected_Click);
            // 
            // ribbonButtonModifyDeleteNotSelected
            // 
            this.ribbonButtonModifyDeleteNotSelected.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyDeleteNotSelected.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteNotSelected.Image")));
            this.ribbonButtonModifyDeleteNotSelected.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteNotSelected.LargeImage")));
            this.ribbonButtonModifyDeleteNotSelected.Name = "ribbonButtonModifyDeleteNotSelected";
            this.ribbonButtonModifyDeleteNotSelected.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteNotSelected.SmallImage")));
            this.ribbonButtonModifyDeleteNotSelected.Text = "Delete all entities BUT selected";
            this.ribbonButtonModifyDeleteNotSelected.Click += new System.EventHandler(this.ribbonButtonModifyDeleteNotSelected_Click);
            // 
            // ribbonSeparator8
            // 
            this.ribbonSeparator8.Name = "ribbonSeparator8";
            // 
            // ribbonButtonModifyDeleteHandle
            // 
            this.ribbonButtonModifyDeleteHandle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyDeleteHandle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteHandle.Image")));
            this.ribbonButtonModifyDeleteHandle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteHandle.LargeImage")));
            this.ribbonButtonModifyDeleteHandle.Name = "ribbonButtonModifyDeleteHandle";
            this.ribbonButtonModifyDeleteHandle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteHandle.SmallImage")));
            this.ribbonButtonModifyDeleteHandle.Text = "Delete entity with Handle...";
            this.ribbonButtonModifyDeleteHandle.Click += new System.EventHandler(this.ribbonButtonModifyDeleteHandle_Click);
            // 
            // ribbonButtonModifyDeleteButHandle
            // 
            this.ribbonButtonModifyDeleteButHandle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyDeleteButHandle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteButHandle.Image")));
            this.ribbonButtonModifyDeleteButHandle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteButHandle.LargeImage")));
            this.ribbonButtonModifyDeleteButHandle.Name = "ribbonButtonModifyDeleteButHandle";
            this.ribbonButtonModifyDeleteButHandle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyDeleteButHandle.SmallImage")));
            this.ribbonButtonModifyDeleteButHandle.Text = "Delete all entites BUT entity with Handle...";
            this.ribbonButtonModifyDeleteButHandle.Click += new System.EventHandler(this.ribbonButtonModifyDeleteButHandle_Click);
            // 
            // ribbonSeparator10
            // 
            this.ribbonSeparator10.Name = "ribbonSeparator10";
            // 
            // ribbonButtonModifyRemoveBlocks
            // 
            this.ribbonButtonModifyRemoveBlocks.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyRemoveBlocks.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRemoveBlocks.Image")));
            this.ribbonButtonModifyRemoveBlocks.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRemoveBlocks.LargeImage")));
            this.ribbonButtonModifyRemoveBlocks.Name = "ribbonButtonModifyRemoveBlocks";
            this.ribbonButtonModifyRemoveBlocks.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRemoveBlocks.SmallImage")));
            this.ribbonButtonModifyRemoveBlocks.Text = "Remove unused blocks";
            this.ribbonButtonModifyRemoveBlocks.Click += new System.EventHandler(this.ribbonButtonModifyRemoveBlocks_Click);
            // 
            // ribbonSeparator17
            // 
            this.ribbonSeparator17.Name = "ribbonSeparator17";
            // 
            // ribbonButtonDeleteSelectedEntities
            // 
            this.ribbonButtonDeleteSelectedEntities.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteSelectedEntities.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteSelectedEntities.Image")));
            this.ribbonButtonDeleteSelectedEntities.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteSelectedEntities.LargeImage")));
            this.ribbonButtonDeleteSelectedEntities.Name = "ribbonButtonDeleteSelectedEntities";
            this.ribbonButtonDeleteSelectedEntities.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteSelectedEntities.SmallImage")));
            this.ribbonButtonDeleteSelectedEntities.Text = "Delete entities by type";
            this.ribbonButtonDeleteSelectedEntities.Click += new System.EventHandler(this.ribbonButtonDeleteSelectedEntities_Click);
            // 
            // ribbonButtonDeleteEntitiesByColor
            // 
            this.ribbonButtonDeleteEntitiesByColor.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteEntitiesByColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByColor.Image")));
            this.ribbonButtonDeleteEntitiesByColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByColor.LargeImage")));
            this.ribbonButtonDeleteEntitiesByColor.Name = "ribbonButtonDeleteEntitiesByColor";
            this.ribbonButtonDeleteEntitiesByColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByColor.SmallImage")));
            this.ribbonButtonDeleteEntitiesByColor.Text = "Delete entities by color";
            this.ribbonButtonDeleteEntitiesByColor.Click += new System.EventHandler(this.ribbonButtonDeleteEntitiesByColor_Click);
            // 
            // ribbonButtonDeleteEntitiesByLayer
            // 
            this.ribbonButtonDeleteEntitiesByLayer.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteEntitiesByLayer.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByLayer.Image")));
            this.ribbonButtonDeleteEntitiesByLayer.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByLayer.LargeImage")));
            this.ribbonButtonDeleteEntitiesByLayer.Name = "ribbonButtonDeleteEntitiesByLayer";
            this.ribbonButtonDeleteEntitiesByLayer.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByLayer.SmallImage")));
            this.ribbonButtonDeleteEntitiesByLayer.Text = "Delete entities by layer";
            this.ribbonButtonDeleteEntitiesByLayer.Click += new System.EventHandler(this.ribbonButtonDeleteEntitiesByLayer_Click);
            // 
            // ribbonButtonDeleteEntitiesByLineType
            // 
            this.ribbonButtonDeleteEntitiesByLineType.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteEntitiesByLineType.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByLineType.Image")));
            this.ribbonButtonDeleteEntitiesByLineType.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByLineType.LargeImage")));
            this.ribbonButtonDeleteEntitiesByLineType.Name = "ribbonButtonDeleteEntitiesByLineType";
            this.ribbonButtonDeleteEntitiesByLineType.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteEntitiesByLineType.SmallImage")));
            this.ribbonButtonDeleteEntitiesByLineType.Tag = "";
            this.ribbonButtonDeleteEntitiesByLineType.Text = "Delete entities by line type";
            this.ribbonButtonDeleteEntitiesByLineType.Click += new System.EventHandler(this.ribbonButtonDeleteEntitiesByLineType_Click);
            // 
            // ribbonSeparator19
            // 
            this.ribbonSeparator19.Name = "ribbonSeparator19";
            // 
            // ribbonButtonDeleteCoincident
            // 
            this.ribbonButtonDeleteCoincident.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteCoincident.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteCoincident.Image")));
            this.ribbonButtonDeleteCoincident.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteCoincident.LargeImage")));
            this.ribbonButtonDeleteCoincident.Name = "ribbonButtonDeleteCoincident";
            this.ribbonButtonDeleteCoincident.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteCoincident.SmallImage")));
            this.ribbonButtonDeleteCoincident.Text = "Delete coincident entities";
            this.ribbonButtonDeleteCoincident.Click += new System.EventHandler(this.ribbonButtonDeleteCoincident_Click);
            // 
            // ribbonButtonDeleteZeroLen
            // 
            this.ribbonButtonDeleteZeroLen.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteZeroLen.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteZeroLen.Image")));
            this.ribbonButtonDeleteZeroLen.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteZeroLen.LargeImage")));
            this.ribbonButtonDeleteZeroLen.Name = "ribbonButtonDeleteZeroLen";
            this.ribbonButtonDeleteZeroLen.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteZeroLen.SmallImage")));
            this.ribbonButtonDeleteZeroLen.Text = "Delete zero lenght entities";
            this.ribbonButtonDeleteZeroLen.Click += new System.EventHandler(this.ribbonButtonDeleteZeroLen_Click);
            // 
            // ribbonButtonDeleteNotConnected
            // 
            this.ribbonButtonDeleteNotConnected.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteNotConnected.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteNotConnected.Image")));
            this.ribbonButtonDeleteNotConnected.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteNotConnected.LargeImage")));
            this.ribbonButtonDeleteNotConnected.Name = "ribbonButtonDeleteNotConnected";
            this.ribbonButtonDeleteNotConnected.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteNotConnected.SmallImage")));
            this.ribbonButtonDeleteNotConnected.Text = "Delete not connected entities";
            this.ribbonButtonDeleteNotConnected.Click += new System.EventHandler(this.ribbonButtonDeleteNotConnected_Click);
            // 
            // ribbonSeparator22
            // 
            this.ribbonSeparator22.Name = "ribbonSeparator22";
            // 
            // ribbonButtonTables
            // 
            this.ribbonButtonTables.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonTables.DropDownItems.Add(this.ribbonButtonTablesDimStyles);
            this.ribbonButtonTables.DropDownItems.Add(this.ribbonButtonTablesLayers);
            this.ribbonButtonTables.DropDownItems.Add(this.ribbonButtonTablesLTYPE);
            this.ribbonButtonTables.DropDownItems.Add(this.ribbonButtonTablesTextStyles);
            this.ribbonButtonTables.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTables.Image")));
            this.ribbonButtonTables.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTables.LargeImage")));
            this.ribbonButtonTables.Name = "ribbonButtonTables";
            this.ribbonButtonTables.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTables.SmallImage")));
            this.ribbonButtonTables.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonTables.Text = "Tables";
            // 
            // ribbonButtonTablesDimStyles
            // 
            this.ribbonButtonTablesDimStyles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonTablesDimStyles.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesDimStyles.Image")));
            this.ribbonButtonTablesDimStyles.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesDimStyles.LargeImage")));
            this.ribbonButtonTablesDimStyles.Name = "ribbonButtonTablesDimStyles";
            this.ribbonButtonTablesDimStyles.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesDimStyles.SmallImage")));
            this.ribbonButtonTablesDimStyles.Text = "Delete dimension styles";
            this.ribbonButtonTablesDimStyles.Click += new System.EventHandler(this.ribbonButtonTablesDimStyles_Click);
            // 
            // ribbonButtonTablesLayers
            // 
            this.ribbonButtonTablesLayers.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonTablesLayers.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesLayers.Image")));
            this.ribbonButtonTablesLayers.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesLayers.LargeImage")));
            this.ribbonButtonTablesLayers.Name = "ribbonButtonTablesLayers";
            this.ribbonButtonTablesLayers.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesLayers.SmallImage")));
            this.ribbonButtonTablesLayers.Text = "Delete layers";
            this.ribbonButtonTablesLayers.Click += new System.EventHandler(this.ribbonButtonTablesLayers_Click);
            // 
            // ribbonButtonTablesLTYPE
            // 
            this.ribbonButtonTablesLTYPE.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonTablesLTYPE.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesLTYPE.Image")));
            this.ribbonButtonTablesLTYPE.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesLTYPE.LargeImage")));
            this.ribbonButtonTablesLTYPE.Name = "ribbonButtonTablesLTYPE";
            this.ribbonButtonTablesLTYPE.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesLTYPE.SmallImage")));
            this.ribbonButtonTablesLTYPE.Text = "Delete line types";
            this.ribbonButtonTablesLTYPE.Click += new System.EventHandler(this.ribbonButtonTablesLTYPE_Click);
            // 
            // ribbonButtonTablesTextStyles
            // 
            this.ribbonButtonTablesTextStyles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonTablesTextStyles.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesTextStyles.Image")));
            this.ribbonButtonTablesTextStyles.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesTextStyles.LargeImage")));
            this.ribbonButtonTablesTextStyles.Name = "ribbonButtonTablesTextStyles";
            this.ribbonButtonTablesTextStyles.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTablesTextStyles.SmallImage")));
            this.ribbonButtonTablesTextStyles.Text = "Delete text styles";
            this.ribbonButtonTablesTextStyles.Click += new System.EventHandler(this.ribbonButtonTablesTextStyles_Click);
            // 
            // ribbonButtonObjects
            // 
            this.ribbonButtonObjects.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonObjects.DropDownItems.Add(this.ribbonButtonDeleteGroup);
            this.ribbonButtonObjects.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjects.Image")));
            this.ribbonButtonObjects.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjects.LargeImage")));
            this.ribbonButtonObjects.Name = "ribbonButtonObjects";
            this.ribbonButtonObjects.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjects.SmallImage")));
            this.ribbonButtonObjects.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonObjects.Text = "Objects";
            // 
            // ribbonButtonDeleteGroup
            // 
            this.ribbonButtonDeleteGroup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDeleteGroup.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteGroup.Image")));
            this.ribbonButtonDeleteGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteGroup.LargeImage")));
            this.ribbonButtonDeleteGroup.Name = "ribbonButtonDeleteGroup";
            this.ribbonButtonDeleteGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDeleteGroup.SmallImage")));
            this.ribbonButtonDeleteGroup.Text = "Delete group definitions";
            this.ribbonButtonDeleteGroup.Click += new System.EventHandler(this.ribbonButtonDeleteGroup_Click);
            // 
            // ribbonButtonModifyProperties
            // 
            this.ribbonButtonModifyProperties.DrawDropDownIconsBar = false;
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModPropColor);
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModPropLayer);
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModPropLineType);
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModPropLineWeight);
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModPropGroup);
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModElev);
            this.ribbonButtonModifyProperties.DropDownItems.Add(this.ribbonButtonModVisibility);
            this.ribbonButtonModifyProperties.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyProperties.Image")));
            this.ribbonButtonModifyProperties.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyProperties.LargeImage")));
            this.ribbonButtonModifyProperties.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyProperties.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyProperties.Name = "ribbonButtonModifyProperties";
            this.ribbonButtonModifyProperties.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyProperties.SmallImage")));
            this.ribbonButtonModifyProperties.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonModifyProperties.Text = "Properties";
            this.ribbonButtonModifyProperties.ToolTip = "Properties";
            this.ribbonButtonModifyProperties.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyProperties.ToolTipImage")));
            this.ribbonButtonModifyProperties.ToolTipTitle = "Change properties";
            this.ribbonButtonModifyProperties.DropDownShowing += new System.EventHandler(this.ribbonButtonModifyProperties_DropDownShowing);
            // 
            // ribbonButtonModPropColor
            // 
            this.ribbonButtonModPropColor.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModPropColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropColor.Image")));
            this.ribbonButtonModPropColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropColor.LargeImage")));
            this.ribbonButtonModPropColor.Name = "ribbonButtonModPropColor";
            this.ribbonButtonModPropColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropColor.SmallImage")));
            this.ribbonButtonModPropColor.Text = "Color";
            this.ribbonButtonModPropColor.ToolTip = "Changes entities color";
            this.ribbonButtonModPropColor.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropColor.ToolTipImage")));
            this.ribbonButtonModPropColor.ToolTipTitle = "Color";
            this.ribbonButtonModPropColor.Click += new System.EventHandler(this.ribbonButtonModPropColor_Click);
            // 
            // ribbonButtonModPropLayer
            // 
            this.ribbonButtonModPropLayer.DrawDropDownIconsBar = false;
            this.ribbonButtonModPropLayer.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModPropLayer.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLayer.Image")));
            this.ribbonButtonModPropLayer.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLayer.LargeImage")));
            this.ribbonButtonModPropLayer.Name = "ribbonButtonModPropLayer";
            this.ribbonButtonModPropLayer.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLayer.SmallImage")));
            this.ribbonButtonModPropLayer.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModPropLayer.Text = "Layer";
            this.ribbonButtonModPropLayer.ToolTip = "Changes entitites layer";
            this.ribbonButtonModPropLayer.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLayer.ToolTipImage")));
            this.ribbonButtonModPropLayer.ToolTipTitle = "Layer";
            this.ribbonButtonModPropLayer.DropDownShowing += new System.EventHandler(this.ribbonButtonModPropLayer_DropDownShowing);
            this.ribbonButtonModPropLayer.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonModPropLayer_DropDownItemClicked);
            // 
            // ribbonButtonModPropLineType
            // 
            this.ribbonButtonModPropLineType.DrawDropDownIconsBar = false;
            this.ribbonButtonModPropLineType.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModPropLineType.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineType.Image")));
            this.ribbonButtonModPropLineType.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineType.LargeImage")));
            this.ribbonButtonModPropLineType.Name = "ribbonButtonModPropLineType";
            this.ribbonButtonModPropLineType.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineType.SmallImage")));
            this.ribbonButtonModPropLineType.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModPropLineType.Text = "Line Type";
            this.ribbonButtonModPropLineType.ToolTip = "Changes entities line type";
            this.ribbonButtonModPropLineType.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineType.ToolTipImage")));
            this.ribbonButtonModPropLineType.ToolTipTitle = "Line Type";
            this.ribbonButtonModPropLineType.DropDownShowing += new System.EventHandler(this.ribbonButtonModPropLineType_DropDownShowing);
            this.ribbonButtonModPropLineType.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonModPropLineType_DropDownItemClicked);
            // 
            // ribbonButtonModPropLineWeight
            // 
            this.ribbonButtonModPropLineWeight.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModPropLineWeight.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineWeight.Image")));
            this.ribbonButtonModPropLineWeight.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineWeight.LargeImage")));
            this.ribbonButtonModPropLineWeight.Name = "ribbonButtonModPropLineWeight";
            this.ribbonButtonModPropLineWeight.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineWeight.SmallImage")));
            this.ribbonButtonModPropLineWeight.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModPropLineWeight.Text = "Line Weight";
            this.ribbonButtonModPropLineWeight.ToolTip = "Changes entities line weight";
            this.ribbonButtonModPropLineWeight.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropLineWeight.ToolTipImage")));
            this.ribbonButtonModPropLineWeight.ToolTipTitle = "Line Weight";
            this.ribbonButtonModPropLineWeight.DropDownShowing += new System.EventHandler(this.ribbonButtonModPropLineWeight_DropDownShowing);
            this.ribbonButtonModPropLineWeight.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonModPropLineWeight_DropDownItemClicked);
            // 
            // ribbonButtonModPropGroup
            // 
            this.ribbonButtonModPropGroup.DrawDropDownIconsBar = false;
            this.ribbonButtonModPropGroup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModPropGroup.DropDownItems.Add(this.ribbonButtonGroupAdd);
            this.ribbonButtonModPropGroup.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropGroup.Image")));
            this.ribbonButtonModPropGroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropGroup.LargeImage")));
            this.ribbonButtonModPropGroup.Name = "ribbonButtonModPropGroup";
            this.ribbonButtonModPropGroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModPropGroup.SmallImage")));
            this.ribbonButtonModPropGroup.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModPropGroup.Text = "Group Entities";
            this.ribbonButtonModPropGroup.DropDownShowing += new System.EventHandler(this.ribbonButtonModPropGroup_DropDownShowing);
            this.ribbonButtonModPropGroup.DropDownItemClicked += new System.Windows.Forms.RibbonButton.RibbonItemEventHandler(this.ribbonButtonModPropGroup_DropDownItemClicked);
            // 
            // ribbonButtonGroupAdd
            // 
            this.ribbonButtonGroupAdd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonGroupAdd.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGroupAdd.Image")));
            this.ribbonButtonGroupAdd.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGroupAdd.LargeImage")));
            this.ribbonButtonGroupAdd.Name = "ribbonButtonGroupAdd";
            this.ribbonButtonGroupAdd.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGroupAdd.SmallImage")));
            this.ribbonButtonGroupAdd.Text = "Add Group...";
            // 
            // ribbonButtonModElev
            // 
            this.ribbonButtonModElev.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModElev.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModElev.Image")));
            this.ribbonButtonModElev.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModElev.LargeImage")));
            this.ribbonButtonModElev.Name = "ribbonButtonModElev";
            this.ribbonButtonModElev.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModElev.SmallImage")));
            this.ribbonButtonModElev.Text = "Elevation/Thickness";
            this.ribbonButtonModElev.Click += new System.EventHandler(this.ribbonButtonModElev_Click);
            // 
            // ribbonButtonModVisibility
            // 
            this.ribbonButtonModVisibility.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModVisibility.DropDownItems.Add(this.ribbonButtonModVisibilityOff);
            this.ribbonButtonModVisibility.DropDownItems.Add(this.ribbonButtonModVisibilityOn);
            this.ribbonButtonModVisibility.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibility.Image")));
            this.ribbonButtonModVisibility.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibility.LargeImage")));
            this.ribbonButtonModVisibility.Name = "ribbonButtonModVisibility";
            this.ribbonButtonModVisibility.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibility.SmallImage")));
            this.ribbonButtonModVisibility.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModVisibility.Text = "Visibility";
            // 
            // ribbonButtonModVisibilityOff
            // 
            this.ribbonButtonModVisibilityOff.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModVisibilityOff.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibilityOff.Image")));
            this.ribbonButtonModVisibilityOff.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibilityOff.LargeImage")));
            this.ribbonButtonModVisibilityOff.Name = "ribbonButtonModVisibilityOff";
            this.ribbonButtonModVisibilityOff.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibilityOff.SmallImage")));
            this.ribbonButtonModVisibilityOff.Text = "Off";
            this.ribbonButtonModVisibilityOff.Click += new System.EventHandler(this.ribbonButtonModVisibilityOff_Click);
            // 
            // ribbonButtonModVisibilityOn
            // 
            this.ribbonButtonModVisibilityOn.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModVisibilityOn.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibilityOn.Image")));
            this.ribbonButtonModVisibilityOn.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibilityOn.LargeImage")));
            this.ribbonButtonModVisibilityOn.Name = "ribbonButtonModVisibilityOn";
            this.ribbonButtonModVisibilityOn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModVisibilityOn.SmallImage")));
            this.ribbonButtonModVisibilityOn.Text = "Make all invisible entities visible";
            this.ribbonButtonModVisibilityOn.Click += new System.EventHandler(this.ribbonButtonModVisibilityOn_Click);
            // 
            // ribbonButtonModifyCopy
            // 
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModidyCopyCopy);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyCopyMove);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyCopyRotate);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyCopyScale);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyLines2Poly);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonLines2PolyB);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyBlock);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyRotate);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyArray);
            this.ribbonButtonModifyCopy.DropDownItems.Add(this.ribbonButtonModifyArrayPolar);
            this.ribbonButtonModifyCopy.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopy.Image")));
            this.ribbonButtonModifyCopy.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopy.LargeImage")));
            this.ribbonButtonModifyCopy.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyCopy.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyCopy.Name = "ribbonButtonModifyCopy";
            this.ribbonButtonModifyCopy.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopy.SmallImage")));
            this.ribbonButtonModifyCopy.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonModifyCopy.Text = "Copy";
            this.ribbonButtonModifyCopy.ToolTip = "Modify entities";
            this.ribbonButtonModifyCopy.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopy.ToolTipImage")));
            this.ribbonButtonModifyCopy.ToolTipTitle = "Modify";
            this.ribbonButtonModifyCopy.DropDownShowing += new System.EventHandler(this.ribbonButtonModifyCopy_DropDownShowing);
            this.ribbonButtonModifyCopy.Click += new System.EventHandler(this.ribbonButtonModifyCopy_Click);
            // 
            // ribbonButtonModidyCopyCopy
            // 
            this.ribbonButtonModidyCopyCopy.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModidyCopyCopy.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModidyCopyCopy.Image")));
            this.ribbonButtonModidyCopyCopy.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModidyCopyCopy.LargeImage")));
            this.ribbonButtonModidyCopyCopy.Name = "ribbonButtonModidyCopyCopy";
            this.ribbonButtonModidyCopyCopy.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModidyCopyCopy.SmallImage")));
            this.ribbonButtonModidyCopyCopy.Text = "Copy selected entities";
            this.ribbonButtonModidyCopyCopy.ToolTip = "Creates a copy of selected entities specifing base point and translation";
            this.ribbonButtonModidyCopyCopy.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModidyCopyCopy.ToolTipImage")));
            this.ribbonButtonModidyCopyCopy.ToolTipTitle = "Copy selected entities";
            this.ribbonButtonModidyCopyCopy.Click += new System.EventHandler(this.ribbonButtonModidyCopyCopy_Click);
            // 
            // ribbonButtonModifyCopyMove
            // 
            this.ribbonButtonModifyCopyMove.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyCopyMove.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyMove.Image")));
            this.ribbonButtonModifyCopyMove.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyMove.LargeImage")));
            this.ribbonButtonModifyCopyMove.Name = "ribbonButtonModifyCopyMove";
            this.ribbonButtonModifyCopyMove.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyMove.SmallImage")));
            this.ribbonButtonModifyCopyMove.Text = "Move selected entities";
            this.ribbonButtonModifyCopyMove.ToolTip = "Moves selected entities specifing base point and translation";
            this.ribbonButtonModifyCopyMove.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyMove.ToolTipImage")));
            this.ribbonButtonModifyCopyMove.ToolTipTitle = "Move selected entities";
            this.ribbonButtonModifyCopyMove.Click += new System.EventHandler(this.ribbonButtonModifyCopyMove_Click);
            // 
            // ribbonButtonModifyCopyRotate
            // 
            this.ribbonButtonModifyCopyRotate.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyCopyRotate.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyRotate.Image")));
            this.ribbonButtonModifyCopyRotate.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyRotate.LargeImage")));
            this.ribbonButtonModifyCopyRotate.Name = "ribbonButtonModifyCopyRotate";
            this.ribbonButtonModifyCopyRotate.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyRotate.SmallImage")));
            this.ribbonButtonModifyCopyRotate.Text = "Rotate selected entities";
            this.ribbonButtonModifyCopyRotate.ToolTip = "Rotates selected entities specifing base point and rotation angle in degree";
            this.ribbonButtonModifyCopyRotate.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyRotate.ToolTipImage")));
            this.ribbonButtonModifyCopyRotate.ToolTipTitle = "Rotate selected entities";
            this.ribbonButtonModifyCopyRotate.Click += new System.EventHandler(this.ribbonButtonModifyCopyRotate_Click);
            // 
            // ribbonButtonModifyCopyScale
            // 
            this.ribbonButtonModifyCopyScale.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyCopyScale.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyScale.Image")));
            this.ribbonButtonModifyCopyScale.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyScale.LargeImage")));
            this.ribbonButtonModifyCopyScale.Name = "ribbonButtonModifyCopyScale";
            this.ribbonButtonModifyCopyScale.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyScale.SmallImage")));
            this.ribbonButtonModifyCopyScale.Text = "Scale selected entities";
            this.ribbonButtonModifyCopyScale.ToolTip = "Scales selected entities specifing base point and scale factor";
            this.ribbonButtonModifyCopyScale.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyCopyScale.ToolTipImage")));
            this.ribbonButtonModifyCopyScale.ToolTipTitle = "Scale selected entities";
            this.ribbonButtonModifyCopyScale.Click += new System.EventHandler(this.ribbonButtonModifyCopyScale_Click);
            // 
            // ribbonButtonModifyLines2Poly
            // 
            this.ribbonButtonModifyLines2Poly.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyLines2Poly.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLines2Poly.Image")));
            this.ribbonButtonModifyLines2Poly.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLines2Poly.LargeImage")));
            this.ribbonButtonModifyLines2Poly.Name = "ribbonButtonModifyLines2Poly";
            this.ribbonButtonModifyLines2Poly.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLines2Poly.SmallImage")));
            this.ribbonButtonModifyLines2Poly.Text = "Create a lwpolyline from selected entities";
            this.ribbonButtonModifyLines2Poly.ToolTip = "Creates a polyline of selected entities if they are contiguous lines and arcs";
            this.ribbonButtonModifyLines2Poly.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLines2Poly.ToolTipImage")));
            this.ribbonButtonModifyLines2Poly.ToolTipTitle = "Create a polyline from selected entities";
            this.ribbonButtonModifyLines2Poly.Click += new System.EventHandler(this.ribbonButtonModifyLines2Poly_Click);
            // 
            // ribbonButtonLines2PolyB
            // 
            this.ribbonButtonLines2PolyB.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonLines2PolyB.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLines2PolyB.Image")));
            this.ribbonButtonLines2PolyB.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLines2PolyB.LargeImage")));
            this.ribbonButtonLines2PolyB.Name = "ribbonButtonLines2PolyB";
            this.ribbonButtonLines2PolyB.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLines2PolyB.SmallImage")));
            this.ribbonButtonLines2PolyB.Text = "Create a bulged lwpolyline from selected entities";
            this.ribbonButtonLines2PolyB.Click += new System.EventHandler(this.ribbonButtonLines2PolyB_Click);
            // 
            // ribbonButtonModifyBlock
            // 
            this.ribbonButtonModifyBlock.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyBlock.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyBlock.Image")));
            this.ribbonButtonModifyBlock.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyBlock.LargeImage")));
            this.ribbonButtonModifyBlock.Name = "ribbonButtonModifyBlock";
            this.ribbonButtonModifyBlock.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyBlock.SmallImage")));
            this.ribbonButtonModifyBlock.Text = "Create a block from selected entities";
            this.ribbonButtonModifyBlock.ToolTip = "Creates a new block from selected entities";
            this.ribbonButtonModifyBlock.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyBlock.ToolTipImage")));
            this.ribbonButtonModifyBlock.ToolTipTitle = "Create a block";
            this.ribbonButtonModifyBlock.Click += new System.EventHandler(this.ribbonButtonModifyBlock_Click);
            // 
            // ribbonButtonModifyRotate
            // 
            this.ribbonButtonModifyRotate.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyRotate.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRotate.Image")));
            this.ribbonButtonModifyRotate.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRotate.LargeImage")));
            this.ribbonButtonModifyRotate.Name = "ribbonButtonModifyRotate";
            this.ribbonButtonModifyRotate.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRotate.SmallImage")));
            this.ribbonButtonModifyRotate.Text = "Mirror selected entities about arbitrary axis";
            this.ribbonButtonModifyRotate.ToolTip = "Mirrors selected entities about arbitrary axis";
            this.ribbonButtonModifyRotate.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyRotate.ToolTipImage")));
            this.ribbonButtonModifyRotate.ToolTipTitle = "Mirror about arbitrary axis";
            this.ribbonButtonModifyRotate.Click += new System.EventHandler(this.ribbonButtonModifyRotate_Click);
            // 
            // ribbonButtonModifyArray
            // 
            this.ribbonButtonModifyArray.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyArray.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArray.Image")));
            this.ribbonButtonModifyArray.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArray.LargeImage")));
            this.ribbonButtonModifyArray.Name = "ribbonButtonModifyArray";
            this.ribbonButtonModifyArray.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArray.SmallImage")));
            this.ribbonButtonModifyArray.Text = "Creates an array with selected entities";
            this.ribbonButtonModifyArray.ToolTip = "Creates an array with selected entities";
            this.ribbonButtonModifyArray.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArray.ToolTipImage")));
            this.ribbonButtonModifyArray.ToolTipTitle = "Array";
            this.ribbonButtonModifyArray.Click += new System.EventHandler(this.ribbonButtonModifyArray_Click);
            // 
            // ribbonButtonModifyArrayPolar
            // 
            this.ribbonButtonModifyArrayPolar.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyArrayPolar.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArrayPolar.Image")));
            this.ribbonButtonModifyArrayPolar.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArrayPolar.LargeImage")));
            this.ribbonButtonModifyArrayPolar.Name = "ribbonButtonModifyArrayPolar";
            this.ribbonButtonModifyArrayPolar.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArrayPolar.SmallImage")));
            this.ribbonButtonModifyArrayPolar.Text = "Creates a polar array with selected entities";
            this.ribbonButtonModifyArrayPolar.ToolTip = "Create a polar array of selected objects";
            this.ribbonButtonModifyArrayPolar.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyArrayPolar.ToolTipImage")));
            this.ribbonButtonModifyArrayPolar.ToolTipTitle = "Polar array";
            this.ribbonButtonModifyArrayPolar.Click += new System.EventHandler(this.ribbonButtonModifyArrayPolar_Click);
            // 
            // ribbonButtonModifyExplode
            // 
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeInsert);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeDimension);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodePoly);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeSpline);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeCircle);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeArc);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeEllipse);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeEllipseArcs);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeCircleArcs);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyLw2Poly);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyPoly2Lw);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyExplodeRegion);
            this.ribbonButtonModifyExplode.DropDownItems.Add(this.ribbonButtonModifyUngroup);
            this.ribbonButtonModifyExplode.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplode.Image")));
            this.ribbonButtonModifyExplode.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplode.LargeImage")));
            this.ribbonButtonModifyExplode.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyExplode.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyExplode.Name = "ribbonButtonModifyExplode";
            this.ribbonButtonModifyExplode.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplode.SmallImage")));
            this.ribbonButtonModifyExplode.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModifyExplode.Text = "ribbonButton6";
            this.ribbonButtonModifyExplode.ToolTip = "Breaks a compound entity into its component entities";
            this.ribbonButtonModifyExplode.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplode.ToolTipImage")));
            this.ribbonButtonModifyExplode.ToolTipTitle = "Explode";
            this.ribbonButtonModifyExplode.DropDownShowing += new System.EventHandler(this.ribbonButtonModifyExplode_DropDownShowing);
            // 
            // ribbonButtonModifyExplodeInsert
            // 
            this.ribbonButtonModifyExplodeInsert.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeInsert.DropDownItems.Add(this.ribbonButtonExplodeInserSingle);
            this.ribbonButtonModifyExplodeInsert.DropDownItems.Add(this.ribbonButtonExplodeInsertRect);
            this.ribbonButtonModifyExplodeInsert.DropDownItems.Add(this.ribbonButtonExplodeInsertAll);
            this.ribbonButtonModifyExplodeInsert.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeInsert.Image")));
            this.ribbonButtonModifyExplodeInsert.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeInsert.LargeImage")));
            this.ribbonButtonModifyExplodeInsert.Name = "ribbonButtonModifyExplodeInsert";
            this.ribbonButtonModifyExplodeInsert.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeInsert.SmallImage")));
            this.ribbonButtonModifyExplodeInsert.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModifyExplodeInsert.Text = "Insert";
            this.ribbonButtonModifyExplodeInsert.ToolTip = "Breaks an insert into its component entities";
            this.ribbonButtonModifyExplodeInsert.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeInsert.ToolTipImage")));
            this.ribbonButtonModifyExplodeInsert.ToolTipTitle = "Explode insert";
            this.ribbonButtonModifyExplodeInsert.Click += new System.EventHandler(this.ribbonButtonModifyExplodeInsert_Click);
            // 
            // ribbonButtonExplodeInserSingle
            // 
            this.ribbonButtonExplodeInserSingle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodeInserSingle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInserSingle.Image")));
            this.ribbonButtonExplodeInserSingle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInserSingle.LargeImage")));
            this.ribbonButtonExplodeInserSingle.Name = "ribbonButtonExplodeInserSingle";
            this.ribbonButtonExplodeInserSingle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInserSingle.SmallImage")));
            this.ribbonButtonExplodeInserSingle.Text = "Select single insert";
            this.ribbonButtonExplodeInserSingle.Click += new System.EventHandler(this.ribbonButtonExplodeInserSingle_Click);
            // 
            // ribbonButtonExplodeInsertRect
            // 
            this.ribbonButtonExplodeInsertRect.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodeInsertRect.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInsertRect.Image")));
            this.ribbonButtonExplodeInsertRect.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInsertRect.LargeImage")));
            this.ribbonButtonExplodeInsertRect.Name = "ribbonButtonExplodeInsertRect";
            this.ribbonButtonExplodeInsertRect.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInsertRect.SmallImage")));
            this.ribbonButtonExplodeInsertRect.Text = "Select inserts with a rectangle";
            this.ribbonButtonExplodeInsertRect.Click += new System.EventHandler(this.ribbonButtonExplodeInsertRect_Click);
            // 
            // ribbonButtonExplodeInsertAll
            // 
            this.ribbonButtonExplodeInsertAll.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodeInsertAll.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInsertAll.Image")));
            this.ribbonButtonExplodeInsertAll.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInsertAll.LargeImage")));
            this.ribbonButtonExplodeInsertAll.Name = "ribbonButtonExplodeInsertAll";
            this.ribbonButtonExplodeInsertAll.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeInsertAll.SmallImage")));
            this.ribbonButtonExplodeInsertAll.Text = "Explode all inserts";
            this.ribbonButtonExplodeInsertAll.Click += new System.EventHandler(this.ribbonButtonExplodeInsertAll_Click);
            // 
            // ribbonButtonModifyExplodeDimension
            // 
            this.ribbonButtonModifyExplodeDimension.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeDimension.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeDimension.Image")));
            this.ribbonButtonModifyExplodeDimension.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeDimension.LargeImage")));
            this.ribbonButtonModifyExplodeDimension.Name = "ribbonButtonModifyExplodeDimension";
            this.ribbonButtonModifyExplodeDimension.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeDimension.SmallImage")));
            this.ribbonButtonModifyExplodeDimension.Text = "Dimension";
            this.ribbonButtonModifyExplodeDimension.Click += new System.EventHandler(this.ribbonButtonModifyExplodeDimension_Click);
            // 
            // ribbonButtonModifyExplodePoly
            // 
            this.ribbonButtonModifyExplodePoly.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodePoly.DropDownItems.Add(this.ribbonButtonExplodePolySingle);
            this.ribbonButtonModifyExplodePoly.DropDownItems.Add(this.ribbonButtonExplodePolyRect);
            this.ribbonButtonModifyExplodePoly.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodePoly.Image")));
            this.ribbonButtonModifyExplodePoly.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodePoly.LargeImage")));
            this.ribbonButtonModifyExplodePoly.Name = "ribbonButtonModifyExplodePoly";
            this.ribbonButtonModifyExplodePoly.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodePoly.SmallImage")));
            this.ribbonButtonModifyExplodePoly.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModifyExplodePoly.Text = "Polyline to lines and arcs";
            this.ribbonButtonModifyExplodePoly.ToolTip = "Breaks a polyline into lines and arcs";
            this.ribbonButtonModifyExplodePoly.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodePoly.ToolTipImage")));
            this.ribbonButtonModifyExplodePoly.ToolTipTitle = "Explode polyline";
            this.ribbonButtonModifyExplodePoly.Click += new System.EventHandler(this.ribbonButtonModifyExplodePoly_Click);
            // 
            // ribbonButtonExplodePolySingle
            // 
            this.ribbonButtonExplodePolySingle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodePolySingle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodePolySingle.Image")));
            this.ribbonButtonExplodePolySingle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodePolySingle.LargeImage")));
            this.ribbonButtonExplodePolySingle.Name = "ribbonButtonExplodePolySingle";
            this.ribbonButtonExplodePolySingle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodePolySingle.SmallImage")));
            this.ribbonButtonExplodePolySingle.Text = "Select single polyline";
            this.ribbonButtonExplodePolySingle.Click += new System.EventHandler(this.ribbonButtonExplodePolySingle_Click);
            // 
            // ribbonButtonExplodePolyRect
            // 
            this.ribbonButtonExplodePolyRect.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodePolyRect.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodePolyRect.Image")));
            this.ribbonButtonExplodePolyRect.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodePolyRect.LargeImage")));
            this.ribbonButtonExplodePolyRect.Name = "ribbonButtonExplodePolyRect";
            this.ribbonButtonExplodePolyRect.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodePolyRect.SmallImage")));
            this.ribbonButtonExplodePolyRect.Text = "Select polylines with a rectangle";
            this.ribbonButtonExplodePolyRect.Click += new System.EventHandler(this.ribbonButtonExplodePolyRect_Click);
            // 
            // ribbonButtonModifyExplodeSpline
            // 
            this.ribbonButtonModifyExplodeSpline.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeSpline.DropDownItems.Add(this.ribbonButtonExplodeSplineSingle);
            this.ribbonButtonModifyExplodeSpline.DropDownItems.Add(this.ribbonButtonExplodeSplineRectangle);
            this.ribbonButtonModifyExplodeSpline.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeSpline.Image")));
            this.ribbonButtonModifyExplodeSpline.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeSpline.LargeImage")));
            this.ribbonButtonModifyExplodeSpline.Name = "ribbonButtonModifyExplodeSpline";
            this.ribbonButtonModifyExplodeSpline.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeSpline.SmallImage")));
            this.ribbonButtonModifyExplodeSpline.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonModifyExplodeSpline.Text = "Spline to polyline";
            // 
            // ribbonButtonExplodeSplineSingle
            // 
            this.ribbonButtonExplodeSplineSingle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodeSplineSingle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeSplineSingle.Image")));
            this.ribbonButtonExplodeSplineSingle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeSplineSingle.LargeImage")));
            this.ribbonButtonExplodeSplineSingle.Name = "ribbonButtonExplodeSplineSingle";
            this.ribbonButtonExplodeSplineSingle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeSplineSingle.SmallImage")));
            this.ribbonButtonExplodeSplineSingle.Text = "Select single spline";
            this.ribbonButtonExplodeSplineSingle.Click += new System.EventHandler(this.ribbonButtonExplodeSplineSingle_Click);
            // 
            // ribbonButtonExplodeSplineRectangle
            // 
            this.ribbonButtonExplodeSplineRectangle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonExplodeSplineRectangle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeSplineRectangle.Image")));
            this.ribbonButtonExplodeSplineRectangle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeSplineRectangle.LargeImage")));
            this.ribbonButtonExplodeSplineRectangle.Name = "ribbonButtonExplodeSplineRectangle";
            this.ribbonButtonExplodeSplineRectangle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonExplodeSplineRectangle.SmallImage")));
            this.ribbonButtonExplodeSplineRectangle.Text = "Select splines with a rectangle";
            this.ribbonButtonExplodeSplineRectangle.Click += new System.EventHandler(this.ribbonButtonExplodeSplineRectangle_Click);
            // 
            // ribbonButtonModifyExplodeCircle
            // 
            this.ribbonButtonModifyExplodeCircle.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeCircle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircle.Image")));
            this.ribbonButtonModifyExplodeCircle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircle.LargeImage")));
            this.ribbonButtonModifyExplodeCircle.Name = "ribbonButtonModifyExplodeCircle";
            this.ribbonButtonModifyExplodeCircle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircle.SmallImage")));
            this.ribbonButtonModifyExplodeCircle.Text = "Circle to polyline";
            this.ribbonButtonModifyExplodeCircle.ToolTip = "Transforms a circle into polyline";
            this.ribbonButtonModifyExplodeCircle.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircle.ToolTipImage")));
            this.ribbonButtonModifyExplodeCircle.ToolTipTitle = "Explode circle";
            this.ribbonButtonModifyExplodeCircle.Click += new System.EventHandler(this.ribbonButtonModifyExplodeCircle_Click);
            // 
            // ribbonButtonModifyExplodeArc
            // 
            this.ribbonButtonModifyExplodeArc.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeArc.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeArc.Image")));
            this.ribbonButtonModifyExplodeArc.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeArc.LargeImage")));
            this.ribbonButtonModifyExplodeArc.Name = "ribbonButtonModifyExplodeArc";
            this.ribbonButtonModifyExplodeArc.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeArc.SmallImage")));
            this.ribbonButtonModifyExplodeArc.Text = "Arc to polyline";
            this.ribbonButtonModifyExplodeArc.ToolTip = "Transforms an arc into polyline";
            this.ribbonButtonModifyExplodeArc.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeArc.ToolTipImage")));
            this.ribbonButtonModifyExplodeArc.ToolTipTitle = "Explode arc";
            this.ribbonButtonModifyExplodeArc.Click += new System.EventHandler(this.ribbonButtonModifyExplodeArc_Click);
            // 
            // ribbonButtonModifyExplodeEllipse
            // 
            this.ribbonButtonModifyExplodeEllipse.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeEllipse.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipse.Image")));
            this.ribbonButtonModifyExplodeEllipse.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipse.LargeImage")));
            this.ribbonButtonModifyExplodeEllipse.Name = "ribbonButtonModifyExplodeEllipse";
            this.ribbonButtonModifyExplodeEllipse.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipse.SmallImage")));
            this.ribbonButtonModifyExplodeEllipse.Text = "Ellipse to polyline";
            this.ribbonButtonModifyExplodeEllipse.ToolTip = "Transforms an ellipse into polyline";
            this.ribbonButtonModifyExplodeEllipse.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipse.ToolTipImage")));
            this.ribbonButtonModifyExplodeEllipse.ToolTipTitle = "Explode ellipse";
            this.ribbonButtonModifyExplodeEllipse.Click += new System.EventHandler(this.ribbonButtonModifyExplodeEllipse_Click);
            // 
            // ribbonButtonModifyExplodeEllipseArcs
            // 
            this.ribbonButtonModifyExplodeEllipseArcs.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeEllipseArcs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipseArcs.Image")));
            this.ribbonButtonModifyExplodeEllipseArcs.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipseArcs.LargeImage")));
            this.ribbonButtonModifyExplodeEllipseArcs.Name = "ribbonButtonModifyExplodeEllipseArcs";
            this.ribbonButtonModifyExplodeEllipseArcs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeEllipseArcs.SmallImage")));
            this.ribbonButtonModifyExplodeEllipseArcs.Text = "Ellipse to arcs";
            this.ribbonButtonModifyExplodeEllipseArcs.Click += new System.EventHandler(this.ribbonButtonModifyExplodeEllipseArcs_Click);
            // 
            // ribbonButtonModifyExplodeCircleArcs
            // 
            this.ribbonButtonModifyExplodeCircleArcs.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeCircleArcs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircleArcs.Image")));
            this.ribbonButtonModifyExplodeCircleArcs.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircleArcs.LargeImage")));
            this.ribbonButtonModifyExplodeCircleArcs.Name = "ribbonButtonModifyExplodeCircleArcs";
            this.ribbonButtonModifyExplodeCircleArcs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeCircleArcs.SmallImage")));
            this.ribbonButtonModifyExplodeCircleArcs.Text = "Circle to arcs";
            this.ribbonButtonModifyExplodeCircleArcs.Click += new System.EventHandler(this.ribbonButtonModifyExplodeCircleArcs_Click);
            // 
            // ribbonButtonModifyLw2Poly
            // 
            this.ribbonButtonModifyLw2Poly.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyLw2Poly.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLw2Poly.Image")));
            this.ribbonButtonModifyLw2Poly.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLw2Poly.LargeImage")));
            this.ribbonButtonModifyLw2Poly.Name = "ribbonButtonModifyLw2Poly";
            this.ribbonButtonModifyLw2Poly.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyLw2Poly.SmallImage")));
            this.ribbonButtonModifyLw2Poly.Text = "Lwpolyline to polyline";
            this.ribbonButtonModifyLw2Poly.Click += new System.EventHandler(this.ribbonButtonModifyLw2Poly_Click);
            // 
            // ribbonButtonModifyPoly2Lw
            // 
            this.ribbonButtonModifyPoly2Lw.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyPoly2Lw.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyPoly2Lw.Image")));
            this.ribbonButtonModifyPoly2Lw.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyPoly2Lw.LargeImage")));
            this.ribbonButtonModifyPoly2Lw.Name = "ribbonButtonModifyPoly2Lw";
            this.ribbonButtonModifyPoly2Lw.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyPoly2Lw.SmallImage")));
            this.ribbonButtonModifyPoly2Lw.Text = "Polyline to lwpolyline";
            this.ribbonButtonModifyPoly2Lw.Click += new System.EventHandler(this.ribbonButtonModifyPoly2Lw_Click);
            // 
            // ribbonButtonModifyExplodeRegion
            // 
            this.ribbonButtonModifyExplodeRegion.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyExplodeRegion.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeRegion.Image")));
            this.ribbonButtonModifyExplodeRegion.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeRegion.LargeImage")));
            this.ribbonButtonModifyExplodeRegion.Name = "ribbonButtonModifyExplodeRegion";
            this.ribbonButtonModifyExplodeRegion.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExplodeRegion.SmallImage")));
            this.ribbonButtonModifyExplodeRegion.Text = "Region to lines and arcs";
            this.ribbonButtonModifyExplodeRegion.Click += new System.EventHandler(this.ribbonButtonModifyExplodeRegion_Click);
            // 
            // ribbonButtonModifyUngroup
            // 
            this.ribbonButtonModifyUngroup.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonModifyUngroup.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyUngroup.Image")));
            this.ribbonButtonModifyUngroup.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyUngroup.LargeImage")));
            this.ribbonButtonModifyUngroup.Name = "ribbonButtonModifyUngroup";
            this.ribbonButtonModifyUngroup.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyUngroup.SmallImage")));
            this.ribbonButtonModifyUngroup.Text = "Ungroup entities";
            this.ribbonButtonModifyUngroup.Click += new System.EventHandler(this.ribbonButtonModifyUngroup_Click);
            // 
            // ribbonButtonModifyOffset
            // 
            this.ribbonButtonModifyOffset.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyOffset.Image")));
            this.ribbonButtonModifyOffset.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyOffset.LargeImage")));
            this.ribbonButtonModifyOffset.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyOffset.Name = "ribbonButtonModifyOffset";
            this.ribbonButtonModifyOffset.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyOffset.SmallImage")));
            this.ribbonButtonModifyOffset.Text = "Offset";
            this.ribbonButtonModifyOffset.ToolTip = "Creates concentric circles, or parallel lines";
            this.ribbonButtonModifyOffset.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyOffset.ToolTipImage")));
            this.ribbonButtonModifyOffset.ToolTipTitle = "Offset";
            this.ribbonButtonModifyOffset.Click += new System.EventHandler(this.ribbonButtonModifyOffset_Click);
            // 
            // ribbonButtonModifyTrim
            // 
            this.ribbonButtonModifyTrim.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyTrim.Image")));
            this.ribbonButtonModifyTrim.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyTrim.LargeImage")));
            this.ribbonButtonModifyTrim.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyTrim.Name = "ribbonButtonModifyTrim";
            this.ribbonButtonModifyTrim.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyTrim.SmallImage")));
            this.ribbonButtonModifyTrim.ToolTip = "Trims an object";
            this.ribbonButtonModifyTrim.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyTrim.ToolTipImage")));
            this.ribbonButtonModifyTrim.ToolTipTitle = "Trim";
            this.ribbonButtonModifyTrim.Click += new System.EventHandler(this.ribbonButtonModifyTrim_Click);
            // 
            // ribbonButtonModifyExtend
            // 
            this.ribbonButtonModifyExtend.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExtend.Image")));
            this.ribbonButtonModifyExtend.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExtend.LargeImage")));
            this.ribbonButtonModifyExtend.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyExtend.Name = "ribbonButtonModifyExtend";
            this.ribbonButtonModifyExtend.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExtend.SmallImage")));
            this.ribbonButtonModifyExtend.ToolTip = "Extends an object";
            this.ribbonButtonModifyExtend.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyExtend.ToolTipImage")));
            this.ribbonButtonModifyExtend.ToolTipTitle = "Extend";
            this.ribbonButtonModifyExtend.Click += new System.EventHandler(this.ribbonButtonModifyExtend_Click);
            // 
            // ribbonButtonModifyFillet
            // 
            this.ribbonButtonModifyFillet.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyFillet.Image")));
            this.ribbonButtonModifyFillet.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyFillet.LargeImage")));
            this.ribbonButtonModifyFillet.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyFillet.Name = "ribbonButtonModifyFillet";
            this.ribbonButtonModifyFillet.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyFillet.SmallImage")));
            this.ribbonButtonModifyFillet.ToolTip = "Rounds and fills the edges of objects";
            this.ribbonButtonModifyFillet.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyFillet.ToolTipImage")));
            this.ribbonButtonModifyFillet.ToolTipTitle = "Fillet";
            this.ribbonButtonModifyFillet.Click += new System.EventHandler(this.ribbonButtonModifyFillet_Click);
            // 
            // ribbonButtonModifyChamfer
            // 
            this.ribbonButtonModifyChamfer.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyChamfer.Image")));
            this.ribbonButtonModifyChamfer.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyChamfer.LargeImage")));
            this.ribbonButtonModifyChamfer.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyChamfer.Name = "ribbonButtonModifyChamfer";
            this.ribbonButtonModifyChamfer.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyChamfer.SmallImage")));
            this.ribbonButtonModifyChamfer.ToolTip = "Chamfers the edges of two objects";
            this.ribbonButtonModifyChamfer.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyChamfer.ToolTipImage")));
            this.ribbonButtonModifyChamfer.ToolTipTitle = "Chamfer";
            this.ribbonButtonModifyChamfer.Click += new System.EventHandler(this.ribbonButtonModifyChamfer_Click);
            // 
            // ribbonButtonModifyJoin
            // 
            this.ribbonButtonModifyJoin.DropDownItems.Add(this.ribbonButtonJoinTwoEntities);
            this.ribbonButtonModifyJoin.DropDownItems.Add(this.ribbonButtonAutoJoinWindow);
            this.ribbonButtonModifyJoin.DropDownItems.Add(this.ribbonButtonAutoJoinAll);
            this.ribbonButtonModifyJoin.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyJoin.Image")));
            this.ribbonButtonModifyJoin.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyJoin.LargeImage")));
            this.ribbonButtonModifyJoin.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonModifyJoin.Name = "ribbonButtonModifyJoin";
            this.ribbonButtonModifyJoin.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyJoin.SmallImage")));
            this.ribbonButtonModifyJoin.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonModifyJoin.Text = "";
            this.ribbonButtonModifyJoin.ToolTip = "Joins two entities";
            this.ribbonButtonModifyJoin.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonModifyJoin.ToolTipImage")));
            this.ribbonButtonModifyJoin.ToolTipTitle = "Join";
            this.ribbonButtonModifyJoin.Click += new System.EventHandler(this.ribbonButtonModifyJoin_Click);
            // 
            // ribbonButtonJoinTwoEntities
            // 
            this.ribbonButtonJoinTwoEntities.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonJoinTwoEntities.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJoinTwoEntities.Image")));
            this.ribbonButtonJoinTwoEntities.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJoinTwoEntities.LargeImage")));
            this.ribbonButtonJoinTwoEntities.Name = "ribbonButtonJoinTwoEntities";
            this.ribbonButtonJoinTwoEntities.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonJoinTwoEntities.SmallImage")));
            this.ribbonButtonJoinTwoEntities.Text = "Join two entites";
            this.ribbonButtonJoinTwoEntities.Click += new System.EventHandler(this.ribbonButtonJoinTwoEntities_Click);
            // 
            // ribbonButtonAutoJoinWindow
            // 
            this.ribbonButtonAutoJoinWindow.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAutoJoinWindow.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAutoJoinWindow.Image")));
            this.ribbonButtonAutoJoinWindow.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAutoJoinWindow.LargeImage")));
            this.ribbonButtonAutoJoinWindow.Name = "ribbonButtonAutoJoinWindow";
            this.ribbonButtonAutoJoinWindow.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAutoJoinWindow.SmallImage")));
            this.ribbonButtonAutoJoinWindow.Text = "Auto join entities selecting by windows";
            this.ribbonButtonAutoJoinWindow.Click += new System.EventHandler(this.ribbonButtonAutoJoinWindow_Click);
            // 
            // ribbonButtonAutoJoinAll
            // 
            this.ribbonButtonAutoJoinAll.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAutoJoinAll.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAutoJoinAll.Image")));
            this.ribbonButtonAutoJoinAll.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAutoJoinAll.LargeImage")));
            this.ribbonButtonAutoJoinAll.Name = "ribbonButtonAutoJoinAll";
            this.ribbonButtonAutoJoinAll.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAutoJoinAll.SmallImage")));
            this.ribbonButtonAutoJoinAll.Text = "Auto join all entities";
            this.ribbonButtonAutoJoinAll.Click += new System.EventHandler(this.ribbonButtonAutoJoinAll_Click);
            // 
            // ribbonButtonNormalize
            // 
            this.ribbonButtonNormalize.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormalize.Image")));
            this.ribbonButtonNormalize.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormalize.LargeImage")));
            this.ribbonButtonNormalize.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonNormalize.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonNormalize.Name = "ribbonButtonNormalize";
            this.ribbonButtonNormalize.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormalize.SmallImage")));
            this.ribbonButtonNormalize.ToolTip = "Projects all entities whose normal vector is not 0,0,1 on the XY plane";
            this.ribbonButtonNormalize.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonNormalize.ToolTipImage")));
            this.ribbonButtonNormalize.ToolTipTitle = "Normalize entities";
            this.ribbonButtonNormalize.Click += new System.EventHandler(this.ribbonButtonNormalize_Click);
            // 
            // ribbonPanelAnnotations
            // 
            this.ribbonPanelAnnotations.ButtonMoreVisible = false;
            this.ribbonPanelAnnotations.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelAnnotations.Image")));
            this.ribbonPanelAnnotations.Items.Add(this.ribbonButtonAnnotationsText);
            this.ribbonPanelAnnotations.Items.Add(this.ribbonButtonAnnotationsDimension);
            this.ribbonPanelAnnotations.Items.Add(this.ribbonButtonLeader);
            this.ribbonPanelAnnotations.Items.Add(this.ribbonComboBoxDimensionStyle);
            this.ribbonPanelAnnotations.Items.Add(this.ribbonComboBoxTextStyle);
            this.ribbonPanelAnnotations.Items.Add(this.ribbonComboBoxLayout);
            this.ribbonPanelAnnotations.Name = "ribbonPanelAnnotations";
            this.ribbonPanelAnnotations.Text = "Annotations";
            this.ribbonPanelAnnotations.ButtonMoreClick += new System.EventHandler(this.ribbonPanelAnnotations_ButtonMoreClick);
            // 
            // ribbonButtonAnnotationsText
            // 
            this.ribbonButtonAnnotationsText.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsText.Image")));
            this.ribbonButtonAnnotationsText.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsText.LargeImage")));
            this.ribbonButtonAnnotationsText.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonAnnotationsText.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonAnnotationsText.Name = "ribbonButtonAnnotationsText";
            this.ribbonButtonAnnotationsText.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsText.SmallImage")));
            this.ribbonButtonAnnotationsText.Text = "Text";
            this.ribbonButtonAnnotationsText.ToolTip = "Creates TEXT entities";
            this.ribbonButtonAnnotationsText.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsText.ToolTipImage")));
            this.ribbonButtonAnnotationsText.ToolTipTitle = "Text";
            this.ribbonButtonAnnotationsText.Click += new System.EventHandler(this.ribbonButtonAnnotationsText_Click);
            // 
            // ribbonButtonAnnotationsDimension
            // 
            this.ribbonButtonAnnotationsDimension.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAligned);
            this.ribbonButtonAnnotationsDimension.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionLinear);
            this.ribbonButtonAnnotationsDimension.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAngular);
            this.ribbonButtonAnnotationsDimension.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionDiameter);
            this.ribbonButtonAnnotationsDimension.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionradius);
            this.ribbonButtonAnnotationsDimension.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimension.Image")));
            this.ribbonButtonAnnotationsDimension.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimension.LargeImage")));
            this.ribbonButtonAnnotationsDimension.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonAnnotationsDimension.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonAnnotationsDimension.Name = "ribbonButtonAnnotationsDimension";
            this.ribbonButtonAnnotationsDimension.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimension.SmallImage")));
            this.ribbonButtonAnnotationsDimension.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonAnnotationsDimension.Text = "Dimension";
            this.ribbonButtonAnnotationsDimension.ToolTip = "Creates DIM entities";
            this.ribbonButtonAnnotationsDimension.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimension.ToolTipImage")));
            this.ribbonButtonAnnotationsDimension.ToolTipTitle = "Dimension";
            this.ribbonButtonAnnotationsDimension.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimension_Click);
            // 
            // ribbonButtonAnnotationsDimensionAligned
            // 
            this.ribbonButtonAnnotationsDimensionAligned.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAligned.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAlignedStartEnd);
            this.ribbonButtonAnnotationsDimensionAligned.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAlignedLine);
            this.ribbonButtonAnnotationsDimensionAligned.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAligned.Image")));
            this.ribbonButtonAnnotationsDimensionAligned.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAligned.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAligned.Name = "ribbonButtonAnnotationsDimensionAligned";
            this.ribbonButtonAnnotationsDimensionAligned.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAligned.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAligned.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonAnnotationsDimensionAligned.Text = "Aligned";
            // 
            // ribbonButtonAnnotationsDimensionAlignedStartEnd
            // 
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAlignedStartEnd.Image")));
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAlignedStartEnd.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.Name = "ribbonButtonAnnotationsDimensionAlignedStartEnd";
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAlignedStartEnd.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.Text = "Start point, end point, position";
            this.ribbonButtonAnnotationsDimensionAlignedStartEnd.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionAlignedStartEnd_Click);
            // 
            // ribbonButtonAnnotationsDimensionAlignedLine
            // 
            this.ribbonButtonAnnotationsDimensionAlignedLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAlignedLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAlignedLine.Image")));
            this.ribbonButtonAnnotationsDimensionAlignedLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAlignedLine.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAlignedLine.Name = "ribbonButtonAnnotationsDimensionAlignedLine";
            this.ribbonButtonAnnotationsDimensionAlignedLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAlignedLine.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAlignedLine.Text = "Line, position";
            this.ribbonButtonAnnotationsDimensionAlignedLine.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionAlignedLine_Click);
            // 
            // ribbonButtonAnnotationsDimensionLinear
            // 
            this.ribbonButtonAnnotationsDimensionLinear.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionLinear.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionLinearStartEnd);
            this.ribbonButtonAnnotationsDimensionLinear.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionLinearLine);
            this.ribbonButtonAnnotationsDimensionLinear.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinear.Image")));
            this.ribbonButtonAnnotationsDimensionLinear.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinear.LargeImage")));
            this.ribbonButtonAnnotationsDimensionLinear.Name = "ribbonButtonAnnotationsDimensionLinear";
            this.ribbonButtonAnnotationsDimensionLinear.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinear.SmallImage")));
            this.ribbonButtonAnnotationsDimensionLinear.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonAnnotationsDimensionLinear.Text = "Linear";
            // 
            // ribbonButtonAnnotationsDimensionLinearStartEnd
            // 
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinearStartEnd.Image")));
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinearStartEnd.LargeImage")));
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.Name = "ribbonButtonAnnotationsDimensionLinearStartEnd";
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinearStartEnd.SmallImage")));
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.Text = "Start point, end point, position";
            this.ribbonButtonAnnotationsDimensionLinearStartEnd.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionLinearStartEnd_Click);
            // 
            // ribbonButtonAnnotationsDimensionLinearLine
            // 
            this.ribbonButtonAnnotationsDimensionLinearLine.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionLinearLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinearLine.Image")));
            this.ribbonButtonAnnotationsDimensionLinearLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinearLine.LargeImage")));
            this.ribbonButtonAnnotationsDimensionLinearLine.Name = "ribbonButtonAnnotationsDimensionLinearLine";
            this.ribbonButtonAnnotationsDimensionLinearLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionLinearLine.SmallImage")));
            this.ribbonButtonAnnotationsDimensionLinearLine.Text = "Line, position";
            this.ribbonButtonAnnotationsDimensionLinearLine.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionLinearLine_Click);
            // 
            // ribbonButtonAnnotationsDimensionAngular
            // 
            this.ribbonButtonAnnotationsDimensionAngular.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAngular.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAngular2Lines);
            this.ribbonButtonAnnotationsDimensionAngular.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAngularArc);
            this.ribbonButtonAnnotationsDimensionAngular.DropDownItems.Add(this.ribbonButtonAnnotationsDimensionAngular3points);
            this.ribbonButtonAnnotationsDimensionAngular.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular.Image")));
            this.ribbonButtonAnnotationsDimensionAngular.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAngular.Name = "ribbonButtonAnnotationsDimensionAngular";
            this.ribbonButtonAnnotationsDimensionAngular.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAngular.Style = System.Windows.Forms.RibbonButtonStyle.DropDown;
            this.ribbonButtonAnnotationsDimensionAngular.Text = "Angular";
            // 
            // ribbonButtonAnnotationsDimensionAngular2Lines
            // 
            this.ribbonButtonAnnotationsDimensionAngular2Lines.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAngular2Lines.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular2Lines.Image")));
            this.ribbonButtonAnnotationsDimensionAngular2Lines.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular2Lines.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAngular2Lines.Name = "ribbonButtonAnnotationsDimensionAngular2Lines";
            this.ribbonButtonAnnotationsDimensionAngular2Lines.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular2Lines.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAngular2Lines.Text = "First line, second line, position";
            this.ribbonButtonAnnotationsDimensionAngular2Lines.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionAngular2Lines_Click);
            // 
            // ribbonButtonAnnotationsDimensionAngularArc
            // 
            this.ribbonButtonAnnotationsDimensionAngularArc.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAngularArc.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngularArc.Image")));
            this.ribbonButtonAnnotationsDimensionAngularArc.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngularArc.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAngularArc.Name = "ribbonButtonAnnotationsDimensionAngularArc";
            this.ribbonButtonAnnotationsDimensionAngularArc.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngularArc.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAngularArc.Text = "Arc, position";
            this.ribbonButtonAnnotationsDimensionAngularArc.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionAngularArc_Click);
            // 
            // ribbonButtonAnnotationsDimensionAngular3points
            // 
            this.ribbonButtonAnnotationsDimensionAngular3points.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionAngular3points.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular3points.Image")));
            this.ribbonButtonAnnotationsDimensionAngular3points.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular3points.LargeImage")));
            this.ribbonButtonAnnotationsDimensionAngular3points.Name = "ribbonButtonAnnotationsDimensionAngular3points";
            this.ribbonButtonAnnotationsDimensionAngular3points.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionAngular3points.SmallImage")));
            this.ribbonButtonAnnotationsDimensionAngular3points.Text = "Center point, start point, end point, position";
            this.ribbonButtonAnnotationsDimensionAngular3points.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionAngular3points_Click);
            // 
            // ribbonButtonAnnotationsDimensionDiameter
            // 
            this.ribbonButtonAnnotationsDimensionDiameter.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionDiameter.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionDiameter.Image")));
            this.ribbonButtonAnnotationsDimensionDiameter.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionDiameter.LargeImage")));
            this.ribbonButtonAnnotationsDimensionDiameter.Name = "ribbonButtonAnnotationsDimensionDiameter";
            this.ribbonButtonAnnotationsDimensionDiameter.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionDiameter.SmallImage")));
            this.ribbonButtonAnnotationsDimensionDiameter.Text = "Diameter";
            this.ribbonButtonAnnotationsDimensionDiameter.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionDiameter_Click);
            // 
            // ribbonButtonAnnotationsDimensionradius
            // 
            this.ribbonButtonAnnotationsDimensionradius.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonAnnotationsDimensionradius.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionradius.Image")));
            this.ribbonButtonAnnotationsDimensionradius.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionradius.LargeImage")));
            this.ribbonButtonAnnotationsDimensionradius.Name = "ribbonButtonAnnotationsDimensionradius";
            this.ribbonButtonAnnotationsDimensionradius.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAnnotationsDimensionradius.SmallImage")));
            this.ribbonButtonAnnotationsDimensionradius.Text = "Radius";
            this.ribbonButtonAnnotationsDimensionradius.Click += new System.EventHandler(this.ribbonButtonAnnotationsDimensionradius_Click);
            // 
            // ribbonButtonLeader
            // 
            this.ribbonButtonLeader.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLeader.Image")));
            this.ribbonButtonLeader.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLeader.LargeImage")));
            this.ribbonButtonLeader.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonLeader.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonLeader.Name = "ribbonButtonLeader";
            this.ribbonButtonLeader.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLeader.SmallImage")));
            this.ribbonButtonLeader.Text = "Leader";
            this.ribbonButtonLeader.ToolTip = "Creates LEADER entities";
            this.ribbonButtonLeader.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLeader.ToolTipImage")));
            this.ribbonButtonLeader.ToolTipTitle = "Leader";
            this.ribbonButtonLeader.Click += new System.EventHandler(this.ribbonButtonLeader_Click);
            // 
            // ribbonComboBoxDimensionStyle
            // 
            this.ribbonComboBoxDimensionStyle.AllowTextEdit = false;
            this.ribbonComboBoxDimensionStyle.DrawIconsBar = false;
            this.ribbonComboBoxDimensionStyle.DropDownItems.Add(this.ribbonComboBox1);
            this.ribbonComboBoxDimensionStyle.LabelWidth = 60;
            this.ribbonComboBoxDimensionStyle.Name = "ribbonComboBoxDimensionStyle";
            this.ribbonComboBoxDimensionStyle.Text = "Dim style";
            this.ribbonComboBoxDimensionStyle.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxDimensionStyle.TextBoxText = "";
            this.ribbonComboBoxDimensionStyle.ToolTip = "Selects current dimension style";
            this.ribbonComboBoxDimensionStyle.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxDimensionStyle.ToolTipImage")));
            this.ribbonComboBoxDimensionStyle.ToolTipTitle = "DImension Style";
            this.ribbonComboBoxDimensionStyle.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxDimensionStyle_DropDownItemClicked);
            // 
            // ribbonComboBox1
            // 
            this.ribbonComboBox1.Name = "ribbonComboBox1";
            this.ribbonComboBox1.Text = "ribbonComboBox1";
            this.ribbonComboBox1.TextBoxText = "";
            // 
            // ribbonComboBoxTextStyle
            // 
            this.ribbonComboBoxTextStyle.AllowTextEdit = false;
            this.ribbonComboBoxTextStyle.DrawIconsBar = false;
            this.ribbonComboBoxTextStyle.LabelWidth = 60;
            this.ribbonComboBoxTextStyle.Name = "ribbonComboBoxTextStyle";
            this.ribbonComboBoxTextStyle.Text = "Text style";
            this.ribbonComboBoxTextStyle.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxTextStyle.TextBoxText = "";
            this.ribbonComboBoxTextStyle.ToolTip = "Selects current text style";
            this.ribbonComboBoxTextStyle.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxTextStyle.ToolTipImage")));
            this.ribbonComboBoxTextStyle.ToolTipTitle = "Text style";
            this.ribbonComboBoxTextStyle.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxTextStyle_DropDownItemClicked);
            // 
            // ribbonComboBoxLayout
            // 
            this.ribbonComboBoxLayout.AllowTextEdit = false;
            this.ribbonComboBoxLayout.LabelWidth = 60;
            this.ribbonComboBoxLayout.Name = "ribbonComboBoxLayout";
            this.ribbonComboBoxLayout.Text = "Layout";
            this.ribbonComboBoxLayout.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxLayout.TextBoxText = "";
            this.ribbonComboBoxLayout.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxLayout_DropDownItemClicked);
            // 
            // ribbonPanelProperites
            // 
            this.ribbonPanelProperites.ButtonMoreVisible = false;
            this.ribbonPanelProperites.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelProperites.Image")));
            this.ribbonPanelProperites.Items.Add(this.ribbonComboBoxLayers);
            this.ribbonPanelProperites.Items.Add(this.ribbonComboBoxLineTypes);
            this.ribbonPanelProperites.Items.Add(this.ribbonItemGroupCurrentColor);
            this.ribbonPanelProperites.Items.Add(this.ribbonTextBoxElevation);
            this.ribbonPanelProperites.Items.Add(this.ribbonTextBoxThickness);
            this.ribbonPanelProperites.Items.Add(this.ribbonTextBoxLtScale);
            this.ribbonPanelProperites.Items.Add(this.ribbonButtonPropertiesUnits);
            this.ribbonPanelProperites.Items.Add(this.ribbonButtonPropertiesLayers);
            this.ribbonPanelProperites.Items.Add(this.ribbonButtonPropertiesDimStyles);
            this.ribbonPanelProperites.Name = "ribbonPanelProperites";
            this.ribbonPanelProperites.Text = "Properties";
            this.ribbonPanelProperites.ButtonMoreClick += new System.EventHandler(this.ribbonPanelProperites_ButtonMoreClick);
            // 
            // ribbonComboBoxLayers
            // 
            this.ribbonComboBoxLayers.AllowTextEdit = false;
            this.ribbonComboBoxLayers.DrawIconsBar = false;
            this.ribbonComboBoxLayers.DropDownItems.Add(this.ribbonButton1);
            this.ribbonComboBoxLayers.DropDownItems.Add(this.ribbonButton2);
            this.ribbonComboBoxLayers.Image = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxLayers.Image")));
            this.ribbonComboBoxLayers.Name = "ribbonComboBoxLayers";
            this.ribbonComboBoxLayers.Text = "";
            this.ribbonComboBoxLayers.TextBoxText = "";
            this.ribbonComboBoxLayers.ToolTip = "Selects current layer";
            this.ribbonComboBoxLayers.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxLayers.ToolTipImage")));
            this.ribbonComboBoxLayers.ToolTipTitle = "Current Layer";
            this.ribbonComboBoxLayers.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxLayers_DropDownItemClicked);
            // 
            // ribbonButton1
            // 
            this.ribbonButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.Image")));
            this.ribbonButton1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.LargeImage")));
            this.ribbonButton1.Name = "ribbonButton1";
            this.ribbonButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1.SmallImage")));
            this.ribbonButton1.Text = "Prova";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.LargeImage")));
            this.ribbonButton2.Name = "ribbonButton2";
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "wrwrw";
            // 
            // ribbonComboBoxLineTypes
            // 
            this.ribbonComboBoxLineTypes.AllowTextEdit = false;
            this.ribbonComboBoxLineTypes.Image = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxLineTypes.Image")));
            this.ribbonComboBoxLineTypes.Name = "ribbonComboBoxLineTypes";
            this.ribbonComboBoxLineTypes.Text = "";
            this.ribbonComboBoxLineTypes.TextBoxText = "";
            this.ribbonComboBoxLineTypes.ToolTip = "Selects current line type";
            this.ribbonComboBoxLineTypes.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxLineTypes.ToolTipImage")));
            this.ribbonComboBoxLineTypes.ToolTipTitle = "Current LineType";
            this.ribbonComboBoxLineTypes.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxLineTypes_DropDownItemClicked);
            // 
            // ribbonItemGroupCurrentColor
            // 
            this.ribbonItemGroupCurrentColor.Items.Add(this.ribbonLabel3);
            this.ribbonItemGroupCurrentColor.Items.Add(this.ribbonColorChooserColor);
            this.ribbonItemGroupCurrentColor.Items.Add(this.ribbonLabelCurrentColor);
            this.ribbonItemGroupCurrentColor.Name = "ribbonItemGroupCurrentColor";
            this.ribbonItemGroupCurrentColor.Text = "";
            // 
            // ribbonLabel3
            // 
            this.ribbonLabel3.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel3.Name = "ribbonLabel3";
            this.ribbonLabel3.Text = "Color";
            this.ribbonLabel3.ToolTip = "Selects current color";
            this.ribbonLabel3.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonLabel3.ToolTipImage")));
            this.ribbonLabel3.ToolTipTitle = "Current color";
            this.ribbonLabel3.Click += new System.EventHandler(this.ribbonLabel3_Click);
            // 
            // ribbonColorChooserColor
            // 
            this.ribbonColorChooserColor.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserColor.DropDownItems.Add(this.ribbonLabel1);
            this.ribbonColorChooserColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserColor.Image")));
            this.ribbonColorChooserColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserColor.LargeImage")));
            this.ribbonColorChooserColor.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserColor.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserColor.Name = "ribbonColorChooserColor";
            this.ribbonColorChooserColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserColor.SmallImage")));
            this.ribbonColorChooserColor.Text = "ribbonColorChooser1";
            this.ribbonColorChooserColor.ToolTip = "Selects current color";
            this.ribbonColorChooserColor.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserColor.ToolTipImage")));
            this.ribbonColorChooserColor.ToolTipTitle = "Current Color";
            this.ribbonColorChooserColor.Click += new System.EventHandler(this.ribbonColorChooserColor_Click);
            // 
            // ribbonLabel1
            // 
            this.ribbonLabel1.Name = "ribbonLabel1";
            this.ribbonLabel1.Text = "Margins";
            // 
            // ribbonLabelCurrentColor
            // 
            this.ribbonLabelCurrentColor.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabelCurrentColor.Name = "ribbonLabelCurrentColor";
            this.ribbonLabelCurrentColor.Text = "ByLayer";
            this.ribbonLabelCurrentColor.ToolTip = "Selects current color";
            this.ribbonLabelCurrentColor.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonLabelCurrentColor.ToolTipImage")));
            this.ribbonLabelCurrentColor.ToolTipTitle = "Current color";
            this.ribbonLabelCurrentColor.Click += new System.EventHandler(this.ribbonLabelCurrentColor_Click);
            // 
            // ribbonTextBoxElevation
            // 
            this.ribbonTextBoxElevation.LabelWidth = 90;
            this.ribbonTextBoxElevation.Name = "ribbonTextBoxElevation";
            this.ribbonTextBoxElevation.Text = "Elevation";
            this.ribbonTextBoxElevation.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonTextBoxElevation.TextBoxText = "";
            this.ribbonTextBoxElevation.TextBoxWidth = 50;
            this.ribbonTextBoxElevation.ToolTip = "Sets current entities elevation";
            this.ribbonTextBoxElevation.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonTextBoxElevation.ToolTipImage")));
            this.ribbonTextBoxElevation.ToolTipTitle = "Elevation";
            this.ribbonTextBoxElevation.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonTextBoxElevation_TextBoxKeyPress);
            this.ribbonTextBoxElevation.TextBoxValidated += new System.EventHandler(this.ribbonTextBoxElevation_TextBoxValidated);
            // 
            // ribbonTextBoxThickness
            // 
            this.ribbonTextBoxThickness.LabelWidth = 90;
            this.ribbonTextBoxThickness.Name = "ribbonTextBoxThickness";
            this.ribbonTextBoxThickness.Text = "Thickness";
            this.ribbonTextBoxThickness.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonTextBoxThickness.TextBoxText = "";
            this.ribbonTextBoxThickness.TextBoxWidth = 50;
            this.ribbonTextBoxThickness.ToolTip = "Sets current entities thichness";
            this.ribbonTextBoxThickness.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonTextBoxThickness.ToolTipImage")));
            this.ribbonTextBoxThickness.ToolTipTitle = "Thickness";
            this.ribbonTextBoxThickness.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonTextBoxThickness_TextBoxKeyPress);
            this.ribbonTextBoxThickness.TextBoxValidated += new System.EventHandler(this.ribbonTextBoxThickness_TextBoxValidated);
            // 
            // ribbonTextBoxLtScale
            // 
            this.ribbonTextBoxLtScale.LabelWidth = 90;
            this.ribbonTextBoxLtScale.Name = "ribbonTextBoxLtScale";
            this.ribbonTextBoxLtScale.Text = "Line type scale";
            this.ribbonTextBoxLtScale.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonTextBoxLtScale.TextBoxText = "";
            this.ribbonTextBoxLtScale.TextBoxWidth = 50;
            this.ribbonTextBoxLtScale.ToolTip = "Sets current line type scale";
            this.ribbonTextBoxLtScale.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonTextBoxLtScale.ToolTipImage")));
            this.ribbonTextBoxLtScale.ToolTipTitle = "Line Type Scale";
            this.ribbonTextBoxLtScale.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonTextBoxLtScale_TextBoxKeyPress);
            this.ribbonTextBoxLtScale.TextBoxValidated += new System.EventHandler(this.ribbonTextBoxLtScale_TextBoxValidated);
            // 
            // ribbonButtonPropertiesUnits
            // 
            this.ribbonButtonPropertiesUnits.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesUnits.Image")));
            this.ribbonButtonPropertiesUnits.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesUnits.LargeImage")));
            this.ribbonButtonPropertiesUnits.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPropertiesUnits.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPropertiesUnits.Name = "ribbonButtonPropertiesUnits";
            this.ribbonButtonPropertiesUnits.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesUnits.SmallImage")));
            this.ribbonButtonPropertiesUnits.Text = "Units";
            this.ribbonButtonPropertiesUnits.ToolTip = "Specifies drawing units";
            this.ribbonButtonPropertiesUnits.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesUnits.ToolTipImage")));
            this.ribbonButtonPropertiesUnits.ToolTipTitle = "Drawing Units";
            this.ribbonButtonPropertiesUnits.Click += new System.EventHandler(this.ribbonButtonPropertiesUnits_Click);
            // 
            // ribbonButtonPropertiesLayers
            // 
            this.ribbonButtonPropertiesLayers.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesLayers.Image")));
            this.ribbonButtonPropertiesLayers.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesLayers.LargeImage")));
            this.ribbonButtonPropertiesLayers.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPropertiesLayers.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPropertiesLayers.Name = "ribbonButtonPropertiesLayers";
            this.ribbonButtonPropertiesLayers.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesLayers.SmallImage")));
            this.ribbonButtonPropertiesLayers.Text = "Layers";
            this.ribbonButtonPropertiesLayers.ToolTip = "Open layers dialog";
            this.ribbonButtonPropertiesLayers.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesLayers.ToolTipImage")));
            this.ribbonButtonPropertiesLayers.ToolTipTitle = "Layers";
            this.ribbonButtonPropertiesLayers.Click += new System.EventHandler(this.ribbonButtonPropertiesLayers_Click);
            // 
            // ribbonButtonPropertiesDimStyles
            // 
            this.ribbonButtonPropertiesDimStyles.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesDimStyles.Image")));
            this.ribbonButtonPropertiesDimStyles.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesDimStyles.LargeImage")));
            this.ribbonButtonPropertiesDimStyles.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPropertiesDimStyles.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPropertiesDimStyles.Name = "ribbonButtonPropertiesDimStyles";
            this.ribbonButtonPropertiesDimStyles.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesDimStyles.SmallImage")));
            this.ribbonButtonPropertiesDimStyles.ToolTip = "Opens dimension styles dialog";
            this.ribbonButtonPropertiesDimStyles.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPropertiesDimStyles.ToolTipImage")));
            this.ribbonButtonPropertiesDimStyles.ToolTipTitle = "Dimension Styles";
            this.ribbonButtonPropertiesDimStyles.Click += new System.EventHandler(this.ribbonButtonPropertiesDimStyles_Click);
            // 
            // ribbonPanelObjectSnap
            // 
            this.ribbonPanelObjectSnap.ButtonMoreVisible = false;
            this.ribbonPanelObjectSnap.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelObjectSnap.Image")));
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapEndpoint);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapMidpoint);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapQuadrant);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapPerpendicular);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapTangent);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapInsertion);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapNearest);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapNode);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapCenter);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapGeometricCenter);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapIntersection);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapSelectAll);
            this.ribbonPanelObjectSnap.Items.Add(this.ribbonButtonObjectSnapClear);
            this.ribbonPanelObjectSnap.Name = "ribbonPanelObjectSnap";
            this.ribbonPanelObjectSnap.Text = "Object Snap";
            // 
            // ribbonButtonObjectSnapEndpoint
            // 
            this.ribbonButtonObjectSnapEndpoint.CheckOnClick = true;
            this.ribbonButtonObjectSnapEndpoint.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapEndpoint.Image")));
            this.ribbonButtonObjectSnapEndpoint.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapEndpoint.LargeImage")));
            this.ribbonButtonObjectSnapEndpoint.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapEndpoint.Name = "ribbonButtonObjectSnapEndpoint";
            this.ribbonButtonObjectSnapEndpoint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapEndpoint.SmallImage")));
            this.ribbonButtonObjectSnapEndpoint.Text = "Endpoint";
            this.ribbonButtonObjectSnapEndpoint.ToolTip = "Snaps to the closest endpoint of an object";
            this.ribbonButtonObjectSnapEndpoint.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapEndpoint.ToolTipImage")));
            this.ribbonButtonObjectSnapEndpoint.ToolTipTitle = "Snap, Endpoint";
            this.ribbonButtonObjectSnapEndpoint.Click += new System.EventHandler(this.ribbonButtonObjectSnapEndpoint_Click);
            // 
            // ribbonButtonObjectSnapMidpoint
            // 
            this.ribbonButtonObjectSnapMidpoint.CheckOnClick = true;
            this.ribbonButtonObjectSnapMidpoint.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapMidpoint.Image")));
            this.ribbonButtonObjectSnapMidpoint.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapMidpoint.LargeImage")));
            this.ribbonButtonObjectSnapMidpoint.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapMidpoint.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapMidpoint.Name = "ribbonButtonObjectSnapMidpoint";
            this.ribbonButtonObjectSnapMidpoint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapMidpoint.SmallImage")));
            this.ribbonButtonObjectSnapMidpoint.Text = "Midpoint";
            this.ribbonButtonObjectSnapMidpoint.ToolTip = "Snaps to the midpoint of an object";
            this.ribbonButtonObjectSnapMidpoint.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapMidpoint.ToolTipImage")));
            this.ribbonButtonObjectSnapMidpoint.ToolTipTitle = "Snap, Midpoint";
            this.ribbonButtonObjectSnapMidpoint.Click += new System.EventHandler(this.ribbonButtonObjectSnapMidpoint_Click);
            // 
            // ribbonButtonObjectSnapQuadrant
            // 
            this.ribbonButtonObjectSnapQuadrant.CheckOnClick = true;
            this.ribbonButtonObjectSnapQuadrant.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapQuadrant.Image")));
            this.ribbonButtonObjectSnapQuadrant.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapQuadrant.LargeImage")));
            this.ribbonButtonObjectSnapQuadrant.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapQuadrant.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapQuadrant.Name = "ribbonButtonObjectSnapQuadrant";
            this.ribbonButtonObjectSnapQuadrant.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapQuadrant.SmallImage")));
            this.ribbonButtonObjectSnapQuadrant.Text = "Quadrant";
            this.ribbonButtonObjectSnapQuadrant.ToolTip = "Snaps to a quadrant point of a circle";
            this.ribbonButtonObjectSnapQuadrant.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapQuadrant.ToolTipImage")));
            this.ribbonButtonObjectSnapQuadrant.ToolTipTitle = "Snap, Quadrant";
            this.ribbonButtonObjectSnapQuadrant.Click += new System.EventHandler(this.ribbonButtonObjectSnapQuadrant_Click);
            // 
            // ribbonButtonObjectSnapPerpendicular
            // 
            this.ribbonButtonObjectSnapPerpendicular.CheckOnClick = true;
            this.ribbonButtonObjectSnapPerpendicular.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapPerpendicular.Image")));
            this.ribbonButtonObjectSnapPerpendicular.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapPerpendicular.LargeImage")));
            this.ribbonButtonObjectSnapPerpendicular.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapPerpendicular.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapPerpendicular.Name = "ribbonButtonObjectSnapPerpendicular";
            this.ribbonButtonObjectSnapPerpendicular.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapPerpendicular.SmallImage")));
            this.ribbonButtonObjectSnapPerpendicular.Text = "Perpendicular";
            this.ribbonButtonObjectSnapPerpendicular.ToolTip = "Snaps to a point perpendicular to an object";
            this.ribbonButtonObjectSnapPerpendicular.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapPerpendicular.ToolTipImage")));
            this.ribbonButtonObjectSnapPerpendicular.ToolTipTitle = "Snap, Perpendicular";
            this.ribbonButtonObjectSnapPerpendicular.Click += new System.EventHandler(this.ribbonButtonObjectSnapPerpendicular_Click);
            // 
            // ribbonButtonObjectSnapTangent
            // 
            this.ribbonButtonObjectSnapTangent.CheckOnClick = true;
            this.ribbonButtonObjectSnapTangent.DropDownItems.Add(this.ribbonButton28);
            this.ribbonButtonObjectSnapTangent.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapTangent.Image")));
            this.ribbonButtonObjectSnapTangent.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapTangent.LargeImage")));
            this.ribbonButtonObjectSnapTangent.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapTangent.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapTangent.Name = "ribbonButtonObjectSnapTangent";
            this.ribbonButtonObjectSnapTangent.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapTangent.SmallImage")));
            this.ribbonButtonObjectSnapTangent.Text = "Tangent";
            this.ribbonButtonObjectSnapTangent.ToolTip = "Snaps to the tangent of a circle";
            this.ribbonButtonObjectSnapTangent.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapTangent.ToolTipImage")));
            this.ribbonButtonObjectSnapTangent.ToolTipTitle = "Snap, Tangent";
            this.ribbonButtonObjectSnapTangent.Value = "";
            this.ribbonButtonObjectSnapTangent.Click += new System.EventHandler(this.ribbonButtonObjectSnapTangent_Click);
            // 
            // ribbonButton28
            // 
            this.ribbonButton28.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton28.Image")));
            this.ribbonButton28.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton28.LargeImage")));
            this.ribbonButton28.Name = "ribbonButton28";
            this.ribbonButton28.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton28.SmallImage")));
            this.ribbonButton28.Text = "ribbonButton28";
            // 
            // ribbonButtonObjectSnapInsertion
            // 
            this.ribbonButtonObjectSnapInsertion.CheckOnClick = true;
            this.ribbonButtonObjectSnapInsertion.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapInsertion.Image")));
            this.ribbonButtonObjectSnapInsertion.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapInsertion.LargeImage")));
            this.ribbonButtonObjectSnapInsertion.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapInsertion.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapInsertion.Name = "ribbonButtonObjectSnapInsertion";
            this.ribbonButtonObjectSnapInsertion.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapInsertion.SmallImage")));
            this.ribbonButtonObjectSnapInsertion.Text = "Insertion";
            this.ribbonButtonObjectSnapInsertion.ToolTip = "Snaps to the insertion point of a block";
            this.ribbonButtonObjectSnapInsertion.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapInsertion.ToolTipImage")));
            this.ribbonButtonObjectSnapInsertion.ToolTipTitle = "Snap, Insert";
            this.ribbonButtonObjectSnapInsertion.Click += new System.EventHandler(this.ribbonButtonObjectSnapInsertion_Click);
            // 
            // ribbonButtonObjectSnapNearest
            // 
            this.ribbonButtonObjectSnapNearest.CheckOnClick = true;
            this.ribbonButtonObjectSnapNearest.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNearest.Image")));
            this.ribbonButtonObjectSnapNearest.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNearest.LargeImage")));
            this.ribbonButtonObjectSnapNearest.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapNearest.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapNearest.Name = "ribbonButtonObjectSnapNearest";
            this.ribbonButtonObjectSnapNearest.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNearest.SmallImage")));
            this.ribbonButtonObjectSnapNearest.Text = "Nearest";
            this.ribbonButtonObjectSnapNearest.ToolTip = "Snaps to the nearest point on an object";
            this.ribbonButtonObjectSnapNearest.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNearest.ToolTipImage")));
            this.ribbonButtonObjectSnapNearest.ToolTipTitle = "Snap, Nearest";
            this.ribbonButtonObjectSnapNearest.Click += new System.EventHandler(this.ribbonButtonObjectSnapNearest_Click);
            // 
            // ribbonButtonObjectSnapNode
            // 
            this.ribbonButtonObjectSnapNode.CheckOnClick = true;
            this.ribbonButtonObjectSnapNode.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNode.Image")));
            this.ribbonButtonObjectSnapNode.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNode.LargeImage")));
            this.ribbonButtonObjectSnapNode.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapNode.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapNode.Name = "ribbonButtonObjectSnapNode";
            this.ribbonButtonObjectSnapNode.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNode.SmallImage")));
            this.ribbonButtonObjectSnapNode.Text = "Node";
            this.ribbonButtonObjectSnapNode.ToolTip = "Snaps to a point object";
            this.ribbonButtonObjectSnapNode.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapNode.ToolTipImage")));
            this.ribbonButtonObjectSnapNode.ToolTipTitle = "Snap, Node";
            this.ribbonButtonObjectSnapNode.Click += new System.EventHandler(this.ribbonButtonObjectSnapNode_Click);
            // 
            // ribbonButtonObjectSnapCenter
            // 
            this.ribbonButtonObjectSnapCenter.CheckOnClick = true;
            this.ribbonButtonObjectSnapCenter.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapCenter.Image")));
            this.ribbonButtonObjectSnapCenter.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapCenter.LargeImage")));
            this.ribbonButtonObjectSnapCenter.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapCenter.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapCenter.Name = "ribbonButtonObjectSnapCenter";
            this.ribbonButtonObjectSnapCenter.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapCenter.SmallImage")));
            this.ribbonButtonObjectSnapCenter.Text = "Center";
            this.ribbonButtonObjectSnapCenter.ToolTip = "Snaps to the center of an arc or circle";
            this.ribbonButtonObjectSnapCenter.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapCenter.ToolTipImage")));
            this.ribbonButtonObjectSnapCenter.ToolTipTitle = "Snap, Center";
            this.ribbonButtonObjectSnapCenter.Click += new System.EventHandler(this.ribbonButtonObjectSnapCenter_Click_1);
            // 
            // ribbonButtonObjectSnapGeometricCenter
            // 
            this.ribbonButtonObjectSnapGeometricCenter.CheckOnClick = true;
            this.ribbonButtonObjectSnapGeometricCenter.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapGeometricCenter.Image")));
            this.ribbonButtonObjectSnapGeometricCenter.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapGeometricCenter.LargeImage")));
            this.ribbonButtonObjectSnapGeometricCenter.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapGeometricCenter.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapGeometricCenter.Name = "ribbonButtonObjectSnapGeometricCenter";
            this.ribbonButtonObjectSnapGeometricCenter.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapGeometricCenter.SmallImage")));
            this.ribbonButtonObjectSnapGeometricCenter.ToolTip = "Snaps to the geometric centre point of a polyline, 2d polyline and 2d spline.";
            this.ribbonButtonObjectSnapGeometricCenter.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapGeometricCenter.ToolTipImage")));
            this.ribbonButtonObjectSnapGeometricCenter.ToolTipTitle = "Snap, Geometric center";
            this.ribbonButtonObjectSnapGeometricCenter.Click += new System.EventHandler(this.ribbonButtonObjectSnapGeometricCenter_Click);
            // 
            // ribbonButtonObjectSnapIntersection
            // 
            this.ribbonButtonObjectSnapIntersection.CheckOnClick = true;
            this.ribbonButtonObjectSnapIntersection.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapIntersection.Image")));
            this.ribbonButtonObjectSnapIntersection.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapIntersection.LargeImage")));
            this.ribbonButtonObjectSnapIntersection.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapIntersection.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapIntersection.Name = "ribbonButtonObjectSnapIntersection";
            this.ribbonButtonObjectSnapIntersection.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapIntersection.SmallImage")));
            this.ribbonButtonObjectSnapIntersection.Text = "Intersection";
            this.ribbonButtonObjectSnapIntersection.ToolTip = "Snaps to the intersection of two objecs";
            this.ribbonButtonObjectSnapIntersection.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapIntersection.ToolTipImage")));
            this.ribbonButtonObjectSnapIntersection.ToolTipTitle = "Snap, Intersection";
            this.ribbonButtonObjectSnapIntersection.Click += new System.EventHandler(this.ribbonButtonObjectSnapIntersection_Click_1);
            // 
            // ribbonButtonObjectSnapSelectAll
            // 
            this.ribbonButtonObjectSnapSelectAll.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapSelectAll.Image")));
            this.ribbonButtonObjectSnapSelectAll.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapSelectAll.LargeImage")));
            this.ribbonButtonObjectSnapSelectAll.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapSelectAll.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapSelectAll.Name = "ribbonButtonObjectSnapSelectAll";
            this.ribbonButtonObjectSnapSelectAll.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapSelectAll.SmallImage")));
            this.ribbonButtonObjectSnapSelectAll.Text = "Select all";
            this.ribbonButtonObjectSnapSelectAll.ToolTip = "Select all";
            this.ribbonButtonObjectSnapSelectAll.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapSelectAll.ToolTipImage")));
            this.ribbonButtonObjectSnapSelectAll.ToolTipTitle = "Snap, Select all snap modes";
            this.ribbonButtonObjectSnapSelectAll.Click += new System.EventHandler(this.ribbonButtonObjectSnapSelectAll_Click);
            // 
            // ribbonButtonObjectSnapClear
            // 
            this.ribbonButtonObjectSnapClear.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapClear.Image")));
            this.ribbonButtonObjectSnapClear.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapClear.LargeImage")));
            this.ribbonButtonObjectSnapClear.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapClear.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectSnapClear.Name = "ribbonButtonObjectSnapClear";
            this.ribbonButtonObjectSnapClear.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapClear.SmallImage")));
            this.ribbonButtonObjectSnapClear.Text = "Clear all";
            this.ribbonButtonObjectSnapClear.ToolTip = "Clear all";
            this.ribbonButtonObjectSnapClear.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectSnapClear.ToolTipImage")));
            this.ribbonButtonObjectSnapClear.ToolTipTitle = "Snap, Clear all";
            this.ribbonButtonObjectSnapClear.Click += new System.EventHandler(this.ribbonButtonObjectSnapClear_Click);
            // 
            // ribbonPanelNavigate
            // 
            this.ribbonPanelNavigate.ButtonMoreVisible = false;
            this.ribbonPanelNavigate.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelNavigate.Image")));
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomExtents);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomLimits);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomIn);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomOut);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomWindow);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomPrev);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomNext);
            this.ribbonPanelNavigate.Items.Add(this.ribbonButtonZoomCenter);
            this.ribbonPanelNavigate.Name = "ribbonPanelNavigate";
            this.ribbonPanelNavigate.Text = "Navigate";
            // 
            // ribbonButtonZoomExtents
            // 
            this.ribbonButtonZoomExtents.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExtents.Image")));
            this.ribbonButtonZoomExtents.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExtents.LargeImage")));
            this.ribbonButtonZoomExtents.Name = "ribbonButtonZoomExtents";
            this.ribbonButtonZoomExtents.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExtents.SmallImage")));
            this.ribbonButtonZoomExtents.Text = "Extents";
            this.ribbonButtonZoomExtents.ToolTip = "Zooms to the full drawing extents";
            this.ribbonButtonZoomExtents.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomExtents.ToolTipImage")));
            this.ribbonButtonZoomExtents.ToolTipTitle = "Zoom, Extents";
            this.ribbonButtonZoomExtents.Click += new System.EventHandler(this.ribbonButton6_Click);
            // 
            // ribbonButtonZoomLimits
            // 
            this.ribbonButtonZoomLimits.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomLimits.Image")));
            this.ribbonButtonZoomLimits.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomLimits.LargeImage")));
            this.ribbonButtonZoomLimits.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomLimits.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomLimits.Name = "ribbonButtonZoomLimits";
            this.ribbonButtonZoomLimits.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomLimits.SmallImage")));
            this.ribbonButtonZoomLimits.Text = "Limits";
            this.ribbonButtonZoomLimits.ToolTip = "Zooms a drawing to the full limits.";
            this.ribbonButtonZoomLimits.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomLimits.ToolTipImage")));
            this.ribbonButtonZoomLimits.ToolTipTitle = "Zoom, Limits";
            this.ribbonButtonZoomLimits.Click += new System.EventHandler(this.ribbonButton5_Click);
            // 
            // ribbonButtonZoomIn
            // 
            this.ribbonButtonZoomIn.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomIn.Image")));
            this.ribbonButtonZoomIn.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomIn.LargeImage")));
            this.ribbonButtonZoomIn.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomIn.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomIn.Name = "ribbonButtonZoomIn";
            this.ribbonButtonZoomIn.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomIn.SmallImage")));
            this.ribbonButtonZoomIn.Text = "In";
            this.ribbonButtonZoomIn.ToolTip = "Zooms in a drawing by scale factor specified in the ZoomInOutPercent property fro" +
    "m the center point of the drawing";
            this.ribbonButtonZoomIn.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomIn.ToolTipImage")));
            this.ribbonButtonZoomIn.ToolTipTitle = "Zoom, In";
            this.ribbonButtonZoomIn.Click += new System.EventHandler(this.ribbonButton7_Click);
            // 
            // ribbonButtonZoomOut
            // 
            this.ribbonButtonZoomOut.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomOut.Image")));
            this.ribbonButtonZoomOut.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomOut.LargeImage")));
            this.ribbonButtonZoomOut.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomOut.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomOut.Name = "ribbonButtonZoomOut";
            this.ribbonButtonZoomOut.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomOut.SmallImage")));
            this.ribbonButtonZoomOut.Text = "Out";
            this.ribbonButtonZoomOut.ToolTip = "Zooms out a drawing by scale factor specified in the ZoomInOutPercent property fr" +
    "om the center point of the drawing";
            this.ribbonButtonZoomOut.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomOut.ToolTipImage")));
            this.ribbonButtonZoomOut.ToolTipTitle = "Zoom, Out";
            this.ribbonButtonZoomOut.Click += new System.EventHandler(this.ribbonButton8_Click);
            // 
            // ribbonButtonZoomWindow
            // 
            this.ribbonButtonZoomWindow.DropDownItems.Add(this.ribbonButton10);
            this.ribbonButtonZoomWindow.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomWindow.Image")));
            this.ribbonButtonZoomWindow.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomWindow.LargeImage")));
            this.ribbonButtonZoomWindow.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomWindow.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomWindow.Name = "ribbonButtonZoomWindow";
            this.ribbonButtonZoomWindow.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomWindow.SmallImage")));
            this.ribbonButtonZoomWindow.Text = "Window";
            this.ribbonButtonZoomWindow.ToolTip = "Zooms a drawing to the window specified on screen ";
            this.ribbonButtonZoomWindow.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomWindow.ToolTipImage")));
            this.ribbonButtonZoomWindow.ToolTipTitle = "Zoom, Window";
            this.ribbonButtonZoomWindow.Click += new System.EventHandler(this.ribbonButton9_Click);
            // 
            // ribbonButton10
            // 
            this.ribbonButton10.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.Image")));
            this.ribbonButton10.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.LargeImage")));
            this.ribbonButton10.Name = "ribbonButton10";
            this.ribbonButton10.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.SmallImage")));
            this.ribbonButton10.Text = "ribbonButton10";
            // 
            // ribbonButtonZoomPrev
            // 
            this.ribbonButtonZoomPrev.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomPrev.Image")));
            this.ribbonButtonZoomPrev.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomPrev.LargeImage")));
            this.ribbonButtonZoomPrev.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomPrev.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomPrev.Name = "ribbonButtonZoomPrev";
            this.ribbonButtonZoomPrev.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomPrev.SmallImage")));
            this.ribbonButtonZoomPrev.Text = "Previous";
            this.ribbonButtonZoomPrev.ToolTip = "Zooms to previous view";
            this.ribbonButtonZoomPrev.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomPrev.ToolTipImage")));
            this.ribbonButtonZoomPrev.ToolTipTitle = "Zoom, Previous";
            this.ribbonButtonZoomPrev.Click += new System.EventHandler(this.ribbonButton11_Click);
            // 
            // ribbonButtonZoomNext
            // 
            this.ribbonButtonZoomNext.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomNext.Image")));
            this.ribbonButtonZoomNext.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomNext.LargeImage")));
            this.ribbonButtonZoomNext.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomNext.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomNext.Name = "ribbonButtonZoomNext";
            this.ribbonButtonZoomNext.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomNext.SmallImage")));
            this.ribbonButtonZoomNext.Text = "Next";
            this.ribbonButtonZoomNext.ToolTip = "Zooms to next view";
            this.ribbonButtonZoomNext.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomNext.ToolTipImage")));
            this.ribbonButtonZoomNext.ToolTipTitle = "Zoom, Next";
            this.ribbonButtonZoomNext.Click += new System.EventHandler(this.ribbonButton12_Click);
            // 
            // ribbonButtonZoomCenter
            // 
            this.ribbonButtonZoomCenter.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomCenter.Image")));
            this.ribbonButtonZoomCenter.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomCenter.LargeImage")));
            this.ribbonButtonZoomCenter.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomCenter.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonZoomCenter.Name = "ribbonButtonZoomCenter";
            this.ribbonButtonZoomCenter.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomCenter.SmallImage")));
            this.ribbonButtonZoomCenter.ToolTip = "Zooms to center";
            this.ribbonButtonZoomCenter.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonZoomCenter.ToolTipImage")));
            this.ribbonButtonZoomCenter.ToolTipTitle = "Zoom, center";
            this.ribbonButtonZoomCenter.Click += new System.EventHandler(this.ribbonButtonZoomCenter_Click);
            // 
            // ribbonPanelView
            // 
            this.ribbonPanelView.ButtonMoreVisible = false;
            this.ribbonPanelView.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelView.Image")));
            this.ribbonPanelView.Items.Add(this.ribbonComboBox3D);
            this.ribbonPanelView.Items.Add(this.ribbonComboBoxRendering);
            this.ribbonPanelView.Items.Add(this.ribbonComboBoxViews);
            this.ribbonPanelView.Items.Add(this.ribbonButtonViewRefresh);
            this.ribbonPanelView.Items.Add(this.ribbonButtonOrbit3D);
            this.ribbonPanelView.Items.Add(this.ribbonButtonViewTreeView);
            this.ribbonPanelView.Name = "ribbonPanelView";
            this.ribbonPanelView.Text = "View";
            // 
            // ribbonComboBox3D
            // 
            this.ribbonComboBox3D.AllowTextEdit = false;
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DTop);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DBottom);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DLeft);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DRight);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DFront);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DBack);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DSW);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DSE);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DNE);
            this.ribbonComboBox3D.DropDownItems.Add(this.ribbonButtonView3DNW);
            this.ribbonComboBox3D.Image = ((System.Drawing.Image)(resources.GetObject("ribbonComboBox3D.Image")));
            this.ribbonComboBox3D.Name = "ribbonComboBox3D";
            this.ribbonComboBox3D.Text = "";
            this.ribbonComboBox3D.TextBoxText = "";
            this.ribbonComboBox3D.ToolTip = "Provides a choice of standard views";
            this.ribbonComboBox3D.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBox3D.ToolTipImage")));
            this.ribbonComboBox3D.ToolTipTitle = "3D Navigation";
            this.ribbonComboBox3D.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBox3D_DropDownItemClicked);
            // 
            // ribbonButtonView3DTop
            // 
            this.ribbonButtonView3DTop.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DTop.Image")));
            this.ribbonButtonView3DTop.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DTop.LargeImage")));
            this.ribbonButtonView3DTop.Name = "ribbonButtonView3DTop";
            this.ribbonButtonView3DTop.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DTop.SmallImage")));
            this.ribbonButtonView3DTop.Text = "Top";
            // 
            // ribbonButtonView3DBottom
            // 
            this.ribbonButtonView3DBottom.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DBottom.Image")));
            this.ribbonButtonView3DBottom.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DBottom.LargeImage")));
            this.ribbonButtonView3DBottom.Name = "ribbonButtonView3DBottom";
            this.ribbonButtonView3DBottom.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DBottom.SmallImage")));
            this.ribbonButtonView3DBottom.Text = "Bottom";
            // 
            // ribbonButtonView3DLeft
            // 
            this.ribbonButtonView3DLeft.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DLeft.Image")));
            this.ribbonButtonView3DLeft.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DLeft.LargeImage")));
            this.ribbonButtonView3DLeft.Name = "ribbonButtonView3DLeft";
            this.ribbonButtonView3DLeft.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DLeft.SmallImage")));
            this.ribbonButtonView3DLeft.Text = "Left";
            // 
            // ribbonButtonView3DRight
            // 
            this.ribbonButtonView3DRight.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DRight.Image")));
            this.ribbonButtonView3DRight.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DRight.LargeImage")));
            this.ribbonButtonView3DRight.Name = "ribbonButtonView3DRight";
            this.ribbonButtonView3DRight.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DRight.SmallImage")));
            this.ribbonButtonView3DRight.Text = "Right";
            // 
            // ribbonButtonView3DFront
            // 
            this.ribbonButtonView3DFront.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DFront.Image")));
            this.ribbonButtonView3DFront.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DFront.LargeImage")));
            this.ribbonButtonView3DFront.Name = "ribbonButtonView3DFront";
            this.ribbonButtonView3DFront.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DFront.SmallImage")));
            this.ribbonButtonView3DFront.Text = "Front";
            // 
            // ribbonButtonView3DBack
            // 
            this.ribbonButtonView3DBack.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DBack.Image")));
            this.ribbonButtonView3DBack.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DBack.LargeImage")));
            this.ribbonButtonView3DBack.Name = "ribbonButtonView3DBack";
            this.ribbonButtonView3DBack.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DBack.SmallImage")));
            this.ribbonButtonView3DBack.Text = "Back";
            // 
            // ribbonButtonView3DSW
            // 
            this.ribbonButtonView3DSW.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DSW.Image")));
            this.ribbonButtonView3DSW.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DSW.LargeImage")));
            this.ribbonButtonView3DSW.Name = "ribbonButtonView3DSW";
            this.ribbonButtonView3DSW.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DSW.SmallImage")));
            this.ribbonButtonView3DSW.Text = "SW Isometric";
            // 
            // ribbonButtonView3DSE
            // 
            this.ribbonButtonView3DSE.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DSE.Image")));
            this.ribbonButtonView3DSE.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DSE.LargeImage")));
            this.ribbonButtonView3DSE.Name = "ribbonButtonView3DSE";
            this.ribbonButtonView3DSE.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DSE.SmallImage")));
            this.ribbonButtonView3DSE.Text = "SE Isometric";
            // 
            // ribbonButtonView3DNE
            // 
            this.ribbonButtonView3DNE.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DNE.Image")));
            this.ribbonButtonView3DNE.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DNE.LargeImage")));
            this.ribbonButtonView3DNE.Name = "ribbonButtonView3DNE";
            this.ribbonButtonView3DNE.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DNE.SmallImage")));
            this.ribbonButtonView3DNE.Text = "NE Isometric";
            // 
            // ribbonButtonView3DNW
            // 
            this.ribbonButtonView3DNW.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DNW.Image")));
            this.ribbonButtonView3DNW.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DNW.LargeImage")));
            this.ribbonButtonView3DNW.Name = "ribbonButtonView3DNW";
            this.ribbonButtonView3DNW.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonView3DNW.SmallImage")));
            this.ribbonButtonView3DNW.Text = "NW Isometric";
            // 
            // ribbonComboBoxRendering
            // 
            this.ribbonComboBoxRendering.AllowTextEdit = false;
            this.ribbonComboBoxRendering.DropDownItems.Add(this.ribbonButtonRenderingWireframe);
            this.ribbonComboBoxRendering.DropDownItems.Add(this.ribbonButtonRenderingShaded);
            this.ribbonComboBoxRendering.DropDownItems.Add(this.ribbonButtonRenderingShadedEdges);
            this.ribbonComboBoxRendering.Image = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxRendering.Image")));
            this.ribbonComboBoxRendering.Name = "ribbonComboBoxRendering";
            this.ribbonComboBoxRendering.Text = "";
            this.ribbonComboBoxRendering.TextBoxText = "";
            this.ribbonComboBoxRendering.ToolTip = "Selects rendering mode";
            this.ribbonComboBoxRendering.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxRendering.ToolTipImage")));
            this.ribbonComboBoxRendering.ToolTipTitle = "Rendering";
            this.ribbonComboBoxRendering.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxRendering_DropDownItemClicked);
            // 
            // ribbonButtonRenderingWireframe
            // 
            this.ribbonButtonRenderingWireframe.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingWireframe.Image")));
            this.ribbonButtonRenderingWireframe.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingWireframe.LargeImage")));
            this.ribbonButtonRenderingWireframe.Name = "ribbonButtonRenderingWireframe";
            this.ribbonButtonRenderingWireframe.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingWireframe.SmallImage")));
            this.ribbonButtonRenderingWireframe.Text = "Wireframe";
            // 
            // ribbonButtonRenderingShaded
            // 
            this.ribbonButtonRenderingShaded.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingShaded.Image")));
            this.ribbonButtonRenderingShaded.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingShaded.LargeImage")));
            this.ribbonButtonRenderingShaded.Name = "ribbonButtonRenderingShaded";
            this.ribbonButtonRenderingShaded.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingShaded.SmallImage")));
            this.ribbonButtonRenderingShaded.Text = "Shaded";
            // 
            // ribbonButtonRenderingShadedEdges
            // 
            this.ribbonButtonRenderingShadedEdges.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingShadedEdges.Image")));
            this.ribbonButtonRenderingShadedEdges.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingShadedEdges.LargeImage")));
            this.ribbonButtonRenderingShadedEdges.Name = "ribbonButtonRenderingShadedEdges";
            this.ribbonButtonRenderingShadedEdges.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRenderingShadedEdges.SmallImage")));
            this.ribbonButtonRenderingShadedEdges.Text = "Shaded edges";
            // 
            // ribbonComboBoxViews
            // 
            this.ribbonComboBoxViews.AllowTextEdit = false;
            this.ribbonComboBoxViews.DrawIconsBar = false;
            this.ribbonComboBoxViews.Image = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxViews.Image")));
            this.ribbonComboBoxViews.Name = "ribbonComboBoxViews";
            this.ribbonComboBoxViews.Text = "";
            this.ribbonComboBoxViews.TextBoxText = "";
            this.ribbonComboBoxViews.ToolTip = "Selects current view";
            this.ribbonComboBoxViews.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxViews.ToolTipImage")));
            this.ribbonComboBoxViews.ToolTipTitle = "Named views";
            this.ribbonComboBoxViews.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonComboBoxViews_DropDownItemClicked);
            // 
            // ribbonButtonViewRefresh
            // 
            this.ribbonButtonViewRefresh.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewRefresh.Image")));
            this.ribbonButtonViewRefresh.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewRefresh.LargeImage")));
            this.ribbonButtonViewRefresh.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonViewRefresh.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonViewRefresh.Name = "ribbonButtonViewRefresh";
            this.ribbonButtonViewRefresh.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewRefresh.SmallImage")));
            this.ribbonButtonViewRefresh.Text = "Refresh";
            this.ribbonButtonViewRefresh.ToolTip = "Regenerates drawing";
            this.ribbonButtonViewRefresh.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewRefresh.ToolTipImage")));
            this.ribbonButtonViewRefresh.ToolTipTitle = "Refresh";
            this.ribbonButtonViewRefresh.Click += new System.EventHandler(this.ribbonButtonViewRefresh_Click);
            // 
            // ribbonButtonOrbit3D
            // 
            this.ribbonButtonOrbit3D.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOrbit3D.Image")));
            this.ribbonButtonOrbit3D.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOrbit3D.LargeImage")));
            this.ribbonButtonOrbit3D.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonOrbit3D.Name = "ribbonButtonOrbit3D";
            this.ribbonButtonOrbit3D.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOrbit3D.SmallImage")));
            this.ribbonButtonOrbit3D.Text = "3D Orbit";
            this.ribbonButtonOrbit3D.ToolTip = "Rotates the view in 3D space";
            this.ribbonButtonOrbit3D.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonOrbit3D.ToolTipImage")));
            this.ribbonButtonOrbit3D.Click += new System.EventHandler(this.ribbonButtonOrbit3D_Click);
            // 
            // ribbonButtonViewTreeView
            // 
            this.ribbonButtonViewTreeView.CheckOnClick = true;
            this.ribbonButtonViewTreeView.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewTreeView.Image")));
            this.ribbonButtonViewTreeView.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewTreeView.LargeImage")));
            this.ribbonButtonViewTreeView.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonViewTreeView.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonViewTreeView.Name = "ribbonButtonViewTreeView";
            this.ribbonButtonViewTreeView.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewTreeView.SmallImage")));
            this.ribbonButtonViewTreeView.Tag = "Tree View";
            this.ribbonButtonViewTreeView.ToolTip = "Displays a tree view of file structure";
            this.ribbonButtonViewTreeView.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonViewTreeView.ToolTipImage")));
            this.ribbonButtonViewTreeView.ToolTipTitle = "Tree View";
            this.ribbonButtonViewTreeView.Click += new System.EventHandler(this.ribbonButtonViewTreeView_Click);
            // 
            // ribbonPanelInquiryMeasure
            // 
            this.ribbonPanelInquiryMeasure.ButtonMoreVisible = false;
            this.ribbonPanelInquiryMeasure.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelInquiryMeasure.Image")));
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonInquiryMeasure);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonDrawingInfo);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonInquiryEntityInfo);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonShowSelectedEntitiesInfo);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonObjectByHandle);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonInquiryXdata);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonInquiryTest);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButton1SaveTest);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonPointInPolygon);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonShowFilledAreas);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonPrintEntityProp);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonPrintEntitiesList);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonShowData);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonTruTOPS);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonSplitSections);
            this.ribbonPanelInquiryMeasure.Items.Add(this.ribbonButtonRecoverDXFFIle);
            this.ribbonPanelInquiryMeasure.Name = "ribbonPanelInquiryMeasure";
            this.ribbonPanelInquiryMeasure.Text = "Inquiry";
            this.ribbonPanelInquiryMeasure.ButtonMoreClick += new System.EventHandler(this.ribbonPanelInquiry_ButtonMoreClick);
            // 
            // ribbonButtonInquiryMeasure
            // 
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasureDistance);
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasureArea);
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasurePoly);
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasureRadius);
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasurecenter);
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasureAreaSelected);
            this.ribbonButtonInquiryMeasure.DropDownItems.Add(this.ribbonButtonInquiryMeasureFilledEmpty);
            this.ribbonButtonInquiryMeasure.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasure.Image")));
            this.ribbonButtonInquiryMeasure.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasure.LargeImage")));
            this.ribbonButtonInquiryMeasure.Name = "ribbonButtonInquiryMeasure";
            this.ribbonButtonInquiryMeasure.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasure.SmallImage")));
            this.ribbonButtonInquiryMeasure.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonInquiryMeasure.Text = "Measure";
            this.ribbonButtonInquiryMeasure.ToolTip = "Measures the distance between two points";
            this.ribbonButtonInquiryMeasure.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasure.ToolTipImage")));
            this.ribbonButtonInquiryMeasure.ToolTipTitle = "Distance";
            this.ribbonButtonInquiryMeasure.Click += new System.EventHandler(this.ribbonButtonInquiryMeasure_Click);
            // 
            // ribbonButtonInquiryMeasureDistance
            // 
            this.ribbonButtonInquiryMeasureDistance.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasureDistance.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureDistance.Image")));
            this.ribbonButtonInquiryMeasureDistance.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureDistance.LargeImage")));
            this.ribbonButtonInquiryMeasureDistance.Name = "ribbonButtonInquiryMeasureDistance";
            this.ribbonButtonInquiryMeasureDistance.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureDistance.SmallImage")));
            this.ribbonButtonInquiryMeasureDistance.Text = "Distance";
            this.ribbonButtonInquiryMeasureDistance.ToolTip = "Measures the distance between two points";
            this.ribbonButtonInquiryMeasureDistance.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureDistance.ToolTipImage")));
            this.ribbonButtonInquiryMeasureDistance.ToolTipTitle = "Distance";
            this.ribbonButtonInquiryMeasureDistance.Click += new System.EventHandler(this.ribbonButtonInquiryMeasureDistance_Click);
            // 
            // ribbonButtonInquiryMeasureArea
            // 
            this.ribbonButtonInquiryMeasureArea.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasureArea.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureArea.Image")));
            this.ribbonButtonInquiryMeasureArea.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureArea.LargeImage")));
            this.ribbonButtonInquiryMeasureArea.Name = "ribbonButtonInquiryMeasureArea";
            this.ribbonButtonInquiryMeasureArea.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureArea.SmallImage")));
            this.ribbonButtonInquiryMeasureArea.Text = "Area";
            this.ribbonButtonInquiryMeasureArea.ToolTip = "Measures the area";
            this.ribbonButtonInquiryMeasureArea.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureArea.ToolTipImage")));
            this.ribbonButtonInquiryMeasureArea.ToolTipTitle = "Area";
            this.ribbonButtonInquiryMeasureArea.Click += new System.EventHandler(this.ribbonButtonInquiryMeasureArea_Click);
            // 
            // ribbonButtonInquiryMeasurePoly
            // 
            this.ribbonButtonInquiryMeasurePoly.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasurePoly.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurePoly.Image")));
            this.ribbonButtonInquiryMeasurePoly.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurePoly.LargeImage")));
            this.ribbonButtonInquiryMeasurePoly.Name = "ribbonButtonInquiryMeasurePoly";
            this.ribbonButtonInquiryMeasurePoly.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurePoly.SmallImage")));
            this.ribbonButtonInquiryMeasurePoly.Text = "Polyline length";
            this.ribbonButtonInquiryMeasurePoly.ToolTip = "Measures the polyline lenght";
            this.ribbonButtonInquiryMeasurePoly.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurePoly.ToolTipImage")));
            this.ribbonButtonInquiryMeasurePoly.ToolTipTitle = "Polyline lenght";
            this.ribbonButtonInquiryMeasurePoly.Click += new System.EventHandler(this.ribbonButtonInquiryMeasurePoly_Click);
            // 
            // ribbonButtonInquiryMeasureRadius
            // 
            this.ribbonButtonInquiryMeasureRadius.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasureRadius.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureRadius.Image")));
            this.ribbonButtonInquiryMeasureRadius.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureRadius.LargeImage")));
            this.ribbonButtonInquiryMeasureRadius.Name = "ribbonButtonInquiryMeasureRadius";
            this.ribbonButtonInquiryMeasureRadius.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureRadius.SmallImage")));
            this.ribbonButtonInquiryMeasureRadius.Text = "Radius";
            this.ribbonButtonInquiryMeasureRadius.ToolTip = "Measures the radius of a circle or arc";
            this.ribbonButtonInquiryMeasureRadius.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureRadius.ToolTipImage")));
            this.ribbonButtonInquiryMeasureRadius.ToolTipTitle = "Radius";
            this.ribbonButtonInquiryMeasureRadius.Click += new System.EventHandler(this.ribbonButtonInquiryMeasureRadius_Click);
            // 
            // ribbonButtonInquiryMeasurecenter
            // 
            this.ribbonButtonInquiryMeasurecenter.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasurecenter.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurecenter.Image")));
            this.ribbonButtonInquiryMeasurecenter.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurecenter.LargeImage")));
            this.ribbonButtonInquiryMeasurecenter.Name = "ribbonButtonInquiryMeasurecenter";
            this.ribbonButtonInquiryMeasurecenter.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurecenter.SmallImage")));
            this.ribbonButtonInquiryMeasurecenter.Text = "Locate point";
            this.ribbonButtonInquiryMeasurecenter.ToolTip = "Dispalys the coordinate values of e location";
            this.ribbonButtonInquiryMeasurecenter.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasurecenter.ToolTipImage")));
            this.ribbonButtonInquiryMeasurecenter.ToolTipTitle = "Locate point";
            this.ribbonButtonInquiryMeasurecenter.Click += new System.EventHandler(this.ribbonButtonInquiryMeasurecenter_Click);
            // 
            // ribbonButtonInquiryMeasureAreaSelected
            // 
            this.ribbonButtonInquiryMeasureAreaSelected.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasureAreaSelected.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureAreaSelected.Image")));
            this.ribbonButtonInquiryMeasureAreaSelected.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureAreaSelected.LargeImage")));
            this.ribbonButtonInquiryMeasureAreaSelected.Name = "ribbonButtonInquiryMeasureAreaSelected";
            this.ribbonButtonInquiryMeasureAreaSelected.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureAreaSelected.SmallImage")));
            this.ribbonButtonInquiryMeasureAreaSelected.Text = "Area of selected objects";
            this.ribbonButtonInquiryMeasureAreaSelected.Click += new System.EventHandler(this.ribbonButtonInquiryMeasureAreaSelected_Click);
            // 
            // ribbonButtonInquiryMeasureFilledEmpty
            // 
            this.ribbonButtonInquiryMeasureFilledEmpty.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonInquiryMeasureFilledEmpty.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureFilledEmpty.Image")));
            this.ribbonButtonInquiryMeasureFilledEmpty.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureFilledEmpty.LargeImage")));
            this.ribbonButtonInquiryMeasureFilledEmpty.Name = "ribbonButtonInquiryMeasureFilledEmpty";
            this.ribbonButtonInquiryMeasureFilledEmpty.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryMeasureFilledEmpty.SmallImage")));
            this.ribbonButtonInquiryMeasureFilledEmpty.Text = "Filled and empty areas";
            this.ribbonButtonInquiryMeasureFilledEmpty.Click += new System.EventHandler(this.ribbonButtonInquiryMeasureFilledEmpty_Click);
            // 
            // ribbonDrawingInfo
            // 
            this.ribbonDrawingInfo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDrawingInfo.Image")));
            this.ribbonDrawingInfo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDrawingInfo.LargeImage")));
            this.ribbonDrawingInfo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonDrawingInfo.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonDrawingInfo.Name = "ribbonDrawingInfo";
            this.ribbonDrawingInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDrawingInfo.SmallImage")));
            this.ribbonDrawingInfo.Text = "Drawing info";
            this.ribbonDrawingInfo.ToolTip = "Shows drawing information";
            this.ribbonDrawingInfo.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonDrawingInfo.ToolTipImage")));
            this.ribbonDrawingInfo.ToolTipTitle = "Drawing info";
            this.ribbonDrawingInfo.Click += new System.EventHandler(this.ribbonDrawingInfo_Click);
            // 
            // ribbonButtonInquiryEntityInfo
            // 
            this.ribbonButtonInquiryEntityInfo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryEntityInfo.Image")));
            this.ribbonButtonInquiryEntityInfo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryEntityInfo.LargeImage")));
            this.ribbonButtonInquiryEntityInfo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonInquiryEntityInfo.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonInquiryEntityInfo.Name = "ribbonButtonInquiryEntityInfo";
            this.ribbonButtonInquiryEntityInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryEntityInfo.SmallImage")));
            this.ribbonButtonInquiryEntityInfo.Text = "Entity Properties";
            this.ribbonButtonInquiryEntityInfo.ToolTip = "Shows entity properties selecting it with a mouse click";
            this.ribbonButtonInquiryEntityInfo.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryEntityInfo.ToolTipImage")));
            this.ribbonButtonInquiryEntityInfo.ToolTipTitle = "Entity Properties";
            this.ribbonButtonInquiryEntityInfo.Click += new System.EventHandler(this.ribbonButtonInquiryEntityInfo_Click);
            // 
            // ribbonButtonShowSelectedEntitiesInfo
            // 
            this.ribbonButtonShowSelectedEntitiesInfo.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowSelectedEntitiesInfo.Image")));
            this.ribbonButtonShowSelectedEntitiesInfo.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowSelectedEntitiesInfo.LargeImage")));
            this.ribbonButtonShowSelectedEntitiesInfo.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowSelectedEntitiesInfo.Name = "ribbonButtonShowSelectedEntitiesInfo";
            this.ribbonButtonShowSelectedEntitiesInfo.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowSelectedEntitiesInfo.SmallImage")));
            this.ribbonButtonShowSelectedEntitiesInfo.ToolTip = "Shows selected entities properties";
            this.ribbonButtonShowSelectedEntitiesInfo.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowSelectedEntitiesInfo.ToolTipImage")));
            this.ribbonButtonShowSelectedEntitiesInfo.ToolTipTitle = "Selected entities Properties";
            this.ribbonButtonShowSelectedEntitiesInfo.Click += new System.EventHandler(this.ribbonButtonShowSelectedEntitiesInfo_Click);
            // 
            // ribbonButtonObjectByHandle
            // 
            this.ribbonButtonObjectByHandle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectByHandle.Image")));
            this.ribbonButtonObjectByHandle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectByHandle.LargeImage")));
            this.ribbonButtonObjectByHandle.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectByHandle.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonObjectByHandle.Name = "ribbonButtonObjectByHandle";
            this.ribbonButtonObjectByHandle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectByHandle.SmallImage")));
            this.ribbonButtonObjectByHandle.ToolTip = "Shows object properties selecting it by handle";
            this.ribbonButtonObjectByHandle.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonObjectByHandle.ToolTipImage")));
            this.ribbonButtonObjectByHandle.ToolTipTitle = "Object properties by handle";
            this.ribbonButtonObjectByHandle.Click += new System.EventHandler(this.ribbonButtonObjectByHandle_Click);
            // 
            // ribbonButtonInquiryXdata
            // 
            this.ribbonButtonInquiryXdata.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryXdata.Image")));
            this.ribbonButtonInquiryXdata.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryXdata.LargeImage")));
            this.ribbonButtonInquiryXdata.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonInquiryXdata.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonInquiryXdata.Name = "ribbonButtonInquiryXdata";
            this.ribbonButtonInquiryXdata.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryXdata.SmallImage")));
            this.ribbonButtonInquiryXdata.ToolTip = "Lists the extended data (xdata) attacched to an entity";
            this.ribbonButtonInquiryXdata.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryXdata.ToolTipImage")));
            this.ribbonButtonInquiryXdata.ToolTipTitle = "List Xdata";
            this.ribbonButtonInquiryXdata.Click += new System.EventHandler(this.ribbonButtonInquiryXdata_Click);
            // 
            // ribbonButtonInquiryTest
            // 
            this.ribbonButtonInquiryTest.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryTest.Image")));
            this.ribbonButtonInquiryTest.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryTest.LargeImage")));
            this.ribbonButtonInquiryTest.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonInquiryTest.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonInquiryTest.Name = "ribbonButtonInquiryTest";
            this.ribbonButtonInquiryTest.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryTest.SmallImage")));
            this.ribbonButtonInquiryTest.Text = "Test";
            this.ribbonButtonInquiryTest.ToolTip = "Test procedure";
            this.ribbonButtonInquiryTest.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonInquiryTest.ToolTipImage")));
            this.ribbonButtonInquiryTest.ToolTipTitle = "Test procedure";
            this.ribbonButtonInquiryTest.Click += new System.EventHandler(this.ribbonButtonInquiryTest_Click);
            // 
            // ribbonButton1SaveTest
            // 
            this.ribbonButton1SaveTest.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton1SaveTest.Image")));
            this.ribbonButton1SaveTest.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1SaveTest.LargeImage")));
            this.ribbonButton1SaveTest.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1SaveTest.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton1SaveTest.Name = "ribbonButton1SaveTest";
            this.ribbonButton1SaveTest.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton1SaveTest.SmallImage")));
            this.ribbonButton1SaveTest.Text = "SaveTest";
            this.ribbonButton1SaveTest.Click += new System.EventHandler(this.ribbonButton1SaveTest_Click);
            // 
            // ribbonButtonPointInPolygon
            // 
            this.ribbonButtonPointInPolygon.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPointInPolygon.Image")));
            this.ribbonButtonPointInPolygon.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPointInPolygon.LargeImage")));
            this.ribbonButtonPointInPolygon.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPointInPolygon.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPointInPolygon.Name = "ribbonButtonPointInPolygon";
            this.ribbonButtonPointInPolygon.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPointInPolygon.SmallImage")));
            this.ribbonButtonPointInPolygon.ToolTip = "Check if a point is inside a polygon defined by selected lines, arcs or polylines" +
    "";
            this.ribbonButtonPointInPolygon.ToolTipTitle = "Pont in Polygon";
            this.ribbonButtonPointInPolygon.Click += new System.EventHandler(this.ribbonButtonPointInPolygon_Click);
            // 
            // ribbonButtonShowFilledAreas
            // 
            this.ribbonButtonShowFilledAreas.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowFilledAreas.Image")));
            this.ribbonButtonShowFilledAreas.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowFilledAreas.LargeImage")));
            this.ribbonButtonShowFilledAreas.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowFilledAreas.Name = "ribbonButtonShowFilledAreas";
            this.ribbonButtonShowFilledAreas.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowFilledAreas.SmallImage")));
            this.ribbonButtonShowFilledAreas.ToolTip = "Show filled areas";
            this.ribbonButtonShowFilledAreas.Click += new System.EventHandler(this.ribbonButtonShowFilledAreas_Click);
            // 
            // ribbonButtonPrintEntityProp
            // 
            this.ribbonButtonPrintEntityProp.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrintEntityProp.Image")));
            this.ribbonButtonPrintEntityProp.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrintEntityProp.LargeImage")));
            this.ribbonButtonPrintEntityProp.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPrintEntityProp.Name = "ribbonButtonPrintEntityProp";
            this.ribbonButtonPrintEntityProp.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrintEntityProp.SmallImage")));
            this.ribbonButtonPrintEntityProp.ToolTip = "Print single entity properties";
            this.ribbonButtonPrintEntityProp.Click += new System.EventHandler(this.ribbonButtonPrintEntityProp_Click);
            // 
            // ribbonButtonPrintEntitiesList
            // 
            this.ribbonButtonPrintEntitiesList.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrintEntitiesList.Image")));
            this.ribbonButtonPrintEntitiesList.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrintEntitiesList.LargeImage")));
            this.ribbonButtonPrintEntitiesList.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonPrintEntitiesList.Name = "ribbonButtonPrintEntitiesList";
            this.ribbonButtonPrintEntitiesList.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPrintEntitiesList.SmallImage")));
            this.ribbonButtonPrintEntitiesList.ToolTip = "Print enitites list";
            this.ribbonButtonPrintEntitiesList.Click += new System.EventHandler(this.ribbonButtonPrintEntitiesList_Click);
            // 
            // ribbonButtonShowData
            // 
            this.ribbonButtonShowData.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowData.Image")));
            this.ribbonButtonShowData.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowData.LargeImage")));
            this.ribbonButtonShowData.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowData.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowData.Name = "ribbonButtonShowData";
            this.ribbonButtonShowData.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowData.SmallImage")));
            this.ribbonButtonShowData.ToolTip = "Shows entities data on drawing";
            this.ribbonButtonShowData.ToolTipTitle = "Show entities data";
            this.ribbonButtonShowData.Click += new System.EventHandler(this.ribbonButtonShowData_Click);
            // 
            // ribbonButtonTruTOPS
            // 
            this.ribbonButtonTruTOPS.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTruTOPS.Image")));
            this.ribbonButtonTruTOPS.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTruTOPS.LargeImage")));
            this.ribbonButtonTruTOPS.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonTruTOPS.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonTruTOPS.Name = "ribbonButtonTruTOPS";
            this.ribbonButtonTruTOPS.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTruTOPS.SmallImage")));
            this.ribbonButtonTruTOPS.ToolTip = "Process TruTops Drawings";
            this.ribbonButtonTruTOPS.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonTruTOPS.ToolTipImage")));
            this.ribbonButtonTruTOPS.ToolTipTitle = "Process TruTops Drawings";
            this.ribbonButtonTruTOPS.Click += new System.EventHandler(this.ribbonButtonTruTOPS_Click);
            // 
            // ribbonButtonSplitSections
            // 
            this.ribbonButtonSplitSections.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSplitSections.Image")));
            this.ribbonButtonSplitSections.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSplitSections.LargeImage")));
            this.ribbonButtonSplitSections.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonSplitSections.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonSplitSections.Name = "ribbonButtonSplitSections";
            this.ribbonButtonSplitSections.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonSplitSections.SmallImage")));
            this.ribbonButtonSplitSections.ToolTip = "Splits current drawing into SECTIONS txt files";
            this.ribbonButtonSplitSections.ToolTipTitle = "Split sections";
            this.ribbonButtonSplitSections.Click += new System.EventHandler(this.ribbonButtonSplitSections_Click);
            // 
            // ribbonButtonRecoverDXFFIle
            // 
            this.ribbonButtonRecoverDXFFIle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRecoverDXFFIle.Image")));
            this.ribbonButtonRecoverDXFFIle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRecoverDXFFIle.LargeImage")));
            this.ribbonButtonRecoverDXFFIle.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonRecoverDXFFIle.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonRecoverDXFFIle.Name = "ribbonButtonRecoverDXFFIle";
            this.ribbonButtonRecoverDXFFIle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRecoverDXFFIle.SmallImage")));
            this.ribbonButtonRecoverDXFFIle.ToolTip = "Try to recover a DXF file";
            this.ribbonButtonRecoverDXFFIle.ToolTipTitle = "Recover DXF file";
            this.ribbonButtonRecoverDXFFIle.Click += new System.EventHandler(this.ribbonButtonRecoverDXFFIle_Click);
            // 
            // ribbonPanelDrawMethods
            // 
            this.ribbonPanelDrawMethods.ButtonMoreVisible = false;
            this.ribbonPanelDrawMethods.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelDrawMethods.Image")));
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsLine);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsCircle);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodstext);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsPoint);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsArc);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsImage);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsPolygon);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonColorChooserDrawMethodsColor);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsPenWidth);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsFill);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsStore);
            this.ribbonPanelDrawMethods.Items.Add(this.ribbonButtonDrawMethodsClear);
            this.ribbonPanelDrawMethods.Name = "ribbonPanelDrawMethods";
            this.ribbonPanelDrawMethods.Text = "Draw Methods";
            // 
            // ribbonButtonDrawMethodsLine
            // 
            this.ribbonButtonDrawMethodsLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsLine.Image")));
            this.ribbonButtonDrawMethodsLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsLine.LargeImage")));
            this.ribbonButtonDrawMethodsLine.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsLine.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsLine.Name = "ribbonButtonDrawMethodsLine";
            this.ribbonButtonDrawMethodsLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsLine.SmallImage")));
            this.ribbonButtonDrawMethodsLine.Text = "Line";
            this.ribbonButtonDrawMethodsLine.ToolTip = "Draws a line without modifying the drawing database";
            this.ribbonButtonDrawMethodsLine.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsLine.ToolTipImage")));
            this.ribbonButtonDrawMethodsLine.ToolTipTitle = "Draw, Line";
            this.ribbonButtonDrawMethodsLine.Click += new System.EventHandler(this.ribbonButtonDrawMethodsLine_Click);
            // 
            // ribbonButtonDrawMethodsCircle
            // 
            this.ribbonButtonDrawMethodsCircle.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsCircle.Image")));
            this.ribbonButtonDrawMethodsCircle.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsCircle.LargeImage")));
            this.ribbonButtonDrawMethodsCircle.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsCircle.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsCircle.Name = "ribbonButtonDrawMethodsCircle";
            this.ribbonButtonDrawMethodsCircle.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsCircle.SmallImage")));
            this.ribbonButtonDrawMethodsCircle.Text = "ribbonButton5";
            this.ribbonButtonDrawMethodsCircle.ToolTip = "Draws a circle without modifying the drawing database";
            this.ribbonButtonDrawMethodsCircle.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsCircle.ToolTipImage")));
            this.ribbonButtonDrawMethodsCircle.ToolTipTitle = "Draw, Circle";
            this.ribbonButtonDrawMethodsCircle.Click += new System.EventHandler(this.ribbonButtonDrawMethodsCircle_Click);
            // 
            // ribbonButtonDrawMethodstext
            // 
            this.ribbonButtonDrawMethodstext.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodstext.Image")));
            this.ribbonButtonDrawMethodstext.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodstext.LargeImage")));
            this.ribbonButtonDrawMethodstext.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodstext.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodstext.Name = "ribbonButtonDrawMethodstext";
            this.ribbonButtonDrawMethodstext.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodstext.SmallImage")));
            this.ribbonButtonDrawMethodstext.Text = "";
            this.ribbonButtonDrawMethodstext.ToolTip = "Draws a text without modifying the drawing database";
            this.ribbonButtonDrawMethodstext.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodstext.ToolTipImage")));
            this.ribbonButtonDrawMethodstext.ToolTipTitle = "Draw, Text";
            this.ribbonButtonDrawMethodstext.Click += new System.EventHandler(this.ribbonButtonDrawMethodstext_Click);
            // 
            // ribbonButtonDrawMethodsPoint
            // 
            this.ribbonButtonDrawMethodsPoint.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPoint.Image")));
            this.ribbonButtonDrawMethodsPoint.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPoint.LargeImage")));
            this.ribbonButtonDrawMethodsPoint.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsPoint.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsPoint.Name = "ribbonButtonDrawMethodsPoint";
            this.ribbonButtonDrawMethodsPoint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPoint.SmallImage")));
            this.ribbonButtonDrawMethodsPoint.Text = "Point";
            this.ribbonButtonDrawMethodsPoint.ToolTip = "Draws a point without modifying the drawing database";
            this.ribbonButtonDrawMethodsPoint.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPoint.ToolTipImage")));
            this.ribbonButtonDrawMethodsPoint.ToolTipTitle = "Draw, Point";
            this.ribbonButtonDrawMethodsPoint.Click += new System.EventHandler(this.ribbonButtonDrawMethodsPoint_Click);
            // 
            // ribbonButtonDrawMethodsArc
            // 
            this.ribbonButtonDrawMethodsArc.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsArc.Image")));
            this.ribbonButtonDrawMethodsArc.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsArc.LargeImage")));
            this.ribbonButtonDrawMethodsArc.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsArc.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsArc.Name = "ribbonButtonDrawMethodsArc";
            this.ribbonButtonDrawMethodsArc.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsArc.SmallImage")));
            this.ribbonButtonDrawMethodsArc.Text = "Arc";
            this.ribbonButtonDrawMethodsArc.ToolTip = "Draws an arc without modifying the drawing database";
            this.ribbonButtonDrawMethodsArc.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsArc.ToolTipImage")));
            this.ribbonButtonDrawMethodsArc.ToolTipTitle = "Draw, Arc";
            this.ribbonButtonDrawMethodsArc.Click += new System.EventHandler(this.ribbonButtonDrawMethodsArc_Click);
            // 
            // ribbonButtonDrawMethodsImage
            // 
            this.ribbonButtonDrawMethodsImage.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsImage.Image")));
            this.ribbonButtonDrawMethodsImage.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsImage.LargeImage")));
            this.ribbonButtonDrawMethodsImage.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsImage.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsImage.Name = "ribbonButtonDrawMethodsImage";
            this.ribbonButtonDrawMethodsImage.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsImage.SmallImage")));
            this.ribbonButtonDrawMethodsImage.Text = "ribbonButton9";
            this.ribbonButtonDrawMethodsImage.ToolTip = "Inserts an image without modifying the drawing database";
            this.ribbonButtonDrawMethodsImage.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsImage.ToolTipImage")));
            this.ribbonButtonDrawMethodsImage.ToolTipTitle = "Draw, Image";
            this.ribbonButtonDrawMethodsImage.Click += new System.EventHandler(this.ribbonButtonDrawMethodsImage_Click);
            // 
            // ribbonButtonDrawMethodsPolygon
            // 
            this.ribbonButtonDrawMethodsPolygon.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPolygon.Image")));
            this.ribbonButtonDrawMethodsPolygon.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPolygon.LargeImage")));
            this.ribbonButtonDrawMethodsPolygon.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsPolygon.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsPolygon.Name = "ribbonButtonDrawMethodsPolygon";
            this.ribbonButtonDrawMethodsPolygon.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPolygon.SmallImage")));
            this.ribbonButtonDrawMethodsPolygon.Text = "ribbonButton11";
            this.ribbonButtonDrawMethodsPolygon.ToolTip = "Draws a polygon without modifying the drawing database";
            this.ribbonButtonDrawMethodsPolygon.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPolygon.ToolTipImage")));
            this.ribbonButtonDrawMethodsPolygon.ToolTipTitle = "Draw, Polygon";
            this.ribbonButtonDrawMethodsPolygon.Click += new System.EventHandler(this.ribbonButtonDrawMethodsPolygon_Click);
            // 
            // ribbonColorChooserDrawMethodsColor
            // 
            this.ribbonColorChooserDrawMethodsColor.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserDrawMethodsColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserDrawMethodsColor.Image")));
            this.ribbonColorChooserDrawMethodsColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserDrawMethodsColor.LargeImage")));
            this.ribbonColorChooserDrawMethodsColor.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserDrawMethodsColor.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserDrawMethodsColor.Name = "ribbonColorChooserDrawMethodsColor";
            this.ribbonColorChooserDrawMethodsColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserDrawMethodsColor.SmallImage")));
            this.ribbonColorChooserDrawMethodsColor.Text = "ribbonColorChooser1";
            this.ribbonColorChooserDrawMethodsColor.ToolTip = "Sets the current draw pen color";
            this.ribbonColorChooserDrawMethodsColor.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserDrawMethodsColor.ToolTipImage")));
            this.ribbonColorChooserDrawMethodsColor.ToolTipTitle = "Pen Color";
            this.ribbonColorChooserDrawMethodsColor.Click += new System.EventHandler(this.ribbonColorChooserDrawMethodsColor_Click);
            // 
            // ribbonButtonDrawMethodsPenWidth
            // 
            this.ribbonButtonDrawMethodsPenWidth.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPenWidth.Image")));
            this.ribbonButtonDrawMethodsPenWidth.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPenWidth.LargeImage")));
            this.ribbonButtonDrawMethodsPenWidth.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsPenWidth.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsPenWidth.Name = "ribbonButtonDrawMethodsPenWidth";
            this.ribbonButtonDrawMethodsPenWidth.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPenWidth.SmallImage")));
            this.ribbonButtonDrawMethodsPenWidth.Text = "ribbonButton8";
            this.ribbonButtonDrawMethodsPenWidth.ToolTip = "Sets the current draw pen width";
            this.ribbonButtonDrawMethodsPenWidth.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsPenWidth.ToolTipImage")));
            this.ribbonButtonDrawMethodsPenWidth.ToolTipTitle = "Pen Width";
            this.ribbonButtonDrawMethodsPenWidth.Click += new System.EventHandler(this.ribbonButtonDrawMethodsPenWidth_Click);
            // 
            // ribbonButtonDrawMethodsFill
            // 
            this.ribbonButtonDrawMethodsFill.CheckOnClick = true;
            this.ribbonButtonDrawMethodsFill.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsFill.Image")));
            this.ribbonButtonDrawMethodsFill.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsFill.LargeImage")));
            this.ribbonButtonDrawMethodsFill.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsFill.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsFill.Name = "ribbonButtonDrawMethodsFill";
            this.ribbonButtonDrawMethodsFill.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsFill.SmallImage")));
            this.ribbonButtonDrawMethodsFill.Text = "ribbonButton6";
            this.ribbonButtonDrawMethodsFill.ToolTip = "If set to true the closed drawing element is filled";
            this.ribbonButtonDrawMethodsFill.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsFill.ToolTipImage")));
            this.ribbonButtonDrawMethodsFill.ToolTipTitle = "Fill";
            // 
            // ribbonButtonDrawMethodsStore
            // 
            this.ribbonButtonDrawMethodsStore.Checked = true;
            this.ribbonButtonDrawMethodsStore.CheckOnClick = true;
            this.ribbonButtonDrawMethodsStore.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsStore.Image")));
            this.ribbonButtonDrawMethodsStore.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsStore.LargeImage")));
            this.ribbonButtonDrawMethodsStore.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsStore.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsStore.Name = "ribbonButtonDrawMethodsStore";
            this.ribbonButtonDrawMethodsStore.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsStore.SmallImage")));
            this.ribbonButtonDrawMethodsStore.Text = "ribbonButton7";
            this.ribbonButtonDrawMethodsStore.ToolTip = "If set to true the element is drawn again after a refresh";
            this.ribbonButtonDrawMethodsStore.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsStore.ToolTipImage")));
            this.ribbonButtonDrawMethodsStore.ToolTipTitle = "Store";
            // 
            // ribbonButtonDrawMethodsClear
            // 
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearPoints);
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearLines);
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearCircles);
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearArcs);
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearPolygons);
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearTexts);
            this.ribbonButtonDrawMethodsClear.DropDownItems.Add(this.ribbonButtonDrawMethodsClearImages);
            this.ribbonButtonDrawMethodsClear.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClear.Image")));
            this.ribbonButtonDrawMethodsClear.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClear.LargeImage")));
            this.ribbonButtonDrawMethodsClear.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsClear.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawMethodsClear.Name = "ribbonButtonDrawMethodsClear";
            this.ribbonButtonDrawMethodsClear.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClear.SmallImage")));
            this.ribbonButtonDrawMethodsClear.Style = System.Windows.Forms.RibbonButtonStyle.SplitDropDown;
            this.ribbonButtonDrawMethodsClear.Text = "ribbonButtonDrawMethodsErase";
            this.ribbonButtonDrawMethodsClear.ToolTip = "Clears all elements added with the Drawn methods";
            this.ribbonButtonDrawMethodsClear.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClear.ToolTipImage")));
            this.ribbonButtonDrawMethodsClear.ToolTipTitle = "Clear";
            this.ribbonButtonDrawMethodsClear.Click += new System.EventHandler(this.ribbonButton9_Click_1);
            // 
            // ribbonButtonDrawMethodsClearPoints
            // 
            this.ribbonButtonDrawMethodsClearPoints.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearPoints.DropDownItems.Add(this.ribbonButton6);
            this.ribbonButtonDrawMethodsClearPoints.DropDownItems.Add(this.ribbonButton7);
            this.ribbonButtonDrawMethodsClearPoints.DropDownItems.Add(this.ribbonButton8);
            this.ribbonButtonDrawMethodsClearPoints.DropDownItems.Add(this.ribbonButton9);
            this.ribbonButtonDrawMethodsClearPoints.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearPoints.Image")));
            this.ribbonButtonDrawMethodsClearPoints.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearPoints.LargeImage")));
            this.ribbonButtonDrawMethodsClearPoints.Name = "ribbonButtonDrawMethodsClearPoints";
            this.ribbonButtonDrawMethodsClearPoints.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearPoints.SmallImage")));
            this.ribbonButtonDrawMethodsClearPoints.Text = "Points";
            this.ribbonButtonDrawMethodsClearPoints.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearPoints_Click);
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.LargeImage")));
            this.ribbonButton6.Name = "ribbonButton6";
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "ribbonButton6";
            // 
            // ribbonButton7
            // 
            this.ribbonButton7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.Image")));
            this.ribbonButton7.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.LargeImage")));
            this.ribbonButton7.Name = "ribbonButton7";
            this.ribbonButton7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton7.SmallImage")));
            this.ribbonButton7.Text = "ribbonButton7";
            // 
            // ribbonButton8
            // 
            this.ribbonButton8.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.Image")));
            this.ribbonButton8.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.LargeImage")));
            this.ribbonButton8.Name = "ribbonButton8";
            this.ribbonButton8.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton8.SmallImage")));
            this.ribbonButton8.Text = "ribbonButton8";
            // 
            // ribbonButton9
            // 
            this.ribbonButton9.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.Image")));
            this.ribbonButton9.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.LargeImage")));
            this.ribbonButton9.Name = "ribbonButton9";
            this.ribbonButton9.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton9.SmallImage")));
            this.ribbonButton9.Text = "ribbonButton9";
            // 
            // ribbonButtonDrawMethodsClearLines
            // 
            this.ribbonButtonDrawMethodsClearLines.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearLines.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearLines.Image")));
            this.ribbonButtonDrawMethodsClearLines.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearLines.LargeImage")));
            this.ribbonButtonDrawMethodsClearLines.Name = "ribbonButtonDrawMethodsClearLines";
            this.ribbonButtonDrawMethodsClearLines.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearLines.SmallImage")));
            this.ribbonButtonDrawMethodsClearLines.Text = "Lines";
            this.ribbonButtonDrawMethodsClearLines.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearLines_Click);
            // 
            // ribbonButtonDrawMethodsClearCircles
            // 
            this.ribbonButtonDrawMethodsClearCircles.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearCircles.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearCircles.Image")));
            this.ribbonButtonDrawMethodsClearCircles.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearCircles.LargeImage")));
            this.ribbonButtonDrawMethodsClearCircles.Name = "ribbonButtonDrawMethodsClearCircles";
            this.ribbonButtonDrawMethodsClearCircles.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearCircles.SmallImage")));
            this.ribbonButtonDrawMethodsClearCircles.Text = "Circles";
            this.ribbonButtonDrawMethodsClearCircles.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearCircles_Click);
            // 
            // ribbonButtonDrawMethodsClearArcs
            // 
            this.ribbonButtonDrawMethodsClearArcs.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearArcs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearArcs.Image")));
            this.ribbonButtonDrawMethodsClearArcs.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearArcs.LargeImage")));
            this.ribbonButtonDrawMethodsClearArcs.Name = "ribbonButtonDrawMethodsClearArcs";
            this.ribbonButtonDrawMethodsClearArcs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearArcs.SmallImage")));
            this.ribbonButtonDrawMethodsClearArcs.Text = "Arcs";
            this.ribbonButtonDrawMethodsClearArcs.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearArcs_Click);
            // 
            // ribbonButtonDrawMethodsClearPolygons
            // 
            this.ribbonButtonDrawMethodsClearPolygons.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearPolygons.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearPolygons.Image")));
            this.ribbonButtonDrawMethodsClearPolygons.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearPolygons.LargeImage")));
            this.ribbonButtonDrawMethodsClearPolygons.Name = "ribbonButtonDrawMethodsClearPolygons";
            this.ribbonButtonDrawMethodsClearPolygons.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearPolygons.SmallImage")));
            this.ribbonButtonDrawMethodsClearPolygons.Text = "Polygons";
            this.ribbonButtonDrawMethodsClearPolygons.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearPolygons_Click);
            // 
            // ribbonButtonDrawMethodsClearTexts
            // 
            this.ribbonButtonDrawMethodsClearTexts.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearTexts.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearTexts.Image")));
            this.ribbonButtonDrawMethodsClearTexts.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearTexts.LargeImage")));
            this.ribbonButtonDrawMethodsClearTexts.Name = "ribbonButtonDrawMethodsClearTexts";
            this.ribbonButtonDrawMethodsClearTexts.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearTexts.SmallImage")));
            this.ribbonButtonDrawMethodsClearTexts.Text = "Texts";
            this.ribbonButtonDrawMethodsClearTexts.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearTexts_Click);
            // 
            // ribbonButtonDrawMethodsClearImages
            // 
            this.ribbonButtonDrawMethodsClearImages.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonButtonDrawMethodsClearImages.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearImages.Image")));
            this.ribbonButtonDrawMethodsClearImages.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearImages.LargeImage")));
            this.ribbonButtonDrawMethodsClearImages.Name = "ribbonButtonDrawMethodsClearImages";
            this.ribbonButtonDrawMethodsClearImages.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawMethodsClearImages.SmallImage")));
            this.ribbonButtonDrawMethodsClearImages.Text = "Images";
            this.ribbonButtonDrawMethodsClearImages.Click += new System.EventHandler(this.ribbonButtonDrawMethodsClearImages_Click);
            // 
            // ribbonPanelHelp
            // 
            this.ribbonPanelHelp.ButtonMoreVisible = false;
            this.ribbonPanelHelp.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelHelp.Image")));
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonHelpRegister);
            this.ribbonPanelHelp.Items.Add(this.ribbonButtonHelpAbout);
            this.ribbonPanelHelp.Name = "ribbonPanelHelp";
            this.ribbonPanelHelp.Text = "Help";
            this.ribbonPanelHelp.ButtonMoreClick += new System.EventHandler(this.ribbonPanelHelp_ButtonMoreClick);
            // 
            // ribbonButtonHelpRegister
            // 
            this.ribbonButtonHelpRegister.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpRegister.Image")));
            this.ribbonButtonHelpRegister.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpRegister.LargeImage")));
            this.ribbonButtonHelpRegister.Name = "ribbonButtonHelpRegister";
            this.ribbonButtonHelpRegister.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpRegister.SmallImage")));
            this.ribbonButtonHelpRegister.Text = "Register DXFReader.NET";
            this.ribbonButtonHelpRegister.ToolTip = "Register DXFReader.NET Component";
            this.ribbonButtonHelpRegister.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpRegister.ToolTipImage")));
            this.ribbonButtonHelpRegister.ToolTipTitle = "Register";
            this.ribbonButtonHelpRegister.Click += new System.EventHandler(this.ribbonButtonHelpRegister_Click);
            // 
            // ribbonButtonHelpAbout
            // 
            this.ribbonButtonHelpAbout.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpAbout.Image")));
            this.ribbonButtonHelpAbout.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpAbout.LargeImage")));
            this.ribbonButtonHelpAbout.Name = "ribbonButtonHelpAbout";
            this.ribbonButtonHelpAbout.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpAbout.SmallImage")));
            this.ribbonButtonHelpAbout.Text = "About DXFReader.NET";
            this.ribbonButtonHelpAbout.ToolTip = "About DXFReader.NET Component";
            this.ribbonButtonHelpAbout.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHelpAbout.ToolTipImage")));
            this.ribbonButtonHelpAbout.ToolTipTitle = "About";
            this.ribbonButtonHelpAbout.Click += new System.EventHandler(this.ribbonButtonHelpAbout_Click);
            // 
            // ribbonTabFormat
            // 
            this.ribbonTabFormat.Name = "ribbonTabFormat";
            this.ribbonTabFormat.Panels.Add(this.ribbonPanelColors);
            this.ribbonTabFormat.Panels.Add(this.ribbonPanelAspect);
            this.ribbonTabFormat.Panels.Add(this.ribbonPanelPlotSettings);
            this.ribbonTabFormat.Text = "Format";
            // 
            // ribbonPanelColors
            // 
            this.ribbonPanelColors.ButtonMoreVisible = false;
            this.ribbonPanelColors.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelColors.Image")));
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup1);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup2);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup3);
            this.ribbonPanelColors.Items.Add(this.ribbonSeparator2);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup4);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup5);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup6);
            this.ribbonPanelColors.Items.Add(this.ribbonSeparator3);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup7);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup8);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup9);
            this.ribbonPanelColors.Items.Add(this.ribbonSeparator4);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup10);
            this.ribbonPanelColors.Items.Add(this.ribbonItemGroup11);
            this.ribbonPanelColors.Items.Add(this.ribbonButtonRubberBandStyle);
            this.ribbonPanelColors.Items.Add(this.ribbonButtonLightColorScheme);
            this.ribbonPanelColors.Items.Add(this.ribbonButtonDefaultColorScheme);
            this.ribbonPanelColors.Name = "ribbonPanelColors";
            this.ribbonPanelColors.Text = "Colors";
            // 
            // ribbonItemGroup1
            // 
            this.ribbonItemGroup1.Items.Add(this.ribbonLabel6);
            this.ribbonItemGroup1.Items.Add(this.ribbonColorChooserForeColor);
            this.ribbonItemGroup1.Name = "ribbonItemGroup1";
            this.ribbonItemGroup1.Text = "ribbonItemGroup1";
            // 
            // ribbonLabel6
            // 
            this.ribbonLabel6.LabelWidth = 80;
            this.ribbonLabel6.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel6.Name = "ribbonLabel6";
            this.ribbonLabel6.Text = "ForeGround";
            this.ribbonLabel6.ToolTip = "Selects foreground  color";
            this.ribbonLabel6.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonLabel6.ToolTipImage")));
            this.ribbonLabel6.ToolTipTitle = "Foreground Color";
            this.ribbonLabel6.Click += new System.EventHandler(this.ribbonLabel6_Click);
            // 
            // ribbonColorChooserForeColor
            // 
            this.ribbonColorChooserForeColor.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserForeColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserForeColor.Image")));
            this.ribbonColorChooserForeColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserForeColor.LargeImage")));
            this.ribbonColorChooserForeColor.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserForeColor.Name = "ribbonColorChooserForeColor";
            this.ribbonColorChooserForeColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserForeColor.SmallImage")));
            this.ribbonColorChooserForeColor.Text = "ribbonColorChooser1";
            this.ribbonColorChooserForeColor.ToolTip = "Selects foreground  color";
            this.ribbonColorChooserForeColor.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserForeColor.ToolTipImage")));
            this.ribbonColorChooserForeColor.ToolTipTitle = "Foreground Color";
            this.ribbonColorChooserForeColor.Click += new System.EventHandler(this.ribbonColorChooserForeColor_Click);
            // 
            // ribbonItemGroup2
            // 
            this.ribbonItemGroup2.Items.Add(this.ribbonLabel5);
            this.ribbonItemGroup2.Items.Add(this.ribbonColorChooserBackColor);
            this.ribbonItemGroup2.Name = "ribbonItemGroup2";
            this.ribbonItemGroup2.Text = "ribbonItemGroup2";
            // 
            // ribbonLabel5
            // 
            this.ribbonLabel5.LabelWidth = 80;
            this.ribbonLabel5.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel5.Name = "ribbonLabel5";
            this.ribbonLabel5.Text = "BackGround";
            // 
            // ribbonColorChooserBackColor
            // 
            this.ribbonColorChooserBackColor.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserBackColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserBackColor.Image")));
            this.ribbonColorChooserBackColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserBackColor.LargeImage")));
            this.ribbonColorChooserBackColor.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserBackColor.Name = "ribbonColorChooserBackColor";
            this.ribbonColorChooserBackColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserBackColor.SmallImage")));
            this.ribbonColorChooserBackColor.Text = "ribbonColorChooser1";
            this.ribbonColorChooserBackColor.ToolTip = "Select background color";
            this.ribbonColorChooserBackColor.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserBackColor.ToolTipImage")));
            this.ribbonColorChooserBackColor.ToolTipTitle = "Back Color";
            this.ribbonColorChooserBackColor.Click += new System.EventHandler(this.ribbonColorChooserBackColor_Click);
            // 
            // ribbonItemGroup3
            // 
            this.ribbonItemGroup3.Items.Add(this.ribbonLabel7);
            this.ribbonItemGroup3.Items.Add(this.ribbonColorChooserGrid);
            this.ribbonItemGroup3.Name = "ribbonItemGroup3";
            this.ribbonItemGroup3.Text = "ribbonItemGroup3";
            // 
            // ribbonLabel7
            // 
            this.ribbonLabel7.LabelWidth = 80;
            this.ribbonLabel7.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel7.Name = "ribbonLabel7";
            this.ribbonLabel7.Text = "Grid";
            // 
            // ribbonColorChooserGrid
            // 
            this.ribbonColorChooserGrid.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserGrid.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserGrid.Image")));
            this.ribbonColorChooserGrid.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserGrid.LargeImage")));
            this.ribbonColorChooserGrid.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserGrid.Name = "ribbonColorChooserGrid";
            this.ribbonColorChooserGrid.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserGrid.SmallImage")));
            this.ribbonColorChooserGrid.Text = "ribbonColorChooser1";
            this.ribbonColorChooserGrid.ToolTip = "Selects the color used to display the grid\'s lines in the control";
            this.ribbonColorChooserGrid.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserGrid.ToolTipImage")));
            this.ribbonColorChooserGrid.ToolTipTitle = "Grid Color";
            this.ribbonColorChooserGrid.Click += new System.EventHandler(this.ribbonColorChooserGrid_Click);
            // 
            // ribbonSeparator2
            // 
            this.ribbonSeparator2.Name = "ribbonSeparator2";
            // 
            // ribbonItemGroup4
            // 
            this.ribbonItemGroup4.Items.Add(this.ribbonLabel8);
            this.ribbonItemGroup4.Items.Add(this.ribbonColorChooserAxisX);
            this.ribbonItemGroup4.Name = "ribbonItemGroup4";
            this.ribbonItemGroup4.Text = "ribbonItemGroup4";
            // 
            // ribbonLabel8
            // 
            this.ribbonLabel8.LabelWidth = 50;
            this.ribbonLabel8.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel8.Name = "ribbonLabel8";
            this.ribbonLabel8.Text = "Axis X";
            // 
            // ribbonColorChooserAxisX
            // 
            this.ribbonColorChooserAxisX.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserAxisX.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisX.Image")));
            this.ribbonColorChooserAxisX.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisX.LargeImage")));
            this.ribbonColorChooserAxisX.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserAxisX.Name = "ribbonColorChooserAxisX";
            this.ribbonColorChooserAxisX.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisX.SmallImage")));
            this.ribbonColorChooserAxisX.Text = "ribbonColorChooser1";
            this.ribbonColorChooserAxisX.ToolTip = "Selects  the color used to X axis";
            this.ribbonColorChooserAxisX.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisX.ToolTipImage")));
            this.ribbonColorChooserAxisX.ToolTipTitle = "Axis X Color";
            this.ribbonColorChooserAxisX.Click += new System.EventHandler(this.ribbonColorChooserAxisX_Click);
            // 
            // ribbonItemGroup5
            // 
            this.ribbonItemGroup5.Items.Add(this.ribbonLabel9);
            this.ribbonItemGroup5.Items.Add(this.ribbonColorChooserAxisY);
            this.ribbonItemGroup5.Name = "ribbonItemGroup5";
            this.ribbonItemGroup5.Text = "ribbonItemGroup5";
            // 
            // ribbonLabel9
            // 
            this.ribbonLabel9.LabelWidth = 50;
            this.ribbonLabel9.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel9.Name = "ribbonLabel9";
            this.ribbonLabel9.Text = "Axis Y";
            // 
            // ribbonColorChooserAxisY
            // 
            this.ribbonColorChooserAxisY.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserAxisY.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisY.Image")));
            this.ribbonColorChooserAxisY.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisY.LargeImage")));
            this.ribbonColorChooserAxisY.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserAxisY.Name = "ribbonColorChooserAxisY";
            this.ribbonColorChooserAxisY.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisY.SmallImage")));
            this.ribbonColorChooserAxisY.Text = "ribbonColorChooser2";
            this.ribbonColorChooserAxisY.ToolTip = "Selects  the color used to Y axis";
            this.ribbonColorChooserAxisY.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisY.ToolTipImage")));
            this.ribbonColorChooserAxisY.ToolTipTitle = "Axis Y Color";
            this.ribbonColorChooserAxisY.Click += new System.EventHandler(this.ribbonColorChooserAxisY_Click);
            // 
            // ribbonItemGroup6
            // 
            this.ribbonItemGroup6.Items.Add(this.ribbonLabel10);
            this.ribbonItemGroup6.Items.Add(this.ribbonColorChooserAxisZ);
            this.ribbonItemGroup6.Name = "ribbonItemGroup6";
            this.ribbonItemGroup6.Text = "ribbonItemGroup6";
            this.ribbonItemGroup6.ToolTip = "Selects  the color used to X axis. ";
            this.ribbonItemGroup6.ToolTipTitle = "Axis X Color";
            // 
            // ribbonLabel10
            // 
            this.ribbonLabel10.LabelWidth = 50;
            this.ribbonLabel10.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel10.Name = "ribbonLabel10";
            this.ribbonLabel10.Text = "Axis Z";
            // 
            // ribbonColorChooserAxisZ
            // 
            this.ribbonColorChooserAxisZ.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserAxisZ.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisZ.Image")));
            this.ribbonColorChooserAxisZ.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisZ.LargeImage")));
            this.ribbonColorChooserAxisZ.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserAxisZ.Name = "ribbonColorChooserAxisZ";
            this.ribbonColorChooserAxisZ.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisZ.SmallImage")));
            this.ribbonColorChooserAxisZ.Text = "ribbonColorChooser3";
            this.ribbonColorChooserAxisZ.ToolTip = "Selects  the color used to Z axis";
            this.ribbonColorChooserAxisZ.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxisZ.ToolTipImage")));
            this.ribbonColorChooserAxisZ.ToolTipTitle = "Axis Z Color";
            this.ribbonColorChooserAxisZ.Click += new System.EventHandler(this.ribbonColorChooserAxisZ_Click);
            // 
            // ribbonSeparator3
            // 
            this.ribbonSeparator3.Name = "ribbonSeparator3";
            // 
            // ribbonItemGroup7
            // 
            this.ribbonItemGroup7.Items.Add(this.ribbonLabel11);
            this.ribbonItemGroup7.Items.Add(this.ribbonColorChooserHighlight);
            this.ribbonItemGroup7.Name = "ribbonItemGroup7";
            this.ribbonItemGroup7.Text = "ribbonItemGroup7";
            // 
            // ribbonLabel11
            // 
            this.ribbonLabel11.LabelWidth = 110;
            this.ribbonLabel11.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel11.Name = "ribbonLabel11";
            this.ribbonLabel11.Text = "Highlight";
            // 
            // ribbonColorChooserHighlight
            // 
            this.ribbonColorChooserHighlight.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserHighlight.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlight.Image")));
            this.ribbonColorChooserHighlight.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlight.LargeImage")));
            this.ribbonColorChooserHighlight.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserHighlight.Name = "ribbonColorChooserHighlight";
            this.ribbonColorChooserHighlight.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlight.SmallImage")));
            this.ribbonColorChooserHighlight.Text = "ribbonColorChooser1";
            this.ribbonColorChooserHighlight.ToolTip = "Selects  the color used to display highlited entities";
            this.ribbonColorChooserHighlight.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlight.ToolTipImage")));
            this.ribbonColorChooserHighlight.ToolTipTitle = "Highlight Color";
            this.ribbonColorChooserHighlight.Click += new System.EventHandler(this.ribbonColorChooserHighlight_Click);
            // 
            // ribbonItemGroup8
            // 
            this.ribbonItemGroup8.Items.Add(this.ribbonLabel12);
            this.ribbonItemGroup8.Items.Add(this.ribbonColorChooserHighlightMarker);
            this.ribbonItemGroup8.Name = "ribbonItemGroup8";
            this.ribbonItemGroup8.Text = "ribbonItemGroup8";
            // 
            // ribbonLabel12
            // 
            this.ribbonLabel12.LabelWidth = 110;
            this.ribbonLabel12.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel12.Name = "ribbonLabel12";
            this.ribbonLabel12.Text = "Highlight marker";
            // 
            // ribbonColorChooserHighlightMarker
            // 
            this.ribbonColorChooserHighlightMarker.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserHighlightMarker.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker.Image")));
            this.ribbonColorChooserHighlightMarker.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker.LargeImage")));
            this.ribbonColorChooserHighlightMarker.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserHighlightMarker.Name = "ribbonColorChooserHighlightMarker";
            this.ribbonColorChooserHighlightMarker.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker.SmallImage")));
            this.ribbonColorChooserHighlightMarker.Text = "ribbonColorChooser2";
            this.ribbonColorChooserHighlightMarker.ToolTip = "Selects  the color used to display the marks of highlighted entities";
            this.ribbonColorChooserHighlightMarker.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker.ToolTipImage")));
            this.ribbonColorChooserHighlightMarker.ToolTipTitle = "Highlight Marker Color";
            this.ribbonColorChooserHighlightMarker.Click += new System.EventHandler(this.ribbonColorChooserHighlightMarker_Click);
            // 
            // ribbonItemGroup9
            // 
            this.ribbonItemGroup9.Items.Add(this.ribbonLabel13);
            this.ribbonItemGroup9.Items.Add(this.ribbonColorChooserHighlightMarker2);
            this.ribbonItemGroup9.Name = "ribbonItemGroup9";
            this.ribbonItemGroup9.Text = "ribbonItemGroup9";
            // 
            // ribbonLabel13
            // 
            this.ribbonLabel13.LabelWidth = 110;
            this.ribbonLabel13.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel13.Name = "ribbonLabel13";
            this.ribbonLabel13.Text = "Highlight marker2";
            // 
            // ribbonColorChooserHighlightMarker2
            // 
            this.ribbonColorChooserHighlightMarker2.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserHighlightMarker2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker2.Image")));
            this.ribbonColorChooserHighlightMarker2.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker2.LargeImage")));
            this.ribbonColorChooserHighlightMarker2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserHighlightMarker2.Name = "ribbonColorChooserHighlightMarker2";
            this.ribbonColorChooserHighlightMarker2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker2.SmallImage")));
            this.ribbonColorChooserHighlightMarker2.Text = "ribbonColorChooser3";
            this.ribbonColorChooserHighlightMarker2.ToolTip = "Selects  the color used to display the secondary marks of highlighted entities";
            this.ribbonColorChooserHighlightMarker2.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserHighlightMarker2.ToolTipImage")));
            this.ribbonColorChooserHighlightMarker2.ToolTipTitle = "Highlight Marker Color 2";
            this.ribbonColorChooserHighlightMarker2.Click += new System.EventHandler(this.ribbonColorChooserHighlightMarker2_Click);
            // 
            // ribbonSeparator4
            // 
            this.ribbonSeparator4.Name = "ribbonSeparator4";
            // 
            // ribbonItemGroup10
            // 
            this.ribbonItemGroup10.Items.Add(this.ribbonLabel14);
            this.ribbonItemGroup10.Items.Add(this.ribbonColorChooserAxes);
            this.ribbonItemGroup10.Name = "ribbonItemGroup10";
            this.ribbonItemGroup10.Text = "ribbonItemGroup10";
            // 
            // ribbonLabel14
            // 
            this.ribbonLabel14.LabelWidth = 80;
            this.ribbonLabel14.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel14.Name = "ribbonLabel14";
            this.ribbonLabel14.Text = "Axes";
            // 
            // ribbonColorChooserAxes
            // 
            this.ribbonColorChooserAxes.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserAxes.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxes.Image")));
            this.ribbonColorChooserAxes.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxes.LargeImage")));
            this.ribbonColorChooserAxes.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserAxes.Name = "ribbonColorChooserAxes";
            this.ribbonColorChooserAxes.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxes.SmallImage")));
            this.ribbonColorChooserAxes.Text = "ribbonColorChooser1";
            this.ribbonColorChooserAxes.ToolTip = "Selects the color used to display the limits box";
            this.ribbonColorChooserAxes.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserAxes.ToolTipImage")));
            this.ribbonColorChooserAxes.ToolTipTitle = "Axes Color";
            this.ribbonColorChooserAxes.Click += new System.EventHandler(this.ribbonColorChooserAxes_Click);
            // 
            // ribbonItemGroup11
            // 
            this.ribbonItemGroup11.Items.Add(this.ribbonLabel15);
            this.ribbonItemGroup11.Items.Add(this.ribbonColorChooserRubberBand);
            this.ribbonItemGroup11.Name = "ribbonItemGroup11";
            this.ribbonItemGroup11.Text = "ribbonItemGroup11";
            // 
            // ribbonLabel15
            // 
            this.ribbonLabel15.LabelWidth = 80;
            this.ribbonLabel15.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonLabel15.Name = "ribbonLabel15";
            this.ribbonLabel15.Text = "Rubber band";
            // 
            // ribbonColorChooserRubberBand
            // 
            this.ribbonColorChooserRubberBand.Color = System.Drawing.Color.Transparent;
            this.ribbonColorChooserRubberBand.Image = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserRubberBand.Image")));
            this.ribbonColorChooserRubberBand.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserRubberBand.LargeImage")));
            this.ribbonColorChooserRubberBand.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonColorChooserRubberBand.Name = "ribbonColorChooserRubberBand";
            this.ribbonColorChooserRubberBand.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserRubberBand.SmallImage")));
            this.ribbonColorChooserRubberBand.Text = "ribbonColorChooser2";
            this.ribbonColorChooserRubberBand.ToolTip = "Selects the color of the rubber band if solid";
            this.ribbonColorChooserRubberBand.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonColorChooserRubberBand.ToolTipImage")));
            this.ribbonColorChooserRubberBand.ToolTipTitle = "Rubber Band Color";
            this.ribbonColorChooserRubberBand.Click += new System.EventHandler(this.ribbonColorChooserRubberBand_Click);
            // 
            // ribbonButtonRubberBandStyle
            // 
            this.ribbonButtonRubberBandStyle.DropDownItems.Add(this.ribbonButtonRubberBandStyleDashed);
            this.ribbonButtonRubberBandStyle.DropDownItems.Add(this.ribbonButtonRubberBandStyleSolid);
            this.ribbonButtonRubberBandStyle.Name = "ribbonButtonRubberBandStyle";
            this.ribbonButtonRubberBandStyle.Text = "Rubber band type";
            this.ribbonButtonRubberBandStyle.TextBoxText = "";
            this.ribbonButtonRubberBandStyle.DropDownItemClicked += new System.Windows.Forms.RibbonComboBox.RibbonItemEventHandler(this.ribbonButtonRubberBandStyle_DropDownItemClicked);
            // 
            // ribbonButtonRubberBandStyleDashed
            // 
            this.ribbonButtonRubberBandStyleDashed.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRubberBandStyleDashed.Image")));
            this.ribbonButtonRubberBandStyleDashed.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRubberBandStyleDashed.LargeImage")));
            this.ribbonButtonRubberBandStyleDashed.Name = "ribbonButtonRubberBandStyleDashed";
            this.ribbonButtonRubberBandStyleDashed.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRubberBandStyleDashed.SmallImage")));
            this.ribbonButtonRubberBandStyleDashed.Text = "Dashed";
            // 
            // ribbonButtonRubberBandStyleSolid
            // 
            this.ribbonButtonRubberBandStyleSolid.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRubberBandStyleSolid.Image")));
            this.ribbonButtonRubberBandStyleSolid.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRubberBandStyleSolid.LargeImage")));
            this.ribbonButtonRubberBandStyleSolid.Name = "ribbonButtonRubberBandStyleSolid";
            this.ribbonButtonRubberBandStyleSolid.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonRubberBandStyleSolid.SmallImage")));
            this.ribbonButtonRubberBandStyleSolid.Text = "Solid";
            // 
            // ribbonButtonLightColorScheme
            // 
            this.ribbonButtonLightColorScheme.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLightColorScheme.Image")));
            this.ribbonButtonLightColorScheme.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLightColorScheme.LargeImage")));
            this.ribbonButtonLightColorScheme.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonLightColorScheme.Name = "ribbonButtonLightColorScheme";
            this.ribbonButtonLightColorScheme.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLightColorScheme.SmallImage")));
            this.ribbonButtonLightColorScheme.Text = "Light scheme";
            this.ribbonButtonLightColorScheme.ToolTip = "Light scheme";
            this.ribbonButtonLightColorScheme.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonLightColorScheme.ToolTipImage")));
            this.ribbonButtonLightColorScheme.ToolTipTitle = "Light scheme";
            this.ribbonButtonLightColorScheme.Click += new System.EventHandler(this.ribbonButtonLightColorScheme_Click);
            // 
            // ribbonButtonDefaultColorScheme
            // 
            this.ribbonButtonDefaultColorScheme.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDefaultColorScheme.Image")));
            this.ribbonButtonDefaultColorScheme.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDefaultColorScheme.LargeImage")));
            this.ribbonButtonDefaultColorScheme.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDefaultColorScheme.Name = "ribbonButtonDefaultColorScheme";
            this.ribbonButtonDefaultColorScheme.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDefaultColorScheme.SmallImage")));
            this.ribbonButtonDefaultColorScheme.Text = "Default  scheme ";
            this.ribbonButtonDefaultColorScheme.ToolTip = "Default  scheme ";
            this.ribbonButtonDefaultColorScheme.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDefaultColorScheme.ToolTipImage")));
            this.ribbonButtonDefaultColorScheme.ToolTipTitle = "Default  scheme ";
            this.ribbonButtonDefaultColorScheme.Click += new System.EventHandler(this.ribbonButtonDefaultColorScheme_Click);
            // 
            // ribbonPanelAspect
            // 
            this.ribbonPanelAspect.ButtonMoreVisible = false;
            this.ribbonPanelAspect.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelAspect.Image")));
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonShowAxes);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonShowBasepoint);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonShowLimits);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonAntialias);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonShowgrid);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonGridRuler);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonCommandLine);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonDrawingLimits);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonHighlight);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonCheckContHighligh);
            this.ribbonPanelAspect.Items.Add(this.ribbonButton11);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonShowExtents);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonGridInsideLimits);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonGrabPoints);
            this.ribbonPanelAspect.Items.Add(this.ribbonButtonContinuosSelection);
            this.ribbonPanelAspect.Items.Add(this.ribbonUpDownPickBoxSize);
            this.ribbonPanelAspect.Items.Add(this.ribbonUpDownRubberPenWidth);
            this.ribbonPanelAspect.Items.Add(this.ribbonUpDownZoomFactor);
            this.ribbonPanelAspect.Name = "ribbonPanelAspect";
            this.ribbonPanelAspect.Text = "Aspect";
            // 
            // ribbonButtonShowAxes
            // 
            this.ribbonButtonShowAxes.CheckOnClick = true;
            this.ribbonButtonShowAxes.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowAxes.Image")));
            this.ribbonButtonShowAxes.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowAxes.LargeImage")));
            this.ribbonButtonShowAxes.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonShowAxes.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowAxes.Name = "ribbonButtonShowAxes";
            this.ribbonButtonShowAxes.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowAxes.SmallImage")));
            this.ribbonButtonShowAxes.Text = "Show axes";
            this.ribbonButtonShowAxes.ToolTip = "Sets whether the control will display the axes";
            this.ribbonButtonShowAxes.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowAxes.ToolTipImage")));
            this.ribbonButtonShowAxes.ToolTipTitle = "Show Axes";
            this.ribbonButtonShowAxes.Click += new System.EventHandler(this.ribbonButtonShowAxes_Click);
            // 
            // ribbonButtonShowBasepoint
            // 
            this.ribbonButtonShowBasepoint.CheckOnClick = true;
            this.ribbonButtonShowBasepoint.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowBasepoint.Image")));
            this.ribbonButtonShowBasepoint.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowBasepoint.LargeImage")));
            this.ribbonButtonShowBasepoint.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonShowBasepoint.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowBasepoint.Name = "ribbonButtonShowBasepoint";
            this.ribbonButtonShowBasepoint.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowBasepoint.SmallImage")));
            this.ribbonButtonShowBasepoint.Text = "Show basepoint";
            this.ribbonButtonShowBasepoint.ToolTip = "Sets whether the control will display the base point";
            this.ribbonButtonShowBasepoint.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowBasepoint.ToolTipImage")));
            this.ribbonButtonShowBasepoint.ToolTipTitle = "Show Basepoint";
            this.ribbonButtonShowBasepoint.Click += new System.EventHandler(this.ribbonButtonShowBasepoint_Click);
            // 
            // ribbonButtonShowLimits
            // 
            this.ribbonButtonShowLimits.CheckOnClick = true;
            this.ribbonButtonShowLimits.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowLimits.Image")));
            this.ribbonButtonShowLimits.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowLimits.LargeImage")));
            this.ribbonButtonShowLimits.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonShowLimits.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowLimits.Name = "ribbonButtonShowLimits";
            this.ribbonButtonShowLimits.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowLimits.SmallImage")));
            this.ribbonButtonShowLimits.Text = "Show limits";
            this.ribbonButtonShowLimits.ToolTip = "Sets whether the control will display the drawing limits";
            this.ribbonButtonShowLimits.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowLimits.ToolTipImage")));
            this.ribbonButtonShowLimits.ToolTipTitle = "Show Limits";
            this.ribbonButtonShowLimits.Click += new System.EventHandler(this.ribbonButtonShowLimits_Click);
            // 
            // ribbonButtonAntialias
            // 
            this.ribbonButtonAntialias.CheckOnClick = true;
            this.ribbonButtonAntialias.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAntialias.Image")));
            this.ribbonButtonAntialias.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAntialias.LargeImage")));
            this.ribbonButtonAntialias.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonAntialias.Name = "ribbonButtonAntialias";
            this.ribbonButtonAntialias.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAntialias.SmallImage")));
            this.ribbonButtonAntialias.Text = "Antialias";
            this.ribbonButtonAntialias.ToolTip = "Sets whether the control will display with antialias rendering";
            this.ribbonButtonAntialias.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonAntialias.ToolTipImage")));
            this.ribbonButtonAntialias.ToolTipTitle = "Antialias";
            this.ribbonButtonAntialias.Click += new System.EventHandler(this.ribbonButtonAntialias_Click);
            // 
            // ribbonButtonShowgrid
            // 
            this.ribbonButtonShowgrid.CheckOnClick = true;
            this.ribbonButtonShowgrid.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowgrid.Image")));
            this.ribbonButtonShowgrid.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowgrid.LargeImage")));
            this.ribbonButtonShowgrid.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonShowgrid.Name = "ribbonButtonShowgrid";
            this.ribbonButtonShowgrid.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowgrid.SmallImage")));
            this.ribbonButtonShowgrid.Text = "Show grid";
            this.ribbonButtonShowgrid.ToolTip = "Sets whether the control will display the grid";
            this.ribbonButtonShowgrid.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowgrid.ToolTipImage")));
            this.ribbonButtonShowgrid.ToolTipTitle = "Show grid";
            this.ribbonButtonShowgrid.Click += new System.EventHandler(this.ribbonButtonShowgrid_Click);
            // 
            // ribbonButtonGridRuler
            // 
            this.ribbonButtonGridRuler.CheckOnClick = true;
            this.ribbonButtonGridRuler.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridRuler.Image")));
            this.ribbonButtonGridRuler.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridRuler.LargeImage")));
            this.ribbonButtonGridRuler.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonGridRuler.Name = "ribbonButtonGridRuler";
            this.ribbonButtonGridRuler.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridRuler.SmallImage")));
            this.ribbonButtonGridRuler.Text = "Grid ruler";
            this.ribbonButtonGridRuler.ToolTip = "Sets the displaying of grid ruler";
            this.ribbonButtonGridRuler.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridRuler.ToolTipImage")));
            this.ribbonButtonGridRuler.ToolTipTitle = "Show Grid Ruler";
            this.ribbonButtonGridRuler.Click += new System.EventHandler(this.ribbonButtonGridRuler_Click);
            // 
            // ribbonButtonCommandLine
            // 
            this.ribbonButtonCommandLine.CheckOnClick = true;
            this.ribbonButtonCommandLine.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCommandLine.Image")));
            this.ribbonButtonCommandLine.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCommandLine.LargeImage")));
            this.ribbonButtonCommandLine.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonCommandLine.Name = "ribbonButtonCommandLine";
            this.ribbonButtonCommandLine.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCommandLine.SmallImage")));
            this.ribbonButtonCommandLine.Text = "Command line";
            this.ribbonButtonCommandLine.ToolTip = "Displays command line input";
            this.ribbonButtonCommandLine.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCommandLine.ToolTipImage")));
            this.ribbonButtonCommandLine.ToolTipTitle = "Command line";
            this.ribbonButtonCommandLine.Visible = false;
            this.ribbonButtonCommandLine.Click += new System.EventHandler(this.ribbonButtonCommandLine_Click);
            // 
            // ribbonButtonDrawingLimits
            // 
            this.ribbonButtonDrawingLimits.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawingLimits.Image")));
            this.ribbonButtonDrawingLimits.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawingLimits.LargeImage")));
            this.ribbonButtonDrawingLimits.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonDrawingLimits.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonDrawingLimits.Name = "ribbonButtonDrawingLimits";
            this.ribbonButtonDrawingLimits.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawingLimits.SmallImage")));
            this.ribbonButtonDrawingLimits.Text = "Set drawing limits";
            this.ribbonButtonDrawingLimits.ToolTip = "Sets the drawing limits";
            this.ribbonButtonDrawingLimits.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonDrawingLimits.ToolTipImage")));
            this.ribbonButtonDrawingLimits.ToolTipTitle = "Set drawing limits";
            this.ribbonButtonDrawingLimits.Click += new System.EventHandler(this.ribbonButtonDrawingLimits_Click);
            // 
            // ribbonButtonHighlight
            // 
            this.ribbonButtonHighlight.CheckOnClick = true;
            this.ribbonButtonHighlight.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHighlight.Image")));
            this.ribbonButtonHighlight.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHighlight.LargeImage")));
            this.ribbonButtonHighlight.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonHighlight.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonHighlight.Name = "ribbonButtonHighlight";
            this.ribbonButtonHighlight.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHighlight.SmallImage")));
            this.ribbonButtonHighlight.Text = "Highlight on hover";
            this.ribbonButtonHighlight.ToolTip = "Sets if the entity is highlighted on cursor hover";
            this.ribbonButtonHighlight.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonHighlight.ToolTipImage")));
            this.ribbonButtonHighlight.ToolTipTitle = "Highlight on hover";
            this.ribbonButtonHighlight.Click += new System.EventHandler(this.ribbonButtonHighlight_Click);
            // 
            // ribbonButtonCheckContHighligh
            // 
            this.ribbonButtonCheckContHighligh.CheckOnClick = true;
            this.ribbonButtonCheckContHighligh.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCheckContHighligh.Image")));
            this.ribbonButtonCheckContHighligh.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCheckContHighligh.LargeImage")));
            this.ribbonButtonCheckContHighligh.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonCheckContHighligh.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonCheckContHighligh.Name = "ribbonButtonCheckContHighligh";
            this.ribbonButtonCheckContHighligh.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCheckContHighligh.SmallImage")));
            this.ribbonButtonCheckContHighligh.Text = "Continuous highlight";
            this.ribbonButtonCheckContHighligh.ToolTip = "Sets if then highlighted entities are continuosly shown after zoom or redraw";
            this.ribbonButtonCheckContHighligh.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonCheckContHighligh.ToolTipImage")));
            this.ribbonButtonCheckContHighligh.ToolTipTitle = "Continuous highlight";
            this.ribbonButtonCheckContHighligh.Click += new System.EventHandler(this.ribbonButtonCheckContHighligh_Click);
            // 
            // ribbonButton11
            // 
            this.ribbonButton11.CheckOnClick = true;
            this.ribbonButton11.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.Image")));
            this.ribbonButton11.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.LargeImage")));
            this.ribbonButton11.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButton11.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton11.Name = "ribbonButton11";
            this.ribbonButton11.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton11.SmallImage")));
            this.ribbonButton11.Text = "Highlight not continous";
            this.ribbonButton11.ToolTip = "Sets if the entity the display of unconnected points.";
            this.ribbonButton11.ToolTipTitle = "Highlight not continous";
            this.ribbonButton11.Click += new System.EventHandler(this.ribbonButton11_Click_1);
            // 
            // ribbonButtonShowExtents
            // 
            this.ribbonButtonShowExtents.CheckOnClick = true;
            this.ribbonButtonShowExtents.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowExtents.Image")));
            this.ribbonButtonShowExtents.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowExtents.LargeImage")));
            this.ribbonButtonShowExtents.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonShowExtents.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonShowExtents.Name = "ribbonButtonShowExtents";
            this.ribbonButtonShowExtents.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonShowExtents.SmallImage")));
            this.ribbonButtonShowExtents.Text = "Show extents";
            this.ribbonButtonShowExtents.ToolTip = "Sets whether the control will display the drawing extents. ";
            this.ribbonButtonShowExtents.ToolTipTitle = "Show extents";
            this.ribbonButtonShowExtents.Click += new System.EventHandler(this.ribbonButtonShowExtents_Click);
            // 
            // ribbonButtonGridInsideLimits
            // 
            this.ribbonButtonGridInsideLimits.CheckOnClick = true;
            this.ribbonButtonGridInsideLimits.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridInsideLimits.Image")));
            this.ribbonButtonGridInsideLimits.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridInsideLimits.LargeImage")));
            this.ribbonButtonGridInsideLimits.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonGridInsideLimits.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonGridInsideLimits.Name = "ribbonButtonGridInsideLimits";
            this.ribbonButtonGridInsideLimits.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGridInsideLimits.SmallImage")));
            this.ribbonButtonGridInsideLimits.Text = "Grid inside limits";
            this.ribbonButtonGridInsideLimits.ToolTip = "Sets whether the grid is dispalyed only inside drawing\'s limits.";
            this.ribbonButtonGridInsideLimits.ToolTipTitle = "Grid inside limits";
            this.ribbonButtonGridInsideLimits.Click += new System.EventHandler(this.ribbonButtonGridInsideLimits_Click);
            // 
            // ribbonButtonGrabPoints
            // 
            this.ribbonButtonGrabPoints.CheckOnClick = true;
            this.ribbonButtonGrabPoints.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGrabPoints.Image")));
            this.ribbonButtonGrabPoints.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGrabPoints.LargeImage")));
            this.ribbonButtonGrabPoints.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonGrabPoints.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonGrabPoints.Name = "ribbonButtonGrabPoints";
            this.ribbonButtonGrabPoints.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGrabPoints.SmallImage")));
            this.ribbonButtonGrabPoints.Text = "Highlight grab points";
            this.ribbonButtonGrabPoints.ToolTip = "Sets whether the osnap points are visible";
            this.ribbonButtonGrabPoints.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonGrabPoints.ToolTipImage")));
            this.ribbonButtonGrabPoints.ToolTipTitle = "Highlight grab points";
            this.ribbonButtonGrabPoints.Click += new System.EventHandler(this.ribbonButtonGrabPoints_Click);
            // 
            // ribbonButtonContinuosSelection
            // 
            this.ribbonButtonContinuosSelection.CheckOnClick = true;
            this.ribbonButtonContinuosSelection.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonContinuosSelection.Image")));
            this.ribbonButtonContinuosSelection.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonContinuosSelection.LargeImage")));
            this.ribbonButtonContinuosSelection.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonButtonContinuosSelection.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButtonContinuosSelection.Name = "ribbonButtonContinuosSelection";
            this.ribbonButtonContinuosSelection.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonContinuosSelection.SmallImage")));
            this.ribbonButtonContinuosSelection.Text = "Continuous selection";
            this.ribbonButtonContinuosSelection.ToolTip = "Sets whether the entities selection is continuous on click";
            this.ribbonButtonContinuosSelection.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonContinuosSelection.ToolTipImage")));
            this.ribbonButtonContinuosSelection.ToolTipTitle = "Continuous selection";
            this.ribbonButtonContinuosSelection.Click += new System.EventHandler(this.ribbonButtonContinuosSelection_Click);
            // 
            // ribbonUpDownPickBoxSize
            // 
            this.ribbonUpDownPickBoxSize.AllowTextEdit = false;
            this.ribbonUpDownPickBoxSize.Image = ((System.Drawing.Image)(resources.GetObject("ribbonUpDownPickBoxSize.Image")));
            this.ribbonUpDownPickBoxSize.Name = "ribbonUpDownPickBoxSize";
            this.ribbonUpDownPickBoxSize.Text = "Pickbox size";
            this.ribbonUpDownPickBoxSize.TextBoxText = "";
            this.ribbonUpDownPickBoxSize.TextBoxWidth = 50;
            this.ribbonUpDownPickBoxSize.ToolTip = "Set the pickbox size of cursor";
            this.ribbonUpDownPickBoxSize.ToolTipTitle = "Pickbox Size";
            this.ribbonUpDownPickBoxSize.Value = "3";
            this.ribbonUpDownPickBoxSize.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPickBoxSize_UpButtonClicked);
            this.ribbonUpDownPickBoxSize.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPickBoxSize_DownButtonClicked);
            // 
            // ribbonUpDownRubberPenWidth
            // 
            this.ribbonUpDownRubberPenWidth.AllowTextEdit = false;
            this.ribbonUpDownRubberPenWidth.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Large;
            this.ribbonUpDownRubberPenWidth.MinSizeMode = System.Windows.Forms.RibbonElementSizeMode.Medium;
            this.ribbonUpDownRubberPenWidth.Name = "ribbonUpDownRubberPenWidth";
            this.ribbonUpDownRubberPenWidth.Text = "Rubber band pen width";
            this.ribbonUpDownRubberPenWidth.TextBoxText = "";
            this.ribbonUpDownRubberPenWidth.TextBoxWidth = 50;
            this.ribbonUpDownRubberPenWidth.ToolTip = "Sets the rubber band pen width when solid";
            this.ribbonUpDownRubberPenWidth.ToolTipTitle = "Rubber band pen width";
            this.ribbonUpDownRubberPenWidth.Value = "0";
            this.ribbonUpDownRubberPenWidth.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownRubberPenWidth_UpButtonClicked);
            this.ribbonUpDownRubberPenWidth.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownRubberPenWidth_DownButtonClicked);
            // 
            // ribbonUpDownZoomFactor
            // 
            this.ribbonUpDownZoomFactor.Name = "ribbonUpDownZoomFactor";
            this.ribbonUpDownZoomFactor.Text = "Zoom factor %";
            this.ribbonUpDownZoomFactor.TextBoxText = "";
            this.ribbonUpDownZoomFactor.TextBoxWidth = 50;
            this.ribbonUpDownZoomFactor.ToolTip = "Sets the zoom factor % when zooming in and out";
            this.ribbonUpDownZoomFactor.ToolTipTitle = "Zoom factor";
            this.ribbonUpDownZoomFactor.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownZoomFactor_UpButtonClicked);
            this.ribbonUpDownZoomFactor.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownZoomFactor_DownButtonClicked);
            // 
            // ribbonPanelPlotSettings
            // 
            this.ribbonPanelPlotSettings.ButtonMoreVisible = false;
            this.ribbonPanelPlotSettings.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanelPlotSettings.Image")));
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonComboBoxPlotMode);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonComboBoxPlotRendering);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonComboBoxPlotRotation);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonComboBoxPlotUnits);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonTextBoxPlotOriginX);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonTextBoxPlotOriginY);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonSeparator12);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonLabel2);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonUpDownPlotMarginTop);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonUpDownPlotMarginLeft);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonLabel4);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonUpDownPlotMarginBottom);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonUpDownPlotMarginRight);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonSeparator11);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonTextBoxPlotScale);
            this.ribbonPanelPlotSettings.Items.Add(this.ribbonUpDownPlotPenWidth);
            this.ribbonPanelPlotSettings.Name = "ribbonPanelPlotSettings";
            this.ribbonPanelPlotSettings.Text = "Plot settings";
            // 
            // ribbonComboBoxPlotMode
            // 
            this.ribbonComboBoxPlotMode.AllowTextEdit = false;
            this.ribbonComboBoxPlotMode.DropDownItems.Add(this.ribbonButtonPlotModeDisplay);
            this.ribbonComboBoxPlotMode.DropDownItems.Add(this.ribbonButtonPlotModeExtents);
            this.ribbonComboBoxPlotMode.DropDownItems.Add(this.ribbonButtonPlotModeLimits);
            this.ribbonComboBoxPlotMode.DropDownItems.Add(this.ribbonButtonPlotModeWindow);
            this.ribbonComboBoxPlotMode.DropDownItems.Add(this.ribbonButtonPlotModeCentered);
            this.ribbonComboBoxPlotMode.LabelWidth = 60;
            this.ribbonComboBoxPlotMode.Name = "ribbonComboBoxPlotMode";
            this.ribbonComboBoxPlotMode.Text = "Plot mode";
            this.ribbonComboBoxPlotMode.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxPlotMode.TextBoxText = "";
            this.ribbonComboBoxPlotMode.TextBoxWidth = 80;
            this.ribbonComboBoxPlotMode.ToolTip = "Sets the current plotting mode";
            this.ribbonComboBoxPlotMode.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxPlotMode.ToolTipImage")));
            this.ribbonComboBoxPlotMode.ToolTipTitle = "Plot mode";
            // 
            // ribbonButtonPlotModeDisplay
            // 
            this.ribbonButtonPlotModeDisplay.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeDisplay.Image")));
            this.ribbonButtonPlotModeDisplay.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeDisplay.LargeImage")));
            this.ribbonButtonPlotModeDisplay.Name = "ribbonButtonPlotModeDisplay";
            this.ribbonButtonPlotModeDisplay.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeDisplay.SmallImage")));
            this.ribbonButtonPlotModeDisplay.Text = "Display";
            this.ribbonButtonPlotModeDisplay.Click += new System.EventHandler(this.ribbonButtonPlotModeDisplay_Click);
            // 
            // ribbonButtonPlotModeExtents
            // 
            this.ribbonButtonPlotModeExtents.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeExtents.Image")));
            this.ribbonButtonPlotModeExtents.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeExtents.LargeImage")));
            this.ribbonButtonPlotModeExtents.Name = "ribbonButtonPlotModeExtents";
            this.ribbonButtonPlotModeExtents.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeExtents.SmallImage")));
            this.ribbonButtonPlotModeExtents.Text = "Extents";
            this.ribbonButtonPlotModeExtents.Click += new System.EventHandler(this.ribbonButtonPlotModeExtents_Click);
            // 
            // ribbonButtonPlotModeLimits
            // 
            this.ribbonButtonPlotModeLimits.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeLimits.Image")));
            this.ribbonButtonPlotModeLimits.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeLimits.LargeImage")));
            this.ribbonButtonPlotModeLimits.Name = "ribbonButtonPlotModeLimits";
            this.ribbonButtonPlotModeLimits.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeLimits.SmallImage")));
            this.ribbonButtonPlotModeLimits.Text = "Limits";
            this.ribbonButtonPlotModeLimits.Click += new System.EventHandler(this.ribbonButtonPlotModeLimits_Click);
            // 
            // ribbonButtonPlotModeWindow
            // 
            this.ribbonButtonPlotModeWindow.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeWindow.Image")));
            this.ribbonButtonPlotModeWindow.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeWindow.LargeImage")));
            this.ribbonButtonPlotModeWindow.Name = "ribbonButtonPlotModeWindow";
            this.ribbonButtonPlotModeWindow.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeWindow.SmallImage")));
            this.ribbonButtonPlotModeWindow.Text = "Window";
            this.ribbonButtonPlotModeWindow.Click += new System.EventHandler(this.ribbonButtonPlotModeWindow_Click);
            // 
            // ribbonButtonPlotModeCentered
            // 
            this.ribbonButtonPlotModeCentered.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeCentered.Image")));
            this.ribbonButtonPlotModeCentered.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeCentered.LargeImage")));
            this.ribbonButtonPlotModeCentered.Name = "ribbonButtonPlotModeCentered";
            this.ribbonButtonPlotModeCentered.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotModeCentered.SmallImage")));
            this.ribbonButtonPlotModeCentered.Text = "Centered";
            this.ribbonButtonPlotModeCentered.Click += new System.EventHandler(this.ribbonButtonPlotModeCentered_Click);
            // 
            // ribbonComboBoxPlotRendering
            // 
            this.ribbonComboBoxPlotRendering.DropDownItems.Add(this.ribbonButtonPlotRenderingGrayScale);
            this.ribbonComboBoxPlotRendering.DropDownItems.Add(this.ribbonButtonPlotRenderingMonochrome);
            this.ribbonComboBoxPlotRendering.DropDownItems.Add(this.ribbonButtonPlotRenderingColor);
            this.ribbonComboBoxPlotRendering.LabelWidth = 60;
            this.ribbonComboBoxPlotRendering.Name = "ribbonComboBoxPlotRendering";
            this.ribbonComboBoxPlotRendering.Text = "Rendering";
            this.ribbonComboBoxPlotRendering.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxPlotRendering.TextBoxText = "";
            this.ribbonComboBoxPlotRendering.TextBoxWidth = 80;
            this.ribbonComboBoxPlotRendering.ToolTip = "Sets the rendering modes on color/bw printers";
            this.ribbonComboBoxPlotRendering.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxPlotRendering.ToolTipImage")));
            this.ribbonComboBoxPlotRendering.ToolTipTitle = "Plot rendering";
            // 
            // ribbonButtonPlotRenderingGrayScale
            // 
            this.ribbonButtonPlotRenderingGrayScale.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingGrayScale.Image")));
            this.ribbonButtonPlotRenderingGrayScale.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingGrayScale.LargeImage")));
            this.ribbonButtonPlotRenderingGrayScale.Name = "ribbonButtonPlotRenderingGrayScale";
            this.ribbonButtonPlotRenderingGrayScale.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingGrayScale.SmallImage")));
            this.ribbonButtonPlotRenderingGrayScale.Text = "GrayScale";
            this.ribbonButtonPlotRenderingGrayScale.Click += new System.EventHandler(this.ribbonButtonPlotRenderingGrayScale_Click);
            // 
            // ribbonButtonPlotRenderingMonochrome
            // 
            this.ribbonButtonPlotRenderingMonochrome.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingMonochrome.Image")));
            this.ribbonButtonPlotRenderingMonochrome.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingMonochrome.LargeImage")));
            this.ribbonButtonPlotRenderingMonochrome.Name = "ribbonButtonPlotRenderingMonochrome";
            this.ribbonButtonPlotRenderingMonochrome.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingMonochrome.SmallImage")));
            this.ribbonButtonPlotRenderingMonochrome.Text = "Monochrome";
            this.ribbonButtonPlotRenderingMonochrome.Click += new System.EventHandler(this.ribbonButtonPlotRenderingMonochrome_Click);
            // 
            // ribbonButtonPlotRenderingColor
            // 
            this.ribbonButtonPlotRenderingColor.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingColor.Image")));
            this.ribbonButtonPlotRenderingColor.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingColor.LargeImage")));
            this.ribbonButtonPlotRenderingColor.Name = "ribbonButtonPlotRenderingColor";
            this.ribbonButtonPlotRenderingColor.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRenderingColor.SmallImage")));
            this.ribbonButtonPlotRenderingColor.Text = "Color";
            this.ribbonButtonPlotRenderingColor.Click += new System.EventHandler(this.ribbonButtonPlotRenderingColor_Click);
            // 
            // ribbonComboBoxPlotRotation
            // 
            this.ribbonComboBoxPlotRotation.DropDownItems.Add(this.ribbonButtonPlotRotationPortrait);
            this.ribbonComboBoxPlotRotation.DropDownItems.Add(this.ribbonButtonPlotRotationLandscape);
            this.ribbonComboBoxPlotRotation.LabelWidth = 60;
            this.ribbonComboBoxPlotRotation.Name = "ribbonComboBoxPlotRotation";
            this.ribbonComboBoxPlotRotation.Text = "Rotation";
            this.ribbonComboBoxPlotRotation.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxPlotRotation.TextBoxText = "";
            this.ribbonComboBoxPlotRotation.TextBoxWidth = 80;
            this.ribbonComboBoxPlotRotation.ToolTip = "Sets the orientation of the plotted drawing";
            this.ribbonComboBoxPlotRotation.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxPlotRotation.ToolTipImage")));
            this.ribbonComboBoxPlotRotation.ToolTipTitle = "Plot rotation";
            // 
            // ribbonButtonPlotRotationPortrait
            // 
            this.ribbonButtonPlotRotationPortrait.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRotationPortrait.Image")));
            this.ribbonButtonPlotRotationPortrait.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRotationPortrait.LargeImage")));
            this.ribbonButtonPlotRotationPortrait.Name = "ribbonButtonPlotRotationPortrait";
            this.ribbonButtonPlotRotationPortrait.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRotationPortrait.SmallImage")));
            this.ribbonButtonPlotRotationPortrait.Text = "Portrait";
            this.ribbonButtonPlotRotationPortrait.Click += new System.EventHandler(this.ribbonButtonPlotRotationPortrait_Click);
            // 
            // ribbonButtonPlotRotationLandscape
            // 
            this.ribbonButtonPlotRotationLandscape.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRotationLandscape.Image")));
            this.ribbonButtonPlotRotationLandscape.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRotationLandscape.LargeImage")));
            this.ribbonButtonPlotRotationLandscape.Name = "ribbonButtonPlotRotationLandscape";
            this.ribbonButtonPlotRotationLandscape.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotRotationLandscape.SmallImage")));
            this.ribbonButtonPlotRotationLandscape.Text = "Landscape";
            this.ribbonButtonPlotRotationLandscape.Click += new System.EventHandler(this.ribbonButtonPlotRotationLandscape_Click);
            // 
            // ribbonComboBoxPlotUnits
            // 
            this.ribbonComboBoxPlotUnits.DropDownItems.Add(this.ribbonButtonPlotUnitsMillimeters);
            this.ribbonComboBoxPlotUnits.DropDownItems.Add(this.ribbonButtonPlotUnitsInchs);
            this.ribbonComboBoxPlotUnits.LabelWidth = 60;
            this.ribbonComboBoxPlotUnits.Name = "ribbonComboBoxPlotUnits";
            this.ribbonComboBoxPlotUnits.Text = "Units";
            this.ribbonComboBoxPlotUnits.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonComboBoxPlotUnits.TextBoxText = "";
            this.ribbonComboBoxPlotUnits.TextBoxWidth = 90;
            this.ribbonComboBoxPlotUnits.ToolTip = "Sets the current plotting units";
            this.ribbonComboBoxPlotUnits.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBoxPlotUnits.ToolTipImage")));
            this.ribbonComboBoxPlotUnits.ToolTipTitle = "Plot units";
            // 
            // ribbonButtonPlotUnitsMillimeters
            // 
            this.ribbonButtonPlotUnitsMillimeters.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotUnitsMillimeters.Image")));
            this.ribbonButtonPlotUnitsMillimeters.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotUnitsMillimeters.LargeImage")));
            this.ribbonButtonPlotUnitsMillimeters.Name = "ribbonButtonPlotUnitsMillimeters";
            this.ribbonButtonPlotUnitsMillimeters.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotUnitsMillimeters.SmallImage")));
            this.ribbonButtonPlotUnitsMillimeters.Text = "Millimeters";
            this.ribbonButtonPlotUnitsMillimeters.Click += new System.EventHandler(this.ribbonButtonPlotUnitsMillimeters_Click);
            // 
            // ribbonButtonPlotUnitsInchs
            // 
            this.ribbonButtonPlotUnitsInchs.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotUnitsInchs.Image")));
            this.ribbonButtonPlotUnitsInchs.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotUnitsInchs.LargeImage")));
            this.ribbonButtonPlotUnitsInchs.Name = "ribbonButtonPlotUnitsInchs";
            this.ribbonButtonPlotUnitsInchs.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButtonPlotUnitsInchs.SmallImage")));
            this.ribbonButtonPlotUnitsInchs.Text = "Inchs";
            this.ribbonButtonPlotUnitsInchs.Click += new System.EventHandler(this.ribbonButtonPlotUnitsInchs_Click);
            // 
            // ribbonTextBoxPlotOriginX
            // 
            this.ribbonTextBoxPlotOriginX.LabelWidth = 60;
            this.ribbonTextBoxPlotOriginX.Name = "ribbonTextBoxPlotOriginX";
            this.ribbonTextBoxPlotOriginX.Text = "Offset X";
            this.ribbonTextBoxPlotOriginX.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonTextBoxPlotOriginX.TextBoxText = "";
            this.ribbonTextBoxPlotOriginX.TextBoxWidth = 90;
            this.ribbonTextBoxPlotOriginX.ToolTip = "Sets the lower-left corner X coordinate of the plottable area";
            this.ribbonTextBoxPlotOriginX.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonTextBoxPlotOriginX.ToolTipImage")));
            this.ribbonTextBoxPlotOriginX.ToolTipTitle = "Offset X";
            this.ribbonTextBoxPlotOriginX.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonTextBoxPlotOriginX_TextBoxKeyPress);
            this.ribbonTextBoxPlotOriginX.TextBoxValidated += new System.EventHandler(this.ribbonTextBoxPlotOriginX_TextBoxValidated);
            // 
            // ribbonTextBoxPlotOriginY
            // 
            this.ribbonTextBoxPlotOriginY.LabelWidth = 60;
            this.ribbonTextBoxPlotOriginY.Name = "ribbonTextBoxPlotOriginY";
            this.ribbonTextBoxPlotOriginY.Text = "Offset Y";
            this.ribbonTextBoxPlotOriginY.TextAlignment = System.Windows.Forms.RibbonItem.RibbonItemTextAlignment.Right;
            this.ribbonTextBoxPlotOriginY.TextBoxText = "";
            this.ribbonTextBoxPlotOriginY.TextBoxWidth = 90;
            this.ribbonTextBoxPlotOriginY.ToolTip = "Sets the lower-left corner Y coordinate of the plottable area";
            this.ribbonTextBoxPlotOriginY.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonTextBoxPlotOriginY.ToolTipImage")));
            this.ribbonTextBoxPlotOriginY.ToolTipTitle = "Offset Y";
            this.ribbonTextBoxPlotOriginY.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonTextBoxPlotOriginY_TextBoxKeyPress);
            this.ribbonTextBoxPlotOriginY.TextBoxValidated += new System.EventHandler(this.ribbonTextBoxPlotOriginY_TextBoxValidated);
            // 
            // ribbonSeparator12
            // 
            this.ribbonSeparator12.Name = "ribbonSeparator12";
            // 
            // ribbonLabel2
            // 
            this.ribbonLabel2.Name = "ribbonLabel2";
            this.ribbonLabel2.Text = "Margins";
            // 
            // ribbonUpDownPlotMarginTop
            // 
            this.ribbonUpDownPlotMarginTop.LabelWidth = 40;
            this.ribbonUpDownPlotMarginTop.Name = "ribbonUpDownPlotMarginTop";
            this.ribbonUpDownPlotMarginTop.Text = "Top";
            this.ribbonUpDownPlotMarginTop.TextBoxText = "";
            this.ribbonUpDownPlotMarginTop.TextBoxWidth = 30;
            this.ribbonUpDownPlotMarginTop.ToolTip = "Sets the top margin of the plotting page";
            this.ribbonUpDownPlotMarginTop.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonUpDownPlotMarginTop.ToolTipImage")));
            this.ribbonUpDownPlotMarginTop.ToolTipTitle = "Plot margin top";
            this.ribbonUpDownPlotMarginTop.Value = "";
            this.ribbonUpDownPlotMarginTop.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginTop_UpButtonClicked);
            this.ribbonUpDownPlotMarginTop.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginTop_DownButtonClicked);
            this.ribbonUpDownPlotMarginTop.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonUpDownPlotMarginTop_TextBoxKeyPress);
            this.ribbonUpDownPlotMarginTop.TextBoxValidated += new System.EventHandler(this.ribbonUpDownPlotMarginTop_TextBoxValidated);
            // 
            // ribbonUpDownPlotMarginLeft
            // 
            this.ribbonUpDownPlotMarginLeft.LabelWidth = 40;
            this.ribbonUpDownPlotMarginLeft.Name = "ribbonUpDownPlotMarginLeft";
            this.ribbonUpDownPlotMarginLeft.Text = "Left";
            this.ribbonUpDownPlotMarginLeft.TextBoxText = "";
            this.ribbonUpDownPlotMarginLeft.TextBoxWidth = 30;
            this.ribbonUpDownPlotMarginLeft.ToolTip = "Sets the left margin of the plotting page";
            this.ribbonUpDownPlotMarginLeft.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonUpDownPlotMarginLeft.ToolTipImage")));
            this.ribbonUpDownPlotMarginLeft.ToolTipTitle = "Plot margin left";
            this.ribbonUpDownPlotMarginLeft.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginLeft_UpButtonClicked);
            this.ribbonUpDownPlotMarginLeft.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginLeft_DownButtonClicked);
            this.ribbonUpDownPlotMarginLeft.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonUpDownPlotMarginLeft_TextBoxKeyPress);
            this.ribbonUpDownPlotMarginLeft.TextBoxValidated += new System.EventHandler(this.ribbonUpDownPlotMarginLeft_TextBoxValidated);
            // 
            // ribbonLabel4
            // 
            this.ribbonLabel4.Name = "ribbonLabel4";
            this.ribbonLabel4.Text = " ";
            // 
            // ribbonUpDownPlotMarginBottom
            // 
            this.ribbonUpDownPlotMarginBottom.LabelWidth = 40;
            this.ribbonUpDownPlotMarginBottom.Name = "ribbonUpDownPlotMarginBottom";
            this.ribbonUpDownPlotMarginBottom.Text = "Bottom";
            this.ribbonUpDownPlotMarginBottom.TextBoxText = "";
            this.ribbonUpDownPlotMarginBottom.TextBoxWidth = 30;
            this.ribbonUpDownPlotMarginBottom.ToolTip = "Sets the bottom margin of the plotting page";
            this.ribbonUpDownPlotMarginBottom.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonUpDownPlotMarginBottom.ToolTipImage")));
            this.ribbonUpDownPlotMarginBottom.ToolTipTitle = "Plot margin bottom";
            this.ribbonUpDownPlotMarginBottom.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginBottom_UpButtonClicked);
            this.ribbonUpDownPlotMarginBottom.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginBottom_DownButtonClicked);
            this.ribbonUpDownPlotMarginBottom.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonUpDownPlotMarginBottom_TextBoxKeyPress);
            this.ribbonUpDownPlotMarginBottom.TextBoxValidated += new System.EventHandler(this.ribbonUpDownPlotMarginBottom_TextBoxValidated);
            // 
            // ribbonUpDownPlotMarginRight
            // 
            this.ribbonUpDownPlotMarginRight.LabelWidth = 40;
            this.ribbonUpDownPlotMarginRight.Name = "ribbonUpDownPlotMarginRight";
            this.ribbonUpDownPlotMarginRight.Text = "Right";
            this.ribbonUpDownPlotMarginRight.TextBoxText = "";
            this.ribbonUpDownPlotMarginRight.TextBoxWidth = 30;
            this.ribbonUpDownPlotMarginRight.ToolTip = "Sets the right margin of the plotting page";
            this.ribbonUpDownPlotMarginRight.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonUpDownPlotMarginRight.ToolTipImage")));
            this.ribbonUpDownPlotMarginRight.ToolTipTitle = "Plot margin right";
            this.ribbonUpDownPlotMarginRight.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginRight_UpButtonClicked);
            this.ribbonUpDownPlotMarginRight.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotMarginRight_DownButtonClicked);
            this.ribbonUpDownPlotMarginRight.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonUpDownPlotMarginRight_TextBoxKeyPress);
            this.ribbonUpDownPlotMarginRight.TextBoxValidated += new System.EventHandler(this.ribbonUpDownPlotMarginRight_TextBoxValidated);
            // 
            // ribbonSeparator11
            // 
            this.ribbonSeparator11.Name = "ribbonSeparator11";
            // 
            // ribbonTextBoxPlotScale
            // 
            this.ribbonTextBoxPlotScale.LabelWidth = 60;
            this.ribbonTextBoxPlotScale.Name = "ribbonTextBoxPlotScale";
            this.ribbonTextBoxPlotScale.Text = "Scale";
            this.ribbonTextBoxPlotScale.TextBoxText = "";
            this.ribbonTextBoxPlotScale.TextBoxWidth = 30;
            this.ribbonTextBoxPlotScale.ToolTip = "Sets the plot scale factor";
            this.ribbonTextBoxPlotScale.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonTextBoxPlotScale.ToolTipImage")));
            this.ribbonTextBoxPlotScale.ToolTipTitle = "Plot scale";
            this.ribbonTextBoxPlotScale.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonTextBoxPlotScale_TextBoxKeyPress);
            this.ribbonTextBoxPlotScale.TextBoxValidated += new System.EventHandler(this.ribbonTextBoxPlotScale_TextBoxValidated);
            // 
            // ribbonUpDownPlotPenWidth
            // 
            this.ribbonUpDownPlotPenWidth.LabelWidth = 60;
            this.ribbonUpDownPlotPenWidth.Name = "ribbonUpDownPlotPenWidth";
            this.ribbonUpDownPlotPenWidth.Text = "Pen width";
            this.ribbonUpDownPlotPenWidth.TextBoxText = "";
            this.ribbonUpDownPlotPenWidth.TextBoxWidth = 30;
            this.ribbonUpDownPlotPenWidth.ToolTip = "Sets the width (in drawing units) of the plotted lines or arcs";
            this.ribbonUpDownPlotPenWidth.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonUpDownPlotPenWidth.ToolTipImage")));
            this.ribbonUpDownPlotPenWidth.ToolTipTitle = "Plot pen width";
            this.ribbonUpDownPlotPenWidth.UpButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotPenWidth_UpButtonClicked);
            this.ribbonUpDownPlotPenWidth.DownButtonClicked += new System.Windows.Forms.MouseEventHandler(this.ribbonUpDownPlotPenWidth_DownButtonClicked);
            this.ribbonUpDownPlotPenWidth.TextBoxKeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ribbonUpDownPlotPenWidth_TextBoxKeyPress);
            this.ribbonUpDownPlotPenWidth.TextBoxValidated += new System.EventHandler(this.ribbonUpDownPlotPenWidth_TextBoxValidated);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ErrorLabel,
            this.StatusLabelGrid,
            this.StatusLabelOrtho,
            this.StatusLabelSnap,
            this.toolStripStatusLabelInfo,
            this.StatusLabelX,
            this.StatusLabelY,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 480);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.ShowItemToolTips = true;
            this.statusStrip1.Size = new System.Drawing.Size(1400, 28);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(653, 23);
            this.StatusLabel.Spring = true;
            this.StatusLabel.Text = "StatusLabel";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(60, 23);
            this.ErrorLabel.Text = "ErrorLabel";
            // 
            // StatusLabelGrid
            // 
            this.StatusLabelGrid.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StatusLabelGrid.Image = ((System.Drawing.Image)(resources.GetObject("StatusLabelGrid.Image")));
            this.StatusLabelGrid.Name = "StatusLabelGrid";
            this.StatusLabelGrid.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StatusLabelGrid.Size = new System.Drawing.Size(25, 23);
            this.StatusLabelGrid.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLabelGrid.ToolTipText = "Grid [F7]";
            this.StatusLabelGrid.Click += new System.EventHandler(this.StatusLabelGrid_Click);
            // 
            // StatusLabelOrtho
            // 
            this.StatusLabelOrtho.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StatusLabelOrtho.Image = ((System.Drawing.Image)(resources.GetObject("StatusLabelOrtho.Image")));
            this.StatusLabelOrtho.Name = "StatusLabelOrtho";
            this.StatusLabelOrtho.Padding = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.StatusLabelOrtho.Size = new System.Drawing.Size(25, 23);
            this.StatusLabelOrtho.Text = "toolStripStatusLabel1";
            this.StatusLabelOrtho.ToolTipText = "Ortho [F8]";
            this.StatusLabelOrtho.Click += new System.EventHandler(this.StatusLabelOrtho_Click);
            // 
            // StatusLabelSnap
            // 
            this.StatusLabelSnap.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.StatusLabelSnap.Image = ((System.Drawing.Image)(resources.GetObject("StatusLabelSnap.Image")));
            this.StatusLabelSnap.Name = "StatusLabelSnap";
            this.StatusLabelSnap.Size = new System.Drawing.Size(20, 23);
            this.StatusLabelSnap.Text = "toolStripStatusLabel2";
            this.StatusLabelSnap.ToolTipText = "Snap [F9]";
            this.StatusLabelSnap.Click += new System.EventHandler(this.StatusLabelSnap_Click);
            // 
            // toolStripStatusLabelInfo
            // 
            this.toolStripStatusLabelInfo.AutoSize = false;
            this.toolStripStatusLabelInfo.Name = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.Size = new System.Drawing.Size(300, 23);
            this.toolStripStatusLabelInfo.Text = "toolStripStatusLabelInfo";
            this.toolStripStatusLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StatusLabelX
            // 
            this.StatusLabelX.AutoSize = false;
            this.StatusLabelX.Name = "StatusLabelX";
            this.StatusLabelX.Size = new System.Drawing.Size(100, 23);
            this.StatusLabelX.Text = "StatusLabelX";
            this.StatusLabelX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLabelX.ToolTipText = "Cursor X coordinate";
            // 
            // StatusLabelY
            // 
            this.StatusLabelY.AutoSize = false;
            this.StatusLabelY.Name = "StatusLabelY";
            this.StatusLabelY.Size = new System.Drawing.Size(100, 23);
            this.StatusLabelY.Text = "StatusLabelY";
            this.StatusLabelY.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLabelY.ToolTipText = "Cursor Y coordinate";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 22);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // ribbonOrbRecentItem10
            // 
            this.ribbonOrbRecentItem10.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem10.Image")));
            this.ribbonOrbRecentItem10.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem10.LargeImage")));
            this.ribbonOrbRecentItem10.Name = "ribbonOrbRecentItem10";
            this.ribbonOrbRecentItem10.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem10.SmallImage")));
            this.ribbonOrbRecentItem10.Text = "ribbonOrbRecentItem10";
            // 
            // printPreviewControl1
            // 
            this.printPreviewControl1.Location = new System.Drawing.Point(606, 162);
            this.printPreviewControl1.Name = "printPreviewControl1";
            this.printPreviewControl1.Size = new System.Drawing.Size(430, 221);
            this.printPreviewControl1.TabIndex = 17;
            this.printPreviewControl1.Visible = false;
            this.printPreviewControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.printPreviewControl1_KeyDown);
            // 
            // ribbonOrbRecentItem7
            // 
            this.ribbonOrbRecentItem7.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem7.Image")));
            this.ribbonOrbRecentItem7.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem7.LargeImage")));
            this.ribbonOrbRecentItem7.Name = "ribbonOrbRecentItem7";
            this.ribbonOrbRecentItem7.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem7.SmallImage")));
            this.ribbonOrbRecentItem7.Text = "ribbonOrbRecentItem7";
            // 
            // ribbonComboBox3
            // 
            this.ribbonComboBox3.Name = "ribbonComboBox3";
            this.ribbonComboBox3.Text = "ribbonComboBox3";
            this.ribbonComboBox3.TextBoxText = "";
            // 
            // ribbonComboBox4
            // 
            this.ribbonComboBox4.AllowTextEdit = false;
            this.ribbonComboBox4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonComboBox4.Image")));
            this.ribbonComboBox4.Name = "ribbonComboBox4";
            this.ribbonComboBox4.Text = "";
            this.ribbonComboBox4.TextBoxText = "";
            this.ribbonComboBox4.ToolTip = "Provides a choice of standard rendering styles.";
            this.ribbonComboBox4.ToolTipImage = ((System.Drawing.Image)(resources.GetObject("ribbonComboBox4.ToolTipImage")));
            this.ribbonComboBox4.ToolTipTitle = "Rendering";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.LargeImage")));
            this.ribbonButton3.Name = "ribbonButton3";
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            this.ribbonButton3.Text = "Distance";
            // 
            // toolStripPlotPreview
            // 
            this.toolStripPlotPreview.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonPlot,
            this.toolStripButton1});
            this.toolStripPlotPreview.Location = new System.Drawing.Point(0, 0);
            this.toolStripPlotPreview.Name = "toolStripPlotPreview";
            this.toolStripPlotPreview.Size = new System.Drawing.Size(1400, 25);
            this.toolStripPlotPreview.TabIndex = 19;
            this.toolStripPlotPreview.Text = "toolStrip1";
            this.toolStripPlotPreview.Visible = false;
            // 
            // toolStripButtonPlot
            // 
            this.toolStripButtonPlot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonPlot.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonPlot.Image")));
            this.toolStripButtonPlot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonPlot.Name = "toolStripButtonPlot";
            this.toolStripButtonPlot.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonPlot.Text = "toolStripButtonPlot";
            this.toolStripButtonPlot.ToolTipText = "Plot";
            this.toolStripButtonPlot.Click += new System.EventHandler(this.toolStripButtonPlot_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTipText = "Close plot preview";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ribbonComboBox2
            // 
            this.ribbonComboBox2.LabelWidth = 60;
            this.ribbonComboBox2.Name = "ribbonComboBox2";
            this.ribbonComboBox2.Text = "Rendering";
            this.ribbonComboBox2.TextBoxText = "";
            this.ribbonComboBox2.TextBoxWidth = 80;
            // 
            // ribbonDescriptionMenuItem1
            // 
            this.ribbonDescriptionMenuItem1.DescriptionBounds = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ribbonDescriptionMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonDescriptionMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.Image")));
            this.ribbonDescriptionMenuItem1.LargeImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.LargeImage")));
            this.ribbonDescriptionMenuItem1.Name = "ribbonDescriptionMenuItem1";
            this.ribbonDescriptionMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonDescriptionMenuItem1.SmallImage")));
            this.ribbonDescriptionMenuItem1.Text = "ribbonDescriptionMenuItem1";
            // 
            // colorDialog1
            // 
            this.colorDialog1.FullOpen = true;
            // 
            // imageListStatusBar
            // 
            this.imageListStatusBar.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListStatusBar.ImageStream")));
            this.imageListStatusBar.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListStatusBar.Images.SetKeyName(0, "grid16Off2.png");
            this.imageListStatusBar.Images.SetKeyName(1, "grid16On.png");
            this.imageListStatusBar.Images.SetKeyName(2, "orto16Off.png");
            this.imageListStatusBar.Images.SetKeyName(3, "ortho16On.png");
            this.imageListStatusBar.Images.SetKeyName(4, "snap16Off.png");
            this.imageListStatusBar.Images.SetKeyName(5, "snap16On.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(1071, 190);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TreeView1);
            this.splitContainer1.Panel1MinSize = 0;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dxfReaderNETControl1);
            this.splitContainer1.Size = new System.Drawing.Size(302, 272);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 22;
            // 
            // TreeView1
            // 
            this.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TreeView1.Location = new System.Drawing.Point(0, 0);
            this.TreeView1.Name = "TreeView1";
            this.TreeView1.Size = new System.Drawing.Size(100, 272);
            this.TreeView1.TabIndex = 2;
            this.TreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            this.TreeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuLastCommand,
            this.toolStripSeparator1,
            this.enterToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.cancelToolStripMenuItem,
            this.toolStripSeparator2,
            this.selectEntitiesToolStripMenuItem,
            this.deleteSelectionsToolStripMenuItem,
            this.toolStripSeparator3,
            this.copyDisplayedAreaToClipboardToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(248, 176);
            this.contextMenuStrip1.Opened += new System.EventHandler(this.contextMenuStrip1_Opened);
            // 
            // menuLastCommand
            // 
            this.menuLastCommand.Name = "menuLastCommand";
            this.menuLastCommand.Size = new System.Drawing.Size(247, 22);
            this.menuLastCommand.Text = "Last command: ";
            this.menuLastCommand.Click += new System.EventHandler(this.menuLastCommand_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // enterToolStripMenuItem
            // 
            this.enterToolStripMenuItem.Name = "enterToolStripMenuItem";
            this.enterToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.enterToolStripMenuItem.Text = "Enter";
            this.enterToolStripMenuItem.Click += new System.EventHandler(this.enterToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // cancelToolStripMenuItem
            // 
            this.cancelToolStripMenuItem.Name = "cancelToolStripMenuItem";
            this.cancelToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cancelToolStripMenuItem.Text = "Cancel";
            this.cancelToolStripMenuItem.Click += new System.EventHandler(this.cancelToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // selectEntitiesToolStripMenuItem
            // 
            this.selectEntitiesToolStripMenuItem.Name = "selectEntitiesToolStripMenuItem";
            this.selectEntitiesToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.selectEntitiesToolStripMenuItem.Text = "Select entities";
            this.selectEntitiesToolStripMenuItem.Click += new System.EventHandler(this.selectEntitiesToolStripMenuItem_Click);
            // 
            // deleteSelectionsToolStripMenuItem
            // 
            this.deleteSelectionsToolStripMenuItem.Name = "deleteSelectionsToolStripMenuItem";
            this.deleteSelectionsToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.deleteSelectionsToolStripMenuItem.Text = "Delete selections";
            this.deleteSelectionsToolStripMenuItem.Click += new System.EventHandler(this.deleteSelectionsToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(244, 6);
            // 
            // copyDisplayedAreaToClipboardToolStripMenuItem
            // 
            this.copyDisplayedAreaToClipboardToolStripMenuItem.Name = "copyDisplayedAreaToClipboardToolStripMenuItem";
            this.copyDisplayedAreaToClipboardToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.copyDisplayedAreaToClipboardToolStripMenuItem.Text = "Copy displayed area to clipboard";
            this.copyDisplayedAreaToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyDisplayedAreaToClipboardToolStripMenuItem_Click);
            // 
            // panelCommands
            // 
            this.panelCommands.BackColor = System.Drawing.SystemColors.Window;
            this.panelCommands.Controls.Add(this.txtCommand);
            this.panelCommands.Controls.Add(this.labelCommands);
            this.panelCommands.Location = new System.Drawing.Point(485, 435);
            this.panelCommands.Name = "panelCommands";
            this.panelCommands.Size = new System.Drawing.Size(400, 20);
            this.panelCommands.TabIndex = 24;
            // 
            // txtCommand
            // 
            this.txtCommand.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCommand.Location = new System.Drawing.Point(101, 0);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(143, 23);
            this.txtCommand.TabIndex = 24;
            this.txtCommand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCommand_KeyDown);
            this.txtCommand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCommand_KeyPress);
            // 
            // labelCommands
            // 
            this.labelCommands.AutoSize = true;
            this.labelCommands.BackColor = System.Drawing.SystemColors.Window;
            this.labelCommands.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCommands.Location = new System.Drawing.Point(3, 0);
            this.labelCommands.Name = "labelCommands";
            this.labelCommands.Size = new System.Drawing.Size(72, 17);
            this.labelCommands.TabIndex = 22;
            this.labelCommands.Text = "Commands";
            this.labelCommands.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // dxfReaderNETControl1
            // 
            this.dxfReaderNETControl1.AutoSize = true;
            this.dxfReaderNETControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.dxfReaderNETControl1.ContinuousHighlight = false;
            this.dxfReaderNETControl1.CustomCursor = DXFReaderNET.CustomCursorType.None;
            this.dxfReaderNETControl1.Dock = System.Windows.Forms.DockStyle.Fill;
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
            dxfDocument1.DateCreated = new System.DateTime(2020, 5, 25, 10, 15, 33, 345);
            dxfDocument1.DateLastEdited = new System.DateTime(2020, 5, 25, 10, 15, 33, 345);
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
            dxfDocument1.TotalEditTime = new System.DateTime(2020, 5, 25, 0, 0, 0, 0);
            dxfDocument1.TotalEditTimeDays = 0;
            dxfDocument1.UserTimer = new System.DateTime(2020, 5, 25, 0, 0, 0, 0);
            dxfDocument1.UserTimerDays = 0;
            this.dxfReaderNETControl1.DXF = dxfDocument1;
            this.dxfReaderNETControl1.FileName = null;
            this.dxfReaderNETControl1.HighlightEntityOnHover = true;
            this.dxfReaderNETControl1.HighlightGrabPoints = false;
            this.dxfReaderNETControl1.HighlightGrabPointsColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(163)))), ((int)(((byte)(0)))));
            this.dxfReaderNETControl1.HighlightMarkerColor2 = System.Drawing.Color.Magenta;
            this.dxfReaderNETControl1.HighlightNotContinuous = false;
            this.dxfReaderNETControl1.Location = new System.Drawing.Point(0, 0);
            this.dxfReaderNETControl1.Margin = new System.Windows.Forms.Padding(4);
            this.dxfReaderNETControl1.Name = "dxfReaderNETControl1";
            this.dxfReaderNETControl1.ShowAxes = false;
            this.dxfReaderNETControl1.ShowGridRuler = false;
            this.dxfReaderNETControl1.Size = new System.Drawing.Size(198, 272);
            this.dxfReaderNETControl1.TabIndex = 19;
            this.dxfReaderNETControl1.Error += new System.EventHandler<DXFReaderNET.ErrorEventArgs>(this.dxfReaderNETControl1_Error);
            this.dxfReaderNETControl1.StartRead += new System.EventHandler<DXFReaderNET.StartReadEventArgs>(this.dxfReaderNETControl1_StartRead);
            this.dxfReaderNETControl1.ReadStatus += new System.EventHandler<DXFReaderNET.ReadStatusEventArgs>(this.dxfReaderNETControl1_ReadStatus);
            this.dxfReaderNETControl1.EndRead += new System.EventHandler<DXFReaderNET.EndReadEventArgs>(this.dxfReaderNETControl1_EndRead);
            this.dxfReaderNETControl1.StartWrite += new System.EventHandler<DXFReaderNET.StartWriteEventArgs>(this.dxfReaderNETControl1_StartWrite);
            this.dxfReaderNETControl1.WriteStatus += new System.EventHandler<DXFReaderNET.WriteStatusEventArgs>(this.dxfReaderNETControl1_WriteStatus);
            this.dxfReaderNETControl1.EndWrite += new System.EventHandler<DXFReaderNET.EndWriteEventArgs>(this.dxfReaderNETControl1_EndWrite);
            this.dxfReaderNETControl1.StartDrawing += new System.EventHandler<DXFReaderNET.StartDrawingEventArgs>(this.dxfReaderNETControl1_StartDrawing);
            this.dxfReaderNETControl1.DrawingStatus += new System.EventHandler<DXFReaderNET.DrawingStatusEventArgs>(this.dxfReaderNETControl1_DrawingStatus);
            this.dxfReaderNETControl1.EndDrawing += new System.EventHandler<DXFReaderNET.EndDrawingEventArgs>(this.dxfReaderNETControl1_EndDrawing);
            this.dxfReaderNETControl1.StartPlot += new System.EventHandler<DXFReaderNET.StartPlotEventArgs>(this.dxfReaderNETControl1_StartPlot);
            this.dxfReaderNETControl1.PlotStatus += new System.EventHandler<DXFReaderNET.PlotStatusEventArgs>(this.dxfReaderNETControl1_PlotStatus);
            this.dxfReaderNETControl1.EndPlot += new System.EventHandler<DXFReaderNET.EndPlotEventArgs>(this.dxfReaderNETControl1_EndPlot);
            this.dxfReaderNETControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dxfReaderNETControl1_MouseDown);
            this.dxfReaderNETControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dxfReaderNETControl1_MouseMove);
            this.dxfReaderNETControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dxfReaderNETControl1_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 508);
            this.Controls.Add(this.panelCommands);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.printPreviewControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ribbon1);
            this.Controls.Add(this.toolStripPlotPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "DXFReader.NET Component - Demo Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStripPlotPreview.ResumeLayout(false);
            this.toolStripPlotPreview.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panelCommands.ResumeLayout(false);
            this.panelCommands.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTabHome;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelInfo;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelX;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelY;
        private System.Windows.Forms.RibbonPanel ribbonPanelNavigate;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomLimits;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomExtents;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomIn;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomOut;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomWindow;
        private System.Windows.Forms.RibbonButton ribbonButton10;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomPrev;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomNext;
        private System.Windows.Forms.RibbonTab ribbonTabFormat;
        private System.Windows.Forms.RibbonPanel ribbonPanelColors;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator4;
        private System.Windows.Forms.RibbonButton ribbonButtonLightColorScheme;
        private System.Windows.Forms.RibbonButton ribbonButtonDefaultColorScheme;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelGrid;

        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemNew;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemOpen;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemSave;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemSaveAs;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButtonExit;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator5;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemPlotPreview;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemPlot;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem10;
        private System.Windows.Forms.PrintPreviewControl printPreviewControl1;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem7;
        private System.Windows.Forms.RibbonButton ribbonButtonOpen;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomExt;
        private System.Windows.Forms.RibbonButton ribbonButtonArc;
        private System.Windows.Forms.RibbonButton ribbonButtonArcCenterStartEnd;
        private System.Windows.Forms.RibbonButton ribbonButtonArcStartMiddleEnd;
        private System.Windows.Forms.RibbonPanel ribbonPanelObjectSnap;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapEndpoint;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapMidpoint;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapQuadrant;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapPerpendicular;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapTangent;
        private System.Windows.Forms.RibbonButton ribbonButton28;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapInsertion;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapNearest;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapNode;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapCenter;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapIntersection;
        private System.Windows.Forms.RibbonButton ribbonButtonSave;
        private System.Windows.Forms.RibbonButton ribbonButtonUndo;
        private System.Windows.Forms.RibbonButton ribbonButtonNew;
        private System.Windows.Forms.RibbonPanel ribbonPanelAspect;
        private System.Windows.Forms.RibbonButton ribbonButtonShowAxes;
        private System.Windows.Forms.RibbonButton ribbonButtonShowBasepoint;
        private System.Windows.Forms.RibbonButton ribbonButtonShowLimits;
        private System.Windows.Forms.RibbonButton ribbonButtonAntialias;
        private System.Windows.Forms.RibbonPanel ribbonPanelDraw;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawLine;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawLineSingle;
        private System.Windows.Forms.RibbonButton ribbonButton29;
        private System.Windows.Forms.RibbonButton ribbonButton30;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawLineContinous;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator13;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawLineRay;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawContructionLine;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolyline;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolylineLwPolyline;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolylinePolyline;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator14;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolylineRectangle;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolylinePolygon;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawCircle;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawCircleRadius;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawCircle2Points;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawCircle3Points;
        private System.Windows.Forms.RibbonPanel ribbonPanelProperites;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxLayers;
        private System.Windows.Forms.RibbonButton ribbonButton1;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawLineTrace;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator15;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolylineSolid;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator16;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPolylineSpline;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxLineTypes;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawHatch;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawHatchNormal;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawHatchGradient;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawBlock;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawImageImage;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawImagePDF;
        private System.Windows.Forms.RibbonPanel ribbonPanelView;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox3D;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DTop;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DBottom;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DLeft;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DRight;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DFront;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DBack;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DSW;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DSE;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DNE;
        private System.Windows.Forms.RibbonButton ribbonButtonView3DNW;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox3;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxViews;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox4;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxRendering;
        private System.Windows.Forms.RibbonButton ribbonButtonRenderingWireframe;
        private System.Windows.Forms.RibbonButton ribbonButtonRenderingShaded;
        private System.Windows.Forms.RibbonButton ribbonButtonRenderingShadedEdges;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroupCurrentColor;
        private System.Windows.Forms.RibbonLabel ribbonLabel3;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserColor;
        private System.Windows.Forms.RibbonLabel ribbonLabel1;
        private System.Windows.Forms.RibbonLabel ribbonLabelCurrentColor;
        private System.Windows.Forms.RibbonPanel ribbonPanelInquiryMeasure;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasure;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasureDistance;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasureArea;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryEntityInfo;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryTest;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator6;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawPoint;
        private System.Windows.Forms.RibbonPanel ribbonPanelDrawMethods;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsLine;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsCircle;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodstext;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsPoint;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsArc;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsImage;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsPolygon;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsFill;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsStore;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsPenWidth;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClear;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserDrawMethodsColor;
        private System.Windows.Forms.RibbonPanel ribbonPanelModify;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelect;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelectSinlge;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelectRectangle;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelectAll;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator7;
        private System.Windows.Forms.RibbonButton ribbonButtonModyfiSelectClear;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyDelete;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyDeleteSelected;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyDeleteNotSelected;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator8;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyDeleteHandle;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyDeleteButHandle;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyCopy;
        private System.Windows.Forms.RibbonButton ribbonButtonModidyCopyCopy;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyCopyMove;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyCopyRotate;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemImport;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItemExport;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator9;
        private System.Windows.Forms.RibbonButton ribbonButtonSaveAs;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelectSingleMulti;
        private System.Windows.Forms.RibbonButton ribbonButtonGridRuler;
        private System.Windows.Forms.RibbonButton ribbonButtonViewRefresh;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasurePoly;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasureRadius;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasurecenter;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplode;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodePoly;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeInsert;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeSpline;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeCircle;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeArc;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeEllipse;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyLines2Poly;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyOffset;
        private System.Windows.Forms.RibbonPanel ribbonPanelHelp;
        private System.Windows.Forms.RibbonButton ribbonButtonHelpRegister;
        private System.Windows.Forms.RibbonButton ribbonButtonHelpAbout;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyBlock;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawInsertBlock;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyRotate;
        private System.Windows.Forms.RibbonButton ribbonButtonShowgrid;
        private System.Windows.Forms.RibbonPanel ribbonPanelAnnotations;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsText;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimension;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAligned;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAlignedStartEnd;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAlignedLine;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionLinear;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionLinearStartEnd;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionLinearLine;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAngular;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAngular2Lines;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAngularArc;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionAngular3points;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionDiameter;
        private System.Windows.Forms.RibbonButton ribbonButtonAnnotationsDimensionradius;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxDimensionStyle;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox1;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxTextStyle;
        private System.Windows.Forms.RibbonButton ribbonButtonPropertiesUnits;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearPoints;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonButton ribbonButton7;
        private System.Windows.Forms.RibbonButton ribbonButton8;
        private System.Windows.Forms.RibbonButton ribbonButton9;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearLines;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearCircles;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearArcs;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearPolygons;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearTexts;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawMethodsClearImages;
        private System.Windows.Forms.RibbonTextBox ribbonTextBoxElevation;
        private System.Windows.Forms.RibbonTextBox ribbonTextBoxThickness;
        private System.Windows.Forms.RibbonTextBox ribbonTextBoxLtScale;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodeSplineSingle;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodeSplineRectangle;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotPreview;
        private System.Windows.Forms.ToolStrip toolStripPlotPreview;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButtonPlot;
        private System.Windows.Forms.RibbonPanel ribbonPanelPlotSettings;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxPlotMode;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotModeDisplay;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotModeExtents;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotModeLimits;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotModeWindow;
       
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxPlotRendering;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxPlotRotation;
        private System.Windows.Forms.RibbonComboBox ribbonComboBox2;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxPlotUnits;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotRenderingGrayScale;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotRenderingMonochrome;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotRenderingColor;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotRotationPortrait;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotRotationLandscape;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotUnitsMillimeters;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotUnitsInchs;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownPlotMarginTop;
        private System.Windows.Forms.RibbonLabel ribbonLabel2;
        private System.Windows.Forms.RibbonDescriptionMenuItem ribbonDescriptionMenuItem1;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownPlotMarginLeft;
        private System.Windows.Forms.RibbonLabel ribbonLabel4;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownPlotMarginBottom;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownPlotMarginRight;
        private System.Windows.Forms.RibbonTextBox ribbonTextBoxPlotOriginX;
        private System.Windows.Forms.RibbonTextBox ribbonTextBoxPlotOriginY;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator12;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator11;
        private System.Windows.Forms.RibbonTextBox ribbonTextBoxPlotScale;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownPlotPenWidth;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyCopyScale;
        private System.Windows.Forms.RibbonButton ribbonButton1SaveTest;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ImageList imageListStatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelOrtho;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelSnap;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup1;
        private System.Windows.Forms.RibbonLabel ribbonLabel6;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserForeColor;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup2;
        private System.Windows.Forms.RibbonLabel ribbonLabel5;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserBackColor;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup3;
        private System.Windows.Forms.RibbonLabel ribbonLabel7;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserGrid;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup4;
        private System.Windows.Forms.RibbonLabel ribbonLabel8;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserAxisX;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup5;
        private System.Windows.Forms.RibbonLabel ribbonLabel9;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserAxisY;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup6;
        private System.Windows.Forms.RibbonLabel ribbonLabel10;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserAxisZ;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup7;
        private System.Windows.Forms.RibbonLabel ribbonLabel11;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserHighlight;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup8;
        private System.Windows.Forms.RibbonLabel ribbonLabel12;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserHighlightMarker;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup9;
        private System.Windows.Forms.RibbonLabel ribbonLabel13;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserHighlightMarker2;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup10;
        private System.Windows.Forms.RibbonLabel ribbonLabel14;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserAxes;
        private System.Windows.Forms.RibbonItemGroup ribbonItemGroup11;
        private System.Windows.Forms.RibbonLabel ribbonLabel15;
        private System.Windows.Forms.RibbonColorChooser ribbonColorChooserRubberBand;
        private System.Windows.Forms.RibbonComboBox ribbonComboBoxLayout;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawEllipse;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawHatchPatterns;
        private System.Windows.Forms.RibbonButton ribbonButtonCommandLine;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyProperties;
        private System.Windows.Forms.RibbonButton ribbonButtonModPropColor;
        private System.Windows.Forms.RibbonButton ribbonButtonModPropLayer;
        private System.Windows.Forms.RibbonButton ribbonButtonModPropLineType;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryXdata;
        private System.Windows.Forms.RibbonButton ribbonButtonModPropGroup;
        private System.Windows.Forms.RibbonButton ribbonButtonGroupAdd;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelectGroup;
        private System.Windows.Forms.RibbonButton ribbonButtonModifySelectHandle;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeRegion;
        private System.Windows.Forms.RibbonButton ribbonButtonModyfiSelectShow;
        private System.Windows.Forms.RibbonButton ribbonButtonPointInPolygon;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownPickBoxSize;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator10;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyRemoveBlocks;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyTrim;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExtend;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyFillet;
        private System.Windows.Forms.RibbonComboBox ribbonButtonRubberBandStyle;
        private System.Windows.Forms.RibbonButton ribbonButtonRubberBandStyleDashed;
        private System.Windows.Forms.RibbonButton ribbonButtonRubberBandStyleSolid;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawingLimits;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownRubberPenWidth;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasureAreaSelected;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyArray;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyArrayPolar;
        private System.Windows.Forms.RibbonButton ribbonButtonShowFilledAreas;
        private System.Windows.Forms.RibbonButton ribbonButtonModElev;
        private System.Windows.Forms.RibbonButton ribbonButtonHighlight;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator17;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteSelectedEntities;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyJoin;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteEntitiesByColor;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteEntitiesByLayer;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyChamfer;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator18;
        private System.Windows.Forms.RibbonButton ribbonButtonDrawSlot;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyUngroup;
        private System.Windows.Forms.RibbonButton ribbonButtonPrintEntityProp;
        private System.Windows.Forms.RibbonButton ribbonButtonPrintEntitiesList;
        private System.Windows.Forms.RibbonButton ribbonButtonArcStartEndMiddle;
        private System.Windows.Forms.RibbonUpDown ribbonUpDownZoomFactor;
        private System.Windows.Forms.RibbonButton ribbonButtonCheckContHighligh;
        private System.Windows.Forms.RibbonButton ribbonButton11;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator19;
        private System.Windows.Forms.RibbonButton ribbonButtonTables;
        private System.Windows.Forms.RibbonButton ribbonButtonTablesLTYPE;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal DXFReaderNET.DXFReaderNETControl dxfReaderNETControl1;
        internal System.Windows.Forms.TreeView TreeView1;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteEntitiesByLineType;
        private System.Windows.Forms.RibbonButton ribbonButtonInquiryMeasureFilledEmpty;
        private System.Windows.Forms.RibbonButton ribbonButton12;
        private System.Windows.Forms.RibbonButton ribbonButton13;
        private System.Windows.Forms.RibbonButton ribbonButton14;
        private System.Windows.Forms.RibbonButton ribbonButton15;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator20;
        private System.Windows.Forms.RibbonButton ribbonButtonLines2PolyB;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator21;
        private System.Windows.Forms.RibbonButton ribbonButtonSelectContours;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeDimension;
        private System.Windows.Forms.RibbonButton ribbonButtonOrbit3D;
        private System.Windows.Forms.RibbonButton ribbonButtonShowExtents;
        private System.Windows.Forms.RibbonButton ribbonButtonShowData;
        private System.Windows.Forms.RibbonButton ribbonButtonZoomCenter;
        private System.Windows.Forms.RibbonButton ribbonButtonRedo;
        private System.Windows.Forms.ToolStripStatusLabel ErrorLabel;
        private System.Windows.Forms.RibbonButton ribbonButtonMultiLine;
        private System.Windows.Forms.RibbonButton ribbonButtonNormalize;
        private System.Windows.Forms.RibbonButton ribbonButtonShowSelectedEntitiesInfo;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodePolySingle;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodePolyRect;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteCoincident;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator22;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodeInserSingle;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodeInsertRect;
        private System.Windows.Forms.RibbonButton ribbonButtonGridInsideLimits;
        private System.Windows.Forms.RibbonButton ribbonButtonTruTOPS;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteNotConnected;
        private System.Windows.Forms.RibbonButton ribbonDrawingInfo;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuLastCommand;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem enterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelToolStripMenuItem;
        private System.Windows.Forms.RibbonButton ribbonButtonGrabPoints;
        private System.Windows.Forms.RibbonButton ribbonButtonArcCenterStartPEndP;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapGeometricCenter;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapSelectAll;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectSnapClear;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyLw2Poly;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyPoly2Lw;
        private System.Windows.Forms.RibbonButton ribbonButtonTablesLayers;
        private System.Windows.Forms.RibbonButton ribbonButtonModVisibility;
        private System.Windows.Forms.RibbonButton ribbonButtonModVisibilityOff;
        private System.Windows.Forms.RibbonButton ribbonButtonModVisibilityOn;
        private System.Windows.Forms.RibbonButton ribbonButtonSelectGroup;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteZeroLen;
        private System.Windows.Forms.RibbonButton ribbonButtonObjects;
        private System.Windows.Forms.RibbonButton ribbonButtonDeleteGroup;
        private System.Windows.Forms.RibbonButton ribbonButtonTablesDimStyles;
        private System.Windows.Forms.RibbonButton ribbonButtonTablesTextStyles;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem selectEntitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem copyDisplayedAreaToClipboardToolStripMenuItem;
        private System.Windows.Forms.RibbonButton ribbonButtonSplitSections;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RibbonButton ribbonButtonObjectByHandle;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeEllipseArcs;
        private System.Windows.Forms.RibbonButton ribbonButtonLeader;
        private System.Windows.Forms.RibbonButton ribbonButtonModifyExplodeCircleArcs;
        private System.Windows.Forms.RibbonButton ribbonButtonPlotModeCentered;
        private System.Windows.Forms.RibbonButton ribbonButtonPropertiesLayers;
        private System.Windows.Forms.RibbonButton ribbonButtonPropertiesDimStyles;
        private System.Windows.Forms.RibbonButton ribbonButtonViewTreeView;
        private System.Windows.Forms.RibbonButton ribbonButtonContinuosSelection;
        private System.Windows.Forms.RibbonButton ribbonButtonSelectExtCont;
        private System.Windows.Forms.RibbonButton ribbonButtonSelectNumber;
        private System.Windows.Forms.RibbonButton ribbonButtonAllButSelected;
        private System.Windows.Forms.RibbonButton ribbonButtonModPropLineWeight;
        private System.Windows.Forms.RibbonButton ribbonButtonRecoverDXFFIle;
        private System.Windows.Forms.RibbonButton ribbonButtonJoinTwoEntities;
        private System.Windows.Forms.RibbonButton ribbonButtonAutoJoinWindow;
        private System.Windows.Forms.RibbonButton ribbonButtonAutoJoinAll;
        private System.Windows.Forms.Panel panelCommands;
        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.Label labelCommands;
        private System.Windows.Forms.RibbonButton ribbonButtonExplodeInsertAll;
    }
}

