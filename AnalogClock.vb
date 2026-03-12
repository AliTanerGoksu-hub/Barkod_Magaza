Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraGauges.Win.Gauges.Circular
Imports DevExpress.XtraGauges.Core.Model
Public Class AnalogClock
    Private WithEvents timer As System.Windows.Forms.Timer
    Private scaleMinutes, scaleSeconds As ArcScaleComponent
    Private lockTimerCounter As Integer = 0
    Public Sub New()
        InitializeComponent()
        scaleMinutes = circularGauge1.AddScale()
        scaleSeconds = circularGauge1.AddScale()
        scaleMinutes.Assign(scaleHours)
        scaleSeconds.Assign(scaleHours)
        arcScaleNeedleComponent2.ArcScale = scaleMinutes
        arcScaleNeedleComponent3.ArcScale = scaleSeconds
        timer.Start()
        OnTimerTick(Nothing, Nothing)
    End Sub
    Sub OnTimerTick(ByVal sender As Object, ByVal e As System.EventArgs) Handles timer.Tick
        If lockTimerCounter = 0 Then
            lockTimerCounter += 1
            UpdateClock(DateTime.Now, scaleHours, scaleMinutes, scaleSeconds)
            lockTimerCounter -= 1
        End If
    End Sub
    Sub UpdateClock(ByVal dt As DateTime, ByVal h As IArcScale, ByVal m As IArcScale, ByVal s As IArcScale)
        Dim hour As Integer
        If dt.Hour <= 12 Then
            hour = dt.Hour
        Else
            hour = dt.Hour - 12
        End If
        Dim min As Integer = dt.Minute
        Dim sec As Integer = dt.Second
        h.Value = CSng(hour) + CSng(min) / 60.0F
        m.Value = (CSng(min) + CSng(sec) / 60.0F) / 5.0F
        s.Value = sec / 5.0F
    End Sub
End Class