using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void Awake()
    {
        GetComponent<SphereCollider>().enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.TakeDamagePlayer();
        }
    }

    private void AttackTriggerOn()
    {
        GetComponent<SphereCollider>().enabled = true;

    }

    private void AttackTriggerOff()
    {
        GetComponent<SphereCollider>().enabled = false;

    }
}
