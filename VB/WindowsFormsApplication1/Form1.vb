Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Docking.Helpers

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			For Each control As Control In panelContainer1.Controls
				If TypeOf control Is DockPanel Then
					Dim panel As DockPanel = CType(control, DockPanel)
					Dim item As New BarCheckItem()
					item.GroupIndex = 1
					item.Caption = panel.Text
					If panelContainer1.ActiveChild Is panel Then
						item.Checked = True
					End If
                    AddHandler item.ItemClick, Function(sender1, args) SelectPanel(panelContainer1, panel)
					popupMenu1.AddItem(item)
				End If
			Next control
		End Sub
		
        Private Function SelectPanel(ByVal parent As DockPanel, ByVal child As DockPanel) As Boolean
            parent.ActiveChild = child
            MakePanelVisible(parent, child)
            Return True
        End Function
		Private Sub MakePanelVisible(ByVal parent As DockPanel, ByVal child As DockPanel)
			Dim dockLayout As DockLayout = CType(parent.GetType().GetProperty("DockLayout", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance).GetValue(parent, Nothing), DockLayout)
			dockLayout.GetType().GetField("firstVisibleTabIndex", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance).SetValue(dockLayout, parent.Controls.IndexOf(child))
			dockLayout.GetType().GetMethod("LayoutChanged", System.Reflection.BindingFlags.NonPublic Or System.Reflection.BindingFlags.Instance).Invoke(dockLayout, Nothing)
		End Sub
		Private Sub panelContainer1_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs) Handles panelContainer1.MouseClick
			If e.Button = MouseButtons.Right Then
				Dim panel As DockPanel = CType(sender, DockPanel)
				Dim info As HitInfo = (CType(sender, DockPanel)).GetHitInfo(e.Location)
				If info.HitTest = HitTest.Tab Then
					popupMenu1.ShowPopup(panel.PointToScreen(e.Location))
				End If
			End If
		End Sub
	End Class
End Namespace