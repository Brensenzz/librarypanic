using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalleryManager : MonoBehaviour {

	public static void CheckGallery(string word)
	{
		switch (word) {
		//FOOD EASY
		case "ごはん":
			UnlockGallery ("ごはん");
			break;

		case "たまご":
			UnlockGallery ("たまご");
			break;

		case "にく":
			UnlockGallery ("にく");
			break;

		case "さかな":
			UnlockGallery ("さかな");
			break;

		case "やさい":
			UnlockGallery ("やさい");
			break;

		case "みず":
			UnlockGallery ("みず");
			break;

		case "りんご":
			UnlockGallery ("りんご");
			break;

		//FOOD MEDIUM
		case "さとう":
			UnlockGallery ("さとう");
			break;

		case "おかし":
			UnlockGallery ("おかし");
			break;

		case "べんとう":
			UnlockGallery ("べんとう");
			break;

		case "しお":
			UnlockGallery ("しお");
			break;

		case "みるく":
			UnlockGallery ("みるく");
			break;

		case "みかん":
			UnlockGallery ("みかん");
			break;
		
		//FOOD HARD
		case "さけ":
			UnlockGallery ("さけ");
			break;

		case "すきやき":
			UnlockGallery ("すきやき");
			break;

		case "さしみ":
			UnlockGallery ("さしみ");
			break;

		case "すし":
			UnlockGallery ("すし");
			break;

		case "てんぷら":
			UnlockGallery ("てんぷら");
			break;

		case "おちゃ":
			UnlockGallery ("おちゃ");
			break;
		
		//TOOL EASY
		case "いす":
			UnlockGallery ("いす");
			break;

		case "はし":
			UnlockGallery ("はし");
			break;

		case "かみ":
			UnlockGallery ("かみ");
			break;

		case "くつ":
			UnlockGallery ("くつ");
			break;

		case "ほん":
			UnlockGallery ("ほん");
			break;

		case "はこ":
			UnlockGallery ("はこ");
			break;

		case "えんぴつ":
			UnlockGallery ("えんぴつ");
			break;
		
		//TOOL MEDIUM
		case "とけい":
			UnlockGallery ("とけい");
			break;

		case "つくえ":
			UnlockGallery ("つくえ");
			break;

		case "はさみ":
			UnlockGallery ("はさみ");
			break;

		case "めいし":
			UnlockGallery ("めいし");
			break;

		case "かぎ":
			UnlockGallery ("かぎ");
			break;

		case "ざっし":
			UnlockGallery ("ざっし");
			break;

		case "じしょ":
			UnlockGallery ("じしょ");
			break;

		//TOOL HARD
		case "かさ":
			UnlockGallery ("かさ");
			break;

		case "てちょう":
			UnlockGallery ("てちょう");
			break;

		case "めがね":
			UnlockGallery ("めがね");
			break;

		case "かばん":
			UnlockGallery ("かばん");
			break;

		case "でんち":
			UnlockGallery ("でんち");
			break;

		case "しんぶん":
			UnlockGallery ("しんぶん");
			break;

		case "ちず":
			UnlockGallery ("ちず");
			break;

		//PLACE EASY
		case "かわ":
			UnlockGallery ("かわ");
			break;

		case "うみ":
			UnlockGallery ("うみ");
			break;

		case "やま":
			UnlockGallery ("やま");
			break;

		case "うち":
			UnlockGallery ("うち");
			break;

		case "えき":
			UnlockGallery ("えき");
			break;

		case "にわ":
			UnlockGallery ("にわ");
			break;

		case "まち":
			UnlockGallery ("まち");
			break;

		//PLACE MEDIUM
		case "ほんや":
			UnlockGallery ("ほんや");
			break;

		case "まつり":
			UnlockGallery ("まつり");
			break;

		case "くうこう":
			UnlockGallery ("くうこう");
			break;

		case "ぎんこう":
			UnlockGallery ("ぎんこう");
			break;

		case "じむしょ":
			UnlockGallery ("じむしょ");
			break;

		case "かいしゃ":
			UnlockGallery ("かいしゃ");
			break;

		case "かいだん":
			UnlockGallery ("かいだん");
			break;

		case "こうえん":
			UnlockGallery ("こうえん");
			break;

		//PLACE HARD
		case "としょかん":
			UnlockGallery ("としょかん");
			break;

		case "がっこう":
			UnlockGallery ("がっこう");
			break;

		case "せかい":
			UnlockGallery ("せかい");
			break;

		case "ゆうびんきょく":
			UnlockGallery ("ゆうびんきょく");
			break;

		case "びじゅつかん":
			UnlockGallery ("びじゅつかん");
			break;

		case "きょうしつ":
			UnlockGallery ("きょうしつ");
			break;

		case "びょういん":
			UnlockGallery ("びょういん");
			break;

		case "だいがく":
			UnlockGallery ("だいがく");
			break;

		//ANIMAl EASY
		case "くま":
			UnlockGallery ("くま");
			break;

		case "とり":
			UnlockGallery ("とり");
			break;

		case "ねこ":
			UnlockGallery ("ねこ");
			break;

		case "うし":
			UnlockGallery ("うし");
			break;

		case "つる":
			UnlockGallery ("つる");
			break;

		case "いぬ":
			UnlockGallery ("いぬ");
			break;

		//ANIMAL MEDIUM
		case "さる":
			UnlockGallery ("さる");
			break;

		case "いるか":
			UnlockGallery ("いるか");
			break;

		case "ぞう":
			UnlockGallery ("ぞう");
			break;

		case "きつね":
			UnlockGallery ("きつね");
			break;

		case "かえる":
			UnlockGallery ("かえる");
			break;

		case "きりん":
			UnlockGallery ("きりん");
			break;

		case "やぎ":
			UnlockGallery ("やぎ");
			break;

		case "うま":
			UnlockGallery ("うま");
			break;

		//ANIMAL HARD
		case "しまうま":
			UnlockGallery ("しまうま");
			break;

		case "ねずみ":
			UnlockGallery ("ねずみ");
			break;

		case "たこ":
			UnlockGallery ("たこ");
			break;

		case "ぶた":
			UnlockGallery ("ぶた");
			break;

		case "さめ":
			UnlockGallery ("さめ");
			break;

		case "ひつじ":
			UnlockGallery ("ひつじ");
			break;

		case "へび":
			UnlockGallery ("へび");
			break;

		case "いか":
			UnlockGallery ("いか");
			break;

		case "りす":
			UnlockGallery ("りす");
			break;

		case "とら":
			UnlockGallery ("とら");
			break;

		case "かめ":
			UnlockGallery ("かめ");
			break;

		case "くじら":
			UnlockGallery ("くじら");
			break;

		case "おおかみ":
			UnlockGallery ("おおかみ");
			break;

		case "かんこく":
			UnlockGallery ("かんこく");
			break;

		case "き":
			UnlockGallery ("き");
			break;

		case "ちゅうごく":
			UnlockGallery ("ちゅうごく");
			break;

		case "にほん":
			UnlockGallery ("にほん");
			break;
		}


	}

	static void UnlockGallery(string word){
		if (!IsLocked (word))
			return;

		PlayerPrefs.SetInt ("Glr" + word,1);
	}

	public static bool IsLocked(string word)
	{
		bool result = true;
		if(PlayerPrefs.HasKey("Glr" + word))
		{
			int temp = PlayerPrefs.GetInt ("Glr", 1);
			if (temp == 1)
				result = false;
		}

		return result;
	}
}
