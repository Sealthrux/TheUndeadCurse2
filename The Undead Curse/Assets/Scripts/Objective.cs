using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Objective : MonoBehaviour
{
    public string Text1;
    public string Text2;
    public TMP_Text ObjectiveText;
    public TMP_Text ObjectiveCounter;
    public float ObjectiveNum;
    public float CurrentObjectiveNum = 0;


    public void Start()
    {
        // Create a temporary reference to the current scene.
        Scene currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;


        Text1 = "Consume "+ ObjectiveNum + " human meat";
        Text2 = CurrentObjectiveNum + "/" + ObjectiveNum;

        ObjectiveText.text = Text1;
        ObjectiveCounter.text = Text2;

        if (sceneName == "MainScene")
        {
            ObjectiveNum = 3;
        }
    }
    public void Update()
    {
        
    }
}
