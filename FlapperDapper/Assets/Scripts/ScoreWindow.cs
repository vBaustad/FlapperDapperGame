using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey;

public class ScoreWindow : MonoBehaviour
{

    private Text scoreText;
    private Text highscoreText;
    private void Awake()
    {
        scoreText = transform.Find("scoreText").GetComponent<Text>();
        highscoreText = transform.Find("highscoreText").GetComponent<Text>();

    }

    private void OnEnable()
    {
        highscoreText.text = "HIGHSCORE: " + Score.GetHighscore().ToString();
    }

    private void Update()
    {
        scoreText.text = Level.GetInstance().GetPipesPassedCount().ToString();
    }
}
