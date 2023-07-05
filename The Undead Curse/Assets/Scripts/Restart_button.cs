using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart_button : MonoBehaviour
{
   public string menuSceneName; 
    public string mainSceneName;

    private void Start()
    {
        
        UnityEngine.UI.Button restartButton = GameObject.Find("RestartButton").GetComponent<UnityEngine.UI.Button>();
        restartButton.onClick.AddListener(RestartGame);

        UnityEngine.UI.Button menuButton = GameObject.Find("MenuButton").GetComponent<UnityEngine.UI.Button>();
        menuButton.onClick.AddListener(GoToMenu);
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(mainSceneName);
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene(menuSceneName);
    }
}
