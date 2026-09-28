using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
   public enum Itens
    {
        ChaveDeFenda,
        FitaCola,
        Barulhenta,
        RelogioDePendulo
    }
   
    Dictionary<Itens, int> precosLoja = new Dictionary<Itens, int>();

    void Start()
    {
        precosLoja.Add(Itens.ChaveDeFenda, 15);
        precosLoja.Add(Itens.FitaCola, 7);
        precosLoja.Add(Itens.Barulhenta, 250);
        precosLoja.Add(Itens.RelogioDePendulo, 2000);

        int precoBarulhenta = precosLoja[Itens.Barulhenta];

        precosLoja[Itens.Barulhenta] = 150;

        if (precosLoja.ContainsKey(Itens.ChaveDeFenda))
        {
            int precoChaveDeFenda = precosLoja[Itens.ChaveDeFenda];
        }

        precosLoja.Remove(Itens.RelogioDePendulo);

        foreach (KeyValuePair<Itens, int> item in precosLoja)
        {
            Debug.Log("Item: " + item.Key + ", Preço: " + item.Value);
        }
    }
}
