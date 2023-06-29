using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFists : MonoBehaviour
{
    public bool deuDano = false;
    public SphereCollider Fist1;
    public SphereCollider Fist2;

    private void Awake()
    {
        Fist1.enabled = false;
        Fist2.enabled = false;

    }

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
        Fist1.enabled = true;
        Fist2.enabled = true;
        deuDano = false;

    }

    private void AttackTriggerOff()
    {
        Fist1.enabled = false;
        Fist2.enabled = false;

    }
}

