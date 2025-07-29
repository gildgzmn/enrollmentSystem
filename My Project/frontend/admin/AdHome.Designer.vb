<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdHome
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
        Me.BtnSbj = New System.Windows.Forms.Button()
        Me.BtnLO = New System.Windows.Forms.Button()
        Me.BtnFac = New System.Windows.Forms.Button()
        Me.BtnEnr = New System.Windows.Forms.Button()
        Me.BtnStd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.BtnSbj)
        Me.Panel1.Controls.Add(Me.BtnLO)
        Me.Panel1.Controls.Add(Me.BtnFac)
        Me.Panel1.Controls.Add(Me.BtnEnr)
        Me.Panel1.Controls.Add(Me.BtnStd)
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
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'BtnSbj
        '
        Me.BtnSbj.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnSbj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSbj.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSbj.ForeColor = System.Drawing.Color.White
        Me.BtnSbj.Location = New System.Drawing.Point(0, 523)
        Me.BtnSbj.Name = "BtnSbj"
        Me.BtnSbj.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnSbj.Size = New System.Drawing.Size(228, 60)
        Me.BtnSbj.TabIndex = 7
        Me.BtnSbj.Text = "SUBJECTS"
        Me.BtnSbj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnSbj.UseVisualStyleBackColor = False
        '
        'BtnLO
        '
        Me.BtnLO.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnLO.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLO.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLO.ForeColor = System.Drawing.Color.White
        Me.BtnLO.Location = New System.Drawing.Point(0, 745)
        Me.BtnLO.Name = "BtnLO"
        Me.BtnLO.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnLO.Size = New System.Drawing.Size(228, 60)
        Me.BtnLO.TabIndex = 4
        Me.BtnLO.Text = "LOGOUT"
        Me.BtnLO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnLO.UseVisualStyleBackColor = False
        '
        'BtnFac
        '
        Me.BtnFac.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnFac.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnFac.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnFac.ForeColor = System.Drawing.Color.White
        Me.BtnFac.Location = New System.Drawing.Point(0, 465)
        Me.BtnFac.Name = "BtnFac"
        Me.BtnFac.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnFac.Size = New System.Drawing.Size(228, 60)
        Me.BtnFac.TabIndex = 1
        Me.BtnFac.Text = "FACULTY"
        Me.BtnFac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnFac.UseVisualStyleBackColor = False
        '
        'BtnEnr
        '
        Me.BtnEnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnEnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnr.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnr.ForeColor = System.Drawing.Color.White
        Me.BtnEnr.Location = New System.Drawing.Point(0, 348)
        Me.BtnEnr.Name = "BtnEnr"
        Me.BtnEnr.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnEnr.Size = New System.Drawing.Size(228, 60)
        Me.BtnEnr.TabIndex = 1
        Me.BtnEnr.Text = "ENROLL STUDENT"
        Me.BtnEnr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnEnr.UseVisualStyleBackColor = False
        '
        'BtnStd
        '
        Me.BtnStd.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnStd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStd.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStd.ForeColor = System.Drawing.Color.White
        Me.BtnStd.Location = New System.Drawing.Point(0, 407)
        Me.BtnStd.Name = "BtnStd"
        Me.BtnStd.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.BtnStd.Size = New System.Drawing.Size(228, 60)
        Me.BtnStd.TabIndex = 0
        Me.BtnStd.Text = "STUDENTS"
        Me.BtnStd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnStd.UseVisualStyleBackColor = False
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
        'AdHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1437, 805)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Home"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnLO As Button
    Friend WithEvents BtnFac As Button
    Friend WithEvents BtnEnr As Button
    Friend WithEvents BtnStd As Button
    Friend WithEvents BtnSbj As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class
