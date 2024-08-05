<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tmc1 = New Microsoft.Research.CommunityTechnologies.Treemap.TreemapControl()
        Me.cmdConnect = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tmc1
        '
        Me.tmc1.AllowDrag = False
        Me.tmc1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tmc1.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.tmc1.DiscreteNegativeColors = 20
        Me.tmc1.DiscretePositiveColors = 20
        Me.tmc1.EmptySpaceLocation = Microsoft.Research.CommunityTechnologies.Treemap.EmptySpaceLocation.DeterminedByLayoutAlgorithm
        Me.tmc1.FontFamily = "Arial"
        Me.tmc1.FontSolidColor = System.Drawing.SystemColors.WindowText
        Me.tmc1.IsZoomable = False
        Me.tmc1.LayoutAlgorithm = Microsoft.Research.CommunityTechnologies.Treemap.LayoutAlgorithm.BottomWeightedSquarified
        Me.tmc1.Location = New System.Drawing.Point(12, 48)
        Me.tmc1.MaxColor = System.Drawing.Color.Green
        Me.tmc1.MaxColorMetric = 100.0!
        Me.tmc1.MinColor = System.Drawing.Color.Red
        Me.tmc1.MinColorMetric = -100.0!
        Me.tmc1.Name = "tmc1"
        Me.tmc1.NodeColorAlgorithm = Microsoft.Research.CommunityTechnologies.Treemap.NodeColorAlgorithm.UseColorMetric
        Me.tmc1.NodeLevelsWithText = Microsoft.Research.CommunityTechnologies.Treemap.NodeLevelsWithText.All
        Me.tmc1.PaddingDecrementPerLevelPx = 1
        Me.tmc1.PaddingPx = 5
        Me.tmc1.PenWidthDecrementPerLevelPx = 1
        Me.tmc1.PenWidthPx = 3
        Me.tmc1.SelectedBackColor = System.Drawing.SystemColors.Highlight
        Me.tmc1.SelectedFontColor = System.Drawing.SystemColors.HighlightText
        Me.tmc1.ShowToolTips = True
        Me.tmc1.Size = New System.Drawing.Size(785, 376)
        Me.tmc1.TabIndex = 0
        Me.tmc1.TextLocation = Microsoft.Research.CommunityTechnologies.Treemap.TextLocation.Top
        '
        'cmdConnect
        '
        Me.cmdConnect.Location = New System.Drawing.Point(12, 12)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.Size = New System.Drawing.Size(138, 23)
        Me.cmdConnect.TabIndex = 1
        Me.cmdConnect.Text = "Connect to Database"
        Me.cmdConnect.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 436)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.tmc1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmc1 As Microsoft.Research.CommunityTechnologies.Treemap.TreemapControl
    Friend WithEvents cmdConnect As System.Windows.Forms.Button

End Class
