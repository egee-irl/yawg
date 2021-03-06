
// This file has been generated by the GUI designer. Do not modify.
namespace yawg
{
	public partial class MainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action FileAction;
		
		private global::Gtk.Action QuitAction;
		
		private global::Gtk.Action HelpAction;
		
		private global::Gtk.Action AboutAction;
		
		private global::Gtk.Action ToolsAction;
		
		private global::Gtk.Action WineConfigureAction;
		
		private global::Gtk.Action ConsoleAction;
		
		private global::Gtk.Action FileExplorerAction;
		
		private global::Gtk.Action WinetricksAction;
		
		private global::Gtk.Action ControlPanelAction;
		
		private global::Gtk.Action InternetExplorerAction;
		
		private global::Gtk.Action RefreshAction;
		
		private global::Gtk.Action OpenFolderAction;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.MenuBar menubar1;
		
		private global::Gtk.ScrolledWindow scrolledwindow1;
		
		private global::Gtk.TextView textview1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget yawg.MainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.FileAction = new global::Gtk.Action ("FileAction", global::Mono.Unix.Catalog.GetString ("File"), null, null);
			this.FileAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.FileAction, "<Alt><Mod2>f");
			this.QuitAction = new global::Gtk.Action ("QuitAction", global::Mono.Unix.Catalog.GetString ("Quit"), null, null);
			this.QuitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Quit");
			w1.Add (this.QuitAction, "<Alt><Mod2>q");
			this.HelpAction = new global::Gtk.Action ("HelpAction", global::Mono.Unix.Catalog.GetString ("Help"), null, null);
			this.HelpAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Help");
			w1.Add (this.HelpAction, null);
			this.AboutAction = new global::Gtk.Action ("AboutAction", global::Mono.Unix.Catalog.GetString ("About"), null, null);
			this.AboutAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("About");
			w1.Add (this.AboutAction, null);
			this.ToolsAction = new global::Gtk.Action ("ToolsAction", global::Mono.Unix.Catalog.GetString ("Tools"), null, null);
			this.ToolsAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Tools");
			w1.Add (this.ToolsAction, null);
			this.WineConfigureAction = new global::Gtk.Action ("WineConfigureAction", global::Mono.Unix.Catalog.GetString ("Wine Configure"), null, null);
			this.WineConfigureAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Configure");
			w1.Add (this.WineConfigureAction, "<Alt><Mod2>c");
			this.ConsoleAction = new global::Gtk.Action ("ConsoleAction", global::Mono.Unix.Catalog.GetString ("Console"), null, null);
			this.ConsoleAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Console");
			w1.Add (this.ConsoleAction, "<Alt><Mod2>o");
			this.FileExplorerAction = new global::Gtk.Action ("FileExplorerAction", global::Mono.Unix.Catalog.GetString ("File Explorer"), null, null);
			this.FileExplorerAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File Manager");
			w1.Add (this.FileExplorerAction, "<Alt><Mod2>m");
			this.WinetricksAction = new global::Gtk.Action ("WinetricksAction", global::Mono.Unix.Catalog.GetString ("Winetricks"), null, null);
			this.WinetricksAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Winetricks");
			w1.Add (this.WinetricksAction, "<Alt><Mod2>w");
			this.ControlPanelAction = new global::Gtk.Action ("ControlPanelAction", global::Mono.Unix.Catalog.GetString ("Control Panel"), null, null);
			this.ControlPanelAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Control Panel");
			w1.Add (this.ControlPanelAction, "<Alt><Mod2>p");
			this.InternetExplorerAction = new global::Gtk.Action ("InternetExplorerAction", global::Mono.Unix.Catalog.GetString ("Internet Explorer"), null, null);
			this.InternetExplorerAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Internet Explorer");
			w1.Add (this.InternetExplorerAction, "<Alt><Mod2>i");
			this.RefreshAction = new global::Gtk.Action ("RefreshAction", global::Mono.Unix.Catalog.GetString ("Refresh"), null, null);
			this.RefreshAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Refresh");
			w1.Add (this.RefreshAction, "<Alt><Mod2>r");
			this.OpenFolderAction = new global::Gtk.Action ("OpenFolderAction", global::Mono.Unix.Catalog.GetString ("Open Folder"), null, null);
			this.OpenFolderAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open Folder");
			w1.Add (this.OpenFolderAction, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "yawg.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Yet Another WINE GUI");
			this.Icon = global::Stetic.IconLoader.LoadIcon (this, "stock_weather-night-few-clouds", global::Gtk.IconSize.Menu);
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child yawg.MainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='OpenFolderAction' action='OpenFolderAction'/><menuitem name='RefreshAction' action='RefreshAction'/><menuitem name='QuitAction' action='QuitAction'/></menu><menu name='ToolsAction' action='ToolsAction'><menuitem name='WineConfigureAction' action='WineConfigureAction'/><menuitem name='ConsoleAction' action='ConsoleAction'/><menuitem name='FileExplorerAction' action='FileExplorerAction'/><menuitem name='WinetricksAction' action='WinetricksAction'/><menuitem name='ControlPanelAction' action='ControlPanelAction'/><menuitem name='InternetExplorerAction' action='InternetExplorerAction'/></menu></menubar></ui>");
			this.menubar1 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar1")));
			this.menubar1.Name = "menubar1";
			this.vbox1.Add (this.menubar1);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar1]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.textview1.Editable = false;
			this.scrolledwindow1.Add (this.textview1);
			this.vbox1.Add (this.scrolledwindow1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.scrolledwindow1]));
			w4.Position = 1;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 436;
			this.DefaultHeight = 300;
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.QuitAction.Activated += new global::System.EventHandler (this.OnQuitActionActivated);
			this.WineConfigureAction.Activated += new global::System.EventHandler (this.OnConfigureActionActivated);
			this.ConsoleAction.Activated += new global::System.EventHandler (this.OnConsoleActionActivated);
			this.FileExplorerAction.Activated += new global::System.EventHandler (this.OnFileManagerActionActivated);
			this.WinetricksAction.Activated += new global::System.EventHandler (this.OnWinetricksActionActivated);
			this.ControlPanelAction.Activated += new global::System.EventHandler (this.OnControlPanelActionActivated);
			this.InternetExplorerAction.Activated += new global::System.EventHandler (this.OnInternetExplorerActionActivated);
			this.RefreshAction.Activated += new global::System.EventHandler (this.OnRefreshActionActivated);
			this.OpenFolderAction.Activated += new global::System.EventHandler (this.OnOpenFolderActionActivated);
		}
	}
}
