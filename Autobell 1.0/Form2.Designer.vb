<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.back_cmb = New System.Windows.Forms.PictureBox()
        Me.toc_cmb = New System.Windows.Forms.PictureBox()
        Me.psb_cmb = New System.Windows.Forms.PictureBox()
        Me.psa_cmb = New System.Windows.Forms.PictureBox()
        Me.pp_cmb = New System.Windows.Forms.PictureBox()
        Me.pna_cmb = New System.Windows.Forms.PictureBox()
        Me.pag_cmb = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.player12 = New AxWMPLib.AxWindowsMediaPlayer()
        CType(Me.back_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toc_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psb_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.psa_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pp_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pna_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pag_cmb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player12, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'back_cmb
        '
        Me.back_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.back_cmb.Image = CType(resources.GetObject("back_cmb.Image"), System.Drawing.Image)
        Me.back_cmb.Location = New System.Drawing.Point(13, 16)
        Me.back_cmb.Name = "back_cmb"
        Me.back_cmb.Size = New System.Drawing.Size(36, 35)
        Me.back_cmb.TabIndex = 35
        Me.back_cmb.TabStop = False
        Me.ToolTip1.SetToolTip(Me.back_cmb, "Go back and exit from Custom mode....")
        '
        'toc_cmb
        '
        Me.toc_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.toc_cmb.Image = CType(resources.GetObject("toc_cmb.Image"), System.Drawing.Image)
        Me.toc_cmb.Location = New System.Drawing.Point(372, 234)
        Me.toc_cmb.Name = "toc_cmb"
        Me.toc_cmb.Size = New System.Drawing.Size(121, 37)
        Me.toc_cmb.TabIndex = 34
        Me.toc_cmb.TabStop = False
        '
        'psb_cmb
        '
        Me.psb_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psb_cmb.Image = CType(resources.GetObject("psb_cmb.Image"), System.Drawing.Image)
        Me.psb_cmb.Location = New System.Drawing.Point(372, 95)
        Me.psb_cmb.Name = "psb_cmb"
        Me.psb_cmb.Size = New System.Drawing.Size(121, 37)
        Me.psb_cmb.TabIndex = 33
        Me.psb_cmb.TabStop = False
        '
        'psa_cmb
        '
        Me.psa_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.psa_cmb.Image = CType(resources.GetObject("psa_cmb.Image"), System.Drawing.Image)
        Me.psa_cmb.Location = New System.Drawing.Point(196, 95)
        Me.psa_cmb.Name = "psa_cmb"
        Me.psa_cmb.Size = New System.Drawing.Size(121, 37)
        Me.psa_cmb.TabIndex = 32
        Me.psa_cmb.TabStop = False
        '
        'pp_cmb
        '
        Me.pp_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pp_cmb.Image = CType(resources.GetObject("pp_cmb.Image"), System.Drawing.Image)
        Me.pp_cmb.Location = New System.Drawing.Point(13, 95)
        Me.pp_cmb.Name = "pp_cmb"
        Me.pp_cmb.Size = New System.Drawing.Size(121, 37)
        Me.pp_cmb.TabIndex = 31
        Me.pp_cmb.TabStop = False
        '
        'pna_cmb
        '
        Me.pna_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pna_cmb.Image = CType(resources.GetObject("pna_cmb.Image"), System.Drawing.Image)
        Me.pna_cmb.Location = New System.Drawing.Point(196, 234)
        Me.pna_cmb.Name = "pna_cmb"
        Me.pna_cmb.Size = New System.Drawing.Size(121, 37)
        Me.pna_cmb.TabIndex = 30
        Me.pna_cmb.TabStop = False
        '
        'pag_cmb
        '
        Me.pag_cmb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pag_cmb.Image = CType(resources.GetObject("pag_cmb.Image"), System.Drawing.Image)
        Me.pag_cmb.Location = New System.Drawing.Point(13, 234)
        Me.pag_cmb.Name = "pag_cmb"
        Me.pag_cmb.Size = New System.Drawing.Size(121, 37)
        Me.pag_cmb.TabIndex = 29
        Me.pag_cmb.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.InitialImage = CType(resources.GetObject("PictureBox1.InitialImage"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 168)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 37)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(196, 168)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(121, 37)
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(372, 168)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(121, 37)
        Me.PictureBox3.TabIndex = 39
        Me.PictureBox3.TabStop = False
        '
        'player12
        '
        Me.player12.Enabled = True
        Me.player12.Location = New System.Drawing.Point(150, 12)
        Me.player12.Name = "player12"
        Me.player12.OcxState = CType(resources.GetObject("player12.OcxState"), System.Windows.Forms.AxHost.State)
        Me.player12.Size = New System.Drawing.Size(75, 23)
        Me.player12.TabIndex = 36
        Me.player12.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(524, 283)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.player12)
        Me.Controls.Add(Me.back_cmb)
        Me.Controls.Add(Me.toc_cmb)
        Me.Controls.Add(Me.psb_cmb)
        Me.Controls.Add(Me.psa_cmb)
        Me.Controls.Add(Me.pp_cmb)
        Me.Controls.Add(Me.pna_cmb)
        Me.Controls.Add(Me.pag_cmb)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(530, 266)
        Me.Name = "Form2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "   Custom Mode"
        CType(Me.back_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toc_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psb_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.psa_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pp_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pna_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pag_cmb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player12, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents back_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents toc_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents psb_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents psa_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents pp_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents pna_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents pag_cmb As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents player12 As AxWMPLib.AxWindowsMediaPlayer
End Class
