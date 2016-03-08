<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmQLSV
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
        Me.LbMSV = New System.Windows.Forms.Label()
        Me.LbTSV = New System.Windows.Forms.Label()
        Me.LbGT = New System.Windows.Forms.Label()
        Me.LbNS = New System.Windows.Forms.Label()
        Me.LbDC = New System.Windows.Forms.Label()
        Me.LbSDT = New System.Windows.Forms.Label()
        Me.TxbMSV = New System.Windows.Forms.TextBox()
        Me.TxbTSV = New System.Windows.Forms.TextBox()
        Me.TxbNS = New System.Windows.Forms.TextBox()
        Me.TxbDC = New System.Windows.Forms.TextBox()
        Me.TxbSDT = New System.Windows.Forms.TextBox()
        Me.BtThem = New System.Windows.Forms.Button()
        Me.BtSua = New System.Windows.Forms.Button()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.BtThoat = New System.Windows.Forms.Button()
        Me.LwQLSV = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CbGT = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LbMSV
        '
        Me.LbMSV.AutoSize = True
        Me.LbMSV.Location = New System.Drawing.Point(80, 41)
        Me.LbMSV.Name = "LbMSV"
        Me.LbMSV.Size = New System.Drawing.Size(87, 17)
        Me.LbMSV.TabIndex = 0
        Me.LbMSV.Text = "Mã sinh viên"
        '
        'LbTSV
        '
        Me.LbTSV.AutoSize = True
        Me.LbTSV.Location = New System.Drawing.Point(80, 83)
        Me.LbTSV.Name = "LbTSV"
        Me.LbTSV.Size = New System.Drawing.Size(93, 17)
        Me.LbTSV.TabIndex = 0
        Me.LbTSV.Text = "Tên sinh viên"
        '
        'LbGT
        '
        Me.LbGT.AutoSize = True
        Me.LbGT.Location = New System.Drawing.Point(80, 132)
        Me.LbGT.Name = "LbGT"
        Me.LbGT.Size = New System.Drawing.Size(60, 17)
        Me.LbGT.TabIndex = 0
        Me.LbGT.Text = "Giới tính"
        '
        'LbNS
        '
        Me.LbNS.AutoSize = True
        Me.LbNS.Location = New System.Drawing.Point(594, 39)
        Me.LbNS.Name = "LbNS"
        Me.LbNS.Size = New System.Drawing.Size(71, 17)
        Me.LbNS.TabIndex = 0
        Me.LbNS.Text = "Ngày sinh"
        '
        'LbDC
        '
        Me.LbDC.AutoSize = True
        Me.LbDC.Location = New System.Drawing.Point(594, 83)
        Me.LbDC.Name = "LbDC"
        Me.LbDC.Size = New System.Drawing.Size(51, 17)
        Me.LbDC.TabIndex = 0
        Me.LbDC.Text = "Địa chỉ"
        '
        'LbSDT
        '
        Me.LbSDT.AutoSize = True
        Me.LbSDT.Location = New System.Drawing.Point(594, 132)
        Me.LbSDT.Name = "LbSDT"
        Me.LbSDT.Size = New System.Drawing.Size(91, 17)
        Me.LbSDT.TabIndex = 0
        Me.LbSDT.Text = "Số điện thoại"
        '
        'TxbMSV
        '
        Me.TxbMSV.Location = New System.Drawing.Point(209, 36)
        Me.TxbMSV.Name = "TxbMSV"
        Me.TxbMSV.Size = New System.Drawing.Size(260, 22)
        Me.TxbMSV.TabIndex = 1
        '
        'TxbTSV
        '
        Me.TxbTSV.Location = New System.Drawing.Point(209, 83)
        Me.TxbTSV.Name = "TxbTSV"
        Me.TxbTSV.Size = New System.Drawing.Size(260, 22)
        Me.TxbTSV.TabIndex = 1
        '
        'TxbNS
        '
        Me.TxbNS.Location = New System.Drawing.Point(720, 36)
        Me.TxbNS.Name = "TxbNS"
        Me.TxbNS.Size = New System.Drawing.Size(260, 22)
        Me.TxbNS.TabIndex = 1
        '
        'TxbDC
        '
        Me.TxbDC.Location = New System.Drawing.Point(720, 83)
        Me.TxbDC.Name = "TxbDC"
        Me.TxbDC.Size = New System.Drawing.Size(260, 22)
        Me.TxbDC.TabIndex = 1
        '
        'TxbSDT
        '
        Me.TxbSDT.Location = New System.Drawing.Point(720, 127)
        Me.TxbSDT.Name = "TxbSDT"
        Me.TxbSDT.Size = New System.Drawing.Size(260, 22)
        Me.TxbSDT.TabIndex = 1
        '
        'BtThem
        '
        Me.BtThem.Location = New System.Drawing.Point(209, 206)
        Me.BtThem.Name = "BtThem"
        Me.BtThem.Size = New System.Drawing.Size(75, 23)
        Me.BtThem.TabIndex = 2
        Me.BtThem.Text = "Thêm"
        Me.BtThem.UseVisualStyleBackColor = True
        '
        'BtSua
        '
        Me.BtSua.Location = New System.Drawing.Point(349, 206)
        Me.BtSua.Name = "BtSua"
        Me.BtSua.Size = New System.Drawing.Size(75, 23)
        Me.BtSua.TabIndex = 2
        Me.BtSua.Text = "Sửa"
        Me.BtSua.UseVisualStyleBackColor = True
        '
        'BtXoa
        '
        Me.BtXoa.Location = New System.Drawing.Point(489, 206)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(75, 23)
        Me.BtXoa.TabIndex = 2
        Me.BtXoa.Text = "Xóa"
        Me.BtXoa.UseVisualStyleBackColor = True
        '
        'BtThoat
        '
        Me.BtThoat.Location = New System.Drawing.Point(625, 206)
        Me.BtThoat.Name = "BtThoat"
        Me.BtThoat.Size = New System.Drawing.Size(75, 23)
        Me.BtThoat.TabIndex = 2
        Me.BtThoat.Text = "Thoát"
        Me.BtThoat.UseVisualStyleBackColor = True
        '
        'LwQLSV
        '
        Me.LwQLSV.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LwQLSV.FullRowSelect = True
        Me.LwQLSV.GridLines = True
        Me.LwQLSV.Location = New System.Drawing.Point(38, 289)
        Me.LwQLSV.Name = "LwQLSV"
        Me.LwQLSV.Size = New System.Drawing.Size(1007, 356)
        Me.LwQLSV.TabIndex = 3
        Me.LwQLSV.UseCompatibleStateImageBehavior = False
        Me.LwQLSV.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STT"
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Mã sinh viên"
        Me.ColumnHeader2.Width = 124
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tên sinh viên"
        Me.ColumnHeader3.Width = 209
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Gới tính"
        Me.ColumnHeader4.Width = 124
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Ngày sinh"
        Me.ColumnHeader5.Width = 137
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Địa chỉ"
        Me.ColumnHeader6.Width = 170
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Số điện thoại"
        Me.ColumnHeader7.Width = 176
        '
        'CbGT
        '
        Me.CbGT.FormattingEnabled = True
        Me.CbGT.Items.AddRange(New Object() {"True", "False"})
        Me.CbGT.Location = New System.Drawing.Point(209, 129)
        Me.CbGT.Name = "CbGT"
        Me.CbGT.Size = New System.Drawing.Size(260, 24)
        Me.CbGT.TabIndex = 4
        '
        'FrmQLSV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1080, 674)
        Me.Controls.Add(Me.CbGT)
        Me.Controls.Add(Me.LwQLSV)
        Me.Controls.Add(Me.BtThoat)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.BtSua)
        Me.Controls.Add(Me.BtThem)
        Me.Controls.Add(Me.TxbSDT)
        Me.Controls.Add(Me.TxbDC)
        Me.Controls.Add(Me.TxbNS)
        Me.Controls.Add(Me.TxbTSV)
        Me.Controls.Add(Me.TxbMSV)
        Me.Controls.Add(Me.LbSDT)
        Me.Controls.Add(Me.LbDC)
        Me.Controls.Add(Me.LbNS)
        Me.Controls.Add(Me.LbGT)
        Me.Controls.Add(Me.LbTSV)
        Me.Controls.Add(Me.LbMSV)
        Me.Name = "FrmQLSV"
        Me.Text = "QLSinhVien"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LbMSV As System.Windows.Forms.Label
    Friend WithEvents LbTSV As System.Windows.Forms.Label
    Friend WithEvents LbGT As System.Windows.Forms.Label
    Friend WithEvents LbNS As System.Windows.Forms.Label
    Friend WithEvents LbDC As System.Windows.Forms.Label
    Friend WithEvents LbSDT As System.Windows.Forms.Label
    Friend WithEvents TxbMSV As System.Windows.Forms.TextBox
    Friend WithEvents TxbTSV As System.Windows.Forms.TextBox
    Friend WithEvents TxbNS As System.Windows.Forms.TextBox
    Friend WithEvents TxbDC As System.Windows.Forms.TextBox
    Friend WithEvents TxbSDT As System.Windows.Forms.TextBox
    Friend WithEvents BtThem As System.Windows.Forms.Button
    Friend WithEvents BtSua As System.Windows.Forms.Button
    Friend WithEvents BtXoa As System.Windows.Forms.Button
    Friend WithEvents BtThoat As System.Windows.Forms.Button
    Friend WithEvents LwQLSV As System.Windows.Forms.ListView
    Friend WithEvents CbGT As System.Windows.Forms.ComboBox
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader

End Class
