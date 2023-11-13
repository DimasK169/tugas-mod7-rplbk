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
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        Button1 = New Button()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        TextBox1 = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(169, 150)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 0
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(443, 150)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(591, 150)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 4
        Button1.Text = "Konversi"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(93, 154)
        Label1.Name = "Label1"
        Label1.Size = New Size(28, 15)
        Label1.TabIndex = 7
        Label1.Text = "Dari"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(377, 153)
        Label3.Name = "Label3"
        Label3.Size = New Size(20, 15)
        Label3.TabIndex = 8
        Label3.Text = "Ke"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(334, 229)
        Label4.Name = "Label4"
        Label4.Size = New Size(81, 15)
        Label4.TabIndex = 9
        Label4.Text = "Hasil Konversi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(367, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(13, 15)
        Label2.TabIndex = 10
        Label2.Text = "0"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(312, 95)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(129, 23)
        TextBox1.TabIndex = 12
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(334, 70)
        Label5.Name = "Label5"
        Label5.Size = New Size(88, 15)
        Label5.TabIndex = 13
        Label5.Text = "Masukkan Nilai"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(298, 30)
        Label6.Name = "Label6"
        Label6.Size = New Size(154, 15)
        Label6.TabIndex = 14
        Label6.Text = "Konversi Suhu Kelompok 28"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(775, 436)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(TextBox1)
        Controls.Add(Label2)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
