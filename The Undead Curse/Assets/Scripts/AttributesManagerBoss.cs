using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManagerBoss : MonoBehaviour
{
    private int health = 24;
    public void TakeDamageBoss(int amount)
    {
        health -= amount;

        if (health <= 0)
        {
            // Chamada para a função que faz o GameObject desaparecer
           Disappear();
        }
    }


    private void Disappear()
    {
        // Desativa o GameObject
        Destroy(gameObject);
    }

  
}