using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AbrirCaja : MonoBehaviour
{
    XRGrabInteractable a;
    void Start()
    {
        a = this.GetComponent<XRGrabInteractable>();
        a.enabled = false;
    }

    public void Opened()
    {
        a.enabled = true;
    }
}
