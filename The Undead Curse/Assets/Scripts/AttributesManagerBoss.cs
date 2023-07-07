using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttributesManagerBoss : MonoBehaviour
{
    Animator animator;
    private int health = 10;
    public string WinScene;
    public void TakeDamageBoss(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            animator.SetTrigger("isDead");
        }
    }


    private void Disappear()
    {
        Destroy(gameObject);
        Invoke("FinalBossWin", 6f);
    }

    private void FinalBossWin()
    {
        SceneManager.LoadScene(WinScene);
    }
}