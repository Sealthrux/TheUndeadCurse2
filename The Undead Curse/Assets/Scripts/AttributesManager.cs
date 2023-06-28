using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    public int health = 100;
    public int attack;
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
        gameObject.SetActive(false);
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            float totalDamage = attack;

            atm.TakeDamage((int)totalDamage);
        }
    }
}