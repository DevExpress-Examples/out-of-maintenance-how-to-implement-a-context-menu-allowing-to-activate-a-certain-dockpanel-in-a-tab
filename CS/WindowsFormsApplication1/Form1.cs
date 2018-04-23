using System;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking.Helpers;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            foreach(Control control in panelContainer1.Controls){
                if (control is DockPanel) {
                    DockPanel panel = (DockPanel)control;
                    BarCheckItem item = new BarCheckItem();
                    item.GroupIndex = 1;
                    item.Caption = panel.Text;
                    if (panelContainer1.ActiveChild == panel) {
                        item.Checked = true;
                    }
                    item.ItemClick += delegate(object sender1, ItemClickEventArgs args) {
                        panelContainer1.ActiveChild = panel;
                        MakePanelVisible(panelContainer1, panel);
                    };
                    popupMenu1.AddItem(item);
                }
            }
        }
        private void MakePanelVisible(DockPanel parent, DockPanel child) {
            DockLayout dockLayout = (DockLayout)parent.GetType().GetProperty("DockLayout", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).GetValue(parent, null);
            dockLayout.GetType().GetField("firstVisibleTabIndex", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(dockLayout, parent.Controls.IndexOf(child));
            dockLayout.GetType().GetMethod("LayoutChanged", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).Invoke(dockLayout, null);
        }
        private void panelContainer1_MouseClick(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Right) {
                DockPanel panel = (DockPanel)sender;
                HitInfo info = ((DockPanel)sender).GetHitInfo(e.Location);
                if (info.HitTest == HitTest.Tab) {
                    popupMenu1.ShowPopup(panel.PointToScreen(e.Location));
                }
            }
        }
    }
}