using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public int colorNum;
	public Color [] colors;
	SpriteRenderer sr;
	public float maxX;
	public float maxY;
	public AudioClip score;
	Vector2 mousePos = new Vector2();

	// Use this for initialization
	void Start () {

		sr = GetComponent<SpriteRenderer> ();
		sr = GetComponent<SpriteRenderer> ();

	}
	
	// Update is called once per frame
	void Update () {

		colorHanlde ();
		stayOnScreen ();

		if (colorNum > 3) 
		{
			colorNum = 0; 
		}
		mousePos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		
	}

	void colorHanlde()
	{
		sr.color = colors [colorNum];
		if (Input.GetMouseButtonDown (0)) {
			colorNum++;
		}
	}

	void stayOnScreen()
	{
		if (mousePos.x >= maxX) {
			transform.position = new Vector2 (maxX, mousePos.y);
		} else if (mousePos.x <= maxX * -1) {
			transform.position = new Vector2 (maxX * -1, mousePos.y);
		} else if (mousePos.y >= maxY) {
			transform.position = new Vector2 (mousePos.x, maxY);
		} else if (mousePos.y <= maxY * -1) {
			transform.position = new Vector2 (mousePos.x, maxY * -1);
		} else {
			transform.position = mousePos;
		}
	}

	void OnTriggerEnter2D (Collider2D coll)
	{
		if (coll.gameObject.tag == "DangerBall") 
		{
			DangerBall db = coll.gameObject.GetComponent<DangerBall> ();
			if (db.colorNum == colorNum) {
				Destroy (coll.gameObject);
				GetComponent<AudioSource> ().PlayOneShot (score);
				GameObject.Find ("ScoreManager").GetComponent<Scoring> ().increaseScore ();
				BallList.balls.Remove (coll.gameObject);
			} else 
			{
				Destroy (this);
				GameObject.Find ("ScoreManager").GetComponent<Scoring> ().endGame.SetActive(true);
			}
		}
	}
}