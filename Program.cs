using System;
using System.Linq;
using System.Windows.Forms;

namespace WMRControl
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			if (args.Length > 0 && new[] { "-enable", "-disable" }.Contains(args[0].ToLower()))
			{
				var WMRM = new WMRManager();
				WMRM.Init();
				WMRM.SetWMRState(args[0].ToLower() == "-enable");
			}
			else
			{
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new FormMain());
			}
		}
	}
}