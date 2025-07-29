<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdEnrollStd
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnRef = New System.Windows.Forms.Button()
        Me.BtnDrop = New System.Windows.Forms.Button()
        Me.BtnEnr = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Std_Table = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Std_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.BtnRef)
        Me.Panel1.Controls.Add(Me.BtnDrop)
        Me.Panel1.Controls.Add(Me.BtnEnr)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(-3, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1278, 717)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(40, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 18)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "use this form to enroll a student..."
        '
        'BtnRef
        '
        Me.BtnRef.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnRef.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnRef.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRef.ForeColor = System.Drawing.Color.Black
        Me.BtnRef.Location = New System.Drawing.Point(1037, 189)
        Me.BtnRef.Name = "BtnRef"
        Me.BtnRef.Size = New System.Drawing.Size(100, 36)
        Me.BtnRef.TabIndex = 163
        Me.BtnRef.Text = "REFRESH"
        Me.BtnRef.UseVisualStyleBackColor = False
        '
        'BtnDrop
        '
        Me.BtnDrop.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnDrop.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnDrop.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDrop.ForeColor = System.Drawing.Color.Black
        Me.BtnDrop.Location = New System.Drawing.Point(1037, 147)
        Me.BtnDrop.Name = "BtnDrop"
        Me.BtnDrop.Size = New System.Drawing.Size(100, 36)
        Me.BtnDrop.TabIndex = 160
        Me.BtnDrop.Text = "DROP"
        Me.BtnDrop.UseVisualStyleBackColor = False
        '
        'BtnEnr
        '
        Me.BtnEnr.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnEnr.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEnr.Font = New System.Drawing.Font("Gotham", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnr.ForeColor = System.Drawing.Color.Black
        Me.BtnEnr.Location = New System.Drawing.Point(1037, 106)
        Me.BtnEnr.Name = "BtnEnr"
        Me.BtnEnr.Size = New System.Drawing.Size(100, 36)
        Me.BtnEnr.TabIndex = 159
        Me.BtnEnr.Text = "ENROLL"
        Me.BtnEnr.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(3, 1)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1275, 61)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gotham", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(33, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(466, 50)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "ENROLL STUDENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.Std_Table)
        Me.Panel3.Location = New System.Drawing.Point(38, 105)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 561)
        Me.Panel3.TabIndex = 162
        '
        'Std_Table
        '
        Me.Std_Table.AllowUserToAddRows = False
        Me.Std_Table.AllowUserToDeleteRows = False
        Me.Std_Table.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Std_Table.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Std_Table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Std_Table.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Std_Table.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Std_Table.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Std_Table.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Std_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Std_Table.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Inter", 11.25!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Std_Table.DefaultCellStyle = DataGridViewCellStyle3
        Me.Std_Table.GridColor = System.Drawing.Color.White
        Me.Std_Table.Location = New System.Drawing.Point(2, 1)
        Me.Std_Table.Name = "Std_Table"
        Me.Std_Table.ReadOnly = True
        Me.Std_Table.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White
        Me.Std_Table.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.Std_Table.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Std_Table.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Std_Table.Size = New System.Drawing.Size(962, 891)
        Me.Std_Table.TabIndex = 161
        '
        'AdEnrollStd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1490, 812)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AdEnrollStd"
        Me.Text = "Form2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.Std_Table, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents Label1 As Label
    Friend WithEvents BtnDrop As Button
    Friend WithEvents BtnEnr As Button
    Friend WithEvents Std_Table As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnRef As Button
    Friend WithEvents Label2 As Label
End Class
