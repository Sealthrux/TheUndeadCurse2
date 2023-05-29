 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string MainScene;
    public void PlayGame()
   {
      SceneManager.LoadScene(MainScene);
   }

   public void QuitGame()
   {
    Application.Quit(); 
   }
}
