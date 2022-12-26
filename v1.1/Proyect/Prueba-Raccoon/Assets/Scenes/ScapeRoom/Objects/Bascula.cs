using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Bascula : MonoBehaviour
{

    private int pesoEnLaBascula = 0;
    [SerializeField] TextMeshProUGUI textWeight;
    [SerializeField] GameObject frame;

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<WeightObjects>() != null)
        {
            pesoEnLaBascula += other.GetComponent<WeightObjects>().weight;
            textWeight.text = pesoEnLaBascula.ToString() + " KG";
            if (pesoEnLaBascula == 26)
            {
                frame.SetActive(false);
            }
            else
            {
                frame.SetActive(true);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<WeightObjects>() != null)
        {
            pesoEnLaBascula -= other.GetComponent<WeightObjects>().weight;
            textWeight.text = pesoEnLaBascula.ToString() + " KG";
            if (pesoEnLaBascula == 26)
            {
                frame.SetActive(false);
            }
            else
            {
                frame.SetActive(true);
            }
        }
    }

}
