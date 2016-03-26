using System;
using Gtk;

namespace yawg
{
	public partial class MainWindow: Gtk.Window
	{
		WineFunctions WineFunctions = new WineFunctions();
		UtilityFunctions Utility = new UtilityFunctions();

		public MainWindow () : base (Gtk.WindowType.Toplevel)
		{
			Build ();
		}

		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
		}

		protected void OnQuitActionActivated (object sender, EventArgs e)
		{
			Application.Quit ();
		}

		protected void OnConfigureActionActivated (object sender, EventArgs e)
		{
			WineFunctions.StartWineCfg ();
		}

		protected void OnConsoleActionActivated (object sender, EventArgs e)
		{
			WineFunctions.StartWineConsole ();
		}

		protected void OnFileManagerActionActivated (object sender, EventArgs e)
		{
			WineFunctions.StartWineFile ();
		}

		protected void OnWinetricksActionActivated (object sender, EventArgs e)
		{
			WineFunctions.StartWinetricks ();
		}

		protected void OnControlPanelActionActivated (object sender, EventArgs e)
		{
			WineFunctions.StartControlPanel ();
		}
			
		protected void OnInternetExplorerActionActivated (object sender, EventArgs e)
		{
			WineFunctions.StartInternetExplorer ();
		}

		protected void OnRefreshActionActivated (object sender, EventArgs e)
		{
			RefreshListBox ();
		}

		public void RefreshListBox()
		{
			try
			{
				textview1.Buffer.Text = "";
				string file = textview1.Buffer.Text;
				textview1.Buffer.Text = Utility.GetListOfFiles (file);
			}
			catch
			{
				NoFilesFoundDialog nofilesfounddialog = new NoFilesFoundDialog ();
				nofilesfounddialog.Show ();
			}
		}

		protected void OnOpenFolderActionActivated (object sender, EventArgs e)
		{
			FileChooserDialog filechooserdialog = new FileChooserDialog ();
			filechooserdialog.Show ();
		}
	}
}