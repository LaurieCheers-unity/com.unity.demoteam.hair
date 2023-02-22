using UnityEngine;

namespace Unity.DemoTeam.Hair
{
	/// <summary>
	/// Project February - Additional settings for Hair based on Quality Level
	/// </summary>
	internal static class HairQualityLevelSettings
	{
		/// <summary>
		/// If HairInstance functionality should be disabled.
		/// Based on current Quality Level name.
		/// </summary>
		internal static bool DisableHairInstanceFunctionality
		{
			get
			{
				int qualityLevel = QualitySettings.GetQualityLevel();
				string[] names = QualitySettings.names;
				string levelName = string.Empty;
				if (qualityLevel >= 0 && qualityLevel < names.Length)
				{
					levelName = names[qualityLevel];
				}
				return levelName.Contains(NoHairSubstring);
			}
		}
		
		private static readonly string NoHairSubstring = "No Hair";
	}
}
