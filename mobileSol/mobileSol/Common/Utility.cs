/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 5/28/2020
 * Time: 11:44 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;

using Ranorex;
using Ranorex.Core.Testing;

namespace mobileSol.Common
{
	/// <summary>
	/// Description of Utility.
	/// </summary>
	[UserCodeCollection]
	public class Utility
	{
		// Define a repository object
		private static mobileSolRepository repo = mobileSolRepository.Instance;
		
		[UserCodeMethod]
		public static String GetCurrentDate(String dateFormat = "MM/dd/yyyy")
		{
			return System.DateTime.Now.ToString(dateFormat);
		}
		
		[UserCodeMethod]
		public static String GetHexByColorName(String colorName)
		{
			String result = "";
			switch (colorName.ToUpper()) {
				case "RED":
					result = ColorByHex.Red;
					break;
				case "DARKRED":
					result = ColorByHex.DarkRed;
					break;
				case "ORANGE":
					result = ColorByHex.Orange;
					break;
				case "YELLOW":
					result = ColorByHex.Yellow;
					break;
				case "LIGHTGREEN":
					result = ColorByHex.LightGreen;
					break;
				case "GREEN":
					result = ColorByHex.Green;
					break;
				case "LIGHTBLUE":
					result = ColorByHex.LightBlue;
					break;
				case "BLUE":
					result = ColorByHex.Blue;
					break;
				case "DARKBLUE":
					result = ColorByHex.DarkBlue;
					break;
				case "PURPLE":
					result = ColorByHex.Purple;
					break;
				default:
					Report.Log(ReportLevel.Error, "This color have not supported yet.");
					break;					           
			}
			return result;
		}
	}
}
