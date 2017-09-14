using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBall : MonoBehaviour {

	public float xSpeed;
	public float ySpeed;
	public float maxSpeed; 
	public float minSpeed;
	public int colorNum;
	public Sprite [] colors; 
	Rigidbody2D rb;
	SpriteRenderer sr;

	void Awake () 
	{
		findNewSpeed ();
	}

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
		
	}
	
	// Update is called once per frame
	void Update () {

		movement ();
		
	}

	void findNewSpeed ()
	{
		xSpeed = Random.Range (minSpeed, maxSpeed); 
		ySpeed = Random.Range (minSpeed, maxSpeed); 
	}

	void movement ()
	{
		sr.sprite = colors [colorNum];
		rb.velocity = new Vector2 (xSpeed, ySpeed);


	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "WallX")
		{
			xSpeed = xSpeed * -1;
		}
		if (coll.gameObject.tag == "WallY")
		{
			ySpeed = ySpeed * -1;
		}
		colorNum = Random.Range (0, 4);
	}


}
