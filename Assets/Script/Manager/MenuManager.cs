using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
	public static MenuManager instance;

	public GameObject startButton;
	public GameObject iconButton;

	[Header("Popup")]
	public GameObject popupPanel;
	public GameObject categoryPopup;
	public GameObject achievementPopup;
	public GameObject galleryPopup;
	public GameObject secondPopupPanel;
	public GameObject dificultyPopup;
	public GameObject detailGallerPopup;
	public GameObject settingPopup;
	public GameObject resetProgressPopup;
	public GameObject creditPopup;

	[Header("Animation")]
	public Animator bookAnimator;

	// Use this for initialization
	void Start () {
		instance = this;
		StaticData.selectedCategory = 0;
		StaticData.selectedDifficulty = "";
//		PlayerPrefs.DeleteAll ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 
	}

	public void openPopup(){
		closePopup ();
		closeSecondPopup ();

		popupPanel.SetActive (true);
		categoryPopup.SetActive (true);
		bookAnimator.SetTrigger ("Open");

		startButton.SetActive (false);
		iconButton.SetActive (false);

	}

	public void openAchievement(){
		closePopup ();
		closeSecondPopup ();

		popupPanel.SetActive (true);
		achievementPopup.SetActive (true);
		bookAnimator.SetTrigger ("Open");

		startButton.SetActive (false);
		iconButton.SetActive (false);
	}

	public void openGallery(){
		closePopup ();
		closeSecondPopup ();

		popupPanel.SetActive (true);
		galleryPopup.SetActive (true);
		bookAnimator.SetTrigger ("Open");

		startButton.SetActive (false);
		iconButton.SetActive (false);
	}

	public void openSetting(){
		closePopup ();
		closeSecondPopup ();

		popupPanel.SetActive (true);
		settingPopup.SetActive (true);
		bookAnimator.SetTrigger ("Open");

		startButton.SetActive (false);
		iconButton.SetActive (false);
	}

	public void openCredit(){
		closePopup ();
		closeSecondPopup ();

		popupPanel.SetActive (true);
		creditPopup.SetActive (true);
		bookAnimator.SetTrigger ("Open");

		startButton.SetActive (false);
		iconButton.SetActive (false);
	}

	public void closePopup()
	{

		popupPanel.SetActive (false);
		categoryPopup.SetActive (false);
		achievementPopup.SetActive (false);
		galleryPopup.SetActive (false);
		settingPopup.SetActive (false);
		creditPopup.SetActive (false);
	}

	public void openSecondPopup(){
		secondPopupPanel.SetActive (true);
		dificultyPopup.SetActive (true);
	}
	public void openResetProgressPopup(){
		secondPopupPanel.SetActive (true);
		resetProgressPopup.SetActive (true);
	}
				
	public void closeSecondPopup()
	{
		secondPopupPanel.SetActive (false);
		dificultyPopup.SetActive (false);
		detailGallerPopup.SetActive (false);
		resetProgressPopup.SetActive (false);
	}

	public void closeBookAnimation(){
		bookAnimator.SetTrigger ("Close");
		StartCoroutine ("delayCloseBook");
	}

	IEnumerator delayCloseBook(){
		yield return new WaitForSeconds(1);
		startButton.SetActive (true);
		iconButton.SetActive (true);
	}

	public void goToScene(string category)
	{
		switch (category) {
		case "Food":
			StaticData.selectedCategory = 1;
			openSecondPopup ();
			break;
		case "Tool":
			StaticData.selectedCategory = 2;
			openSecondPopup ();
			break;
		case "Place":
			StaticData.selectedCategory = 3;
			openSecondPopup ();
			break;
		case "Animal":
			StaticData.selectedCategory = 4;
			openSecondPopup ();
			break;
		case "Chaos":
			StaticData.selectedCategory = 5;
			Application.LoadLevel ("Gameplay");
			break;
		case "Alphabet":
			StaticData.selectedCategory = 6;
			Application.LoadLevel ("Gameplay");
			break;
		}
	}

	public void pickDifficulty(string difficulty){
		switch (difficulty) {
		case "Easy":
			StaticData.selectedDifficulty = "Easy";
			Application.LoadLevel ("Gameplay");
			break;
		case "Medium":
			StaticData.selectedDifficulty= "Medium";
			Application.LoadLevel ("Gameplay");
			break;
		case "Hard":
			StaticData.selectedDifficulty = "Hard";
			Application.LoadLevel ("Gameplay");
			break;
		}
	}

	public void ResetProgress(){
		PlayerPrefs.DeleteAll ();
		Application.LoadLevel ("Menu");
	}
}
