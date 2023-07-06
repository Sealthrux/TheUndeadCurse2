using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    private int health = 6;
    public void TakeDamage(int amount)
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