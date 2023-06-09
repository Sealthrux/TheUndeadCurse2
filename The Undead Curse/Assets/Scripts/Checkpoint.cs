using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour
{
    public bool checkpointplayed = false;
    public GameObject PlayerCam;
    public GameObject CheckPointCam;
    public int NextScene;

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
            //SwitchToPlayerCam();
        }
    }

    void SwitchToPlayerCam()
    {
        PlayerCam.SetActive(true);
        CheckPointCam.SetActive(false);

        SceneManager.LoadScene(NextScene);
    
        
             
    }
}