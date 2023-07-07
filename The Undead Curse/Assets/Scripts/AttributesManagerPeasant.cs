using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManagerPeasant : MonoBehaviour
{
    Animator animator;
    private int health = 2;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    public void TakeDamagePeasant(int amount)
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
    }

  
}