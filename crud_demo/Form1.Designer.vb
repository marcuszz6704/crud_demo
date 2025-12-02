<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.ButtonConnect = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonCreate = New System.Windows.Forms.Button()
        Me.ButtonRead = New System.Windows.Forms.Button()
        Me.ButtonUpdate = New System.Windows.Forms.Button()
        Me.ButtonDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.TextBoxAge = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.TextBoxHiddenID = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ButtonConnect
        '
        Me.ButtonConnect.Location = New System.Drawing.Point(23, 12)
        Me.ButtonConnect.Name = "ButtonConnect"
        Me.ButtonConnect.Size = New System.Drawing.Size(197, 110)
        Me.ButtonConnect.TabIndex = 0
        Me.ButtonConnect.Text = "ConnectMySQL"
        Me.ButtonConnect.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 179)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "NAME:"
        '
        'ButtonCreate
        '
        Me.ButtonCreate.Location = New System.Drawing.Point(82, 332)
        Me.ButtonCreate.Name = "ButtonCreate"
        Me.ButtonCreate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCreate.TabIndex = 2
        Me.ButtonCreate.Text = "Create"
        Me.ButtonCreate.UseVisualStyleBackColor = True
        '
        'ButtonRead
        '
        Me.ButtonRead.Location = New System.Drawing.Point(82, 371)
        Me.ButtonRead.Name = "ButtonRead"
        Me.ButtonRead.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRead.TabIndex = 3
        Me.ButtonRead.Text = "Read"
        Me.ButtonRead.UseVisualStyleBackColor = True
        '
        'ButtonUpdate
        '
        Me.ButtonUpdate.Location = New System.Drawing.Point(181, 332)
        Me.ButtonUpdate.Name = "ButtonUpdate"
        Me.ButtonUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ButtonUpdate.TabIndex = 4
        Me.ButtonUpdate.Text = "Update"
        Me.ButtonUpdate.UseVisualStyleBackColor = True
        '
        'ButtonDelete
        '
        Me.ButtonDelete.Location = New System.Drawing.Point(181, 371)
        Me.ButtonDelete.Name = "ButtonDelete"
        Me.ButtonDelete.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDelete.TabIndex = 5
        Me.ButtonDelete.Text = "Delete"
        Me.ButtonDelete.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "AGE:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "EMAIL:"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(244, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(512, 296)
        Me.DataGridView1.TabIndex = 9
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(94, 179)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxName.TabIndex = 10
        '
        'TextBoxAge
        '
        Me.TextBoxAge.Location = New System.Drawing.Point(94, 210)
        Me.TextBoxAge.Name = "TextBoxAge"
        Me.TextBoxAge.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAge.TabIndex = 11
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(94, 236)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxEmail.TabIndex = 12
        '
        'TextBoxHiddenID
        '
        Me.TextBoxHiddenID.Location = New System.Drawing.Point(94, 153)
        Me.TextBoxHiddenID.Name = "TextBoxHiddenID"
        Me.TextBoxHiddenID.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxHiddenID.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBoxHiddenID)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxAge)
        Me.Controls.Add(Me.TextBoxName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonDelete)
        Me.Controls.Add(Me.ButtonUpdate)
        Me.Controls.Add(Me.ButtonRead)
        Me.Controls.Add(Me.ButtonCreate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ButtonConnect)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonConnect As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonCreate As Button
    Friend WithEvents ButtonRead As Button
    Friend WithEvents ButtonUpdate As Button
    Friend WithEvents ButtonDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents TextBoxAge As TextBox
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents TextBoxHiddenID As TextBox
End Class
