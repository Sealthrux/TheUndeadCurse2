using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFists : MonoBehaviour
{
    public bool deuDano = false;


    private void OnTriggerEnter(Collider other)
    {
    if (other.tag == "Enemy" && !deuDano)
        {
            other.gameObject.GetComponent<AttributesManager>().TakeDamage(1);
            deuDano = true;
        }

    }

    private void AttackTriggerOn()
    {
        GetComponent<SphereCollider>().enabled = true;
        deuDano = false;

    }

    private void AttackTriggerOff()
    {
        GetComponent<SphereCollider>().enabled = false;

    }
}

