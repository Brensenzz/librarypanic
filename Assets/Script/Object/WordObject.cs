using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordObject : MonoBehaviour {

	float fall = 0;
	public float fallSpeed;

	bool isDown = true;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(isDown)
			transform.Translate((new Vector3(0,GameManager.instance.fallSpeed,0)/3) * Time.deltaTime,Space.World);

//		if(Time.time - fall >= fallSpeed)
//		{
//			transform.position += new Vector3 (0,-1,0);
//
//			fall = Time.time;
//
//		}



//		if(transform.position.y <= borderPosition.position.y)
//		{
//			Destroy (this.gameObject);
//			GameManager.instance.DecreaseHealthBar ();
//		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		isDown = false;
		gameObject.tag = "Untagged";
		this.gameObject.GetComponent<TextMesh> ().text = "";
		GameManager.instance.DecreaseHealthBar ();
	}
}
