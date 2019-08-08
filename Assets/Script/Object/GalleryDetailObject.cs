using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryDetailObject : MonoBehaviour {

	public Image imageGallery;
	public Text titleGallery;
	public Text spellingGallery;
	public Text hiraganaGallery;
	public Text detailGallery;

	void OnEnable(){
		imageGallery.sprite = Resources.Load<Sprite> ("Chaos/"+StaticData.tempDetailGallery);
		switch (StaticData.tempDetailGallery) {
		//FOOD EASY
		case "ごはん":
			titleGallery.text = "Rice";
			spellingGallery.text = "go-ha-n";
			hiraganaGallery.text = "ごはん";
			detailGallery.text = "Rice";
			break;

		case "たまご":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "たまご";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "にく":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "にく";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "さかな":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "さかな";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "やさい":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "やさい";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "みず":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "みず";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "りんご":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "りんご";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//FOOD MEDIUM
		case "さとう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "さとう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "おかし":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "おかし";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "べんとう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "べんとう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "しお":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "しお";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "みるく":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "みるく";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "みかん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "みかん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//FOOD HARD
		case "さけ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "さけ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "すきやき":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "すきやき";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "さしみ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "さしみ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "すし":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "すし";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "てんぷら":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "てんぷら";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "おちゃ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "おちゃ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//TOOL EASY
		case "いす":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "いす";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "はし":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "はし";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かみ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かみ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "くつ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "くつ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ほん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ほん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "はこ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "はこ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "えんぴつ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "えんぴつ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//TOOL MEDIUM
		case "とけい":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "とけい";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "つくえ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "つくえ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "はさみ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "はさみ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "めいし":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "めいし";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かぎ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かぎ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ざっし":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ざっし";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "じしょ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "じしょ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//TOOL HARD
		case "かさ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かさ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "てちょう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "てちょう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "めがね":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "めがね";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かばん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かばん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "でんち":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "でんち";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "しんぶん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "しんぶん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ちず":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ちず";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//PLACE EASY
		case "かわ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かわ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "うみ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "うみ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "やま":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "やま";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "うち":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "うち";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "えき":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "えき";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "にわ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "にわ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "まち":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "まち";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//PLACE MEDIUM
		case "ほんや":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ほんや";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "まつり":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "まつり";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "くうこう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "くうこう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ぎんこう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ぎんこう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "じむしょ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "じむしょ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かいしゃ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かいしゃ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かいだん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かいだん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "こうえん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "こうえん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//PLACE HARD
		case "としょかん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "としょかん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "がっこう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "がっこう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "せかい":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "せかい";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ゆうびんきょく":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ゆうびんきょく";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "びじゅつかん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "びじゅつかん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "きょうしつ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "きょうしつ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "びょういん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "びょういん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "だいがく":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "だいがく";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//ANIMAl EASY
		case "くま":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "くま";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "とり":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "とり";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ねこ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ねこ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "うし":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "うし";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "つる":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "つる";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "いぬ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "いぬ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//ANIMAL MEDIUM
		case "さる":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "さる";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "いるか":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "いるか";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ぞう":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ぞう";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "きつね":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "きつね";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かえる":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かえる";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "きりん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "きりん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "やぎ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "やぎ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "うま":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "うま";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

			//ANIMAL HARD
		case "しまうま":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "しまうま";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ねずみ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ねずみ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "たこ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "たこ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ぶた":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ぶた";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "さめ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "さめ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ひつじ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ひつじ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "へび":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "へび";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "いか":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "いか";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "りす":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "りす";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "とら":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "とら";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かめ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かめ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "くじら":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "くじら";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "おおかみ":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "おおかみ";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "かんこく":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "かんこく";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "き":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "き";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "ちゅうごく":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "ちゅうごく";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		case "にほん":
			titleGallery.text = "Apple";
			spellingGallery.text = "ri-n-go";
			hiraganaGallery.text = "にほん";
			detailGallery.text = "An apple is a sweet, edible fruit produced by an apple tree (Malus pumila).";
			break;

		}
	}
	
}
