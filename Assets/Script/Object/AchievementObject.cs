using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchievementObject : MonoBehaviour {
	
	public int AcId;
	public Image iconImage;
	public Sprite spriteLock;
	public Sprite spriteTrophy;
	public Text txtTitle;

	void Start()
	{
		txtTitle.text = "???";
		iconImage.sprite = spriteLock;
		switch (AcId) {
		case 1:
			if(!AchievementManager.IsLocked(1)){
				txtTitle.text = "Novice Food!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 2:
			if(!AchievementManager.IsLocked(2)){
				txtTitle.text = "Master Food!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 3:
			if(!AchievementManager.IsLocked(3)){
				txtTitle.text = "Novice Tool!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 4:
			if(!AchievementManager.IsLocked(4)){
				txtTitle.text = "Master Tool!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 5:
			if(!AchievementManager.IsLocked(5)){
				txtTitle.text = "Novice Place!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 6:
			if(!AchievementManager.IsLocked(6)){
				txtTitle.text = "Master Place!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 7:
			if(!AchievementManager.IsLocked(7)){
				txtTitle.text = "Novice Animal!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		case 8:
			if(!AchievementManager.IsLocked(8)){
				txtTitle.text = "Master Animal!";
				iconImage.sprite = spriteTrophy;
			}
			break;
		}

	}
}
