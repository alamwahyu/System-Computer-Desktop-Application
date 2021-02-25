<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormInfoIP
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
        Me.tb_ip = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btn_cek = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btn_self = New System.Windows.Forms.Button()
        Me.btn_cekinternet = New System.Windows.Forms.Button()
        Me.btn_info = New System.Windows.Forms.Button()
        Me.btn_url = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb_ip
        '
        Me.tb_ip.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_ip.Location = New System.Drawing.Point(462, 115)
        Me.tb_ip.Name = "tb_ip"
        Me.tb_ip.Size = New System.Drawing.Size(433, 49)
        Me.tb_ip.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "IP ADDRESS CHECKED"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Masukan IP Address"
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 24
        Me.ListBox1.Location = New System.Drawing.Point(43, 276)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(852, 172)
        Me.ListBox1.TabIndex = 3
        '
        'btn_cek
        '
        Me.btn_cek.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cek.Location = New System.Drawing.Point(689, 183)
        Me.btn_cek.Name = "btn_cek"
        Me.btn_cek.Size = New System.Drawing.Size(206, 71)
        Me.btn_cek.TabIndex = 4
        Me.btn_cek.Text = "CEK DOMAIN"
        Me.btn_cek.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button1.Location = New System.Drawing.Point(754, 483)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(141, 36)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button2.Location = New System.Drawing.Point(462, 183)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 71)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "CEK IP END POINT"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button3.Location = New System.Drawing.Point(327, 96)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(116, 47)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "CEK IPv4"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Location = New System.Drawing.Point(327, 149)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 47)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "CEK IPv6"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button5.Location = New System.Drawing.Point(327, 202)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(116, 47)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "CEK IP DNS"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'btn_self
        '
        Me.btn_self.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_self.Location = New System.Drawing.Point(779, 36)
        Me.btn_self.Name = "btn_self"
        Me.btn_self.Size = New System.Drawing.Size(116, 47)
        Me.btn_self.TabIndex = 10
        Me.btn_self.Text = "SELF IP"
        Me.btn_self.UseVisualStyleBackColor = False
        '
        'btn_cekinternet
        '
        Me.btn_cekinternet.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_cekinternet.Location = New System.Drawing.Point(43, 202)
        Me.btn_cekinternet.Name = "btn_cekinternet"
        Me.btn_cekinternet.Size = New System.Drawing.Size(116, 47)
        Me.btn_cekinternet.TabIndex = 11
        Me.btn_cekinternet.Text = "CEK INTERNET"
        Me.btn_cekinternet.UseVisualStyleBackColor = False
        '
        'btn_info
        '
        Me.btn_info.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_info.Location = New System.Drawing.Point(31, 472)
        Me.btn_info.Name = "btn_info"
        Me.btn_info.Size = New System.Drawing.Size(116, 47)
        Me.btn_info.TabIndex = 12
        Me.btn_info.Text = "INFORMASI"
        Me.btn_info.UseVisualStyleBackColor = False
        '
        'btn_url
        '
        Me.btn_url.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_url.Location = New System.Drawing.Point(647, 36)
        Me.btn_url.Name = "btn_url"
        Me.btn_url.Size = New System.Drawing.Size(116, 47)
        Me.btn_url.TabIndex = 13
        Me.btn_url.Text = "CEK INFORMASI URL"
        Me.btn_url.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 531)
        Me.Controls.Add(Me.btn_url)
        Me.Controls.Add(Me.btn_info)
        Me.Controls.Add(Me.btn_cekinternet)
        Me.Controls.Add(Me.btn_self)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btn_cek)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb_ip)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb_ip As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btn_cek As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btn_self As Button
    Friend WithEvents btn_cekinternet As Button
    Friend WithEvents btn_info As Button
    Friend WithEvents btn_url As Button
End Class
