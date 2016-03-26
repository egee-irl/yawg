using System.IO;

namespace yawg
{
	public class UtilityFunctions
	{
		public string GetListOfFiles(string text)
		{
			string[] filearray = Directory.GetFiles("TBD");
			foreach (string file in filearray)
			{
				text = TrimFilePath(file) + "\r\n" + text;
			}
			return text;
		}

		public string TrimFilePath(string filename)
		{
			return Path.GetFileName (filename);
		}
	}
}