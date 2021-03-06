using JuicySwapper.Api;
using JuicySwapper.Main.Classes;
using JuicySwapper.Properties;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using static JuicySwapper.Api.OffsetsAPI;

namespace JuicySwapper.Main.Classes
{
    public class SwapUtilities
    {
		
		public string[] GetSwapPath()
		{
			var Pathtopaks = $"{Settings.Default.InstallationPath}\\FortniteGame\\Content\\Paks";

			string Skin_Body_Path = $"{Pathtopaks}\\pakchunk10_s3-WindowsClient.ucas";
			string Skin_Head_Path = $"{Pathtopaks}\\pakchunk10_s3-WindowsClient.ucas";
			string Pickaxe_Mesh_Path = $"{Pathtopaks}\\pakchunk10_s3-WindowsClient.ucas";
			string Backbling_Path = $"{Pathtopaks}\\pakchunk10_s3-WindowsClient.ucas";
			string Emote_Path = $"{Pathtopaks}\\pakchunk10_s3-WindowsClient.ucas";

			return new string[] { Skin_Body_Path, Skin_Head_Path, Pickaxe_Mesh_Path, Backbling_Path, Emote_Path };
		}

		public int[] GetSwapOffset()
		{
			int Offset_Skin_Body = Settings.Default.offset_skin_body;
			int Offset_Skin_Head = Settings.Default.offset_skin_head;
			int Offset_Pick_Mesh = Settings.Default.offset_pick_mesh;
			int Offset_Back_Mesh = Settings.Default.offset_back_mesh;
			int Offset_Emote_Mesh = Settings.Default.offset_emote_mesh;
			int Offset_Temp_gender = 134101198;

			return new int[] { Offset_Skin_Body, Offset_Skin_Head, Offset_Pick_Mesh, Offset_Back_Mesh, Offset_Emote_Mesh, Offset_Temp_gender };
		}

		public string[] GetEACPath()
        {
			var PathtoEAC = $"{Settings.Default.InstallationPath}\\FortniteGame\\Binaries\\Win64\\EasyAntiCheat\\Launcher";
			string One = $"{PathtoEAC}\\SplashScreen.png";

			return new string[] { One };
		}

		public string[] GetBackupPaths()
		{
			string Skin_Body_Path = "PakBackup/pakchunk10_s3-WindowsClient.ucas";
			string Skin_Head_Path = "PakBackup/pakchunk10_s3-WindowsClient.ucas";
			string Pickaxe_Mesh_Path = "PakBackup/pakchunk10_s3-WindowsClient.ucas";
			string Backbling_Path = "PakBackup/pakchunk10_s1-WindowsClient.ucas";
			string Emote_Path = "PakBackup/pakchunk10_s2-WindowsClient.pak";

			return new string[] { Skin_Body_Path, Skin_Head_Path, Pickaxe_Mesh_Path, Backbling_Path, Emote_Path };
		}

		public List<bool> AssaultTrooper = new List<bool>()
		{
			Settings.Default.SparkleSpecialistEnabled,
			Settings.Default.headhunterATEnabled,
			Settings.Default.RenegadeRaiderEnabled,
			Settings.Default.SurvivalSpecialistEnabled
		};

		public List<bool> Dominator = new List<bool>()
		{
			Settings.Default.ReconExpertEnabled,
			Settings.Default.BansheeEnabled
		};

		public List<bool> Whiplash = new List<bool>()
		{
			Settings.Default.DazzleEnabled,
			Settings.Default.EliteAgentEnabled
		};

		public List<bool> NiteLite = new List<bool>()
		{
			Settings.Default.GhoulOGEnabled,
			Settings.Default.RednoseEnabled
		};

		public List<bool> Blaze = new List<bool>()
		{
			Settings.Default.BrenegadeEnabled,
			Settings.Default.BrenegadeCEnabled
		};

		public List<bool> Redline = new List<bool>()
		{
			Settings.Default.RrenegadeEnabled,
			Settings.Default.RrenegadeCEnabled
		};

		public List<bool> GingerReneade = new List<bool>()
		{
			Settings.Default.RrenegadeEnabled,
			Settings.Default.GrenegadeCEnabled
		};

		public List<bool> Diva = new List<bool>()
		{
			Settings.Default.SirenEnabled,
			Settings.Default.TravisEnabled
		};

		public List<bool> DivaB = new List<bool>()
		{
			Settings.Default.SixStringEnabled,
			Settings.Default.InsigniaEnabled
		};

		public bool CheckIfCanSwap(string s)
		{
			switch (s)
			{
				case "AssaultTrooper":
					if (AssaultTrooper.All(a => a) || AssaultTrooper.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Dominator is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Dominator":
					if (Dominator.All(a => a) || Dominator.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Dominator is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Whiplash":
					if (Dominator.All(a => a) || Dominator.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Whiplash is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Nitelite":
					if (NiteLite.All(a => a) || NiteLite.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Nitelite is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Blaze":
					if (Blaze.All(a => a) || Blaze.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Blaze is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Redline":
					if (Redline.All(a => a) || Redline.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Redline is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "GingerReneade":
					if (GingerReneade.All(a => a) || GingerReneade.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using GingerReneade is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

				case "Diva":
					if (Diva.All(a => a) || Diva.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Diamond Diva is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break; 

				case "DivaB":
					if (GingerReneade.All(a => a) || GingerReneade.All(a => !a))
						return false;
					else
						MessageBox.Show("A skin using Diamond Diva back pack is already converted, if this is an error on our part, please reset the configuration from the Swapper settings.");
					break;

			}
			return true;
		}

		//offsets
		public static void Requestoffsets()
		{
			try
			{
				//Downloads JSON from Juicy Swapper API.
				var OffsetsAPI = new WebClient().DownloadString($"{API.HOST}/{API.Offsets}");

				//Deserializes JSON from Juicy Swapper API.
				Offsets StatusResponse = JsonConvert.DeserializeObject<Offsets>(OffsetsAPI);

				//Sets Form Items from API Response.
				Settings.Default.offset_skin_body = int.Parse(StatusResponse.Body); //offset body
				Settings.Default.offset_skin_head = int.Parse(StatusResponse.Head); //offset head
				Settings.Default.offset_pick_mesh = int.Parse(StatusResponse.Pickaxe); //offset pickaxe
				Settings.Default.offset_back_mesh = int.Parse(StatusResponse.Backbling); //offset pickaxe
				Settings.Default.offset_emote_mesh = int.Parse(StatusResponse.Emotes); //offset pickaxe
				Settings.Default.Save();
			}
			catch
			{
				Message Exception = new Message(Resources.Exception);
				Exception.ShowDialog();
			}
		}

		//paks || cba to use atm
		/*public static void RequestPaks()
	      {
		   try
		   {
			   //Downloads JSON from Juicy Swapper API.
			   var PaksAPI = new WebClient().DownloadString($"{Api.HOST}/{Api.Paks}");

			   //Deserializes JSON from Juicy Swapper API.
			   Paks StatusResponse = JsonConvert.DeserializeObject<Paks>(PaksAPI);

			   //Sets Form Items from API Response.
			   Settings.Default.Save();
		   }
		   catch
		   {
			   Exp = "Paks";
			   new ExceptionMess().ShowDialog();
		   }
	   } */
	}
}
