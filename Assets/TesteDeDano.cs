using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TesteDeDano : MonoBehaviour
{
    public int vida = 100;
    bool vivo;

    void Update()
    {
        vivo = vida > 0;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int dano = Random.Range(0, 11);
            AplicarDano(dano);
        }
    }
    void AplicarDano(int dano)
    {
        if (!vivo)
        {
            return;
        }

        vida -= dano;
        Debug.Log("Vida atual: " + vida);
    }
}
