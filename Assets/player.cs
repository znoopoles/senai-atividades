using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public string nome;
    public int vida=100;
    public float velocidade=100;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector2 direcao = new Vector2(inputX, 0);

        GetComponent<Rigidbody2D>().linearVelocity = direcao*velocidade*Time.fixedDeltaTime;
    }
}
