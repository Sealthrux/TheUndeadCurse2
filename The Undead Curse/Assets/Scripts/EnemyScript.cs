using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)

    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.instance.TakeDamagePlayer();
        }
    }
}
