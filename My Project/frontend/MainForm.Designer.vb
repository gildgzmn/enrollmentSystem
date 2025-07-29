<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.LogChoice = New System.Windows.Forms.ComboBox()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.LinkReg = New System.Windows.Forms.LinkLabel()
        Me.TbxPW = New System.Windows.Forms.TextBox()
        Me.TbxUN = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LogChoice
        '
        Me.LogChoice.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.LogChoice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LogChoice.Font = New System.Drawing.Font("Inter", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogChoice.ForeColor = System.Drawing.Color.White
        Me.LogChoice.FormattingEnabled = True
        Me.LogChoice.Items.AddRange(New Object() {"admin", "faculty", "student"})
        Me.LogChoice.Location = New System.Drawing.Point(436, 293)
        Me.LogChoice.Name = "LogChoice"
        Me.LogChoice.Size = New System.Drawing.Size(280, 27)
        Me.LogChoice.TabIndex = 22
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Inter", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.Color.White
        Me.BtnLogin.Location = New System.Drawing.Point(618, 521)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(98, 31)
        Me.BtnLogin.TabIndex = 13
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'LinkReg
        '
        Me.LinkReg.ActiveLinkColor = System.Drawing.Color.White
        Me.LinkReg.AutoSize = True
        Me.LinkReg.BackColor = System.Drawing.Color.Transparent
        Me.LinkReg.Font = New System.Drawing.Font("Inter", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkReg.LinkColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.LinkReg.Location = New System.Drawing.Point(628, 475)
        Me.LinkReg.Name = "LinkReg"
        Me.LinkReg.Size = New System.Drawing.Size(61, 15)
        Me.LinkReg.TabIndex = 14
        Me.LinkReg.TabStop = True
        Me.LinkReg.Text = "Register"
        '
        'TbxPW
        '
        Me.TbxPW.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TbxPW.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxPW.ForeColor = System.Drawing.Color.White
        Me.TbxPW.Location = New System.Drawing.Point(436, 417)
        Me.TbxPW.Name = "TbxPW"
        Me.TbxPW.Size = New System.Drawing.Size(280, 27)
        Me.TbxPW.TabIndex = 10
        Me.TbxPW.UseSystemPasswordChar = True
        '
        'TbxUN
        '
        Me.TbxUN.AccessibleName = ""
        Me.TbxUN.BackColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(43, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.TbxUN.Font = New System.Drawing.Font("Inter", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbxUN.ForeColor = System.Drawing.Color.White
        Me.TbxUN.Location = New System.Drawing.Point(436, 356)
        Me.TbxUN.Name = "TbxUN"
        Me.TbxUN.Size = New System.Drawing.Size(280, 27)
        Me.TbxUN.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(474, 475)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 15)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Don't have an account yet?"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.enrollment_sys.My.Resources.Resources.wow_balowet
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1147, 647)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.LogChoice)
        Me.Controls.Add(Me.LinkReg)
        Me.Controls.Add(Me.BtnLogin)
        Me.Controls.Add(Me.TbxUN)
        Me.Controls.Add(Me.TbxPW)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents BtnLogin As Button
    Private WithEvents LinkReg As LinkLabel
    Private WithEvents TbxPW As TextBox
    Private WithEvents TbxUN As TextBox
    Friend WithEvents LogChoice As ComboBox
    Friend WithEvents Label5 As Label
End Class
