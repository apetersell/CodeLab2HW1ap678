using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scoring : MonoBehaviour {

	public int score;
	public Text scoreDisplay;
	public Text finalScore;
	public GameObject endGame;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		scoreDisplay.text = score.ToString ();
		finalScore.text = score.ToString ();
		if (Input.GetKeyDown(KeyCode.R))
		{
			BallList.balls.Clear ();
			SceneManager.LoadScene (0);
		}
		
	}

	public void increaseScore ()
	{
		score++;
	}
}
