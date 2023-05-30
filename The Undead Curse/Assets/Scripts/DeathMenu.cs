using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public string Menu;
    public string MainScene;
    public void ExitToMain()
    {
        SceneManager.LoadScene(Menu);
    }

    public void Restart()
    {
        SceneManager.LoadScene(MainScene);
    }
}
