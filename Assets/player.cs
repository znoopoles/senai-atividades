using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public string nome;
    public int vida=100;
    public float velocidade=100;
    public float pulo = 20;
    Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2D.velocity = Vector2.up * pulo;
        }
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        float velocidadeX = inputX*velocidade*Time.fixedDeltaTime;
        Vector2 direcao = new Vector2(velocidadeX, rigidbody2D.velocity.y);

        rigidbody2D.velocity = direcao;
    }

    public void TomarDano(int dano)
    {
        vida -= dano;
    }
}
