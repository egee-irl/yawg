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
using System;

// This file doesn't actually do anything. The original file was lost during a distro change.
// I have no plans to rework this class as this project is reach its EOL.

namespace yawg
{
	public partial class FileChooserDialog : Gtk.Dialog
	{
		public FileChooserDialog ()
		{
			this.Build ();
		}

		public static string FileName()
		{
			return "";
		}

		protected void OnButtonOkClicked (object sender, EventArgs e)
		{
			Destroy ();
		}

		protected void OnButtonCancelClicked (object sender, EventArgs e)
		{
			Destroy ();
		}
	}		
}
