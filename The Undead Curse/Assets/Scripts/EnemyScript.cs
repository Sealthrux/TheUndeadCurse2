using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public SphereCollider SphereCol;
    private void Awake()
    {
        SphereCol.enabled = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerFist"))
        {
            GameManager.instance.TakeDamagePlayer();
        }
    }

    private void AttackTriggerOn()
    {
        SphereCol.enabled = true;

    }

    private void AttackTriggerOff()
    {
        SphereCol.enabled = false;

    }
}
