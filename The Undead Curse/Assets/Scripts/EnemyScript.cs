using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public SphereCollider SphereCol;

    [SerializeField]
    private AudioSource deathsound;
    private void Awake()
    {
        SphereCol.enabled = false;
    }
    

    private void AttackTriggerOn()
    {
        SphereCol.enabled = true;

    }

    private void AttackTriggerOff()
    {
        SphereCol.enabled = false;

    }
    private void DeathSoundFun()
    {
        deathsound.Play();
    }
    
}
