using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GalleryObject : MonoBehaviour {

	public Image imageGallery;
	public Button buttonGallery;
	public string name;
	public GameObject secondPopupPanel;
	public GameObject galleryDetailPopup;

	// Use this for initialization
	void Start () {
		if(!GalleryManager.IsLocked(name))
		{
			imageGallery.sprite = Resources.Load<Sprite> ("Chaos/"+name);
			buttonGallery.interactable = true;
		}
	}

	public void openDetailGallery(){
		StaticData.tempDetailGallery = gameObject.name;
		Debug.Log (StaticData.tempDetailGallery);

		secondPopupPanel.SetActive (true);
		galleryDetailPopup.SetActive (true);
	}
}
