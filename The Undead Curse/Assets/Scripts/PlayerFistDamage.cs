using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFistDamage : MonoBehaviour
{

    public bool deuDano = false;


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy" && !deuDano)
        {
            other.gameObject.GetComponent<AttributesManager>().TakeDamage(1);
            deuDano = true;
        }


        if (other.tag == "EnemyPeasant" && !deuDano)
        {
            other.gameObject.GetComponent<AttributesManagerPeasant>().TakeDamagePeasant(1);
            deuDano = true;
        }
    }
}
