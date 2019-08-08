using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyboardBehaviour : MonoBehaviour {

	public Text Output;
	public GameObject detailKeyboard;
	public GameObject[] keyButtons;

	//ceritanya maksimal tulisan 30 huruf
	string[] wordArray = new string[30];
	int wordIndex = 0;
	string word = null;
	string wordRomaji = null;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape))
			PauseFunction();
	}

	public void AlphabetFunction(string alphabet){
		wordArray [wordIndex] = alphabet;

		word += wordArray[wordIndex].ToString();
		wordRomaji += ConvertRomajiToHiragana(wordArray[wordIndex].ToString());

		Output.text = word;

		wordIndex++;

		CheckInput ();
		CloseDetailKeyboard ();
	}

	public void BakcspaceFunction()
	{
		if(wordIndex > 0)
		{
			wordIndex--;
			string newWord = null;

			for (int i = 0; i < wordIndex; i++)
				newWord += wordArray [i].ToString ();

			word = newWord;
			wordRomaji = newWord;

			Output.text = word;
		}
	}

	public void CloseDetailKeyboard()
	{
		detailKeyboard.SetActive (false);
		for(int i=0; i<keyButtons.Length;i++)
		{
			keyButtons [i].SetActive (false);
		}
	}
		
	void CheckInput()
	{
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag ("WordObjects");

		foreach (GameObject go in gos) {
			if (StaticData.selectedCategory == 6 || StaticData.selectedDifficulty.Equals ("Easy") || StaticData.selectedDifficulty.Equals ("Medium")) {
//				for (int i = 0; i < wordIndex; i++)
//					wordRomaji += wordArray [i].ToString ();

				Debug.Log (word);
				Debug.Log ("Romaji: "+wordRomaji);
				if (go.name == wordRomaji) {
					go.GetComponentInChildren<Animator> ().enabled = true;
					go.GetComponentInChildren<Image> ().enabled = false;
					go.GetComponent<MeshRenderer> ().enabled = false;
					wordIndex = 0;
					word = null;
					wordRomaji = null;
					Output.text = "";
//					Destroy (go);
					StartCoroutine(DestroyWordObject(go));
					GameManager.instance.CheckNeededWord ();
					}
			} else {
				if (go.name == word) {
					GalleryManager.CheckGallery (word);
					go.GetComponentInChildren<Animator> ().enabled = true;
					go.GetComponentInChildren<Image> ().enabled = false;
					go.GetComponent<MeshRenderer> ().enabled = false;
					wordIndex = 0;
					word = null;
					Output.text = "";
//					Destroy (go);
					StartCoroutine(DestroyWordObject(go));
					GameManager.instance.CheckNeededWord ();
					//go.SetActive (false);			
					}
				}
			}

		}

	private IEnumerator DestroyWordObject(GameObject go){
		while (true) {
			yield return new WaitForSeconds (1f);
			Destroy (go);

		}
	}

	#region Pause
	public void PauseFunction(){
		GameManager.instance.popupPause.SetActive (true);
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag ("WordObjects");
		foreach (GameObject go in gos) {
			go.GetComponent<MeshRenderer> ().enabled = false;
		}
		Time.timeScale = 0;
	}

	public void ResumeFunction(){
		GameManager.instance.popupPause.SetActive (false);
		GameObject[] gos;
		gos = GameObject.FindGameObjectsWithTag ("WordObjects");
		foreach (GameObject go in gos) {
			go.GetComponent<MeshRenderer> ().enabled = true;
		}
		Time.timeScale = 1;
	}
	#endregion

	#region Validation
	public void MaruTengFunction()
	{
		bool flag = CheckMaruTeng();
		if (!flag) 
		{
			return;
		} 
		else 
		{
			string newWord = null;
			switch(wordArray[wordIndex-1])
			{
			//GAGIGUGEGO
			case "か":
				wordArray [wordIndex - 1] = "が";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "き":
				wordArray [wordIndex - 1] = "ぎ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "く":
				wordArray [wordIndex - 1] = "ぐ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "け":
				wordArray [wordIndex - 1] = "げ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "こ":
				wordArray [wordIndex - 1] = "ご";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
				//ZAZIZUZEZO
			case "さ":
				wordArray [wordIndex - 1] = "ざ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "し":
				wordArray [wordIndex - 1] = "じ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "す":
				wordArray [wordIndex - 1] = "ず";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "せ":
				wordArray [wordIndex - 1] = "ぜ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "そ":
				wordArray [wordIndex - 1] = "ぞ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
				//DADIDUDEDO
			case "た":
				wordArray [wordIndex - 1] = "だ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ち":
				wordArray [wordIndex - 1] = "ぢ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "つ":
				wordArray [wordIndex - 1] = "づ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "て":
				wordArray [wordIndex - 1] = "で";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "と":
				wordArray [wordIndex - 1] = "ど";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
				//BABIBUBEBO
			case "は":
				wordArray [wordIndex - 1] = "ば";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ひ":
				wordArray [wordIndex - 1] = "び";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ふ":
				wordArray [wordIndex - 1] = "ぶ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "へ":
				wordArray [wordIndex - 1] = "べ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ほ":
				wordArray [wordIndex - 1] = "ぼ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
				//PAPIPUPEPO
			case "ば":
				wordArray [wordIndex - 1] = "ぱ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "び":
				wordArray [wordIndex - 1] = "ぴ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ぶ":
				wordArray [wordIndex - 1] = "ぷ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "べ":
				wordArray [wordIndex - 1] = "ぺ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ぼ":
				wordArray [wordIndex - 1] = "ぽ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
				//YAYUYO TSU KECIL
			case "や":
				wordArray [wordIndex - 1] = "ゃ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "ゆ":
				wordArray [wordIndex - 1] = "ゅ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "よ":
				wordArray [wordIndex - 1] = "ょ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			case "づ":
				wordArray [wordIndex - 1] = "っ";
				for (int i = 0; i < wordIndex; i++)
					newWord += wordArray [i].ToString ();

				word = newWord;
				Output.text = word;
				break;
			}
			CheckInput ();
		}
	}

	bool CheckMaruTeng()
	{
		string[] validate = {"か","き","く","け","こ","さ","し","す","せ","そ","た","ち","つ","て","と",
			"は","ひ","ふ","へ","ほ","や","ゆ","よ","づ","ば","び","ぶ","べ","ぼ"};

		for(int i = 0; i < validate.Length; i++)
		{
			if (wordArray [wordIndex - 1].Contains (validate [i])) {
				return true;
			}
		}
		return false;
	}

	public void MaruTengRomajiFunction()
	{
		bool flag = CheckMaruTengRomaji();
		if (!flag) 
		{
			return;
		} 
		else 
		{
			string newWord = null;
			switch(wordArray[wordIndex-1])
			{
			//GAGIGUGEGO
			case "KA":
				wordArray [wordIndex - 1] = "GA";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "KI":
				wordArray [wordIndex - 1] = "GI";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "KU":
				wordArray [wordIndex - 1] = "GU";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "KE":
				wordArray [wordIndex - 1] = "GE";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "KO":
				wordArray [wordIndex - 1] = "GO";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				if(wordIndex < 2)
					word = "GO";
				else
					word = newWord;
				
				wordRomaji = newWord;
				Output.text = word;
				break;
				//ZAZIZUZEZO
			case "SA":
				wordArray [wordIndex - 1] = "ZA";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "SHI":
				wordArray [wordIndex - 1] = "JI";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "SU":
				wordArray [wordIndex - 1] = "ZU";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "SE":
				wordArray [wordIndex - 1] = "ZE";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "SO":
				wordArray [wordIndex - 1] = "ZO";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
				//DADIDUDEDO
			case "TA":
				wordArray [wordIndex - 1] = "DA";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "CHI":
				wordArray [wordIndex - 1] = "DJI";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "TSU":
				wordArray [wordIndex - 1] = "DZU";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "TE":
				wordArray [wordIndex - 1] = "DE";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "TO":
				wordArray [wordIndex - 1] = "DO";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
				//BABIBUBEBO
			case "HA":
				wordArray [wordIndex - 1] = "BA";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "HI":
				wordArray [wordIndex - 1] = "BI";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "FU":
				wordArray [wordIndex - 1] = "BU";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "HE":
				wordArray [wordIndex - 1] = "BE";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "HO":
				wordArray [wordIndex - 1] = "BO";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
				//PAPIPUPEPO
			case "BA":
				wordArray [wordIndex - 1] = "PA";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "BI":
				wordArray [wordIndex - 1] = "PI";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "BU":
				wordArray [wordIndex - 1] = "PU";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "BE":
				wordArray [wordIndex - 1] = "PE";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			case "BO":
				wordArray [wordIndex - 1] = "PO";
				for (int i = 0; i < wordIndex; i++)
					newWord += ConvertRomajiToHiragana(wordArray [i].ToString ());

				word = newWord;
				wordRomaji = newWord;
				Output.text = word;
				break;
			}
			CheckInput ();
		}
	}

	bool CheckMaruTengRomaji()
	{
		string[] validate = {"KA","KI","KU","KE","KO","SA","SHI","SU","SE","SO","TA","CHI","TSU","TE","TO",
			"HA","HI","FU","HE","HO","YA","YU","YO","DZU","BA","BI","BU","BE","BO"};

		for(int i = 0; i < validate.Length; i++)
		{
			if (wordArray [wordIndex - 1].Contains (validate [i])) {
				return true;
			}
		}
		return false;
	}


	string ConvertRomajiToHiragana(string romaji){
		if (romaji == null)
			return "";
		string temp = "";
		temp = (romaji.Equals("A")) ? "あ" : temp;
		temp = (romaji.Equals("I")) ? "い" : temp;
		temp = (romaji.Equals("U")) ? "う" : temp;
		temp = (romaji.Equals("E")) ? "え" : temp;
		temp = (romaji.Equals("O")) ? "お" : temp;
		temp = (romaji.Equals("KA")) ? "か" : temp;
		temp = (romaji.Equals("KI")) ? "き" : temp;
		temp = (romaji.Equals("KU")) ? "く" : temp;
		temp = (romaji.Equals("KE")) ? "け" : temp;
		temp = (romaji.Equals("KO")) ? "こ" : temp;
		temp = (romaji.Equals("SA")) ? "さ" : temp;
		temp = (romaji.Equals("SHI")) ? "し" : temp;
		temp = (romaji.Equals("SU")) ? "す" : temp;
		temp = (romaji.Equals("SE")) ? "せ" : temp;
		temp = (romaji.Equals("SO")) ? "そ" : temp;
		temp = (romaji.Equals("TA")) ? "た" : temp;
		temp = (romaji.Equals("CHI")) ? "ち" : temp;
		temp = (romaji.Equals("TSU")) ? "つ" : temp;
		temp = (romaji.Equals("TE")) ? "て" : temp;
		temp = (romaji.Equals("TO")) ? "と" : temp;
		temp = (romaji.Equals("NA")) ? "な" : temp;
		temp = (romaji.Equals("NI")) ? "に" : temp;
		temp = (romaji.Equals("NU")) ? "ぬ" : temp;
		temp = (romaji.Equals("NE")) ? "ね" : temp;
		temp = (romaji.Equals("NO")) ? "の" : temp;
		temp = (romaji.Equals("HA")) ? "は" : temp;
		temp = (romaji.Equals("HI")) ? "ひ" : temp;
		temp = (romaji.Equals("FU")) ? "ふ" : temp;
		temp = (romaji.Equals("HE")) ? "へ" : temp;
		temp = (romaji.Equals("HO")) ? "ほ" : temp;
		temp = (romaji.Equals("MA")) ? "ま" : temp;
		temp = (romaji.Equals("MI")) ? "み" : temp;
		temp = (romaji.Equals("MU")) ? "む" : temp;
		temp = (romaji.Equals("ME")) ? "め" : temp;
		temp = (romaji.Equals("MO")) ? "も" : temp;
		temp = (romaji.Equals("YA")) ? "や" : temp;
		temp = (romaji.Equals("YU")) ? "ゆ" : temp;
		temp = (romaji.Equals("YO")) ? "よ" : temp;
		temp = (romaji.Equals("RA")) ? "ら" : temp;
		temp = (romaji.Equals("RI")) ? "り" : temp;
		temp = (romaji.Equals("RU")) ? "る" : temp;
		temp = (romaji.Equals("RE")) ? "れ" : temp;
		temp = (romaji.Equals("RO")) ? "ろ" : temp;
		temp = (romaji.Equals("WA")) ? "わ" : temp;
		temp = (romaji.Equals("WO")) ? "を" : temp;
		temp = (romaji.Equals("N")) ? "ん" : temp;
		temp = (romaji.Equals("GA")) ? "が" : temp;
		temp = (romaji.Equals("GI")) ? "ぎ" : temp;
		temp = (romaji.Equals("GU")) ? "ぐ" : temp;
		temp = (romaji.Equals("GE")) ? "げ" : temp;
		temp = (romaji.Equals("GO")) ? "ご" : temp;
		temp = (romaji.Equals("ZA")) ? "ざ" : temp;
		temp = (romaji.Equals("JI")) ? "じ" : temp;
		temp = (romaji.Equals("ZU")) ? "ず" : temp;
		temp = (romaji.Equals("ZE")) ? "ぜ" : temp;
		temp = (romaji.Equals("ZO")) ? "ぞ" : temp;
		temp = (romaji.Equals("DA")) ? "だ" : temp;
		temp = (romaji.Equals("DJI")) ? "ぢ" : temp;
		temp = (romaji.Equals("DZU")) ? "づ" : temp;
		temp = (romaji.Equals("DE")) ? "で" : temp;
		temp = (romaji.Equals("DO")) ? "ど" : temp;
		temp = (romaji.Equals("BA")) ? "ば" : temp;
		temp = (romaji.Equals("BI")) ? "び" : temp;
		temp = (romaji.Equals("BU")) ? "ぶ" : temp;
		temp = (romaji.Equals("BE")) ? "べ" : temp;
		temp = (romaji.Equals("BO")) ? "ぼ" : temp;
		temp = (romaji.Equals("PA")) ? "ぱ" : temp;
		temp = (romaji.Equals("PI")) ? "ぴ" : temp;
		temp = (romaji.Equals("PU")) ? "ぷ" : temp;
		temp = (romaji.Equals("PE")) ? "ぺ" : temp;
		temp = (romaji.Equals("PO")) ? "ぽ" : temp;

		return temp;
	}



	public void OpenDetailKeyboard(string key){
		detailKeyboard.SetActive (true);
		switch(key)
		{
		case "A":
			keyButtons [0].SetActive (true);
			break;
		case "KA":
			keyButtons [1].SetActive (true);
			break;
		case "SA":
			keyButtons [2].SetActive (true);
			break;
		case "TA":
			keyButtons [3].SetActive (true);
			break;
		case "NA":
			keyButtons [4].SetActive (true);
			break;
		case "HA":
			keyButtons [5].SetActive (true);
			break;
		case "MA":
			keyButtons [6].SetActive (true);
			break;
		case "YA":
			keyButtons [7].SetActive (true);
			break;
		case "RA":
			keyButtons [8].SetActive (true);
			break;
		case "WA":
			keyButtons [9].SetActive (true);
			break;
		}
	}
	#endregion	
}
