Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel3 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel3_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel4 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel4_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.barManager1 = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
			Me.barButtonItem4 = New DevExpress.XtraBars.BarButtonItem()
			Me.popupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panelContainer1.SuspendLayout()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			Me.dockPanel3.SuspendLayout()
			Me.dockPanel4.SuspendLayout()
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})
			' 
			' panelContainer1
			' 
			Me.panelContainer1.ActiveChild = Me.dockPanel1
			Me.panelContainer1.Controls.Add(Me.dockPanel1)
			Me.panelContainer1.Controls.Add(Me.dockPanel2)
			Me.panelContainer1.Controls.Add(Me.dockPanel3)
			Me.panelContainer1.Controls.Add(Me.dockPanel4)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.panelContainer1.FloatVertical = True
			Me.panelContainer1.ID = New System.Guid("e41404a5-5326-45ee-8530-93039fe42801")
			Me.panelContainer1.Location = New System.Drawing.Point(313, 0)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(175, 200)
			Me.panelContainer1.Size = New System.Drawing.Size(175, 306)
			Me.panelContainer1.Tabbed = True
			Me.panelContainer1.TabsScroll = True
			Me.panelContainer1.Text = "panelContainer1"
'			Me.panelContainer1.MouseClick += New System.Windows.Forms.MouseEventHandler(Me.panelContainer1_MouseClick);
			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel1.FloatVertical = True
			Me.dockPanel1.ID = New System.Guid("8dfb842d-9e1e-4948-9e1d-71dcc43d79c5")
			Me.dockPanel1.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(169, 256)
			Me.dockPanel1.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel1.Text = "dockPanel1"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel2.ID = New System.Guid("eabe0052-02f7-42ce-80d6-e8ed02b972ae")
			Me.dockPanel2.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(169, 256)
			Me.dockPanel2.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel2.Text = "dockPanel2"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' dockPanel3
			' 
			Me.dockPanel3.Controls.Add(Me.dockPanel3_Container)
			Me.dockPanel3.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel3.ID = New System.Guid("92e18de3-ffba-4500-90f7-270fc884e98b")
			Me.dockPanel3.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel3.Name = "dockPanel3"
			Me.dockPanel3.OriginalSize = New System.Drawing.Size(169, 256)
			Me.dockPanel3.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel3.Text = "dockPanel3"
			' 
			' dockPanel3_Container
			' 
			Me.dockPanel3_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel3_Container.Name = "dockPanel3_Container"
			Me.dockPanel3_Container.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel3_Container.TabIndex = 0
			' 
			' dockPanel4
			' 
			Me.dockPanel4.Controls.Add(Me.dockPanel4_Container)
			Me.dockPanel4.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel4.FloatVertical = True
			Me.dockPanel4.ID = New System.Guid("843e570e-f3ec-4e4f-844e-f5e6ac506728")
			Me.dockPanel4.Location = New System.Drawing.Point(3, 25)
			Me.dockPanel4.Name = "dockPanel4"
			Me.dockPanel4.OriginalSize = New System.Drawing.Size(169, 256)
			Me.dockPanel4.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel4.Text = "dockPanel4"
			' 
			' dockPanel4_Container
			' 
			Me.dockPanel4_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel4_Container.Name = "dockPanel4_Container"
			Me.dockPanel4_Container.Size = New System.Drawing.Size(169, 256)
			Me.dockPanel4_Container.TabIndex = 0
			' 
			' barManager1
			' 
			Me.barManager1.DockControls.Add(Me.barDockControlTop)
			Me.barManager1.DockControls.Add(Me.barDockControlBottom)
			Me.barManager1.DockControls.Add(Me.barDockControlLeft)
			Me.barManager1.DockControls.Add(Me.barDockControlRight)
			Me.barManager1.DockManager = Me.dockManager1
			Me.barManager1.Form = Me
			Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barButtonItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem4})
			Me.barManager1.MaxItemId = 4
			' 
			' barDockControlTop
			' 
			Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
			Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlTop.Size = New System.Drawing.Size(488, 0)
			' 
			' barDockControlBottom
			' 
			Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.barDockControlBottom.Location = New System.Drawing.Point(0, 306)
			Me.barDockControlBottom.Size = New System.Drawing.Size(488, 0)
			' 
			' barDockControlLeft
			' 
			Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
			Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
			Me.barDockControlLeft.Size = New System.Drawing.Size(0, 306)
			' 
			' barDockControlRight
			' 
			Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
			Me.barDockControlRight.Location = New System.Drawing.Point(488, 0)
			Me.barDockControlRight.Size = New System.Drawing.Size(0, 306)
			' 
			' barButtonItem1
			' 
			Me.barButtonItem1.Caption = "DockPanel1"
			Me.barButtonItem1.Id = 0
			Me.barButtonItem1.Name = "barButtonItem1"
			' 
			' barButtonItem2
			' 
			Me.barButtonItem2.Caption = "DockPanel2"
			Me.barButtonItem2.Id = 1
			Me.barButtonItem2.Name = "barButtonItem2"
			' 
			' barButtonItem3
			' 
			Me.barButtonItem3.Caption = "DockPanel3"
			Me.barButtonItem3.Id = 2
			Me.barButtonItem3.Name = "barButtonItem3"
			' 
			' barButtonItem4
			' 
			Me.barButtonItem4.Caption = "Docl"
			Me.barButtonItem4.Id = 3
			Me.barButtonItem4.Name = "barButtonItem4"
			' 
			' popupMenu1
			' 
			Me.popupMenu1.Manager = Me.barManager1
			Me.popupMenu1.Name = "popupMenu1"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(488, 306)
			Me.Controls.Add(Me.panelContainer1)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panelContainer1.ResumeLayout(False)
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			Me.dockPanel3.ResumeLayout(False)
			Me.dockPanel4.ResumeLayout(False)
			CType(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.popupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private WithEvents panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel4 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel4_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel3 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel3_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barManager1 As DevExpress.XtraBars.BarManager
		Private popupMenu1 As DevExpress.XtraBars.PopupMenu
		Private barButtonItem1 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
		Private barButtonItem4 As DevExpress.XtraBars.BarButtonItem


	End Class
End Namespace

