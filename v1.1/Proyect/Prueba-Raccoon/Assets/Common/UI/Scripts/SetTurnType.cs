using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SetTurnType : MonoBehaviour
{

    [SerializeField] ActionBasedSnapTurnProvider snapTurn;
    [SerializeField] ActionBasedContinuousTurnProvider continuousTurn;

    [SerializeField] TeleportationProvider teleportationProvider;
    [SerializeField] ActivateTeleportationRay activateTeleportationRay;
    [SerializeField] ContinuousMoveProviderBase continuousMoveProvider;

    [SerializeField] GameObject settingsPanel;
    [SerializeField] GameObject objectivePanel;

    public void SetTurnTypeFromIndex(int index)
    {
        if (index == 0)
        {
            snapTurn.enabled = false;
            continuousTurn.enabled = true;
        }
        else if (index == 1)
        {
            snapTurn.enabled = true;
            continuousTurn.enabled = false;
        }
    }

    public void SetMovementTypeFromIndex(int index)
    {
        if (index == 0)
        {
            teleportationProvider.enabled = false;
            activateTeleportationRay.enabled = false;
            continuousMoveProvider.enabled = true;
        }
        else if (index == 1)
        {
            teleportationProvider.enabled = true;
            activateTeleportationRay.enabled = true;
            continuousMoveProvider.enabled = false;
        }
    }

    public void SetSettingsPanel()
    {
        objectivePanel.SetActive(false);
        settingsPanel.SetActive(true);
    }

    public void SetObjectivePanel()
    {
        objectivePanel.SetActive(true);
        settingsPanel.SetActive(false);
    }



}
