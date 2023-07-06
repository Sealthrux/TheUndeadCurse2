using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderDamage2 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.TakeDamage2Player();
        }
    }
}
