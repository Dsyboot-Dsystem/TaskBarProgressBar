<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.trackBar1 = New System.Windows.Forms.TrackBar()
        Me.label2 = New System.Windows.Forms.Label()
        Me.button1 = New System.Windows.Forms.Button()
        Me.comboBox1 = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'trackBar1
        '
        Me.trackBar1.Location = New System.Drawing.Point(12, 105)
        Me.trackBar1.Maximum = 100
        Me.trackBar1.Name = "trackBar1"
        Me.trackBar1.Size = New System.Drawing.Size(224, 45)
        Me.trackBar1.TabIndex = 9
        Me.trackBar1.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.Location = New System.Drawing.Point(12, 77)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(108, 25)
        Me.label2.TabIndex = 8
        Me.label2.Text = "Value: 0"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(161, 36)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(75, 21)
        Me.button1.TabIndex = 7
        Me.button1.Text = "Aplicar"
        Me.button1.UseVisualStyleBackColor = True
        '
        'comboBox1
        '
        Me.comboBox1.FormattingEnabled = True
        Me.comboBox1.Items.AddRange(New Object() {"None", "Normal", "Paused", "Error", "Undefined"})
        Me.comboBox1.Location = New System.Drawing.Point(12, 37)
        Me.comboBox1.Name = "comboBox1"
        Me.comboBox1.Size = New System.Drawing.Size(121, 21)
        Me.comboBox1.TabIndex = 6
        Me.comboBox1.Text = "None"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(7, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 25)
        Me.label1.TabIndex = 5
        Me.label1.Text = "State:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(248, 157)
        Me.Controls.Add(Me.trackBar1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.comboBox1)
        Me.Controls.Add(Me.label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TaskBarTestVB"
        CType(Me.trackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents trackBar1 As TrackBar
    Private WithEvents label2 As Label
    Private WithEvents button1 As Button
    Private WithEvents comboBox1 As ComboBox
    Private WithEvents label1 As Label
End Class
