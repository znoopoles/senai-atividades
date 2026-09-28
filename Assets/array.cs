using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    public string[] Inventario = new string[5];

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            MostrarInventario();
        }
    }

    void MostrarInventario()
    {
        foreach (string item in Inventario)
        {
            Debug.Log(item);
        }
    }
}
