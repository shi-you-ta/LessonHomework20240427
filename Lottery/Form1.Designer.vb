<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        components = New ComponentModel.Container()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Button1 = New Button()
        TabControl1 = New TabControl()
        TabPage1 = New TabPage()
        TabPage2 = New TabPage()
        Label19 = New Label()
        Label18 = New Label()
        Label17 = New Label()
        Button2 = New Button()
        Label16 = New Label()
        Label15 = New Label()
        Label14 = New Label()
        Label13 = New Label()
        Label12 = New Label()
        Label11 = New Label()
        Label10 = New Label()
        Label9 = New Label()
        Label8 = New Label()
        Timer1 = New Timer(components)
        TabControl1.SuspendLayout()
        TabPage1.SuspendLayout()
        TabPage2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label1.Location = New Point(88, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(74, 114)
        Label1.TabIndex = 0
        Label1.Text = "ー"
        Label1.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label2
        ' 
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label2.Location = New Point(230, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(74, 114)
        Label2.TabIndex = 0
        Label2.Text = "ー"
        Label2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label3
        ' 
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label3.Location = New Point(372, 3)
        Label3.Name = "Label3"
        Label3.Size = New Size(74, 114)
        Label3.TabIndex = 0
        Label3.Text = "ー"
        Label3.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label4
        ' 
        Label4.BorderStyle = BorderStyle.FixedSingle
        Label4.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label4.Location = New Point(514, 3)
        Label4.Name = "Label4"
        Label4.Size = New Size(74, 114)
        Label4.TabIndex = 0
        Label4.Text = "ー"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label5.Location = New Point(160, 201)
        Label5.Name = "Label5"
        Label5.Size = New Size(116, 31)
        Label5.TabIndex = 1
        Label5.Text = "結果は・・・"
        Label5.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label6
        ' 
        Label6.BorderStyle = BorderStyle.FixedSingle
        Label6.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label6.ForeColor = Color.Red
        Label6.Location = New Point(282, 193)
        Label6.Name = "Label6"
        Label6.Size = New Size(118, 47)
        Label6.TabIndex = 2
        Label6.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label7.Location = New Point(406, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(52, 31)
        Label7.TabIndex = 3
        Label7.Text = "です"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(263, 130)
        Button1.Name = "Button1"
        Button1.Size = New Size(154, 52)
        Button1.TabIndex = 4
        Button1.Text = "抽選開始"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TabControl1
        ' 
        TabControl1.Controls.Add(TabPage1)
        TabControl1.Controls.Add(TabPage2)
        TabControl1.Location = New Point(12, 89)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(690, 313)
        TabControl1.TabIndex = 5
        ' 
        ' TabPage1
        ' 
        TabPage1.Controls.Add(Label1)
        TabPage1.Controls.Add(Label7)
        TabPage1.Controls.Add(Button1)
        TabPage1.Controls.Add(Label6)
        TabPage1.Controls.Add(Label2)
        TabPage1.Controls.Add(Label5)
        TabPage1.Controls.Add(Label3)
        TabPage1.Controls.Add(Label4)
        TabPage1.Location = New Point(4, 29)
        TabPage1.Name = "TabPage1"
        TabPage1.Padding = New Padding(3)
        TabPage1.Size = New Size(682, 280)
        TabPage1.TabIndex = 0
        TabPage1.Text = "4桁の宝くじ"
        TabPage1.UseVisualStyleBackColor = True
        ' 
        ' TabPage2
        ' 
        TabPage2.Controls.Add(Label19)
        TabPage2.Controls.Add(Label18)
        TabPage2.Controls.Add(Label17)
        TabPage2.Controls.Add(Button2)
        TabPage2.Controls.Add(Label16)
        TabPage2.Controls.Add(Label15)
        TabPage2.Controls.Add(Label14)
        TabPage2.Controls.Add(Label13)
        TabPage2.Controls.Add(Label12)
        TabPage2.Controls.Add(Label11)
        TabPage2.Controls.Add(Label10)
        TabPage2.Controls.Add(Label9)
        TabPage2.Location = New Point(4, 29)
        TabPage2.Name = "TabPage2"
        TabPage2.Padding = New Padding(3)
        TabPage2.Size = New Size(682, 280)
        TabPage2.TabIndex = 1
        TabPage2.Text = "8桁の宝くじ"
        TabPage2.UseVisualStyleBackColor = True
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label19.Location = New Point(403, 210)
        Label19.Name = "Label19"
        Label19.Size = New Size(52, 31)
        Label19.TabIndex = 8
        Label19.Text = "です"
        ' 
        ' Label18
        ' 
        Label18.BorderStyle = BorderStyle.FixedSingle
        Label18.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label18.ForeColor = Color.Red
        Label18.Location = New Point(279, 202)
        Label18.Name = "Label18"
        Label18.Size = New Size(118, 47)
        Label18.TabIndex = 7
        Label18.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label17.Location = New Point(157, 210)
        Label17.Name = "Label17"
        Label17.Size = New Size(116, 31)
        Label17.TabIndex = 6
        Label17.Text = "結果は・・・"
        Label17.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(261, 136)
        Button2.Name = "Button2"
        Button2.Size = New Size(159, 52)
        Button2.TabIndex = 5
        Button2.Text = "抽選開始"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label16
        ' 
        Label16.BorderStyle = BorderStyle.FixedSingle
        Label16.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label16.Location = New Point(601, 3)
        Label16.Name = "Label16"
        Label16.Size = New Size(74, 114)
        Label16.TabIndex = 1
        Label16.Text = "ー"
        Label16.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label15
        ' 
        Label15.BorderStyle = BorderStyle.FixedSingle
        Label15.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label15.Location = New Point(516, 3)
        Label15.Name = "Label15"
        Label15.Size = New Size(74, 114)
        Label15.TabIndex = 1
        Label15.Text = "ー"
        Label15.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label14
        ' 
        Label14.BorderStyle = BorderStyle.FixedSingle
        Label14.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label14.Location = New Point(431, 3)
        Label14.Name = "Label14"
        Label14.Size = New Size(74, 114)
        Label14.TabIndex = 1
        Label14.Text = "ー"
        Label14.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label13
        ' 
        Label13.BorderStyle = BorderStyle.FixedSingle
        Label13.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label13.Location = New Point(346, 3)
        Label13.Name = "Label13"
        Label13.Size = New Size(74, 114)
        Label13.TabIndex = 1
        Label13.Text = "ー"
        Label13.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label12
        ' 
        Label12.BorderStyle = BorderStyle.FixedSingle
        Label12.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label12.Location = New Point(261, 3)
        Label12.Name = "Label12"
        Label12.Size = New Size(74, 114)
        Label12.TabIndex = 1
        Label12.Text = "ー"
        Label12.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label11
        ' 
        Label11.BorderStyle = BorderStyle.FixedSingle
        Label11.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label11.Location = New Point(176, 3)
        Label11.Name = "Label11"
        Label11.Size = New Size(74, 114)
        Label11.TabIndex = 1
        Label11.Text = "ー"
        Label11.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label10
        ' 
        Label10.BorderStyle = BorderStyle.FixedSingle
        Label10.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label10.Location = New Point(91, 3)
        Label10.Name = "Label10"
        Label10.Size = New Size(74, 114)
        Label10.TabIndex = 1
        Label10.Text = "ー"
        Label10.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label9
        ' 
        Label9.BorderStyle = BorderStyle.FixedSingle
        Label9.Font = New Font("Yu Gothic UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(128))
        Label9.Location = New Point(6, 3)
        Label9.Name = "Label9"
        Label9.Size = New Size(74, 114)
        Label9.TabIndex = 1
        Label9.Text = "ー"
        Label9.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Label8
        ' 
        Label8.BorderStyle = BorderStyle.Fixed3D
        Label8.Font = New Font("メイリオ", 10.2F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(128))
        Label8.Location = New Point(12, 9)
        Label8.Name = "Label8"
        Label8.Size = New Size(339, 45)
        Label8.TabIndex = 5
        Label8.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(743, 410)
        Controls.Add(Label8)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "宝くじ"
        TabControl1.ResumeLayout(False)
        TabPage1.ResumeLayout(False)
        TabPage1.PerformLayout()
        TabPage2.ResumeLayout(False)
        TabPage2.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label8 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Button2 As Button

End Class
