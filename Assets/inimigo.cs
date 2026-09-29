using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public int dano = 20;
    void OnCollisionEnter2D(Collision2D collision)
    {
        player player = collision.gameObject.GetComponent<player>();
        if (player != null)
        {
            player.TomarDano(dano);
            Debug.Log("Dano aplicado ao player");
        }
    }
}
