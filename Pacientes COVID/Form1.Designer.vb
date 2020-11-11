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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_all = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_dia = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_oe = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_age = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_fie = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_cans = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_ts = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_hip = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_ob = New System.Windows.Forms.ComboBox()
        Me.txt_status = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_state = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.dg_view = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.txt_no = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_view, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_search
        '
        Me.btn_search.Location = New System.Drawing.Point(687, 102)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(78, 21)
        Me.btn_search.TabIndex = 0
        Me.btn_search.Text = "Buscar"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btn_clear)
        Me.Panel1.Controls.Add(Me.btn_all)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmb_dia)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txt_oe)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.txt_age)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.cmb_fie)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.cmb_cans)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.cmb_ts)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.cmb_hip)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.cmb_ob)
        Me.Panel1.Controls.Add(Me.txt_status)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txt_state)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txt_name)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btn_update)
        Me.Panel1.Controls.Add(Me.dg_view)
        Me.Panel1.Controls.Add(Me.btn_search)
        Me.Panel1.Controls.Add(Me.btn_delete)
        Me.Panel1.Controls.Add(Me.btn_save)
        Me.Panel1.Controls.Add(Me.txt_no)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(776, 426)
        Me.Panel1.TabIndex = 4
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(687, 72)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(78, 21)
        Me.btn_clear.TabIndex = 42
        Me.btn_clear.Text = "Limpiar"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_all
        '
        Me.btn_all.Location = New System.Drawing.Point(533, 7)
        Me.btn_all.Name = "btn_all"
        Me.btn_all.Size = New System.Drawing.Size(138, 39)
        Me.btn_all.TabIndex = 41
        Me.btn_all.Text = "Mostrar todos los registros"
        Me.btn_all.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(82, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 40
        Me.Label13.Text = "Diabetes"
        '
        'cmb_dia
        '
        Me.cmb_dia.DisplayMember = "NO"
        Me.cmb_dia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_dia.FormattingEnabled = True
        Me.cmb_dia.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmb_dia.Location = New System.Drawing.Point(85, 126)
        Me.cmb_dia.Name = "cmb_dia"
        Me.cmb_dia.Size = New System.Drawing.Size(67, 21)
        Me.cmb_dia.TabIndex = 39
        Me.cmb_dia.ValueMember = "NO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(530, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 13)
        Me.Label12.TabIndex = 38
        Me.Label12.Text = "Otras Enfermedades"
        '
        'txt_oe
        '
        Me.txt_oe.Location = New System.Drawing.Point(533, 88)
        Me.txt_oe.Multiline = True
        Me.txt_oe.Name = "txt_oe"
        Me.txt_oe.Size = New System.Drawing.Size(148, 63)
        Me.txt_oe.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(464, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 36
        Me.Label11.Text = "Edad"
        '
        'txt_age
        '
        Me.txt_age.Location = New System.Drawing.Point(467, 128)
        Me.txt_age.Name = "txt_age"
        Me.txt_age.Size = New System.Drawing.Size(50, 20)
        Me.txt_age.TabIndex = 35
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(395, 111)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 13)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Fiebre"
        '
        'cmb_fie
        '
        Me.cmb_fie.DisplayMember = "NO"
        Me.cmb_fie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_fie.FormattingEnabled = True
        Me.cmb_fie.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmb_fie.Location = New System.Drawing.Point(398, 127)
        Me.cmb_fie.Name = "cmb_fie"
        Me.cmb_fie.Size = New System.Drawing.Size(57, 21)
        Me.cmb_fie.TabIndex = 33
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(325, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "Cansancio"
        '
        'cmb_cans
        '
        Me.cmb_cans.DisplayMember = "NO"
        Me.cmb_cans.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cans.FormattingEnabled = True
        Me.cmb_cans.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmb_cans.Location = New System.Drawing.Point(328, 126)
        Me.cmb_cans.Name = "cmb_cans"
        Me.cmb_cans.Size = New System.Drawing.Size(57, 21)
        Me.cmb_cans.TabIndex = 31
        Me.cmb_cans.ValueMember = "NO"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(252, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Tos Seca"
        '
        'cmb_ts
        '
        Me.cmb_ts.DisplayMember = "NO"
        Me.cmb_ts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ts.FormattingEnabled = True
        Me.cmb_ts.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmb_ts.Location = New System.Drawing.Point(255, 127)
        Me.cmb_ts.Name = "cmb_ts"
        Me.cmb_ts.Size = New System.Drawing.Size(57, 21)
        Me.cmb_ts.TabIndex = 29
        Me.cmb_ts.ValueMember = "NO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(168, 110)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Hipertencion"
        '
        'cmb_hip
        '
        Me.cmb_hip.DisplayMember = "NO"
        Me.cmb_hip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_hip.FormattingEnabled = True
        Me.cmb_hip.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmb_hip.Location = New System.Drawing.Point(171, 126)
        Me.cmb_hip.Name = "cmb_hip"
        Me.cmb_hip.Size = New System.Drawing.Size(67, 21)
        Me.cmb_hip.TabIndex = 27
        Me.cmb_hip.ValueMember = "NO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 110)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Obesidad"
        '
        'cmb_ob
        '
        Me.cmb_ob.DisplayMember = "NO"
        Me.cmb_ob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ob.FormattingEnabled = True
        Me.cmb_ob.Items.AddRange(New Object() {"NO", "SI"})
        Me.cmb_ob.Location = New System.Drawing.Point(15, 126)
        Me.cmb_ob.Name = "cmb_ob"
        Me.cmb_ob.Size = New System.Drawing.Size(57, 21)
        Me.cmb_ob.TabIndex = 25
        Me.cmb_ob.ValueMember = "NO"
        '
        'txt_status
        '
        Me.txt_status.Location = New System.Drawing.Point(313, 88)
        Me.txt_status.Name = "txt_status"
        Me.txt_status.Size = New System.Drawing.Size(126, 20)
        Me.txt_status.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(310, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Estatus Covid"
        '
        'txt_state
        '
        Me.txt_state.Location = New System.Drawing.Point(161, 88)
        Me.txt_state.Name = "txt_state"
        Me.txt_state.Size = New System.Drawing.Size(126, 20)
        Me.txt_state.TabIndex = 22
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(158, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Estado"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(15, 88)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(126, 20)
        Me.txt_name.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Nombre del paciente"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(687, 130)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(78, 21)
        Me.btn_update.TabIndex = 14
        Me.btn_update.Text = "Actualizar"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'dg_view
        '
        Me.dg_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_view.Location = New System.Drawing.Point(0, 157)
        Me.dg_view.Name = "dg_view"
        Me.dg_view.Size = New System.Drawing.Size(776, 266)
        Me.dg_view.TabIndex = 13
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(687, 41)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(78, 21)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Eliminar"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(687, 7)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(78, 21)
        Me.btn_save.TabIndex = 2
        Me.btn_save.Text = "Guardar"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'txt_no
        '
        Me.txt_no.Location = New System.Drawing.Point(15, 49)
        Me.txt_no.Name = "txt_no"
        Me.txt_no.Size = New System.Drawing.Size(75, 20)
        Me.txt_no.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Control"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Captura de Datos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Pacientes COVID"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_view, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents btn_search As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_no As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_view As DataGridView
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_cans As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_ts As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_hip As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_ob As ComboBox
    Friend WithEvents txt_status As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_state As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents txt_oe As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txt_age As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_fie As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_dia As ComboBox
    Friend WithEvents btn_all As Button
    Friend WithEvents btn_clear As Button
End Class
