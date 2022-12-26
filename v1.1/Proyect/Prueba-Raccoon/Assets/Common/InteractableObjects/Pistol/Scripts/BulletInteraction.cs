using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletInteraction : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Candado")
        {
            Destroy(collision.gameObject);
        }
    }
}
