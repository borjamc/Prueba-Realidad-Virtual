using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRGrabInteractableGlowingBall : XRGrabInteractable
{

    private float maxDistanceToRespawn = 5;
    [SerializeField] Transform spawnPoint;
    private bool hasRespawnAnotherBall = false;

    private void Start()
    {
        spawnPoint = transform.parent;
    }

    private void Update()
    {
        if ((Vector3.Distance(spawnPoint.position, transform.position) > maxDistanceToRespawn) && !hasRespawnAnotherBall)
        {
            spawnPoint.gameObject.GetComponent<RespawnBall>().SpawnBall();
            hasRespawnAnotherBall = true;
        }
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        this.gameObject.GetComponent<Rigidbody>().useGravity = true;
        transform.parent = null;
        base.OnSelectExited(args);
    }

}
