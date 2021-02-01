/*
 * User: Maxwell Duarte Miquelino
 * Date: 28/04/2020
 * Time: 08:30
 */
using Estacionamento.View;
using System;
using System.Windows.Forms;

namespace Estacionamento
{
    /// <summary>
    /// Class with program entry point.
    /// </summary>
    internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new frmSplashScreen());
		}
		
	}
}
