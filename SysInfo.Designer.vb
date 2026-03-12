<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SysInfo
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Dim notifyEvent As System.Threading.WaitHandle = New System.Threading.EventWaitHandle(False, System.Threading.EventResetMode.AutoReset)
        System.Threading.Interlocked.Add(lockTimerCounter, 1)
        If pollingTimer IsNot Nothing Then
            pollingTimer.Change(System.Threading.Timeout.Infinite, System.Threading.Timeout.Infinite)
            pollingTimer.Dispose(notifyEvent)
            pollingTimer = Nothing
        End If
        System.Threading.WaitHandle.WaitAll(New System.Threading.WaitHandle() {notifyEvent})
        If wmiService IsNot Nothing Then
            wmiService.Dispose()
            wmiService = Nothing
        End If
        MyBase.Dispose(disposing)
    End Sub
    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer
    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ScaleLabel1 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel2 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel3 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel4 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel5 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel6 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel7 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel8 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim ScaleLabel9 As DevExpress.XtraGauges.Core.Model.ScaleLabel = New DevExpress.XtraGauges.Core.Model.ScaleLabel
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SysInfo))
        Me.xtraScrollableControl1 = New DevExpress.XtraEditors.XtraScrollableControl
        Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl
        Me.updateSpeed = New DevExpress.XtraEditors.TrackBarControl
        Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
        Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.arcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.arcScaleBackgroundLayerComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.arcScaleComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.arcScaleBackgroundLayerComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.arcScaleComponent6 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.arcScaleBackgroundLayerComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.arcScaleComponent7 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.labelComponent1 = New DevExpress.XtraGauges.Win.Base.LabelComponent
        Me.labelComponent2 = New DevExpress.XtraGauges.Win.Base.LabelComponent
        Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.arcScaleRangeBarComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
        Me.arcScaleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.arcScaleRangeBarComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
        Me.arcScaleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.arcScaleRangeBarComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
        Me.arcScaleRangeBarComponent4 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
        Me.arcScaleComponent5 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup
        Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem
        Me.emptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem
        Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem
        Me.xtraScrollableControl1.SuspendLayout()
        CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.layoutControl1.SuspendLayout()
        CType(Me.updateSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updateSpeed.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.labelComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleRangeBarComponent4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'xtraScrollableControl1
        '
        Me.xtraScrollableControl1.Controls.Add(Me.layoutControl1)
        Me.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.xtraScrollableControl1.Location = New System.Drawing.Point(0, 0)
        Me.xtraScrollableControl1.Name = "xtraScrollableControl1"
        Me.xtraScrollableControl1.Padding = New System.Windows.Forms.Padding(0, 8, 0, 12)
        Me.xtraScrollableControl1.Size = New System.Drawing.Size(536, 583)
        Me.xtraScrollableControl1.TabIndex = 0
        '
        'layoutControl1
        '
        Me.layoutControl1.Controls.Add(Me.updateSpeed)
        Me.layoutControl1.Controls.Add(Me.gaugeControl1)
        Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.layoutControl1.Location = New System.Drawing.Point(0, 8)
        Me.layoutControl1.Name = "layoutControl1"
        Me.layoutControl1.Root = Me.layoutControlGroup1
        Me.layoutControl1.Size = New System.Drawing.Size(536, 563)
        Me.layoutControl1.TabIndex = 1
        Me.layoutControl1.Text = "layoutControl1"
        '
        'updateSpeed
        '
        Me.updateSpeed.EditValue = Nothing
        Me.updateSpeed.Location = New System.Drawing.Point(338, 530)
        Me.updateSpeed.MaximumSize = New System.Drawing.Size(0, 32)
        Me.updateSpeed.MinimumSize = New System.Drawing.Size(0, 32)
        Me.updateSpeed.Name = "updateSpeed"
        Me.updateSpeed.Size = New System.Drawing.Size(197, 32)
        Me.updateSpeed.StyleController = Me.layoutControl1
        Me.updateSpeed.TabIndex = 4
        '
        'gaugeControl1
        '
        Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
        Me.gaugeControl1.Location = New System.Drawing.Point(1, 1)
        Me.gaugeControl1.Name = "gaugeControl1"
        Me.gaugeControl1.Size = New System.Drawing.Size(534, 517)
        Me.gaugeControl1.TabIndex = 0
        '
        'circularGauge1
        '
        Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1, Me.arcScaleBackgroundLayerComponent2, Me.arcScaleBackgroundLayerComponent3, Me.arcScaleBackgroundLayerComponent4})
        Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 522, 505)
        Me.circularGauge1.Labels.AddRange(New DevExpress.XtraGauges.Win.Base.LabelComponent() {Me.labelComponent1, Me.labelComponent2})
        Me.circularGauge1.Name = "circularGauge1"
        Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
        Me.circularGauge1.RangeBars.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent() {Me.arcScaleRangeBarComponent1, Me.arcScaleRangeBarComponent2, Me.arcScaleRangeBarComponent3, Me.arcScaleRangeBarComponent4})
        Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.arcScaleComponent1, Me.arcScaleComponent2, Me.arcScaleComponent3, Me.arcScaleComponent4, Me.arcScaleComponent5, Me.arcScaleComponent6, Me.arcScaleComponent7})
        '
        'arcScaleBackgroundLayerComponent1
        '
        Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.arcScaleComponent1
        Me.arcScaleBackgroundLayerComponent1.Name = "bgCPU"
        Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(122.0!, 122.0!)
        Me.arcScaleBackgroundLayerComponent1.ZOrder = -5
        '
        'arcScaleComponent1
        '
        Me.arcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        Me.arcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 75.0!)
        Me.arcScaleComponent1.EndAngle = 60.0!
        ScaleLabel1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        ScaleLabel1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel1.FormatString = "{0} {1:F0}%"
        ScaleLabel1.Name = "Label0"
        ScaleLabel1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 122.0!)
        ScaleLabel1.Size = New System.Drawing.SizeF(100.0!, 12.0!)
        ScaleLabel1.Text = "Total:"
        ScaleLabel2.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        ScaleLabel2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DimGray")
        ScaleLabel2.FormatString = "{0}"
        ScaleLabel2.Name = "Label1"
        ScaleLabel2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 95.0!)
        ScaleLabel2.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel2.Text = "Kernel"
        ScaleLabel3.AppearanceText.Font = New System.Drawing.Font("Tahoma", 5.0!)
        ScaleLabel3.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:DarkGray")
        ScaleLabel3.FormatString = "{0}"
        ScaleLabel3.Name = "Label2"
        ScaleLabel3.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 88.0!)
        ScaleLabel3.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel3.Text = "User"
        Me.arcScaleComponent1.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel1, ScaleLabel2, ScaleLabel3})
        Me.arcScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent1.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent1.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.4!, 0.6!)
        Me.arcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent1.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent1.MaxValue = 100.0!
        Me.arcScaleComponent1.MinorTickCount = 4
        Me.arcScaleComponent1.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.5!)
        Me.arcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent1.Name = "cpuTotal"
        Me.arcScaleComponent1.RadiusX = 50.0!
        Me.arcScaleComponent1.RadiusY = 50.0!
        Me.arcScaleComponent1.StartAngle = -240.0!
        Me.arcScaleComponent1.Value = 15.0!
        Me.arcScaleComponent1.ZOrder = -50
        '
        'arcScaleBackgroundLayerComponent2
        '
        Me.arcScaleBackgroundLayerComponent2.ArcScale = Me.arcScaleComponent4
        Me.arcScaleBackgroundLayerComponent2.Name = "bgOS"
        Me.arcScaleBackgroundLayerComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent2.Size = New System.Drawing.SizeF(100.0!, 100.0!)
        Me.arcScaleBackgroundLayerComponent2.ZOrder = 1050
        '
        'arcScaleComponent4
        '
        Me.arcScaleComponent4.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        Me.arcScaleComponent4.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent4.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 175.0!)
        Me.arcScaleComponent4.EndAngle = 10.0!
        ScaleLabel4.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel4.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel4.FormatString = "{0}{1:F0}"
        ScaleLabel4.Name = "Label1"
        ScaleLabel4.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 160.0!)
        ScaleLabel4.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel4.Text = "Threads:"
        Me.arcScaleComponent4.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel4})
        Me.arcScaleComponent4.MajorTickCount = 7
        Me.arcScaleComponent4.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent4.MajorTickmark.ShapeOffset = -1.0!
        Me.arcScaleComponent4.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.25!, 0.4!)
        Me.arcScaleComponent4.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent4.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent4.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent4.MaxValue = 1300.0!
        Me.arcScaleComponent4.MinorTickCount = 4
        Me.arcScaleComponent4.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.5!)
        Me.arcScaleComponent4.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent4.MinValue = 100.0!
        Me.arcScaleComponent4.Name = "osThreads"
        Me.arcScaleComponent4.RadiusX = 40.0!
        Me.arcScaleComponent4.RadiusY = 40.0!
        Me.arcScaleComponent4.StartAngle = -190.0!
        Me.arcScaleComponent4.Value = 500.0!
        '
        'arcScaleBackgroundLayerComponent3
        '
        Me.arcScaleBackgroundLayerComponent3.ArcScale = Me.arcScaleComponent6
        Me.arcScaleBackgroundLayerComponent3.Name = "bgMemory"
        Me.arcScaleBackgroundLayerComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent3.Size = New System.Drawing.SizeF(92.0!, 92.0!)
        Me.arcScaleBackgroundLayerComponent3.ZOrder = 1000
        '
        'arcScaleComponent6
        '
        Me.arcScaleComponent6.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3.0!)
        Me.arcScaleComponent6.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent6.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(45.0!, 135.0!)
        Me.arcScaleComponent6.EndAngle = 60.0!
        ScaleLabel5.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel5.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel5.FormatString = "{0} {2:P1}"
        ScaleLabel5.Name = "Label0"
        ScaleLabel5.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(50.0!, 150.0!)
        ScaleLabel5.Size = New System.Drawing.SizeF(100.0!, 12.0!)
        ScaleLabel5.Text = "Free:"
        ScaleLabel6.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel6.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        ScaleLabel6.FormatString = "{0}"
        ScaleLabel6.Name = "Label1"
        ScaleLabel6.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(50.0!, 125.0!)
        ScaleLabel6.Text = "Memory, MB"
        Me.arcScaleComponent6.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel5, ScaleLabel6})
        Me.arcScaleComponent6.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent6.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent6.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.2!, 0.3!)
        Me.arcScaleComponent6.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent6.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent6.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent6.MaxValue = 100.0!
        Me.arcScaleComponent6.MinorTickCount = 4
        Me.arcScaleComponent6.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.15!, 0.25!)
        Me.arcScaleComponent6.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent6.Name = "memoryTotal"
        Me.arcScaleComponent6.RadiusX = 40.0!
        Me.arcScaleComponent6.RadiusY = 40.0!
        Me.arcScaleComponent6.StartAngle = -240.0!
        Me.arcScaleComponent6.Value = 15.0!
        '
        'arcScaleBackgroundLayerComponent4
        '
        Me.arcScaleBackgroundLayerComponent4.ArcScale = Me.arcScaleComponent7
        Me.arcScaleBackgroundLayerComponent4.Name = "bgHDD"
        Me.arcScaleBackgroundLayerComponent4.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Style1
        Me.arcScaleBackgroundLayerComponent4.Size = New System.Drawing.SizeF(92.0!, 92.0!)
        Me.arcScaleBackgroundLayerComponent4.ZOrder = 1000
        '
        'arcScaleComponent7
        '
        Me.arcScaleComponent7.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3.0!)
        Me.arcScaleComponent7.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent7.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 135.0!)
        Me.arcScaleComponent7.EndAngle = 60.0!
        ScaleLabel7.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel7.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel7.FormatString = "{0} {2:P1}"
        ScaleLabel7.Name = "Label0"
        ScaleLabel7.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 150.0!)
        ScaleLabel7.Size = New System.Drawing.SizeF(100.0!, 12.0!)
        ScaleLabel7.Text = "Free:"
        ScaleLabel8.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel8.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        ScaleLabel8.FormatString = "{0}"
        ScaleLabel8.Name = "Label1"
        ScaleLabel8.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(205.0!, 125.0!)
        ScaleLabel8.Text = "HDD, GB"
        Me.arcScaleComponent7.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel7, ScaleLabel8})
        Me.arcScaleComponent7.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent7.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent7.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.2!, 0.3!)
        Me.arcScaleComponent7.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_4
        Me.arcScaleComponent7.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent7.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent7.MaxValue = 100.0!
        Me.arcScaleComponent7.MinorTickCount = 4
        Me.arcScaleComponent7.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.15!, 0.25!)
        Me.arcScaleComponent7.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_3
        Me.arcScaleComponent7.Name = "hddTotal"
        Me.arcScaleComponent7.RadiusX = 40.0!
        Me.arcScaleComponent7.RadiusY = 40.0!
        Me.arcScaleComponent7.StartAngle = -240.0!
        Me.arcScaleComponent7.Value = 15.0!
        '
        'labelComponent1
        '
        Me.labelComponent1.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        Me.labelComponent1.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        Me.labelComponent1.Name = "processorName"
        Me.labelComponent1.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 62.0!)
        Me.labelComponent1.Size = New System.Drawing.SizeF(75.0!, 25.0!)
        Me.labelComponent1.Text = "CPU Info"
        Me.labelComponent1.ZOrder = -45
        '
        'labelComponent2
        '
        Me.labelComponent2.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        Me.labelComponent2.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#C00000")
        Me.labelComponent2.Name = "osName"
        Me.labelComponent2.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 175.0!)
        Me.labelComponent2.Size = New System.Drawing.SizeF(55.0!, 25.0!)
        Me.labelComponent2.Text = "OS Info"
        Me.labelComponent2.ZOrder = -2
        '
        'arcScaleNeedleComponent1
        '
        Me.arcScaleNeedleComponent1.ArcScale = Me.arcScaleComponent1
        Me.arcScaleNeedleComponent1.Name = "needleCpu"
        Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
        Me.arcScaleNeedleComponent1.StartOffset = -2.75!
        Me.arcScaleNeedleComponent1.ZOrder = -50
        '
        'arcScaleNeedleComponent2
        '
        Me.arcScaleNeedleComponent2.ArcScale = Me.arcScaleComponent6
        Me.arcScaleNeedleComponent2.Name = "needleRAM"
        Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
        Me.arcScaleNeedleComponent2.StartOffset = -2.75!
        Me.arcScaleNeedleComponent2.ZOrder = -50
        '
        'arcScaleNeedleComponent3
        '
        Me.arcScaleNeedleComponent3.ArcScale = Me.arcScaleComponent7
        Me.arcScaleNeedleComponent3.Name = "needleHDD"
        Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style1
        Me.arcScaleNeedleComponent3.StartOffset = -2.75!
        Me.arcScaleNeedleComponent3.ZOrder = -50
        '
        'arcScaleRangeBarComponent1
        '
        Me.arcScaleRangeBarComponent1.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleRangeBarComponent1.ArcScale = Me.arcScaleComponent2
        Me.arcScaleRangeBarComponent1.EndOffset = 15.0!
        Me.arcScaleRangeBarComponent1.Name = "rangeUser"
        Me.arcScaleRangeBarComponent1.StartOffset = 40.0!
        Me.arcScaleRangeBarComponent1.ZOrder = -10
        '
        'arcScaleComponent2
        '
        Me.arcScaleComponent2.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.arcScaleComponent2.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleComponent2.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 75.0!)
        Me.arcScaleComponent2.EndAngle = 60.0!
        Me.arcScaleComponent2.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent2.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent2.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 0.8!)
        Me.arcScaleComponent2.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
        Me.arcScaleComponent2.MajorTickmark.ShowText = False
        Me.arcScaleComponent2.MajorTickmark.ShowTick = False
        Me.arcScaleComponent2.MajorTickmark.TextOffset = -10.0!
        Me.arcScaleComponent2.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent2.MaxValue = 100.0!
        Me.arcScaleComponent2.MinorTickCount = 4
        Me.arcScaleComponent2.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 1.0!)
        Me.arcScaleComponent2.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
        Me.arcScaleComponent2.MinorTickmark.ShowTick = False
        Me.arcScaleComponent2.Name = "cpuUser"
        Me.arcScaleComponent2.RadiusX = 50.0!
        Me.arcScaleComponent2.RadiusY = 50.0!
        Me.arcScaleComponent2.StartAngle = -240.0!
        Me.arcScaleComponent2.Value = 15.0!
        Me.arcScaleComponent2.ZOrder = 1001
        '
        'arcScaleRangeBarComponent2
        '
        Me.arcScaleRangeBarComponent2.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Gray")
        Me.arcScaleRangeBarComponent2.ArcScale = Me.arcScaleComponent3
        Me.arcScaleRangeBarComponent2.EndOffset = 15.0!
        Me.arcScaleRangeBarComponent2.Name = "rangeKernel"
        Me.arcScaleRangeBarComponent2.StartOffset = 40.0!
        Me.arcScaleRangeBarComponent2.ZOrder = -11
        '
        'arcScaleComponent3
        '
        Me.arcScaleComponent3.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 6.0!)
        Me.arcScaleComponent3.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleComponent3.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 75.0!)
        Me.arcScaleComponent3.EndAngle = 60.0!
        Me.arcScaleComponent3.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent3.MajorTickmark.ShapeOffset = -2.0!
        Me.arcScaleComponent3.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 0.8!)
        Me.arcScaleComponent3.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_4
        Me.arcScaleComponent3.MajorTickmark.ShowText = False
        Me.arcScaleComponent3.MajorTickmark.ShowTick = False
        Me.arcScaleComponent3.MajorTickmark.TextOffset = -10.0!
        Me.arcScaleComponent3.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent3.MaxValue = 100.0!
        Me.arcScaleComponent3.MinorTickCount = 4
        Me.arcScaleComponent3.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.6!, 1.0!)
        Me.arcScaleComponent3.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_3
        Me.arcScaleComponent3.MinorTickmark.ShowTick = False
        Me.arcScaleComponent3.Name = "cpuKernel"
        Me.arcScaleComponent3.RadiusX = 50.0!
        Me.arcScaleComponent3.RadiusY = 50.0!
        Me.arcScaleComponent3.StartAngle = -240.0!
        Me.arcScaleComponent3.Value = 3.0!
        Me.arcScaleComponent3.ZOrder = 1002
        '
        'arcScaleRangeBarComponent3
        '
        Me.arcScaleRangeBarComponent3.AnchorValue = 100.0!
        Me.arcScaleRangeBarComponent3.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleRangeBarComponent3.ArcScale = Me.arcScaleComponent4
        Me.arcScaleRangeBarComponent3.EndOffset = -3.0!
        Me.arcScaleRangeBarComponent3.Name = "rangeThreads"
        Me.arcScaleRangeBarComponent3.StartOffset = 35.0!
        Me.arcScaleRangeBarComponent3.ZOrder = 1
        '
        'arcScaleRangeBarComponent4
        '
        Me.arcScaleRangeBarComponent4.AppearanceRangeBar.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Silver")
        Me.arcScaleRangeBarComponent4.ArcScale = Me.arcScaleComponent5
        Me.arcScaleRangeBarComponent4.EndOffset = -2.0!
        Me.arcScaleRangeBarComponent4.Name = "rangeProcesses"
        Me.arcScaleRangeBarComponent4.StartOffset = 35.0!
        Me.arcScaleRangeBarComponent4.ZOrder = 1
        '
        'arcScaleComponent5
        '
        Me.arcScaleComponent5.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 3.0!)
        Me.arcScaleComponent5.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.arcScaleComponent5.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 175.0!)
        Me.arcScaleComponent5.EndAngle = 150.0!
        ScaleLabel9.AppearanceText.Font = New System.Drawing.Font("Tahoma", 4.0!)
        ScaleLabel9.AppearanceText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        ScaleLabel9.FormatString = "{0}{1:F0}"
        ScaleLabel9.Name = "Label1"
        ScaleLabel9.Position = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 195.0!)
        ScaleLabel9.Size = New System.Drawing.SizeF(50.0!, 12.0!)
        ScaleLabel9.Text = "Processes:"
        Me.arcScaleComponent5.Labels.AddRange(New DevExpress.XtraGauges.Core.Model.ILabel() {ScaleLabel9})
        Me.arcScaleComponent5.MajorTickCount = 6
        Me.arcScaleComponent5.MajorTickmark.FormatString = "{0:F0}"
        Me.arcScaleComponent5.MajorTickmark.ShapeOffset = -1.0!
        Me.arcScaleComponent5.MajorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.4!)
        Me.arcScaleComponent5.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_2
        Me.arcScaleComponent5.MajorTickmark.TextOffset = -7.0!
        Me.arcScaleComponent5.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.arcScaleComponent5.MaxValue = 150.0!
        Me.arcScaleComponent5.MinorTickCount = 4
        Me.arcScaleComponent5.MinorTickmark.ShapeScale = New DevExpress.XtraGauges.Core.Base.FactorF2D(0.3!, 0.5!)
        Me.arcScaleComponent5.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style1_1
        Me.arcScaleComponent5.Name = "osProcesses"
        Me.arcScaleComponent5.RadiusX = 40.0!
        Me.arcScaleComponent5.RadiusY = 40.0!
        Me.arcScaleComponent5.StartAngle = 30.0!
        Me.arcScaleComponent5.Value = 50.0!
        '
        'layoutControlGroup1
        '
        Me.layoutControlGroup1.AllowDrawBackground = False
        Me.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1"
        Me.layoutControlGroup1.GroupBordersVisible = False
        Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.layoutControlItem1, Me.emptySpaceItem1, Me.layoutControlItem2})
        Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlGroup1.Name = "layoutControlGroup1"
        Me.layoutControlGroup1.Size = New System.Drawing.Size(536, 563)
        Me.layoutControlGroup1.Text = "layoutControlGroup1"
        Me.layoutControlGroup1.TextVisible = False
        '
        'layoutControlItem1
        '
        Me.layoutControlItem1.Control = Me.gaugeControl1
        Me.layoutControlItem1.CustomizationFormText = "layoutControlItem1"
        Me.layoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.layoutControlItem1.Name = "layoutControlItem1"
        Me.layoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1)
        Me.layoutControlItem1.Size = New System.Drawing.Size(536, 519)
        Me.layoutControlItem1.Text = "layoutControlItem1"
        Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.layoutControlItem1.TextToControlDistance = 0
        Me.layoutControlItem1.TextVisible = False
        '
        'emptySpaceItem1
        '
        Me.emptySpaceItem1.AllowHotTrack = False
        Me.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1"
        Me.emptySpaceItem1.Location = New System.Drawing.Point(0, 519)
        Me.emptySpaceItem1.Name = "emptySpaceItem1"
        Me.emptySpaceItem1.Size = New System.Drawing.Size(268, 44)
        Me.emptySpaceItem1.Text = "emptySpaceItem1"
        Me.emptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'layoutControlItem2
        '
        Me.layoutControlItem2.Control = Me.updateSpeed
        Me.layoutControlItem2.CustomizationFormText = "Update Speed:"
        Me.layoutControlItem2.Location = New System.Drawing.Point(268, 519)
        Me.layoutControlItem2.Name = "layoutControlItem2"
        Me.layoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(1, 1, 11, 1)
        Me.layoutControlItem2.Size = New System.Drawing.Size(268, 44)
        Me.layoutControlItem2.Text = "Yenileme Hızı:"
        Me.layoutControlItem2.TextSize = New System.Drawing.Size(65, 13)
        '
        'SysInfo
        '
        Me.ClientSize = New System.Drawing.Size(536, 583)
        Me.Controls.Add(Me.xtraScrollableControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SysInfo"
        Me.xtraScrollableControl1.ResumeLayout(False)
        CType(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.layoutControl1.ResumeLayout(False)
        CType(Me.updateSpeed.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updateSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.labelComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleRangeBarComponent4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleComponent5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.emptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
    Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Private emptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Private WithEvents updateSpeed As DevExpress.XtraEditors.TrackBarControl
    Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private arcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private arcScaleBackgroundLayerComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private arcScaleComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private arcScaleBackgroundLayerComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private arcScaleComponent6 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private arcScaleBackgroundLayerComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private arcScaleComponent7 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private labelComponent1 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private labelComponent2 As DevExpress.XtraGauges.Win.Base.LabelComponent
    Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private arcScaleRangeBarComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private arcScaleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private arcScaleRangeBarComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private arcScaleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private arcScaleRangeBarComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private arcScaleRangeBarComponent4 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleRangeBarComponent
    Private arcScaleComponent5 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private xtraScrollableControl1 As DevExpress.XtraEditors.XtraScrollableControl
End Class
