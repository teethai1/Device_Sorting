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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGridViewDevice = New System.Windows.Forms.DataGridView()
        Me.DataGridViewPackage = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Device = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewDevice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewPackage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGridViewDevice
        '
        Me.DataGridViewDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewDevice.Location = New System.Drawing.Point(12, 76)
        Me.DataGridViewDevice.Name = "DataGridViewDevice"
        Me.DataGridViewDevice.RowHeadersVisible = False
        Me.DataGridViewDevice.RowTemplate.Height = 24
        Me.DataGridViewDevice.Size = New System.Drawing.Size(421, 378)
        Me.DataGridViewDevice.TabIndex = 0
        '
        'DataGridViewPackage
        '
        Me.DataGridViewPackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewPackage.Location = New System.Drawing.Point(439, 76)
        Me.DataGridViewPackage.Name = "DataGridViewPackage"
        Me.DataGridViewPackage.RowHeadersVisible = False
        Me.DataGridViewPackage.RowTemplate.Height = 24
        Me.DataGridViewPackage.Size = New System.Drawing.Size(286, 378)
        Me.DataGridViewPackage.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(439, 469)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 47)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "OpenFile CSV"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 469)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 47)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "OpenFile CSV"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(742, 468)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(123, 49)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "Sorting"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Device
        '
        Me.Device.AutoSize = True
        Me.Device.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Device.Location = New System.Drawing.Point(12, 20)
        Me.Device.Name = "Device"
        Me.Device.Size = New System.Drawing.Size(122, 39)
        Me.Device.TabIndex = 4
        Me.Device.Text = "Device"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(432, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "TP Rank"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(735, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 39)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Device List"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(742, 76)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(456, 378)
        Me.DataGridView2.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1210, 557)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Device)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridViewPackage)
        Me.Controls.Add(Me.DataGridViewDevice)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DataGridViewDevice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewPackage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DataGridViewDevice As DataGridView
    Friend WithEvents DataGridViewPackage As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Device As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
