<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnDot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLine = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblX = New System.Windows.Forms.Label()
        Me.lblY = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnOpen = New System.Windows.Forms.ToolStripButton()
        Me.tsbtnSave = New System.Windows.Forms.ToolStripButton()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(29, 74)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(40, 23)
        Me.btnDot.TabIndex = 1
        Me.btnDot.Text = "Dot"
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tools"
        '
        'btnLine
        '
        Me.btnLine.Location = New System.Drawing.Point(29, 103)
        Me.btnLine.Name = "btnLine"
        Me.btnLine.Size = New System.Drawing.Size(40, 23)
        Me.btnLine.TabIndex = 3
        Me.btnLine.Text = "Line"
        Me.btnLine.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.Location = New System.Drawing.Point(98, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(640, 400)
        Me.PictureBox1.TabIndex = 13
        Me.PictureBox1.TabStop = False
        '
        'lblX
        '
        Me.lblX.AutoSize = True
        Me.lblX.Location = New System.Drawing.Point(118, 444)
        Me.lblX.Name = "lblX"
        Me.lblX.Size = New System.Drawing.Size(13, 13)
        Me.lblX.TabIndex = 18
        Me.lblX.Text = "0"
        '
        'lblY
        '
        Me.lblY.AutoSize = True
        Me.lblY.Location = New System.Drawing.Point(184, 444)
        Me.lblY.Name = "lblY"
        Me.lblY.Size = New System.Drawing.Size(13, 13)
        Me.lblY.TabIndex = 19
        Me.lblY.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 444)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "X: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(158, 444)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Y: "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(654, 439)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 22
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(29, 160)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(40, 23)
        Me.btnColor.TabIndex = 23
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnOpen, Me.tsbtnSave})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 26
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnOpen
        '
        Me.tsbtnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnOpen.Image = CType(resources.GetObject("tsbtnOpen.Image"), System.Drawing.Image)
        Me.tsbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnOpen.Name = "tsbtnOpen"
        Me.tsbtnOpen.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnOpen.Text = "ToolStripButton1"
        '
        'tsbtnSave
        '
        Me.tsbtnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbtnSave.Image = CType(resources.GetObject("tsbtnSave.Image"), System.Drawing.Image)
        Me.tsbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnSave.Name = "tsbtnSave"
        Me.tsbtnSave.Size = New System.Drawing.Size(23, 22)
        Me.tsbtnSave.Text = "ToolStripButton2"
        '
        'cmbSize
        '
        Me.cmbSize.DisplayMember = "1"
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbSize.Location = New System.Drawing.Point(62, 133)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(30, 21)
        Me.cmbSize.TabIndex = 27
        Me.cmbSize.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(26, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Size:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 479)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblY)
        Me.Controls.Add(Me.lblX)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnLine)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDot)
        Me.Name = "Form1"
        Me.Text = "Draw Tools"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLine As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblX As Label
    Friend WithEvents lblY As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents btnColor As Button
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbtnOpen As ToolStripButton
    Friend WithEvents tsbtnSave As ToolStripButton
    Friend WithEvents cmbSize As ComboBox
    Friend WithEvents Label8 As Label
End Class
