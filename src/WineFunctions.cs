using System.Diagnostics;

namespace yawg
{
	public class WineFunctions
	{
		private Process proc = new Process ();

		private void StartAndEndProcess(string filename, string arguements = null, bool useshell = false)
		{
			proc.StartInfo.UseShellExecute = useshell;
			proc.StartInfo.FileName = filename;
			proc.StartInfo.Arguments = arguements;
			proc.Start ();
			proc.Close ();
		}

		public void StartWineCfg()
		{
			StartAndEndProcess ("winecfg");
		}

		public void StartWineConsole()
		{
			StartAndEndProcess ("wineconsole", "cmd");
		}

		public void StartWineFile()
		{
			StartAndEndProcess ("winefile");
		}

		public void StartWinetricks()
		{
			StartAndEndProcess ("winetricks");
		}

		public void StartControlPanel()
		{
			StartAndEndProcess ("wine", "iexplore");
		}

		public void StartInternetExplorer()
		{
			StartAndEndProcess ("wine", "control", true);
		}
	}
}