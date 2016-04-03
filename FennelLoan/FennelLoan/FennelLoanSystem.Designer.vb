<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FennelLoanSystem
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FennelLoanSystem))
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Group_1 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Dim ButtonBar1_Group_2 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup
        Me.ButtonBarContainerControl1 = New Janus.Windows.ButtonBar.ButtonBarContainerControl
        Me.BtnClientDashBoard = New System.Windows.Forms.Button
        Me.ImgListLeftMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.UiPanelManager1 = New Janus.Windows.UI.Dock.UIPanelManager(Me.components)
        Me.uiPanel0 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanel0Container = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar
        Me.uiPanel1 = New Janus.Windows.UI.Dock.UIPanel
        Me.uiPanelMainContainer = New Janus.Windows.UI.Dock.UIPanelInnerContainer
        Me.UiStatusBar1 = New Janus.Windows.UI.StatusBar.UIStatusBar
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.BtnClose = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ButtonBarContainerControl1.SuspendLayout()
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel0.SuspendLayout()
        Me.uiPanel0Container.SuspendLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ButtonBar1.SuspendLayout()
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.uiPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonBarContainerControl1
        '
        Me.ButtonBarContainerControl1.Controls.Add(Me.BtnClientDashBoard)
        Me.ButtonBarContainerControl1.Location = New System.Drawing.Point(1, 33)
        Me.ButtonBarContainerControl1.Name = "ButtonBarContainerControl1"
        Me.ButtonBarContainerControl1.Size = New System.Drawing.Size(163, 496)
        Me.ButtonBarContainerControl1.TabIndex = 2
        '
        'BtnClientDashBoard
        '
        Me.BtnClientDashBoard.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnClientDashBoard.AutoEllipsis = True
        Me.BtnClientDashBoard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BtnClientDashBoard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClientDashBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClientDashBoard.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClientDashBoard.ForeColor = System.Drawing.Color.Red
        Me.BtnClientDashBoard.ImageIndex = 0
        Me.BtnClientDashBoard.ImageList = Me.ImgListLeftMenu
        Me.BtnClientDashBoard.Location = New System.Drawing.Point(4, 5)
        Me.BtnClientDashBoard.Name = "BtnClientDashBoard"
        Me.BtnClientDashBoard.Size = New System.Drawing.Size(157, 41)
        Me.BtnClientDashBoard.TabIndex = 0
        Me.BtnClientDashBoard.Text = "Client"
        Me.BtnClientDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BtnClientDashBoard.UseVisualStyleBackColor = True
        '
        'ImgListLeftMenu
        '
        Me.ImgListLeftMenu.ImageStream = CType(resources.GetObject("ImgListLeftMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImgListLeftMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.ImgListLeftMenu.Images.SetKeyName(0, "business.png")
        Me.ImgListLeftMenu.Images.SetKeyName(1, "close.png")
        Me.ImgListLeftMenu.Images.SetKeyName(2, "coins.png")
        Me.ImgListLeftMenu.Images.SetKeyName(3, "computer.png")
        Me.ImgListLeftMenu.Images.SetKeyName(4, "exchange.png")
        Me.ImgListLeftMenu.Images.SetKeyName(5, "people.png")
        '
        'UiPanelManager1
        '
        Me.UiPanelManager1.ContainerControl = Me
        Me.UiPanelManager1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Standard
        Me.uiPanel0.Id = New System.Guid("4548b79a-e994-4079-8f8f-79942cef7c65")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel0)
        Me.uiPanel1.Id = New System.Guid("d2df805a-6c78-48dc-bf6a-0df4cb54849e")
        Me.UiPanelManager1.Panels.Add(Me.uiPanel1)
        '
        'Design Time Panel Info:
        '
        Me.UiPanelManager1.BeginPanelInfo()
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("4548b79a-e994-4079-8f8f-79942cef7c65"), Janus.Windows.UI.Dock.PanelDockStyle.Left, New System.Drawing.Size(171, 596), True)
        Me.UiPanelManager1.AddDockPanelInfo(New System.Guid("d2df805a-6c78-48dc-bf6a-0df4cb54849e"), Janus.Windows.UI.Dock.PanelDockStyle.Fill, New System.Drawing.Size(1078, 596), True)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("4548b79a-e994-4079-8f8f-79942cef7c65"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.AddFloatingPanelInfo(New System.Guid("d2df805a-6c78-48dc-bf6a-0df4cb54849e"), New System.Drawing.Point(-1, -1), New System.Drawing.Size(-1, -1), False)
        Me.UiPanelManager1.EndPanelInfo()
        '
        'uiPanel0
        '
        Me.uiPanel0.AutoHideButtonVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.BorderCaption = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.CaptionStyle = Janus.Windows.UI.Dock.PanelCaptionStyle.Dark
        Me.uiPanel0.CaptionVisible = Janus.Windows.UI.InheritableBoolean.[False]
        Me.uiPanel0.InnerContainer = Me.uiPanel0Container
        Me.uiPanel0.Location = New System.Drawing.Point(3, 69)
        Me.uiPanel0.Name = "uiPanel0"
        Me.uiPanel0.Size = New System.Drawing.Size(171, 596)
        Me.uiPanel0.TabIndex = 4
        '
        'uiPanel0Container
        '
        Me.uiPanel0Container.Controls.Add(Me.ButtonBar1)
        Me.uiPanel0Container.Location = New System.Drawing.Point(1, 1)
        Me.uiPanel0Container.Name = "uiPanel0Container"
        Me.uiPanel0Container.Size = New System.Drawing.Size(165, 594)
        Me.uiPanel0Container.TabIndex = 0
        '
        'ButtonBar1
        '
        Me.ButtonBar1.BorderStyle = Janus.Windows.ButtonBar.BorderStyle.Flat
        Me.ButtonBar1.Controls.Add(Me.ButtonBarContainerControl1)
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Fill
        ButtonBar1_Group_0.Container = True
        ButtonBar1_Group_0.ContainerControl = Me.ButtonBarContainerControl1
        ButtonBar1_Group_0.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_0.ItemsStateStyles.FormatStyle.Font = New System.Drawing.Font("Khmer OS Muol Light", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.Text = "អតិថិជន"
        ButtonBar1_Group_1.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_1.Key = "Group2"
        ButtonBar1_Group_1.Text = "New Group"
        ButtonBar1_Group_2.Cursor = System.Windows.Forms.Cursors.Hand
        ButtonBar1_Group_2.Key = "Group3"
        ButtonBar1_Group_2.Text = "New Group"
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0, ButtonBar1_Group_1, ButtonBar1_Group_2})
        Me.ButtonBar1.GroupsStateStyles.FormatStyle.Font = New System.Drawing.Font("Khmer OS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonBar1.GroupsStateStyles.FormatStyle.FontSize = 12.0!
        Me.ButtonBar1.GroupsStateStyles.FormatStyle.ForeColor = System.Drawing.Color.Blue
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 0)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(165, 594)
        Me.ButtonBar1.TabIndex = 0
        Me.ButtonBar1.Text = "ButtonBar1"
        Me.ButtonBar1.VisualStyleAreas.BackgroundStyle = Janus.Windows.ButtonBar.VisualStyle.Standard
        Me.ButtonBar1.VisualStyleAreas.ControlBorderStyle = Janus.Windows.ButtonBar.VisualStyle.Standard
        Me.ButtonBar1.VisualStyleAreas.GroupsStyle = Janus.Windows.ButtonBar.VisualStyle.Standard
        Me.ButtonBar1.VisualStyleAreas.ItemsStyle = Janus.Windows.ButtonBar.VisualStyle.Standard
        '
        'uiPanel1
        '
        Me.uiPanel1.InnerContainer = Me.uiPanelMainContainer
        Me.uiPanel1.Location = New System.Drawing.Point(174, 69)
        Me.uiPanel1.Name = "uiPanel1"
        Me.uiPanel1.Size = New System.Drawing.Size(1078, 596)
        Me.uiPanel1.TabIndex = 4
        Me.uiPanel1.Text = "Panel 1"
        '
        'uiPanelMainContainer
        '
        Me.uiPanelMainContainer.AutoScroll = True
        Me.uiPanelMainContainer.BackColor = System.Drawing.SystemColors.Control
        Me.uiPanelMainContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.uiPanelMainContainer.Location = New System.Drawing.Point(1, 1)
        Me.uiPanelMainContainer.Margin = New System.Windows.Forms.Padding(2)
        Me.uiPanelMainContainer.Name = "uiPanelMainContainer"
        Me.uiPanelMainContainer.Size = New System.Drawing.Size(1076, 594)
        Me.uiPanelMainContainer.TabIndex = 6
        '
        'UiStatusBar1
        '
        Me.UiStatusBar1.Location = New System.Drawing.Point(0, 668)
        Me.UiStatusBar1.Name = "UiStatusBar1"
        Me.UiStatusBar1.Size = New System.Drawing.Size(1255, 23)
        Me.UiStatusBar1.TabIndex = 4
        Me.UiStatusBar1.VisualStyle = Janus.Windows.UI.VisualStyle.Standard
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton1, Me.ToolStripSeparator1, Me.ToolStripButton3, Me.ToolStripSeparator5, Me.ToolStripButton2, Me.ToolStripSeparator2, Me.ToolStripButton5, Me.ToolStripSeparator6, Me.BtnClose, Me.ToolStripSeparator4})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1255, 66)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripButton4.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton4.Image = Global.FennelLoan.My.Resources.Resources.business
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(76, 63)
        Me.ToolStripButton4.Text = "    Client   "
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripButton1.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton1.Image = Global.FennelLoan.My.Resources.Resources.coins
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(106, 63)
        Me.ToolStripButton1.Text = "    New Loan    "
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripButton3.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton3.Image = Global.FennelLoan.My.Resources.Resources.people
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(77, 63)
        Me.ToolStripButton3.Text = "    Teller    "
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripButton2.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton2.Image = Global.FennelLoan.My.Resources.Resources.computer
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(126, 63)
        Me.ToolStripButton2.Text = "    Credit Officer    "
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 66)
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ToolStripButton5.ForeColor = System.Drawing.Color.Red
        Me.ToolStripButton5.Image = Global.FennelLoan.My.Resources.Resources.exchange
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(129, 63)
        Me.ToolStripButton5.Text = "Currency Exchange"
        Me.ToolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(6, 66)
        '
        'BtnClose
        '
        Me.BtnClose.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.BtnClose.ForeColor = System.Drawing.Color.Blue
        Me.BtnClose.Image = Global.FennelLoan.My.Resources.Resources.close
        Me.BtnClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(78, 63)
        Me.BtnClose.Text = "    Close    "
        Me.BtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 66)
        '
        'FennelLoanSystem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1255, 691)
        Me.Controls.Add(Me.uiPanel1)
        Me.Controls.Add(Me.uiPanel0)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.UiStatusBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FennelLoanSystem"
        Me.Text = "Fennel-Loan System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ButtonBarContainerControl1.ResumeLayout(False)
        CType(Me.UiPanelManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uiPanel0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel0.ResumeLayout(False)
        Me.uiPanel0Container.ResumeLayout(False)
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ButtonBar1.ResumeLayout(False)
        CType(Me.uiPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.uiPanel1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents UiPanelManager1 As Janus.Windows.UI.Dock.UIPanelManager
    Friend WithEvents uiPanel1 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0 As Janus.Windows.UI.Dock.UIPanel
    Friend WithEvents uiPanel0Container As Janus.Windows.UI.Dock.UIPanelInnerContainer
    Friend WithEvents UiStatusBar1 As Janus.Windows.UI.StatusBar.UIStatusBar
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents ButtonBarContainerControl1 As Janus.Windows.ButtonBar.ButtonBarContainerControl
    Friend WithEvents BtnClientDashBoard As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BtnClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImgListLeftMenu As System.Windows.Forms.ImageList
    Friend WithEvents uiPanelMainContainer As Janus.Windows.UI.Dock.UIPanelInnerContainer

End Class
