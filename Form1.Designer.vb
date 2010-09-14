<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipmentRental
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
        Me.btnDisplayRentalRates = New System.Windows.Forms.Button()
        Me.btnDisplayBill = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lstRentalInformation = New System.Windows.Forms.ListBox()
        Me.lstBillingInformation = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnDisplayRentalRates
        '
        Me.btnDisplayRentalRates.Location = New System.Drawing.Point(12, 23)
        Me.btnDisplayRentalRates.Name = "btnDisplayRentalRates"
        Me.btnDisplayRentalRates.Size = New System.Drawing.Size(175, 70)
        Me.btnDisplayRentalRates.TabIndex = 0
        Me.btnDisplayRentalRates.Text = "Display Rental Rates"
        Me.btnDisplayRentalRates.UseVisualStyleBackColor = True
        '
        'btnDisplayBill
        '
        Me.btnDisplayBill.Location = New System.Drawing.Point(12, 191)
        Me.btnDisplayBill.Name = "btnDisplayBill"
        Me.btnDisplayBill.Size = New System.Drawing.Size(175, 38)
        Me.btnDisplayBill.TabIndex = 1
        Me.btnDisplayBill.Text = "Display Customer Bill"
        Me.btnDisplayBill.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select and Item (1, 2, or 3):"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Select a duration (H orF):"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(169, 110)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(17, 20)
        Me.TextBox1.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(169, 154)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(17, 20)
        Me.TextBox2.TabIndex = 5
        '
        'lstRentalInformation
        '
        Me.lstRentalInformation.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstRentalInformation.FormattingEnabled = True
        Me.lstRentalInformation.ItemHeight = 15
        Me.lstRentalInformation.Location = New System.Drawing.Point(305, 23)
        Me.lstRentalInformation.Name = "lstRentalInformation"
        Me.lstRentalInformation.Size = New System.Drawing.Size(512, 79)
        Me.lstRentalInformation.TabIndex = 6
        '
        'lstBillingInformation
        '
        Me.lstBillingInformation.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstBillingInformation.FormattingEnabled = True
        Me.lstBillingInformation.ItemHeight = 15
        Me.lstBillingInformation.Location = New System.Drawing.Point(305, 157)
        Me.lstBillingInformation.Name = "lstBillingInformation"
        Me.lstBillingInformation.Size = New System.Drawing.Size(512, 139)
        Me.lstBillingInformation.TabIndex = 7
        '
        'frmEquipmentRental
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 316)
        Me.Controls.Add(Me.lstBillingInformation)
        Me.Controls.Add(Me.lstRentalInformation)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDisplayBill)
        Me.Controls.Add(Me.btnDisplayRentalRates)
        Me.Name = "frmEquipmentRental"
        Me.Text = "Welcome to Eddie's Equipment Rental"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDisplayRentalRates As System.Windows.Forms.Button
    Friend WithEvents btnDisplayBill As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents lstRentalInformation As System.Windows.Forms.ListBox
    Friend WithEvents lstBillingInformation As System.Windows.Forms.ListBox

End Class
