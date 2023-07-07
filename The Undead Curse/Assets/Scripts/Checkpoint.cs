using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public bool checkpointplayed = false;
    public GameObject PlayerCam;
    public GameObject CheckPointCam;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCam.SetActive(true);
        CheckPointCam.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "CheckPoint" && checkpointplayed == false)
        {
            checkpointplayed = true;
            PlayerCam.SetActive(false);
            CheckPointCam.SetActive(true);
            Invoke("SwitchToPlayerCam", 6f);
        }
    }

    void SwitchToPlayerCam()
    {
        PlayerCam.SetActive(true);
        CheckPointCam.SetActive(false);

        switch (SceneManager.GetActiveScene().name)
        {
            case "MainScene":
                SceneManager.LoadScene("Level2");
                break;
            case "Level2":
                SceneManager.LoadScene("Level3");
                break;
            case "Level3":
                SceneManager.LoadScene("Level4");
                break;
            case "Level4":
                SceneManager.LoadScene("Level5");
                break;
            case "Level5":
                SceneManager.LoadScene("Level6");
                break;
            case "Level6":
                SceneManager.LoadScene("FinalLevel");
                break;
            case "FinalLevel":
                SceneManager.LoadScene("WinScene");
                break;
                
        }  
    }
}