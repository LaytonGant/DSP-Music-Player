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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Pause = New System.Windows.Forms.Button()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.StopButton = New System.Windows.Forms.Button()
        Me.Play = New System.Windows.Forms.Button()
        Me.SongListBox = New System.Windows.Forms.ListBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.IndexButton = New System.Windows.Forms.Button()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pause
        '
        Me.Pause.Location = New System.Drawing.Point(220, 15)
        Me.Pause.Name = "Pause"
        Me.Pause.Size = New System.Drawing.Size(103, 32)
        Me.Pause.TabIndex = 0
        Me.Pause.Text = "Pause"
        Me.Pause.UseVisualStyleBackColor = True
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.IndexButton)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.StopButton)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Play)
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.Pause)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(803, 143)
        Me.ToolStripContainer1.Location = New System.Drawing.Point(-2, 366)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(803, 168)
        Me.ToolStripContainer1.TabIndex = 1
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        '
        'StopButton
        '
        Me.StopButton.Location = New System.Drawing.Point(477, 15)
        Me.StopButton.Name = "StopButton"
        Me.StopButton.Size = New System.Drawing.Size(93, 32)
        Me.StopButton.TabIndex = 2
        Me.StopButton.Text = "Stop"
        Me.StopButton.UseVisualStyleBackColor = True
        '
        'Play
        '
        Me.Play.Location = New System.Drawing.Point(349, 15)
        Me.Play.Name = "Play"
        Me.Play.Size = New System.Drawing.Size(104, 32)
        Me.Play.TabIndex = 1
        Me.Play.Text = "Play"
        Me.Play.UseVisualStyleBackColor = True
        '
        'SongListBox
        '
        Me.SongListBox.BackColor = System.Drawing.SystemColors.ControlText
        Me.SongListBox.FormattingEnabled = True
        Me.SongListBox.Location = New System.Drawing.Point(173, 12)
        Me.SongListBox.Name = "SongListBox"
        Me.SongListBox.Size = New System.Drawing.Size(615, 329)
        Me.SongListBox.TabIndex = 3
        '
        'IndexButton
        '
        Me.IndexButton.Location = New System.Drawing.Point(735, 15)
        Me.IndexButton.Name = "IndexButton"
        Me.IndexButton.Size = New System.Drawing.Size(55, 32)
        Me.IndexButton.TabIndex = 3
        Me.IndexButton.Text = "Index"
        Me.IndexButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SongListBox)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Name = "Form1"
        Me.Text = "Brandify"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Pause As Button
    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents StopButton As Button
    Friend WithEvents Play As Button
    Friend WithEvents SongListBox As ListBox
    Friend WithEvents IndexButton As Button
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
End Class
