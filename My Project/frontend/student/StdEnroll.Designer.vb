<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StdEnroll
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CbxSec = New System.Windows.Forms.ComboBox()
        Me.BtnEnr = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Payment = New System.Windows.Forms.TextBox()
        Me.LblTotalAmount = New System.Windows.Forms.Label()
        Me.LblTotalUnits = New System.Windows.Forms.Label()
        Me.TbxFee = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Req = New System.Windows.Forms.CheckedListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TbxCour = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxSem = New System.Windows.Forms.ComboBox()
        Me.Enr_subj = New System.Windows.Forms.DataGridView()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.CbxYear = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Enr_subj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.CbxSec)
        Me.Panel1.Controls.Add(Me.BtnEnr)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Payment)
        Me.Panel1.Controls.Add(Me.LblTotalAmount)
        Me.Panel1.Controls.Add(Me.LblTotalUnits)
        Me.Panel1.Controls.Add(Me.TbxFee)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Req)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TbxCour)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.CbxSem)
        Me.Panel1.Controls.Add(Me.Enr_subj)
        Me.Panel1.Controls.Add(Me.Label39)
        Me.Panel1.Controls.Add(Me.CbxYear)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(-15, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1161, 615)
        Me.Panel1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(649, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 15)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Section"
        '
        'CbxSec
        '
        Me.CbxSec.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSec.FormattingEnabled = True
        Me.CbxSec.Items.AddRange(New Object() {"A", "B", "C"})
        Me.CbxSec.Location = New System.Drawing.Point(653, 142)
        Me.CbxSec.Name = "CbxSec"
        Me.CbxSec.Size = New System.Drawing.Size(93, 23)
        Me.CbxSec.TabIndex = 100
        '
        'BtnEnr
        '
        Me.BtnEnr.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnEnr.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEnr.Enabled = False
        Me.BtnEnr.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEnr.FlatAppearance.BorderSize = 0
        Me.BtnEnr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEnr.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEnr.ForeColor = System.Drawing.Color.Black
        Me.BtnEnr.Location = New System.Drawing.Point(914, 416)
        Me.BtnEnr.Name = "BtnEnr"
        Me.BtnEnr.Size = New System.Drawing.Size(170, 36)
        Me.BtnEnr.TabIndex = 97
        Me.BtnEnr.Text = "Enroll"
        Me.BtnEnr.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(910, 334)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Payment"
        '
        'Payment
        '
        Me.Payment.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Payment.Location = New System.Drawing.Point(914, 356)
        Me.Payment.Name = "Payment"
        Me.Payment.Size = New System.Drawing.Size(170, 23)
        Me.Payment.TabIndex = 69
        '
        'LblTotalAmount
        '
        Me.LblTotalAmount.AutoSize = True
        Me.LblTotalAmount.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalAmount.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalAmount.ForeColor = System.Drawing.Color.White
        Me.LblTotalAmount.Location = New System.Drawing.Point(935, 282)
        Me.LblTotalAmount.Name = "LblTotalAmount"
        Me.LblTotalAmount.Size = New System.Drawing.Size(0, 19)
        Me.LblTotalAmount.TabIndex = 67
        '
        'LblTotalUnits
        '
        Me.LblTotalUnits.AutoSize = True
        Me.LblTotalUnits.BackColor = System.Drawing.Color.Transparent
        Me.LblTotalUnits.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalUnits.ForeColor = System.Drawing.Color.White
        Me.LblTotalUnits.Location = New System.Drawing.Point(935, 249)
        Me.LblTotalUnits.Name = "LblTotalUnits"
        Me.LblTotalUnits.Size = New System.Drawing.Size(0, 19)
        Me.LblTotalUnits.TabIndex = 66
        '
        'TbxFee
        '
        Me.TbxFee.Enabled = False
        Me.TbxFee.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxFee.Location = New System.Drawing.Point(914, 283)
        Me.TbxFee.Name = "TbxFee"
        Me.TbxFee.Size = New System.Drawing.Size(170, 23)
        Me.TbxFee.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(910, 261)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 16)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "Tuition Fee"
        '
        'Req
        '
        Me.Req.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Req.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Req.Font = New System.Drawing.Font("Inter", 11.25!)
        Me.Req.ForeColor = System.Drawing.Color.White
        Me.Req.FormattingEnabled = True
        Me.Req.Items.AddRange(New Object() {"Form 137", "Birth Certificate", "GMC"})
        Me.Req.Location = New System.Drawing.Point(914, 183)
        Me.Req.Name = "Req"
        Me.Req.Size = New System.Drawing.Size(170, 63)
        Me.Req.TabIndex = 63
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(50, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 15)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "Course"
        '
        'TbxCour
        '
        Me.TbxCour.Enabled = False
        Me.TbxCour.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxCour.Location = New System.Drawing.Point(54, 143)
        Me.TbxCour.Name = "TbxCour"
        Me.TbxCour.Size = New System.Drawing.Size(236, 22)
        Me.TbxCour.TabIndex = 61
        Me.TbxCour.Text = "BS Computer Engineering"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(465, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 15)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Semester"
        '
        'CbxSem
        '
        Me.CbxSem.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxSem.FormattingEnabled = True
        Me.CbxSem.Items.AddRange(New Object() {"1st Semester", "2nd Semester"})
        Me.CbxSem.Location = New System.Drawing.Point(469, 143)
        Me.CbxSem.Name = "CbxSem"
        Me.CbxSem.Size = New System.Drawing.Size(153, 23)
        Me.CbxSem.TabIndex = 53
        '
        'Enr_subj
        '
        Me.Enr_subj.AllowUserToAddRows = False
        Me.Enr_subj.AllowUserToDeleteRows = False
        Me.Enr_subj.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Enr_subj.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.Enr_subj.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Enr_subj.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.Enr_subj.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Enr_subj.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Enr_subj.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.Enr_subj.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Enr_subj.Cursor = System.Windows.Forms.Cursors.Default
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Enr_subj.DefaultCellStyle = DataGridViewCellStyle7
        Me.Enr_subj.GridColor = System.Drawing.Color.White
        Me.Enr_subj.Location = New System.Drawing.Point(54, 192)
        Me.Enr_subj.Name = "Enr_subj"
        Me.Enr_subj.ReadOnly = True
        Me.Enr_subj.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White
        Me.Enr_subj.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.Enr_subj.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Enr_subj.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Enr_subj.Size = New System.Drawing.Size(829, 361)
        Me.Enr_subj.TabIndex = 52
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.BackColor = System.Drawing.Color.Transparent
        Me.Label39.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.White
        Me.Label39.Location = New System.Drawing.Point(335, 121)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(66, 15)
        Me.Label39.TabIndex = 51
        Me.Label39.Text = "Year Level"
        '
        'CbxYear
        '
        Me.CbxYear.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxYear.FormattingEnabled = True
        Me.CbxYear.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.CbxYear.Location = New System.Drawing.Point(339, 143)
        Me.CbxYear.Name = "CbxYear"
        Me.CbxYear.Size = New System.Drawing.Size(93, 23)
        Me.CbxYear.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1218, 61)
        Me.Panel2.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Gotham", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label1.Location = New System.Drawing.Point(43, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(292, 50)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "ENROLLMENT"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StdEnroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1490, 776)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "StdEnroll"
        Me.Text = "Enroll"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Enr_subj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Private WithEvents Label1 As Label
    Friend WithEvents CbxYear As ComboBox
    Private WithEvents Label39 As Label
    Friend WithEvents Enr_subj As DataGridView
    Private WithEvents Label2 As Label
    Friend WithEvents CbxSem As ComboBox
    Private WithEvents Label3 As Label
    Private WithEvents TbxCour As TextBox
    Private WithEvents TbxFee As TextBox
    Private WithEvents Label4 As Label
    Private WithEvents LblTotalUnits As Label
    Private WithEvents LblTotalAmount As Label
    Private WithEvents Payment As TextBox
    Private WithEvents Label5 As Label
    Private WithEvents BtnEnr As Button
    Private WithEvents Label7 As Label
    Friend WithEvents CbxSec As ComboBox
    Friend WithEvents Req As CheckedListBox
End Class
