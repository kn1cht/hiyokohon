using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameResult : MonoBehaviour {
	private int highScore;
	public Text resultTime;
	public Text bestTime;
	public GameObject resultUI;

	// Use this for initialization
	void Start () {
		if(PlayerPrefs.HasKey("HighScore")) {
			highScore = PlayerPrefs.GetInt("HighScore");
		}
		else {
			highScore = 999;
		}
	}

	// Update is called once per frame
	void Update () {
		if(GoalCheck.goal) {
			resultUI.SetActive(true);
			int result = Mathf.FloorToInt(Timer.time);
			resultTime.text = "Time: " + result;
			bestTime.text = "BestTime: " + Math.Min(highScore, result);
			if(highScore > result) {
				PlayerPrefs.SetInt("HighScore", result);
			}
		}
	}

	public void OnRetry() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
}
