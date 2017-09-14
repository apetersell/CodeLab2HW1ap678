using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	Vector3 mousePos;

	public bool red;
	public bool yellow;
	public bool green;
	public bool blue; 
	SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		colorHanlde ();

		Vector2 mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		transform.position = mousePos;
		sr = GetComponent<SpriteRenderer> ();
		
	}

	void colorHanlde()
	{
//		if (red) {
//			sr.color = Color.red;
//		}
//		if (yellow) {
//			sr.color = Color.yellow;
//		}
//		if (green) {
//			sr.color = Color.green;
//		}
//		if (blue) {
//			sr.color = Color.blue;
//		}
//
//		if (Input.GetKeyDown (KeyCode.A)) 
//		{
//			red = true;
//			yellow = false;
//			green = false;
//			blue = false;
//		}
//		if (Input.GetKeyDown (KeyCode.S)) 
//		{
//			yellow = true;
//			red = false;
//			green = false;
//			blue = false;
//		}
//		if (Input.GetKeyDown (KeyCode.D))
//		{
//			green = true;
//			red = false;
//			yellow = false;
//			blue = false;
//		}
//		if (Input.GetKeyDown (KeyCode.F))
//		{
//			blue = true;
//			red = false;
//			yellow = false;
//			green = false;
//		}
	}
}