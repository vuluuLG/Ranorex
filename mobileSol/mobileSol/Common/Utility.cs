/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 5/28/2020
 * Time: 11:44 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;

namespace mobileSol.Common
{
	/// <summary>
	/// Description of Utility.
	/// </summary>
	public class Utility
	{
		public static String GetCurrentDate(String dateFormat = "MM/dd/yyyy")
		{
			return DateTime.Now.ToString(dateFormat);
		}
	}
}
