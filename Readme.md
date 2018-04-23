# How to implement a context menu allowing to activate a certain DockPanel in a tabbed group


<p>Starting from <strong>version 11.2</strong>, we have introduced a special <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDockingDockManager_PopupMenuShowingtopic"><u>DockManager.PopupMenuShowing event</u></a>. Handle this event to show a menu.  </p><p><strong>For earlier versions:<br />
</strong><br />
In this example, the XtraBar PopupMenu is populated with items based on panels from a tabbed group. This menu is shown when the tab header is clicked. When the menu item is selected, a corresponding child DockPanel is activated.</p>

<br/>


