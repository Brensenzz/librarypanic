using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq; //combine string[]

public class GameManager : MonoBehaviour {
	public static GameManager instance;
	public string[] keyWord;

	[Header("Instantiate Word")]
	public Transform parentWord;
	public GameObject prefabWord;

	[Header("Game Objective")]
	public Text wordToGo;
	public Text currLvl;

	[HideInInspector]
	public float fallSpeed = -1;

	[Header("Pause")]
	public GameObject popupPause;

	[Header("Achievement")]
	public GameObject achievementUnlocked;

	[Header("Keyboard")]
	public GameObject Keyboard;
	public GameObject KeyboardRomaji;

	public GameObject gameoverPopup;
	public Slider healthBar;

	private string categoryName;
	private int intervalFallingObject = 5;
	private bool isEasy;
	private bool isNormal;
	private bool isHard;

	// Use this for initialization
	void Start () {
		instance = this;
		RefreshNeededWord ();
		StaticData.currLvl = 1;
		currLvl.text = "Chapter: " + StaticData.currLvl;
		RefreshNeededWord ();
		isEasy = true;
		CategorySelected (StaticData.selectedCategory);
//		bangsat.GetComponent<Image>().sprite = Resources.Load<Sprite> ("keyboardpng");
//		for(int i=0;i<StaticData.Chaos.Length;i++)
//		{
//			keyWord [i] = StaticData.Chaos [i];
//			Debug.Log (keyWord[i]);
//		}

		InvokeRepeating("CreateWord",1,intervalFallingObject);
	}
	
	// Update is called once per frame
	void Update () {
//		cibai ();
//		if (GameObject.FindGameObjectsWithTag ("WordObjects").Length > 2) {
//			CancelInvoke ();
//			Debug.Log ("matiiii");
//			CheckCondition ();
//		}
		
		if(healthBar.value == 1)
		{
			CancelInvoke ();
			GameObject[] gos;
			gos = GameObject.FindGameObjectsWithTag ("WordObjects");
			foreach (GameObject go in gos) {
				go.GetComponent<MeshRenderer> ().enabled = false;
			}
			gameoverPopup.SetActive (true);
		}
	}

	void CreateWord()
	{
		int randX = Random.Range (-2,3);
		GameObject obj = Instantiate (prefabWord, new Vector3(randX,5,0),Quaternion.identity,parentWord);
		int rand = Random.Range (0, keyWord.Length);
		obj.gameObject.name = keyWord [rand];
		obj.GetComponentInChildren<Image> ().sprite = Resources.Load<Sprite> (categoryName+"/"+keyWord [rand]);
		obj.GetComponent<MeshRenderer> ().sortingLayerName = "UI";
		obj.GetComponent<MeshRenderer> ().sortingOrder = 1;
		if(StaticData.selectedDifficulty.Equals("Easy"))
//			obj.GetComponent<Text> ().text = ConvertHiraganaToRomaji(keyWord [rand]);
			obj.GetComponent<TextMesh> ().text = ConvertHiraganaToRomaji(keyWord [rand]);
		else
//			obj.GetComponent<Text> ().text = keyWord [rand];
			obj.GetComponent<TextMesh> ().text = keyWord [rand];

		if (StaticData.selectedCategory == 6)
			obj.GetComponentInChildren<Image> ().enabled = false;
//		CheckCondition ();
//		obj.transform.position = new Vector3(0,5,0);
	}
		
	void CheckCondition()
	{
		if (GameObject.FindGameObjectsWithTag ("WordObjects").Length > 2) {
			CancelInvoke ();
			Debug.Log ("CANCEL");
			if(GameObject.FindGameObjectsWithTag ("WordObjects").Length < 3)
			{
				Invoke ("CreateWord", 3);
			}
		} 	
	}

	public void DecreaseHealthBar(){
		healthBar.value += 0.25f;
		if(healthBar.value != 1f)
			healthBar.gameObject.GetComponent<Animator> ().SetTrigger ("FAIL");
	}

	#region Game Objective
	void CheckLevel(){
		StaticData.currLvl++;
		fallSpeed -= 0.5f;
		currLvl.text = "Chapter: " + StaticData.currLvl;
		AchievementManager.CheckLevelAc (StaticData.currLvl);
		if(StaticData.currLvl == 2){
			isEasy = false;
			isNormal = true;
			isHard = false;
			CategorySelected (StaticData.selectedCategory);
			CancelInvoke ();
			InvokeRepeating("CreateWord",1,intervalFallingObject);

		} else if(StaticData.currLvl == 3){
			isEasy = false;
			isNormal = false;
			isHard = true;
			CategorySelected (StaticData.selectedCategory);
			CancelInvoke ();
			InvokeRepeating("CreateWord",1,intervalFallingObject);
		}
//		if (StaticData.currLvl % 3 == 0) {
//			intervalFallingObject--;
//			if (intervalFallingObject <= 1)
//				intervalFallingObject = 1;
//			CancelInvoke ();
//			InvokeRepeating("CreateWord",1,intervalFallingObject);
//		}
	}

	public void CheckNeededWord()
	{
		if (StaticData.neededWord != 0) {
			StaticData.neededWord--;

			if (StaticData.neededWord == 0) {
				CheckLevel ();
				RefreshNeededWord ();
			} else {
				wordToGo.text = "" + StaticData.neededWord + "\nWords to go";

			}
		}
	}

	void RefreshNeededWord()
	{
		StaticData.neededWord = 1 * StaticData.currLvl;
		wordToGo.text = ""+StaticData.neededWord+"\nWords to go";
	}
		
	void CategorySelected(int category)
	{
		switch (category) {
		case 1:
			switch(StaticData.selectedDifficulty)
			{
			case "Easy":
				SetKeyword ("Food");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

			case "Medium":
				SetKeyword ("Food");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

			case "Hard":
				SetKeyword ("Food");
				KeyboardRomaji.SetActive (false);
				Keyboard.SetActive (true);
				break;
			}
			break;
		case 2:
			switch (StaticData.selectedDifficulty) {
			case "Easy":
				SetKeyword ("Tools");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

				case "Medium":
				SetKeyword ("Tools");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

				case "Hard":
				SetKeyword ("Tools");
				KeyboardRomaji.SetActive (false);
				Keyboard.SetActive (true);
				break;
			}
			break;
		case 3:
			switch (StaticData.selectedDifficulty) {
			case "Easy":
				SetKeyword ("Places");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

			case "Medium":
				SetKeyword ("Places");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

			case "Hard":
				SetKeyword ("Places");
				KeyboardRomaji.SetActive (false);
				Keyboard.SetActive (true);
				break;

			}
			break;
		case 4:
			switch (StaticData.selectedDifficulty) {
			case "Easy":
				SetKeyword ("Animal");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

			case "Medium":
				SetKeyword ("Animal");
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				break;

			case "Hard":
				SetKeyword ("Animal");
				KeyboardRomaji.SetActive (false);
				Keyboard.SetActive (true);
				break;

			}
			break;
		case 5:
			keyWord = new string[StaticData.Chaos.Length];
			for (int i = 0; i < StaticData.Chaos.Length; i++) {
				keyWord [i] = StaticData.Chaos [i];
				categoryName = "Chaos";
				KeyboardRomaji.SetActive (false);
				Keyboard.SetActive (true);
				Debug.Log (keyWord [i]);
			}
			break;
		case 6:
			keyWord = new string[StaticData.Alphabet.Length];
			for (int i = 0; i < StaticData.Alphabet.Length; i++) {
				keyWord [i] = StaticData.Alphabet [i];
				categoryName = "Alphabet";
				KeyboardRomaji.SetActive (true);
				Keyboard.SetActive (false);
				Debug.Log (keyWord [i]);
			}
			break;
		}
	}

	void SetKeyword(string category){
		switch (category) {
		case "Food":
			if (isEasy) {
				keyWord = new string[StaticData.FoodEasy.Length];
				for (int i = 0; i < StaticData.FoodEasy.Length; i++) {
					keyWord [i] = StaticData.FoodEasy [i];
					categoryName = "Food";
					Debug.Log (keyWord [i]);

				}
			} else if (isNormal) {
				string[] temp = StaticData.FoodEasy.Concat(StaticData.FoodMedium).ToArray();
				keyWord = new string[temp.Length];
				for (int i = 0; i < temp.Length; i++) {
					keyWord [i] = temp [i];
					categoryName = "Food";
					Debug.Log (keyWord [i]);
				}
			} else if(isHard) {
				string[] temp = StaticData.FoodEasy.Concat(StaticData.FoodMedium).ToArray();
				string[] temp2 = temp.Concat (StaticData.FoodHard).ToArray ();
				keyWord = new string[temp2.Length];
				for (int i = 0; i < temp2.Length; i++) {
					keyWord [i] = temp2 [i];
					categoryName = "Food";
					Debug.Log (keyWord [i]);
				}
			}
			break;
		case "Tools":
			if (isEasy) {
				keyWord = new string[StaticData.ToolEasy.Length];
				for (int i = 0; i < StaticData.ToolEasy.Length; i++) {
					keyWord [i] = StaticData.ToolEasy [i];
					categoryName = "Tools";
					Debug.Log (keyWord [i]);

				}
			} else if (isNormal) {
				string[] temp = StaticData.ToolEasy.Concat(StaticData.ToolMedium).ToArray();
				keyWord = new string[temp.Length];
				for (int i = 0; i < temp.Length; i++) {
					keyWord [i] = temp [i];
					categoryName = "Tools";
					Debug.Log (keyWord [i]);
				}
			} else if(isHard) {
				string[] temp = StaticData.ToolEasy.Concat(StaticData.ToolMedium).ToArray();
				string[] temp2 = temp.Concat (StaticData.ToolHard).ToArray ();
				keyWord = new string[temp2.Length];
				for (int i = 0; i < temp2.Length; i++) {
					keyWord [i] = temp2 [i];
					categoryName = "Tools";
					Debug.Log (keyWord [i]);
				}
			}
			break;
		case "Places":
			if (isEasy) {
				keyWord = new string[StaticData.PlaceEasy.Length];
				for (int i = 0; i < StaticData.PlaceEasy.Length; i++) {
					keyWord [i] = StaticData.PlaceEasy [i];
					categoryName = "Places";
					Debug.Log (keyWord [i]);

				}
			} else if (isNormal) {
				string[] temp = StaticData.PlaceEasy.Concat(StaticData.PlaceMedium).ToArray();
				keyWord = new string[temp.Length];
				for (int i = 0; i < temp.Length; i++) {
					keyWord [i] = temp [i];
					categoryName = "Places";
					Debug.Log (keyWord [i]);
				}
			} else if(isHard) {
				string[] temp = StaticData.PlaceEasy.Concat(StaticData.PlaceMedium).ToArray();
				string[] temp2 = temp.Concat (StaticData.PlaceHard).ToArray ();
				keyWord = new string[temp2.Length];
				for (int i = 0; i < temp2.Length; i++) {
					keyWord [i] = temp2 [i];
					categoryName = "Places";
					Debug.Log (keyWord [i]);
				}
			}
			break;
		case "Animal":
			if (isEasy) {
				keyWord = new string[StaticData.AnimalEasy.Length];
				for (int i = 0; i < StaticData.AnimalEasy.Length; i++) {
					keyWord [i] = StaticData.AnimalEasy [i];
					categoryName = "Animal";
					Debug.Log (keyWord [i]);

				}
			} else if (isNormal) {
				string[] temp = StaticData.AnimalEasy.Concat(StaticData.AnimalMedium).ToArray();
				keyWord = new string[temp.Length];
				for (int i = 0; i < temp.Length; i++) {
					keyWord [i] = temp [i];
					categoryName = "Animal";
					Debug.Log (keyWord [i]);
				}
			} else if(isHard) {
				string[] temp = StaticData.AnimalEasy.Concat(StaticData.AnimalMedium).ToArray();
				string[] temp2 = temp.Concat (StaticData.AnimalHard).ToArray ();
				keyWord = new string[temp2.Length];
				for (int i = 0; i < temp2.Length; i++) {
					keyWord [i] = temp2 [i];
					categoryName = "Animal";
					Debug.Log (keyWord [i]);
				}
			}
			break;
		}
	}

	#endregion

	//DUMMY
	#region DUMMY
	string ConvertHiraganaToRomaji(string hiragana){
		string temp = "";
		temp = (hiragana.Equals("ごはん")) ? "GOHAN" : temp;
		temp = (hiragana.Equals("たまご")) ? "TAMAGO" : temp;
		temp = (hiragana.Equals("にく")) ? "NIKU" : temp;
		temp = (hiragana.Equals("さかな")) ? "SAKANA" : temp;
		temp = (hiragana.Equals("やさい")) ? "YASAI" : temp;
		temp = (hiragana.Equals("みず")) ? "MIZU" : temp;
		temp = (hiragana.Equals("りんご")) ? "RINGO" : temp;
		temp = (hiragana.Equals("さとう")) ? "SATOU" : temp;
		temp = (hiragana.Equals("おかし")) ? "OKASHI" : temp;
		temp = (hiragana.Equals("べんと")) ? "BENTO" : temp;
		temp = (hiragana.Equals("しお")) ? "SHIO" : temp;
		temp = (hiragana.Equals("みるく")) ? "MIRUKU" : temp;
		temp = (hiragana.Equals("みかん")) ? "MIKAN" : temp;
		temp = (hiragana.Equals("さけ")) ? "SAKE" : temp;
		temp = (hiragana.Equals("すきやき")) ? "SUKIYAKI" : temp;
		temp = (hiragana.Equals("さしみ")) ? "SASHIMI" : temp;
		temp = (hiragana.Equals("すし")) ? "MIZU" : temp;
		temp = (hiragana.Equals("てんぷら")) ? "TENPURA" : temp;
		temp = (hiragana.Equals("おちゃ")) ? "OCHIYA" : temp; //DUMMY
		temp = (hiragana.Equals("いす")) ? "ISU" : temp;
		temp = (hiragana.Equals("はし")) ? "HASHI" : temp;
		temp = (hiragana.Equals("かみ")) ? "KAMI" : temp;
		temp = (hiragana.Equals("くつ")) ? "KUTSU" : temp;
		temp = (hiragana.Equals("ほん")) ? "HON" : temp;
		temp = (hiragana.Equals("はこ")) ? "HAKO" : temp;
		temp = (hiragana.Equals("えんぴつ")) ? "ENPITSU" : temp;
		temp = (hiragana.Equals("とけい")) ? "TOKEI" : temp;
		temp = (hiragana.Equals("つくえ")) ? "TSUKUE" : temp;
		temp = (hiragana.Equals("はさみ")) ? "HASAMI" : temp;
		temp = (hiragana.Equals("めいし")) ? "MEISHI" : temp;
		temp = (hiragana.Equals("かぎ")) ? "KAGI" : temp;
		temp = (hiragana.Equals("ざっし")) ? "ZASHI" : temp; //DUMMY
		temp = (hiragana.Equals("じしょ")) ? "JISO" : temp; //DUMMY
		temp = (hiragana.Equals("かさ")) ? "KASA" : temp;
		temp = (hiragana.Equals("てちょう")) ? "TECHIYOU" : temp; //DUMMY
		temp = (hiragana.Equals("めがね")) ? "MEGANE" : temp;
		temp = (hiragana.Equals("かばん")) ? "KABAN" : temp;
		temp = (hiragana.Equals("でんち")) ? "DENCHI" : temp;
		temp = (hiragana.Equals("しんぶん")) ? "SHINBUN" : temp;
		temp = (hiragana.Equals("ちず")) ? "CHIZU" : temp;
		temp = (hiragana.Equals("かわ")) ? "KAWA" : temp;
		temp = (hiragana.Equals("うみ")) ? "UMI" : temp;
		temp = (hiragana.Equals("やま")) ? "YAMA" : temp;
		temp = (hiragana.Equals("うち")) ? "UCHI" : temp;
		temp = (hiragana.Equals("えき")) ? "EKI" : temp;
		temp = (hiragana.Equals("にわ")) ? "NIWA" : temp;
		temp = (hiragana.Equals("まち")) ? "MACHI" : temp;
		temp = (hiragana.Equals("ほんや")) ? "HONYA" : temp;
		temp = (hiragana.Equals("まつり")) ? "MATSURI" : temp;
		temp = (hiragana.Equals("くうこう")) ? "KUUKOU" : temp;
		temp = (hiragana.Equals("ぎんこう")) ? "GINKOU" : temp;
		temp = (hiragana.Equals("じむしょ")) ? "JIMUSO" : temp; //DUMMY
		temp = (hiragana.Equals("かいしゃ")) ? "KAISHIYA" : temp; //DUMMY
		temp = (hiragana.Equals("かいだん")) ? "KAIDAN" : temp;
		temp = (hiragana.Equals("こうえん")) ? "KOUEN" : temp;
		temp = (hiragana.Equals("としょかん")) ? "TOSHIYOKAN" : temp; //DUMMY
		temp = (hiragana.Equals("がっこう")) ? "GAKOU" : temp; //DUMMY
		temp = (hiragana.Equals("せかい")) ? "SEKAI" : temp;
		temp = (hiragana.Equals("ゆうびんきょく")) ? "YUUBUNKIYOKU" : temp;
		temp = (hiragana.Equals("びじゅつかん")) ? "BITSUTSUKAN" : temp; //DUMMY
		temp = (hiragana.Equals("きょうしつ")) ? "KIYOSHITSU" : temp; //DUMMY
		temp = (hiragana.Equals("びょういん")) ? "BIYOUIN" : temp; //DUMMY
		temp = (hiragana.Equals("だいがく")) ? "DAIGAKU" : temp;
		temp = (hiragana.Equals("くま")) ? "KUMA" : temp;
		temp = (hiragana.Equals("とり")) ? "TORI" : temp;
		temp = (hiragana.Equals("ねこ")) ? "NEKO" : temp;
		temp = (hiragana.Equals("うし")) ? "USHI" : temp;
		temp = (hiragana.Equals("つる")) ? "TSURU" : temp;
		temp = (hiragana.Equals("いぬ")) ? "INU" : temp;
		temp = (hiragana.Equals("さる")) ? "SARU" : temp;
		temp = (hiragana.Equals("いるか")) ? "IRUKA" : temp;
		temp = (hiragana.Equals("ぞう")) ? "ZOU" : temp;
		temp = (hiragana.Equals("さかな")) ? "SAKANA" : temp;
		temp = (hiragana.Equals("きつね")) ? "KITSUNE" : temp;
		temp = (hiragana.Equals("かえる")) ? "KAERU" : temp;
		temp = (hiragana.Equals("きりん")) ? "KIRIN" : temp;
		temp = (hiragana.Equals("やぎ")) ? "YAGI" : temp;
		temp = (hiragana.Equals("うま")) ? "UMA" : temp;
		temp = (hiragana.Equals("しまうま")) ? "SHIMAUMA" : temp;
		temp = (hiragana.Equals("ねずみ")) ? "NEZUMI" : temp;
		temp = (hiragana.Equals("たこ")) ? "TAKO" : temp;
		temp = (hiragana.Equals("ぶた")) ? "BUTA" : temp;
		temp = (hiragana.Equals("さめ")) ? "SAME" : temp;
		temp = (hiragana.Equals("ひつじ")) ? "HITSUJI" : temp;
		temp = (hiragana.Equals("へび")) ? "EBI" : temp;
		temp = (hiragana.Equals("いか")) ? "IKA" : temp;
		temp = (hiragana.Equals("りす")) ? "RISU" : temp;
		temp = (hiragana.Equals("とら")) ? "TORA" : temp;
		temp = (hiragana.Equals("かめ")) ? "KAME" : temp;
		temp = (hiragana.Equals("くじら")) ? "KUJIRA" : temp;
		temp = (hiragana.Equals("おおかみ")) ? "OOKAMI" : temp;

		return temp;
	}

	public void restartGame()
	{
		Application.LoadLevel ("Gameplay");
		StaticData.currLvl = 1;
	}
	public void backMenu()
	{
		Time.timeScale = 1;
		CancelInvoke ();
		Application.LoadLevel ("Menu");

	}
	#endregion

}
