 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string NextScene;
    public void PlayGame()
   {
      SceneManager.LoadScene(NextScene);
   }

   public void QuitGame()
   {
    Application.Quit(); 
   }
}
