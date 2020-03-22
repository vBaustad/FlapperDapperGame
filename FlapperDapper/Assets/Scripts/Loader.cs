using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Loader  
{
  
    public enum Scene
    {
        Loading,
        GameScene,
        MainMenu,
    }

    private static Scene targetScene;
    public static void Load(Scene scene)
    {
        SceneManager.LoadScene(Scene.Loading.ToString());

        targetScene = scene;
    }

    public static void LoadTargetScene()
    {

        SceneManager.LoadScene(targetScene.ToString());
    }
}
