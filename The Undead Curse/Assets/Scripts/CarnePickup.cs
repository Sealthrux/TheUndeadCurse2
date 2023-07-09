using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarnePickup : MonoBehaviour
{
    private AudioSource sound;

    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            sound.Play();
            GameManager.instance.PickupCarnes();
            GameObject.Destroy(this.gameObject, 2.0f);
        }
    }
}
