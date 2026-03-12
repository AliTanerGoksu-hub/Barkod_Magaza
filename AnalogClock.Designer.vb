<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnalogClock
    Inherits System.Windows.Forms.Form
    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            lockTimerCounter += 1
            If Timer IsNot Nothing Then
                Timer.Stop()
                Timer.Dispose()
                Timer = Nothing
            End If
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
        Me.components = New System.ComponentModel.Container
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.gaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl
        Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
        Me.arcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
        Me.scaleHours = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
        Me.arcScaleEffectLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
        Me.arcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.arcScaleNeedleComponent2 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.arcScaleNeedleComponent3 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
        Me.arcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scaleHours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timer
        '
        '
        'gaugeControl1
        '
        Me.gaugeControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
        Me.gaugeControl1.Location = New System.Drawing.Point(0, 0)
        Me.gaugeControl1.Name = "gaugeControl1"
        Me.gaugeControl1.Size = New System.Drawing.Size(415, 363)
        Me.gaugeControl1.TabIndex = 0
        '
        'circularGauge1
        '
        Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.arcScaleBackgroundLayerComponent1})
        Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 403, 351)
        Me.circularGauge1.EffectLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent() {Me.arcScaleEffectLayerComponent1})
        Me.circularGauge1.Name = "circularGauge1"
        Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.arcScaleNeedleComponent1, Me.arcScaleNeedleComponent2, Me.arcScaleNeedleComponent3})
        Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.scaleHours})
        Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.arcScaleSpindleCapComponent1})
        '
        'arcScaleBackgroundLayerComponent1
        '
        Me.arcScaleBackgroundLayerComponent1.ArcScale = Me.scaleHours
        Me.arcScaleBackgroundLayerComponent1.Name = "arcScaleBackgroundLayerComponent1"
        Me.arcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularFull_Clock
        Me.arcScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'scaleHours
        '
        Me.scaleHours.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 11.0!)
        Me.scaleHours.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Black")
        Me.scaleHours.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 125.0!)
        Me.scaleHours.EndAngle = 270.0!
        Me.scaleHours.MajorTickCount = 13
        Me.scaleHours.MajorTickmark.FormatString = "{0:F0}"
        Me.scaleHours.MajorTickmark.ShapeOffset = -4.0!
        Me.scaleHours.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_2
        Me.scaleHours.MajorTickmark.ShowFirst = False
        Me.scaleHours.MajorTickmark.TextOffset = -15.0!
        Me.scaleHours.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.scaleHours.MaxValue = 12.0!
        Me.scaleHours.MinorTickCount = 4
        Me.scaleHours.MinorTickmark.ShapeOffset = -0.5!
        Me.scaleHours.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style10_1
        Me.scaleHours.Name = "arcScaleComponent1"
        Me.scaleHours.RadiusX = 90.0!
        Me.scaleHours.RadiusY = 90.0!
        Me.scaleHours.Shader = New DevExpress.XtraGauges.Core.Drawing.StyleShader("Colors[Style1:#404040;Style2:Gray]")
        Me.scaleHours.StartAngle = -90.0!
        '
        'arcScaleEffectLayerComponent1
        '
        Me.arcScaleEffectLayerComponent1.ArcScale = Me.scaleHours
        Me.arcScaleEffectLayerComponent1.Name = "arcScaleEffectLayerComponent1"
        Me.arcScaleEffectLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 1.0!)
        Me.arcScaleEffectLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.EffectLayerShapeType.CircularFull_Clock
        Me.arcScaleEffectLayerComponent1.Size = New System.Drawing.SizeF(210.0!, 105.0!)
        Me.arcScaleEffectLayerComponent1.ZOrder = -1000
        '
        'arcScaleNeedleComponent1
        '
        Me.arcScaleNeedleComponent1.ArcScale = Me.scaleHours
        Me.arcScaleNeedleComponent1.EndOffset = 20.0!
        Me.arcScaleNeedleComponent1.Name = "arcScaleNeedleComponent1"
        Me.arcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockHour
        Me.arcScaleNeedleComponent1.ZOrder = -50
        '
        'arcScaleNeedleComponent2
        '
        Me.arcScaleNeedleComponent2.ArcScale = Me.scaleHours
        Me.arcScaleNeedleComponent2.Name = "arcScaleNeedleComponent2"
        Me.arcScaleNeedleComponent2.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockMinute
        Me.arcScaleNeedleComponent2.ZOrder = -49
        '
        'arcScaleNeedleComponent3
        '
        Me.arcScaleNeedleComponent3.ArcScale = Me.scaleHours
        Me.arcScaleNeedleComponent3.EndOffset = -10.0!
        Me.arcScaleNeedleComponent3.Name = "arcScaleNeedleComponent3"
        Me.arcScaleNeedleComponent3.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_ClockSecond
        Me.arcScaleNeedleComponent3.ZOrder = -101
        '
        'arcScaleSpindleCapComponent1
        '
        Me.arcScaleSpindleCapComponent1.ArcScale = Me.scaleHours
        Me.arcScaleSpindleCapComponent1.Name = "arcScaleSpindleCapComponent1"
        Me.arcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Clock
        Me.arcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(20.0!, 20.0!)
        Me.arcScaleSpindleCapComponent1.ZOrder = -100
        '
        'AnalogClock
        '
        Me.ClientSize = New System.Drawing.Size(415, 363)
        Me.Controls.Add(Me.gaugeControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "AnalogClock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scaleHours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleEffectLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleNeedleComponent3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.arcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Private gaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Private circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private arcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private scaleHours As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private arcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private arcScaleNeedleComponent2 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private arcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Private arcScaleEffectLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleEffectLayerComponent
    Private arcScaleNeedleComponent3 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
End Class
