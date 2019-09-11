<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form8
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form8))
        Me.exit_cancel = New System.Windows.Forms.PictureBox()
        Me.exit_ok = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.input_password = New System.Windows.Forms.TextBox()
        CType(Me.exit_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exit_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exit_cancel
        '
        Me.exit_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_cancel.Image = CType(resources.GetObject("exit_cancel.Image"), System.Drawing.Image)
        Me.exit_cancel.Location = New System.Drawing.Point(115, 111)
        Me.exit_cancel.Name = "exit_cancel"
        Me.exit_cancel.Size = New System.Drawing.Size(115, 31)
        Me.exit_cancel.TabIndex = 35
        Me.exit_cancel.TabStop = False
        '
        'exit_ok
        '
        Me.exit_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.exit_ok.Image = CType(resources.GetObject("exit_ok.Image"), System.Drawing.Image)
        Me.exit_ok.Location = New System.Drawing.Point(271, 111)
        Me.exit_ok.Name = "exit_ok"
        Me.exit_ok.Size = New System.Drawing.Size(115, 31)
        Me.exit_ok.TabIndex = 34
        Me.exit_ok.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 21)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Please enter Admin password..."
        '
        'input_password
        '
        Me.input_password.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.input_password.Location = New System.Drawing.Point(15, 61)
        Me.input_password.Name = "input_password"
        Me.input_password.Size = New System.Drawing.Size(377, 22)
        Me.input_password.TabIndex = 32
        Me.input_password.UseSystemPasswordChar = True
        '
        'Form8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(37, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(402, 155)
        Me.Controls.Add(Me.exit_cancel)
        Me.Controls.Add(Me.exit_ok)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input_password)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(402, 155)
        Me.MinimumSize = New System.Drawing.Size(402, 155)
        Me.Name = "Form8"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autobell security check "
        CType(Me.exit_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exit_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exit_cancel As System.Windows.Forms.PictureBox
    Friend WithEvents exit_ok As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents input_password As System.Windows.Forms.TextBox
End Class
