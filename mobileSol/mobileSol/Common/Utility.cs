/*
 * Created by Ranorex
 * User: thuc.duy.nguyen
 * Date: 5/28/2020
 * Time: 11:44 AM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using System;
using System.Linq;
using System.Xml.Linq;
using Ranorex;
using Ranorex.Core.Repository;
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
		
		[UserCodeMethod]
		public static int GetHeaderIndex(RepoItemInfo tableRepo, String headerName)
		{
			return tableRepo.FindAdapter<Ranorex.TableTag>().FindSingle(".//tr[1]/th[@innertext='"+ headerName+"']").ChildIndex + 1;
		}
		
		[UserCodeMethod]
		public static int GetTotalCols(RepoItemInfo tableRepo)
		{
			return tableRepo.FindAdapter<Ranorex.TableTag>().FindDescendants<Ranorex.ThTag>().Count;
		}
		
		[UserCodeMethod]
		public static int GetTotalRows(RepoItemInfo tableRepo)
		{
			return tableRepo.FindAdapter<Ranorex.TableTag>().FindDescendants<Ranorex.TrTag>().Count;
		}
		
		[UserCodeMethod]
		public static int GetRowIndex(RepoItemInfo tableRepo, String itemName, String headerName)
		{
			int headerIndex = GetHeaderIndex(tableRepo, headerName);
			return tableRepo.FindAdapter<Ranorex.TableTag>().FindSingle(".//td[" + headerIndex + "]//a[@innertext = '" + itemName + "']").Parent.Parent.ChildIndex + 1;
		}
		
		[UserCodeMethod]
		public static void SelectItemInTable(RepoItemInfo tableRepo, String itemName, String headerName)
		{
			int headerIndex = GetHeaderIndex(tableRepo, headerName);
			ATag element = tableRepo.FindAdapter<Ranorex.TableTag>().FindSingle(".//td[" + headerIndex + "]//a[@innertext = '" + itemName + "']");
			element.Touch();
		}
	}
}
