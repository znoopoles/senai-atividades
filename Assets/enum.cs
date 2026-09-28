using System.Collections.Generic;
using UnityEngine;

public enum Ataque
{
    Soco,
    Chute,
    Voadora,
    Banda,
    Cabeçada
}

public class Combo : MonoBehaviour
{
    public List<Ataque> sequenciaGolpes = new List<Ataque>();

    void Start()
    {
        foreach (Ataque ataque in sequenciaGolpes)
        {
            Debug.Log("Ataque: " + ataque);
        }
    }
}
