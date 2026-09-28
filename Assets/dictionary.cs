using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dictionary : MonoBehaviour
{
    Dictionary<string, int> precosLoja = new Dictionary<string, int>();

    void Start()
    {
        precosLoja.Add("Chave de fenda", 15);
        precosLoja.Add("Fita-cola", 7);
        precosLoja.Add("Barulhenta", 250);
        precosLoja.Add("Relógio de pêndulo", 2000);

        int precoBarulhenta = precosLoja["Barulhenta"];

        precosLoja["Barulhenta"] = 150;

        if (precosLoja.ContainsKey("Chave de fenda"))
        {
            int precoChaveDeFenda = precosLoja["Chave de fenda"];
        }

        precosLoja.Remove("Relógio de pêndulo");

        foreach (KeyValuePair<string, int> item in precosLoja)
        {
            Debug.Log("Item: " + item.Key + ", Preço: " + item.Value);
        }
    }
}
