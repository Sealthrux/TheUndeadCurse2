using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    [SerializeField]
    public int lifes = 10;

    [SerializeField]
    List<Image> vidas = new List<Image>();


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LifeMax()
    {
        if (lifes >= 10)
        {
            lifes = 10;
        }

        else
        {
            lifes++;
        }
    }
}