using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievementUnlockedObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DisableThis()
	{
		this.gameObject.SetActive(false);
	}
}
