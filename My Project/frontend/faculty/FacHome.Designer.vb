<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FacHome
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BtnSched = New System.Windows.Forms.Button()
        Me.BtnLO = New System.Windows.Forms.Button()
        Me.BtnGrd = New System.Windows.Forms.Button()
        Me.BtnPrf = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSubjs = New System.Windows.Forms.Button()
        Me.BtnClass = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnSched)
        Me.Panel1.Controls.Add(Me.BtnLO)
        Me.Panel1.Controls.Add(Me.BtnClass)
        Me.Panel1.Controls.Add(Me.BtnGrd)
        Me.Panel1.Controls.Add(Me.BtnSubjs)
        Me.Panel1.Controls.Add(Me.BtnPrf)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(228, 805)
        Me.Panel1.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.enrollment_sys.My.Resources.Resources.logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 227)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'BtnSched
        '
        Me.BtnSched.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnSched.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSched.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSched.ForeColor = System.Drawing.Color.White
        Me.BtnSched.Location = New System.Drawing.Point(0, 575)
        Me.BtnSched.Name = "BtnSched"
        Me.BtnSched.Size = New System.Drawing.Size(228, 60)
        Me.BtnSched.TabIndex = 5
        Me.BtnSched.Text = "SCHEDULES"
        Me.BtnSched.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSched.UseVisualStyleBackColor = False
        '
        'BtnLO
        '
        Me.BtnLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLO.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLO.ForeColor = System.Drawing.Color.White
        Me.BtnLO.Location = New System.Drawing.Point(0, 745)
        Me.BtnLO.Name = "BtnLO"
        Me.BtnLO.Size = New System.Drawing.Size(228, 60)
        Me.BtnLO.TabIndex = 4
        Me.BtnLO.Text = "LOGOUT"
        Me.BtnLO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLO.UseVisualStyleBackColor = False
        '
        'BtnGrd
        '
        Me.BtnGrd.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnGrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnGrd.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGrd.ForeColor = System.Drawing.Color.White
        Me.BtnGrd.Location = New System.Drawing.Point(0, 398)
        Me.BtnGrd.Name = "BtnGrd"
        Me.BtnGrd.Size = New System.Drawing.Size(228, 60)
        Me.BtnGrd.TabIndex = 1
        Me.BtnGrd.Text = "ENCODE GRADES"
        Me.BtnGrd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnGrd.UseVisualStyleBackColor = False
        '
        'BtnPrf
        '
        Me.BtnPrf.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnPrf.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrf.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrf.ForeColor = System.Drawing.Color.White
        Me.BtnPrf.Location = New System.Drawing.Point(0, 339)
        Me.BtnPrf.Name = "BtnPrf"
        Me.BtnPrf.Size = New System.Drawing.Size(228, 60)
        Me.BtnPrf.TabIndex = 0
        Me.BtnPrf.Text = "PROFILE"
        Me.BtnPrf.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnPrf.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(228, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1209, 805)
        Me.Panel2.TabIndex = 2
        '
        'BtnSubjs
        '
        Me.BtnSubjs.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnSubjs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubjs.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubjs.ForeColor = System.Drawing.Color.White
        Me.BtnSubjs.Location = New System.Drawing.Point(0, 516)
        Me.BtnSubjs.Name = "BtnSubjs"
        Me.BtnSubjs.Size = New System.Drawing.Size(228, 60)
        Me.BtnSubjs.TabIndex = 1
        Me.BtnSubjs.Text = "SUBJECTS"
        Me.BtnSubjs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSubjs.UseVisualStyleBackColor = False
        '
        'BtnClass
        '
        Me.BtnClass.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClass.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClass.ForeColor = System.Drawing.Color.White
        Me.BtnClass.Location = New System.Drawing.Point(0, 457)
        Me.BtnClass.Name = "BtnClass"
        Me.BtnClass.Size = New System.Drawing.Size(228, 60)
        Me.BtnClass.TabIndex = 2
        Me.BtnClass.Text = "CLASS LIST"
        Me.BtnClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClass.UseVisualStyleBackColor = False
        '
        'FacHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1437, 805)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FacHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSched As Button
    Friend WithEvents BtnLO As Button
    Friend WithEvents BtnGrd As Button
    Friend WithEvents BtnPrf As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnClass As Button
    Friend WithEvents BtnSubjs As Button
End Class
