using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTester : MonoBehaviour
{
    public AttributesManager playerAtm;
    public AttributesManager enemyAtm;
    // Update is called once per frame
    private void Update()
    {
        // vídeo https://www.youtube.com/watch?v=NHuoiGtiZ7M
        if (Input.GetMouseButtonDown(0)) // Verifica se o botão esquerdo do mouse foi clicado
        {
            playerAtm.DealDamage(enemyAtm.gameObject);
        }
    }
}
