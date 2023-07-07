using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    Animator animator;
    private int health = 3;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }


    public void TakeDamage(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            animator.SetTrigger("isDeadMerc");
        }
    }


    private void Disappear()
    {
        // Desativa o GameObject
        Destroy(gameObject);
    }

  
}