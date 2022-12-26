using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class ActivateTeleportationRay : MonoBehaviour
{
    public GameObject leftTeleportation;
    public GameObject rightTeleportation;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    public InputActionProperty leftCancel;
    public InputActionProperty rightCancel;

    [SerializeField] XRRayInteractor leftRay;
    [SerializeField] XRRayInteractor rightRay;


    private void Update()
    {

        bool isLeftRayHevering = leftRay.TryGetHitInfo(out Vector3 leftPos, out Vector3 leftNormal, out int leftNumber, out bool leftValid);

        leftTeleportation.SetActive(!isLeftRayHevering && leftActivate.action.ReadValue<float>() > 0.1f && leftCancel.action.ReadValue<float>() == 0);

        bool isRightRayHevering = rightRay.TryGetHitInfo(out Vector3 rightPos, out Vector3 rightNormal, out int rightNumber, out bool rightValid);

        rightTeleportation.SetActive(!isRightRayHevering && rightActivate.action.ReadValue<float>() > 0.1f && rightCancel.action.ReadValue<float>() == 0);
    }
}
