//  Author:
//       Brian Warren <bwarren@yandex.com>
//
//  Copyright (c) 2014 GPL v3
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using System.IO;
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