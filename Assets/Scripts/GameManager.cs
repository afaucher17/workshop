using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
	public Text gameOverText;
	public Text scoreText;
	public static GameManager instance;
	public int scoreValue = 0;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else {
			Destroy (this.gameObject);
		}
	}

	public void ChangeScoreValue()
	{
		scoreValue += 1;
		scoreText.text = "SCORE : " + scoreValue;
	}

	public void DisplayGameOverText()
	{
		gameOverText.gameObject.SetActive (true);
	}
}
