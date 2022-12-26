using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candado : MonoBehaviour
{
    public AbrirCaja caja;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Bullet(Clone)")
        {
            caja.Opened();
            Destroy(this.gameObject);
        }
    }
}
