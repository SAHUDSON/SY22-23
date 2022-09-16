<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dropdownBody = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dropdownFill = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dropdownMisc = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dropdownTop = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Vladimir Script", 25.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(369, 52)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Customize Your Cookie!"
        '
        'dropdownBody
        '
        Me.dropdownBody.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropdownBody.FormattingEnabled = True
        Me.dropdownBody.Items.AddRange(New Object() {"Classic soft - $0.65", "Sugar cookie - $0.60", "Oatmeal - $0.50", "Red velvet - $0.80", "Peanut butter - $0.65", "Chocolate - $0.75", "Chocolate oatmeal - $0.65"})
        Me.dropdownBody.Location = New System.Drawing.Point(47, 182)
        Me.dropdownBody.MaxDropDownItems = 5
        Me.dropdownBody.Name = "dropdownBody"
        Me.dropdownBody.Size = New System.Drawing.Size(121, 28)
        Me.dropdownBody.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(39, 125)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(226, 45)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Body dough"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 45)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Filling"
        '
        'dropdownFill
        '
        Me.dropdownFill.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropdownFill.FormattingEnabled = True
        Me.dropdownFill.Items.AddRange(New Object() {"None", "Chocolate chip - $0.10", "Hazelnut - $0.06", "Pecan - $0.05", "Peanut $0.07", "Raisin - $0.15"})
        Me.dropdownFill.Location = New System.Drawing.Point(47, 299)
        Me.dropdownFill.MaxDropDownItems = 5
        Me.dropdownFill.Name = "dropdownFill"
        Me.dropdownFill.Size = New System.Drawing.Size(121, 28)
        Me.dropdownFill.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 474)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(264, 45)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Miscellaneous"
        '
        'dropdownMisc
        '
        Me.dropdownMisc.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropdownMisc.FormattingEnabled = True
        Me.dropdownMisc.Items.AddRange(New Object() {"None", "Ganache stuffing - $0.20", "Hard-baked"})
        Me.dropdownMisc.Location = New System.Drawing.Point(47, 531)
        Me.dropdownMisc.MaxDropDownItems = 5
        Me.dropdownMisc.Name = "dropdownMisc"
        Me.dropdownMisc.Size = New System.Drawing.Size(121, 28)
        Me.dropdownMisc.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 25.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 357)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 45)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Topping"
        '
        'dropdownTop
        '
        Me.dropdownTop.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dropdownTop.FormattingEnabled = True
        Me.dropdownTop.Items.AddRange(New Object() {"None", "Vanilla frosting - $0.10", "Chocolate frosting - $0.12", "Hazelnut drizzle - $0.10", "Vanilla drizzle - $0.08", "Chocolate drizzle - $0.10", "Coconut - $0.15"})
        Me.dropdownTop.Location = New System.Drawing.Point(47, 414)
        Me.dropdownTop.MaxDropDownItems = 5
        Me.dropdownTop.Name = "dropdownTop"
        Me.dropdownTop.Size = New System.Drawing.Size(121, 28)
        Me.dropdownTop.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(425, 378)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 27)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "Continue with order"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 805)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dropdownMisc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dropdownTop)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dropdownFill)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dropdownBody)
        Me.Controls.Add(Me.Label7)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents dropdownBody As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dropdownFill As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dropdownMisc As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dropdownTop As ComboBox
    Friend WithEvents Button1 As Button
End Class
