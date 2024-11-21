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
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnload = New System.Windows.Forms.Button()
        Me.btnclose = New System.Windows.Forms.Button()
        Me.datarecord = New System.Windows.Forms.DataGridView()
        Me.btnprint = New System.Windows.Forms.Button()
        CType(Me.datarecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnadd
        '
        Me.btnadd.Location = New System.Drawing.Point(108, 94)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 0
        Me.btnadd.Text = "Add User"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnload
        '
        Me.btnload.Location = New System.Drawing.Point(108, 158)
        Me.btnload.Name = "btnload"
        Me.btnload.Size = New System.Drawing.Size(106, 23)
        Me.btnload.TabIndex = 1
        Me.btnload.Text = "Load Record"
        Me.btnload.UseVisualStyleBackColor = True
        '
        'btnclose
        '
        Me.btnclose.Location = New System.Drawing.Point(108, 221)
        Me.btnclose.Name = "btnclose"
        Me.btnclose.Size = New System.Drawing.Size(75, 23)
        Me.btnclose.TabIndex = 2
        Me.btnclose.Text = "Close"
        Me.btnclose.UseVisualStyleBackColor = True
        '
        'datarecord
        '
        Me.datarecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datarecord.Location = New System.Drawing.Point(292, 94)
        Me.datarecord.Name = "datarecord"
        Me.datarecord.Size = New System.Drawing.Size(240, 150)
        Me.datarecord.TabIndex = 3
        '
        'btnprint
        '
        Me.btnprint.Location = New System.Drawing.Point(108, 276)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.Size = New System.Drawing.Size(75, 23)
        Me.btnprint.TabIndex = 4
        Me.btnprint.Text = "Print User"
        Me.btnprint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 450)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.datarecord)
        Me.Controls.Add(Me.btnclose)
        Me.Controls.Add(Me.btnload)
        Me.Controls.Add(Me.btnadd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.datarecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnadd As Button
    Friend WithEvents btnload As Button
    Friend WithEvents btnclose As Button
    Friend WithEvents datarecord As DataGridView
    Friend WithEvents btnprint As Button
End Class
