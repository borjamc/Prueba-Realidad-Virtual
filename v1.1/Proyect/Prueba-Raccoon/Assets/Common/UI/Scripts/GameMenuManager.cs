using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.XR.Interaction.Toolkit;

public class GameMenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] InputActionProperty showButton;

    private void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }


}
