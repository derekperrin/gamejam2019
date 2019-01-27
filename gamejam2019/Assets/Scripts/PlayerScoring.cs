using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScoring : MonoBehaviour {

	public int score;
	public Text scoreText;
	// Use this for initialization
	void Start () {
		score = 0;
		UpdateScore(score);
	}

	public void UpdateScore(int points) {
		Debug.Log("Updating Score: " + points.ToString());
		score += points;
		scoreText.text = "Score: " + score.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
