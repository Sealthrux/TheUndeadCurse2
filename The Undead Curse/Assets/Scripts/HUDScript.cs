using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    [SerializeField]
    public int lives = 10;

    public GameObject HEALTHBAR;
    public GameObject HPBarPrefab;
    public string DeathScene;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HPBarUpdate();

        if (lives <= 0)
        {
            SceneManager.LoadScene(DeathScene);
        }
    }

    public void LifeMax()
    {
        if (lives >= 10)
        {
            lives = 10;
        }

        else
        {
            lives++;
        }
    }

    public void HPBarUpdate()
    {
        if (lives <= 0)
        {
            return;
        }
            if (HEALTHBAR.transform.childCount > lives)
        {
            float healthtemp = HEALTHBAR.transform.childCount - lives;

            for (int i = 0; i < healthtemp; i++)
            {
                GameObject.Destroy(HEALTHBAR.transform.GetChild(HEALTHBAR.transform.childCount - i - 1).gameObject);
            }
        }
        else if (HEALTHBAR.transform.childCount < lives)
        {
            float healthtemp2 = lives - HEALTHBAR.transform.childCount;

            for (int i = 0; i < healthtemp2; i++)
            {
                GameObject.Instantiate(HPBarPrefab, HEALTHBAR.transform);
            }
        }
    }

    public void LifesTimerDeath()
    {
        lives = 0;
    }

    public void TakeDamage()
    {
        lives--;
    }

    public void TakeDamage2()
    {
        lives = lives - 2;
    }
    public void TakeDamageBoss()
    {
        lives = lives - 1;
        lives = lives - 1;
        lives = lives - 1;
    }
}
