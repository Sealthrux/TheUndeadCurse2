using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public GameObject CheckPoint;

    public HUDScript MyHUD;
    public Objective ObjectiveScript;
    public Timer TimerScript;

    public GameObject Player;

    public void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else
        {
            instance = this;
        }
    }

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PickupCarnes()
    {
        MyHUD.LifeMax();


        ObjectiveScript.ObjectiveCheckpoint();
    }

    public void TakeDamagePlayer()
    {
        MyHUD.TakeDamage();
    }


    public void Update()
    {
      if (ObjectiveScript.ObjectiveComplete() && TimerScript.TimerCheck())
        {
            CheckPoint.gameObject.SetActive(true);
        }

        if (TimerScript.TimerDeath() == true)
        {
            MyHUD.LifesTimerDeath();
        }
    }

}