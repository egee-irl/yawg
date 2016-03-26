using System;

namespace yawg
{
	public partial class FileChooserDialog : Gtk.Dialog
	{
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
