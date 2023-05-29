using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if(other.gameObject.name=="CheckPoint"&&checkpointplayed==false)
        {
            checkpointplayed=true;
            PlayerCam.SetActive(false);
            CheckPointCam.SetActive(true);
            Invoke("SwitchToPlayerCam",6f);
        }
    }

    void SwitchToPlayerCam()
    {
        PlayerCam.SetActive(true);
        CheckPointCam.SetActive(false);
    }
}