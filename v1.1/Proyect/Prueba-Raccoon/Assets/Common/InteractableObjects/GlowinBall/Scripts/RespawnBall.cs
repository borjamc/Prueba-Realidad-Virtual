using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnBall : MonoBehaviour
{
    [SerializeField] GameObject glowingBallPrefab;
    public void SpawnBall()
    {
        Instantiate(glowingBallPrefab, this.gameObject.transform);
    }
}
