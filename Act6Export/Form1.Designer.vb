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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BASICPAYDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GROSSAMOUNTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WATXDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaySlipBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PayrollDataSet = New Act5DataLoading.PayrollDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PaySlipTableAdapter = New Act5DataLoading.PayrollDataSetTableAdapters.PaySlipTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PaySlipBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NAMEDataGridViewTextBoxColumn, Me.BASICPAYDataGridViewTextBoxColumn, Me.GROSSAMOUNTDataGridViewTextBoxColumn, Me.WATXDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PaySlipBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DataGridView1.Size = New System.Drawing.Size(518, 345)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NAMEDataGridViewTextBoxColumn
        '
        Me.NAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.HeaderText = "NAME"
        Me.NAMEDataGridViewTextBoxColumn.Name = "NAMEDataGridViewTextBoxColumn"
        '
        'BASICPAYDataGridViewTextBoxColumn
        '
        Me.BASICPAYDataGridViewTextBoxColumn.DataPropertyName = "BASICPAY"
        Me.BASICPAYDataGridViewTextBoxColumn.HeaderText = "BASICPAY"
        Me.BASICPAYDataGridViewTextBoxColumn.Name = "BASICPAYDataGridViewTextBoxColumn"
        '
        'GROSSAMOUNTDataGridViewTextBoxColumn
        '
        Me.GROSSAMOUNTDataGridViewTextBoxColumn.DataPropertyName = "GROSSAMOUNT"
        Me.GROSSAMOUNTDataGridViewTextBoxColumn.HeaderText = "GROSSAMOUNT"
        Me.GROSSAMOUNTDataGridViewTextBoxColumn.Name = "GROSSAMOUNTDataGridViewTextBoxColumn"
        '
        'WATXDataGridViewTextBoxColumn
        '
        Me.WATXDataGridViewTextBoxColumn.DataPropertyName = "WATX"
        Me.WATXDataGridViewTextBoxColumn.HeaderText = "WATX"
        Me.WATXDataGridViewTextBoxColumn.Name = "WATXDataGridViewTextBoxColumn"
        '
        'PaySlipBindingSource
        '
        Me.PaySlipBindingSource.DataMember = "PaySlip"
        Me.PaySlipBindingSource.DataSource = Me.PayrollDataSet
        '
        'PayrollDataSet
        '
        Me.PayrollDataSet.DataSetName = "PayrollDataSet"
        Me.PayrollDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(374, 372)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "EXPORT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PaySlipTableAdapter
        '
        Me.PaySlipTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 449)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Export to Excel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PaySlipBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PayrollDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PayrollDataSet As PayrollDataSet
    Friend WithEvents PaySlipBindingSource As BindingSource
    Friend WithEvents PaySlipTableAdapter As PayrollDataSetTableAdapters.PaySlipTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BASICPAYDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GROSSAMOUNTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WATXDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
