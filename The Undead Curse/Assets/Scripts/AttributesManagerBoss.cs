using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AttributesManagerBoss : MonoBehaviour
{
    Animator animator;
    private int health = 6;
    public int WinScene;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void TakeDamageBoss(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            animator.SetTrigger("isDeadBoss");
        }
    }


    private void Disappear()
    {
        Destroy(gameObject);
        FinalBossWin();
    }

    private void FinalBossWin()
    {
        SceneManager.LoadScene(WinScene);
        Cursor.lockState = CursorLockMode.None;
    }
}