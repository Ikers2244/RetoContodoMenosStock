<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PanelPrincipal = New System.Windows.Forms.Panel()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.PanelBot = New System.Windows.Forms.Panel()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.btnRestar = New Guna.UI2.WinForms.Guna2Button()
        Me.btnSumar = New Guna.UI2.WinForms.Guna2Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.btnFin = New Guna.UI2.WinForms.Guna2Button()
        Me.btnAñadir = New Guna.UI2.WinForms.Guna2Button()
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.ibEntrantes = New FontAwesome.Sharp.IconButton()
        Me.ibBebidas = New FontAwesome.Sharp.IconButton()
        Me.ibPrincipal = New FontAwesome.Sharp.IconButton()
        Me.lbla = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanelTop.SuspendLayout()
        Me.PanelBot.SuspendLayout()
        Me.PanelMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.PanelPrincipal)
        Me.Panel1.Controls.Add(Me.PanelTop)
        Me.Panel1.Controls.Add(Me.PanelBot)
        Me.Panel1.Controls.Add(Me.PanelMenu)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1671, 749)
        Me.Panel1.TabIndex = 0
        '
        'PanelPrincipal
        '
        Me.PanelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelPrincipal.Location = New System.Drawing.Point(230, 80)
        Me.PanelPrincipal.Name = "PanelPrincipal"
        Me.PanelPrincipal.Size = New System.Drawing.Size(1441, 311)
        Me.PanelPrincipal.TabIndex = 4
        '
        'PanelTop
        '
        Me.PanelTop.BackColor = System.Drawing.Color.MediumPurple
        Me.PanelTop.Controls.Add(Me.lblTitulo)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(230, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(1441, 80)
        Me.PanelTop.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Century Gothic", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblTitulo.Location = New System.Drawing.Point(668, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(0, 27)
        Me.lblTitulo.TabIndex = 0
        '
        'PanelBot
        '
        Me.PanelBot.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.PanelBot.Controls.Add(Me.lbla)
        Me.PanelBot.Controls.Add(Me.lblCantidad)
        Me.PanelBot.Controls.Add(Me.btnRestar)
        Me.PanelBot.Controls.Add(Me.btnSumar)
        Me.PanelBot.Controls.Add(Me.lblTotal)
        Me.PanelBot.Controls.Add(Me.lblNombre)
        Me.PanelBot.Controls.Add(Me.btnFin)
        Me.PanelBot.Controls.Add(Me.btnAñadir)
        Me.PanelBot.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanelBot.Location = New System.Drawing.Point(230, 391)
        Me.PanelBot.Name = "PanelBot"
        Me.PanelBot.Size = New System.Drawing.Size(1441, 358)
        Me.PanelBot.TabIndex = 2
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblCantidad.Location = New System.Drawing.Point(566, 125)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(31, 34)
        Me.lblCantidad.TabIndex = 15
        Me.lblCantidad.Text = "1"
        '
        'btnRestar
        '
        Me.btnRestar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnRestar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnRestar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnRestar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnRestar.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnRestar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnRestar.ForeColor = System.Drawing.Color.White
        Me.btnRestar.Location = New System.Drawing.Point(436, 125)
        Me.btnRestar.Name = "btnRestar"
        Me.btnRestar.Size = New System.Drawing.Size(72, 50)
        Me.btnRestar.TabIndex = 14
        Me.btnRestar.Text = "-"
        '
        'btnSumar
        '
        Me.btnSumar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnSumar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnSumar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnSumar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnSumar.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnSumar.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSumar.ForeColor = System.Drawing.Color.White
        Me.btnSumar.Location = New System.Drawing.Point(668, 125)
        Me.btnSumar.Name = "btnSumar"
        Me.btnSumar.Size = New System.Drawing.Size(72, 50)
        Me.btnSumar.TabIndex = 13
        Me.btnSumar.Text = "+"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTotal.Location = New System.Drawing.Point(115, 160)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(31, 34)
        Me.lblTotal.TabIndex = 12
        Me.lblTotal.Text = "0"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblNombre.Location = New System.Drawing.Point(23, 160)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(86, 34)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Total:"
        '
        'btnFin
        '
        Me.btnFin.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnFin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnFin.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnFin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnFin.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnFin.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFin.ForeColor = System.Drawing.Color.White
        Me.btnFin.Location = New System.Drawing.Point(929, 160)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(190, 63)
        Me.btnFin.TabIndex = 10
        Me.btnFin.Text = "Ver Pedido"
        '
        'btnAñadir
        '
        Me.btnAñadir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnAñadir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnAñadir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnAñadir.FillColor = System.Drawing.Color.MediumSlateBlue
        Me.btnAñadir.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAñadir.ForeColor = System.Drawing.Color.White
        Me.btnAñadir.Location = New System.Drawing.Point(1209, 160)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(190, 63)
        Me.btnAñadir.TabIndex = 9
        Me.btnAñadir.Text = "Añadir al carrito"
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.SkyBlue
        Me.PanelMenu.Controls.Add(Me.ibEntrantes)
        Me.PanelMenu.Controls.Add(Me.ibBebidas)
        Me.PanelMenu.Controls.Add(Me.ibPrincipal)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Size = New System.Drawing.Size(230, 749)
        Me.PanelMenu.TabIndex = 1
        '
        'ibEntrantes
        '
        Me.ibEntrantes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibEntrantes.FlatAppearance.BorderSize = 0
        Me.ibEntrantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibEntrantes.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibEntrantes.ForeColor = System.Drawing.Color.Black
        Me.ibEntrantes.IconChar = FontAwesome.Sharp.IconChar.Bacon
        Me.ibEntrantes.IconColor = System.Drawing.Color.Black
        Me.ibEntrantes.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibEntrantes.IconSize = 45
        Me.ibEntrantes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibEntrantes.Location = New System.Drawing.Point(0, 208)
        Me.ibEntrantes.Name = "ibEntrantes"
        Me.ibEntrantes.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibEntrantes.Size = New System.Drawing.Size(230, 104)
        Me.ibEntrantes.TabIndex = 5
        Me.ibEntrantes.Text = "      Entrantes"
        Me.ibEntrantes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibEntrantes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibEntrantes.UseVisualStyleBackColor = True
        '
        'ibBebidas
        '
        Me.ibBebidas.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibBebidas.FlatAppearance.BorderSize = 0
        Me.ibBebidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibBebidas.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibBebidas.ForeColor = System.Drawing.Color.Black
        Me.ibBebidas.IconChar = FontAwesome.Sharp.IconChar.GlassCheers
        Me.ibBebidas.IconColor = System.Drawing.Color.Black
        Me.ibBebidas.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibBebidas.IconSize = 50
        Me.ibBebidas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibBebidas.Location = New System.Drawing.Point(0, 104)
        Me.ibBebidas.Name = "ibBebidas"
        Me.ibBebidas.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibBebidas.Size = New System.Drawing.Size(230, 104)
        Me.ibBebidas.TabIndex = 4
        Me.ibBebidas.Text = "      Bebidas"
        Me.ibBebidas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibBebidas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibBebidas.UseVisualStyleBackColor = True
        '
        'ibPrincipal
        '
        Me.ibPrincipal.Dock = System.Windows.Forms.DockStyle.Top
        Me.ibPrincipal.FlatAppearance.BorderSize = 0
        Me.ibPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ibPrincipal.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ibPrincipal.ForeColor = System.Drawing.Color.Black
        Me.ibPrincipal.IconChar = FontAwesome.Sharp.IconChar.Burger
        Me.ibPrincipal.IconColor = System.Drawing.Color.Black
        Me.ibPrincipal.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.ibPrincipal.IconSize = 40
        Me.ibPrincipal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.ibPrincipal.Name = "ibPrincipal"
        Me.ibPrincipal.Padding = New System.Windows.Forms.Padding(10, 0, 5, 0)
        Me.ibPrincipal.Size = New System.Drawing.Size(230, 104)
        Me.ibPrincipal.TabIndex = 3
        Me.ibPrincipal.Text = "  Platos Principales"
        Me.ibPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ibPrincipal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ibPrincipal.UseVisualStyleBackColor = True
        '
        'lbla
        '
        Me.lbla.AutoSize = True
        Me.lbla.Font = New System.Drawing.Font("Century Gothic", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lbla.Location = New System.Drawing.Point(241, 151)
        Me.lbla.Name = "lbla"
        Me.lbla.Size = New System.Drawing.Size(86, 34)
        Me.lbla.TabIndex = 16
        Me.lbla.Text = "Total:"
        '
        'FormPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1671, 749)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.Name = "FormPedidos"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.PanelTop.ResumeLayout(False)
        Me.PanelTop.PerformLayout()
        Me.PanelBot.ResumeLayout(False)
        Me.PanelBot.PerformLayout()
        Me.PanelMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents PanelBot As Panel
    Friend WithEvents PanelPrincipal As Panel
    Friend WithEvents PanelTop As Panel
    Friend WithEvents ibPrincipal As FontAwesome.Sharp.IconButton
    Friend WithEvents ibEntrantes As FontAwesome.Sharp.IconButton
    Friend WithEvents ibBebidas As FontAwesome.Sharp.IconButton
    Friend WithEvents lblTitulo As Label
    Friend WithEvents btnFin As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnAñadir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCantidad As Label
    Friend WithEvents btnRestar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnSumar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lbla As Label
End Class
