using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderDamage3 : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GameManager.instance.TakeDamageBossPlayer();
        }
    }
}
