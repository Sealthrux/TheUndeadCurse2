using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFists : MonoBehaviour
{
    
    public SphereCollider Fist1;
    public SphereCollider Fist2;

    private void Awake()
    {
        Fist1.enabled = false;
        Fist2.enabled = false;

    }

    private void AttackTriggerOn()
    {
        Fist1.enabled = true;
        Fist2.enabled = true;
        Fist1.gameObject.GetComponent<PlayerFistDamage>().deuDano = false;
        Fist2.gameObject.GetComponent<PlayerFistDamage>().deuDano = false;

    }

    private void AttackTriggerOff()
    {
        Fist1.enabled = false;
        Fist2.enabled = false;

    }
}

