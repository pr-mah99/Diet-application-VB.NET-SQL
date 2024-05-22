<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gender))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel1 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.Guna2CirclePictureBox5 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox4 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox3 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox2 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CirclePictureBox1 = New Guna.UI2.WinForms.Guna2CirclePictureBox()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Guna2CustomGradientPanel1.SuspendLayout()
        CType(Me.Guna2CirclePictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tajawal", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(258, 411)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "أنثى بالغة"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tajawal", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(530, 411)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 31)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ذكر بالغ"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Tajawal", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(274, 628)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "طفلة"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Tajawal", 12.2!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(542, 628)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 31)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "طفل"
        '
        'Label5
        '
        Me.Label5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Tajawal", 18.2!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(349, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(174, 46)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "أختر الجنس"
        '
        'Guna2CustomGradientPanel1
        '
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.TextBox1)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Guna2CirclePictureBox5)
        Me.Guna2CustomGradientPanel1.Controls.Add(Me.Label5)
        Me.Guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel1.FillColor = System.Drawing.Color.MediumPurple
        Me.Guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.SeaGreen
        Me.Guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Thistle
        Me.Guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Tomato
        Me.Guna2CustomGradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel1.Name = "Guna2CustomGradientPanel1"
        Me.Guna2CustomGradientPanel1.Quality = 100
        Me.Guna2CustomGradientPanel1.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel1
        Me.Guna2CustomGradientPanel1.Size = New System.Drawing.Size(848, 233)
        Me.Guna2CustomGradientPanel1.TabIndex = 9
        '
        'Guna2CirclePictureBox5
        '
        Me.Guna2CirclePictureBox5.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2CirclePictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox5.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CirclePictureBox5.Image = Global.Diet_application.My.Resources.Resources.icons8_healthy_food_150px
        Me.Guna2CirclePictureBox5.Location = New System.Drawing.Point(332, 22)
        Me.Guna2CirclePictureBox5.Name = "Guna2CirclePictureBox5"
        Me.Guna2CirclePictureBox5.ShadowDecoration.BorderRadius = 0
        Me.Guna2CirclePictureBox5.ShadowDecoration.Color = System.Drawing.Color.Empty
        Me.Guna2CirclePictureBox5.ShadowDecoration.Depth = 0
        Me.Guna2CirclePictureBox5.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox5.ShadowDecoration.Parent = Me.Guna2CirclePictureBox5
        Me.Guna2CirclePictureBox5.Size = New System.Drawing.Size(207, 138)
        Me.Guna2CirclePictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox5.TabIndex = 10
        Me.Guna2CirclePictureBox5.TabStop = False
        '
        'Guna2CirclePictureBox4
        '
        Me.Guna2CirclePictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2CirclePictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox4.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CirclePictureBox4.Image = Global.Diet_application.My.Resources.Resources.icons8_child_with_pacifier_200px
        Me.Guna2CirclePictureBox4.Location = New System.Drawing.Point(506, 497)
        Me.Guna2CirclePictureBox4.Name = "Guna2CirclePictureBox4"
        Me.Guna2CirclePictureBox4.ShadowDecoration.BorderRadius = 0
        Me.Guna2CirclePictureBox4.ShadowDecoration.Color = System.Drawing.Color.Empty
        Me.Guna2CirclePictureBox4.ShadowDecoration.Depth = 0
        Me.Guna2CirclePictureBox4.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox4.ShadowDecoration.Parent = Me.Guna2CirclePictureBox4
        Me.Guna2CirclePictureBox4.Size = New System.Drawing.Size(118, 143)
        Me.Guna2CirclePictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox4.TabIndex = 3
        Me.Guna2CirclePictureBox4.TabStop = False
        '
        'Guna2CirclePictureBox3
        '
        Me.Guna2CirclePictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CirclePictureBox3.Image = Global.Diet_application.My.Resources.Resources.icons8_girl_96px
        Me.Guna2CirclePictureBox3.Location = New System.Drawing.Point(241, 497)
        Me.Guna2CirclePictureBox3.Name = "Guna2CirclePictureBox3"
        Me.Guna2CirclePictureBox3.ShadowDecoration.BorderRadius = 0
        Me.Guna2CirclePictureBox3.ShadowDecoration.Color = System.Drawing.Color.Empty
        Me.Guna2CirclePictureBox3.ShadowDecoration.Depth = 0
        Me.Guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox3.ShadowDecoration.Parent = Me.Guna2CirclePictureBox3
        Me.Guna2CirclePictureBox3.Size = New System.Drawing.Size(118, 143)
        Me.Guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox3.TabIndex = 2
        Me.Guna2CirclePictureBox3.TabStop = False
        '
        'Guna2CirclePictureBox2
        '
        Me.Guna2CirclePictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2CirclePictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CirclePictureBox2.Image = Global.Diet_application.My.Resources.Resources.icons8_person_male_skin_type_4_60px
        Me.Guna2CirclePictureBox2.Location = New System.Drawing.Point(506, 279)
        Me.Guna2CirclePictureBox2.Name = "Guna2CirclePictureBox2"
        Me.Guna2CirclePictureBox2.ShadowDecoration.BorderRadius = 0
        Me.Guna2CirclePictureBox2.ShadowDecoration.Color = System.Drawing.Color.Empty
        Me.Guna2CirclePictureBox2.ShadowDecoration.Depth = 0
        Me.Guna2CirclePictureBox2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox2.ShadowDecoration.Parent = Me.Guna2CirclePictureBox2
        Me.Guna2CirclePictureBox2.Size = New System.Drawing.Size(118, 143)
        Me.Guna2CirclePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox2.TabIndex = 1
        Me.Guna2CirclePictureBox2.TabStop = False
        '
        'Guna2CirclePictureBox1
        '
        Me.Guna2CirclePictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Guna2CirclePictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2CirclePictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2CirclePictureBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2CirclePictureBox1.Image = Global.Diet_application.My.Resources.Resources.icons8_person_female_skin_type_4_60px_1
        Me.Guna2CirclePictureBox1.Location = New System.Drawing.Point(246, 279)
        Me.Guna2CirclePictureBox1.Name = "Guna2CirclePictureBox1"
        Me.Guna2CirclePictureBox1.ShadowDecoration.BorderRadius = 0
        Me.Guna2CirclePictureBox1.ShadowDecoration.Color = System.Drawing.Color.Empty
        Me.Guna2CirclePictureBox1.ShadowDecoration.Depth = 0
        Me.Guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.Guna2CirclePictureBox1.ShadowDecoration.Parent = Me.Guna2CirclePictureBox1
        Me.Guna2CirclePictureBox1.Size = New System.Drawing.Size(118, 143)
        Me.Guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Guna2CirclePictureBox1.TabIndex = 0
        Me.Guna2CirclePictureBox1.TabStop = False
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label3)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label1)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2CirclePictureBox2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2CirclePictureBox1)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2CirclePictureBox3)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Guna2CirclePictureBox4)
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.SystemColors.MenuText
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.SkyBlue
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Thistle
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Teal
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Quality = 199
        Me.Guna2CustomGradientPanel2.ShadowDecoration.Parent = Me.Guna2CustomGradientPanel2
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(848, 731)
        Me.Guna2CustomGradientPanel2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(727, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 24)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Visible = False
        '
        'Gender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(848, 724)
        Me.Controls.Add(Me.Guna2CustomGradientPanel1)
        Me.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(866, 771)
        Me.MinimumSize = New System.Drawing.Size(866, 771)
        Me.Name = "Gender"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gender"
        Me.Guna2CustomGradientPanel1.ResumeLayout(False)
        Me.Guna2CustomGradientPanel1.PerformLayout()
        CType(Me.Guna2CirclePictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Guna2CirclePictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2CirclePictureBox1 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox2 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox3 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CirclePictureBox4 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CustomGradientPanel1 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents Guna2CirclePictureBox5 As Guna.UI2.WinForms.Guna2CirclePictureBox
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents TextBox1 As TextBox
End Class
