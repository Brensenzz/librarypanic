using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementManager : MonoBehaviour {
	static string AcID = "Achievement ID";

	#region Check Achievement
	public static void CheckLevelAc(int level)
	{
		if (level == 2 && StaticData.selectedCategory == 1)
			UnlockAchievement (1);
		else if (level == 5 && StaticData.selectedCategory == 1)
			UnlockAchievement (2);
		else if (level == 2 && StaticData.selectedCategory == 2)
			UnlockAchievement (3);
		else if (level == 5 && StaticData.selectedCategory == 2)
			UnlockAchievement (4);
		else if (level == 2 && StaticData.selectedCategory == 3)
			UnlockAchievement (5);
		else if (level == 5 && StaticData.selectedCategory == 3)
			UnlockAchievement (6);
		else if (level == 2 && StaticData.selectedCategory == 4)
			UnlockAchievement (7);
		else if (level == 5 && StaticData.selectedCategory == 4)
			UnlockAchievement (8);
	}
	#endregion

	#region Unlock Achievement
	public static void UnlockAchievement(int AcID)
	{
		if (!IsLocked (AcID))
			return;
		
		PlayerPrefs.SetInt ("Ac" + AcID,1);
		GameManager.instance.achievementUnlocked.SetActive (true);
	}

	public static bool IsLocked(int AcID)
	{
		bool result = true;
		if(PlayerPrefs.HasKey("Ac" + AcID))
		{
			int temp = PlayerPrefs.GetInt ("Ac", 1);
			if (temp == 1)
				result = false;
		}

		return result;
	}
	#endregion
}
