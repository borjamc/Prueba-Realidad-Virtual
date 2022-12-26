using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LeverActivated : MonoBehaviour
{
    [SerializeField] GameObject pared;
    [SerializeField] TextMeshProUGUI canvasText;
    public void LeverHasBeenActivated()
    {
        Debug.Log("pasa");
        pared.SetActive(false);
        canvasText.text = "Oyes un muro moviendose, encuentra la salida";
    }
}
