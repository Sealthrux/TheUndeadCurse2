using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFists : MonoBehaviour
{
    
    public GameObject Fist1;
    public GameObject Fist2;

    private void Awake()
    {
        Fist1.SetActive(false);
        Fist2.SetActive(false);
    }

    private void AttackTriggerOn()
    {
        Fist1.SetActive(true);
        Fist1.SetActive(true);
        Fist1.gameObject.GetComponent<PlayerFistDamage>().deuDano = false;
        Fist2.gameObject.GetComponent<PlayerFistDamage>().deuDano = false;

    }

    private void AttackTriggerOff()
    {
        Fist1.SetActive(false);
        Fist2.SetActive(false);

    }
}

