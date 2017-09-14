using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoring : MonoBehaviour {

	public int score;
	public Text scoreDisplay;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		scoreDisplay.text = score.ToString ();
		
	}

	public void increaseScore ()
	{
		score++;
	}
}
