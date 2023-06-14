using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnePickup : MonoBehaviour
{
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameManager.instance.PickupCarnes();
            GameObject.Destroy(this.gameObject);
        }
    }
}
