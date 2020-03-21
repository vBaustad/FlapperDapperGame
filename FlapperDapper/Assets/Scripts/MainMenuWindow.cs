using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class MainMenuWindow : MonoBehaviour
{
    private void Awake()
    {
        transform.Find("playButton").GetComponent<Button_UI>().ClickFunc = () =>
        {
            Loader.Load(Loader.Scene.GameScene);
        };

        transform.Find("quitButton").GetComponent<Button_UI>().ClickFunc = () =>
        {
            Application.Quit();
        };
    }
}
