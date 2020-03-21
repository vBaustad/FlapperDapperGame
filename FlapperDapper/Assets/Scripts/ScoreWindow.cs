using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CodeMonkey;

public class ScoreWindow : MonoBehaviour
{

    private Text scoreText;
    private void Awake()
    {
        scoreText = transform.Find("scoreText").GetComponent<Text>();

    }

    private void Update()
    {
        scoreText.text = Level.GetInstance().GetPipesSpawned().ToString();
        CMDebug.TextPopupMouse(scoreText.text);
    }
}
