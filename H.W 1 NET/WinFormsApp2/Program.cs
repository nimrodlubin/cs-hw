namespace WinFormsApp2
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// To customize application configuration such as set high DPI settings or default font,
			// see https://aka.ms/applicationconfiguration.
			ApplicationConfiguration.Initialize();
			Application.Run(new ManuForms());

		}

		public static string[] registedUsers = new string[100];
		public static string[,] users = new string[,]
		{ { "123456789", "nimi" },
		  { "987654321", "bini" },
		  { "123123123", "kimi" } };



	}
}