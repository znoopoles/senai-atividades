using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public int vida=100;
    public float velocidade=100;

    Rigidbody2D rigidbody2D;

    void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxis("Horizontal");
        Vector2 direcao = new Vector2(inputX, 0);

        rigidbody2D.linearVelocity = direcao*velocidade*Time.fixedDeltaTime;
    }
}
