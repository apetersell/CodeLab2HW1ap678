using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBall : MonoBehaviour {

	public float xSpeed;
	public float ySpeed;
	public float maxSpeed; 
	public float minSpeed;
	public float maxStartSpeed; 
	public float minStartSpeed;
	public int colorNum;
	public Sprite [] colors; 
	Rigidbody2D rb;
	SpriteRenderer sr;

	void Awake () 
	{
		findNewSpeed ();
		colorNum = Random.Range (0, 4);
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

	public void findNewSpeed ()
	{
		xSpeed = Random.Range (minStartSpeed, maxStartSpeed);  
		ySpeed = Random.Range (minStartSpeed, maxStartSpeed);  
	}

	void movement ()
	{
		sr.sprite = colors [colorNum];
		rb.velocity = new Vector2 (xSpeed, ySpeed);
		if (xSpeed > maxSpeed) 
		{
			xSpeed = maxSpeed;
		}
		if (xSpeed < maxSpeed * -1) 
		{
			xSpeed = maxSpeed * -1;
		}
		if (ySpeed > maxSpeed) 
		{
			ySpeed = maxSpeed;
		}
		if (ySpeed < maxSpeed * -1) 
		{
			ySpeed = maxSpeed * -1;
		}


	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "WallX")
		{
			xSpeed = xSpeed * -1.1f;
		}
		if (coll.gameObject.tag == "WallY")
		{
			ySpeed = ySpeed * -1.1f;
		}
		if (coll.gameObject.tag == "DangerBall") 
		{
			colorNum = coll.gameObject.GetComponent<DangerBall> ().colorNum;
			xSpeed = xSpeed * -1.1f;
			ySpeed = ySpeed * -1.1f;
		}
		colorNum = Random.Range (0, 4);
	}


}
