using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerBallSpawner : MonoBehaviour {

	Rigidbody2D rb;
	public float xSpeed;
	public float ySpeed;
	public GameObject dangerBall;
	public int ballLimit;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody2D> ();
		InvokeRepeating ("makeDangerBall", 1, 1);
		
	}
	
	// Update is called once per frame
	void Update () {

		movement ();
		
	}

	void movement ()
	{
		rb.velocity = new Vector2 (xSpeed, ySpeed);
	}

	void OnCollisionEnter2D (Collision2D coll)
	{
		if (coll.gameObject.tag == "WallX")
		{
			xSpeed = xSpeed * -1f;
		}
		if (coll.gameObject.tag == "WallY")
		{
			ySpeed = ySpeed * -1f;
		}
		if (coll.gameObject.tag == "DangerBall") 
		{
			xSpeed = xSpeed * -1f;
			ySpeed = ySpeed * -1f;
		}
	}

	void makeDangerBall ()
	{

		if (BallList.balls.Count <= ballLimit)
		{
		GameObject newDangerBall = Instantiate (dangerBall) as GameObject;
		newDangerBall.transform.position = transform.position;
		newDangerBall.GetComponent<DangerBall> ().findNewSpeed ();
		BallList.balls.Add (newDangerBall);
		}

	}


}
